namespace LibrarySystem.Common.Configuration
{
    /// <summary>
    /// Configuration section names used across microservices. Use these constants instead of string literals in GetSection("...").
    /// </summary>
    public static class ConfigSectionNames
    {
        public const string RabbitMq = "RabbitMq";
        public const string Jwt = "Jwt";
        public const string MongoSettings = "MongoSettings";
    }
}
