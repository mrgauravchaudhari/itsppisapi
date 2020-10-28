using itsppisapi.Dtos;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace itsppisapi.Data
{
    public class POS003Repository
    {
        private readonly string _connectionString;
        public POS003Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }
        private Func_IN_STK_Model MapToValue2(SqlDataReader reader)
        {
            return new Func_IN_STK_Model()
            {
                IN_STK = (decimal)reader["IN_STK"],
            };
        }

        public async Task<Func_IN_STK_Model> putData(Func_IN_STK_Dto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT PPIS.PPU_F_GET_CHEMICAL_STOCK('" + value.OU1_CHEMICAL_ID + "','" + value.OU1_CHEMICAL_LEVEL + "') AS IN_STK", sql))
                {
                    Func_IN_STK_Model response = null;
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

        private POS003Model MapToValue(SqlDataReader reader)
        {
            return new POS003Model()
            {
                MINDT = reader["MINDT"].ToString(),
                MAXDT = reader["MAXDT"].ToString(),
                OU1_TRANS_DATE = reader["OU1_TRANS_DATE"].ToString(),
                OU1_UNIT_ID = reader["OU1_UNIT_ID"].ToString(),
                OU1_DATE_MOD = reader["OU1_DATE_MOD"].ToString(),
                OU1_USER_ID = (decimal)reader["OU1_USER_ID"],
                OU1_USER_NAME = reader["OU1_USER_NAME"].ToString(),

                OU1_HCL_RECPT = (dynamic)reader["OU1_HCL_RECPT"],
                OU1_HCL_OTANK_LEVEL = (dynamic)reader["OU1_HCL_OTANK_LEVEL"],
                OU1_HCL_OTANK_STOCK = (dynamic)reader["OU1_HCL_OTANK_STOCK"],
                OU1_HCL_NTANK_LEVEL = (dynamic)reader["OU1_HCL_NTANK_LEVEL"],
                OU1_HCL_NTANK_STOCK = (dynamic)reader["OU1_HCL_NTANK_STOCK"],
                OU1_HCL_STOCK = (dynamic)reader["OU1_HCL_STOCK"],
                OU1_HCL_CONSP = (dynamic)reader["OU1_HCL_CONSP"],
                OU1_SULACID_RECPT = (dynamic)reader["OU1_SULACID_RECPT"],
                OU1_SULACID_TANK_LEVEL = (dynamic)reader["OU1_SULACID_TANK_LEVEL"],
                OU1_SULACID_STOCK = (dynamic)reader["OU1_SULACID_STOCK"],
                OU1_SULACID_CONSP = (dynamic)reader["OU1_SULACID_CONSP"],
                OU1_CLYE_RECPT = (dynamic)reader["OU1_CLYE_RECPT"],
                OU1_CLYE_TANK_LEVEL = (dynamic)reader["OU1_CLYE_TANK_LEVEL"],
                OU1_CLYE_STOCK = (dynamic)reader["OU1_CLYE_STOCK"],
                OU1_CLYE_CONSP = (dynamic)reader["OU1_CLYE_CONSP"],
                OU1_HSD_RECPT = (dynamic)reader["OU1_HSD_RECPT"],
                OU1_HSD_EDG_LEVEL = (dynamic)reader["OU1_HSD_EDG_LEVEL"],
                // OU1_HSD_EDG_STOCK = (dynamic)reader["OU1_HSD_EDG_STOCK"],
                OU1_HSD_GT_LEVEL = (dynamic)reader["OU1_HSD_GT_LEVEL"],
                // OU1_HSD_GT_STOCK = (dynamic)reader["OU1_HSD_GT_STOCK"],
                OU1_HSD_NEW_LEVEL = (dynamic)reader["OU1_HSD_NEW_LEVEL"],
                // OU1_HSD_NEW_STOCK = (dynamic)reader["OU1_HSD_NEW_STOCK"],
                OU1_HSD_STOCK = (dynamic)reader["OU1_HSD_STOCK"],
                OU1_HSD_CONSP = (dynamic)reader["OU1_HSD_CONSP"],
                OU1_ALUM_RECPT = (dynamic)reader["OU1_ALUM_RECPT"],
                OU1_ALUM_STOCK = (dynamic)reader["OU1_ALUM_STOCK"],
                OU1_ALUM_CONSP = (dynamic)reader["OU1_ALUM_CONSP"],
                OU1_CHLWPT_RECPT = (dynamic)reader["OU1_CHLWPT_RECPT"],
                OU1_CHLWPT_STOCK = (dynamic)reader["OU1_CHLWPT_STOCK"],
                OU1_CHLWPT_CONSP = (dynamic)reader["OU1_CHLWPT_CONSP"],
                OU1_CHLRW_RECPT = (dynamic)reader["OU1_CHLRW_RECPT"],
                OU1_CHLRW_STOCK = (dynamic)reader["OU1_CHLRW_STOCK"],
                OU1_CHLRW_CONSP = (dynamic)reader["OU1_CHLRW_CONSP"],
                OU1_CHLCT_RECPT = (dynamic)reader["OU1_CHLCT_RECPT"],
                OU1_CHLCT_STOCK = (dynamic)reader["OU1_CHLCT_STOCK"],
                OU1_CHLCT_CONSP = (dynamic)reader["OU1_CHLCT_CONSP"],
                OU1_HYPO_RECPT = (dynamic)reader["OU1_HYPO_RECPT"],
                OU1_HYPO_STOCK = (dynamic)reader["OU1_HYPO_STOCK"],
                OU1_HYPO_CONSP = (dynamic)reader["OU1_HYPO_CONSP"],
                OU1_N7356_RECPT = (dynamic)reader["OU1_N7356_RECPT"],
                OU1_N7356_STOCK = (dynamic)reader["OU1_N7356_STOCK"],
                OU1_N7356_CONSP = (dynamic)reader["OU1_N7356_CONSP"],
                OU1_N8301D_RECPT = (dynamic)reader["OU1_N8301D_RECPT"],
                OU1_N8301D_STOCK = (dynamic)reader["OU1_N8301D_STOCK"],
                OU1_N8301D_CONSP = (dynamic)reader["OU1_N8301D_CONSP"],
                // OU1_N7348_RECPT = (dynamic)reader["OU1_N7348_RECPT"],
                // OU1_N7348_STOCK = (dynamic)reader["OU1_N7348_STOCK"],
                // OU1_N7348_CONSP = (dynamic)reader["OU1_N7348_CONSP"],
                OU1_N7342_RECPT = (dynamic)reader["OU1_N7342_RECPT"],
                OU1_N7342_STOCK = (dynamic)reader["OU1_N7342_STOCK"],
                OU1_N7342_CONSP = (dynamic)reader["OU1_N7342_CONSP"],
                OU1_N7307_RECPT = (dynamic)reader["OU1_N7307_RECPT"],
                OU1_N7307_STOCK = (dynamic)reader["OU1_N7307_STOCK"],
                OU1_N7307_CONSP = (dynamic)reader["OU1_N7307_CONSP"],
                OU1_STBX_RECPT = (dynamic)reader["OU1_STBX_RECPT"],
                OU1_STBX_STOCK = (dynamic)reader["OU1_STBX_STOCK"],
                OU1_STBX_CONSP = (dynamic)reader["OU1_STBX_CONSP"],
                OU1_HYDRAZINE_RECPT = (dynamic)reader["OU1_HYDRAZINE_RECPT"],
                OU1_HYDRAZINE_STOCK = (dynamic)reader["OU1_HYDRAZINE_STOCK"],
                OU1_HYDRAZINE_CONSP = (dynamic)reader["OU1_HYDRAZINE_CONSP"],
                OU1_TSP_RECPT = (dynamic)reader["OU1_TSP_RECPT"],
                OU1_TSP_STOCK = (dynamic)reader["OU1_TSP_STOCK"],
                OU1_TSP_CONSP = (dynamic)reader["OU1_TSP_CONSP"],
                OU1_HITECH_RECPT = (dynamic)reader["OU1_HITECH_RECPT"],
                OU1_HITECH_STOCK = (dynamic)reader["OU1_HITECH_STOCK"],
                OU1_HITECH_CONSP = (dynamic)reader["OU1_HITECH_CONSP"],
                OU1_POLYEL_RECPT = (dynamic)reader["OU1_POLYEL_RECPT"],
                OU1_POLYEL_STOCK = (dynamic)reader["OU1_POLYEL_STOCK"],
                OU1_POLYEL_CONSP = (dynamic)reader["OU1_POLYEL_CONSP"],
                OU1_ACT_ALUM_RECPT = (dynamic)reader["OU1_ACT_ALUM_RECPT"],
                OU1_ACT_ALUM_STOCK = (dynamic)reader["OU1_ACT_ALUM_STOCK"],
                OU1_ACT_ALUM_CONSP = (dynamic)reader["OU1_ACT_ALUM_CONSP"],
                OU1_MOLSIEVE_RECPT = (dynamic)reader["OU1_MOLSIEVE_RECPT"],
                OU1_MOLSIEVE_STOCK = (dynamic)reader["OU1_MOLSIEVE_STOCK"],
                OU1_MOLSIEVE_CONSP = (dynamic)reader["OU1_MOLSIEVE_CONSP"],
                OU1_ACT_CARBON_RECPT = (dynamic)reader["OU1_ACT_CARBON_RECPT"],
                OU1_ACT_CARBON_STOCK = (dynamic)reader["OU1_ACT_CARBON_STOCK"],
                OU1_ACT_CARBON_CONSP = (dynamic)reader["OU1_ACT_CARBON_CONSP"],
                OU1_SSF_PEB_RECPT = (dynamic)reader["OU1_SSF_PEB_RECPT"],
                OU1_SSF_PEB_STOCK = (dynamic)reader["OU1_SSF_PEB_STOCK"],
                OU1_SSF_PEB_CONSP = (dynamic)reader["OU1_SSF_PEB_CONSP"],
                OU1_SSF_SAND_RECPT = (dynamic)reader["OU1_SSF_SAND_RECPT"],
                OU1_SSF_SAND_STOCK = (dynamic)reader["OU1_SSF_SAND_STOCK"],
                OU1_SSF_SAND_CONSP = (dynamic)reader["OU1_SSF_SAND_CONSP"],
                OU1_DMP_PEB_RECPT = (dynamic)reader["OU1_DMP_PEB_RECPT"],
                OU1_DMP_PEB_STOCK = (dynamic)reader["OU1_DMP_PEB_STOCK"],
                OU1_DMP_PEB_CONSP = (dynamic)reader["OU1_DMP_PEB_CONSP"],
                OU1_WPT_SAND_RECPT = (dynamic)reader["OU1_WPT_SAND_RECPT"],
                OU1_WPT_SAND_STOCK = (dynamic)reader["OU1_WPT_SAND_STOCK"],
                OU1_WPT_SAND_CONSP = (dynamic)reader["OU1_WPT_SAND_CONSP"],
                OU1_INDION225_RECPT = (dynamic)reader["OU1_INDION225_RECPT"],
                OU1_INDION225_STOCK = (dynamic)reader["OU1_INDION225_STOCK"],
                OU1_INDION225_CONSP = (dynamic)reader["OU1_INDION225_CONSP"],
                OU1_INDION850_RECPT = (dynamic)reader["OU1_INDION850_RECPT"],
                OU1_INDION850_STOCK = (dynamic)reader["OU1_INDION850_STOCK"],
                OU1_INDION850_CONSP = (dynamic)reader["OU1_INDION850_CONSP"],
                OU1_FFIP_RECPT = (dynamic)reader["OU1_FFIP_RECPT"],
                OU1_FFIP_STOCK = (dynamic)reader["OU1_FFIP_STOCK"],
                OU1_FFIP_CONSP = (dynamic)reader["OU1_FFIP_CONSP"],
                // OU1_N8301D_REMARK = reader["OU1_N8301D_REMARK"].ToString(),
                // OU1_N7356_REMARK = reader["OU1_N7356_REMARK"].ToString(),
                // OU1_N7348_REMARK = reader["OU1_N7348_REMARK"].ToString(),
                // OU1_N7342_REMARK = reader["OU1_N7342_REMARK"].ToString(),
                // OU1_N7307_REMARK = reader["OU1_N7307_REMARK"].ToString(),
                // OU1_STABREX_REMARK = reader["OU1_STABREX_REMARK"].ToString(),
                OU1_REMARKS = reader["OU1_REMARKS"].ToString(),
                OU1_HSD_EXPORTT_UNIT2 = (dynamic)reader["OU1_HSD_EXPORTT_UNIT2"],
                OU1_HCL_G2TANK_LEVEL = (dynamic)reader["OU1_HCL_G2TANK_LEVEL"],
                OU1_CLYE_G2TANK_LEVEL = (dynamic)reader["OU1_CLYE_G2TANK_LEVEL"],
                OU1_HLIME_RECPT = (dynamic)reader["OU1_HLIME_RECPT"],
                OU1_HLIME_STOCK = (dynamic)reader["OU1_HLIME_STOCK"],
                OU1_HLIME_CONSP = (dynamic)reader["OU1_HLIME_CONSP"],
                OU1_HCL_G2TANK_STOCK = (dynamic)reader["OU1_HCL_G2TANK_STOCK"],
                OU1_CLYE_G2TANK_STOCK = (dynamic)reader["OU1_CLYE_G2TANK_STOCK"],
                OU1_CLYE_OTANK_STOCK = (dynamic)reader["OU1_CLYE_OTANK_STOCK"],
                OU1_HYPO_RECPT_STP = (dynamic)reader["OU1_HYPO_RECPT_STP"],
                OU1_HYPO_CONSP_STP = (dynamic)reader["OU1_HYPO_CONSP_STP"],
                OU1_HYPO_STOCK_STP = (dynamic)reader["OU1_HYPO_STOCK_STP"],
                OU1_N7308_RECPT = (dynamic)reader["OU1_N7308_RECPT"],
                OU1_N7308_CONSP = (dynamic)reader["OU1_N7308_CONSP"],
                OU1_N7308_STOCK = (dynamic)reader["OU1_N7308_STOCK"],
                OU1_BLEACH_POWDER_RECPT = (dynamic)reader["OU1_BLEACH_POWDER_RECPT"],
                OU1_BLEACH_POWDER_CONSP = (dynamic)reader["OU1_BLEACH_POWDER_CONSP"],
                OU1_BLEACH_POWDER_STOCK = (dynamic)reader["OU1_BLEACH_POWDER_STOCK"],
                OU1_PAC_RECPT = (dynamic)reader["OU1_PAC_RECPT"],
                OU1_PAC_CONSP = (dynamic)reader["OU1_PAC_CONSP"],
                OU1_PAC_STOCK = (dynamic)reader["OU1_PAC_STOCK"],
                OU1_NAP315_RECPT = (dynamic)reader["OU1_NAP315_RECPT"],
                OU1_NAP315_CONSP = (dynamic)reader["OU1_NAP315_CONSP"],
                OU1_NAP315_STOCK = (dynamic)reader["OU1_NAP315_STOCK"],
                OU1_NA1005_RECPT = (dynamic)reader["OU1_NA1005_RECPT"],
                OU1_NA1005_CONSP = (dynamic)reader["OU1_NA1005_CONSP"],
                OU1_NA1005_STOCK = (dynamic)reader["OU1_NA1005_STOCK"],
                // OU1_NA1002_RECPT = (dynamic)reader["OU1_NA1002_RECPT"],
                // OU1_NA1002_CONSP = (dynamic)reader["OU1_NA1002_CONSP"],
                // OU1_NA1002_STOCK = (dynamic)reader["OU1_NA1002_STOCK"],
                // OU1_RESIN_T42_RECPT = (dynamic)reader["OU1_RESIN_T42_RECPT"],
                // OU1_RESIN_T42_CONSP = (dynamic)reader["OU1_RESIN_T42_CONSP"],
                // OU1_RESIN_T42_STOCK = (dynamic)reader["OU1_RESIN_T42_STOCK"],
                // OU1_RESIN_T23_RECPT = (dynamic)reader["OU1_RESIN_T23_RECPT"],
                // OU1_RESIN_T23_CONSP = (dynamic)reader["OU1_RESIN_T23_CONSP"],
                // OU1_RESIN_T23_STOCK = (dynamic)reader["OU1_RESIN_T23_STOCK"],
                // OU1_N8300_RECPT = (dynamic)reader["OU1_N8300_RECPT"],
                // OU1_N8300_CONSP = (dynamic)reader["OU1_N8300_CONSP"],
                // OU1_N8300_STOCK = (dynamic)reader["OU1_N8300_STOCK"],
                OU1_N73202_RECPT = (dynamic)reader["OU1_N73202_RECPT"],
                OU1_N73202_CONSP = (dynamic)reader["OU1_N73202_CONSP"],
                OU1_N73202_STOCK = (dynamic)reader["OU1_N73202_STOCK"],
                OU1_PAC_TANKA_LEVEL = (dynamic)reader["OU1_PAC_TANKA_LEVEL"],
                OU1_PAC_TANKA_STOCK = (dynamic)reader["OU1_PAC_TANKA_STOCK"],
                OU1_PAC_TANKB_STOCK = (dynamic)reader["OU1_PAC_TANKB_STOCK"],
                OU1_PAC_TANKB_LEVEL = (dynamic)reader["OU1_PAC_TANKB_LEVEL"],
                OU1_CD2001L_RECPT = (dynamic)reader["OU1_CD2001L_RECPT"],
                OU1_CD2001L_CONSP = (dynamic)reader["OU1_CD2001L_CONSP"],
                OU1_CD2001L_STOCK = (dynamic)reader["OU1_CD2001L_STOCK"],
                OU1_CDDS_HPA_RECPT = (dynamic)reader["OU1_CDDS_HPA_RECPT"],
                OU1_CDDS_HPA_CONSP = (dynamic)reader["OU1_CDDS_HPA_CONSP"],
                OU1_CDDS_HPA_STOCK = (dynamic)reader["OU1_CDDS_HPA_STOCK"],
                OU1_CDDS_2625AC_RECPT = (dynamic)reader["OU1_CDDS_2625AC_RECPT"],
                OU1_CDDS_2625AC_CONSP = (dynamic)reader["OU1_CDDS_2625AC_CONSP"],
                OU1_CDDS_2625AC_STOCK = (dynamic)reader["OU1_CDDS_2625AC_STOCK"],
                OU1_HCL_NEWTANK_STOCK = (dynamic)reader["OU1_HCL_NEWTANK_STOCK"],

                // ---------------------PRV---------------------
                PRV_OU1_TRANS_DATE = (dynamic)reader["PRV_OU1_TRANS_DATE"],
                PRV_OU1_HCL_RECPT = (dynamic)reader["PRV_OU1_HCL_RECPT"],
                PRV_OU1_HCL_G2TANK_LEVEL = (dynamic)reader["PRV_OU1_HCL_G2TANK_LEVEL"],
                PRV_OU1_HCL_NTANK_LEVEL = (dynamic)reader["PRV_OU1_HCL_NTANK_LEVEL"],
                PRV_OU1_HCL_NEWTANK_STOCK = (dynamic)reader["PRV_OU1_HCL_NEWTANK_STOCK"],
                PRV_OU1_HCL_STOCK = (dynamic)reader["PRV_OU1_HCL_STOCK"],
                PRV_OU1_HCL_OTANK_LEVEL = (dynamic)reader["PRV_OU1_HCL_OTANK_LEVEL"],
                PRV_OU1_HCL_CONSP = (dynamic)reader["PRV_OU1_HCL_CONSP"],
                PRV_OU1_CLYE_RECPT = (dynamic)reader["PRV_OU1_CLYE_RECPT"],
                PRV_OU1_CLYE_TANK_LEVEL = (dynamic)reader["PRV_OU1_CLYE_TANK_LEVEL"],
                PRV_OU1_CLYE_G2TANK_LEVEL = (dynamic)reader["PRV_OU1_CLYE_G2TANK_LEVEL"],
                PRV_OU1_CLYE_STOCK = (dynamic)reader["PRV_OU1_CLYE_STOCK"],
                PRV_OU1_CLYE_CONSP = (dynamic)reader["PRV_OU1_CLYE_CONSP"],
                PRV_OU1_SULACID_RECPT = (dynamic)reader["PRV_OU1_SULACID_RECPT"],
                PRV_OU1_SULACID_TANK_LEVEL = (dynamic)reader["PRV_OU1_SULACID_TANK_LEVEL"],
                PRV_OU1_SULACID_STOCK = (dynamic)reader["PRV_OU1_SULACID_STOCK"],
                PRV_OU1_SULACID_CONSP = (dynamic)reader["PRV_OU1_SULACID_CONSP"],
                PRV_OU1_HSD_RECPT = (dynamic)reader["PRV_OU1_HSD_RECPT"],
                PRV_OU1_HSD_EDG_LEVEL = (dynamic)reader["PRV_OU1_HSD_EDG_LEVEL"],
                PRV_OU1_HSD_GT_LEVEL = (dynamic)reader["PRV_OU1_HSD_GT_LEVEL"],
                PRV_OU1_HSD_NEW_LEVEL = (dynamic)reader["PRV_OU1_HSD_NEW_LEVEL"],
                PRV_OU1_HSD_EXPORTT_UNIT2 = (dynamic)reader["PRV_OU1_HSD_EXPORTT_UNIT2"],
                PRV_OU1_HSD_CONSP = (dynamic)reader["PRV_OU1_HSD_CONSP"],
                PRV_OU1_HSD_STOCK = (dynamic)reader["PRV_OU1_HSD_STOCK"],
                PRV_OU1_ALUM_RECPT = (dynamic)reader["PRV_OU1_ALUM_RECPT"],
                PRV_OU1_ALUM_CONSP = (dynamic)reader["PRV_OU1_ALUM_CONSP"],
                PRV_OU1_ALUM_STOCK = (dynamic)reader["PRV_OU1_ALUM_STOCK"],
                PRV_OU1_CHLWPT_RECPT = (dynamic)reader["PRV_OU1_CHLWPT_RECPT"],
                PRV_OU1_CHLWPT_CONSP = (dynamic)reader["PRV_OU1_CHLWPT_CONSP"],
                PRV_OU1_CHLWPT_STOCK = (dynamic)reader["PRV_OU1_CHLWPT_STOCK"],
                PRV_OU1_CHLRW_RECPT = (dynamic)reader["PRV_OU1_CHLRW_RECPT"],
                PRV_OU1_CHLRW_CONSP = (dynamic)reader["PRV_OU1_CHLRW_CONSP"],
                PRV_OU1_CHLRW_STOCK = (dynamic)reader["PRV_OU1_CHLRW_STOCK"],
                PRV_OU1_CHLCT_RECPT = (dynamic)reader["PRV_OU1_CHLCT_RECPT"],
                PRV_OU1_CHLCT_CONSP = (dynamic)reader["PRV_OU1_CHLCT_CONSP"],
                PRV_OU1_CHLCT_STOCK = (dynamic)reader["PRV_OU1_CHLCT_STOCK"],
                PRV_OU1_HYPO_RECPT = (dynamic)reader["PRV_OU1_HYPO_RECPT"],
                PRV_OU1_HYPO_CONSP = (dynamic)reader["PRV_OU1_HYPO_CONSP"],
                PRV_OU1_HYPO_STOCK = (dynamic)reader["PRV_OU1_HYPO_STOCK"],
                PRV_OU1_HYPO_RECPT_STP = (dynamic)reader["PRV_OU1_HYPO_RECPT_STP"],
                PRV_OU1_HYPO_CONSP_STP = (dynamic)reader["PRV_OU1_HYPO_CONSP_STP"],
                PRV_OU1_HYPO_STOCK_STP = (dynamic)reader["PRV_OU1_HYPO_STOCK_STP"],
                PRV_OU1_N7356_RECPT = (dynamic)reader["PRV_OU1_N7356_RECPT"],
                PRV_OU1_N7356_CONSP = (dynamic)reader["PRV_OU1_N7356_CONSP"],
                PRV_OU1_N7356_STOCK = (dynamic)reader["PRV_OU1_N7356_STOCK"],
                PRV_OU1_N8301D_RECPT = (dynamic)reader["PRV_OU1_N8301D_RECPT"],
                PRV_OU1_N8301D_CONSP = (dynamic)reader["PRV_OU1_N8301D_CONSP"],
                PRV_OU1_N8301D_STOCK = (dynamic)reader["PRV_OU1_N8301D_STOCK"],
                PRV_OU1_N7342_RECPT = (dynamic)reader["PRV_OU1_N7342_RECPT"],
                PRV_OU1_N7342_CONSP = (dynamic)reader["PRV_OU1_N7342_CONSP"],
                PRV_OU1_N7342_STOCK = (dynamic)reader["PRV_OU1_N7342_STOCK"],
                PRV_OU1_N7307_RECPT = (dynamic)reader["PRV_OU1_N7307_RECPT"],
                PRV_OU1_N7307_CONSP = (dynamic)reader["PRV_OU1_N7307_CONSP"],
                PRV_OU1_N7307_STOCK = (dynamic)reader["PRV_OU1_N7307_STOCK"],
                PRV_OU1_N7308_RECPT = (dynamic)reader["PRV_OU1_N7308_RECPT"],
                PRV_OU1_N7308_CONSP = (dynamic)reader["PRV_OU1_N7308_CONSP"],
                PRV_OU1_N7308_STOCK = (dynamic)reader["PRV_OU1_N7308_STOCK"],
                PRV_OU1_STBX_RECPT = (dynamic)reader["PRV_OU1_STBX_RECPT"],
                PRV_OU1_STBX_CONSP = (dynamic)reader["PRV_OU1_STBX_CONSP"],
                PRV_OU1_STBX_STOCK = (dynamic)reader["PRV_OU1_STBX_STOCK"],
                PRV_OU1_HYDRAZINE_RECPT = (dynamic)reader["PRV_OU1_HYDRAZINE_RECPT"],
                PRV_OU1_HYDRAZINE_CONSP = (dynamic)reader["PRV_OU1_HYDRAZINE_CONSP"],
                PRV_OU1_HYDRAZINE_STOCK = (dynamic)reader["PRV_OU1_HYDRAZINE_STOCK"],
                PRV_OU1_TSP_RECPT = (dynamic)reader["PRV_OU1_TSP_RECPT"],
                PRV_OU1_TSP_CONSP = (dynamic)reader["PRV_OU1_TSP_CONSP"],
                PRV_OU1_TSP_STOCK = (dynamic)reader["PRV_OU1_TSP_STOCK"],
                PRV_OU1_HITECH_RECPT = (dynamic)reader["PRV_OU1_HITECH_RECPT"],
                PRV_OU1_HITECH_CONSP = (dynamic)reader["PRV_OU1_HITECH_CONSP"],
                PRV_OU1_HITECH_STOCK = (dynamic)reader["PRV_OU1_HITECH_STOCK"],
                PRV_OU1_POLYEL_RECPT = (dynamic)reader["PRV_OU1_POLYEL_RECPT"],
                PRV_OU1_POLYEL_CONSP = (dynamic)reader["PRV_OU1_POLYEL_CONSP"],
                PRV_OU1_POLYEL_STOCK = (dynamic)reader["PRV_OU1_POLYEL_STOCK"],
                PRV_OU1_ACT_ALUM_RECPT = (dynamic)reader["PRV_OU1_ACT_ALUM_RECPT"],
                PRV_OU1_ACT_ALUM_CONSP = (dynamic)reader["PRV_OU1_ACT_ALUM_CONSP"],
                PRV_OU1_ACT_ALUM_STOCK = (dynamic)reader["PRV_OU1_ACT_ALUM_STOCK"],
                PRV_OU1_MOLSIEVE_RECPT = (dynamic)reader["PRV_OU1_MOLSIEVE_RECPT"],
                PRV_OU1_MOLSIEVE_CONSP = (dynamic)reader["PRV_OU1_MOLSIEVE_CONSP"],
                PRV_OU1_MOLSIEVE_STOCK = (dynamic)reader["PRV_OU1_MOLSIEVE_STOCK"],
                PRV_OU1_ACT_CARBON_RECPT = (dynamic)reader["PRV_OU1_ACT_CARBON_RECPT"],
                PRV_OU1_ACT_CARBON_CONSP = (dynamic)reader["PRV_OU1_ACT_CARBON_CONSP"],
                PRV_OU1_ACT_CARBON_STOCK = (dynamic)reader["PRV_OU1_ACT_CARBON_STOCK"],
                PRV_OU1_SSF_PEB_RECPT = (dynamic)reader["PRV_OU1_SSF_PEB_RECPT"],
                PRV_OU1_SSF_PEB_CONSP = (dynamic)reader["PRV_OU1_SSF_PEB_CONSP"],
                PRV_OU1_SSF_PEB_STOCK = (dynamic)reader["PRV_OU1_SSF_PEB_STOCK"],
                PRV_OU1_SSF_SAND_RECPT = (dynamic)reader["PRV_OU1_SSF_SAND_RECPT"],
                PRV_OU1_SSF_SAND_CONSP = (dynamic)reader["PRV_OU1_SSF_SAND_CONSP"],
                PRV_OU1_SSF_SAND_STOCK = (dynamic)reader["PRV_OU1_SSF_SAND_STOCK"],
                PRV_OU1_DMP_PEB_RECPT = (dynamic)reader["PRV_OU1_DMP_PEB_RECPT"],
                PRV_OU1_DMP_PEB_CONSP = (dynamic)reader["PRV_OU1_DMP_PEB_CONSP"],
                PRV_OU1_DMP_PEB_STOCK = (dynamic)reader["PRV_OU1_DMP_PEB_STOCK"],
                PRV_OU1_WPT_SAND_RECPT = (dynamic)reader["PRV_OU1_WPT_SAND_RECPT"],
                PRV_OU1_WPT_SAND_CONSP = (dynamic)reader["PRV_OU1_WPT_SAND_CONSP"],
                PRV_OU1_WPT_SAND_STOCK = (dynamic)reader["PRV_OU1_WPT_SAND_STOCK"],
                PRV_OU1_INDION225_RECPT = (dynamic)reader["PRV_OU1_INDION225_RECPT"],
                PRV_OU1_INDION225_CONSP = (dynamic)reader["PRV_OU1_INDION225_CONSP"],
                PRV_OU1_INDION225_STOCK = (dynamic)reader["PRV_OU1_INDION225_STOCK"],
                PRV_OU1_INDION850_RECPT = (dynamic)reader["PRV_OU1_INDION850_RECPT"],
                PRV_OU1_INDION850_CONSP = (dynamic)reader["PRV_OU1_INDION850_CONSP"],
                PRV_OU1_INDION850_STOCK = (dynamic)reader["PRV_OU1_INDION850_STOCK"],
                PRV_OU1_FFIP_RECPT = (dynamic)reader["PRV_OU1_FFIP_RECPT"],
                PRV_OU1_FFIP_CONSP = (dynamic)reader["PRV_OU1_FFIP_CONSP"],
                PRV_OU1_FFIP_STOCK = (dynamic)reader["PRV_OU1_FFIP_STOCK"],
                PRV_OU1_HLIME_RECPT = (dynamic)reader["PRV_OU1_HLIME_RECPT"],
                PRV_OU1_HLIME_CONSP = (dynamic)reader["PRV_OU1_HLIME_CONSP"],
                PRV_OU1_HLIME_STOCK = (dynamic)reader["PRV_OU1_HLIME_STOCK"],
                PRV_OU1_BLEACH_POWDER_RECPT = (dynamic)reader["PRV_OU1_BLEACH_POWDER_RECPT"],
                PRV_OU1_BLEACH_POWDER_CONSP = (dynamic)reader["PRV_OU1_BLEACH_POWDER_CONSP"],
                PRV_OU1_BLEACH_POWDER_STOCK = (dynamic)reader["PRV_OU1_BLEACH_POWDER_STOCK"],
                PRV_OU1_PAC_TANKA_LEVEL = (dynamic)reader["PRV_OU1_PAC_TANKA_LEVEL"],
                PRV_OU1_PAC_TANKA_STOCK = (dynamic)reader["PRV_OU1_PAC_TANKA_STOCK"],
                PRV_OU1_PAC_TANKB_LEVEL = (dynamic)reader["PRV_OU1_PAC_TANKB_LEVEL"],
                PRV_OU1_PAC_TANKB_STOCK = (dynamic)reader["PRV_OU1_PAC_TANKB_STOCK"],
                PRV_OU1_PAC_RECPT = (dynamic)reader["PRV_OU1_PAC_RECPT"],
                PRV_OU1_PAC_CONSP = (dynamic)reader["PRV_OU1_PAC_CONSP"],
                PRV_OU1_PAC_STOCK = (dynamic)reader["PRV_OU1_PAC_STOCK"],
                PRV_OU1_NAP315_RECPT = (dynamic)reader["PRV_OU1_NAP315_RECPT"],
                PRV_OU1_NAP315_CONSP = (dynamic)reader["PRV_OU1_NAP315_CONSP"],
                PRV_OU1_NAP315_STOCK = (dynamic)reader["PRV_OU1_NAP315_STOCK"],
                PRV_OU1_NA1005_RECPT = (dynamic)reader["PRV_OU1_NA1005_RECPT"],
                PRV_OU1_NA1005_CONSP = (dynamic)reader["PRV_OU1_NA1005_CONSP"],
                PRV_OU1_NA1005_STOCK = (dynamic)reader["PRV_OU1_NA1005_STOCK"],
                PRV_OU1_CD2001L_RECPT = (dynamic)reader["PRV_OU1_CD2001L_RECPT"],
                PRV_OU1_CD2001L_CONSP = (dynamic)reader["PRV_OU1_CD2001L_CONSP"],
                PRV_OU1_CD2001L_STOCK = (dynamic)reader["PRV_OU1_CD2001L_STOCK"],
                PRV_OU1_CDDS_HPA_RECPT = (dynamic)reader["PRV_OU1_CDDS_HPA_RECPT"],
                PRV_OU1_CDDS_HPA_CONSP = (dynamic)reader["PRV_OU1_CDDS_HPA_CONSP"],
                PRV_OU1_CDDS_HPA_STOCK = (dynamic)reader["PRV_OU1_CDDS_HPA_STOCK"],
                PRV_OU1_CDDS_2625AC_RECPT = (dynamic)reader["PRV_OU1_CDDS_2625AC_RECPT"],
                PRV_OU1_CDDS_2625AC_CONSP = (dynamic)reader["PRV_OU1_CDDS_2625AC_CONSP"],
                PRV_OU1_CDDS_2625AC_STOCK = (dynamic)reader["PRV_OU1_CDDS_2625AC_STOCK"],
                PRV_OU1_N73202_RECPT = (dynamic)reader["PRV_OU1_N73202_RECPT"],
                PRV_OU1_N73202_CONSP = (dynamic)reader["PRV_OU1_N73202_CONSP"],
                PRV_OU1_N73202_STOCK = (dynamic)reader["PRV_OU1_N73202_STOCK"],

                // ---------------------DV-------------------------
                PARM_G_HCL_NDS = (dynamic)reader["PARM_G_HCL_NDS"],
                PARM_G_HCL_NMF = (dynamic)reader["PARM_G_HCL_NMF"],
                PARM_G_HCL_ODS = (dynamic)reader["PARM_G_HCL_ODS"],
                PARM_G_HCL_OMF = (dynamic)reader["PARM_G_HCL_OMF"],
                PARM_G_SULPH_ACID_MF = (dynamic)reader["PARM_G_SULPH_ACID_MF"],
                PARM_G_HSD_EDG_MF = (dynamic)reader["PARM_G_HSD_EDG_MF"],
                PARM_G_HSD_GT_MF = (dynamic)reader["PARM_G_HSD_GT_MF"],
                PARM_G_HSD_NEWTANK_MF = (dynamic)reader["PARM_G_HSD_NEWTANK_MF"],
                PARM_G_HSD_NWDEADSTOCK_MF = (dynamic)reader["PARM_G_HSD_NWDEADSTOCK_MF"],
                PARM_G_HCL_G2DS = (dynamic)reader["PARM_G_HCL_G2DS"],
                PARM_G_HCL_G2MF = (dynamic)reader["PARM_G_HCL_G2MF"],

                PARM_OU_HCL_STOCK = (dynamic)reader["PARM_OU_HCL_STOCK"],
                parm_ou_clye_stock = (dynamic)reader["parm_ou_clye_stock"],
                PARM_ou_sulacid_stock = (dynamic)reader["PARM_ou_sulacid_stock"],
                parm_ou_hsd_stock = (dynamic)reader["parm_ou_hsd_stock"],
                parm_ou_alum_stock = (dynamic)reader["parm_ou_alum_stock"],
                parm_ou_chlwpt_stock = (dynamic)reader["parm_ou_chlwpt_stock"],
                parm_ou_chlrw_stock = (dynamic)reader["parm_ou_chlrw_stock"],
                parm_ou_chlct_stock = (dynamic)reader["parm_ou_chlct_stock"],
                parm_ou_hypo_stock = (dynamic)reader["parm_ou_hypo_stock"],
                parm_ou_hypo_stock_stp = (dynamic)reader["parm_ou_hypo_stock_stp"],
                parm_ou_n7356_stock = (dynamic)reader["parm_ou_n7356_stock"],
                parm_ou_n8301d_stock = (dynamic)reader["parm_ou_n8301d_stock"],
                Parm_ou_n7342_stock = (dynamic)reader["Parm_ou_n7342_stock"],
                parm_ou_n7307_stock = (dynamic)reader["parm_ou_n7307_stock"],
                parm_ou_n7308_stock = (dynamic)reader["parm_ou_n7308_stock"],
                parm_ou_stbx_stock = (dynamic)reader["parm_ou_stbx_stock"],
                parm_ou_hydrazine_stock = (dynamic)reader["parm_ou_hydrazine_stock"],
                parm_ou_tsp_stock = (dynamic)reader["parm_ou_tsp_stock"],
                parm_ou_hitech_stock = (dynamic)reader["parm_ou_hitech_stock"],
                parm_ou_polyel_stock = (dynamic)reader["parm_ou_polyel_stock"],
                parm_ou_act_alum_stock = (dynamic)reader["parm_ou_act_alum_stock"],
                parm_ou_molsieve_stock = (dynamic)reader["parm_ou_molsieve_stock"],
                parm_ou_act_carbon_stock = (dynamic)reader["parm_ou_act_carbon_stock"],
                parm_ou_ssf_peb_stock = (dynamic)reader["parm_ou_ssf_peb_stock"],
                parm_ou_ssf_sand_stock = (dynamic)reader["parm_ou_ssf_sand_stock"],
                parm_ou_dmp_peb_stock = (dynamic)reader["parm_ou_dmp_peb_stock"],
                parm_ou_wpt_sand_stock = (dynamic)reader["parm_ou_wpt_sand_stock"],
                parm_ou_indion225_stock = (dynamic)reader["parm_ou_indion225_stock"],
                parm_ou_indion850_stock = (dynamic)reader["parm_ou_indion850_stock"],
                parm_ou_ffip_stock = (dynamic)reader["parm_ou_ffip_stock"],
                parm_ou_hlime_stock = (dynamic)reader["parm_ou_hlime_stock"],
                parm_ou_bleach_powder_stock = (dynamic)reader["parm_ou_bleach_powder_stock"],
                PARM_OU_PAC_STOCK = (dynamic)reader["PARM_OU_PAC_STOCK"],
                PARM_OU_NAP315_STOCK = (dynamic)reader["PARM_OU_NAP315_STOCK"],
                PARM_OU_NA1005_STOCK = (dynamic)reader["PARM_OU_NA1005_STOCK"],
                PARM_OU_CD2001L_STOCK = (dynamic)reader["PARM_OU_CD2001L_STOCK"],
                PARM_OU_CDDS_HPA_STOCK = (dynamic)reader["PARM_OU_CDDS_HPA_STOCK"],
                PARM_OU_CDDS_2625AC_STOCK = (dynamic)reader["PARM_OU_CDDS_2625AC_STOCK"],
                PARM_OU_N73202_STOCK = (dynamic)reader["PARM_OU_N73202_STOCK"],

                parm_ng_dsg_comp_fact_ab = (dynamic)reader["parm_ng_dsg_comp_fact_ab"],
                parm_ng_dsg_comp_fact_gt = (dynamic)reader["parm_ng_dsg_comp_fact_gt"],
                parm_dsg_mol_wt = (dynamic)reader["parm_dsg_mol_wt"],
                parm_ng_act_comp_fact_ab = (dynamic)reader["parm_ng_act_comp_fact_ab"],
                parm_ng_act_comp_fact_gt = (dynamic)reader["parm_ng_act_comp_fact_gt"],
                parm_dsg_temp_gt = (dynamic)reader["parm_dsg_temp_gt"],
                parm_dsg_prs_gt = (dynamic)reader["parm_dsg_prs_gt"],
                parm_kelvin_temp = (dynamic)reader["parm_kelvin_temp"],
                parm_dsg_prs_hrsg = (dynamic)reader["parm_dsg_prs_hrsg"],
                parm_dsg_temp_hrsg = (dynamic)reader["parm_dsg_temp_hrsg"],
                parm_cf_nm3_sm3 = (dynamic)reader["parm_cf_nm3_sm3"],
            };
        }

        public async Task<POS003Model> putData(TransactionDateBtnDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_GET_PPT_OU_CHEMICAL_CONSP", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_DATE", value.TransactionDate));
                    cmd.Parameters.Add(new SqlParameter("@IN_BTN", value.Btn));
                    POS003Model response = null;
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
        public async Task saveData(POS003SaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU1_SAVE_PPT_OU_CHEMICAL_CONSP", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TRANS_DATE", value.OU1_TRANS_DATE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_UNIT_ID", value.OU1_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_USER_ID", value.OU1_USER_ID));

                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HCL_RECPT", value.OU1_HCL_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HCL_OTANK_LEVEL", value.OU1_HCL_OTANK_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HCL_OTANK_STOCK", value.OU1_HCL_OTANK_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HCL_NTANK_LEVEL", value.OU1_HCL_NTANK_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HCL_NTANK_STOCK", value.OU1_HCL_NTANK_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HCL_STOCK", value.OU1_HCL_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HCL_CONSP", value.OU1_HCL_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SULACID_RECPT", value.OU1_SULACID_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SULACID_TANK_LEVEL", value.OU1_SULACID_TANK_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SULACID_STOCK", value.OU1_SULACID_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SULACID_CONSP", value.OU1_SULACID_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CLYE_RECPT", value.OU1_CLYE_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CLYE_TANK_LEVEL", value.OU1_CLYE_TANK_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CLYE_STOCK", value.OU1_CLYE_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CLYE_CONSP", value.OU1_CLYE_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HSD_RECPT", value.OU1_HSD_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HSD_EDG_LEVEL", value.OU1_HSD_EDG_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HSD_EDG_STOCK", value.OU1_HSD_EDG_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HSD_GT_LEVEL", value.OU1_HSD_GT_LEVEL));
                    // cmd.Parameters.Add(new SqlParameter("@IN_OU1_HSD_GT_STOCK", value.OU1_HSD_GT_STOCK))/;
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HSD_NEW_LEVEL", value.OU1_HSD_NEW_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HSD_NEW_STOCK", value.OU1_HSD_NEW_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HSD_STOCK", value.OU1_HSD_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HSD_CONSP", value.OU1_HSD_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ALUM_RECPT", value.OU1_ALUM_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ALUM_STOCK", value.OU1_ALUM_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ALUM_CONSP", value.OU1_ALUM_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CHLWPT_RECPT", value.OU1_CHLWPT_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CHLWPT_STOCK", value.OU1_CHLWPT_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CHLWPT_CONSP", value.OU1_CHLWPT_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CHLRW_RECPT", value.OU1_CHLRW_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CHLRW_STOCK", value.OU1_CHLRW_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CHLRW_CONSP", value.OU1_CHLRW_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CHLCT_RECPT", value.OU1_CHLCT_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CHLCT_STOCK", value.OU1_CHLCT_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CHLCT_CONSP", value.OU1_CHLCT_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HYPO_RECPT", value.OU1_HYPO_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HYPO_STOCK", value.OU1_HYPO_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HYPO_CONSP", value.OU1_HYPO_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N7356_RECPT", value.OU1_N7356_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N7356_STOCK", value.OU1_N7356_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N7356_CONSP", value.OU1_N7356_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N8301D_RECPT", value.OU1_N8301D_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N8301D_STOCK", value.OU1_N8301D_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N8301D_CONSP", value.OU1_N8301D_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N7348_RECPT", value.OU1_N7348_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N7348_STOCK", value.OU1_N7348_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N7348_CONSP", value.OU1_N7348_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N7342_RECPT", value.OU1_N7342_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N7342_STOCK", value.OU1_N7342_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N7342_CONSP", value.OU1_N7342_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N7307_RECPT", value.OU1_N7307_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N7307_STOCK", value.OU1_N7307_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N7307_CONSP", value.OU1_N7307_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_STBX_RECPT", value.OU1_STBX_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_STBX_STOCK", value.OU1_STBX_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_STBX_CONSP", value.OU1_STBX_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HYDRAZINE_RECPT", value.OU1_HYDRAZINE_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HYDRAZINE_STOCK", value.OU1_HYDRAZINE_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HYDRAZINE_CONSP", value.OU1_HYDRAZINE_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TSP_RECPT", value.OU1_TSP_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TSP_STOCK", value.OU1_TSP_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_TSP_CONSP", value.OU1_TSP_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HITECH_RECPT", value.OU1_HITECH_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HITECH_STOCK", value.OU1_HITECH_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HITECH_CONSP", value.OU1_HITECH_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_POLYEL_RECPT", value.OU1_POLYEL_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_POLYEL_STOCK", value.OU1_POLYEL_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_POLYEL_CONSP", value.OU1_POLYEL_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ACT_ALUM_RECPT", value.OU1_ACT_ALUM_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ACT_ALUM_STOCK", value.OU1_ACT_ALUM_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ACT_ALUM_CONSP", value.OU1_ACT_ALUM_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_MOLSIEVE_RECPT", value.OU1_MOLSIEVE_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_MOLSIEVE_STOCK", value.OU1_MOLSIEVE_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_MOLSIEVE_CONSP", value.OU1_MOLSIEVE_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ACT_CARBON_RECPT", value.OU1_ACT_CARBON_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ACT_CARBON_STOCK", value.OU1_ACT_CARBON_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_ACT_CARBON_CONSP", value.OU1_ACT_CARBON_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SSF_PEB_RECPT", value.OU1_SSF_PEB_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SSF_PEB_STOCK", value.OU1_SSF_PEB_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SSF_PEB_CONSP", value.OU1_SSF_PEB_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SSF_SAND_RECPT", value.OU1_SSF_SAND_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SSF_SAND_STOCK", value.OU1_SSF_SAND_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_SSF_SAND_CONSP", value.OU1_SSF_SAND_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMP_PEB_RECPT", value.OU1_DMP_PEB_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMP_PEB_STOCK", value.OU1_DMP_PEB_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_DMP_PEB_CONSP", value.OU1_DMP_PEB_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_WPT_SAND_RECPT", value.OU1_WPT_SAND_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_WPT_SAND_STOCK", value.OU1_WPT_SAND_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_WPT_SAND_CONSP", value.OU1_WPT_SAND_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_INDION225_RECPT", value.OU1_INDION225_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_INDION225_STOCK", value.OU1_INDION225_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_INDION225_CONSP", value.OU1_INDION225_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_INDION850_RECPT", value.OU1_INDION850_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_INDION850_STOCK", value.OU1_INDION850_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_INDION850_CONSP", value.OU1_INDION850_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FFIP_RECPT", value.OU1_FFIP_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FFIP_STOCK", value.OU1_FFIP_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_FFIP_CONSP", value.OU1_FFIP_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N8301D_REMARK", value.OU1_N8301D_REMARK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N7356_REMARK", value.OU1_N7356_REMARK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N7348_REMARK", value.OU1_N7348_REMARK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N7342_REMARK", value.OU1_N7342_REMARK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N7307_REMARK", value.OU1_N7307_REMARK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_STABREX_REMARK", value.OU1_STABREX_REMARK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_REMARKS", value.OU1_REMARKS));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HSD_EXPORTT_UNIT2", value.OU1_HSD_EXPORTT_UNIT2));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HCL_G2TANK_LEVEL", value.OU1_HCL_G2TANK_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CLYE_G2TANK_LEVEL", value.OU1_CLYE_G2TANK_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HLIME_RECPT", value.OU1_HLIME_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HLIME_STOCK", value.OU1_HLIME_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HLIME_CONSP", value.OU1_HLIME_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HCL_G2TANK_STOCK", value.OU1_HCL_G2TANK_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CLYE_G2TANK_STOCK", value.OU1_CLYE_G2TANK_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CLYE_OTANK_STOCK", value.OU1_CLYE_OTANK_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HYPO_RECPT_STP", value.OU1_HYPO_RECPT_STP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HYPO_CONSP_STP", value.OU1_HYPO_CONSP_STP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HYPO_STOCK_STP", value.OU1_HYPO_STOCK_STP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N7308_RECPT", value.OU1_N7308_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N7308_CONSP", value.OU1_N7308_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N7308_STOCK", value.OU1_N7308_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_BLEACH_POWDER_RECPT", value.OU1_BLEACH_POWDER_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_BLEACH_POWDER_CONSP", value.OU1_BLEACH_POWDER_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_BLEACH_POWDER_STOCK", value.OU1_BLEACH_POWDER_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PAC_RECPT", value.OU1_PAC_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PAC_CONSP", value.OU1_PAC_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PAC_STOCK", value.OU1_PAC_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP315_RECPT", value.OU1_NAP315_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP315_CONSP", value.OU1_NAP315_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NAP315_STOCK", value.OU1_NAP315_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NA1005_RECPT", value.OU1_NA1005_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NA1005_CONSP", value.OU1_NA1005_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NA1005_STOCK", value.OU1_NA1005_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NA1002_RECPT", value.OU1_NA1002_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NA1002_CONSP", value.OU1_NA1002_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_NA1002_STOCK", value.OU1_NA1002_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RESIN_T42_RECPT", value.OU1_RESIN_T42_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RESIN_T42_CONSP", value.OU1_RESIN_T42_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RESIN_T42_STOCK", value.OU1_RESIN_T42_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RESIN_T23_RECPT", value.OU1_RESIN_T23_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RESIN_T23_CONSP", value.OU1_RESIN_T23_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_RESIN_T23_STOCK", value.OU1_RESIN_T23_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N8300_RECPT", value.OU1_N8300_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N8300_CONSP", value.OU1_N8300_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N8300_STOCK", value.OU1_N8300_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N73202_RECPT", value.OU1_N73202_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N73202_CONSP", value.OU1_N73202_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_N73202_STOCK", value.OU1_N73202_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PAC_TANKA_LEVEL", value.OU1_PAC_TANKA_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PAC_TANKA_STOCK", value.OU1_PAC_TANKA_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PAC_TANKB_STOCK", value.OU1_PAC_TANKB_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_PAC_TANKB_LEVEL", value.OU1_PAC_TANKB_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CD2001L_RECPT", value.OU1_CD2001L_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CD2001L_CONSP", value.OU1_CD2001L_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CD2001L_STOCK", value.OU1_CD2001L_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CDDS_HPA_RECPT", value.OU1_CDDS_HPA_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CDDS_HPA_CONSP", value.OU1_CDDS_HPA_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CDDS_HPA_STOCK", value.OU1_CDDS_HPA_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CDDS_2625AC_RECPT", value.OU1_CDDS_2625AC_RECPT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CDDS_2625AC_CONSP", value.OU1_CDDS_2625AC_CONSP));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_CDDS_2625AC_STOCK", value.OU1_CDDS_2625AC_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU1_HCL_NEWTANK_STOCK", value.OU1_HCL_NEWTANK_STOCK));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
