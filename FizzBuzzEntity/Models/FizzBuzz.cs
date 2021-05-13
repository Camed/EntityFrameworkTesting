using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzEntity.Models
{
    public class FizzBuzz
    {
        public int Id { get; set; }
        [Display(Name = "FizzBuzz")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter proper number!"), Required(ErrorMessage = "You need to fill this field!")]
        public int fbNumber { get; set; }

        public string SessionId { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Answer")]
        public string fbValue
        {
            get
            {
                var result = "";
                if (fbNumber % 3 == 0) result += "Fizz";
                if (fbNumber % 5 == 0) result += "Buzz";
                if (result == "") result += fbNumber.ToString();
                return result.ToString();
            }
        }
        public DateTime dateTime { get; set; }
    }
}
