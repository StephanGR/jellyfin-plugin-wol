using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Jellyfin.Data.Entities;
using Jellyfin.Data.Entities.Security;
using Jellyfin.Data.Events;
using MediaBrowser.Controller.Authentication;
using MediaBrowser.Controller.Library;
using MediaBrowser.Controller.Session;
using MediaBrowser.Model.Session;
using MediaBrowser.Model.SyncPlay;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Plugin.WakeOnLan;

public class SessionManager : ISessionManager
{
    private readonly ILogger<Plugin> _logger;

    public SessionManager(ILogger<Plugin> logger)
    {
        _logger = logger;
    }

    public IEnumerable<SessionInfo> Sessions { get; } = new List<SessionInfo>();

    public event EventHandler<PlaybackProgressEventArgs> PlaybackStart
    {
        add { }
        remove { }
    }

    public event EventHandler<PlaybackProgressEventArgs> PlaybackProgress
    {
        add { }
        remove { }
    }

    public event EventHandler<PlaybackStopEventArgs> PlaybackStopped
    {
        add { }
        remove { }
    }

    public event EventHandler<SessionEventArgs> SessionStarted
    {
        add { }
        remove { }
    }

    public event EventHandler<SessionEventArgs> SessionEnded
    {
        add { }
        remove { }
    }

    public event EventHandler<SessionEventArgs> SessionActivity
    {
        add { }
        remove { }
    }

    public event EventHandler<SessionEventArgs> SessionControllerConnected
    {
        add { }
        remove { }
    }

    public event EventHandler<SessionEventArgs> CapabilitiesChanged
    {
        add { }
        remove { }
    }

    public event EventHandler<GenericEventArgs<AuthenticationRequest>> AuthenticationFailed
    {
        add { }
        remove { }
    }

    public event EventHandler<GenericEventArgs<AuthenticationResult>> AuthenticationSucceeded
    {
        add { }
        remove { }
    }

    public Task<SessionInfo> LogSessionActivity(string appName, string appVersion, string deviceId, string deviceName, string remoteEndPoint, User user)
    {
        throw new NotImplementedException();
    }

    public void OnSessionControllerConnected(SessionInfo session)
    {
        throw new NotImplementedException();
    }

    public void UpdateDeviceName(string sessionId, string reportedDeviceName)
    {
        throw new NotImplementedException();
    }

    public Task OnPlaybackStart(PlaybackStartInfo info)
    {
        _logger.LogInformation("OnPlaybackStart appelée");

        // Implémenter la logique réelle ici

        return Task.CompletedTask;
    }

    public Task OnPlaybackProgress(PlaybackProgressInfo info)
    {
        throw new NotImplementedException();
    }

    public Task OnPlaybackProgress(PlaybackProgressInfo info, bool isAutomated)
    {
        throw new NotImplementedException();
    }

    public Task OnPlaybackStopped(PlaybackStopInfo info)
    {
        throw new NotImplementedException();
    }

    public void ReportSessionEnded(string sessionId)
    {
        throw new NotImplementedException();
    }

    public Task SendGeneralCommand(string controllingSessionId, string sessionId, GeneralCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SendMessageCommand(string controllingSessionId, string sessionId, MessageCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SendPlayCommand(string controllingSessionId, string sessionId, PlayRequest command, CancellationToken cancellationToken)
    {
        _logger.LogInformation("SendPlayCommand appelée");

        // Implémenter la logique réelle ici

        return Task.CompletedTask;
    }

    public Task SendSyncPlayCommand(string sessionId, SendCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SendSyncPlayGroupUpdate<T>(string sessionId, GroupUpdate<T> command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SendBrowseCommand(string controllingSessionId, string sessionId, BrowseRequest command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SendPlaystateCommand(string controllingSessionId, string sessionId, PlaystateRequest command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SendMessageToAdminSessions<T>(SessionMessageType name, T data, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SendMessageToUserSessions<T>(List<Guid> userIds, SessionMessageType name, T data, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SendMessageToUserSessions<T>(List<Guid> userIds, SessionMessageType name, Func<T> dataFn, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SendMessageToUserDeviceSessions<T>(string deviceId, SessionMessageType name, T data, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SendRestartRequiredNotification(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SendServerShutdownNotification(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SendServerRestartNotification(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public void AddAdditionalUser(string sessionId, Guid userId)
    {
        throw new NotImplementedException();
    }

    public void RemoveAdditionalUser(string sessionId, Guid userId)
    {
        throw new NotImplementedException();
    }

    public void ReportNowViewingItem(string sessionId, string itemId)
    {
        throw new NotImplementedException();
    }

    public Task<AuthenticationResult> AuthenticateNewSession(AuthenticationRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<AuthenticationResult> AuthenticateDirect(AuthenticationRequest request)
    {
        throw new NotImplementedException();
    }

    public void ReportCapabilities(string sessionId, ClientCapabilities capabilities)
    {
        throw new NotImplementedException();
    }

    public void ReportTranscodingInfo(string deviceId, TranscodingInfo info)
    {
        throw new NotImplementedException();
    }

    public void ClearTranscodingInfo(string deviceId)
    {
        throw new NotImplementedException();
    }

    public SessionInfo GetSession(string deviceId, string client, string version)
    {
        throw new NotImplementedException();
    }

    public Task<SessionInfo> GetSessionByAuthenticationToken(string token, string deviceId, string remoteEndpoint)
    {
        throw new NotImplementedException();
    }

    public Task<SessionInfo> GetSessionByAuthenticationToken(Device info, string deviceId, string remoteEndpoint, string appVersion)
    {
        throw new NotImplementedException();
    }

    public Task Logout(string accessToken)
    {
        throw new NotImplementedException();
    }

    public Task Logout(Device device)
    {
        throw new NotImplementedException();
    }

    public Task RevokeUserTokens(Guid userId, string currentAccessToken)
    {
        throw new NotImplementedException();
    }

    public Task CloseIfNeededAsync(SessionInfo session)
    {
        throw new NotImplementedException();
    }
}
