

namespace Banking.UnitTests;

    public class OverdraftOfAccount
{
    [Fact] 
    public void CanTakeAllTheMoney()
    {
        var account = new BankAccount();

        account.Withdraw(account.GetBalance());

        Assert.Equal(0, account.GetBalance());
    }
    [Fact]
    public void OverdraftDoesNotDecreaseTheBalance()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance + .01m;

        try
        {
            account.Withdraw(amountToWithdraw);
        }
        catch 
        { 
        
    } Assert.Equal(openingBalance, account.GetBalance());
    
    }
    [Fact]
    public void OverdraftThrowsAnOverdraftException()
    {
        var account = new BankAccount();
        Assert.Throws<OverdraftException>(() =>
        {
            account.Withdraw(account.GetBalance() + .01m);
        });
        }
}
