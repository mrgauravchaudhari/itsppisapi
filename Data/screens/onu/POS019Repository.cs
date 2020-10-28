using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class POS019Repository
    {
        private readonly string _connectionString;
        public POS019Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private POS019Model MapToValue(SqlDataReader reader)
        {
            return new POS019Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                OU1_TRANS_DATE = reader["OU1_TRANS_DATE"].ToString(),
                OU1_UNIT_ID = reader["OU1_UNIT_ID"].ToString(),
                OU1_RAKE_NO = reader["OU1_RAKE_NO"].ToString(),
                OU1_TIME = reader["OU1_TIME"].ToString(),
                OU1_TEMP = (decimal)reader["OU1_TEMP"],
                OU1_DENSITY = (decimal)reader["OU1_DENSITY"],
                OU1_DENSITY_15C = (decimal)reader["OU1_DENSITY_15C"],
                OU1_BR_NO = (decimal)reader["OU1_BR_NO"],
                OU1_OLEFINES = (decimal)reader["OU1_OLEFINES"],
                OU1_AROMATICS = (decimal)reader["OU1_AROMATICS"],
                OU1_IBP = (decimal)reader["OU1_IBP"],
                OU1_NRA_5 = (decimal)reader["OU1_NRA_5"],
                OU1_NRA_10 = (decimal)reader["OU1_NRA_10"],
                OU1_NRA_50 = (decimal)reader["OU1_NRA_50"],
                OU1_NRA_90 = (decimal)reader["OU1_NRA_90"],
                OU1_NRA_95 = (decimal)reader["OU1_NRA_95"],
                OU1_FBP = (decimal)reader["OU1_FBP"],
                OU1_CH_RATIO = (decimal)reader["OU1_CH_RATIO"],
                OU1_SULPHUR = (decimal)reader["OU1_SULPHUR"],
                OU1_RESIDUE = (decimal)reader["OU1_RESIDUE"],
                OU1_RECOVERY = (decimal)reader["OU1_RECOVERY"],
                OU1_LIQ_REMAIN = (decimal)reader["OU1_LIQ_REMAIN"],
                OU1_LOSS = (decimal)reader["OU1_LOSS"],
                OU1_CHLORIDE = (decimal)reader["OU1_CHLORIDE"],
                OU1_VAPOR_PRESSURE = (decimal)reader["OU1_VAPOR_PRESSURE"],
                OU1_NAP_IOC_CV = (decimal)reader["OU1_NAP_IOC_CV"],
                OU1_NAP_NET_CV = (decimal)reader["OU1_NAP_NET_CV"],
                OU1_NAP_GROSS_CV = (decimal)reader["OU1_NAP_GROSS_CV"],
                OU1_DATE_MOD = reader["OU1_DATE_MOD"].ToString(),
                OU1_USER_ID = (decimal)reader["OU1_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),

                // PRV
                PRV_OU1_TRANS_DATE = reader["PRV_OU1_TRANS_DATE"].ToString(),
                PRV_OU1_UNIT_ID = reader["PRV_OU1_UNIT_ID"].ToString(),
                PRV_OU1_RAKE_NO = reader["PRV_OU1_RAKE_NO"].ToString(),
                PRV_OU1_TIME = reader["PRV_OU1_TIME"].ToString(),
                PRV_OU1_TEMP = (decimal)reader["PRV_OU1_TEMP"],
                PRV_OU1_DENSITY = (decimal)reader["PRV_OU1_DENSITY"],
                PRV_OU1_DENSITY_15C = (decimal)reader["PRV_OU1_DENSITY_15C"],
                PRV_OU1_BR_NO = (decimal)reader["PRV_OU1_BR_NO"],
                PRV_OU1_OLEFINES = (decimal)reader["PRV_OU1_OLEFINES"],
                PRV_OU1_AROMATICS = (decimal)reader["PRV_OU1_AROMATICS"],
                PRV_OU1_IBP = (decimal)reader["PRV_OU1_IBP"],
                PRV_OU1_NRA_5 = (decimal)reader["PRV_OU1_NRA_5"],
                PRV_OU1_NRA_10 = (decimal)reader["PRV_OU1_NRA_10"],
                PRV_OU1_NRA_50 = (decimal)reader["PRV_OU1_NRA_50"],
                PRV_OU1_NRA_90 = (decimal)reader["PRV_OU1_NRA_90"],
                PRV_OU1_NRA_95 = (decimal)reader["PRV_OU1_NRA_95"],
                PRV_OU1_FBP = (decimal)reader["PRV_OU1_FBP"],
                PRV_OU1_CH_RATIO = (decimal)reader["PRV_OU1_CH_RATIO"],
                PRV_OU1_SULPHUR = (decimal)reader["PRV_OU1_SULPHUR"],
                PRV_OU1_RESIDUE = (decimal)reader["PRV_OU1_RESIDUE"],
                PRV_OU1_RECOVERY = (decimal)reader["PRV_OU1_RECOVERY"],
                PRV_OU1_LIQ_REMAIN = (decimal)reader["PRV_OU1_LIQ_REMAIN"],
                PRV_OU1_LOSS = (decimal)reader["PRV_OU1_LOSS"],
                PRV_OU1_CHLORIDE = (decimal)reader["PRV_OU1_CHLORIDE"],
                PRV_OU1_VAPOR_PRESSURE = (decimal)reader["PRV_OU1_VAPOR_PRESSURE"],
                PRV_OU1_NAP_IOC_CV = (decimal)reader["PRV_OU1_NAP_IOC_CV"]
            };
        }

        public async Task<POS019Model> putData(string IN_DATE, string IN_UNIT, string Btn)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_GET_PPT_OU_IOC_NAP_RAKE_ANALYSIS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_UNIT", IN_UNIT));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", Btn));
                    POS019Model response = null;
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

        public async Task saveData(POS019SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_SAVE_PPT_OU_IOC_NAP_RAKE_ANALYSIS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TRANS_DATE", value.OU1_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TIME", value.OU1_TIME));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UNIT_ID", value.OU1_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RAKE_NO", value.OU1_RAKE_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_USER_ID", value.OU1_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TEMP", value.OU1_TEMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DENSITY", value.OU1_DENSITY));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DENSITY_15C", value.OU1_DENSITY_15C));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_BR_NO", value.OU1_BR_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_OLEFINES", value.OU1_OLEFINES));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_AROMATICS", value.OU1_AROMATICS));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_IBP", value.OU1_IBP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NRA_50", value.OU1_NRA_50));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NRA_95", value.OU1_NRA_95));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FBP", value.OU1_FBP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CH_RATIO", value.OU1_CH_RATIO));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_NET_CV", value.OU1_NAP_NET_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_GROSS_CV", value.OU1_NAP_GROSS_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SULPHUR", value.OU1_SULPHUR));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RESIDUE", value.OU1_RESIDUE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RECOVERY", value.OU1_RECOVERY));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LIQ_REMAIN", value.OU1_LIQ_REMAIN));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_LOSS", value.OU1_LOSS));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP_IOC_CV", value.OU1_NAP_IOC_CV));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NRA_5", value.OU1_NRA_5));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NRA_10", value.OU1_NRA_10));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NRA_90", value.OU1_NRA_90));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_VAPOR_PRESSURE", value.OU1_VAPOR_PRESSURE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CHLORIDE", value.OU1_CHLORIDE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_GCV_CALCULATE", value.OU1_GCV_CALCULATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_H_CALCULATE", value.OU1_H_CALCULATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NCV_CALCULATE", value.OU1_NCV_CALCULATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NCV_CORRECT", value.OU1_NCV_CORRECT));


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
