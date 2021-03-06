#region zh-CHS 版权所有 (C) 2006 - 2006 DemoSoft Corporation. 保留所有权利 | en Copyright (C) 2006 - 2006 DemoSoft Corporation. All Rights Reserved.

// COPYRIGHT NOTES
// ---------------
// Program.cs : interface for the Program class.
//
// This file is a part of the Demo Toolkit for .NET.
// 2006-2006 Demo Software, All Rights Reserved.
//
// This source code can only be used under the terms and conditions 
// outlined in the accompanying license agreement.
//
// mailto:caihuanqing@hotmail.com

#region zh-CHS 包含名字空间 | en Include namespace
using System;
using System.Text;
using System.Collections.Generic;
using Demo.Mmose.Core.Entity.Item;
using Demo.Mmose.Core.Entity.Suit.Treasure;
using Demo.Mmose.Core.Entity.GameObject;
using Demo.Wow.WorldServer.Entity.Fields;
using Demo.Wow.WorldServer.Entity.Common;
#endregion

namespace Demo.Wow.WorldServer.Object
{
    /// <summary>
    /// 
    /// </summary>
    public partial class WowGameObject : BaseGameObject
    {
        #region zh-CHS 构造和初始化和清理 | en Constructors and Initializers and Dispose
        /// <summary>
        /// 
        /// </summary>
        protected override void DefaultGameObjectInit()
        {
            base.DefaultGameObjectInit();

            // IWowUpdate
            this.RegisterComponent<IWowUpdate>( WowUpdate.WOW_UPDATE_COMPONENT_ID, this );

            // CorpseField
            this.GameObjectField.EventRequestUpdate += new RequestUpdateEventHandler( this.OnFieldRequestUpdate );
        }
        #endregion

        #region zh-CHS 杂项 | en
        ///// <summary>
        ///// 
        ///// </summary>
        //uint m_ObjectScriptGUID = 0;
        ///// <summary>
        ///// 
        ///// </summary>
        //public uint 物体触发脚本编号
        //{
        //    get { return m_ObjectScriptGUID; }
        //    set { m_ObjectScriptGUID = value; }
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //uint m_ObjectCastsSpell = 0;
        ///// <summary>
        ///// 
        ///// </summary>
        //public uint 物体陷井魔法猎人编号
        //{
        //    get { return m_ObjectCastsSpell; }
        //    set { m_ObjectCastsSpell = value; }
        //}
        #endregion
    }
}
#endregion
