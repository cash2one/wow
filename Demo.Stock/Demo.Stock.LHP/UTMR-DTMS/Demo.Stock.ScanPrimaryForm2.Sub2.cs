﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Demo.Stock.LHP.Common;
using Demo.Stock.LHP.BaseSR;

namespace Demo.Stock.LHP
{
    public partial class ScanPrimary2ControlSub2 : UserControl
    {
        ScanPrimary2ControlSub2A m_ScanControlSub2A = null;
        ScanPrimary2ControlSub2B m_ScanControlSub2B = null;
        SRControlSub2Up m_ScanControlSub2BUp = null;

        public ScanPrimary2ControlSub2()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            //m_ScanControlSub2A = new ScanPrimary2ControlSub2A();
            //m_ScanControlSub2A.Parent = this.axTabControl;

            //this.axTabControl.InsertItem( 0, "扫描设置A", m_ScanControlSub2A.Handle.ToInt32(), 0 );

            //m_ScanControlSub2B = new ScanPrimary2ControlSub2B();
            //m_ScanControlSub2B.Parent = this.axTabControl;

            //this.axTabControl.InsertItem( 1, "扫描设置B", m_ScanControlSub2B.Handle.ToInt32(), 0 );


            //m_ScanControlSub2BUp = new ScanPrimaryControlSub2Up();
            //m_ScanControlSub2BUp.Parent = this.axTabControl;
            //this.axTabControl.InsertItem( 2, "扫描设置C", m_ScanControlSub2A.Handle.ToInt32(), 0 );
        }


        private void ScanControlSub2B_Load( object sender, EventArgs e )
        {
        }

        public LHPPrimaryScanInfo.ScanNormalInfo GetLHPScanNormalInfo()
        {
            LHPPrimaryScanInfo.ScanNormalInfo lhpScanNormalInfo = m_ScanControlSub2B.GetLHPScanNormalInfo();

            LHPPrimaryScanInfo.ScanTrendInfo lhpScanTrendInfo = m_ScanControlSub2B.GetLHPScanTrendInfo();
            lhpScanTrendInfo.UpTrendInfo = m_ScanControlSub2BUp.GetLHPScanUpTrendInfo();
            lhpScanTrendInfo.DownTrendInfo = m_ScanControlSub2A.GetLHPScanDownTrendInfo();

            lhpScanNormalInfo.ScanTrendInfo = lhpScanTrendInfo;

            return lhpScanNormalInfo;
        }

        public void SetLHPScanNormalInfo( LHPPrimaryScanInfo.ScanNormalInfo lhpScanNormalInfo )
        {
            m_ScanControlSub2B.SetLHPScanNormalInfo( lhpScanNormalInfo );
            m_ScanControlSub2B.SetLHPScanTrendInfo( lhpScanNormalInfo.ScanTrendInfo );
            m_ScanControlSub2BUp.SetLHPScanUpTrendInfo( lhpScanNormalInfo.ScanTrendInfo.UpTrendInfo );
            m_ScanControlSub2A.SetLHPScanDownTrendInfo( lhpScanNormalInfo.ScanTrendInfo.DownTrendInfo );
        }
    }
}
