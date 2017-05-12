using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyShoppingCartTrial.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public int ItemId { get; set; }     
    }
}