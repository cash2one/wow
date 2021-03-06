﻿namespace Demo_R.O.S.E.STB.Editor
{
    partial class STBEditorForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Load949ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Load936ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs949ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs936ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StructToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.dataGridView ) ).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "*.STB";
            this.openFileDialog.FileName = "*.STB";
            this.openFileDialog.Filter = "STB 文件 (*.STB)|*.STB|所有文件 (*.*)|*.*";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem} );
            this.menuStrip.Location = new System.Drawing.Point( 0, 0 );
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size( 792, 24 );
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.Load949ToolStripMenuItem,
            this.Load936ToolStripMenuItem,
            this.toolStripSeparator1,
            this.SaveToolStripMenuItem,
            this.SaveAs949ToolStripMenuItem,
            this.SaveAs936ToolStripMenuItem,
            this.toolStripSeparator3,
            this.CloseToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExitToolStripMenuItem} );
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size( 59, 20 );
            this.FileToolStripMenuItem.Text = "文件(&F)";
            // 
            // Load949ToolStripMenuItem
            // 
            this.Load949ToolStripMenuItem.Name = "Load949ToolStripMenuItem";
            this.Load949ToolStripMenuItem.Size = new System.Drawing.Size( 166, 22 );
            this.Load949ToolStripMenuItem.Text = "读取韩文文件(&L)";
            this.Load949ToolStripMenuItem.Click += new System.EventHandler( this.LoadKoreaToolStripMenuItem_Click );
            // 
            // Load936ToolStripMenuItem
            // 
            this.Load936ToolStripMenuItem.Name = "Load936ToolStripMenuItem";
            this.Load936ToolStripMenuItem.Size = new System.Drawing.Size( 166, 22 );
            this.Load936ToolStripMenuItem.Text = "读取中文简体文件";
            this.Load936ToolStripMenuItem.Click += new System.EventHandler( this.LoadChinaToolStripMenuItem_Click );
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 163, 6 );
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size( 166, 22 );
            this.SaveToolStripMenuItem.Text = "保存(&S)";
            this.SaveToolStripMenuItem.Click += new System.EventHandler( this.SaveToolStripMenuItem_Click );
            // 
            // SaveAs949ToolStripMenuItem
            // 
            this.SaveAs949ToolStripMenuItem.Enabled = false;
            this.SaveAs949ToolStripMenuItem.Name = "SaveAs949ToolStripMenuItem";
            this.SaveAs949ToolStripMenuItem.Size = new System.Drawing.Size( 166, 22 );
            this.SaveAs949ToolStripMenuItem.Text = "另存为韩文(&A)";
            this.SaveAs949ToolStripMenuItem.Click += new System.EventHandler( this.SaveAsKoreaToolStripMenuItem_Click );
            // 
            // SaveAs936ToolStripMenuItem
            // 
            this.SaveAs936ToolStripMenuItem.Enabled = false;
            this.SaveAs936ToolStripMenuItem.Name = "SaveAs936ToolStripMenuItem";
            this.SaveAs936ToolStripMenuItem.Size = new System.Drawing.Size( 166, 22 );
            this.SaveAs936ToolStripMenuItem.Text = "另存为中文简体";
            this.SaveAs936ToolStripMenuItem.Click += new System.EventHandler( this.SaveAsChinaToolStripMenuItem_Click );
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size( 163, 6 );
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Enabled = false;
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size( 166, 22 );
            this.CloseToolStripMenuItem.Text = "关闭(&C)";
            this.CloseToolStripMenuItem.Click += new System.EventHandler( this.CloseToolStripMenuItem_Click );
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size( 163, 6 );
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size( 166, 22 );
            this.ExitToolStripMenuItem.Text = "退出(&X)";
            this.ExitToolStripMenuItem.Click += new System.EventHandler( this.ExitToolStripMenuItem_Click );
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.DelToolStripMenuItem,
            this.ColumnToolStripMenuItem,
            this.StructToolStripMenuItem} );
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size( 59, 20 );
            this.EditToolStripMenuItem.Text = "编辑(&E)";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Enabled = false;
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size( 136, 22 );
            this.AddToolStripMenuItem.Text = "添加行(&A)";
            this.AddToolStripMenuItem.Click += new System.EventHandler( this.AddToolStripMenuItem_Click );
            // 
            // DelToolStripMenuItem
            // 
            this.DelToolStripMenuItem.Enabled = false;
            this.DelToolStripMenuItem.Name = "DelToolStripMenuItem";
            this.DelToolStripMenuItem.Size = new System.Drawing.Size( 136, 22 );
            this.DelToolStripMenuItem.Text = "删除行(&D)";
            this.DelToolStripMenuItem.Click += new System.EventHandler( this.DelToolStripMenuItem_Click );
            // 
            // ColumnToolStripMenuItem
            // 
            this.ColumnToolStripMenuItem.Enabled = false;
            this.ColumnToolStripMenuItem.Name = "ColumnToolStripMenuItem";
            this.ColumnToolStripMenuItem.Size = new System.Drawing.Size( 136, 22 );
            this.ColumnToolStripMenuItem.Text = "列的名字(&C)";
            this.ColumnToolStripMenuItem.Click += new System.EventHandler( this.ColumnToolStripMenuItem_Click );
            // 
            // StructToolStripMenuItem
            // 
            this.StructToolStripMenuItem.Enabled = false;
            this.StructToolStripMenuItem.Name = "StructToolStripMenuItem";
            this.StructToolStripMenuItem.Size = new System.Drawing.Size( 136, 22 );
            this.StructToolStripMenuItem.Text = "结构名字(&S)";
            this.StructToolStripMenuItem.Click += new System.EventHandler( this.StructToolStripMenuItem_Click );
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem} );
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size( 59, 20 );
            this.HelpToolStripMenuItem.Text = "帮助(&H)";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size( 274, 22 );
            this.AboutToolStripMenuItem.Text = "关于 Demo R.O.S.E.STB.Editor(&A)...";
            this.AboutToolStripMenuItem.Click += new System.EventHandler( this.AboutToolStripMenuItem_Click );
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point( 0, 24 );
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size( 792, 549 );
            this.dataGridView.TabIndex = 1;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "STB 文件 (*.STB)|*.STB|所有文件 (*.*)|*.*";
            // 
            // STBEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 792, 573 );
            this.Controls.Add( this.dataGridView );
            this.Controls.Add( this.menuStrip );
            this.MainMenuStrip = this.menuStrip;
            this.Name = "STBEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo R.O.S.E.STB.Editor.Form";
            this.menuStrip.ResumeLayout( false );
            this.menuStrip.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.dataGridView ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Load949ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAs949ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColumnToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem Load936ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAs936ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StructToolStripMenuItem;
    }
}


