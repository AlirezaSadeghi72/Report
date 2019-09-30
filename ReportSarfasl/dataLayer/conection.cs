using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ReportSarfasl.Services;

namespace ReportSarfasl.dataLayer
{
    public class conection
    {
        #region private
        private static List<SarfaslService> _getSarfaslses(DbAtiran2Entities context, Expression<Func<sarfasls, bool>> where = null)
        {
            IQueryable<sarfasls> result = context.Set<sarfasls>().AsNoTracking();
            if (where != null)
            {
                result = result.Where(where);
            }

            return result.Select(s => new SarfaslService()
            {
                ID = s.rdf,
                GroupSarfaslID = s.GroupSarfaslID,
                Name = s.name,
                ZirSarfasls = s.zirsarfasls.Select(z => new ZirSarfaslService()
                {
                    ID = z.rdf,
                    SarfaslID = z.rdf_sarfasl,
                    Name = z.name,
                    has_dar = z.has_dar,
                    Active = z.Active
                }).ToList()
            }).ToList();

        }
        private static List<ZirSarfaslService> _getZirSarfasls(DbAtiran2Entities context, Expression<Func<zirsarfasls, bool>> where = null)
        {
            IQueryable<zirsarfasls> result = context.Set<zirsarfasls>().AsNoTracking();
            if (where != null)
            {
                result = result.Where(where);
            }

            return result.Select(z => new ZirSarfaslService()
            {
                ID = z.rdf,
                SarfaslID = z.rdf_sarfasl,
                Name = z.name,
                has_dar = z.has_dar,
                Active = z.Active,
                sarfasls = new SarfaslService()
                {
                    ID = z.sarfasls.rdf,
                    GroupSarfaslID = z.sarfasls.GroupSarfaslID,
                    Name = z.sarfasls.name
                }
            }).ToList();
        }
        private static List<ActZirSarfaslService> _getActZirSarfasls(DbAtiran2Entities context, Expression<Func<act_zirsarfasls, bool>> where = null)
        {
            IQueryable<act_zirsarfasls> result = context.Set<act_zirsarfasls>().AsNoTracking();
            if (where != null)
            {
                result = result.Where(where);
            }

            return result.Select(a => new ActZirSarfaslService()
            {
                ID = a.rdf,
                ZirSarfaslID = a.rdf_zirsarfasls,
                date = a.date,
                bed = a.bed,
                bes = a.bes,
                bed_bes = a.bed_bes,
                description = a.dis,
                kind = a.kind,
                sanadno = a.sanadno,
                zirsarfasls = new ZirSarfaslService()
                {
                    ID = a.zirsarfasls.rdf,
                    SarfaslID = a.zirsarfasls.rdf_sarfasl,
                    Name = a.zirsarfasls.name,
                    has_dar = a.zirsarfasls.has_dar,
                    Active = a.zirsarfasls.Active,
                    sarfasls = new SarfaslService()
                    {
                        ID = a.zirsarfasls.sarfasls.rdf,
                        GroupSarfaslID = a.zirsarfasls.sarfasls.GroupSarfaslID,
                        Name = a.zirsarfasls.sarfasls.name
                    }
                }
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

        public static List<SarfaslService> GetViewSarfaslses(List<int> sarfaslID, List<int> zirsarfaslID)
        {
            IQueryable<SarfaslService> result;

            using (var context = new DbAtiran2Entities())
            {
                //AsNoTracking()
                IQueryable<zirsarfasls> result_z = context.zirsarfasls.AsNoTracking();
                IQueryable<sarfasls> result_s = context.sarfasls.AsNoTracking();
                if (zirsarfaslID.Count > 0)
                {
                    result_z = context.zirsarfasls.Where(z => zirsarfaslID.Contains(z.rdf));
                    //result_z = context.zirsarfasls.Where(z => zirsarfaslID.Any(a=>z.rdf_sarfasl==a));
                }
                else
                {
                    result_z = context.zirsarfasls;
                }

                if (sarfaslID.Any())
                {
                    result_s = context.sarfasls.Where(s => sarfaslID.Contains(s.rdf));
                }
                else
                {
                    result_s = context.sarfasls;
                }

                result = context.act_zirsarfasls.Join(result_z.ToList(), a => a.rdf_zirsarfasls, z => z.rdf,
                        (a, z) => new { a, z })
                    .Join(result_s.ToList(), az => az.z.rdf_sarfasl, s => s.rdf, (az, s) => new { az, s }).GroupBy(r2 => r2.s.rdf).Select(
                        r =>
                            new SarfaslService()
                            {
                                ID = r.Key,
                                Name = r.Select(r1 => r1.s.name).First(),
                                GroupSarfaslID = r.Select(r1 => r1.s.GroupSarfaslID).First(),
                                Man = r.Sum(r1 => r1.az.a.bed - r1.az.a.bes)
                            });
            }

            //return (from read in result select new SarfaslService
            //{
            //    GroupSarfaslID = read.GroupSarfaslID
            //}).ToList();
            return result.ToList();
        }

        public static decimal manSarfasls(int sarfaslID)
        {
            using (var context = new DbAtiran2Entities())
            {
                List<ZirSarfaslService> zs = _getZirSarfasls(context, z => z.rdf_sarfasl == sarfaslID);
                List<ActZirSarfaslService> azs = _getActZirSarfasls(context,
                    a => zs.Select(z => z.ID).ToList().Contains(a.rdf_zirsarfasls));
                return azs.Any() ? azs.Sum(a => a.bed - a.bes) : 0;
            }
        }

        public static decimal manZirSarfasls(int zirSarfaslID)
        {
            using (var context = new DbAtiran2Entities())
            {
                List<ActZirSarfaslService> azs = _getActZirSarfasls(context, a => a.rdf_zirsarfasls == zirSarfaslID);
                return azs.Any() ? azs.Sum(a => a.bed - a.bes) : 0;
            }
        }
        #endregion

        public static IEnumerable<T> get<T>(Expression<Func<T, bool>> where = null) where T : class
        {
            using (var context = new DbAtiran2Entities())
            {
                IQueryable<T> result = context.Set<T>().AsNoTracking();
                if (where != null)
                {
                    result = result.Where(where);
                }

                return result.ToList();
            }
        }
    }
}
