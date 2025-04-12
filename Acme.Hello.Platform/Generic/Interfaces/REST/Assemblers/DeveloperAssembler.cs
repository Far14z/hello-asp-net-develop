using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

/// <summary>
/// This class is responsible for convert REST sources to domain entities.
/// </summary>
public static class DeveloperAssembler
{
    /// <summary>
    /// Convert from GreetDeveloperRequest to Developer entity.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public static Developer? ToEntityFromRequest(GreetDeveloperRequest? request)
    {
        if (request == null || 
            string.IsNullOrWhiteSpace(request.firstName) || 
            string.IsNullOrWhiteSpace(request.lastName))
        {
            return null;
        }
        return new Developer(request.firstName, request.lastName);
    }
}