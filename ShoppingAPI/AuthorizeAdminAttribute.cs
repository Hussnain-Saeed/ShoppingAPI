using ShoppingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace ShoppingAPI
{
    public class AuthorizeAdminAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            bool IsAdmin = false;
            string accessToken= HttpContext.Current.Request.Headers.Get("access-token");
            if (!string.IsNullOrEmpty(accessToken))
                IsAdmin= new ShoppingContext().Users.Where(x => x.AccessToken.Equals(accessToken) && x.RoleId==3).Any();

            if (!IsAdmin)
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized,"You are not Admin");
        }
    }
}