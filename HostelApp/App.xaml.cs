using System.Windows;
using System.Windows.Threading;

namespace HostelApp;

public partial class App : Application
{
    private static readonly NLog.Logger Logger = 
        NLog.LogManager.GetCurrentClassLogger();
    
    private void App_OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
    {
        Logger.Error(e.Exception);
        
        MessageBox.Show(
            caption: "!!! ERROR !!!",
            messageBoxText: "Выполнил невыполнимое",
            button: MessageBoxButton.OK,
            icon: MessageBoxImage.Error
            );
        
        Environment.Exit(1);
    }
}