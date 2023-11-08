namespace Genocs.BlazorWasm.Template.Shared.MultiTenancy;

public class MultitenancyConstants
{
    public static class Root
    {
        public const string Id = "root";
        public const string Name = "Root";
        public const string EmailAddress = "admin@root.com";
    }

    /// <summary>
    /// Default password for all users created by the system.
    /// </summary>
    public const string DefaultPassword = "123Pa$$word!";

    /// <summary>
    /// Default tenant name used if no tenant is specified.
    /// </summary>
    public const string TenantIdName = "tenant";
}