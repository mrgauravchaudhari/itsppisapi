using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class POS013Repository
    {
        private readonly string _connectionString;
        public POS013Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private POS013Model MapToValue(SqlDataReader reader)
        {
            return new POS013Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                OU1_TRANS_DATE = reader["OU1_TRANS_DATE"].ToString(),
                OU1_UNIT_ID = reader["OU1_UNIT_ID"].ToString(),
                OU1_DATE_MOD = reader["OU1_DATE_MOD"].ToString(),
                OU1_USER_ID = (decimal)reader["OU1_USER_ID"],
                OU1_USER_NAME = reader["OU1_USER_NAME"].ToString(),

                OU1_SERVICE_AIR_PROD_INT = (decimal)reader["OU1_SERVICE_AIR_PROD_INT"],
                OU1_SERVICE_AIR_PROD_INT_DIFF = (decimal)reader["OU1_SERVICE_AIR_PROD_INT_DIFF"],
                OU1_SERVICE_AIR_PRODUCTION = (decimal)reader["OU1_SERVICE_AIR_PRODUCTION"],
                OU1_NITROGEN_PROD_INT = (decimal)reader["OU1_NITROGEN_PROD_INT"],
                OU1_NITROGEN_PROD_INT_DIFF = (decimal)reader["OU1_NITROGEN_PROD_INT_DIFF"],
                OU1_NITROGEN_PRODUCTION = (decimal)reader["OU1_NITROGEN_PRODUCTION"],
                OU1_INST_AIR_CONS_UNIT1_INT = (decimal)reader["OU1_INST_AIR_CONS_UNIT1_INT"],
                OU1_INST_AIR_CONS_UNIT1_INT_DIF = (decimal)reader["OU1_INST_AIR_CONS_UNIT1_INT_DIF"],
                OU1_INST_AIR_CONS_UNIT1 = (decimal)reader["OU1_INST_AIR_CONS_UNIT1"],
                OU1_N2_CONSP_UNIT1_INT = (decimal)reader["OU1_N2_CONSP_UNIT1_INT"],
                OU1_N2_CONSP_UNIT1_INT_DIFF = (decimal)reader["OU1_N2_CONSP_UNIT1_INT_DIFF"],
                OU1_N2_CONSP_UNIT1 = (decimal)reader["OU1_N2_CONSP_UNIT1"],
                OU1_SERVICE_AIR_EXPORTT_UNIT2 = (decimal)reader["OU1_SERVICE_AIR_EXPORTT_UNIT2"],
                OU1_N2_CONSP_UNIT2_INT = (decimal)reader["OU1_N2_CONSP_UNIT2_INT"],
                OU1_N2_CONSP_UNIT2_INT_DIFF = (decimal)reader["OU1_N2_CONSP_UNIT2_INT_DIFF"],
                OU1_NITROGEN_EXPORTT_UNIT2 = (decimal)reader["OU1_NITROGEN_EXPORTT_UNIT2"],
                OU1_INST_AIR_CONS_UNIT2_INT = (decimal)reader["OU1_INST_AIR_CONS_UNIT2_INT"],
                OU1_INST_AIR_CONS_UNIT2_INT_DIF = (decimal)reader["OU1_INST_AIR_CONS_UNIT2_INT_DIF"],
                OU1_INST_AIR_CONS_UNIT2 = (decimal)reader["OU1_INST_AIR_CONS_UNIT2"],
                OU1_AUX_COMP_RHRS_UNIT2 = (decimal)reader["OU1_AUX_COMP_RHRS_UNIT2"],
                OU1_MAIN_COMP_RHRS_UNIT2 = (decimal)reader["OU1_MAIN_COMP_RHRS_UNIT2"],
                OU1_NO_AB_SU_SD = (decimal)reader["OU1_NO_AB_SU_SD"],
                OU1_NO_GT_SU_SD = (decimal)reader["OU1_NO_GT_SU_SD"],
                OU1_NO_2GTG_HRS = (decimal)reader["OU1_NO_2GTG_HRS"],
                OU1_OLD_BOTTLE_STRG_LVL = (decimal)reader["OU1_OLD_BOTTLE_STRG_LVL"],
                OU1_OLD_BOTTLE_STOCK = (decimal)reader["OU1_OLD_BOTTLE_STOCK"],
                OU1_NEW_BOTTLE_STRG_LVL = (decimal)reader["OU1_NEW_BOTTLE_STRG_LVL"],
                OU1_NEW_BOTTLE_STOCK = (decimal)reader["OU1_NEW_BOTTLE_STOCK"],
                OU1_N2_BOTTLE_STOCK = (decimal)reader["OU1_N2_BOTTLE_STOCK"],
                OU1_OLD_BOTTLE_LVL_BF_CONSP = (decimal)reader["OU1_OLD_BOTTLE_LVL_BF_CONSP"],
                OU1_OLD_BOTTLE_LVL_AF_CONSP = (decimal)reader["OU1_OLD_BOTTLE_LVL_AF_CONSP"],
                OU1_OLD_BOTTLE_CONSP = (decimal)reader["OU1_OLD_BOTTLE_CONSP"],
                OU1_NEW_BOTTLE_LVL_BF_CONSP = (decimal)reader["OU1_NEW_BOTTLE_LVL_BF_CONSP"],
                OU1_NEW_BOTTLE_LVL_AF_CONSP = (decimal)reader["OU1_NEW_BOTTLE_LVL_AF_CONSP"],
                OU1_NEW_BOTTLE_CONSP = (decimal)reader["OU1_NEW_BOTTLE_CONSP"],
                OU1_TOTAL_N2_BOTTLE_CONSP = (decimal)reader["OU1_TOTAL_N2_BOTTLE_CONSP"],
                OU1_OLD_BOTTLE_LVL_BF_UNLDG = (decimal)reader["OU1_OLD_BOTTLE_LVL_BF_UNLDG"],
                OU1_OLD_BOTTLE_LVL_AF_UNLDG = (decimal)reader["OU1_OLD_BOTTLE_LVL_AF_UNLDG"],
                OU1_OLD_BOTTLE_UNLD_QTY = (decimal)reader["OU1_OLD_BOTTLE_UNLD_QTY"],
                OU1_NEW_BOTTLE_LVL_BF_UNLDG = (decimal)reader["OU1_NEW_BOTTLE_LVL_BF_UNLDG"],
                OU1_NEW_BOTTLE_LVL_AF_UNLDG = (decimal)reader["OU1_NEW_BOTTLE_LVL_AF_UNLDG"],
                OU1_NEW_BOTTLE_UNLD_QTY = (decimal)reader["OU1_NEW_BOTTLE_UNLD_QTY"],
                OU1_TOTAL_N2_UNLD_QTY = (decimal)reader["OU1_TOTAL_N2_UNLD_QTY"],

                // ------------------PRV-----------------------------
                // PRV_OU_TRANS_DATE = reader["PRV_OU_TRANS_DATE"].ToString(),
                PRV_OU1_SERVICE_AIR_PROD_INT = (decimal)reader["PRV_OU1_SERVICE_AIR_PROD_INT"],
                PRV_OU1_SERVICE_AIR_PROD_INT_DIFF = (decimal)reader["PRV_OU1_SERVICE_AIR_PROD_INT_DIFF"],
                PRV_OU1_SERVICE_AIR_PRODUCTION = (decimal)reader["PRV_OU1_SERVICE_AIR_PRODUCTION"],
                PRV_OU1_NITROGEN_PROD_INT = (decimal)reader["PRV_OU1_NITROGEN_PROD_INT"],
                PRV_OU1_NITROGEN_PROD_INT_DIFF = (decimal)reader["PRV_OU1_NITROGEN_PROD_INT_DIFF"],
                PRV_OU1_NITROGEN_PRODUCTION = (decimal)reader["PRV_OU1_NITROGEN_PRODUCTION"],
                PRV_OU1_INST_AIR_CONS_UNIT1_INT = (decimal)reader["PRV_OU1_INST_AIR_CONS_UNIT1_INT"],
                PRV_OU1_INST_AIR_CONS_UNIT1_INT_DIF = (decimal)reader["PRV_OU1_INST_AIR_CONS_UNIT1_INT_DIF"],
                PRV_OU1_INST_AIR_CONS_UNIT1 = (decimal)reader["PRV_OU1_INST_AIR_CONS_UNIT1"],
                PRV_OU1_N2_CONSP_UNIT1_INT = (decimal)reader["PRV_OU1_N2_CONSP_UNIT1_INT"],
                PRV_OU1_N2_CONSP_UNIT1_INT_DIFF = (decimal)reader["PRV_OU1_N2_CONSP_UNIT1_INT_DIFF"],
                PRV_OU1_N2_CONSP_UNIT1 = (decimal)reader["PRV_OU1_N2_CONSP_UNIT1"],
                PRV_OU1_SERVICE_AIR_EXPORTT_UNIT2 = (decimal)reader["PRV_OU1_SERVICE_AIR_EXPORTT_UNIT2"],
                PRV_OU1_N2_CONSP_UNIT2_INT = (decimal)reader["PRV_OU1_N2_CONSP_UNIT2_INT"],
                PRV_OU1_N2_CONSP_UNIT2_INT_DIFF = (decimal)reader["PRV_OU1_N2_CONSP_UNIT2_INT_DIFF"],
                PRV_OU1_NITROGEN_EXPORTT_UNIT2 = (decimal)reader["PRV_OU1_NITROGEN_EXPORTT_UNIT2"],
                PRV_OU1_INST_AIR_CONS_UNIT2_INT = (decimal)reader["PRV_OU1_INST_AIR_CONS_UNIT2_INT"],
                PRV_OU1_INST_AIR_CONS_UNIT2_INT_DIF = (decimal)reader["PRV_OU1_INST_AIR_CONS_UNIT2_INT_DIF"],
                PRV_OU1_INST_AIR_CONS_UNIT2 = (decimal)reader["PRV_OU1_INST_AIR_CONS_UNIT2"],
                PRV_OU1_AUX_COMP_RHRS_UNIT2 = (decimal)reader["PRV_OU1_AUX_COMP_RHRS_UNIT2"],
                PRV_OU1_MAIN_COMP_RHRS_UNIT2 = (decimal)reader["PRV_OU1_MAIN_COMP_RHRS_UNIT2"],
                PRV_OU1_NO_AB_SU_SD = (decimal)reader["PRV_OU1_NO_AB_SU_SD"],
                PRV_OU1_NO_GT_SU_SD = (decimal)reader["PRV_OU1_NO_GT_SU_SD"],
                PRV_OU1_NO_2GTG_HRS = (decimal)reader["PRV_OU1_NO_2GTG_HRS"],
                PRV_OU1_OLD_BOTTLE_STRG_LVL = (decimal)reader["PRV_OU1_OLD_BOTTLE_STRG_LVL"],
                PRV_OU1_OLD_BOTTLE_STOCK = (decimal)reader["PRV_OU1_OLD_BOTTLE_STOCK"],
                PRV_OU1_NEW_BOTTLE_STRG_LVL = (decimal)reader["PRV_OU1_NEW_BOTTLE_STRG_LVL"],
                PRV_OU1_NEW_BOTTLE_STOCK = (decimal)reader["PRV_OU1_NEW_BOTTLE_STOCK"],
                PRV_OU1_N2_BOTTLE_STOCK = (decimal)reader["PRV_OU1_N2_BOTTLE_STOCK"],
                PRV_OU1_OLD_BOTTLE_LVL_BF_CONSP = (decimal)reader["PRV_OU1_OLD_BOTTLE_LVL_BF_CONSP"],
                PRV_OU1_OLD_BOTTLE_LVL_AF_CONSP = (decimal)reader["PRV_OU1_OLD_BOTTLE_LVL_AF_CONSP"],
                PRV_OU1_OLD_BOTTLE_CONSP = (decimal)reader["PRV_OU1_OLD_BOTTLE_CONSP"],
                PRV_OU1_NEW_BOTTLE_LVL_BF_CONSP = (decimal)reader["PRV_OU1_NEW_BOTTLE_LVL_BF_CONSP"],
                PRV_OU1_NEW_BOTTLE_LVL_AF_CONSP = (decimal)reader["PRV_OU1_NEW_BOTTLE_LVL_AF_CONSP"],
                PRV_OU1_NEW_BOTTLE_CONSP = (decimal)reader["PRV_OU1_NEW_BOTTLE_CONSP"],
                PRV_OU1_TOTAL_N2_BOTTLE_CONSP = (decimal)reader["PRV_OU1_TOTAL_N2_BOTTLE_CONSP"],
                PRV_OU1_OLD_BOTTLE_LVL_BF_UNLDG = (decimal)reader["PRV_OU1_OLD_BOTTLE_LVL_BF_UNLDG"],
                PRV_OU1_OLD_BOTTLE_LVL_AF_UNLDG = (decimal)reader["PRV_OU1_OLD_BOTTLE_LVL_AF_UNLDG"],
                PRV_OU1_OLD_BOTTLE_UNLD_QTY = (decimal)reader["PRV_OU1_OLD_BOTTLE_UNLD_QTY"],
                PRV_OU1_NEW_BOTTLE_LVL_BF_UNLDG = (decimal)reader["PRV_OU1_NEW_BOTTLE_LVL_BF_UNLDG"],
                PRV_OU1_NEW_BOTTLE_LVL_AF_UNLDG = (decimal)reader["PRV_OU1_NEW_BOTTLE_LVL_AF_UNLDG"],
                PRV_OU1_NEW_BOTTLE_UNLD_QTY = (decimal)reader["PRV_OU1_NEW_BOTTLE_UNLD_QTY"],
                PRV_OU1_TOTAL_N2_UNLD_QTY = (decimal)reader["PRV_OU1_TOTAL_N2_UNLD_QTY"],

                // ------------------DV-----------------------------
                parm_n2_density = (decimal)reader["parm_n2_density"],
                parm_mf_old_bottle = (decimal)reader["parm_mf_old_bottle"],
                parm_new_bottle_scale = (decimal)reader["parm_new_bottle_scale"],
                parm_new_bottle_cap = (decimal)reader["parm_new_bottle_cap"],
            };
        }

        public async Task<POS013Model> putData(TransactionDateBtnDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_GET_PPT_OU_UNIT2_UTILITIES", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    POS013Model response = null;
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

        public async Task saveData(POS013SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_SAVE_PPT_OU_UNIT2_UTILITIES", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TRANS_DATE", value.OU1_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UNIT_ID", value.OU1_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_USER_ID", value.OU1_USER_ID));

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SERVICE_AIR_PROD_INT", value.OU1_SERVICE_AIR_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SERVICE_AIR_PROD_INT_DIFF", value.OU1_SERVICE_AIR_PROD_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SERVICE_AIR_PRODUCTION", value.OU1_SERVICE_AIR_PRODUCTION));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SERVICE_AIR_EXPORTT_UNIT2", value.OU1_SERVICE_AIR_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NITROGEN_PROD_INT", value.OU1_NITROGEN_PROD_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NITROGEN_PROD_INT_DIFF", value.OU1_NITROGEN_PROD_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NITROGEN_PRODUCTION", value.OU1_NITROGEN_PRODUCTION));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NITROGEN_EXPORTT_UNIT2", value.OU1_NITROGEN_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_INST_AIR_CONS_UNIT1_INT", value.OU1_INST_AIR_CONS_UNIT1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_INST_AIR_CONS_UNIT1_INT_DIF", value.OU1_INST_AIR_CONS_UNIT1_INT_DIF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_INST_AIR_CONS_UNIT1", value.OU1_INST_AIR_CONS_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_INST_AIR_CONS_UNIT2_INT", value.OU1_INST_AIR_CONS_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_INST_AIR_CONS_UNIT2_INT_DIF", value.OU1_INST_AIR_CONS_UNIT2_INT_DIF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_INST_AIR_CONS_UNIT2", value.OU1_INST_AIR_CONS_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NO_AB_SU_SD", value.OU1_NO_AB_SU_SD));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NO_GT_SU_SD", value.OU1_NO_GT_SU_SD));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NO_2GTG_HRS", value.OU1_NO_2GTG_HRS));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N2_CONSP_UNIT2_INT", value.OU1_N2_CONSP_UNIT2_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N2_CONSP_UNIT2_INT_DIFF", value.OU1_N2_CONSP_UNIT2_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_AUX_COMP_RHRS_UNIT2", value.OU1_AUX_COMP_RHRS_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_MAIN_COMP_RHRS_UNIT2", value.OU1_MAIN_COMP_RHRS_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UREA_II_PROD", value.OU1_UREA_II_PROD));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N2_CONSP_UNIT1_INT", value.OU1_N2_CONSP_UNIT1_INT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N2_CONSP_UNIT1_INT_DIFF", value.OU1_N2_CONSP_UNIT1_INT_DIFF));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N2_CONSP_UNIT1", value.OU1_N2_CONSP_UNIT1));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N2_PRCHSD_UNIT2", value.OU1_N2_PRCHSD_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_OLD_BOTTLE_STRG_LVL", value.OU1_OLD_BOTTLE_STRG_LVL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_OLD_BOTTLE_STOCK", value.OU1_OLD_BOTTLE_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NEW_BOTTLE_STRG_LVL", value.OU1_NEW_BOTTLE_STRG_LVL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NEW_BOTTLE_STOCK", value.OU1_NEW_BOTTLE_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N2_BOTTLE_STOCK", value.OU1_N2_BOTTLE_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_OLD_BOTTLE_LVL_BF_CONSP", value.OU1_OLD_BOTTLE_LVL_BF_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_OLD_BOTTLE_LVL_AF_CONSP", value.OU1_OLD_BOTTLE_LVL_AF_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_OLD_BOTTLE_CONSP", value.OU1_OLD_BOTTLE_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NEW_BOTTLE_LVL_BF_CONSP", value.OU1_NEW_BOTTLE_LVL_BF_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NEW_BOTTLE_LVL_AF_CONSP", value.OU1_NEW_BOTTLE_LVL_AF_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NEW_BOTTLE_CONSP", value.OU1_NEW_BOTTLE_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TOTAL_N2_BOTTLE_CONSP", value.OU1_TOTAL_N2_BOTTLE_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_OLD_BOTTLE_LVL_BF_UNLDG", value.OU1_OLD_BOTTLE_LVL_BF_UNLDG));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_OLD_BOTTLE_LVL_AF_UNLDG", value.OU1_OLD_BOTTLE_LVL_AF_UNLDG));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_OLD_BOTTLE_UNLD_QTY", value.OU1_OLD_BOTTLE_UNLD_QTY));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NEW_BOTTLE_LVL_BF_UNLDG", value.OU1_NEW_BOTTLE_LVL_BF_UNLDG));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NEW_BOTTLE_LVL_AF_UNLDG", value.OU1_NEW_BOTTLE_LVL_AF_UNLDG));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NEW_BOTTLE_UNLD_QTY", value.OU1_NEW_BOTTLE_UNLD_QTY));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TOTAL_N2_UNLD_QTY", value.OU1_TOTAL_N2_UNLD_QTY));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
