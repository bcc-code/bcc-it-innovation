using System;
using System.Collections.Generic;
using System.Text;

namespace Bcc.Auth.Stores.RavenDb
{

    public class RavenConfig
    {
        // "http://your_RavenDB_cluster_node,..."
        public string Urls { get; set; }
        public string DatabaseName { get; set; }
    }
}
