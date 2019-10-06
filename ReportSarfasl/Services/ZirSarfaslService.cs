using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSarfasl.Services
{
    public class ZirSarfaslService
    {
        public int row { get; set; }
        public int ID { get; set; }
        public int SarfaslID { get; set; }
        public string Name { get; set; }
        public string has_dar { get; set; }
        public decimal Man { get; set; }
        public decimal bed { get; set; }
        public decimal bes { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}
