using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CvBuilder.Models
{
    public class WorkHistory
    {
        public List<WorkExperience> WorkItems { get; set; }

        public int OrderOfItems { get; set; } //0 desc by time, 1 asc by time

        public WorkHistory()
        {
            WorkItems = new List<WorkExperience>();
            for(int i = 0; i < 10; i++)
                WorkItems.Add(new WorkExperience());
            OrderOfItems = 0;
        }
    }

    public class WorkExperience
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public string Details { get; set; }
        
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool CurrentlyHere { get; set; }

        public string Location { get; set; }

        internal bool IsEmpty()
        {
            //required fields are not filled
            return string.IsNullOrEmpty(Title) &&
                string.IsNullOrEmpty(Company) &&
                string.IsNullOrEmpty(Details);
        }
    }
}