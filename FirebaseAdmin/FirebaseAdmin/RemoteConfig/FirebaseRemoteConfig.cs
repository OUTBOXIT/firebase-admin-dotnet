using System;

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
        /// Deletes this <see cref="FirebaseRemoteConfig"/> service instance.
        /// </summary>
        void IFirebaseService.Delete()
        {
        }
    }
}
