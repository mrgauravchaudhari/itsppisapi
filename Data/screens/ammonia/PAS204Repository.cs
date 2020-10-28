using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class PAS204Repository
    {
        private readonly string _connectionString;
        public PAS204Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PAS204Model MapToValue(SqlDataReader reader)
        {
            return new PAS204Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                A2_TRANS_DATE = reader["A2_TRANS_DATE"].ToString(),
                A2_HSD_RECEIPT = (dynamic)reader["A2_HSD_RECEIPT"],
                A2_HSD_TANK_LEVEL = (dynamic)reader["A2_HSD_TANK_LEVEL"],
                A2_HSD_TANK_STOCK = (dynamic)reader["A2_HSD_TANK_STOCK"],
                A2_HSD_CONSUMPTION = (dynamic)reader["A2_HSD_CONSUMPTION"],
                A2_H2SO4_RECPT = (dynamic)reader["A2_H2SO4_RECPT"],
                A2_H2SO4_TANK_LEVEL = (dynamic)reader["A2_H2SO4_TANK_LEVEL"],
                A2_H2SO4_STOCK = (dynamic)reader["A2_H2SO4_STOCK"],
                A2_H2SO4_CONSP = (dynamic)reader["A2_H2SO4_CONSP"],
                A2_CHLCT_RECPT = (dynamic)reader["A2_CHLCT_RECPT"],
                A2_CHLCT_STOCK = (dynamic)reader["A2_CHLCT_STOCK"],
                A2_CHLCT_CONSP = (dynamic)reader["A2_CHLCT_CONSP"],
                A2_TSP_RECPT = (dynamic)reader["A2_TSP_RECPT"],
                A2_TSP_STOCK = (dynamic)reader["A2_TSP_STOCK"],
                A2_TSP_CONSP = (dynamic)reader["A2_TSP_CONSP"],
                A2_K2CO3_RECPT = (dynamic)reader["A2_K2CO3_RECPT"],
                A2_K2CO3_STOCK = (dynamic)reader["A2_K2CO3_STOCK"],
                A2_K2CO3_CONSP = (dynamic)reader["A2_K2CO3_CONSP"],
                A2_V2O5_RECPT = (dynamic)reader["A2_V2O5_RECPT"],
                A2_V2O5_STOCK = (dynamic)reader["A2_V2O5_STOCK"],
                A2_V2O5_CONSP = (dynamic)reader["A2_V2O5_CONSP"],
                A2_KNO2_RECPT = (dynamic)reader["A2_KNO2_RECPT"],
                A2_KNO2_STOCK = (dynamic)reader["A2_KNO2_STOCK"],
                A2_KNO2_CONSP = (dynamic)reader["A2_KNO2_CONSP"],
                A2_UCON_RECPT = (dynamic)reader["A2_UCON_RECPT"],
                A2_UCON_STOCK = (dynamic)reader["A2_UCON_STOCK"],
                A2_UCON_CONSP = (dynamic)reader["A2_UCON_CONSP"],
                A2_ACT1_RECPT = (dynamic)reader["A2_ACT1_RECPT"],
                A2_ACT1_STOCK = (dynamic)reader["A2_ACT1_STOCK"],
                A2_ACT1_CONSP = (dynamic)reader["A2_ACT1_CONSP"],
                A2_SC_RECPT = (dynamic)reader["A2_SC_RECPT"],
                A2_SC_STOCK = (dynamic)reader["A2_SC_STOCK"],
                A2_SC_CONSP = (dynamic)reader["A2_SC_CONSP"],
                A2_A9240_RECPT = (dynamic)reader["A2_A9240_RECPT"],
                A2_A9240_STOCK = (dynamic)reader["A2_A9240_STOCK"],
                A2_A9240_CONSP = (dynamic)reader["A2_A9240_CONSP"],
                A2_A9330_RECPT = (dynamic)reader["A2_A9330_RECPT"],
                A2_A9330_STOCK = (dynamic)reader["A2_A9330_STOCK"],
                A2_A9330_CONSP = (dynamic)reader["A2_A9330_CONSP"],
                A2_REMARKS = reader["A2_REMARKS"].ToString(),
                A2_DATE_MOD = reader["A2_DATE_MOD"].ToString(),
                A2_USER_ID = (dynamic)reader["A2_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),

                // PRV
                PRV_A2_TRANS_DATE = reader["PRV_A2_TRANS_DATE"].ToString(),
                PRV_A2_HSD_RECEIPT = (dynamic)reader["PRV_A2_HSD_RECEIPT"],
                PRV_A2_HSD_TANK_LEVEL = (dynamic)reader["PRV_A2_HSD_TANK_LEVEL"],
                PRV_A2_HSD_TANK_STOCK = (dynamic)reader["PRV_A2_HSD_TANK_STOCK"],
                PRV_A2_H2SO4_RECPT = (dynamic)reader["PRV_A2_H2SO4_RECPT"],
                PRV_A2_H2SO4_TANK_LEVEL = (dynamic)reader["PRV_A2_H2SO4_TANK_LEVEL"],
                PRV_A2_H2SO4_STOCK = (dynamic)reader["PRV_A2_H2SO4_STOCK"],
                PRV_A2_H2SO4_CONSP = (dynamic)reader["PRV_A2_H2SO4_CONSP"],
                PRV_A2_CHLCT_RECPT = (dynamic)reader["PRV_A2_CHLCT_RECPT"],
                PRV_A2_CHLCT_STOCK = (dynamic)reader["PRV_A2_CHLCT_STOCK"],
                PRV_A2_CHLCT_CONSP = (dynamic)reader["PRV_A2_CHLCT_CONSP"],
                PRV_A2_TSP_RECPT = (dynamic)reader["PRV_A2_TSP_RECPT"],
                PRV_A2_TSP_STOCK = (dynamic)reader["PRV_A2_TSP_STOCK"],
                PRV_A2_TSP_CONSP = (dynamic)reader["PRV_A2_TSP_CONSP"],
                PRV_A2_K2CO3_RECPT = (dynamic)reader["PRV_A2_K2CO3_RECPT"],
                PRV_A2_K2CO3_STOCK = (dynamic)reader["PRV_A2_K2CO3_STOCK"],
                PRV_A2_K2CO3_CONSP = (dynamic)reader["PRV_A2_K2CO3_CONSP"],
                PRV_A2_V2O5_RECPT = (dynamic)reader["PRV_A2_V2O5_RECPT"],
                PRV_A2_V2O5_STOCK = (dynamic)reader["PRV_A2_V2O5_STOCK"],
                PRV_A2_V2O5_CONSP = (dynamic)reader["PRV_A2_V2O5_CONSP"],
                PRV_A2_KNO2_RECPT = (dynamic)reader["PRV_A2_KNO2_RECPT"],
                PRV_A2_KNO2_STOCK = (dynamic)reader["PRV_A2_KNO2_STOCK"],
                PRV_A2_KNO2_CONSP = (dynamic)reader["PRV_A2_KNO2_CONSP"],
                PRV_A2_UCON_RECPT = (dynamic)reader["PRV_A2_UCON_RECPT"],
                PRV_A2_UCON_STOCK = (dynamic)reader["PRV_A2_UCON_STOCK"],
                PRV_A2_UCON_CONSP = (dynamic)reader["PRV_A2_UCON_CONSP"],
                PRV_A2_ACT1_RECPT = (dynamic)reader["PRV_A2_ACT1_RECPT"],
                PRV_A2_ACT1_STOCK = (dynamic)reader["PRV_A2_ACT1_STOCK"],
                PRV_A2_ACT1_CONSP = (dynamic)reader["PRV_A2_ACT1_CONSP"],
                PRV_A2_SC_RECPT = (dynamic)reader["PRV_A2_SC_RECPT"],
                PRV_A2_SC_STOCK = (dynamic)reader["PRV_A2_SC_STOCK"],
                PRV_A2_SC_CONSP = (dynamic)reader["PRV_A2_SC_CONSP"],
                PRV_A2_A9240_RECPT = (dynamic)reader["PRV_A2_A9240_RECPT"],
                PRV_A2_A9240_STOCK = (dynamic)reader["PRV_A2_A9240_STOCK"],
                PRV_A2_A9240_CONSP = (dynamic)reader["PRV_A2_A9240_CONSP"],
                PRV_A2_A9330_RECPT = (dynamic)reader["PRV_A2_A9330_RECPT"],
                PRV_A2_A9330_STOCK = (dynamic)reader["PRV_A2_A9330_STOCK"],
                PRV_A2_A9330_CONSP = (dynamic)reader["PRV_A2_A9330_CONSP"],
                // PRV_A2_REMARKS = reader["PRV_A2_REMARKS"].ToString(),
                G_MF_HSD_TANK = (dynamic)reader["G_MF_HSD_TANK"],
                G_CONST_H2SO4_DEAD_STOCK = (dynamic)reader["G_CONST_H2SO4_DEAD_STOCK"],
                G_MF_H2SO4_TANK = (dynamic)reader["G_MF_H2SO4_TANK"]
            };
        }

        public async Task<PAS204Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_GET_PPT_AM2_CHEMICAL_CONSP_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PAS204Model response = null;
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

        public async Task saveData(PAS204SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_SAVE_PPT_AM2_CHEMICAL_CONSP_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TRANS_DATE", value.A2_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DMY_FLG", value.A2_DMY_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_USER_ID", value.A2_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_HSD_TANK_LEVEL", value.A2_HSD_TANK_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_HSD_TANK_STOCK", value.A2_HSD_TANK_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_H2SO4_RECPT", value.A2_H2SO4_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_H2SO4_CONSP", value.A2_H2SO4_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_H2SO4_TANK_LEVEL", value.A2_H2SO4_TANK_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_H2SO4_STOCK", value.A2_H2SO4_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CHLCT_RECPT", value.A2_CHLCT_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CHLCT_CONSP", value.A2_CHLCT_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CHLCT_STOCK", value.A2_CHLCT_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TSP_RECPT", value.A2_TSP_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TSP_CONSP", value.A2_TSP_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TSP_STOCK", value.A2_TSP_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_HYDRAZINE_RECPT", value.A2_HYDRAZINE_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_HYDRAZINE_CONSP", value.A2_HYDRAZINE_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_HYDRAZINE_STOCK", value.A2_HYDRAZINE_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_K2CO3_RECPT", value.A2_K2CO3_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_K2CO3_CONSP", value.A2_K2CO3_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_K2CO3_STOCK", value.A2_K2CO3_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DEA_RECPT", value.A2_DEA_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DEA_CONSP", value.A2_DEA_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DEA_STOCK", value.A2_DEA_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_REMARKS", value.A2_REMARKS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_V2O5_RECPT", value.A2_V2O5_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_V2O5_CONSP", value.A2_V2O5_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_V2O5_STOCK", value.A2_V2O5_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_KNO2_RECPT", value.A2_KNO2_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_KNO2_CONSP", value.A2_KNO2_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_KNO2_STOCK", value.A2_KNO2_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UCON_RECPT", value.A2_UCON_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UCON_CONSP", value.A2_UCON_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UCON_STOCK", value.A2_UCON_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_ACT1_RECPT", value.A2_ACT1_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_ACT1_CONSP", value.A2_ACT1_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_ACT1_STOCK", value.A2_ACT1_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SC_RECPT", value.A2_SC_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SC_CONSP", value.A2_SC_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SC_STOCK", value.A2_SC_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_A9240_RECPT", value.A2_A9240_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_A9240_CONSP", value.A2_A9240_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_A9240_STOCK", value.A2_A9240_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_A9330_RECPT", value.A2_A9330_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_A9330_CONSP", value.A2_A9330_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_A9330_STOCK", value.A2_A9330_STOCK));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
