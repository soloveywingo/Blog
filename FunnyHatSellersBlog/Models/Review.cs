using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FunnyHatSellersBlog.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string Topic { get; set; }

        public string Text { get; set; }

        public DateTime Date { get; set; }
    }
}