using Microsoft.AspNetCore.Identity;

namespace academia;

public class ApplicationUser : IdentityUser
{
    public string NomeCompleto { get; set; } = string.Empty;
}
