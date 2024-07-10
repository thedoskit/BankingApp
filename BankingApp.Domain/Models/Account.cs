using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Domain.Models
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string AccountName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Length(10, 10, ErrorMessage ="Account number must be 10")]
        public string AccountNumber { get; set; }

        public decimal AccountBalance { get; set; } = 0;


    }
}
