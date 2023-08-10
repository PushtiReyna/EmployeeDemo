using EmployeeDBFirstDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EmployeeDBFirstDemo.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly EmployeeDbContext _db;
        public EmployeeController(EmployeeDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var result = _db.Employees.ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    Employeename = model.Employeename,
                    Gender= model.Gender,
                    Dob=model.Dob,
                    Department=model.Department,
                    Username=model.Username,
                    Password=model.Password,
                    Address=model.Address,
                    Pincode=model.Pincode,
                    Email=model.Email,
                    Mobile1=model.Mobile1,
                    Mobile2=model.Mobile2,
                };

                _db.Employees.Add(employee);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "fail to create Employee";
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var employee = _db.Employees.SingleOrDefault(x => x.EmployeeId == id);
            
                var result = new Employee()
                {
                    EmployeeId = employee.EmployeeId,
                    Employeename = employee.Employeename,
                    Gender = employee.Gender,
                    Dob = employee.Dob,
                    Department = employee.Department,
                    Username = employee.Username,
                    Password = employee.Password,
                    Address = employee.Address,
                    Pincode = employee.Pincode,
                    Email = employee.Email,
                    Mobile1 = employee.Mobile1,
                    Mobile2 = employee.Mobile2,
                };
                return View(result);
        }

        [HttpPost]
        public ActionResult Edit(Employee model)
        {
            var employee = new Employee()
            {
                EmployeeId = model.EmployeeId,
                Employeename = model.Employeename,
                Gender = model.Gender,
                Dob = model.Dob,
                Department = model.Department,
                Username = model.Username,
                Password = model.Password,
                Address = model.Address,
                Pincode = model.Pincode,
                Email = model.Email,
                Mobile1 = model.Mobile1,
                Mobile2 = model.Mobile2,
            };
            _db.Employees.Update(employee);
            _db.SaveChanges();
            return RedirectToAction("Index");
           
        }

        public IActionResult Delete(int id)
        {
            var employee = _db.Employees.SingleOrDefault(x => x.EmployeeId == id);
            if (employee != null)
            {
                _db.Employees.Remove(employee);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}
