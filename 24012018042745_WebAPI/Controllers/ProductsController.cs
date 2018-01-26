﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using _24012018042745_WebAPI.Models;

namespace _24012018042745_WebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        private ProductContext db = new ProductContext();
        [HttpGet()]
        public IHttpActionResult Get()
        {
            IHttpActionResult ret = null;
            List<Product> list = new List<Product>();
            list = db.Products.ToList();
            ret = Ok(list);
            return ret;
        }
        [HttpGet()]
        public IHttpActionResult Get(int id)
        {
            IHttpActionResult ret;
            Product prod = new Product();
            prod = db.Products.Where(p=>p.ProductId.Equals(id)).First();
            if (prod == null)
            {
                ret = NotFound();
            }
            else
            {
                ret = Ok(prod);
            }
            return ret;
        }
        [HttpPost()]
        public IHttpActionResult Post(Product product)
        {
            IHttpActionResult ret = null;
            product = db.Products.Add(product);
            db.SaveChanges();
            if (product != null)
            {
                ret = Created<Product>(Request.RequestUri +
                     product.ProductId.ToString(), product);
            }
            else
            {
                ret = NotFound();
            }
            return ret;
        }

        private List<Product> CreateMockData()
        {
            List<Product> ret = new List<Product>();
            ret.Add(new Product()
            {
                ProductId = 1,
                ProductName = "Extending Bootstrap with CSSJavaScript and jQuery",
                IntroductionDate = Convert.ToDateTime("06/29/2017"),
                Url = "http://bit.ly/1SNzc0i"
            });

            ret.Add(new Product()
            {
                ProductId = 2,
                ProductName = "Build your own Bootstrap BusinessApplication Template in MVC",
                IntroductionDate = Convert.ToDateTime("1/31/2017"),
                Url = "http://bit.ly/1I8ZqZg"
            });

            ret.Add(new Product()
            {
                ProductId = 3,
                ProductName = "Building Mobile Web Sites Using Web Forms Bootstrapand HTML5",
                IntroductionDate = Convert.ToDateTime("8/2/2017"),
                Url = "http://bit.ly/1J2dcrj"
            });

            return ret;
        }
    }
}
