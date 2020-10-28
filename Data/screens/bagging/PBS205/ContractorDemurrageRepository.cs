using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class ContractorDemurrageRepository
    {
        private readonly string _connectionString;
        public ContractorDemurrageRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private ContractorDemurrage MapToValue(SqlDataReader reader)
        {
            return new ContractorDemurrage()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                B_TRANS_DATE = reader["B_TRANS_DATE"].ToString(),
                B_UNIT_ID = reader["B_UNIT_ID"].ToString(),
                B_RAKE_NO = reader["B_RAKE_NO"].ToString(),
                B_CONTR_CODE = reader["B_CONTR_CODE"].ToString(),
                B_DEMG_AMT = (dynamic)reader["B_DEMG_AMT"],
                B_DEMG_HRS = (dynamic)reader["B_DEMG_HRS"]
            };
        }

        public async Task<List<ContractorDemurrage>> putData(threeParamDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_GET_PPT_BG_CONTRACTOR_DEMURRAGE", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_UNIT_ID", value.UnitId));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    var response = new List<ContractorDemurrage>();
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

        public async Task saveData(ContractorDemurrageSaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_BG2_SAVE_PPT_BG_CONTRACTOR_DEMURRAGE", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_B_TRANS_DATE", value.B_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_CONTR_CODE", value.B_CONTR_CODE));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_RAKE_NO", value.B_RAKE_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_UNIT_ID", value.B_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DEMG_AMT", value.B_DEMG_AMT));
                    cmd.Parameters.Add(new SqlParameter("@IN_B_DEMG_HRS", value.B_DEMG_HRS));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
