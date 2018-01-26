using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _24012018042745_WebAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public DateTime IntroductionDate { get; set; }
        public string Url { get; set; }
    }
}