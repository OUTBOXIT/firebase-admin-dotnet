using System;
using System.Threading;
using System.Threading.Tasks;
using FirebaseAdmin.Messaging;

namespace FirebaseAdmin.RemoteConfig
{
    /// <summary>
    /// This is the entry point to all server-side Firebase Remote Configuration operations. You
    /// can get an instance of this class via <c>FirebaseRemoteConfig.DefaultInstance</c>.
    /// </summary>
    public class FirebaseRemoteConfig : IFirebaseService
    {
        private FirebaseRemoteConfig(FirebaseApp app)
        {
        }

        /// <summary>
        /// Gets the messaging instance associated with the default Firebase app. This property is
        /// <c>null</c> if the default app doesn't yet exist.
        /// </summary>
        public static FirebaseRemoteConfig DefaultInstance
        {
            get
            {
                var app = FirebaseApp.DefaultInstance;
                if (app == null)
                {
                    return null;
                }

                return GetRemoteConfig(app);
            }
        }

        /// <summary>
        /// Returns the messaging instance for the specified app.
        /// </summary>
        /// <returns>The <see cref="FirebaseRemoteConfig"/> instance associated with the specified
        /// app.</returns>
        /// <exception cref="System.ArgumentNullException">If the app argument is null.</exception>
        /// <param name="app">An app instance.</param>
        public static FirebaseRemoteConfig GetRemoteConfig(FirebaseApp app)
        {
            if (app == null)
            {
                throw new ArgumentNullException("App argument must not be null.");
            }

            return app.GetOrInit(nameof(FirebaseRemoteConfig), () => new FirebaseRemoteConfig(app));
        }

        /// <summary>
        /// Sends a message to the FCM service for delivery. The message gets validated both by
        /// the Admin SDK, and the remote FCM service. A successful return value indicates
        /// that the message has been successfully sent to FCM, where it has been accepted by the
        /// FCM service.
        /// <para>If the <paramref name="dryRun"/> option is set to true, the message will not be
        /// actually sent to the recipients. Instead, the FCM service performs all the necessary
        /// validations, and emulates the send operation. This is a good way to check if a
        /// certain message will be accepted by FCM for delivery.</para>
        /// </summary>
        /// <returns>A task that completes with a message ID string, which represents
        /// successful handoff to FCM.</returns>
        /// <exception cref="ArgumentNullException">If the message argument is null.</exception>
        /// <exception cref="ArgumentException">If the message contains any invalid
        /// fields.</exception>
        /// <exception cref="FirebaseMessagingException">If an error occurs while sending the
        /// message.</exception>
        /// <param name="message">The message to be sent. Must not be null.</param>
        /// <param name="dryRun">A boolean indicating whether to perform a dry run (validation
        /// only) of the send. If set to true, the message will be sent to the FCM backend service,
        /// but it will not be delivered to any actual recipients.</param>
        /// <param name="cancellationToken">A cancellation token to monitor the asynchronous
        /// operation.</param>
        public async Task<string> GetTemplateAsync(Message message, bool dryRun, CancellationToken cancellationToken)
        {
            return await this.messagingClient.SendAsync(
                message, dryRun, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Sends a message to the FCM service for delivery. The message gets validated both by
        /// the Admin SDK, and the remote FCM service. A successful return value indicates
        /// that the message has been successfully sent to FCM, where it has been accepted by the
        /// FCM service.
        /// <para>If the <paramref name="dryRun"/> option is set to true, the message will not be
        /// actually sent to the recipients. Instead, the FCM service performs all the necessary
        /// validations, and emulates the send operation. This is a good way to check if a
        /// certain message will be accepted by FCM for delivery.</para>
        /// </summary>
        /// <returns>A task that completes with a message ID string, which represents
        /// successful handoff to FCM.</returns>
        /// <exception cref="ArgumentNullException">If the message argument is null.</exception>
        /// <exception cref="ArgumentException">If the message contains any invalid
        /// fields.</exception>
        /// <exception cref="FirebaseMessagingException">If an error occurs while sending the
        /// message.</exception>
        /// <param name="message">The message to be sent. Must not be null.</param>
        /// <param name="dryRun">A boolean indicating whether to perform a dry run (validation
        /// only) of the send. If set to true, the message will be sent to the FCM backend service,
        /// but it will not be delivered to any actual recipients.</param>
        /// <param name="cancellationToken">A cancellation token to monitor the asynchronous
        /// operation.</param>
        public async Task<string> GetTemplateAtVersionAsync(Message message, bool dryRun, CancellationToken cancellationToken)
        {
            return await this.messagingClient.SendAsync(
                message, dryRun, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Sends a message to the FCM service for delivery. The message gets validated both by
        /// the Admin SDK, and the remote FCM service. A successful return value indicates
        /// that the message has been successfully sent to FCM, where it has been accepted by the
        /// FCM service.
        /// <para>If the <paramref name="dryRun"/> option is set to true, the message will not be
        /// actually sent to the recipients. Instead, the FCM service performs all the necessary
        /// validations, and emulates the send operation. This is a good way to check if a
        /// certain message will be accepted by FCM for delivery.</para>
        /// </summary>
        /// <returns>A task that completes with a message ID string, which represents
        /// successful handoff to FCM.</returns>
        /// <exception cref="ArgumentNullException">If the message argument is null.</exception>
        /// <exception cref="ArgumentException">If the message contains any invalid
        /// fields.</exception>
        /// <exception cref="FirebaseMessagingException">If an error occurs while sending the
        /// message.</exception>
        /// <param name="message">The message to be sent. Must not be null.</param>
        /// <param name="dryRun">A boolean indicating whether to perform a dry run (validation
        /// only) of the send. If set to true, the message will be sent to the FCM backend service,
        /// but it will not be delivered to any actual recipients.</param>
        /// <param name="cancellationToken">A cancellation token to monitor the asynchronous
        /// operation.</param>
        public async Task<string> ValidateTemplateAsync(Message message, bool dryRun, CancellationToken cancellationToken)
        {
            return await this.messagingClient.SendAsync(
                message, dryRun, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Sends a message to the FCM service for delivery. The message gets validated both by
        /// the Admin SDK, and the remote FCM service. A successful return value indicates
        /// that the message has been successfully sent to FCM, where it has been accepted by the
        /// FCM service.
        /// <para>If the <paramref name="dryRun"/> option is set to true, the message will not be
        /// actually sent to the recipients. Instead, the FCM service performs all the necessary
        /// validations, and emulates the send operation. This is a good way to check if a
        /// certain message will be accepted by FCM for delivery.</para>
        /// </summary>
        /// <returns>A task that completes with a message ID string, which represents
        /// successful handoff to FCM.</returns>
        /// <exception cref="ArgumentNullException">If the message argument is null.</exception>
        /// <exception cref="ArgumentException">If the message contains any invalid
        /// fields.</exception>
        /// <exception cref="FirebaseMessagingException">If an error occurs while sending the
        /// message.</exception>
        /// <param name="message">The message to be sent. Must not be null.</param>
        /// <param name="dryRun">A boolean indicating whether to perform a dry run (validation
        /// only) of the send. If set to true, the message will be sent to the FCM backend service,
        /// but it will not be delivered to any actual recipients.</param>
        /// <param name="cancellationToken">A cancellation token to monitor the asynchronous
        /// operation.</param>
        public async Task<string> PublishTemplateAsync(Message message, bool dryRun, CancellationToken cancellationToken)
        {
            return await this.messagingClient.SendAsync(
                message, dryRun, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Sends a message to the FCM service for delivery. The message gets validated both by
        /// the Admin SDK, and the remote FCM service. A successful return value indicates
        /// that the message has been successfully sent to FCM, where it has been accepted by the
        /// FCM service.
        /// <para>If the <paramref name="dryRun"/> option is set to true, the message will not be
        /// actually sent to the recipients. Instead, the FCM service performs all the necessary
        /// validations, and emulates the send operation. This is a good way to check if a
        /// certain message will be accepted by FCM for delivery.</para>
        /// </summary>
        /// <returns>A task that completes with a message ID string, which represents
        /// successful handoff to FCM.</returns>
        /// <exception cref="ArgumentNullException">If the message argument is null.</exception>
        /// <exception cref="ArgumentException">If the message contains any invalid
        /// fields.</exception>
        /// <exception cref="FirebaseMessagingException">If an error occurs while sending the
        /// message.</exception>
        /// <param name="message">The message to be sent. Must not be null.</param>
        /// <param name="dryRun">A boolean indicating whether to perform a dry run (validation
        /// only) of the send. If set to true, the message will be sent to the FCM backend service,
        /// but it will not be delivered to any actual recipients.</param>
        /// <param name="cancellationToken">A cancellation token to monitor the asynchronous
        /// operation.</param>
        public async Task<string> Rollback(Message message, bool dryRun, CancellationToken cancellationToken)
        {
            return await this.messagingClient.SendAsync(
                message, dryRun, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Sends a message to the FCM service for delivery. The message gets validated both by
        /// the Admin SDK, and the remote FCM service. A successful return value indicates
        /// that the message has been successfully sent to FCM, where it has been accepted by the
        /// FCM service.
        /// <para>If the <paramref name="dryRun"/> option is set to true, the message will not be
        /// actually sent to the recipients. Instead, the FCM service performs all the necessary
        /// validations, and emulates the send operation. This is a good way to check if a
        /// certain message will be accepted by FCM for delivery.</para>
        /// </summary>
        /// <returns>A task that completes with a message ID string, which represents
        /// successful handoff to FCM.</returns>
        /// <exception cref="ArgumentNullException">If the message argument is null.</exception>
        /// <exception cref="ArgumentException">If the message contains any invalid
        /// fields.</exception>
        /// <exception cref="FirebaseMessagingException">If an error occurs while sending the
        /// message.</exception>
        /// <param name="message">The message to be sent. Must not be null.</param>
        /// <param name="dryRun">A boolean indicating whether to perform a dry run (validation
        /// only) of the send. If set to true, the message will be sent to the FCM backend service,
        /// but it will not be delivered to any actual recipients.</param>
        /// <param name="cancellationToken">A cancellation token to monitor the asynchronous
        /// operation.</param>
        public async Task<string> ListVersions(Message message, bool dryRun, CancellationToken cancellationToken)
        {
            return await this.messagingClient.SendAsync(
                message, dryRun, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Sends a message to the FCM service for delivery. The message gets validated both by
        /// the Admin SDK, and the remote FCM service. A successful return value indicates
        /// that the message has been successfully sent to FCM, where it has been accepted by the
        /// FCM service.
        /// <para>If the <paramref name="dryRun"/> option is set to true, the message will not be
        /// actually sent to the recipients. Instead, the FCM service performs all the necessary
        /// validations, and emulates the send operation. This is a good way to check if a
        /// certain message will be accepted by FCM for delivery.</para>
        /// </summary>
        /// <returns>A task that completes with a message ID string, which represents
        /// successful handoff to FCM.</returns>
        /// <exception cref="ArgumentNullException">If the message argument is null.</exception>
        /// <exception cref="ArgumentException">If the message contains any invalid
        /// fields.</exception>
        /// <exception cref="FirebaseMessagingException">If an error occurs while sending the
        /// message.</exception>
        /// <param name="message">The message to be sent. Must not be null.</param>
        /// <param name="dryRun">A boolean indicating whether to perform a dry run (validation
        /// only) of the send. If set to true, the message will be sent to the FCM backend service,
        /// but it will not be delivered to any actual recipients.</param>
        /// <param name="cancellationToken">A cancellation token to monitor the asynchronous
        /// operation.</param>
        public async Task<string> CreateTemplateFromJsonAsync(string json, bool dryRun, CancellationToken cancellationToken)
        {
            return await this.messagingClient.SendAsync(
                message, dryRun, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes this <see cref="FirebaseRemoteConfig"/> service instance.
        /// </summary>
        void IFirebaseService.Delete()
        {
        }
    }
}
