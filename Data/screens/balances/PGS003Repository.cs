using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Models;
using itsppisapi.Dtos;

namespace itsppisapi.Data
{
    public class PGS003Repository
    {
        private readonly string _connectionString;
        public PGS003Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private PGS003Model MapToValue(SqlDataReader reader)
        {
            return new PGS003Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                OU1_TRANS_DATE = reader["OU1_TRANS_DATE"].ToString(),
                OU1_UNIT_ID = reader["OU1_UNIT_ID"].ToString(),
                OU1_DATE_MOD = reader["OU1_DATE_MOD"].ToString(),
                OU1_USER_ID = (decimal)reader["OU1_USER_ID"],
                OU1_USER_NAME = reader["OU1_USER_NAME"].ToString(),
                OU1_AB1_KS_PROD = (decimal)reader["OU1_AB1_KS_PROD"],
                OU1_AB2_KS_PROD = (decimal)reader["OU1_AB2_KS_PROD"],
                OU1_AB_KS_PROD = (decimal)reader["OU1_AB_KS_PROD"],
                OU1_KS_IMPORTF_UNIT2 = (decimal)reader["OU1_KS_IMPORTF_UNIT2"],
                OU1_TOTAL_KS_PROD = (decimal)reader["OU1_TOTAL_KS_PROD"],
                OU1_KS_HS_LETDOWN = (decimal)reader["OU1_KS_HS_LETDOWN"],
                OU1_KS_EXPORTT_PROCESS = (decimal)reader["OU1_KS_EXPORTT_PROCESS"],
                OU1_KS_CONSP_AMM = (decimal)reader["OU1_KS_CONSP_AMM"],
                OU1_KS_EXPORTT_UNIT2 = (decimal)reader["OU1_KS_EXPORTT_UNIT2"],
                OU1_KS_TOT_CONSP = (decimal)reader["OU1_KS_TOT_CONSP"],
                OU1_HS_HRSG1_PROD = (decimal)reader["OU1_HS_HRSG1_PROD"],
                OU1_HS_HRSG2_PROD = (decimal)reader["OU1_HS_HRSG2_PROD"],
                OU1_HRSG_HS_PROD = (decimal)reader["OU1_HRSG_HS_PROD"],
                OU1_HS_IMPORTF_UNIT2 = (decimal)reader["OU1_HS_IMPORTF_UNIT2"],
                OU1_TOTAL_HS_PROD = (decimal)reader["OU1_TOTAL_HS_PROD"],
                OU1_HS_CONSP_HPBFW = (decimal)reader["OU1_HS_CONSP_HPBFW"],
                OU1_HS_CONSP_MPBFW = (decimal)reader["OU1_HS_CONSP_MPBFW"],
                OU1_HS_CONSP_FD1 = (decimal)reader["OU1_HS_CONSP_FD1"],
                OU1_HS_CONSP_FD2 = (decimal)reader["OU1_HS_CONSP_FD2"],
                OU1_HS_CONSP_CTT = (decimal)reader["OU1_HS_CONSP_CTT"],
                OU1_HS_CONSP_PWT = (decimal)reader["OU1_HS_CONSP_PWT"],
                OU1_HS_CONSP_NPT = (decimal)reader["OU1_HS_CONSP_NPT"],
                OU1_HS_CONSP_ATOMIZING = (decimal)reader["OU1_HS_CONSP_ATOMIZING"],
                OU1_HS_LS_LETDOWN = (decimal)reader["OU1_HS_LS_LETDOWN"],
                OU1_HS_INTERNAL_CONSP = (decimal)reader["OU1_HS_INTERNAL_CONSP"],
                OU1_HS_EXPORTT_UNIT2 = (decimal)reader["OU1_HS_EXPORTT_UNIT2"],
                OU1_HS_EXPORT_PROCESS = (decimal)reader["OU1_HS_EXPORT_PROCESS"],
                OU1_HS_CONSP_AMM = (decimal)reader["OU1_HS_CONSP_AMM"],
                OU1_HS_TOT_CONSP = (decimal)reader["OU1_HS_TOT_CONSP"],
                OU1_LS_INTERNAL_PROD = (decimal)reader["OU1_LS_INTERNAL_PROD"],
                OU1_LS_IMPORTF_UNIT2 = (decimal)reader["OU1_LS_IMPORTF_UNIT2"],
                OU1_TOTAL_LS_PROD = (decimal)reader["OU1_TOTAL_LS_PROD"],
                OU1_LS_CONSP_DEARATOR = (decimal)reader["OU1_LS_CONSP_DEARATOR"],
                OU1_LS_EXPORTT_UNIT2 = (decimal)reader["OU1_LS_EXPORTT_UNIT2"],
                OU1_LS_EXPORTT_PROCESS = (decimal)reader["OU1_LS_EXPORTT_PROCESS"],
                OU1_LS_CONSP_AMM = (decimal)reader["OU1_LS_CONSP_AMM"],
                OU1_LS_TOT_CONSP = (decimal)reader["OU1_LS_TOT_CONSP"],
                OU1_KS_CONSP_U11 = (decimal)reader["OU1_KS_CONSP_U11"],
                OU1_KS_CONSP_U21 = (decimal)reader["OU1_KS_CONSP_U21"],
                OU1_KS_CONSP_UREA = (decimal)reader["OU1_KS_CONSP_UREA"],
                OU1_HS_CONSP_UREA = (decimal)reader["OU1_HS_CONSP_UREA"],
                OU1_LS_CONSP_UREA = (decimal)reader["OU1_LS_CONSP_UREA"],
                OU1_HS_CONSP_UCT = (decimal)reader["OU1_HS_CONSP_UCT"],
                OU1_HS_CONSP_ACT = (decimal)reader["OU1_HS_CONSP_ACT"],
                OU1_HS_CONSP_PWT_GP2 = (decimal)reader["OU1_HS_CONSP_PWT_GP2"]
            };
        }

        public async Task<PGS003Model> putData(TriParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_STEAM_BAL_PGS003", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_FROM_DATE", value.StringParameter1));
                    cmd.Parameters.Add(new SqlParameter("@IN_TO_DATE", value.StringParameter2));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    PGS003Model response = null;
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
