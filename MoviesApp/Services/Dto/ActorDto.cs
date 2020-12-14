using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MoviesApp.Filters;
using MoviesApp.Models;

namespace MoviesApp.Services.Dto
{
    public class ActorDto
    {
        public int? Id { get; set; }

        [Required]
        [FIOLength(4, ErrorMessage = "Firstname length cant be more than 4 symbols")]
        public string Firstname { get; set; }


        [Required]
        [FIOLength(4, ErrorMessage = "Lastname length cant be more than 4 symbols")]
        public string Lastname { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [ActorAge]
        public DateTime Birthdate { get; set; }
    }
}