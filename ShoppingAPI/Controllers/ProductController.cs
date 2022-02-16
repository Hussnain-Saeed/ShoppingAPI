﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ShoppingAPI.Models;

namespace ShoppingAPI.Controllers
{
    public class ProductController : ApiController
    {
        private ShoppingContext db = new ShoppingContext();

        public IHttpActionResult GetProducts(string keyword="",int skip=0,int take=10)
        {
            return Json(db.Products.Where(x=>string.IsNullOrEmpty(keyword) || x.Title.Contains(keyword)).OrderByDescending(x=>x.AddedOn).Skip(skip).Take(take).ToList());
        }
    }
}