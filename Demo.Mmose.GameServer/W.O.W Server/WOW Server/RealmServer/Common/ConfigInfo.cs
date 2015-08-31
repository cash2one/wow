#region zh-CHS 版权所有 (C) 2006 - 2007 DemoSoft Corporation. 保留所有权利 | en Copyright (C) 2006 - 2007 DemoSoft Corporation. All Rights Reserved.

// COPYRIGHT NOTES
// ---------------
// Program.cs : interface for the Program class.
//
// This file is a part of the Demo Toolkit for .NET.
// 2006-2007 Demo Software, All Rights Reserved.
//
// This source code can only be used under the terms and conditions 
// outlined in the accompanying license agreement.
//
// mailto:caihuanqing@hotmail.com

#region zh-CHS 包含名字空间 | en Include namespace
using System;
using System.Text;
using System.Collections.Generic;
#endregion

namespace Demo.Wow.RealmServer.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class ServerConfig
    {
        #region zh-CHS <ServerSetting>属性 | en <ServerSetting> Properties
        //////////////////////////////////////////////////////////////////////////
        // <ServerSetting>
        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private bool m_bCache = true;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public bool Cache
        {
            get { return m_bCache; }
            set { m_bCache = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private bool m_bDebug = false;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public bool Debug
        {
            get { return m_bDebug; }
            set { m_bDebug = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private bool m_bHaltOnWarning = true;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public bool HaltOnWarning
        {
            get { return m_bHaltOnWarning; }
            set { m_bHaltOnWarning = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private bool m_bProfiling = false;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public bool Profiling
        {
            get { return m_bProfiling; }
            set { m_bProfiling = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private bool m_bService = false;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public bool Service
        {
            get { return m_bService; }
            set { m_bService = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private string m_strLogFile = string.Empty;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public string LogFile
        {
            get { return m_strLogFile; }
            set { m_strLogFile = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private byte m_iWorldThreadCount = 5;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public byte WorldThreadCount
        {
            get { return m_iWorldThreadCount; }
            set { m_iWorldThreadCount = value; }
        }
        #endregion

        #region zh-CHS <NetSetting> Server属性 | en <NetSetting> Properties
        //////////////////////////////////////////////////////////////////////////
        // <NetSetting>
        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_iServerCachedSize = 0;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long ServerCachedSize
        {
            get { return m_iServerCachedSize; }
            set { m_iServerCachedSize = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_iServerBufferSize = 0;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long ServerBufferSize
        {
            get { return m_iServerBufferSize; }
            set { m_iServerBufferSize = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_iServerManageThreadPoolSize = 0;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long ServerManageThreadPoolSize
        {
            get { return m_iServerManageThreadPoolSize; }
            set { m_iServerManageThreadPoolSize = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_iServerSendThreadPoolSize = 0;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long ServerSendThreadPoolSize
        {
            get { return m_iServerSendThreadPoolSize; }
            set { m_iServerSendThreadPoolSize = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_iServerReceiveThreadPoolSize = 0;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long ServerReceiveThreadPoolSize
        {
            get { return m_iServerReceiveThreadPoolSize; }
            set { m_iServerReceiveThreadPoolSize = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_iServerProcessThreadPoolSize = 0;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long ServerProcessThreadPoolSize
        {
            get { return m_iServerProcessThreadPoolSize; }
            set { m_iServerProcessThreadPoolSize = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_iServerMaxClients = 0;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long ServerMaxClients
        {
            get { return m_iServerMaxClients; }
            set { m_iServerMaxClients = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_iServerOutTimeInterval = 0;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long ServerOutTimeInterval
        {
            get { return m_iServerOutTimeInterval; }
            set { m_iServerOutTimeInterval = value; }
        }
        #endregion

        #region zh-CHS <NetSetting> Client属性 | en <NetSetting> Properties
        //////////////////////////////////////////////////////////////////////////
        // <NetSetting>
        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_iClientCachedSize = 0;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long ClientCachedSize
        {
            get { return m_iClientCachedSize; }
            set { m_iClientCachedSize = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_iClientBufferSize = 0;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long ClientBufferSize
        {
            get { return m_iClientBufferSize; }
            set { m_iClientBufferSize = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_iClientManageThreadPoolSize = 0;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long ClientManageThreadPoolSize
        {
            get { return m_iClientManageThreadPoolSize; }
            set { m_iClientManageThreadPoolSize = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_iClientSendThreadPoolSize = 0;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long ClientSendThreadPoolSize
        {
            get { return m_iClientSendThreadPoolSize; }
            set { m_iClientSendThreadPoolSize = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_iClientReceiveThreadPoolSize = 0;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long ClientReceiveThreadPoolSize
        {
            get { return m_iClientReceiveThreadPoolSize; }
            set { m_iClientReceiveThreadPoolSize = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_iClientProcessThreadPoolSize = 0;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long ClientProcessThreadPoolSize
        {
            get { return m_iClientProcessThreadPoolSize; }
            set { m_iClientProcessThreadPoolSize = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_iClientOutTimeInterval = 0;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long ClientOutTimeInterval
        {
            get { return m_iClientOutTimeInterval; }
            set { m_iClientOutTimeInterval = value; }
        }
        #endregion
    }

    /// <summary>
    /// 
    /// </summary>
    public class WowConfig
    {
        #region zh-CHS <ServerSetting>属性 | en <ServerSetting> Properties
        //////////////////////////////////////////////////////////////////////////
        // <ServerSetting>
        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private string m_strRealmServerHost = string.Empty;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public string RealmServerHost
        {
            get { return m_strRealmServerHost; }
            set { m_strRealmServerHost = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_iRealmServerPort = 0;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long RealmServerPort
        {
            get { return m_iRealmServerPort; }
            set { m_iRealmServerPort = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private string m_strAuthServerHost = string.Empty;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public string AuthServerHost
        {
            get { return m_strAuthServerHost; }
            set { m_strAuthServerHost = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_iAuthServerPort = 0;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long AuthServerPort
        {
            get { return m_iAuthServerPort; }
            set { m_iAuthServerPort = value; }
        }
        #endregion

        #region zh-CHS <SQLSetting>属性 | en <SQLSetting> Properties
        //////////////////////////////////////////////////////////////////////////
        // <SQLSetting>
        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private string m_strSQLUser = string.Empty;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public string SQLUser
        {
            get { return m_strSQLUser; }
            set { m_strSQLUser = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private string m_strSQLHost = string.Empty;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public string SQLHost
        {
            get { return m_strSQLHost; }
            set { m_strSQLHost = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_iSQLPort = 0;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long SQLPort
        {
            get { return m_iSQLPort; }
            set { m_iSQLPort = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private string m_strSQLDatabase = string.Empty;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public string SQLDatabase
        {
            get { return m_strSQLDatabase; }
            set { m_strSQLDatabase = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private string m_strSQLConnection = string.Empty;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public string SQLConnection
        {
            get { return m_strSQLConnection; }
            set { m_strSQLConnection = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private string m_strSQLPassword = string.Empty;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public string SQLPassword
        {
            get { return m_strSQLPassword; }
            set { m_strSQLPassword = value; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private string m_strSQLConnectionUrl = string.Empty;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public string SQLConnectionUrl
        {
            get { return m_strSQLConnectionUrl; }
            set { m_strSQLConnectionUrl = value; }
        }
        #endregion
    }

    public class WorldConfig
    {
        #region zh-CHS <Settings>属性 | en <Settings> Properties
        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private string m_strZoneClusterName = string.Empty;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public string ZoneClusterName
        {
            get { return m_strZoneClusterName; }
            set { m_strZoneClusterName = value; }
        }
        #endregion
    }

    /// <summary>
    /// 
    /// </summary>
    public class ConfigInfo
    {
        #region zh-CHS 内部属性 | en Internal Properties

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private ServerConfig m_ServerConfig = new ServerConfig();
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public ServerConfig ServerConfig
        {
            get { return m_ServerConfig; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private WowConfig m_WowConfig = new WowConfig();
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public WowConfig WowConfig
        {
            get { return m_WowConfig; }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private WorldConfig m_WorldConfig = new WorldConfig();
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public WorldConfig WorldConfig
        {
            get { return m_WorldConfig; }
        }

        #endregion
    }
}
#endregion