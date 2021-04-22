﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.ProductsAdmin;
using Shop.Application.StockAdmin;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.UI.Controllers
{
    [Route("[Controller]")]
    [Authorize(Policy = "Manager")]
    public class StocksController: Controller
    {
        private ApplicationDbContext _ctx;

        public StocksController(Database.ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        [HttpGet("")]
        public IActionResult GetStock() => Ok(new GetStock(_ctx).Do());

        [HttpPost("")]
        public async Task<IActionResult> CreateStocks([FromBody] CreateStock.Request request) => Ok((await new CreateStock(_ctx).Do(request)));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStock(int id) => Ok((await new DeleteStock(_ctx).Do(id)));

        [HttpPut("")]
        public async Task<IActionResult> UpdateStock([FromBody] UpdateStock.Request request) => Ok((await new UpdateStock(_ctx).Do(request)));
    }
}
