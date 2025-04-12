namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

/// <summary>
/// This is a request to greet a developer.
/// Contains the first and last name of the developer, used as input for the greeting request.
/// </summary>
/// <param name="firstName">The first name of the developer. Can be null.</param>
/// <param name="lastName">The last name of the developer. Can be null</param>
public record GreetDeveloperRequest(string? firstName, string? lastName)
{

}