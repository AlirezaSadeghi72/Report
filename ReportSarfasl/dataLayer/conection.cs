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
        private List<sarfasls> _getSarfaslses(DbAtiran2Entities context, Expression<Func<sarfasls, bool>> where = null)
        {
            IQueryable<sarfasls> result = context.Set<sarfasls>();
            if (where != null)
            {
                result = result.Where(where);
            }

            return result.ToList();

        }

        private List<zirsarfasls> _getZirSarfasls(DbAtiran2Entities context, Expression<Func<zirsarfasls, bool>> where = null)
        {
            IQueryable<zirsarfasls> result = context.Set<zirsarfasls>();
            if (where != null)
            {
                result = result.Where(where);
            }

            return result.Include(s => s.sarfasls).ToList();
        }

        private List<act_zirsarfasls> _getActZirSarfasls(DbAtiran2Entities context, Expression<Func<act_zirsarfasls, bool>> where = null)
        {
            IQueryable<act_zirsarfasls> result = context.Set<act_zirsarfasls>();
            if (where != null)
            {
                result = result.Where(where);
            }

            return result.Include(s => s.zirsarfasls).ToList();

        }

        public List<sarfasls> GetSarfaslses(Expression<Func<sarfasls, bool>> where = null)
        {
            using (var context = new DbAtiran2Entities())
            {
                return _getSarfaslses(context, where);
            }
        }
        public List<zirsarfasls> GetZirSarfasls(Expression<Func<zirsarfasls, bool>> where = null)
        {
            using (var context = new DbAtiran2Entities())
            {
                return _getZirSarfasls(context, where);
            }
        }
        public List<act_zirsarfasls> GetActZirSarfasls(Expression<Func<act_zirsarfasls, bool>> where = null)
        {
            using (var context = new DbAtiran2Entities())
            {
                return _getActZirSarfasls(context, where);
            }
        }
        public decimal manSarfasls(int sarfaslID)
        {
            using (var context = new DbAtiran2Entities())
            {
                List<zirsarfasls> zs = _getZirSarfasls(context, z => z.rdf_sarfasl == sarfaslID);
                List<act_zirsarfasls> azs = _getActZirSarfasls(context, a => zs.Select(z => z.rdf).ToList().Contains(a.rdf_zirsarfasls));
                return azs.Any() ? azs.Sum(a => a.bed - a.bes) : 0;
            }
        }
        public decimal manZirSarfasls(int zirSarfaslID)
        {
            using (var context = new DbAtiran2Entities())
            {
                List<act_zirsarfasls> azs = _getActZirSarfasls(context, a => a.rdf_zirsarfasls == zirSarfaslID);
                return azs.Any() ? azs.Sum(a => a.bed - a.bes) : 0;
            }
        }
    }
}
