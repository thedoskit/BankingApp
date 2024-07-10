using BankingApp.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.DataAccess.Interfaces
{
    public interface IAccount
    {
        Task<(string accountNumber,string accountName)> CreateAccount(AccountCreationDTO accountCreationDTO);

        Task<string> GetAccountBalance(string accountBalance);

        Task<string> Deposit( DepositDTO depositDTO);

        Task<string> Transfer( TransferDTO transferDTO);

        Task<string> Withdrawal( WithdrawalDTO withdrawalDTO);

    }
}
