using System;
using System.Net;

namespace Mirage.Discovery
{
    [NetworkMessage]
    public struct ServerResponse
    {
        // The server that sent this
        // this is a property so that it is not serialized,  but the
        // client fills this up after we receive it
        public IPEndPoint EndPoint { get; set; }

        public string[] uri;

        // Prevent duplicate server appearance when a connection can be made via LAN on multiple NICs
        public long serverId;
    }
}
