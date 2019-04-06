using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CookWeb.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ApplicationUser Author { get; set; }
    }
}