﻿namespace GnarlyGameStudio.Serializer
{
    public interface IBridgeSerializer
    {
        void Read(BridgeStream stream);
        void Write(BridgeStream stream);
    }
}