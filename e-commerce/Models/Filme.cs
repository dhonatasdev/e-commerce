using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models
{
    public class Filme
    {
        [Key]
        public int FilmeId { get; set; }
        [Display(Name ="Nome")]
        [Required]
        public string FilmeNome { get; set; }
        [Display(Name ="Descrição")]
        [Required]
        public string FilmeDescricao { get; set; }
        [Display(Name ="Preço")]
        [Required]
        public double FilmePreco { get; set; }
        [Display(Name ="Capa filme")]
        public string FilmeFotoLink { get; set; }
        [Display(Name ="Data de início")]
        [Required]
        public DateTime FilmeDataInicio{get;set;}
        [Display(Name ="Data final")]
        [Required]
        public DateTime FilmeDataFim { get; set; }

        [Display(Name ="Categoria")]
        public Categ FilmeCategoria { get; set; }

        public List<Ator_Filme> Atores_Filmes { get; set; }

        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        public int ProdutorId { get; set; }
        [ForeignKey("ProdutorId")]
        public Produtor Produtor { get; set; }



        public enum Categ
        {
            Acao = 1,
            Comedia = 2,
            Drama = 3,
            Documentario = 4
        }

    }
}