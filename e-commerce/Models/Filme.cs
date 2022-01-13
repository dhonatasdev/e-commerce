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
        public string FilmeNome { get; set; }
        public string FilmeDescricao { get; set; }
        public double FilmePreco { get; set; }
        public string FilmeFotoLink { get; set; }

        public DateTime FilmeDataInicio{get;set;}
        public DateTime FilmeDataFim { get; set; }

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