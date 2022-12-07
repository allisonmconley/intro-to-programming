﻿namespace Banking.Domain
{
    public class BankAccount
    {
        private decimal _balance = 5000;
        public void Deposit(decimal amountToDeposit)
        {
            _balance = _balance + amountToDeposit;
        }
        public void Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw > _balance)
            {
                throw new OverdraftException();
            }
            else
            {
                _balance = _balance - amountToWithdraw;
            }
        }
        public decimal GetBalance()
        {
            return _balance;
        }
    }
}