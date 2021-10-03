namespace ConsoleClientFromTemplate
{
    public partial class swaggerClient
    {
        partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings)
        {
            // we may adjust JsonSerializerSettings, but NodaTime.Serialization.SystemTextJson package supports only adjusting JsonSerializerOptions
        }

    }
}