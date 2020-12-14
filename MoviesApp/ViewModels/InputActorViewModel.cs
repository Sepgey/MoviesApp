using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MoviesApp.Filters;
using MoviesApp.Models;

namespace MoviesApp.ViewModels
{
    public class InputActorViewModel
    {
        [Required] public int Id { get; set; }

        [FIOLength(4, ErrorMessage = "Firstname length cant be more than 4 symbols")]
        public string Firstname { get; set; }

        [FIOLength(4, ErrorMessage = "Firstname length cant be more than 4 symbols")]
        public string Lastname { get; set; }

        [Required] [DataType(DataType.Date)] public DateTime Birthdate { get; set; }
    }
}