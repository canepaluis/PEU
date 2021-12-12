using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PEU.Controllers
{
    public class DirectorController : Controller
    {
        // GET: Director
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

        public ActionResult Documents()
        {
            return View();
        }

        public ActionResult Account()
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
        public ActionResult Subject()
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
        public ActionResult Groups()
        {
            return View();
        }
        #endregion

        #region HORARIOS
        public ActionResult Schedules()
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