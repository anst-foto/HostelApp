namespace HostelApp.ViewModels;

public abstract class ViewModelBase : Notify
{
    public string Title { get; set; }

    protected ViewModelBase(string title)
    {
        Title = title;
    }
}