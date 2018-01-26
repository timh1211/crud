using System;
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
        [HttpGet()]
        public IHttpActionResult Get()
        {
            IHttpActionResult ret = null;
            List<Product> list = new List<Product>();
            list = CreateMockData();
            ret = Ok(list);
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
