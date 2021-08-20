
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace crud_mvc.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("FullName")]
        public string FullName { get; set; }

        [Required]
        [DisplayName("City")]
        public string City { get; set; }

        [Required]
        [DisplayName("Cep")]
        public string CEP { get; set; }

        [Required]
        [DisplayName("District")]
        public string District { get; set; }

        [Required]
        [DisplayName("State")]
        public string State { get; set; }

        [Required]
        [DisplayName("Address")]
        public string Address { get; set; }
        
    }
}
