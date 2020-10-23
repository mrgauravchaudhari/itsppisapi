using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Dtos;

namespace itsppisapi.Data
{
    public class PAS207Repository
    {
        private readonly string _connectionString;
        public PAS207Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private PAS207Model MapToValue(SqlDataReader reader)
        {
            return new PAS207Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                A2_TRANS_DATE = reader["A2_TRANS_DATE"].ToString(),
                A2_PWR_WATER_INT = (dynamic)reader["A2_PWR_WATER_INT"],
                A2_PWR_WATER_CONSP = (dynamic)reader["A2_PWR_WATER_CONSP"],
                A2_FW_CONSP_ACT_INT = (dynamic)reader["A2_FW_CONSP_ACT_INT"],
                A2_FW_CONSP_ACT = (dynamic)reader["A2_FW_CONSP_ACT"],
                A2_FW_CONSP_UCT_INT = (dynamic)reader["A2_FW_CONSP_UCT_INT"],
                A2_FW_CONSP_UCT_AMM = (dynamic)reader["A2_FW_CONSP_UCT_AMM"],
                A2_FW_CONSP_UCT = (dynamic)reader["A2_FW_CONSP_UCT"],
                A2_FW_CONSP_PLANT = (dynamic)reader["A2_FW_CONSP_PLANT"],
                A2_ACT_BLOWDOWN = (dynamic)reader["A2_ACT_BLOWDOWN"],
                A2_UCT_BLOWDOWN = (dynamic)reader["A2_UCT_BLOWDOWN"],
                A2_TOTAL_BLOWDOWN = (dynamic)reader["A2_TOTAL_BLOWDOWN"],
                A2_PW_GPI_DRAW_INT = (dynamic)reader["A2_PW_GPI_DRAW_INT"],
                A2_PW_GPI_DRAW = (dynamic)reader["A2_PW_GPI_DRAW"],
                A2_PW_TANK_LEVEL = (dynamic)reader["A2_PW_TANK_LEVEL"],
                A2_PW_TANK_STOCK = (dynamic)reader["A2_PW_TANK_STOCK"],
                A2_PW_CONSP_AB_INT = (dynamic)reader["A2_PW_CONSP_AB_INT"],
                A2_PW_CONSP_AB_INT_DIFF = (dynamic)reader["A2_PW_CONSP_AB_INT_DIFF"],
                A2_PW_CONSP_DESUP1_INT = (dynamic)reader["A2_PW_CONSP_DESUP1_INT"],
                A2_PW_CONSP_DESUP1_INT_DIFF = (dynamic)reader["A2_PW_CONSP_DESUP1_INT_DIFF"],
                A2_PW_CONSP_DESUP2_INT = (dynamic)reader["A2_PW_CONSP_DESUP2_INT"],
                A2_PW_CONSP_DESUP2_INT_DIFF = (dynamic)reader["A2_PW_CONSP_DESUP2_INT_DIFF"],
                A2_PW_CONSP_AB = (dynamic)reader["A2_PW_CONSP_AB"],
                A2_PW_CONSP_RGB_INT = (dynamic)reader["A2_PW_CONSP_RGB_INT"],
                A2_PW_CONSP_RGB = (dynamic)reader["A2_PW_CONSP_RGB"],
                A2_PW_CONSP_DESUPERHEAT_INT = (dynamic)reader["A2_PW_CONSP_DESUPERHEAT_INT"],
                A2_PW_CONSP_DESUPERHEAT = (dynamic)reader["A2_PW_CONSP_DESUPERHEAT"],
                A2_PW_CONSP_QUENCH_INT = (dynamic)reader["A2_PW_CONSP_QUENCH_INT"],
                A2_PW_CONSP_QUENCH_INT_DIFF = (dynamic)reader["A2_PW_CONSP_QUENCH_INT_DIFF"],
                A2_PW_CONSP_LB_INT = (dynamic)reader["A2_PW_CONSP_LB_INT"],
                A2_PW_CONSP_LB = (dynamic)reader["A2_PW_CONSP_LB"],
                A2_PW_CONSP_REVAMP = (dynamic)reader["A2_PW_CONSP_REVAMP"],
                A2_PW_CONSP_AMM2 = (dynamic)reader["A2_PW_CONSP_AMM2"],
                A2_PW_CONSP_UREA2 = (dynamic)reader["A2_PW_CONSP_UREA2"],
                A2_PW_TOT_CONSP = (dynamic)reader["A2_PW_TOT_CONSP"],
                A2_APC_PROD_INT = (dynamic)reader["A2_APC_PROD_INT"],
                A2_APC_PROD = (dynamic)reader["A2_APC_PROD"],
                A2_CTTC_PROD_INT = (dynamic)reader["A2_CTTC_PROD_INT"],
                A2_CTTC_PROD = (dynamic)reader["A2_CTTC_PROD"],
                A2_ATC_PROD = (dynamic)reader["A2_ATC_PROD"],
                A2_ACTTC_PROD = (dynamic)reader["A2_ACTTC_PROD"],
                A2_SSF_BACK_WASH_IBD = (dynamic)reader["A2_SSF_BACK_WASH_IBD"],
                A2_OILY_WATER = (dynamic)reader["A2_OILY_WATER"],
                TXT_TOT_ACT_MAKEUP = (dynamic)reader["TXT_TOT_ACT_MAKEUP"],
                TXT_ACT_MAKEUP_SINK = (dynamic)reader["TXT_ACT_MAKEUP_SINK"],
                TXT_ACT_NET_MAKUP = (dynamic)reader["TXT_ACT_NET_MAKUP"],
                TXT_SERVICE_WATER = (dynamic)reader["TXT_SERVICE_WATER"],
                TXT_DRINKING_WATER = (dynamic)reader["TXT_DRINKING_WATER"],
                TXT_FIRE_WATER = (dynamic)reader["TXT_FIRE_WATER"],
                TXT_TOT_NONPLANT_CONSP = (dynamic)reader["TXT_TOT_NONPLANT_CONSP"],
                TXT_TOT_PLANT_NONPLANT = (dynamic)reader["TXT_TOT_PLANT_NONPLANT"],
                TXT_UPC = (dynamic)reader["TXT_UPC"],
                TXT_UTC = (dynamic)reader["TXT_UTC"],
                TXT_USC = (dynamic)reader["TXT_USC"],
                TXT_UCTTC = (dynamic)reader["TXT_UCTTC"],
                TXT_ASC = (dynamic)reader["TXT_ASC"],
                TXT_TOT_AMM_PLANT = (dynamic)reader["TXT_TOT_AMM_PLANT"],
                TXT_TC = (dynamic)reader["TXT_TC"],
                TXT_TOT_SC = (dynamic)reader["TXT_TOT_SC"],
                TXT_CONDEN_GP2 = (dynamic)reader["TXT_CONDEN_GP2"],
                TXT_DM_WATER = (dynamic)reader["TXT_DM_WATER"],
                TXT_REG_LOSS = (dynamic)reader["TXT_REG_LOSS"],
                A2_DATE_MOD = reader["A2_DATE_MOD"].ToString(),
                A2_USER_ID = (dynamic)reader["A2_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString(),
                // PRV
                PRV_A2_TRANS_DATE = reader["PRV_A2_TRANS_DATE"].ToString(),
                PRV_A2_PWR_WATER_INT = (dynamic)reader["PRV_A2_PWR_WATER_INT"],
                PRV_A2_PWR_WATER_CONSP = (dynamic)reader["PRV_A2_PWR_WATER_CONSP"],
                PRV_A2_FW_CONSP_ACT_INT = (dynamic)reader["PRV_A2_FW_CONSP_ACT_INT"],
                PRV_A2_FW_CONSP_ACT = (dynamic)reader["PRV_A2_FW_CONSP_ACT"],
                PRV_A2_FW_CONSP_UCT_INT = (dynamic)reader["PRV_A2_FW_CONSP_UCT_INT"],
                PRV_A2_FW_CONSP_UCT_AMM = (dynamic)reader["PRV_A2_FW_CONSP_UCT_AMM"],
                PRV_A2_FW_CONSP_UCT = (dynamic)reader["PRV_A2_FW_CONSP_UCT"],
                PRV_A2_FW_CONSP_PLANT = (dynamic)reader["PRV_A2_FW_CONSP_PLANT"],
                PRV_A2_ACT_BLOWDOWN = (dynamic)reader["PRV_A2_ACT_BLOWDOWN"],
                PRV_A2_UCT_BLOWDOWN = (dynamic)reader["PRV_A2_UCT_BLOWDOWN"],
                PRV_A2_TOTAL_BLOWDOWN = (dynamic)reader["PRV_A2_TOTAL_BLOWDOWN"],
                PRV_A2_PW_GPI_DRAW_INT = (dynamic)reader["PRV_A2_PW_GPI_DRAW_INT"],
                PRV_A2_PW_GPI_DRAW = (dynamic)reader["PRV_A2_PW_GPI_DRAW"],
                PRV_A2_PW_TANK_LEVEL = (dynamic)reader["PRV_A2_PW_TANK_LEVEL"],
                PRV_A2_PW_TANK_STOCK = (dynamic)reader["PRV_A2_PW_TANK_STOCK"],
                PRV_A2_PW_CONSP_AB_INT = (dynamic)reader["PRV_A2_PW_CONSP_AB_INT"],
                PRV_A2_PW_CONSP_AB_INT_DIFF = (dynamic)reader["PRV_A2_PW_CONSP_AB_INT_DIFF"],
                PRV_A2_PW_CONSP_DESUP1_INT = (dynamic)reader["PRV_A2_PW_CONSP_DESUP1_INT"],
                PRV_A2_PW_CONSP_DESUP1_INT_DIFF = (dynamic)reader["PRV_A2_PW_CONSP_DESUP1_INT_DIFF"],
                PRV_A2_PW_CONSP_DESUP2_INT = (dynamic)reader["PRV_A2_PW_CONSP_DESUP2_INT"],
                PRV_A2_PW_CONSP_DESUP2_INT_DIFF = (dynamic)reader["PRV_A2_PW_CONSP_DESUP2_INT_DIFF"],
                PRV_A2_PW_CONSP_AB = (dynamic)reader["PRV_A2_PW_CONSP_AB"],
                PRV_A2_PW_CONSP_RGB_INT = (dynamic)reader["PRV_A2_PW_CONSP_RGB_INT"],
                PRV_A2_PW_CONSP_RGB = (dynamic)reader["PRV_A2_PW_CONSP_RGB"],
                PRV_A2_PW_CONSP_DESUPERHEAT_INT = (dynamic)reader["PRV_A2_PW_CONSP_DESUPERHEAT_INT"],
                PRV_A2_PW_CONSP_DESUPERHEAT = (dynamic)reader["PRV_A2_PW_CONSP_DESUPERHEAT"],
                PRV_A2_PW_CONSP_QUENCH_INT = (dynamic)reader["PRV_A2_PW_CONSP_QUENCH_INT"],
                PRV_A2_PW_CONSP_QUENCH_INT_DIFF = (dynamic)reader["PRV_A2_PW_CONSP_QUENCH_INT_DIFF"],
                PRV_A2_PW_CONSP_LB_INT = (dynamic)reader["PRV_A2_PW_CONSP_LB_INT"],
                PRV_A2_PW_CONSP_LB = (dynamic)reader["PRV_A2_PW_CONSP_LB"],
                PRV_A2_PW_CONSP_REVAMP = (dynamic)reader["PRV_A2_PW_CONSP_REVAMP"],
                PRV_A2_PW_CONSP_AMM2 = (dynamic)reader["PRV_A2_PW_CONSP_AMM2"],
                PRV_A2_PW_CONSP_UREA2 = (dynamic)reader["PRV_A2_PW_CONSP_UREA2"],
                PRV_A2_PW_TOT_CONSP = (dynamic)reader["PRV_A2_PW_TOT_CONSP"],
                PRV_A2_APC_PROD_INT = (dynamic)reader["PRV_A2_APC_PROD_INT"],
                PRV_A2_APC_PROD = (dynamic)reader["PRV_A2_APC_PROD"],
                PRV_A2_CTTC_PROD_INT = (dynamic)reader["PRV_A2_CTTC_PROD_INT"],
                PRV_A2_CTTC_PROD = (dynamic)reader["PRV_A2_CTTC_PROD"],
                PRV_A2_ATC_PROD = (dynamic)reader["PRV_A2_ATC_PROD"],
                PRV_A2_ACTTC_PROD = (dynamic)reader["PRV_A2_ACTTC_PROD"],
                PRV_A2_SSF_BACK_WASH_IBD = (dynamic)reader["PRV_A2_SSF_BACK_WASH_IBD"],

                // DV
                U2_FIRE_CONSP_UCT2 = (dynamic)reader["U2_FIRE_CONSP_UCT2"],
                parm_oily_effl_etp = (dynamic)reader["parm_oily_effl_etp"],
                parm_urea2_tot_prod = (dynamic)reader["parm_urea2_tot_prod"],
                parm_urea1_tot_prod = (dynamic)reader["parm_urea1_tot_prod"],
                PARM_MF_PW_DAYTANK = (dynamic)reader["PARM_MF_PW_DAYTANK"],
                PARM_PW_DAYTANK_DEAD_STOCK = (dynamic)reader["PARM_PW_DAYTANK_DEAD_STOCK"],
                PARM_CF_FW_CONSP_ACT_MAKEUP = (dynamic)reader["PARM_CF_FW_CONSP_ACT_MAKEUP"],
                PARM_CF_FW_CONSP_UCT_MAKEUP = (dynamic)reader["PARM_CF_FW_CONSP_UCT_MAKEUP"],
                PARM_CF_PW_AB = (dynamic)reader["PARM_CF_PW_AB"],
                parm_proj_start_date = (dynamic)reader["parm_proj_start_date"],
                ln_op_stk = (dynamic)reader["ln_op_stk"]
            };
        }

        public async Task<PAS207Model> putData(string IN_DATE, char IN_BTN)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_GET_PPT_AM2_WATER_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", IN_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", IN_BTN));
                    PAS207Model response = null;
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

        public async Task saveData(PAS207SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_AM2_SAVE_PPT_AM2_WATER_DETAILS", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TRANS_DATE", value.A2_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_DMY_FLG", value.A2_DMY_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_USER_ID", value.A2_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_FW_CONSP_ACT_INT", value.A2_FW_CONSP_ACT_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_FW_CONSP_ACT", value.A2_FW_CONSP_ACT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_FW_CONSP_UCT_INT", value.A2_FW_CONSP_UCT_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_FW_CONSP_UCT", value.A2_FW_CONSP_UCT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_FW_CONSP_PLANT", value.A2_FW_CONSP_PLANT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_ACT_BLOWDOWN", value.A2_ACT_BLOWDOWN));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_UCT_BLOWDOWN", value.A2_UCT_BLOWDOWN));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_TOTAL_BLOWDOWN", value.A2_TOTAL_BLOWDOWN));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_GPI_DRAW_INT", value.A2_PW_GPI_DRAW_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_GPI_DRAW", value.A2_PW_GPI_DRAW));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_TANK_LEVEL", value.A2_PW_TANK_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_TANK_STOCK", value.A2_PW_TANK_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_CONSP_AB_INT", value.A2_PW_CONSP_AB_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_CONSP_AB", value.A2_PW_CONSP_AB));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_CONSP_RGB_INT", value.A2_PW_CONSP_RGB_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_CONSP_RGB", value.A2_PW_CONSP_RGB));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_CONSP_DESUPERHEAT_INT", value.A2_PW_CONSP_DESUPERHEAT_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_CONSP_DESUPERHEAT", value.A2_PW_CONSP_DESUPERHEAT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_CONSP_AMM2", value.A2_PW_CONSP_AMM2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_CONSP_UREA2", value.A2_PW_CONSP_UREA2));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_TOT_CONSP", value.A2_PW_TOT_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_APC_PROD_INT", value.A2_APC_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_APC_PROD", value.A2_APC_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_ATC_PROD_INT", value.A2_ATC_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_ATC_PROD", value.A2_ATC_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_ACTTC_PROD_INT", value.A2_ACTTC_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_ACTTC_PROD", value.A2_ACTTC_PROD));
                   // cmd.Parameters.Add(new SqlParameter("@IN_A2_REMARKS", value.A2_REMARKS));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_CONSP_AB_INT_DIFF", value.A2_PW_CONSP_AB_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_CONSP_DESUP1_INT", value.A2_PW_CONSP_DESUP1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_CONSP_DESUP1_INT_DIFF", value.A2_PW_CONSP_DESUP1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_CONSP_DESUP2_INT", value.A2_PW_CONSP_DESUP2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_CONSP_DESUP2_INT_DIFF", value.A2_PW_CONSP_DESUP2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CTTC_PROD_INT", value.A2_CTTC_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_CTTC_PROD", value.A2_CTTC_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_CONSP_QUENCH_INT", value.A2_PW_CONSP_QUENCH_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_CONSP_QUENCH_INT_DIFF", value.A2_PW_CONSP_QUENCH_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_FW_CONSP_UCT_AMM", value.A2_FW_CONSP_UCT_AMM));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_CONSP_LB", value.A2_PW_CONSP_LB));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_CONSP_LB_INT", value.A2_PW_CONSP_LB_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PW_CONSP_REVAMP", value.A2_PW_CONSP_REVAMP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PWR_WATER_INT", value.A2_PWR_WATER_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_PWR_WATER_CONSP", value.A2_PWR_WATER_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_SSF_BACK_WASH_IBD", value.A2_SSF_BACK_WASH_IBD));
                    cmd.Parameters.Add(new SqlParameter("@IN_A2_OILY_WATER", value.A2_OILY_WATER));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
