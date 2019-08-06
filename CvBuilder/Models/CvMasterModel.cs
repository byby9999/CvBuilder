using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CvBuilder.Models
{
    public class CvMasterModel
    {
        public ContactInfo ContactInfo { get; set; }
        public WorkHistory Work { get; set; }
        public EducationHistory Education { get; set; }
        public LanguageSkills Languages { get; set; }
        public Skills Skills { get; set; }
        public Certifications Certifications { get; set; }
        public OtherInfo OtherInfo { get; set; }

        public CvMasterModel()
        {
            ContactInfo = new ContactInfo();
            Work = new WorkHistory();
            Education = new EducationHistory();
            Languages = new LanguageSkills();
            Skills = new Skills();
            Certifications = new Certifications();
            OtherInfo = new OtherInfo();
        }
    }
}