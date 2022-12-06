

using Banking.Domain;

namespace Banking.UnitTests
{
    public class MakingWithdrawals
    {
        [Theory]
        [InlineData(100)]
        [InlineData(50)]
        public void MakingWithdrawalsDecreasesBalance(decimal amountToWithdrawal)
        {
            //Given
            var account = new BankAccount();
            var openingBalance = account.GetBalance();

            //When
            account.Withdraw(amountToWithdrawal);

            //Then
            Assert.Equal(openingBalance - amountToWithdrawal,
                account.GetBalance());
        }
    }
}
