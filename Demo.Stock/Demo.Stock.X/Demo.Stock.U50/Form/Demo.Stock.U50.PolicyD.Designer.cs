﻿namespace Demo.Stock.X.U50
{
    partial class PolicyDControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( PolicyDControl ) );
            this.axShortcutCaption3 = new AxXtremeShortcutBar.AxShortcutCaption();
            this.Panel = new System.Windows.Forms.Panel();
            this.ButtonPDU = new System.Windows.Forms.Button();
            this.ButtonPCD = new System.Windows.Forms.Button();
            this.ButtonTDU = new System.Windows.Forms.Button();
            this.ButtonTCD = new System.Windows.Forms.Button();
            this.ButtonTCU = new System.Windows.Forms.Button();
            this.ButtonO = new System.Windows.Forms.Button();
            this.ButtonVacUC = new System.Windows.Forms.Button();
            ( (System.ComponentModel.ISupportInitialize)( this.axShortcutCaption3 ) ).BeginInit();
            this.SuspendLayout();
            // 
            // axShortcutCaption3
            // 
            this.axShortcutCaption3.Dock = System.Windows.Forms.DockStyle.Top;
            this.axShortcutCaption3.Enabled = true;
            this.axShortcutCaption3.Location = new System.Drawing.Point( 0, 0 );
            this.axShortcutCaption3.Name = "axShortcutCaption3";
            this.axShortcutCaption3.OcxState = ( (System.Windows.Forms.AxHost.State)( resources.GetObject( "axShortcutCaption3.OcxState" ) ) );
            this.axShortcutCaption3.Size = new System.Drawing.Size( 330, 29 );
            this.axShortcutCaption3.TabIndex = 0;
            // 
            // Panel
            // 
            this.Panel.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.Panel.Location = new System.Drawing.Point( 0, 35 );
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size( 330, 345 );
            this.Panel.TabIndex = 1;
            // 
            // ButtonPDU
            // 
            this.ButtonPDU.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.ButtonPDU.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonPDU.Location = new System.Drawing.Point( 41, 386 );
            this.ButtonPDU.Name = "ButtonPDU";
            this.ButtonPDU.Size = new System.Drawing.Size( 31, 23 );
            this.ButtonPDU.TabIndex = 3;
            this.ButtonPDU.Text = "PDU";
            this.ButtonPDU.UseVisualStyleBackColor = true;
            this.ButtonPDU.Click += new System.EventHandler( this.ButtonPDU_Click );
            // 
            // ButtonPCD
            // 
            this.ButtonPCD.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.ButtonPCD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonPCD.Location = new System.Drawing.Point( 79, 386 );
            this.ButtonPCD.Name = "ButtonPCD";
            this.ButtonPCD.Size = new System.Drawing.Size( 31, 23 );
            this.ButtonPCD.TabIndex = 4;
            this.ButtonPCD.Text = "PCD";
            this.ButtonPCD.UseVisualStyleBackColor = true;
            this.ButtonPCD.Click += new System.EventHandler( this.ButtonPCD_Click );
            // 
            // ButtonTDU
            // 
            this.ButtonTDU.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.ButtonTDU.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonTDU.Location = new System.Drawing.Point( 117, 386 );
            this.ButtonTDU.Name = "ButtonTDU";
            this.ButtonTDU.Size = new System.Drawing.Size( 31, 23 );
            this.ButtonTDU.TabIndex = 5;
            this.ButtonTDU.Text = "TDU";
            this.ButtonTDU.UseVisualStyleBackColor = true;
            this.ButtonTDU.Click += new System.EventHandler( this.ButtonTDU_Click );
            // 
            // ButtonTCD
            // 
            this.ButtonTCD.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.ButtonTCD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonTCD.Location = new System.Drawing.Point( 155, 386 );
            this.ButtonTCD.Name = "ButtonTCD";
            this.ButtonTCD.Size = new System.Drawing.Size( 31, 23 );
            this.ButtonTCD.TabIndex = 6;
            this.ButtonTCD.Text = "TCD";
            this.ButtonTCD.UseVisualStyleBackColor = true;
            this.ButtonTCD.Click += new System.EventHandler( this.ButtonTCD_Click );
            // 
            // ButtonTCU
            // 
            this.ButtonTCU.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.ButtonTCU.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonTCU.Location = new System.Drawing.Point( 193, 386 );
            this.ButtonTCU.Name = "ButtonTCU";
            this.ButtonTCU.Size = new System.Drawing.Size( 31, 23 );
            this.ButtonTCU.TabIndex = 7;
            this.ButtonTCU.Text = "TBU";
            this.ButtonTCU.UseVisualStyleBackColor = true;
            this.ButtonTCU.Click += new System.EventHandler( this.ButtonTCU_Click );
            // 
            // ButtonO
            // 
            this.ButtonO.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.ButtonO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonO.Location = new System.Drawing.Point( 3, 386 );
            this.ButtonO.Name = "ButtonO";
            this.ButtonO.Size = new System.Drawing.Size( 31, 23 );
            this.ButtonO.TabIndex = 2;
            this.ButtonO.Text = "O";
            this.ButtonO.UseVisualStyleBackColor = true;
            this.ButtonO.Click += new System.EventHandler( this.ButtonO_Click );
            // 
            // ButtonVacUC
            // 
            this.ButtonVacUC.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.ButtonVacUC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonVacUC.Location = new System.Drawing.Point( 231, 386 );
            this.ButtonVacUC.Name = "ButtonVacUC";
            this.ButtonVacUC.Size = new System.Drawing.Size( 49, 23 );
            this.ButtonVacUC.TabIndex = 8;
            this.ButtonVacUC.Text = "Vac-UC";
            this.ButtonVacUC.UseVisualStyleBackColor = true;
            this.ButtonVacUC.Click += new System.EventHandler( this.ButtonVacUC_Click );
            // 
            // ConfigDControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.Panel );
            this.Controls.Add( this.axShortcutCaption3 );
            this.Controls.Add( this.ButtonVacUC );
            this.Controls.Add( this.ButtonTCU );
            this.Controls.Add( this.ButtonTCD );
            this.Controls.Add( this.ButtonTDU );
            this.Controls.Add( this.ButtonPCD );
            this.Controls.Add( this.ButtonO );
            this.Controls.Add( this.ButtonPDU );
            this.Name = "ConfigDControl";
            this.Size = new System.Drawing.Size( 330, 412 );
            this.Load += new System.EventHandler( this.ConfigBControl_Load );
            ( (System.ComponentModel.ISupportInitialize)( this.axShortcutCaption3 ) ).EndInit();
            this.ResumeLayout( false );

        }

        #endregion

        private AxXtremeShortcutBar.AxShortcutCaption axShortcutCaption3;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button ButtonPDU;
        private System.Windows.Forms.Button ButtonPCD;
        private System.Windows.Forms.Button ButtonTDU;
        private System.Windows.Forms.Button ButtonTCD;
        private System.Windows.Forms.Button ButtonTCU;
        private System.Windows.Forms.Button ButtonO;
        private System.Windows.Forms.Button ButtonVacUC;
    }
}
