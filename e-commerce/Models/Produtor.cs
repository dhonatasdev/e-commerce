using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Produtor
    {
        [Key]
        public int ProdutorId { get; set; }
        public string ProdutorFotoLink { get; set; }
        public string ProdutorNomeCompleto { get; set; }
        public string ProdutorBio { get; set; }
        public List<Filme> Filmes { get; set; }
    }
}