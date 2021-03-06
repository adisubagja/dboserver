﻿using BaseLib.Packets;
using BaseLib.Structs;

namespace CharServer.Packets
{
    class CU_CONNECT_WAIT_CANCEL_RES : Packet
    {
        public CU_CONNECT_WAIT_CANCEL_RES()
        {
            Opcode = (ushort)PacketOpcodes.CU_CONNECT_WAIT_CANCEL_RES;
            ResultCode = (ushort)ResultCodes.CHARACTER_SUCCESS;
        }

        public ushort ResultCode
        {
            get { return GetShort(4); }
            set { SetShort(4, value); }
        }
    }
}
