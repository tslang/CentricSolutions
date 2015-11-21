using CentricSolutions.Domain.Models;
using CentricSolutions.Infrastructure;
using CentricSolutions.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CentricSolutions.Controllers
{
    public class PropertiesController : Controller
    {
        private PropertyRepository _repo = new PropertyRepository();
        private PropertyData _data = new PropertyData();

        // GET: Properties
        public ActionResult Index()
        {
            return View();
        }

        #region GetAll
        // GET: List
        public ActionResult List()
        {
            var properties = _repo.GetAllProperties();
            return View(properties);
        }
        #endregion

        // GET: Properties/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Properties/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Properties/Create
        [HttpPost]
        public ActionResult Create(Property property)
        {
            if (property != null)
            {
                _repo.AddProperty(property);
                return RedirectToAction("List");
            }

            return View();
        }

        // GET: Properties/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Properties/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Properties/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Properties/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
