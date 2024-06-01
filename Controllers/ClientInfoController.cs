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
//All of these are required to access the database
    public class ClientInfoController : Controller   //at first it was logger, then nigger, but context
    {
        private readonly CsharpUtangDatabaseContext _context;  // change these greens to context

        public ClientInfoController(CsharpUtangDatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var clients = _context.ClientInfos.ToList();
            return View(clients);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }


        [HttpGet]
        public IActionResult Create(){
            return View();
        }

        [HttpPost]

        public IActionResult Create( ClientInfo client){
            _context.ClientInfos.Add(client);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }

        [HttpGet]

        public IActionResult Update(int id){
            var client = _context.ClientInfos.Where( q => q.Id == id).FirstOrDefault();
            return View(client);
        }

        [HttpPost]

        public IActionResult Update(ClientInfo client){
            if(!ModelState.IsValid)
            return View(client);

            _context.ClientInfos.Update(client);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Delete(int id){
            var client = _context.ClientInfos.Where( q=> q.Id == id).FirstOrDefault();
            _context.ClientInfos.Remove(client);
            _context.SaveChanges();
            return RedirectToAction ("Index");
        }


    }
}