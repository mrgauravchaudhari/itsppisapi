using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PBS204Repository
    {
        private readonly string _connectionString;
        public PBS204Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PBS204Model MapToValue(SqlDataReader reader)
        {
            return new PBS204Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                B_TRANS_DATE = reader["B_TRANS_DATE"].ToString(),
                B_USER_ID = (decimal)reader["B_USER_ID"],
                B_USER_NAME = reader["B_USER_NAME"].ToString(),
                B_DATE_MOD = reader["B_DATE_MOD"].ToString(),
                B_WORK_CODE = reader["B_WORK_CODE"].ToString(),
                B_WORK_DESC = reader["B_WORK_DESC"].ToString(),
                B_PRINT_SEQ = (decimal)reader["B_PRINT_SEQ"],
                B_UNIT_ID = reader["B_UNIT_ID"].ToString(),
                B_CONTR_CODE = reader["B_CONTR_CODE"].ToString(),
                B_RAKE_NO = reader["B_RAKE_NO"].ToString(),
                B_BAGG_QTY_PF1 = (dynamic)reader["B_BAGG_QTY_PF1"],
                B_BAGG_QTY = (dynamic)reader["B_BAGG_QTY"],
                TXT_TOT_QTY_PF1 = (dynamic)reader["TXT_TOT_QTY_PF1"],
                TXT_TOT_QTY = (dynamic)reader["TXT_TOT_QTY"],
            };
        }

        public async Task<List<PBS204Model>> putData(PBS204Dto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_GET_PPT_BG_CONTR_RAKE_LDG", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    //cmd.Parameters.Add(new SqlParameter("@IN_B_CONTR_CODE", value.ContractorCode));
                    //cmd.Parameters.Add(new SqlParameter("@IN_B_UNIT_ID", value.UnitId));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    var response = new List<PBS204Model>();
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValue(reader));
                        }
                    }
                    return response;
                }
            }
        }
        private RakeNoModel MapToValue2(SqlDataReader reader)
        {
            return new RakeNoModel()
            {
                B_RAKE_NO = reader["B_RAKE_NO"].ToString(),
                B_UNIT_ID = reader["B_UNIT_ID"].ToString(),
            };
        }
        public async Task<List<RakeNoModel>> putData2(StringParameterDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT B_RAKE_NO, B_UNIT_ID FROM PPIS.PPT_BG_RAKE_LOADING_DETAILS WHERE B_TRANS_DATE = CONVERT(date,'" + value.StringParameter + "',105)", sql))
                {
                    var response = new List<RakeNoModel>();
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValue2(reader));
                        }
                    }
                    return response;
                }
            }
        }

        public async Task saveData(PBS204SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_SAVE_PPT_BG_CONTR_RAKE_LDG", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TRANS_DATE", value.B_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_UNIT_ID", value.B_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_RAKE_NO", value.B_RAKE_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_CONTR_CODE", value.B_CONTR_CODE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_WORK_CODE", value.B_WORK_CODE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAGG_QTY", value.B_BAGG_QTY));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_PRINT_SEQ", value.B_PRINT_SEQ));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_BAGG_QTY_PF1", value.B_BAGG_QTY_PF1));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_USER_ID", value.B_USER_ID));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
