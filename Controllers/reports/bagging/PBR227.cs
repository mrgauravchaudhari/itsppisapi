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

    public class PBR227Controller : ControllerBase
    {
        private string _connectionString;

        private readonly itsppisapi.Models.DataContext _context;
        public PBR227Controller(itsppisapi.Models.DataContext context)
        {
            _context = context;
        }

        [HttpGet("{mnth}")]
        public async Task<DataSet> get(string mnth)
        {
            try
            {
               string strqry = "[PPIS].[PPU_P_BG2_MR_COST_ANALYSIS_PBR227]";

                _connectionString = _context.Database.GetDbConnection().ConnectionString.ToString();

                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(strqry, sql))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IN_MNTH", mnth));
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