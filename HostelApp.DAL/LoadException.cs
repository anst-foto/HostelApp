namespace HostelApp.DAL;

public class LoadException : Exception
{
    public LoadException(string path) 
        : base($"Ошибка загрузки данных из {path}") { }
    public LoadException(string path, Exception innerException) 
        : base($"Ошибка загрузки данных из {path}", innerException) { }
    
}