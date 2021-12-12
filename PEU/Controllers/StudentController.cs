using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PEU.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        #region PERFIL
        public ActionResult GeneralData()
        {
            return View();
        }

        public ActionResult ContactService()
        {
            return View();
        }

        public ActionResult Provenance()
        {
            return View();
        }

        public ActionResult AditionalData()
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

        #region HORARIOS
        public ActionResult Schedules()
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