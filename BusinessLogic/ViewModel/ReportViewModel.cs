using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BusinessLogic.ViewModel
{
    public class ReportViewModel
    {
        public string Name { get; set; }
        public DateTime DateCreate { get; set; }
        public string FIO { get; set; }
        public string Work { get; set; }
        public DateTime Birthday { get; set; }
    }
}
