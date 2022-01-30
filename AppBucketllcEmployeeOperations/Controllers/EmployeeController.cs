using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppBucketllcEmployeeOperations.Models;

namespace AppBucketllcEmployeeOperations.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            using (AppBucketEntities dbModel = new AppBucketEntities())
            {
                return View(dbModel.tblEmployees.ToList());
            }
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            using (AppBucketEntities dbModel = new AppBucketEntities())
            {
                return View(dbModel.tblEmployees.Where(x => x.EmpId == id).FirstOrDefault());
            }
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(tblEmployee objEmployee)
        {
            try
            {
                using (AppBucketEntities dbModel = new AppBucketEntities())
                {
                    objEmployee.CreatedDate = DateTime.Now;
                    objEmployee.ModifiedDate = DateTime.Now;

                    dbModel.tblEmployees.Add(objEmployee);
                    dbModel.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            using (AppBucketEntities dbModel = new AppBucketEntities())
            {
                return View(dbModel.tblEmployees.Where(x => x.EmpId == id).FirstOrDefault());
            }
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, tblEmployee objEmployee)
        {
            try
            {
                using (AppBucketEntities dbModel = new AppBucketEntities())
                {
                    dbModel.Entry(objEmployee).State = System.Data.Entity.EntityState.Modified;
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            using (AppBucketEntities dbModel = new AppBucketEntities())
            {
                return View(dbModel.tblEmployees.Where(x => x.EmpId == id).FirstOrDefault());
            }
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (AppBucketEntities dbModel = new AppBucketEntities())
                {
                    tblEmployee objEmployee = dbModel.tblEmployees.Where(x => x.EmpId == id).FirstOrDefault();
                    dbModel.tblEmployees.Remove(objEmployee);
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
