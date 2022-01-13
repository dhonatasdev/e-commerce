using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Ator
    {
        [Key]
        public int Id { get; set; }
        public string FotoLink { get; set; }
        public string NomeCompleto { get;set }
        public string Bio { get;set }
    }
}