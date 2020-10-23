using Microsoft.Extensions.Configuration;
using itsppisapi.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using itsppisapi.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace itsppisapi.Data
{
    public class PGS013Repository
    {
        private readonly string _connectionString;

        public PGS013Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DBConnection");
        }


        private ListGroupsByUser MapToValue5(SqlDataReader reader)
        {
            return new ListGroupsByUser()
            {
                GROUP_ID = (decimal)reader["GROUP_ID"],
            };
        }
        public async Task<List<ListGroupsByUser>> putData3(decimal value)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select GROUP_ID from PPIS.PPM_GL_MODULE_GROUP_NEW where GROUP_NAME in (select MODULE_GROUP from PPIS.PPM_GL_MODULE_ACCESS_NEW  where MODULE_USER = '" + value + "')", sql))
                {
                    var response = new List<ListGroupsByUser>();
                    await sql.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValue5(reader));
                        }
                    }
                    return response;
                }
            }
        }

        private PGS013Model MapToValue(SqlDataReader reader)
        {
            return new PGS013Model()
            {
                GROUP_ID = (decimal)reader["GROUP_ID"],
                GROUP_MODULES = reader["GROUP_MODULES"].ToString()
            };
        }

        public async Task<PGS013Model> putData(NumberParameterDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_GET_PPM_GL_MODULE_GROUP_ID_NEW]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_GROUP_ID", data.NumberParameter));
                    PGS013Model response = null;
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

        private ListAccessModuleModel MapToValue2(SqlDataReader reader)
        {
            return new ListAccessModuleModel()
            {
                //  GROUP_ID = (decimal)reader["GROUP_ID"],
                MODULE_GROUP = reader["MODULE_GROUP"].ToString(),
                USER_ID = (decimal)reader["USER_ID"],
                ACCESS_FLAG = reader["ACCESS_FLAG"].ToString(),
                GROUP_MODULES = reader["GROUP_MODULES"].ToString()
            };
        }

        public async Task<ListAccessModuleModel> putData2(NumberParameterDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_GET_PPM_GL_MODULE_ACCESS_NEW]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_ID", data.USERID_PARAM));
                    cmd.Parameters.Add(new SqlParameter("@IN_GROUP_ID", data.GROUPID_PARAM));
                    ListAccessModuleModel response = null;
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

        private ListModuleModel MapToValue3(SqlDataReader reader)
        {
            return new ListModuleModel()
            {
                MODULE_ID = (decimal)reader["MODULE_ID"],
                MODULE_NAME = reader["MODULE_NAME"].ToString(),
                MODULE_DESC = reader["MODULE_DESC"].ToString()
            };
        }
        public async Task<List<ListModuleModel>> getData3()
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    //   using (SqlCommand cmd = new SqlCommand("SELECT MODULE_ID,MODULE_NAME,MODULE_DESC FROM [PPIS].[PPM_GL_MODULE_NEW] WHERE ACTIVE_FLG = 'A'", sql))
                    using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_GET_PPM_GL_MODULE_ALL_NEW]", sql))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        var response = new List<ListModuleModel>();
                        await sql.OpenAsync();
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                response.Add(MapToValue3(reader));
                            }
                        }
                        return response;
                    }
                }
            }
            catch (Exception ex)
            {
                List<ListModuleModel> result = new List<ListModuleModel>();
                ListModuleModel data = new ListModuleModel();
                data.MODULE_NAME = "IT";
                data.MODULE_DESC = ex.Message;
                result.Add(data);
                return result;
            }
        }

        private ListGroupModel MapToValue4(SqlDataReader reader)
        {
            return new ListGroupModel()
            {
                GROUP_ID = (decimal)reader["GROUP_ID"],
                GROUP_NAME = reader["GROUP_NAME"].ToString()
            };
        }

        public async Task<List<ListGroupModel>> getData4()
        {
            try
            {
                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT GROUP_ID,GROUP_NAME FROM [PPIS].[PPM_GL_MODULE_GROUP_NEW] WHERE ACTIVE_FLAG = 'A'", sql))
                    {
                        var response = new List<ListGroupModel>();
                        await sql.OpenAsync();
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                response.Add(MapToValue4(reader));
                            }
                        }
                        return response;
                    }
                }
            }
            catch (Exception ex)
            {
                List<ListGroupModel> result = new List<ListGroupModel>();

                ListGroupModel data = new ListGroupModel();
                data.GROUP_ID = 1;
                data.GROUP_NAME = ex.Message;
                result.Add(data);
                return result;
            }
        }

        public async Task saveData(PGS013SaveDto data)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[PPIS].[PPU_P_SAVE_PPM_GL_MODULE_ACCESS_NEW]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IN_GROUP_ID", data.GROUP_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_ID", data.USER_ID));
                    cmd.Parameters.Add(new SqlParameter("@IN_GROUP_MODULES", data.GROUP_MODULES));
                    cmd.Parameters.Add(new SqlParameter("@IN_ACCESS_FLAG", data.ACCESS_FLAG));
                    cmd.Parameters.Add(new SqlParameter("@IN_USER_BY", data.USER_BY));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
