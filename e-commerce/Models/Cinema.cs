using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        public string CinemaLogo { get; set; }
        public string CinemaNome { get; set; }
        public string CinemaDescricao { get; set; }
        public List<Filme> Filmes { get; set; }

    }
}