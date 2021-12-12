using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PEU.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        #region PERFILES
        public ActionResult NewUser()
        {
            return View();
        }
        public ActionResult Searcher()
        {
            return View();
        }
        #endregion

        #region CARRERAS
        public ActionResult Career()
        {
            return View();
        }
        #endregion

        #region PLANES
        public ActionResult AcademicPlan()
        {
            return View();
        }
        #endregion

        #region ASIGNATURAS
        public ActionResult Subjects()
        {
            return View();
        }
        #endregion

        #region PERIODOS
        public ActionResult AcademicPeriod()
        {
            return View();
        }
        #endregion

        #region GRUPOS
        public ActionResult Groups()
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