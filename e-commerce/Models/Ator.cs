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
        [Display(Name= "Id do Ator")]
        [Required]
        public int AtorId { get; set; }
        [Display(Name = "Link da foto")]
        public string AtorFotoLink { get; set; }
        [Display(Name = "Nome completo")]
        [Required]
        public string AtorNomeCompleto { get; set; }
        [Display(Name = "Biográfia")]
        [Required]
        public string AtorBio { get; set; }
        public List<Ator_Filme> Atores_Filmes { get; set; }
    }
}