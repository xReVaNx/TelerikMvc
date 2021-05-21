using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelerikMvc.Models;

namespace TelerikMvc.Controllers
{
    public class TestGridController : Controller
    {
        // GET: TestGrid
        [HttpGet]
        public ActionResult Grid_Read([DataSourceRequest]DataSourceRequest request)
        {
            Person[] personList = new Person[]
            {
                new Person {Firstname = "Adam", Lastname = "Nowak", Company = "CDP", ExperienceInYears = 10},
                new Person {Firstname = "Kamil", Lastname = "Kowalski", Company = "Accenture", ExperienceInYears = 5},
                new Person {Firstname = "Dariusz", Lastname = "Kamiński", Company = "Microsoft", ExperienceInYears = 8},
                new Person {Firstname = "Maciej", Lastname = "Dołęgowski", Company = "Google", ExperienceInYears = 2},
                new Person {Firstname = "Dominik", Lastname = "Stachurski", Company = "IBM", ExperienceInYears = 3}
            };

            return Json(personList.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }
    }
}