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

    public class PBR235Controller : ControllerBase
    {
        private string _connectionString;

        private readonly itsppisapi.Models.DataContext _context;
        public PBR235Controller(itsppisapi.Models.DataContext context)
        {
            _context = context;
        }

        [HttpGet("{fromdate}/{todate}")]
        public async Task<DataSet> get(string fromdate,string todate)
        {
            try
            {
               string strqry = "[PPIS].PPU_P_BG2_DR_UPH_Status_PBR235";

                _connectionString = _context.Database.GetDbConnection().ConnectionString.ToString();

                using (SqlConnection sql = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(strqry, sql))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@IN_FROM_DT", fromdate));
                        cmd.Parameters.Add(new SqlParameter("@IN_TO_DT", todate));
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