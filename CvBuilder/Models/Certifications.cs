using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CvBuilder.Models
{
    public class Certifications
    {
        public List<CertificationOrTraining> CertificationItems { get; set; }

        public Certifications()
        {
            CertificationItems = new List<CertificationOrTraining>();
            for (int i = 0; i < 10; i++)
                CertificationItems.Add(new CertificationOrTraining());
        }
    }

    public class CertificationOrTraining
    {
        public string Name { get; set; }
        public string Organization { get; set; }
        public string DateEarned { get; set; }
        public string ExpireDate { get; set; }
        public bool DoesExpire { get; set; }
        public string CredentialUrl { get; set; }

    }
}