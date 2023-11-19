using System.Threading.Tasks;
using MediaBrowser.Controller;
using MediaBrowser.Controller.Events;
using MediaBrowser.Controller.Events.Session;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Plugin.WakeOnLan
{
    /// <summary>
    /// Session start notifier.
    /// </summary>
    public class SessionStartNotifier : IEventConsumer<SessionStartedEventArgs>
    {
        private readonly IServerApplicationHost _applicationHost;
        private readonly ILogger<SessionStartNotifier> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionStartNotifier"/> class.
        /// </summary>
        /// <param name="applicationHost">Instance of the <see cref="IServerApplicationHost"/> interface.</param>
        /// <param name="logger">Instance of the &lt;see cref="ILogger"/&gt; interface.</param>
        public SessionStartNotifier(IServerApplicationHost applicationHost, ILogger<SessionStartNotifier> logger)
        {
            _applicationHost = applicationHost;
            _logger = logger;
        }

        /// <inheritdoc />
        public Task OnEvent(SessionStartedEventArgs eventArgs)
        {
            if (eventArgs?.Argument is null)
            {
                _logger.LogInformation("Aucun argument de session fourni.");
                return Task.CompletedTask;
            }

            // Ajoute ici la logique souhaitée pour les événements de démarrage de session.
            _logger.LogInformation("Session démarrée");
            return Task.CompletedTask;
        }
    }
}
