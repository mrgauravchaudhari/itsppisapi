
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
namespace itsppisapi.Data
{
    public class PLR202ReportRepository
    {
        private readonly string _connectionString;
        public PLR202ReportRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PLR202ReportModel MapToValue(SqlDataReader reader)
        {
            return new PLR202ReportModel()
            {
                l_trans_date = reader["l_trans_date"].ToString(),
                l_TIME = reader["l_TIME"].ToString(),
                l_TEMP = (decimal)reader["l_TEMP"],
                l_density = (decimal)reader["l_density"],
                l_density_15c = (decimal)reader["l_density_15c"],
                l_br_no = (decimal)reader["l_br_no"],
                l_olefines = (decimal)reader["l_olefines"],
                l_aromatics = (decimal)reader["l_aromatics"],
                l_ibp = (decimal)reader["l_ibp"],
                l_nra_50 = (decimal)reader["l_nra_50"],
                l_nra_95 = (decimal)reader["l_nra_95"],
                l_fbp = (decimal)reader["l_fbp"],
                l_ch_ratio = (decimal)reader["l_ch_ratio"],
                l_gross_cv = (decimal)reader["l_gross_cv"],
                l_net_cv = (decimal)reader["l_net_cv"],
                l_sulphur = (decimal)reader["l_sulphur"],
                l_residue = (decimal)reader["l_residue"],
                l_recovery = (decimal)reader["l_recovery"],
            };
        }

        public async Task<PLR202ReportModel> GetById(string TDATE)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_LB_RAW_NAP_DTANK_ANALS_GP2_D_RPT", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DT", TDATE));
                    PLR202ReportModel response = null;
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
