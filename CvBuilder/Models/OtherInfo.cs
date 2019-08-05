using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CvBuilder.Models
{
    public class OtherInfo
    {
        public List<string> Items { get; set; }

        public OtherInfo()
        {
            Items = new List<string>();
            Items.Add("");
        }
    }
}