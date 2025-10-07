using System.Windows;
using System.Windows.Input;
using HostelApp.DAL;
using HostelApp.Views;

namespace HostelApp.ViewModels;

public class AuthWindowViewModel : ViewModelBase
{
    private string? _inputLogin;
    public string? InputLogin
    {
        get => _inputLogin;
        set => SetField(ref _inputLogin, value);
    }
    
    private string? _inputPassword;
    public string? InputPassword
    {
        get => _inputPassword;
        set => SetField(ref _inputPassword, value);
    }
    
    public ICommand CommandLogin { get; }
    public ICommand CommandExit { get; }

    private readonly IEnumerable<Account> _accounts;

    public AuthWindowViewModel() : base("Авторизация")
    {
        _accounts = AccountService.Load();

        CommandLogin = new LambdaCommand(
            execute: _ => Login(),
            canExecute: _ => CanLogin());
        CommandExit = new LambdaCommand(execute: _ => Environment.Exit(0));
    }

    private void Login()
    {
        var account = _accounts.SingleOrDefault(a => a.Login == InputLogin && a.Password == InputPassword);
        if (account is null) return;
        
        var window = new MainWindow();
        window.Show();
    }

    private bool CanLogin() => !string.IsNullOrEmpty(InputLogin) 
                               && !string.IsNullOrEmpty(InputPassword);
}