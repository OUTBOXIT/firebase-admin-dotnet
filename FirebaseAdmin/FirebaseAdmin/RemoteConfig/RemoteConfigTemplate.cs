using System;
using System.Collections.Generic;
using System.Text;

namespace FirebaseAdmin.RemoteConfig
{
    /// <summary>
    /// f.
    /// </summary>
    public class RemoteConfigTemplate
    {
        /// <summary>
        /// f.
        /// </summary>
        public IEnumerable<RemoteConfigCondition> Conditions { get; set; }

        public IDictionary<string, RemoteConfigParameter> Parameters { get; set; }

        public IDictionary<string, RemoteConfigParameterGroup> ParameterGroups { get; set; }

        public string ETag { get; }

        public Version Version { get; set; }
    }
}
