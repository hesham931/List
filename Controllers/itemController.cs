using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using List.Data;
using List.Models;

namespace List.Controllers
{
    public class itemController : Controller
    {
        private readonly ApplicationDbContext _Db;
        private readonly ILogger<itemController> _logger;

        public itemController(ILogger<itemController> logger, ApplicationDbContext Db)
        {
            _logger = logger;
            _Db = Db;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> obj = _Db.items;
            return View(obj);
        }
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item obj){
            _Db.items.Add(obj);
            _Db.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Edit(int? id){
            var obj = _Db.items.Find(id);
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Item obj){
            _Db.items.Update(obj);
            _Db.SaveChanges();

            return RedirectToAction("index");   
        }
        public IActionResult Delete(int? id){
            var obj = _Db.items.Find(id);
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Item obj){
            _Db.items.Remove(obj);

            _Db.SaveChanges();
            return RedirectToAction("index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}