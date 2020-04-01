using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_MVC.Models
{
    //public class CustomModelBinding : IModelBinder
    //{

    //    public Task BindModelAsync(ModelBindingContext bindingContext)
    //    {
    //        HttpRequestBase request = controllerContext.HttpContext.Request;

    //        string title = request.Form.Get("Title");
    //        string day = request.Form.Get("Day");
    //        string month = request.Form.Get("Month");
    //        string year = request.Form.Get("Year");

    //        return new HomePageModels
    //        {
    //            Title = title,
    //            Date = day + "/" + month + "/" + year
    //        };
    //    }
    //}

}
