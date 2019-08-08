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
        private static CvMasterModel MasterModel { get; set; }
        // GET: Builder
        public ActionResult Index()
        {
            return RedirectToAction("Editor");
        }

        // GET: Builder/Details/5
        public ActionResult Editor()
        {
            if (MasterModel == null)
                MasterModel = new CvMasterModel();

            return View(MasterModel);
        }

        public ActionResult FormAddContactInfo(ContactInfo contactInfo)
        {
            if(contactInfo == null)
                contactInfo = new ContactInfo();

            MasterModel.ContactInfo = contactInfo;

            return PartialView("Partials/_AddContactInfo", contactInfo);
        }

        public ActionResult FormAddWork(WorkHistory workHistory)
        {
            if (workHistory == null)
                workHistory = new WorkHistory();

            MasterModel.Work = workHistory;

            return PartialView("Partials/_AddWork", workHistory);
        }

        public ActionResult FormAddEducation(EducationHistory educationHistory)
        {
            if (educationHistory == null)
                educationHistory = new EducationHistory();

            MasterModel.Education = educationHistory;

            return PartialView("Partials/_AddEducation", educationHistory);
        }

        public ActionResult FormAddLanguages(LanguageSkills languageSkills)
        {
            if (languageSkills == null)
                languageSkills = new LanguageSkills();

            MasterModel.Languages = languageSkills;

            return PartialView("Partials/_AddLanguage", languageSkills);
        }

        public ActionResult FormAddSkills(Skills skills)
        {
            if (skills == null)
                skills = new Skills();

            MasterModel.Skills = skills;

            return PartialView("Partials/_AddSkills", skills);
        }

        public ActionResult FormAddCertifications(Certifications certifications)
        {
            if (certifications == null)
                certifications = new Certifications();

            MasterModel.Certifications = certifications;

            return PartialView("Partials/_AddCertifications", certifications);
        }

        public ActionResult FormAddOtherInfo(OtherInfo otherInfo)
        {
            if (otherInfo == null)
                otherInfo = new OtherInfo();

            MasterModel.OtherInfo = otherInfo;

            return PartialView("Partials/_AddOtherInfo", otherInfo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveData(CvMasterModel masterModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Editor");
            }
            else
            {
                return View("Editor", masterModel);
            }
        }
    }
}
