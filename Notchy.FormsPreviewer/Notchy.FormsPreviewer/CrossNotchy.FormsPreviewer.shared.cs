using System;

namespace Plugin.Notchy.FormsPreviewer
{
    /// <summary>
    /// Cross Notchy.FormsPreviewer
    /// </summary>
    public static class CrossNotchy.FormsPreviewer
    {
        static Lazy<INotchy.FormsPreviewer> implementation = new Lazy<INotchy.FormsPreviewer>(() => CreateNotchy.FormsPreviewer(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

    /// <summary>
    /// Gets if the plugin is supported on the current platform.
    /// </summary>
    public static bool IsSupported => implementation.Value == null ? false : true;

    /// <summary>
    /// Current plugin implementation to use
    /// </summary>
    public static INotchy.FormsPreviewer Current
    {
        get
        {
            INotchy.FormsPreviewer ret = implementation.Value;
            if (ret == null)
            {
                throw NotImplementedInReferenceAssembly();
            }
            return ret;
        }
    }

    static INotchy.FormsPreviewer CreateNotchy.FormsPreviewer()
    {
#if NETSTANDARD1_0 || NETSTANDARD2_0
            return null;
#else
#pragma warning disable IDE0022 // Use expression body for methods
        return new Notchy.FormsPreviewerImplementation();
#pragma warning restore IDE0022 // Use expression body for methods
#endif
    }

    internal static Exception NotImplementedInReferenceAssembly() =>
        new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");

}
}
