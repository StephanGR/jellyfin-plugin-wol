using System;
using System.Collections.Generic;
using System.Globalization;
using Jellyfin.Plugin.WakeOnLan.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Controller.Session;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Plugin.WakeOnLan;

/// <summary>
/// The main plugin.
/// </summary>
public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
{
    private readonly ILogger<Plugin> _logger;
    private readonly SessionManager _sessionManager;

    /// <summary>
    /// Initializes a new instance of the <see cref="Plugin"/> class.
    /// </summary>
    /// <param name="applicationPaths">Instance of the <see cref="IApplicationPaths"/> interface.</param>
    /// <param name="xmlSerializer">Instance of the <see cref="IXmlSerializer"/> interface.</param>
    /// <param name="logger">Instance of the <see cref="ILogger{TCategoryName}"/> for logging.</param>
    public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer, ILogger<Plugin> logger)
        : base(applicationPaths, xmlSerializer)
    {
        Instance = this;
        _logger = logger;
        _sessionManager = new SessionManager(_logger);
        _logger.LogInformation("Wake On Lan Plugin started. Server MAC Address: {ServerMacAddress}", Configuration.ServerMacAddress);
    }

    /// <inheritdoc />
    public override string Name => "Wake On Lan";

    /// <inheritdoc />
    public override Guid Id => Guid.Parse("7C883692-BA04-40BD-A6AD-BF90D6D063FA");

    /// <summary>
    /// Gets the current plugin instance.
    /// </summary>
    public static Plugin? Instance { get; private set; }

    /// <inheritdoc />
    public IEnumerable<PluginPageInfo> GetPages()
    {
        return new[]
        {
            new PluginPageInfo
            {
                Name = this.Name,
                EmbeddedResourcePath = string.Format(CultureInfo.InvariantCulture, "{0}.Configuration.configPage.html", GetType().Namespace)
            }
        };
    }
}
