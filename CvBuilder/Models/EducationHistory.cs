using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CvBuilder.Models
{
    public class EducationHistory
    {
        public List<EducationExperience> Items { get; set; }

        public EducationHistory()
        {
            Items = new List<EducationExperience>();
            Items.Add(new EducationExperience());
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