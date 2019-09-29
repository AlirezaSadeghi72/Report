using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReportSarfasl.dataLayer
{
    public class conection
    {
        #region private
        private static List<sarfasls> _getSarfaslses(DbAtiran2Entities context, Expression<Func<sarfasls, bool>> where = null)
        {
            IQueryable<sarfasls> result = context.Set<sarfasls>();
            if (where != null)
            {
                result = result.Where(where);
            }

            return result.ToList();

        }
        private static List<zirsarfasls> _getZirSarfasls(DbAtiran2Entities context, Expression<Func<zirsarfasls, bool>> where = null)
        {
            IQueryable<zirsarfasls> result = context.Set<zirsarfasls>();
            if (where != null)
            {
                result = result.Where(where);
            }

            return result.ToList();
        }
        private static List<act_zirsarfasls> _getActZirSarfasls(DbAtiran2Entities context, Expression<Func<act_zirsarfasls, bool>> where = null)
        {
            IQueryable<act_zirsarfasls> result = context.Set<act_zirsarfasls>();
            if (where != null)
            {
                result = result.Where(where);
            }

            return result.ToList();

        }
        #endregion

        #region public
        public static List<sarfasls> GetSarfaslses(Expression<Func<sarfasls, bool>> where = null)
        {
            using (var context = new DbAtiran2Entities())
            {
                return _getSarfaslses(context, where);
            }
        }
        public static List<zirsarfasls> GetZirSarfasls(Expression<Func<zirsarfasls, bool>> where = null)
        {
            using (var context = new DbAtiran2Entities())
            {
                return _getZirSarfasls(context, where);
            }
        }
        public static List<act_zirsarfasls> GetActZirSarfasls(Expression<Func<act_zirsarfasls, bool>> where = null)
        {
            using (var context = new DbAtiran2Entities())
            {
                return _getActZirSarfasls(context, where);
            }
        }

        public static List<viewSarfasls> GetViewSarfaslses(List<int> sarfaslID, List<int> zirsarfaslID)
        {
            IQueryable<viewSarfasls> result;

            using (var context = new DbAtiran2Entities())
            {
                //AsNoTracking()
                IQueryable<zirsarfasls> result_z = context.zirsarfasls;
                IQueryable<sarfasls> result_s = context.sarfasls;
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
                    .Join(result_s.ToList(), az => az.z.rdf_sarfasl, s => s.rdf, (az, s) => new { az, s }).GroupBy(r2=>r2.s.rdf).Select(
                        r =>
                            new viewSarfasls()
                            {
                                rdf = r.Key,
                                name = r.Select(r1 => r1.s.name).First(),
                                Active = r.Select(r1 => r1.s.Active).First(),
                                start_date = r.Select(r1 => r1.s.start_date).First(),
                                GroupSarfaslID = r.Select(r1 => r1.s.GroupSarfaslID).First(),
                                has_dar = r.Select(r1 => r1.s.has_dar).First(),
                                who_def = r.Select(r1=>r1.s.who_def).First(),
                                men = r.Sum(r1=>r1.az.a.bed - r1.az.a.bes)
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
                List<zirsarfasls> zs = _getZirSarfasls(context, z => z.rdf_sarfasl == sarfaslID);
                List<act_zirsarfasls> azs = _getActZirSarfasls(context,
                    a => zs.Select(z => z.rdf).ToList().Contains(a.rdf_zirsarfasls));
                return azs.Any() ? azs.Sum(a => a.bed - a.bes) : 0;
            }
        }

        public static decimal manZirSarfasls(int zirSarfaslID)
        {
            using (var context = new DbAtiran2Entities())
            {
                List<act_zirsarfasls> azs = _getActZirSarfasls(context, a => a.rdf_zirsarfasls == zirSarfaslID);
                return azs.Any() ? azs.Sum(a => a.bed - a.bes) : 0;
            }
        }
        #endregion

        public static IEnumerable<T> get<T>(Expression<Func<T, bool>> where = null) where T : class
        {
            using (var context = new DbAtiran2Entities())
            {
                IQueryable<T> result = context.Set<T>();
                if (where != null)
                {
                    result = result.Where(where);
                }

                return result.ToList();
            }
        }
    }
}
