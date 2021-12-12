using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PEU.Controllers
{
    public class ProfessorController : Controller
    {
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
        public ActionResult History()
        {
            return View();
        }
        public ActionResult Account()
        {
            return View();
        }
        #endregion

        #region PERIODOS
        public ActionResult AcademicPeriods()
        {
            return View();
        }
        #endregion

        #region GRUPOS
        public ActionResult AcademicGroups()
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

        #region EVALUACION
        public ActionResult Evaluation()
        {
            return View();
        }
        #endregion
    }
}