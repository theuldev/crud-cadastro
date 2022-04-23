using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace crud_mvc.Models
{
    public class Client
    {
        
        [Key]
     

        public int Id { get; set; }

        [Required]
        [DisplayName("Nome")]
        

        public string FullName { get; set; }
            
        [Required]
        [DisplayName("Cidade")]
        

        public string City { get; set; }

        [Required]
        [DisplayName("Cep")]
        

        public string CEP { get; set; }

        [Required]
        [DisplayName("Bairro")]
        public string District { get; set; }

        [Required]
        [DisplayName("Estado")]
        

        public string State { get; set; }

        [Required]
        [DisplayName("Rua")]
        public string Address { get; set; }

        [Required]
        [DisplayName("CPF")]
        public string CPF { get; set; }

        [Required]
        [DisplayName("RG")]
        public string RG { get; set; }

        [Required]
        [DisplayName("Sexo")]
        public string Gender { get; set; }

        [Required]
        [DisplayName("Telefone")]
        public string Phone { get; set; }

        [Required]
        [DisplayName("Profissão")]
        public string Career { get; set; }

        [Required]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Serviço")]
        public string Service { get; set; }

        [Required]
        [DisplayName("Detalhes")]
        public string Details { get; set; }

        [Required]
        [DisplayName("Convênio")]
        public string HealthI { get; set; }

        [Required]
        [DisplayName("Estado Civil")]
        public string MCivil { get; set; }




    }
}
