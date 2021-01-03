using LabDay3Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabDay3Core.Controllers
{
    public class StudentsController1 : Controller
    {
        ITIContext db;
        public StudentsController1(ITIContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            List<student> slst = db.Students.ToList();
            return View(slst);
        }
    }
}
