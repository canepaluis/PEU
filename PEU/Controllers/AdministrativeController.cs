using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PEU.Controllers
{
    public class AdministrativeController : Controller
    {
        // GET: Administrative
        public ActionResult Index()
        {
            return View();
        }

        #region PERFILES
        public ActionResult GeneralData()
        {
            return View();
        }
        public ActionResult ContactService()
        {
            return View();
        }
        public ActionResult EmploymentData()
        {
            return View();
        }
        public ActionResult Document()
        {
            return View();
        }
        public ActionResult Searcher()
        {
            return View();
        }
        public ActionResult Account()
        {
            return View();
        }
        #endregion

        #region PERÍODOS
        public ActionResult AcademicPeriod()
        {
            return View();
        }
        #endregion

        #region GRUPOS
        public ActionResult Group()
        {
            return View();
        }
        #endregion

        #region HORARIOS
        public ActionResult Schedule()
        {
            return View();
        }
        #endregion

        #region EVALUACIÓN
        public ActionResult Evaluation()
        {
            return View();
        }
        #endregion
    }
}