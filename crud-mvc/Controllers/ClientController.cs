using crud_mvc.Data;
using crud_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_mvc.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ClientController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Client> clientobj = _db._Client;
            return View(clientobj);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Client obj)
        {
            if (ModelState.IsValid)
            {
                
                _db._Client.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }

        }
       
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db._Client.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }
        [ValidateAntiForgeryToken]
        public IActionResult _Delete(int? id)
        {
            var obj = _db._Client.Find(id);
            if (id == null)
            {
                return NotFound();
            }
            else
            {
            _db._Client.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
            }

            

        }
        
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db._Client.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        public IActionResult _Edit(Client obj)
        {
            if (ModelState.IsValid)
            {
                _db._Client.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }


        }
    }
}
