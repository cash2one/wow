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
using System;
using System.Threading;
#endregion

namespace Demo.Mmose.Core.Util
{
    /// <summary>
    /// 
    /// </summary>
    public static class ReaderWriterLockSlimEx
    {
        #region zh-CHS 共有静态属性 | en Public Static Properties
        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private static TimeSpan s_TimeSpan = TimeSpan.FromMilliseconds( 3 );
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public static TimeSpan Timeout
        {
            get { return s_TimeSpan; }
            set { s_TimeSpan = value; }
        }
        #endregion

        #region zh-CHS 共有静态方法 | en Public Static Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="readerWriterLockSlim"></param>
        /// <returns></returns>
        public static bool QuickTryEnterReadLock( ReaderWriterLockSlim readerWriterLockSlim )
        {
            return readerWriterLockSlim.TryEnterReadLock( s_TimeSpan );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="readerWriterLockSlim"></param>
        /// <returns></returns>
        public static bool QuickTryEnterWriteLock( ReaderWriterLockSlim readerWriterLockSlim )
        {
            return readerWriterLockSlim.TryEnterWriteLock( s_TimeSpan );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="readerWriterLockSlim"></param>
        /// <returns></returns>
        public static bool QuickTryEnterUpgradeableReadLock( ReaderWriterLockSlim readerWriterLockSlim )
        {
            return readerWriterLockSlim.TryEnterUpgradeableReadLock( s_TimeSpan );
        }
        #endregion
    }
}
#endregion