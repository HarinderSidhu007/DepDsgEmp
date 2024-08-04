using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2_DepDsgEmp_1147.Data;
using WebApplication2_DepDsgEmp_1147.Models;

namespace WebApplication2_DepDsgEmp_1147.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly Applicationdbcontext context;
        public EmployeeController()
        {
            context = new Applicationdbcontext();
        }

        public object IsValid { get; private set; }

        // GET: Employee
        public ActionResult Index()
        {
            var employeesList = context.Employees.Include(e => e.Department).
                Include(e => e.Designation).ToList();
            return View(employeesList);
        }
        public ActionResult Upsert(int? id)
        {
            //ViewData["depList"] = context.Departments.ToList();
            //ViewData["dsgList"] = context.Designations.ToList();
            ViewBag.depList = context.Departments.ToList();
            ViewBag.dsgList = context.Designations.ToList();
            Employee employee = new Employee();
            if (id == null) return View(employee); //create
            //Edit
            employee = context.Employees.Find(id.GetValueOrDefault());
            if (employee == null) return HttpNotFound();
            return View(employee);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upsert(Employee employee)
        {
            if (employee == null) return HttpNotFound();
            if (!ModelState.IsValid)
            {
                return View(employee);
            }
            if (employee.Id == 0)
                context.Employees.Add(employee);
            else
            {
                var employeeInDb = context.Employees.Find(employee.Id);
                if (employeeInDb == null) return HttpNotFound();
                employeeInDb.Name = employee.Name;
                employeeInDb.Address = employee.Address;
                employeeInDb.Salary = employee.Salary;
                employeeInDb.DepartmentId = employee.DepartmentId;
                employeeInDb.DesignationId = employee.DesignationId;
            }
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Details(int id)
        {
        var employeeInDb = context.Employees.Include(e=> e.Department).
            Include(e=>e.Designation).FirstOrDefault(e=> e.Id == id);
        if (employeeInDb == null) return HttpNotFound();
        return View(employeeInDb);
        }
        public ActionResult Delete(int id)
        {
            var employeeInDb = context.Employees.Find(id);
            if (employeeInDb == null) return HttpNotFound();
            context.Employees.Remove(employeeInDb);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
     }
}