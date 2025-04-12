namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;


/// <summary>
/// This response is used to greet a developer. it contains the developer's ID, full name, and a message.
/// It is used as output for the greeting request.
/// </summary>
/// <param name="Id">The ID of the developer</param>
/// <param name="Fullname"></param>
/// <param name="Message"></param>
public record GreetDeveloperResponse(Guid? Id, string? Fullname, string Message)
{
    /// <summary>
    /// This constructor is used to create a GreetDeveloperResponse with only the message.
    /// </summary>
    /// <param name="Message"></param>
    public GreetDeveloperResponse(string Message) : this(null, null, Message)
    {

    }

}