using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MalinaoLoans.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MalinaoLoans.Controllers
{
 
    public class LoanController : Controller
    {
        private readonly CsharpUtangDatabaseContext _context;

        public LoanController(CsharpUtangDatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
           var Loans = _context.Loans.ToList();
           return View(Loans);
        }

             [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

      
    }
}