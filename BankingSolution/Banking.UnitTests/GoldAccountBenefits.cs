

using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests;

public class GoldAccountBenefits
{
    [Fact]
    public void GetBonusOnDeposit()
    {
        var stubbedBonusCalculator = new Mock<ICalculateBonuses>();
        var account = new BankAccount(stubbedBonusCalculator.Object);
        var openingBalance = account.GetBalance();
        var amountToDeposit = 92.42m;
        var expectedBonus = 42m;
        stubbedBonusCalculator.Setup(s => s.GetBonusForDepositOn(openingBalance, amountToDeposit)).Returns(expectedBonus);
        
        account.Deposit(amountToDeposit);

        Assert.Equal(openingBalance + amountToDeposit + expectedBonus,
            account.GetBalance());

    }
}