using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using itsppisapi.Models;
using itsppisapi.SaveDtos;

namespace itsppisapi.Data
{
    public class POS001Repository
    {
        private readonly string _connectionString;
        public POS001Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        // VALUE MAPPER FUNC. FOR MACHINE MASTER
        private MachineMasterModel MapToValueMM(SqlDataReader reader)
        {
            return new MachineMasterModel()
            {
                OU_DEPT_CODE = reader["OU_DEPT_CODE"].ToString(),
                OU_CATG_NAME = reader["OU_CATG_NAME"].ToString(),
                OU_PUMP_UNIT_FLG = reader["OU_PUMP_UNIT_FLG"].ToString(),
                OU_MACH_NAME = reader["OU_MACH_NAME"].ToString(),
                OU_MACH_DESC = reader["OU_MACH_DESC"].ToString(),
                OU_MACH_ASSOCIATION = reader["OU_MACH_ASSOCIATION"].ToString(),
                OU_MACH_ACTIVE_FLAG = reader["OU_MACH_ACTIVE_FLAG"].ToString(),
                OU_DATE_MOD = reader["OU_DATE_MOD"].ToString(),
                OU_USER_ID = (decimal)reader["OU_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString()
            };
        }

        // VALUE MAPPER FUNC. FOR CHEMICAL MASTER
        private ChemicalMasterModel MapToValueCM(SqlDataReader reader)
        {
            return new ChemicalMasterModel()
            {
                OU_DEPT_CODE = reader["OU_DEPT_CODE"].ToString(),
                OU_CHEMICAL_ID = reader["OU_CHEMICAL_ID"].ToString(),
                OU_CHEMICAL_NAME = reader["OU_CHEMICAL_NAME"].ToString(),
                OU_MEAS_UNIT = reader["OU_MEAS_UNIT"].ToString(),
                OU_TANK_NO = reader["OU_TANK_NO"].ToString(),
                OU_DATE_MOD = reader["OU_DATE_MOD"].ToString(),
                OU_USER_ID = (decimal)reader["OU_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString()
            };
        }

        // VALUE MAPPER FUNC. FOR STOCK MASTER
        private StockMasterModel MapToValueSM(SqlDataReader reader)
        {
            return new StockMasterModel()
            {
                OU_CHEMICAL_ID = reader["OU_CHEMICAL_ID"].ToString(),
                OU_CHEMICAL_LEVEL = (decimal)reader["OU_CHEMICAL_LEVEL"],
                OU_CHEMICAL_STOCK = (decimal)reader["OU_CHEMICAL_STOCK"],
                OU_DATE_MOD = reader["OU_DATE_MOD"].ToString(),
                OU_USER_ID = (decimal)reader["OU_USER_ID"],
                USER_NAME = reader["USER_NAME"].ToString()
            };
        }

        // GET DATA METHOD FOR MACHINE MASTER
        public async Task<List<MachineMasterModel>> putDataMM(string DEPT_CODE)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU_GET_PPM_OU_MACHINE", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@DEPT_CODE", DEPT_CODE));
                    var response = new List<MachineMasterModel>();
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValueMM(reader));
                        }
                    }
                    return response;
                }
            }
        }

        // GET DATA METHOD FOR CHEMICAL MASTER
        public async Task<List<ChemicalMasterModel>> putDataCM(string DEPT_CODE)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU_GET_PPM_OU_CHEMICAL", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@DEPT_CODE", DEPT_CODE));
                    var response = new List<ChemicalMasterModel>();
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValueCM(reader));
                        }
                    }
                    return response;
                }
            }
        }

        // GET DATA METHOD FOR STOCK MASTER
        public async Task<List<StockMasterModel>> putDataSM(string CH_ID)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU_GET_PPM_OU_CHEMICAL_STOCK", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@CH_ID", CH_ID));
                    var response = new List<StockMasterModel>();
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValueSM(reader));
                        }
                    }
                    return response;
                }
            }
        }


        // SAVE DATA FOR MACHINE MASTER 
        public async Task saveDataMM(MachineMasterSaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU_SAVE_PPM_OU_MACHINE", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_OU_DEPT_CODE", value.OU_DEPT_CODE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_UNIT_ID", value.OU_UNIT_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_MACH_NAME", value.OU_MACH_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_MACH_DESC", value.OU_MACH_DESC));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_CATG_NAME", value.OU_CATG_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_PUMP_UNIT_FLG", value.OU_PUMP_UNIT_FLG));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_MACH_ASSOCIATION", value.OU_MACH_ASSOCIATION));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_USER_ID", value.OU_USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_MACH_ACTIVE_FLAG", value.OU_MACH_ACTIVE_FLAG));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }

        // SAVE DATA FOR CHEMICAL MASTER
        public async Task saveDataCM(ChemicalMasterSaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU_SAVE_PPM_OU_CHEMICAL", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_OU_CHEMICAL_ID", value.OU_CHEMICAL_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_MEAS_UNIT", value.OU_MEAS_UNIT));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_TANK_NO", value.OU_TANK_NO));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_CHEMICAL_NAME", value.OU_CHEMICAL_NAME));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_DEPT_CODE", value.OU_DEPT_CODE));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_USER_ID", value.OU_USER_ID));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }

        // SAVE DATA FOR STOCK MASTER
        public async Task saveDataSM(StockMasterSaveDto value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("PPIS.PPU_P_OU_SAVE_PPM_OU_CHEMICAL_STOCK", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IN_OU_CHEMICAL_ID", value.OU_CHEMICAL_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_CHEMICAL_LEVEL", value.OU_CHEMICAL_LEVEL));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_CHEMICAL_STOCK", value.OU_CHEMICAL_STOCK));
                    cmd.Parameters.Add(new SqlParameter("@IN_OU_USER_ID", value.OU_USER_ID));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
