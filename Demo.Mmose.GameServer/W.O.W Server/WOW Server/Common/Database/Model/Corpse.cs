﻿#region zh-CHS 版权所有 (C) 2006 - 2006 DemoSoft Corporation. 保留所有权利 | en Copyright (C) 2006 - 2006 DemoSoft Corporation. All Rights Reserved.

// COPYRIGHT NOTES
// ---------------
//
// This file is a part of the G.O.S.E(Game Online Server Engine) for .NET.
//
//           2007-2008 Demo Software, All Rights Reserved.
//
// This source code can only be used under the terms and conditions outlined
// in the accompanying license agreement.
//
//
// First Version : by H.Q.Cai - mailto:caihuanqing@hotmail.com

#region zh-CHS 包含名字空间 | en Include namespace
using System;
using DevExpress.Xpo;
#endregion

namespace Demo.Wow.Database.Ver1a
{
    /// <summary>
    /// 尸体信息
    /// </summary>
    public class Corpse : XPObject
    {
        #region zh-CHS 构造和初始化和清理 | en Constructors and Initializers and Dispose
        /// <summary>
        /// 
        /// </summary>
        public Corpse() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        public Corpse( Session session ) : base( session ) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        public Corpse( Session session, CharacterBase owner )
            : base( session )
        {
            Owner = owner;
        }
        #endregion

        #region zh-CHS 属性 | en Properties

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private CharacterBase m_Owner;
        #endregion
        /// <summary>
        /// 尸体拥有的唯一序号ID
        /// </summary>
        [Indexed( Unique = true )]
        public CharacterBase Owner
        {
            get { return m_Owner; }
            set { SetPropertyValue<CharacterBase>( "Owner", ref m_Owner, value ); }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_MapId;
        #endregion
        /// <summary>
        /// 尸体的地图
        /// </summary>
        [Indexed]
        public long MapId
        {
            get { return m_MapId; }
            set { SetPropertyValue<long>( "MapId", ref m_MapId, value ); }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_ZoneId;
        #endregion
        /// <summary>
        /// 尸体的地域
        /// </summary>
        [Indexed]
        public long ZoneId
        {
            get { return m_ZoneId; }
            set { SetPropertyValue<long>( "ZoneId", ref m_ZoneId, value ); }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private float m_PositionX;
        #endregion
        /// <summary>
        /// 尸体 所在的 X坐标
        /// </summary>
        public float PositionX
        {
            get { return m_PositionX; }
            set { SetPropertyValue<float>( "PositionX", ref m_PositionX, value ); }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private float m_PositionY;
        #endregion
        /// <summary>
        /// 尸体 所在的 Y坐标
        /// </summary>
        public float PositionY
        {
            get { return m_PositionY; }
            set { SetPropertyValue<float>( "PositionY", ref m_PositionY, value ); }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private float m_PositionZ;
        #endregion
        /// <summary>
        /// 尸体 所在的 Z坐标
        /// </summary>
        public float PositionZ
        {
            get { return m_PositionZ; }
            set { SetPropertyValue<float>( "PositionZ", ref m_PositionZ, value ); }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private float m_Orientation;
        #endregion
        /// <summary>
        /// 尸体 所在的 方向
        /// North(北方) is 0*Pi => 0.00000
        /// East(东方) is Pi/2 => 1.57079
        /// South(南方) is Pi => 3.14159
        /// West(西方) is 3*Pi/2 => 4.71238
        /// </summary>
        public float Orientation
        {
            get { return m_Orientation; }
            set { SetPropertyValue<float>( "Orientation", ref m_Orientation, value ); }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private DateTime m_DieTime;
        #endregion
        /// <summary>
        /// 人物的死亡时间
        /// </summary>
        [NullValue( null )]
        public DateTime DieTime
        {
            get { return m_DieTime; }
            set { SetPropertyValue<DateTime>( "DieTime", ref m_DieTime, value ); }
        }

        #endregion

        #region zh-CHS 方法 | en Method
        /// <summary>
        /// 防止违反索引唯一的规者
        /// </summary>
        public override void AfterConstruction()
        {
            Owner = null;
            MapId = 0;
            ZoneId = 0;
            PositionX = 0;
            PositionY = 0;
            PositionZ = 0;
            Orientation = 0;
            DieTime = DateTime.MinValue;

            base.AfterConstruction();
        }
        #endregion
    }
}
#endregion