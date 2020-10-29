using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PAS004Repository
    {
        private readonly string _connectionString;
        public PAS004Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PAS004Model MapToValue(SqlDataReader reader)
        {
            return new PAS004Model()
            {
                MINMONTH = reader["MINMONTH"].ToString(),
                MINYEAR = (decimal)reader["MINYEAR"],
                MAXMONTH = reader["MAXMONTH"].ToString(),
                MAXYEAR = (decimal)reader["MAXYEAR"],
                A1_YEAR = (decimal)reader["A1_YEAR"],
                A1_MONTH = reader["A1_MONTH"].ToString(),
                A1_INPUT_PROD_ADJ_AMM_VOL_VAR = (decimal)reader["A1_INPUT_PROD_ADJ_AMM_VOL_VAR"],
                A1_INPUT_PROD_LOSS_GAS_LIMIT_AM = (decimal)reader["A1_INPUT_PROD_LOSS_GAS_LIMIT_AM"],
                A1_INPUT_PROD_ADJ_AMM_CONSP_VAR = (decimal)reader["A1_INPUT_PROD_ADJ_AMM_CONSP_VAR"],
                A1_UNPROD_GAS_AM = (decimal)reader["A1_UNPROD_GAS_AM"],
                A1_NO_GT_STARTUP = (decimal)reader["A1_NO_GT_STARTUP"],
                A1_NO_AB_STARTUP = (decimal)reader["A1_NO_AB_STARTUP"],
                A1_NO_UREA_STARTUP = (decimal)reader["A1_NO_UREA_STARTUP"],
                A1_HRS_2GTG = (decimal)reader["A1_HRS_2GTG"],
                A1_REMARKS_1 = reader["A1_REMARKS_1"].ToString(),
                A1_REMARKS_2 = reader["A1_REMARKS_2"].ToString(),
                A1_REMARKS_3 = reader["A1_REMARKS_3"].ToString(),
                A1_REMARKS_4 = reader["A1_REMARKS_4"].ToString(),
                A1_REMARKS_5 = reader["A1_REMARKS_5"].ToString(),
                A1_REMARKS_6 = reader["A1_REMARKS_6"].ToString(),
                A1_DATE_MOD = reader["A1_DATE_MOD"].ToString(),
                A1_USER_ID = (decimal)reader["A1_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString()
            };
        }

        public async Task<PAS004Model> putData(string MONTH, decimal YEAR)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM1_GET_PPT_AM_VARIANCE_INPUT", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_MONTH", MONTH));
                    cmd.Parameters.Add(new SqlParameter("@IN_YEAR", YEAR));
                    PAS004Model response = null;
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

        private PAS004Model2 MapToValue2(SqlDataReader reader)
        {
            return new PAS004Model2()
            {
                MSG = (string)reader["MSG"],
            };
        }

        public async Task<PAS004Model2> calAmmVar(string MONTH, string YEAR, string DELETE_FLG, decimal USER_ID)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_CALC_AMM_VARIANCE", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MONTH", MONTH));
                    cmd.Parameters.Add(new SqlParameter("@YEAR", YEAR));
                    cmd.Parameters.Add(new SqlParameter("@DELETE_FLG", DELETE_FLG));
                    cmd.Parameters.Add(new SqlParameter("@USER_ID", USER_ID));
                    PAS004Model2 response = null;
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response = MapToValue2(reader);
                        }
                    }
                    return response;
                }
            }
        }

        public async Task saveData(PAS004SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM1_SAVE_PPT_AM_VARIANCE_INPUT", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_TRANS_DATE", value.A1_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_USER_ID", value.A1_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_YEAR", value.A1_YEAR));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_MONTH", value.A1_MONTH));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_INPUT_PROD_ADJ_AMM_VOL_VAR", value.A1_INPUT_PROD_ADJ_AMM_VOL_VAR));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_INPUT_PROD_LOSS_GAS_LIMIT_AM", value.A1_INPUT_PROD_LOSS_GAS_LIMIT_AM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_INPUT_PROD_ADJ_AMM_CONSP_VAR", value.A1_INPUT_PROD_ADJ_AMM_CONSP_VAR));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_UNPROD_GAS_AM", value.A1_UNPROD_GAS_AM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NO_GT_STARTUP", value.A1_NO_GT_STARTUP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NO_AB_STARTUP", value.A1_NO_AB_STARTUP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_NO_UREA_STARTUP", value.A1_NO_UREA_STARTUP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_HRS_2GTG", value.A1_HRS_2GTG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_REMARKS", value.A1_REMARKS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_REMARKS_1", value.A1_REMARKS_1));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_REMARKS_2", value.A1_REMARKS_2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_REMARKS_3", value.A1_REMARKS_3));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_REMARKS_4", value.A1_REMARKS_4));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_REMARKS_5", value.A1_REMARKS_5));
                    cmd.Parameters.Add(new SqlParameter("@IN_A1_REMARKS_6", value.A1_REMARKS_6));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
