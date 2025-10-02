namespace HostelApp.DAL.Test;

public class AccountServiceTest
{
    [Fact]
    public void Load_Test_Positive()
    {
        var expected = new List<Account>()
        {
            new()
            {
                Id = Guid.Parse("676D743D-F76C-4026-A740-DC1259B684C5"),
                Login = "admin",
                Password = "admin"
            }
        };
        
        var actual = AccountService.Load("accounts_test.json");
        
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Load_Test_Negative()
    {
        Assert.Throws<LoadException>(() => AccountService.Load("accounts_.json"));
    }
}