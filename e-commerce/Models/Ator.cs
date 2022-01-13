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
        public int AtorId { get; set; }
        public string AtorFotoLink { get; set; }
        public string AtorNomeCompleto { get; set; }
        public string AtorBio { get; set; }
        public List<Ator_Filme> Atores_Filmes { get; set; }
    }
}