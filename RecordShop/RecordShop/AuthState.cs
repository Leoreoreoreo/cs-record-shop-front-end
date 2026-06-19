// Holds the logged-in user's JWT for the current session (scoped per Blazor circuit).
public class AuthState
{
    public string? Token { get; set; }

    public bool IsLoggedIn => !string.IsNullOrEmpty(Token);
}
