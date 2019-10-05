using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using ReportSarfasl.Services;

namespace ReportSarfasl.dataLayer
{
    public static class conection
    {
        #region private

        private static List<SarfaslService> _getSarfaslses(DbAtiran2Entities context,
            Expression<Func<sarfasls, bool>> where = null)
        {
            IQueryable<sarfasls> result = context.Set<sarfasls>().AsNoTracking();
            if (where != null)
            {
                result = result.Where(where);
            }

            int Row = 1;
            return result.ToList().Select(s => new SarfaslService()
            {
                row = Row++,
                ID = s.rdf,
                GroupSarfaslID = s.GroupSarfaslID,
                Name = s.name
            }).ToList();

        }

        private static List<ZirSarfaslService> _getZirSarfasls(DbAtiran2Entities context,
            Expression<Func<zirsarfasls, bool>> where = null)
        {
            IQueryable<zirsarfasls> result = context.Set<zirsarfasls>().AsNoTracking();
            if (where != null)
            {
                result = result.Where(where);
            }

            int Row = 1;
            return result.ToList().Select(z => new ZirSarfaslService()
            {
                row = Row++,
                ID = z.rdf,
                SarfaslID = z.rdf_sarfasl,
                Name = z.name,
                has_dar = z.has_dar,
                Active = z.Active
            }).ToList();
        }

        private static List<ActZirSarfaslService> _getActZirSarfasls(DbAtiran2Entities context,
            Expression<Func<act_zirsarfasls, bool>> where = null)
        {
            IQueryable<act_zirsarfasls> result = context.Set<act_zirsarfasls>().AsNoTracking();
            if (where != null)
            {
                result = result.Where(where);
            }

            int Row = 1;
            return result.ToList().Select(a => new ActZirSarfaslService()
            {
                row = Row++,
                ID = a.rdf,
                ZirSarfaslID = a.rdf_zirsarfasls,
                date = a.date,
                bed = a.bed,
                bes = a.bes,
                bed_bes = a.bed_bes,
                description = a.dis,
                kind = a.kind,
                sanadno = a.sanadno
            }).ToList();

        }

        #endregion

        #region public

        public static List<SarfaslService> GetSarfaslses(Expression<Func<sarfasls, bool>> where = null)
        {
            using (var context = new DbAtiran2Entities())
            {
                return _getSarfaslses(context, where);
            }
        }

        public static List<ZirSarfaslService> GetZirSarfasls(Expression<Func<zirsarfasls, bool>> where = null)
        {
            using (var context = new DbAtiran2Entities())
            {
                return _getZirSarfasls(context, where);
            }
        }

        public static List<ActZirSarfaslService> GetActZirSarfasls(Expression<Func<act_zirsarfasls, bool>> where = null)
        {
            using (var context = new DbAtiran2Entities())
            {
                return _getActZirSarfasls(context, where);
            }
        }

        public static List<SarfaslService> GetSarfaslseServis(List<int> listSarfaslID, List<int> listZirsarfaslID , string FromDate , string ToDate)
        {

            using (var context = new DbAtiran2Entities())
            {
                var result = context.act_zirsarfasls.AsNoTracking().Join(context.zirsarfasls.AsNoTracking(),
                    a => a.rdf_zirsarfasls,
                    z => z.rdf,
                    (a, z) => new { a, z }).Join(context.sarfasls.AsNoTracking(), az => az.z.rdf_sarfasl, s => s.rdf,
                    (az, s) => new { az, s });

                if (listZirsarfaslID.Any())
                {
                    result = result.Where(r => listZirsarfaslID.Contains(r.az.z.rdf));
                }

                if (listSarfaslID.Any())
                {
                    result = result.Where(r => listSarfaslID.Contains(r.s.rdf));
                }
                else if (listZirsarfaslID.Any())
                {
                    listSarfaslID = context.zirsarfasls.Where(z => listZirsarfaslID.Contains(z.rdf))
                        .GroupBy(z => z.rdf_sarfasl).Select(z => z.Key).ToList();
                }
                else
                {
                    listSarfaslID = context.sarfasls.Select(s => s.rdf).ToList();
                }

                result = result.Where(r => r.az.a.date.CompareTo(FromDate) >= 0 && r.az.a.date.CompareTo(ToDate) <= 0);
                
                //var ali = result.GroupBy(r2 => r2.s.rdf).Select(
                //    g => new
                //{
                //    sarfasl = g.Select(r=>r.s),
                //    man = g.Sum(r1 => r1.az.a.bed - r1.az.a.bes)
                //    }).ToList();
                int Row = 1;
                var result1 = result.GroupBy(r2 => new { r2.s }).ToList().Select(
                    g => new SarfaslService()
                    {
                        row = Row++,
                        ID = g.Key.s.rdf,
                        Name = g.Key.s.name,
                        GroupSarfaslID = g.Key.s.GroupSarfaslID,
                        Man = g.Sum(r1 => r1.az.a.bed - r1.az.a.bes)
                    }).ToList();

                if (listSarfaslID.Count > result1.Count)
                {
                    var Sarfasls = context.sarfasls.AsNoTracking().ToList();

                    foreach (int id in listSarfaslID)
                    {
                        if (!result1.Any(r => r.ID == id))
                        {
                            var Safasl = Sarfasls.First(s => s.rdf == id);
                            result1.Add(new SarfaslService()
                            {
                                row = result1.Count + 1,
                                ID = Safasl.rdf,
                                Name = Safasl.name,
                                GroupSarfaslID = Safasl.GroupSarfaslID,
                                Man = 0
                            });
                        }
                    }
                }

                return result1;
            }

            //return (from read in result select new SarfaslService
            //{
            //    GroupSarfaslID = read.GroupSarfaslID
            //}).ToList();
        }

        public static List<ZirSarfaslService> GetZirSarfaslServices(List<int> listZirsarfaslID, int sarfaslID, string FromDate , string ToDate)
        {
            using (var context = new DbAtiran2Entities())
            {
                var result = context.act_zirsarfasls.AsNoTracking().Join(context.zirsarfasls.AsNoTracking(),
                    a => a.rdf_zirsarfasls,
                    z => z.rdf,
                    (a, z) => new { a, z }).Where(az => az.z.rdf_sarfasl == sarfaslID).Where(az => az.z.rdf_sarfasl == sarfaslID);

                var ZirsarfaslID = context.zirsarfasls.AsNoTracking().Where(z => z.rdf_sarfasl == sarfaslID).Select(z => z.rdf).ToList();

                if (listZirsarfaslID.Any())
                {
                    listZirsarfaslID = listZirsarfaslID.Where(z => ZirsarfaslID.Contains(z)).ToList();
                    if (listZirsarfaslID.Any())
                    {
                        result = result.Where(az => listZirsarfaslID.Contains(az.z.rdf));
                    }
                    else
                    {
                        result = result.Where(az => az.z.rdf == null);
                        listZirsarfaslID = ZirsarfaslID;
                    }
                }
                else
                {
                    listZirsarfaslID = ZirsarfaslID;
                }

                result = result.Where(r => r.a.date.CompareTo(FromDate) >= 0 && r.a.date.CompareTo(ToDate) <= 0);

                //var ali = result.GroupBy(r2 => new { r2.z }).ToList();
                int Row = 1;
                var result1 = result.GroupBy(r2 => new { r2.z }).ToList().Select(
                    g => new ZirSarfaslService()
                    {
                        row = Row++,
                        ID = g.Key.z.rdf,
                        Name = g.Key.z.name,
                        SarfaslID = g.Key.z.rdf_sarfasl,
                        Active = g.Key.z.Active,
                        has_dar = g.Key.z.has_dar,
                        Man = g.Sum(r1 => r1.a.bed - r1.a.bes)
                    }).ToList();

                if (listZirsarfaslID.Count > result1.Count)
                {
                    var ZirSarfasls = context.zirsarfasls.AsNoTracking().ToList();

                    foreach (int id in listZirsarfaslID)
                    {
                        if (!result1.Any(r => r.ID == id))
                        {
                            var ZirSafasl = ZirSarfasls.First(z => z.rdf == id);
                            result1.Add(new ZirSarfaslService()
                            {
                                row = result1.Count + 1,
                                ID = ZirSafasl.rdf,
                                Name = ZirSafasl.name,
                                SarfaslID = ZirSafasl.rdf_sarfasl,
                                Active = ZirSafasl.Active,
                                has_dar = ZirSafasl.has_dar,
                                Man = 0
                            });
                        }
                    }
                }

                return result1;
            }
        }
        public static List<ActZirSarfaslService> GetActZirSarfaslServices(string FromDate,string ToDate,int zirSarfaslID = -1, int sarfaslID = -1, List<int> listZirsarfasl = null )
        {
            using (var context = new DbAtiran2Entities())
            {
                if (zirSarfaslID != -1)
                    return _getActZirSarfasls(context, a => a.rdf_zirsarfasls == zirSarfaslID && a.date.CompareTo(FromDate) >= 0 && a.date.CompareTo(ToDate) <= 0);

                if (sarfaslID != -1)
                {
                    var ZirsarfaslID = context.zirsarfasls.AsNoTracking().Where(z => z.rdf_sarfasl == sarfaslID).Select(z => z.rdf).ToList();

                    if (listZirsarfasl.Any())
                    {
                        var listZirsarfasl1 = listZirsarfasl.Where(z => ZirsarfaslID.Contains(z)).ToList();
                        if (listZirsarfasl1.Any())
                        {
                            return _getActZirSarfasls(context, a => listZirsarfasl1.Contains(a.rdf_zirsarfasls) && a.date.CompareTo(FromDate) >= 0 && a.date.CompareTo(ToDate) <= 0);
                        }

                        return _getActZirSarfasls(context, a => listZirsarfasl.Contains(a.rdf_zirsarfasls) && a.date.CompareTo(FromDate) >= 0 && a.date.CompareTo(ToDate) <= 0);
                    }

                    return _getActZirSarfasls(context, a => ZirsarfaslID.Contains(a.rdf_zirsarfasls) && a.date.CompareTo(FromDate) >= 0 && a.date.CompareTo(ToDate) <= 0);
                }

                throw new NullReferenceException();
            }
        }

        //public static decimal manSarfasls(int sarfaslID)
        //{
        //    using (var context = new DbAtiran2Entities())
        //    {
        //        List<ZirSarfaslService> zs = _getZirSarfasls(context, z => z.rdf_sarfasl == sarfaslID);
        //        List<ActZirSarfaslService> azs = _getActZirSarfasls(context,
        //            a => zs.Select(z => z.ID).ToList().Contains(a.rdf_zirsarfasls));
        //        return azs.Any() ? azs.Sum(a => a.bed - a.bes) : 0;
        //    }
        //}

        //public static decimal manZirSarfasls(int zirSarfaslID)
        //{
        //    using (var context = new DbAtiran2Entities())
        //    {
        //        List<ActZirSarfaslService> azs = _getActZirSarfasls(context, a => a.rdf_zirsarfasls == zirSarfaslID);
        //        return azs.Any() ? azs.Sum(a => a.bed - a.bes) : 0;
        //    }
        //}

        #endregion

        //public static IEnumerable<T> get<T>(Expression<Func<T, bool>> where = null) where T : class
        //{
        //    using (var context = new DbAtiran2Entities())
        //    {
        //        IQueryable<T> result = context.Set<T>().AsNoTracking();
        //        if (where != null)
        //        {
        //            result = result.Where(where);
        //        }

        //        return result.ToList();
        //    }
        //}
    }
}
