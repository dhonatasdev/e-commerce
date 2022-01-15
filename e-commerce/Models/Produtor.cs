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
        [Display(Name ="Link da foto")]
        [Required]
        public string ProdutorFotoLink { get; set; }
        [Display(Name ="Nome completo")]
        [Required]
        public string ProdutorNomeCompleto { get; set; }
        [Display(Name ="Biográfia")]
        [Required]
        public string ProdutorBio { get; set; }
        public List<Filme> Filmes { get; set; }
    }
}