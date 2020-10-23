using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Dtos;

namespace itsppisapi.Data
{
    public class PBS212Repository
    {
        private readonly string _connectionString;
        public PBS212Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PBS212Model MapToValue(SqlDataReader reader)
        {
            return new PBS212Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                S_TRANS_DATE = reader["S_TRANS_DATE"].ToString(),
                S_DATE_MOD = reader["S_DATE_MOD"].ToString(),
                S_USER_NAME = reader["S_USER_NAME"].ToString(),
                S_USER_ID = reader["S_UREA_PROD"].ToString(),
                S_UREA_PROD = (decimal)reader["S_UREA_PROD"],
                S_UREA_BAGG = (decimal)reader["S_UREA_BAGG"],
                S_DISP_ROAD = (decimal)reader["S_DISP_ROAD"],
                S_DISP_RAIL = (decimal)reader["S_DISP_RAIL"],
                S_DIVET_SILO = (decimal)reader["S_DIVET_SILO"],
                S_RECO_SILO = (decimal)reader["S_RECO_SILO"],
                S_NET_SILO = (decimal)reader["S_NET_SILO"],
                S_RK_BCNHL = (decimal)reader["S_RK_BCNHL"],
                S_RK_BCN = (decimal)reader["S_RK_BCN"],
                S_RK_BOX = (decimal)reader["S_RK_BOX"],
                S_PF_CLOS_STK = (decimal)reader["S_PF_CLOS_STK"],
                S_SILO_CLOS_STK = (decimal)reader["S_SILO_CLOS_STK"],
                S_TOT_SK = (decimal)reader["S_TOT_SK"],
                S_NO_TRUCK = (decimal)reader["S_NO_TRUCK"],
                S_PF01 = (decimal)reader["S_PF01"],
                S_PF02 = (decimal)reader["S_PF02"],
                S_PF03 = (decimal)reader["S_PF03"],
                S_PF04 = (decimal)reader["S_PF04"],
                S_RK_UND_LDG = (decimal)reader["S_RK_UND_LDG"],
            };
        }

        public async Task<PBS212Model> putData(TransactionDateBtnDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_GET_PPT_BG_UPH_DTL", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    PBS212Model response = null;
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

        public async Task saveData(PBS212SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_SAVE_PPT_BG_UPH_DTL", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_S_TRANS_DATE", value.S_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_UREA_PROD", value.S_UREA_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_UREA_BAGG", value.S_UREA_BAGG));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_DISP_RAIL", value.S_DISP_RAIL));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_DISP_ROAD", value.S_DISP_ROAD));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_DIVET_SILO", value.S_DIVET_SILO));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_RECO_SILO", value.S_RECO_SILO));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_NET_SILO", value.S_NET_SILO));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_PF_CLOS_STK", value.S_PF_CLOS_STK));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_SILO_CLOS_STK", value.S_SILO_CLOS_STK));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_TOT_SK", value.S_TOT_SK));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_NO_TRUCK", value.S_NO_TRUCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_RK_BCNHL", value.S_RK_BCNHL));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_RK_BCN", value.S_RK_BCN));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_RK_BOX", value.S_RK_BOX));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_PF01", value.S_PF01));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_PF02", value.S_PF02));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_PF03", value.S_PF03));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_PF04", value.S_PF04));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_RK_UND_LDG", value.S_RK_UND_LDG));
                    cmd.Parameters.Add(new SqlParameter("@IN_S_USER_ID", value.S_USER_ID));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
