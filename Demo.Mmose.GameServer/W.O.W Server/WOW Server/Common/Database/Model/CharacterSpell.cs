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
    /// 游戏人物法术信息
    /// </summary>
    public class CharacterSpell : XPObject
    {
        #region zh-CHS 构造和初始化和清理 | en Constructors and Initializers and Dispose
        /// <summary>
        /// 
        /// </summary>
        public CharacterSpell() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        public CharacterSpell( Session session ) : base( session ) { }
        #endregion

        #region zh-CHS 属性 | en Properties

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private CharacterBase m_Owner;
        #endregion
        /// <summary>
        ///  游戏人物法术拥有者的GuidID
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
        private long m_SpellId;
        #endregion
        /// <summary>
        /// 游戏人物法术的编号
        /// </summary>
        public long SpellId
        {
            get { return m_SpellId; }
            set { SetPropertyValue<long>( "SpellId", ref m_SpellId, value ); }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private int m_SpellState;
        #endregion
        /// <summary>
        /// 游戏人物法术的状态
        /// </summary>
        public int SpellState
        {
            get { return m_SpellState; }
            set { SetPropertyValue<int>( "SpellState", ref m_SpellState, value ); }
        }

        #region zh-CHS 私有成员变量 | en Private Member Variables
        /// <summary>
        /// 
        /// </summary>
        private int m_Active;
        #endregion
        /// <summary>
        /// 游戏人物法术的激活状态
        /// </summary>
        public int Active
        {
            get { return m_Active; }
            set { SetPropertyValue<int>( "Active", ref m_Active, value ); }
        }

        #endregion

        #region zh-CHS 方法 | en Method
        /// <summary>
        /// 防止违反索引唯一的规者
        /// </summary>
        public override void AfterConstruction()
        {
            Owner = new CharacterBase();

            SpellId = 0;
            Active = 0;
            SpellState = 0;


            base.AfterConstruction();
        }
        #endregion
    }
}
#endregion