using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial_App_Core.Data;
using Financial_App_Core.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;

namespace Financial_App_Core.Controllers
{
    public class ChartController : Controller
    {
        private readonly FinancialDbContext _context;

        public ChartController(FinancialDbContext context)
        {
            _context = context;
        }

        public IActionResult GetStockData()
        {
            var data = _context.StockData.OrderBy(d => d.Date).ToList();
            return Json(data);
        }

        public IActionResult GetCashflowData()
        {
            var data = _context.Cashflows.ToList();
            return Json(data);
        }
    }

}
