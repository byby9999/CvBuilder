using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CvBuilder.Models
{
    public class LanguageSkills
    {
        public List<LanguageSkill> Items { get; set; }
        public List<string> AllLanguages { get; set; }

        public LanguageSkills()
        {
            Items = new List<LanguageSkill>();
            Items.Add(new LanguageSkill());
            AllLanguages = new List<string>();
            AllLanguages.Add("English");
            AllLanguages.Add("French");
            AllLanguages.Add("German");
        }
    }

    public class LanguageSkill
    {
        public string Language { get; set; }
        public string Level { get; set; }
    }
}