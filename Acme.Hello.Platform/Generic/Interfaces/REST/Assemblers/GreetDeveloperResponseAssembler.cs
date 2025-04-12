using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

/// <summary>
/// This class is responsible for converting domain entities to REST resources.
/// </summary>
public static class GreetDeveloperResponseAssembler
{
    /// <summary>
    /// Convert Developer entity to GreetDeveloperResponse resource.
    /// </summary>
    /// <param name="developer">The Developer entity to convert.</param>
    /// <returns>A GreetDeveloperResponse Object</returns>
    public static GreetDeveloperResponse ToResponseFromEntity(Developer? developer)
    {
        if (developer == null || developer.IsAnyNameEmpty())    
            return new GreetDeveloperResponse("Welcome Anonymous ASP .NET Developer!");

        return new GreetDeveloperResponse( developer.Id, developer.GetFullName(), 
            $"Congrats {developer.GetFullName()}! You are an ASP .NET Developer!");
    }
}