using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cfclapi.Models
{
    public class PLR202ReportModel
    {
		public string l_trans_date { get; set; }
		public string l_TIME { get; set; }
		public decimal l_TEMP { get; set; }
		public decimal l_density { get; set; }
		public decimal l_density_15c { get; set; }
		public decimal l_br_no { get; set; }
		public decimal l_olefines { get; set; }
		public decimal l_aromatics { get; set; }
		public decimal l_ibp { get; set; }
		public decimal l_nra_50 { get; set; }
		public decimal l_nra_95 { get; set; }
		public decimal l_fbp { get; set; }
		public decimal l_ch_ratio { get; set; }
		public decimal l_gross_cv { get; set; }
		public decimal l_net_cv { get; set; }
		public decimal l_sulphur { get; set; }
		public decimal l_residue { get; set; }
		public decimal l_recovery { get; set; }


	}
}
