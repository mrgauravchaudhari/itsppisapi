using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PGS204Repository
    {
        private readonly string _connectionString;
        public PGS204Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private PGS204Model MapToValue(SqlDataReader reader)
        {
            return new PGS204Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                AM2_TRANS_DATE = reader["AM2_TRANS_DATE"].ToString(),
                AM2_RG_SH_PROD = (decimal)reader["AM2_RG_SH_PROD"],
                AM2_AB_SH_PROD = (decimal)reader["AM2_AB_SH_PROD"],
                AM2_IMP_FROM_GP1 = (decimal)reader["AM2_IMP_FROM_GP1"],
                AM2_TOTAL_SH_PROD = (decimal)reader["AM2_TOTAL_SH_PROD"],
                AM2_SH_CONSP_SYNGAS = (decimal)reader["AM2_SH_CONSP_SYNGAS"],
                AM2_SH_CONSP_AIRCOMP = (decimal)reader["AM2_SH_CONSP_AIRCOMP"],
                AM2_SH_CONSP_UREA2 = (decimal)reader["AM2_SH_CONSP_UREA2"],
                AM2_SH_EXPORTT_GPI = (decimal)reader["AM2_SH_EXPORTT_GPI"],
                AM2_SH_TOTAL_CONSP = (decimal)reader["AM2_SH_TOTAL_CONSP"],
                AM2_SYNGAS_EXTRACT_SM_PROD = (decimal)reader["AM2_SYNGAS_EXTRACT_SM_PROD"],
                AM2_AIRCOMP_EXTRCT_SM_PROD = (decimal)reader["AM2_AIRCOMP_EXTRCT_SM_PROD"],
                AM2_LETDOWN_FROM_SH = (decimal)reader["AM2_LETDOWN_FROM_SH"],
                AM2_TOTAL_SM_PROD = (decimal)reader["AM2_TOTAL_SM_PROD"],
                AM2_SM_CONSP_PSTEAM = (decimal)reader["AM2_SM_CONSP_PSTEAM"],
                AM2_SM_CONSP_REFCOMP = (decimal)reader["AM2_SM_CONSP_REFCOMP"],
                AM2_SM_CONSP_NGCOMP = (decimal)reader["AM2_SM_CONSP_NGCOMP"],
                AM2_SM_CONSP_BFW_PUMPA = (decimal)reader["AM2_SM_CONSP_BFW_PUMPA"],
                AM2_SM_CONSP_BFW_PUMPB = (decimal)reader["AM2_SM_CONSP_BFW_PUMPB"],
                AM2_SM_CONSP_SLPUMPA = (decimal)reader["AM2_SM_CONSP_SLPUMPA"],
                AM2_SM_CONSP_SLPUMPB = (decimal)reader["AM2_SM_CONSP_SLPUMPB"],
                AM2_SM_CONSP_LPUMP = (decimal)reader["AM2_SM_CONSP_LPUMP"],
                AM2_SM_CONSP_IDFAN = (decimal)reader["AM2_SM_CONSP_IDFAN"],
                AM2_SM_CONSP_FDFAN = (decimal)reader["AM2_SM_CONSP_FDFAN"],
                AM2_SM_CONSP_PACOIL = (decimal)reader["AM2_SM_CONSP_PACOIL"],
                AM2_SM_CONSP_H2SSTRIP = (decimal)reader["AM2_SM_CONSP_H2SSTRIP"],
                AM2_SM_CONSP_DISTCOL = (decimal)reader["AM2_SM_CONSP_DISTCOL"],
                AM2_SM_CONSP_ATOMIZING = (decimal)reader["AM2_SM_CONSP_ATOMIZING"],
                AM2_SM_LETDOWN_SL = (decimal)reader["AM2_SM_LETDOWN_SL"],
                AM2_SM_TOTAL_CONSP_AMM2 = (decimal)reader["AM2_SM_TOTAL_CONSP_AMM2"],
                AM2_SM_CONSP_AB = (decimal)reader["AM2_SM_CONSP_AB"],
                AM2_SM_CONSP_ABFDFAN = (decimal)reader["AM2_SM_CONSP_ABFDFAN"],
                AM2_ABSM_LETDOWN_ATOMIZING = (decimal)reader["AM2_ABSM_LETDOWN_ATOMIZING"],
                AM2_SM_CONSP_ACWPUMPA = (decimal)reader["AM2_SM_CONSP_ACWPUMPA"],
                AM2_SM_CONSP_ACWPUMPB = (decimal)reader["AM2_SM_CONSP_ACWPUMPB"],
                AM2_SM_CONSP_ACWPUMPC = (decimal)reader["AM2_SM_CONSP_ACWPUMPC"],
                AM2_SM_CONSP_UCWPUMPA = (decimal)reader["AM2_SM_CONSP_UCWPUMPA"],
                AM2_SM_CONSP_UCWPUMPB = (decimal)reader["AM2_SM_CONSP_UCWPUMPB"],
                AM2_SM_CONSP_UCWPUMPC = (decimal)reader["AM2_SM_CONSP_UCWPUMPC"],
                AM2_SM_CONSP_CTTCPUMP = (decimal)reader["AM2_SM_CONSP_CTTCPUMP"],
                AM2_SM_TOTAL_CONSP_UTIL = (decimal)reader["AM2_SM_TOTAL_CONSP_UTIL"],
                AM2_SM_TOTAL_CONSP_GPII = (decimal)reader["AM2_SM_TOTAL_CONSP_GPII"],
                AM2_SL_INTERNAL_PROD = (decimal)reader["AM2_SL_INTERNAL_PROD"],
                AM2_SM_LETDOWN_SL2 = (decimal)reader["AM2_SM_LETDOWN_SL2"],
                AM2_IMP_FROM_GP1_TAB4 = (decimal)reader["AM2_IMP_FROM_GP1_TAB4"],
                AM2_TOTAL_SL_PROD = (decimal)reader["AM2_TOTAL_SL_PROD"],
                AM2_SL_CONSP_AMMREF = (decimal)reader["AM2_SL_CONSP_AMMREF"],
                AM2_SL_CONSP_NAPPREHEAT = (decimal)reader["AM2_SL_CONSP_NAPPREHEAT"],
                AM2_SL_CONSP_RNAPPREHEAT = (decimal)reader["AM2_SL_CONSP_RNAPPREHEAT"],
                AM2_SL_CONSP_EJECTOR = (decimal)reader["AM2_SL_CONSP_EJECTOR"],
                AM2_SL_CONSP_MISC = (decimal)reader["AM2_SL_CONSP_MISC"],
                AM2_SL_TOTAL_CONSP = (decimal)reader["AM2_SL_TOTAL_CONSP"],
                AM2_DESUP_HTR_WATER = (decimal)reader["AM2_DESUP_HTR_WATER"]
            };
        }

        public async Task<PGS204Model> putData(TriParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_STEAM_BAL_PGS204", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_FROM_DATE", value.StringParameter1));
                    cmd.Parameters.Add(new SqlParameter("@IN_TO_DATE", value.StringParameter2));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    PGS204Model response = null;
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response = MapToValue(reader);
                        }
                    }
                    return response;
                }
            }
        }
    }
}
