namespace ProxyDesignPattern;

public class Proxy : ISubject
{
    private RealSubject _realSubject;
    
    public Proxy(RealSubject realSubject)
    {
        _realSubject = realSubject;
    }

    public void Request()
    {
        if (!CheckAccess())
            return;
        
        _realSubject.Request();
        LogAccess();
    }

    public bool CheckAccess()
    {
        Console.WriteLine("Proxy: Checking access.");
        return true;
    }

    public void LogAccess() =>
        Console.WriteLine("Proxy: Logging access.");
}
