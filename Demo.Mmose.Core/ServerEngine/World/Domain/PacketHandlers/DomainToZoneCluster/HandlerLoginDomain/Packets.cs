﻿#region zh-CHS 2006 - 2008 DemoSoft 团队 | en 2006 - 2008 DemoSoft Team

//     NOTES
// ---------------
//
// This file is a part of the MMOSE(Massively Multiplayer Online Server Engine) for .NET.
//
//                              2006-2008 DemoSoft Team
//
//
// First Version : by H.Q.Cai - mailto:caihuanqing@hotmail.com

/***************************************************************************
 *
 *   This program is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU Lesser General Public License as published
 *   by the Free Software Foundation; either version 2.1 of the License, or
 *   (at your option) any later version.
 *
 ***************************************************************************/

#region zh-CHS 包含名字空间 | en Include namespace
using Demo.Mmose.Core.Network;
#endregion

namespace Demo.Mmose.Core.World.DomainWorld
{
    #region zh-CHS Domain_LoginDomain 类 | en Domain_LoginDomain Class
    /// <summary>
    /// 
    /// </summary>
    internal sealed class Domain_LoginDomainResult : Packet
    {
        /// <summary>
        /// 
        /// </summary>
        public Domain_LoginDomainResult()
            : base( (long)DomainOpCodeFromZoneCluster.CMSG_LOGIN_DOMAIN_RESULT, 0/*6 + ?*/ )
        {
            WriterStream.Write( (ushort)7 /*6 + 1*/ );      // 字段大小
            WriterStream.Write( (ushort)base.PacketID );    // 字段编号
            WriterStream.Write( (ushort)0x00 );             // 字段保留

            WriterStream.Write( (byte)0x00 );
        }
    }
    #endregion
}
#endregion