using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CvBuilder.Models
{
    public class EducationHistory
    {
        public List<EducationExperience> EducationItems { get; set; }

        public EducationHistory()
        {
            EducationItems = new List<EducationExperience>();
            for (int i = 0; i < 10; i++)
                EducationItems.Add(new EducationExperience());
        }
    }

    public class EducationExperience
    {
        public string SchoolName { get; set; }
        public string Degree { get; set; }
        public string FieldOfStudy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public string Description { get; set; }
    }
}