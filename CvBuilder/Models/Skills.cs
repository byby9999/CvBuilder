using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CvBuilder.Models
{
    public class Skills
    {
        public List<Skill> Items { get; set; }

        public Skills()
        {
            Items = new List<Skill>();
            Items.Add(new Skill());
        }
    }

    public class Skill
    {
        public string Name { get; set; }
        public int Rating { get; set; }
    }
}