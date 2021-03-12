using System;
using System.Collections.Generic;

#nullable disable

namespace ReactApi.Models
{
    public partial class Product
    {
        public int IdProduct { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
    }
}
