using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CvBuilder.Models
{
    public class LanguageSkills
    {
        public List<LanguageSkill> LanguageItems { get; set; }
        public List<string> AllLanguages { get; set; }
        public List<string> AllLevels { get; set; }

        public LanguageSkills()
        {
            LanguageItems = new List<LanguageSkill>();
            for (int i = 0; i < 10; i++)
                LanguageItems.Add(new LanguageSkill());

            AllLanguages = new List<string>();
            AllLanguages.Add("English");
            AllLanguages.Add("French");
            AllLanguages.Add("German");

            AllLevels = new List<string>();
            AllLevels.Add("Beginner");
            AllLevels.Add("Intermediate");
            AllLevels.Add("Professional");
            AllLevels.Add("Native/Billingual");
        }
    }

    public class LanguageSkill
    {
        public string Language { get; set; }
        public string Level { get; set; }
    }
}