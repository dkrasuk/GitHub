using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [RoutePrefix("Index")]
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            ApplicationViewModel model = new ApplicationViewModel();
            model.Client = new Client() { FIO = "Красюк Дмитрий Витальевич", INN = "125455674455", AgreementId = new List<int>{11555, 11111, 258774, 8545212}};
            model.Address = new Address()
            {
                RegistrationAddress = "Киев, ул.Степана Бандеры 10",
                ResidentAddress = "Киев, ул.Волынская 69"
            };
            model.Comment = "Нет задолженности";
            model.Income = new Income() { Value = 25000, Currency = "UAH" };

            model.Collaterals = new List<Collateral>()
            {
                new Collateral() { Evaluation = "45555", Description = "Земельный участок", Type = "LAND", ID = Guid.NewGuid()},
                new Collateral() { Evaluation = "45555", Description = "Земельный участок", Type = "AUTO",ID = Guid.NewGuid()},
                new Collateral() { Evaluation = "45555", Description = "Земельный участок", Type = "MORTAGE",ID = Guid.NewGuid()},
                new Collateral() { Evaluation = "45555", Description = "Земельный участок", Type = "OTHER",ID = Guid.NewGuid()}
            };

           

            return View("Index", model);
        }

        // GET: Index/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Index/Create
        public ActionResult Create()
        {
            ApplicationViewModel app = new ApplicationViewModel();
            return View(app);
        }

        // POST: Index/Create
        [HttpPost]
        [Route("Create")]
        public HttpResponse Create(ApplicationViewModel model)
        {
            var postRequest = model;
            return null;
        }

        // GET: Index/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Index/Edit/5
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

        // GET: Index/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Index/Delete/5
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
