using System.Text.Json;

namespace HostelApp.DAL;

public class AccountService
{
    public static void Save(IEnumerable<Account> accounts, string path = "accounts.json")
    {
        var json = JsonSerializer.Serialize(accounts);
        File.WriteAllText(path, json);
    }

    public static IEnumerable<Account> Load(string path = "accounts.json")
    {
        try
        {
            var json = File.ReadAllText(path);
            var accounts = JsonSerializer.Deserialize<IEnumerable<Account>>(json);
            return accounts ?? throw new LoadException(path);
        }
        catch (Exception e)
        {
            throw new LoadException(path, e);
        }
    }
}