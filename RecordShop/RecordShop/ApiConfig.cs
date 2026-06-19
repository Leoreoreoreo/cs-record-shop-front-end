public static class ApiConfig
{
    public const string BaseUrl = "http://localhost:5113";

    // Sent as the X-Api-Key header on write requests. The write forms render on the
    // server (InteractiveServer), so this is not exposed to the browser.
    public const string ApiKey = "dev-secret-key";
}
