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
using DevExpress.Xpo;
#endregion

namespace Demo.Wow.Database.Ver1a
{
    /// <summary>
    /// 游戏人物的荣誉信息
    /// </summary>
    public class CharactersHonor : XPObject
    {
        #region zh-CHS 构造和初始化和清理 | en Constructors and Initializers and Dispose
        /// <summary>
        /// 
        /// </summary>
        public CharactersHonor() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        public CharactersHonor( Session session ) : base( session ) { }
        #endregion

        #region zh-CHS 属性 | en Properties

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private CharacterBase m_Owner;
        #endregion
        /// <summary>
        /// 荣誉信息拥有者的唯一序号
        /// </summary>
        [Indexed]
        public CharacterBase Owner
        {
            get { return m_Owner; }
            set { SetPropertyValue<CharacterBase>( "Owner", ref m_Owner, value ); }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_CreatureTemplate;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long CreatureTemplate
        {
            get { return m_CreatureTemplate; }
            set { SetPropertyValue<long>( "CreatureTemplate", ref m_CreatureTemplate, value ); }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_Honor;
        #endregion
        /// <summary>
        /// 人物的荣誉信息
        /// </summary>
        public long Honor
        {
            get { return m_Honor; }
            set { SetPropertyValue<long>( "Honor", ref m_Honor, value ); }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private long m_Date;
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public long Date
        {
            get { return m_Date; }
            set { SetPropertyValue<long>( "Date", ref m_Date, value ); }
        }

        #endregion

        #region zh-CHS 方法 | en Method
        /// <summary>
        /// 防止违反索引唯一的规者
        /// </summary>
        public override void AfterConstruction()
        {
            Owner = new CharacterBase();
            CreatureTemplate = 0;
            Honor = 0;
            Date = 0;

            base.AfterConstruction();
        }
        #endregion
    }
}
#endregion