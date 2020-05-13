using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace cfclapi.Models
{
    public class PLS002Model
    {
        public string L_SAMPLE_NAME { get; set; }
        public string L_ATTRIBUTE_NAME { get; set; }
        public decimal L_SAMPLE_PRINT_SEQ { get; set; }
        public string L_ACTIVE_FLAG { get; set; }
        public decimal L_MIN_LIMIT { get; set; }
        public decimal L_MAX_LIMIT { get; set; }
        public string L_MEAS_UNIT { get; set; }
        public string DSP_L_REPORT_NAME { get; set; }
        public decimal L_REPORT_ID { get; set; }
    }
}