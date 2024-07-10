using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Domain.DTOs
{
    public class TransferDTO
    {
        public string SenderAccount {  get; set; }
        public string ReceiverAccount { get; set; }
        public decimal Amount { get; set; }
    }
}
