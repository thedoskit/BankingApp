using BankingApp.DataAccess.Interfaces;
using BankingApp.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.DataAccess.Repositories
{
    public class AccountRepository : IAccount
    {
        public async Task<(string accountNumber, string accountName)> CreateAccount(AccountCreationDTO accountCreationDTO)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> Deposit(DepositDTO depositDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetAccountBalance(string accountBalance)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Transfer(TransferDTO transferDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Withdrawal(WithdrawalDTO withdrawalDTO)
        {
            throw new NotImplementedException();
        }
    }
}
