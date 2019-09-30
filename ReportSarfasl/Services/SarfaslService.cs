﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSarfasl.Services
{
    public class SarfaslService
    {
        public int ID { get; set; }
        public int GroupSarfaslID { get; set; }
        public string Name { get; set; }
        public decimal Man { get; set; }
        public virtual List<ZirSarfaslService> ZirSarfasls { get; set; }
    }
}