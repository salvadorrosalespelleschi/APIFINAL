using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FINAL.Models
{
    public class Numero
    {
        [Key]
        [Required]
        public int numero { get; set; }
        public string Mensaje { get; set; }
    }
}