﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CvBuilder.Models
{
    public class OtherInfo
    {
        public List<string> OtherInfoItems { get; set; }

        public OtherInfo()
        {
            OtherInfoItems = new List<string>();
            OtherInfoItems.Add("");
        }
    }
}