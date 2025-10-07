using System.Windows;

namespace HostelApp.Views;


public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        Closing += (sender, args) => Environment.Exit(0);
    }
}