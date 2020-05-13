using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itsppisapi.Models
{
	public class PLR006ReportModel
	{
		public string DEP_NAME { get; set; }
		public string MUNIT { get; set; }
		public string DEPT_CODE { get; set; }
		public string L_TIME { get; set; }
		public string L_SAMPLE_NAME { get; set; }
		public string L_ATTRIBUTE_NAME { get; set; }
		public string L_VALUE { get; set; }
		public decimal L_MIN_LIMIT { get; set; }
		public decimal L_MAX_LIMIT { get; set; }
		public string L_REPORT_NAME { get; set; }
		public decimal L_SAMPLE_PRINT_SEQ { get; set; }
		public decimal L_REP_PRINT_SEQ { get; set; }
		public string L_TRANS_DATE { get; set; }
		public string NEW_TIME { get; set; }
	}
}
