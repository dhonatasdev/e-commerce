using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Ator_Filme
    {
        [Key]
        public int FilmeId { get; set; }
        public Filme Filme { get; set; }
        public int AtorId { get; set; }
        public Ator Ator { get; set; }
    }
}