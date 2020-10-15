﻿using PacketDotNet;
using System;

namespace VpnHood
{
    public interface IDatagramChannel : IChannel
    {
        event EventHandler<ChannelPacketArrivalEventArgs> OnPacketArrival;
        void SendPacket(IPPacket[] packets);
        int SendBufferSize { get; }
    }
}
