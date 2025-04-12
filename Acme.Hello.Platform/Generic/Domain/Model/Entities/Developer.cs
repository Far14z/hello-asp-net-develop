namespace Acme.Hello.Platform.Generic.Domain.Model.Entities;

/// <summary>
/// Represents a developer entity in the domain model for the generic bounded context.
/// </summary>
public class Developer
{
    /// <summary>
    /// Gets the unique identifier for the developer.
    /// </summary>
    public Guid Id { get; } = Guid.NewGuid();

    /// <summary>
    /// Gets the first name of the developer.
    /// </summary>
    public string FirstName { get; }
    public string LastName { get; }


    /// <summary>
    /// Initializes a new instance of the <see cref="Developer"/> class with the specified first and last name.
    /// </summary>
    ///
    /// <remarks>
    /// The constructor ensures that the first and last names are trimmed and not null or empty.
    /// </remarks>
    ///
    /// <param name="firstName">The first name of the developer.</param>
    /// <param name="lastName">The last name of the developer.</param>
    public Developer(string firstName, string lastName)
    {
        FirstName = string.IsNullOrWhiteSpace(firstName) ? "" : firstName.Trim();
        LastName = string.IsNullOrWhiteSpace(lastName) ? "" : lastName.Trim();
    }
    
    /// <summary>
    /// Gets the full name of the developer by concatenating the first and last names.
    /// </summary>
    /// <returns>The full name of the developer.</returns>
    public string GetFullName() => $"{FirstName} {LastName}".Trim();
    
    /// <summary>
    /// Gets the initials of the developer by concatenating the first letters of the first and last names.
    /// </summary>
    /// <returns>True if either names is empty: otherwise, false</returns>
    public bool IsAnyNameEmpty() => string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName);
}