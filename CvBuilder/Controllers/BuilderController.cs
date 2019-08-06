using CvBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CvBuilder.Controllers
{
    public class BuilderController : Controller
    {
        // GET: Builder
        public ActionResult Index()
        {
            return RedirectToAction("Editor");
        }

        // GET: Builder/Details/5
        public ActionResult Editor()
        {
            CvMasterModel model = new CvMasterModel();
            return View(model);
        }

        public ActionResult FormAddContactInfo(ContactInfo passed)
        {
            if(passed == null)
                passed = new ContactInfo();
            return PartialView("Partials/_AddContactInfo", passed);
        }

        public ActionResult FormAddWork()
        {
            WorkHistory model = new WorkHistory();
            return PartialView("Partials/_AddWork", model);
        }

        public ActionResult FormAddEducation()
        {
            EducationHistory model = new EducationHistory();
            return PartialView("Partials/_AddEducation", model);
        }

        public ActionResult FormAddLanguages()
        {
            LanguageSkills model = new LanguageSkills();
            return PartialView("Partials/_AddLanguage", model);
        }

        public ActionResult FormAddSkills()
        {
            Skills model = new Skills();
            return PartialView("Partials/_AddSkills", model);
        }

        public ActionResult FormAddCertifications()
        {
            Certifications model = new Certifications();
            return PartialView("Partials/_AddCertifications", model);
        }

        public ActionResult FormAddOtherInfo()
        {
            OtherInfo model = new OtherInfo();
            return PartialView("Partials/_AddOtherInfo", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveData()
        {
            throw new NotImplementedException();
        }
    }
}
