using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _0._18_GuessingGame.Models
{
    public class GameModel
    {
        [Required]
        [MaxLength(25, ErrorMessage = "The name must be fewer than 25 characters long")]
        [Display(Name = "Player Name")]
        public string PlayerName { get; set; }
        
        [Range(1, 10, ErrorMessage = "Guess must be between 1 and 10")]
        //can never be null int is a value type
        public int Guess { get; set; }
    }
}