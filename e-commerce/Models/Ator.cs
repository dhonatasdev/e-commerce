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
        public string AtorFotoLink { get; set; }
        [Display(Name = "Nome do Ator")]
        [Required]
        public string AtorNomeCompleto { get; set; }
        [Display(Name = "Biográfia do Ator")]
        [Required]
        public string AtorBio { get; set; }
        public List<Ator_Filme> Atores_Filmes { get; set; }
    }
}