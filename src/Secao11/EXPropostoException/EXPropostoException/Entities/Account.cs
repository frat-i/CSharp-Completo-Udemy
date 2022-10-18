using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXPropostoException.Entities.Exceptions;

namespace EXPropostoException.Entities
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int accountNumber, string holder, double balance, double withdrawLimit)
        {
            AccountNumber = accountNumber;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(Balance == 0)
            {
                throw new DomainException("The account balance needs to be more than Zero to make a withdraw");
            }
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds the withdraw limit");
            }
            if(amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }
            Balance -= amount;
        }


    }
}
