using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PAS216Repository
    {
        private readonly string _connectionString;
        public PAS216Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PAS216Model MapToValue(SqlDataReader reader)
        {
            return new PAS216Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                A_TRANS_DATE = reader["A_TRANS_DATE"].ToString(),
                A_USER_ID = (decimal)reader["A_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),
                A_DATE_MOD = reader["A_DATE_MOD"].ToString(),

                A_RIL_NOM = (decimal)reader["A_RIL_NOM"],
                A_RIL_SCHD = (decimal)reader["A_RIL_SCHD"],
                A_RIL_ALLOC = (decimal)reader["A_RIL_ALLOC"],
                A_RGTIL_ENT_NOM_NORM = (decimal)reader["A_RGTIL_ENT_NOM_NORM"],
                A_RGTIL_ENT_NOM_BAL = (decimal)reader["A_RGTIL_ENT_NOM_BAL"],
                A_RGTIL_ENT_NOM_TOT = (decimal)reader["A_RGTIL_ENT_NOM_TOT"],
                A_RGTIL_ENT_SCHD_NORM = (decimal)reader["A_RGTIL_ENT_SCHD_NORM"],
                A_RGTIL_ENT_SCHD_BAL = (decimal)reader["A_RGTIL_ENT_SCHD_BAL"],
                A_RGTIL_ENT_SCHD_TOT = (decimal)reader["A_RGTIL_ENT_SCHD_TOT"],
                A_RGTIL_ENT_ALLOC_NORM = (decimal)reader["A_RGTIL_ENT_ALLOC_NORM"],
                A_RGTIL_ENT_ALLOC_BAL = (decimal)reader["A_RGTIL_ENT_ALLOC_BAL"],
                A_RGTIL_ENT_ALLOC_TOT = (decimal)reader["A_RGTIL_ENT_ALLOC_TOT"],
                A_GAIL_DEL_NOM_NORM = (decimal)reader["A_GAIL_DEL_NOM_NORM"],
                A_GAIL_DEL_NOM_BAL = (decimal)reader["A_GAIL_DEL_NOM_BAL"],
                A_GAIL_DEL_NOM_TOT = (decimal)reader["A_GAIL_DEL_NOM_TOT"],
                A_GAIL_DEL_SCHD_NORM = (decimal)reader["A_GAIL_DEL_SCHD_NORM"],
                A_GAIL_DEL_SCHD_BAL = (decimal)reader["A_GAIL_DEL_SCHD_BAL"],
                A_GAIL_DEL_SCHD_TOT = (decimal)reader["A_GAIL_DEL_SCHD_TOT"],
                A_GAIL_DEL_ALLOC_NORM = (decimal)reader["A_GAIL_DEL_ALLOC_NORM"],
                A_GAIL_DEL_ALLOC_BAL = (decimal)reader["A_GAIL_DEL_ALLOC_BAL"],
                A_GAIL_DEL_ALLOC_TOT = (decimal)reader["A_GAIL_DEL_ALLOC_TOT"],
                A_RGTIL_EXT_NOM_NORM = (decimal)reader["A_RGTIL_EXT_NOM_NORM"],
                A_RGTIL_EXT_NOM_BAL = (decimal)reader["A_RGTIL_EXT_NOM_BAL"],
                A_RGTIL_EXT_NOM_TOT = (decimal)reader["A_RGTIL_EXT_NOM_TOT"],
                A_RGTIL_EXT_SCHD_NORM = (decimal)reader["A_RGTIL_EXT_SCHD_NORM"],
                A_RGTIL_EXT_SCHD_BAL = (decimal)reader["A_RGTIL_EXT_SCHD_BAL"],
                A_RGTIL_EXT_SCHD_TOT = (decimal)reader["A_RGTIL_EXT_SCHD_TOT"],
                A_RGTIL_EXT_ALLOC_NORM = (decimal)reader["A_RGTIL_EXT_ALLOC_NORM"],
                A_RGTIL_EXT_ALLOC_BAL = (decimal)reader["A_RGTIL_EXT_ALLOC_BAL"],
                A_RGTIL_EXT_ALLOC_TOT = (decimal)reader["A_RGTIL_EXT_ALLOC_TOT"],
                A_GAIL_REDEL_NOM_NORM = (decimal)reader["A_GAIL_REDEL_NOM_NORM"],
                A_GAIL_REDEL_NOM_BAL = (decimal)reader["A_GAIL_REDEL_NOM_BAL"],
                A_GAIL_REDEL_NOM_TOT = (decimal)reader["A_GAIL_REDEL_NOM_TOT"],
                A_GAIL_REDEL_SCHD_NORM = (decimal)reader["A_GAIL_REDEL_SCHD_NORM"],
                A_GAIL_REDEL_SCHD_BAL = (decimal)reader["A_GAIL_REDEL_SCHD_BAL"],
                A_GAIL_REDEL_SCHD_TOT = (decimal)reader["A_GAIL_REDEL_SCHD_TOT"],
                A_GAIL_REDEL_ALLOC_NORM = (decimal)reader["A_GAIL_REDEL_ALLOC_NORM"],
                A_GAIL_REDEL_ALLOC_BAL = (decimal)reader["A_GAIL_REDEL_ALLOC_BAL"],
                A_GAIL_REDEL_ALLOC_TOT = (decimal)reader["A_GAIL_REDEL_ALLOC_TOT"],
            };
        }

        public async Task<PAS216Model> putData(TransactionDateBtnDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_GET_PPT_RIL_GAS_RECPT_DETAIL", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    PAS216Model response = null;
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

        public async Task saveData(PAS216SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_AM2_SAVE_PPT_RIL_GAS_RECPT_DETAIL]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TRANS_DATE", value.A_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_USER_ID", value.A_USER_ID));

                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RIL_NOM", value.A_RIL_NOM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RIL_SCHD", value.A_RIL_SCHD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RIL_ALLOC", value.A_RIL_ALLOC));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RGTIL_ENT_NOM_NORM", value.A_RGTIL_ENT_NOM_NORM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RGTIL_ENT_NOM_BAL", value.A_RGTIL_ENT_NOM_BAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RGTIL_ENT_NOM_TOT", value.A_RGTIL_ENT_NOM_TOT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RGTIL_EXT_NOM_NORM", value.A_RGTIL_EXT_NOM_NORM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RGTIL_EXT_NOM_BAL", value.A_RGTIL_EXT_NOM_BAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RGTIL_EXT_NOM_TOT", value.A_RGTIL_EXT_NOM_TOT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RGTIL_ENT_SCHD_NORM", value.A_RGTIL_ENT_SCHD_NORM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RGTIL_ENT_SCHD_BAL", value.A_RGTIL_ENT_SCHD_BAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RGTIL_ENT_SCHD_TOT", value.A_RGTIL_ENT_SCHD_TOT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RGTIL_EXT_SCHD_NORM", value.A_RGTIL_EXT_SCHD_NORM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RGTIL_EXT_SCHD_BAL", value.A_RGTIL_EXT_SCHD_BAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RGTIL_EXT_SCHD_TOT", value.A_RGTIL_EXT_SCHD_TOT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RGTIL_ENT_ALLOC_NORM", value.A_RGTIL_ENT_ALLOC_NORM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RGTIL_ENT_ALLOC_BAL", value.A_RGTIL_ENT_ALLOC_BAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RGTIL_ENT_ALLOC_TOT", value.A_RGTIL_ENT_ALLOC_TOT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RGTIL_EXT_ALLOC_NORM", value.A_RGTIL_EXT_ALLOC_NORM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RGTIL_EXT_ALLOC_BAL", value.A_RGTIL_EXT_ALLOC_BAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_RGTIL_EXT_ALLOC_TOT", value.A_RGTIL_EXT_ALLOC_TOT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_DEL_NOM_NORM", value.A_GAIL_DEL_NOM_NORM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_DEL_NOM_BAL", value.A_GAIL_DEL_NOM_BAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_DEL_NOM_TOT", value.A_GAIL_DEL_NOM_TOT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_DEL_SCHD_NORM", value.A_GAIL_DEL_SCHD_NORM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_DEL_SCHD_BAL", value.A_GAIL_DEL_SCHD_BAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_DEL_SCHD_TOT", value.A_GAIL_DEL_SCHD_TOT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_DEL_ALLOC_NORM", value.A_GAIL_DEL_ALLOC_NORM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_DEL_ALLOC_BAL", value.A_GAIL_DEL_ALLOC_BAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_DEL_ALLOC_TOT", value.A_GAIL_DEL_ALLOC_TOT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_REDEL_NOM_NORM", value.A_GAIL_REDEL_NOM_NORM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_REDEL_NOM_BAL", value.A_GAIL_REDEL_NOM_BAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_REDEL_NOM_TOT", value.A_GAIL_REDEL_NOM_TOT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_REDEL_SCHD_NORM", value.A_GAIL_REDEL_SCHD_NORM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_REDEL_SCHD_BAL", value.A_GAIL_REDEL_SCHD_BAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_REDEL_SCHD_TOT", value.A_GAIL_REDEL_SCHD_TOT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_REDEL_ALLOC_NORM", value.A_GAIL_REDEL_ALLOC_NORM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_REDEL_ALLOC_BAL", value.A_GAIL_REDEL_ALLOC_BAL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_GAIL_REDEL_ALLOC_TOT", value.A_GAIL_REDEL_ALLOC_TOT));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
