namespace Std2Net8
{
    using System.Reflection;
    using System.Runtime.Versioning;

    public static class TargetFramework
    {
        public static bool? IsNetStandard()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var framework = assembly.GetCustomAttribute<TargetFrameworkAttribute>();
            if (framework == null)
                return null;
            if (string.IsNullOrEmpty(framework.FrameworkDisplayName))
                return null;
            return framework.FrameworkDisplayName.Contains("Standard");
        }
    }

}