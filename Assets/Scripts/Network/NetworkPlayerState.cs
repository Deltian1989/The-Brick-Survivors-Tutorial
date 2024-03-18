﻿using PRN;
using Unity.Netcode;
using UnityEngine;

namespace TBS.Network
{
    public struct NetworkPlayerState : IState, INetworkSerializable
    {
        public int tick;
        public Vector3 position;
        public Vector3 movement;
        public Vector3 gravity;

        public void SetTick(int tick) => this.tick = tick;
        public int GetTick() => tick;

        public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
        {
            serializer.SerializeValue(ref tick);
            serializer.SerializeValue(ref position);
            serializer.SerializeValue(ref movement);
            serializer.SerializeValue(ref gravity);
        }
    }
}
