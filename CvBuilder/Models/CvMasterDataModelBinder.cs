﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web;
using System.Web.Mvc;

namespace CvBuilder.Models
{
    public class CvMasterDataModelBinder : IModelBinder
    {

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpRequestBase request = controllerContext.HttpContext.Request;

            //int id = Convert.ToInt32(request.Form.Get("Id"));
            //string address = request.Form.Get("Address");
            //DateTime joinDate = Convert.ToDateTime(request.Form.Get("JoinDate"));
            DateTime? birthDate = null;
            var fullName = request.Form.Get("FullName");
            var email = request.Form.Get("Email");
            var bday = request.Form.Get("Birthday");

            if(string.IsNullOrEmpty(bday) == false)
                birthDate = Convert.ToDateTime(bday);
            var liprofile = request.Form.Get("LinkedinProfile");
            var location = request.Form.Get("Location");
            var phone = request.Form.Get("Phone");
            var website = request.Form.Get("Website");
            
            var masterModel = new CvMasterModel();
            masterModel.ContactInfo =
                new ContactInfo()
                {
                    FullName = fullName,
                    Email = email,
                    Birthday = birthDate,
                    LinkedinProfile = liprofile,
                    Location = location,
                    Phone = phone,
                    Website = website
                };
            
            WorkExperience workItem = new WorkExperience();
            workItem.Title = request.Form.Get("Items[0].Title");
            workItem.Company = request.Form.Get("Items[0].Company");
            workItem.Details = request.Form.Get("Items[0].Details");
            workItem.Location = request.Form.Get("Items[0].Location");
            workItem.CurrentlyHere = Convert.ToBoolean(request.Form.Get("Items[0].CurrentlyHere"));

            string startDateString = request.Form.Get("Items[0].StartDate");
            string endDateString = request.Form.Get("Items[0].EndDate");

            workItem.StartDate = DateTime.ParseExact(startDateString, "dd-mm-yyyy", CultureInfo.InvariantCulture);
            if(string.IsNullOrEmpty(endDateString) == false)
                workItem.EndDate = DateTime.ParseExact(endDateString, "dd-mm-yyyy", CultureInfo.InvariantCulture);

            masterModel.AddWork(workItem);

            return masterModel;
        }
    }
}