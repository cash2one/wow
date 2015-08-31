﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo.Stock.X.U50
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PolicyDControlSub2 : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        public PolicyDControlSub2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnVisibleChanged( EventArgs eventArgs )
        {
            base.OnVisibleChanged( eventArgs );

            if ( this.Visible == true )
            {
                MainForm.Instance.AxSkinFramework.ApplyWindow( this.Handle.ToInt32() );
                this.BackColor = MainForm.Instance.AxSkinFramework.GetColor( XtremeSkinFramework.XTPColorManagerColor.STDCOLOR_BTNFACE );
            }
        }

        private void ConfigBControlSub2_Load( object sender, EventArgs e )
        {
            CheckBoxAllow_CheckedChanged( this, EventArgs.Empty );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBoxAllow_CheckedChanged( object sender, EventArgs eventArgs )
        {
            if ( CheckBoxAllow.Checked == false )
            {
                this.RadioButtonAny.Enabled = false;
                this.RadioButtonBig.Enabled = false;
                this.RadioButtonSmall.Enabled = false;
                this.RadioButtonBigAndSmall.Enabled = false;

                this.LabelBig.Enabled = false;
                this.LabelSmall.Enabled = false;
                this.LabelBigAndSmall.Enabled = false;
                this.LabelBigAndSmall2.Enabled = false;

                this.MaskedTextBoxBig.Enabled = false;
                this.MaskedTextBoxSmall.Enabled = false;
                this.MaskedTextBoxBig2.Enabled = false;
                this.MaskedTextBoxSmall2.Enabled = false;
            }
            else
            {
                this.RadioButtonAny.Enabled = true;
                this.RadioButtonBig.Enabled = true;
                this.RadioButtonSmall.Enabled = true;
                this.RadioButtonBigAndSmall.Enabled = true;

                if ( this.RadioButtonAny.Checked == true )
                    RadioButtonAny_CheckedChanged( this, EventArgs.Empty );
                if ( this.RadioButtonBig.Checked == true )
                    RadioButtonBig_CheckedChanged( this, EventArgs.Empty );
                else if ( this.RadioButtonSmall.Checked == true )
                    RadioButtonSmall_CheckedChanged( this, EventArgs.Empty );
                else if ( this.RadioButtonBigAndSmall.Checked == true )
                    RadioButtonBigAndSmall_CheckedChanged( this, EventArgs.Empty );
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonBig_CheckedChanged( object sender, EventArgs eventArgs )
        {
            if ( this.RadioButtonBig.Enabled == true )
            {
                this.LabelBig.Enabled = true;
                this.MaskedTextBoxBig.Enabled = true;

                this.LabelSmall.Enabled = false;
                this.LabelBigAndSmall.Enabled = false;
                this.LabelBigAndSmall2.Enabled = false;

                this.MaskedTextBoxSmall.Enabled = false;
                this.MaskedTextBoxBig2.Enabled = false;
                this.MaskedTextBoxSmall2.Enabled = false;
            }
            else
            {
                this.LabelBig.Enabled = false;
                this.MaskedTextBoxBig.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonSmall_CheckedChanged( object sender, EventArgs eventArgs )
        {
            if ( this.RadioButtonSmall.Enabled == true )
            {
                this.LabelSmall.Enabled = true;
                this.MaskedTextBoxSmall.Enabled = true;

                this.LabelBig.Enabled = false;
                this.LabelBigAndSmall.Enabled = false;
                this.LabelBigAndSmall2.Enabled = false;

                this.MaskedTextBoxBig.Enabled = false;
                this.MaskedTextBoxBig2.Enabled = false;
                this.MaskedTextBoxSmall2.Enabled = false;
            }
            else
            {
                this.LabelSmall.Enabled = false;
                this.MaskedTextBoxSmall.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonBigAndSmall_CheckedChanged( object sender, EventArgs eventArgs )
        {
            if ( this.RadioButtonBigAndSmall.Enabled == true )
            {
                this.LabelBigAndSmall.Enabled = true;
                this.LabelBigAndSmall2.Enabled = true;
                this.MaskedTextBoxBig2.Enabled = true;
                this.MaskedTextBoxSmall2.Enabled = true;

                this.LabelBig.Enabled = false;
                this.LabelSmall.Enabled = false;

                this.MaskedTextBoxBig.Enabled = false;
                this.MaskedTextBoxSmall.Enabled = false;
            }
            else
            {
                this.LabelBigAndSmall.Enabled = false;
                this.MaskedTextBoxBig2.Enabled = false;
                this.MaskedTextBoxSmall2.Enabled = false;
            }
        }

        private void RadioButtonAny_CheckedChanged( object sender, EventArgs e )
        {
            if ( this.RadioButtonAny.Enabled == true )
            {
                this.LabelBigAndSmall.Enabled = false;
                this.LabelBigAndSmall2.Enabled = false;
                this.MaskedTextBoxBig2.Enabled = false;
                this.MaskedTextBoxSmall2.Enabled = false;

                this.LabelBig.Enabled = false;
                this.LabelSmall.Enabled = false;

                this.MaskedTextBoxBig.Enabled = false;
                this.MaskedTextBoxSmall.Enabled = false;
            }
        }
    }
}
