using ProxyDesignPattern;

Console.WriteLine("Proxy Design Pattern");
Console.WriteLine("c");
Console.WriteLine("A proxy receives client requests, does some work (access control, caching, etc.) and then passes the request to a service object.");
Console.WriteLine();

var client = new Client();

Console.WriteLine("Client: Executing the client code with a real subject:");
var realSubject = new RealSubject();
client.ClientCode(realSubject);

Console.WriteLine();

Console.WriteLine("Client: Executing the same client code with a proxy:");
var proxy = new Proxy(realSubject);
client.ClientCode(proxy);