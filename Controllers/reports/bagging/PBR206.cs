﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;

namespace cfclapi.Controllers.ledgers.electrical
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]

    public class PBR206Controller : ControllerBase
    {
        private string _connectionString;

        private readonly itsppisapi.Models.DataContext _context;
        public PBR206Controller(itsppisapi.Models.DataContext context)
        {
            _context = context;
        }

        [HttpGet("{FDATE}/{TO_DATE}/{unit_id}")]
        public async Task<DataSet> get(string FDATE,string TO_DATE,string unit_id)
        {
            try
            {
               string strqry = "[PPIS].[PPU_P_BG_PR_Demurrage_Recv_Waiver_PBR206]";

                _connectionString = _context.Database.GetDbConnection().ConnectionString.ToString();

                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(strqry, sql))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IN_FROM_DATE", FDATE));
                        cmd.Parameters.Add(new SqlParameter("@IN_TO_DATE", TO_DATE));
                        cmd.Parameters.Add(new SqlParameter("@IN_UNIT_ID", unit_id));
                        await sql.OpenAsync();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        return ds;
                    }
                }
            }
            catch (Exception ex)
            {
                DataSet ds = new DataSet(ex.Message.ToString());
                ds.AcceptChanges();
                return ds;
            }
        }
    }

}