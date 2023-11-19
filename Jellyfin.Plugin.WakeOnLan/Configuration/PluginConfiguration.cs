using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.WakeOnLan.Configuration;

/// <summary>
/// Plugin configuration.
/// </summary>
public class PluginConfiguration : BasePluginConfiguration
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PluginConfiguration"/> class.
    /// </summary>
    public PluginConfiguration()
    {
        ServerMacAddress = "11:22:33:44:55:66";
    }

    /// <summary>
    /// Gets or sets ServerMacAddress string.
    /// </summary>
    public string ServerMacAddress { get; set; }
}
