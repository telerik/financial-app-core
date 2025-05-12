using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial_App_Core.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;

namespace Financial_App_Core.Controllers
{
    using Financial_App_Core.Data;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;

    public class GridController : Controller
    {
        private readonly FinancialDbContext _context;

        public GridController(FinancialDbContext context)
        {
            _context = context;
        }

        public ActionResult GetTransactions([DataSourceRequest] DataSourceRequest request)
        {
            var result = _context.Transactions
                .ToList()
                .ToDataSourceResult(request);
            
            return Json(result);
        }
    }

}
