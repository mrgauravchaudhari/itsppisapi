using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace cfclapi.Models
{
    public class PLS009Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string L_REPORT_NAME { get; set; }
        public string L_SHIFT_NO { get; set; }
        public string L_TIME { get; set; }
        public string L_SAMPLE_NAME { get; set; }
        public string L_ATTRIBUTE_NAME { get; set; }
        public string L_VALUE { get; set; }     

    }
}
