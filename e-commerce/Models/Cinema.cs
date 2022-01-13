using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Cinema
    {
        [Key]
        public string Logo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

    }
}