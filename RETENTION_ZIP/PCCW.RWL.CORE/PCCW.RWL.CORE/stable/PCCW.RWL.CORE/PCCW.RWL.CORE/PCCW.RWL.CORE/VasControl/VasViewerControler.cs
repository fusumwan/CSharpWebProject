using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-03-Thu>
///-- Description:	<Description,Class :VasViewerController, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    [Serializable]
    public class VasViewerController
    {
        protected Hashtable n_oVasDrp1 = new Hashtable();
        #region m_oVasDrp1
        protected Hashtable m_oVasDrp1
        {
            get
            {
                return this.n_oVasDrp1;
            }
            set
            {
                this.n_oVasDrp1 = value;
            }
        }
        #endregion m_oVasDrp1

        protected Hashtable n_oVasDrp2 = new Hashtable();
        #region m_oVasDrp2
        protected Hashtable m_oVasDrp2
        {
            get
            {
                return this.n_oVasDrp2;
            }
            set
            {
                this.n_oVasDrp2 = value;
            }
        }
        #endregion m_oVasDrp2

        #region Constructor & Destructor
        public VasViewerController() { }

        public VasViewerController(Hashtable x_oVasDrp1, Hashtable x_oVasDrp2)
        {
            m_oVasDrp1 = x_oVasDrp1;
            m_oVasDrp2 = x_oVasDrp2;
        }

        ~VasViewerController() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public Hashtable GetVasDrp1() { return this.m_oVasDrp1; }
        public Hashtable GetVasDrp2() { return this.m_oVasDrp2; }

        public bool SetVasDrp1(Hashtable value)
        {
            this.m_oVasDrp1 = value;
            return true;
        }

        public bool SetVasDrp2(Hashtable value)
        {
            this.m_oVasDrp2 = value;
            return true;
        }

        public VasDrpAtt SaveVasDrp1Selected(string x_sID, int x_iSel)
        {
            if (string.IsNullOrEmpty(x_sID)) return new VasDrpAtt();
            if (n_oVasDrp1.Contains(x_sID))
            {
                VasDrpAtt _oVasDrpAtt = (VasDrpAtt)n_oVasDrp1[x_sID];
                if (_oVasDrpAtt != null)
                {
                    _oVasDrpAtt.SelectedIndex = x_iSel;
                    return (VasDrpAtt)n_oVasDrp1[x_sID];
                }
                else
                {
                    _oVasDrpAtt = new VasDrpAtt();
                    _oVasDrpAtt.SelectedIndex = x_iSel;
                    n_oVasDrp1[x_sID] = _oVasDrpAtt;
                    return (VasDrpAtt)n_oVasDrp1[x_sID];
                }
            }
            else
            {
                VasDrpAtt _oVasDrpAtt = new VasDrpAtt();
                _oVasDrpAtt.SelectedIndex = x_iSel;
                n_oVasDrp1.Add(x_sID, _oVasDrpAtt);
                return (VasDrpAtt)n_oVasDrp1[x_sID];
            }
            return new VasDrpAtt();
        }

        public VasDrpAtt SaveVasDrp1Selected(string x_sID, int? x_iSel, bool? x_bDisplay, bool? x_bEnabled)
        {
            if (string.IsNullOrEmpty(x_sID)) return new VasDrpAtt();
            if (n_oVasDrp1.Contains(x_sID))
            {
                VasDrpAtt _oVasDrpAtt = (VasDrpAtt)n_oVasDrp1[x_sID];
                if (x_bDisplay == null)
                    _oVasDrpAtt = _oVasDrpAtt.SaveVasDrp(x_iSel, x_bEnabled, null);
                else
                {
                    _oVasDrpAtt = _oVasDrpAtt.SaveVasDrp(x_iSel, x_bEnabled, null)
                        .ModifyStyle("Display", ((bool)x_bDisplay) ? "inline" : "none");
                }
                return (VasDrpAtt)n_oVasDrp1[x_sID];
            }
            else
            {
                VasDrpAtt _oVasDrpAtt = new VasDrpAtt();
                if (x_bDisplay == null)
                    _oVasDrpAtt = _oVasDrpAtt.SaveVasDrp(x_iSel, x_bEnabled, null);
                else
                {
                    _oVasDrpAtt = _oVasDrpAtt.SaveVasDrp(x_iSel, x_bEnabled, null)
                        .ModifyStyle("Display", ((bool)x_bDisplay) ? "inline" : "none");
                }
                n_oVasDrp1.Add(x_sID, _oVasDrpAtt);
                return (VasDrpAtt)n_oVasDrp1[x_sID];
            }
            return new VasDrpAtt();
        }

        public VasDrpAtt SaveVasDrp2Selected(string x_sID, int x_iSel)
        {
            if (string.IsNullOrEmpty(x_sID)) return new VasDrpAtt();
            if (n_oVasDrp2.Contains(x_sID))
            {
                VasDrpAtt _oVasDrpAtt = (VasDrpAtt)n_oVasDrp1[x_sID];
                if (_oVasDrpAtt != null)
                {
                    _oVasDrpAtt.SelectedIndex = x_iSel;
                    return (VasDrpAtt)n_oVasDrp2[x_sID];
                }
                else
                {
                    _oVasDrpAtt = new VasDrpAtt();
                    _oVasDrpAtt.SelectedIndex = x_iSel;
                    n_oVasDrp2[x_sID] = _oVasDrpAtt;
                    return (VasDrpAtt)n_oVasDrp2[x_sID];
                }
                
            }
            else
            {
                VasDrpAtt _oVasDrpAtt = new VasDrpAtt();
                _oVasDrpAtt.SelectedIndex = x_iSel;
                n_oVasDrp2.Add(x_sID, _oVasDrpAtt);
                return (VasDrpAtt)n_oVasDrp2[x_sID];
            }
            return new VasDrpAtt();
        }

        public VasDrpAtt SaveVasDrp2Selected(string x_sID, int? x_iSel, bool? x_bDisplay, bool? x_bEnabled)
        {
            if (string.IsNullOrEmpty(x_sID)) return new VasDrpAtt();
            if (n_oVasDrp2.Contains(x_sID))
            {
                VasDrpAtt _oVasDrpAtt = (VasDrpAtt)n_oVasDrp2[x_sID];
                if (x_bDisplay == null)
                    _oVasDrpAtt = _oVasDrpAtt.SaveVasDrp(x_iSel, x_bEnabled, null);
                else
                {
                    _oVasDrpAtt = _oVasDrpAtt.SaveVasDrp(x_iSel, x_bEnabled, null)
                        .ModifyStyle("Display", ((bool)x_bDisplay) ? "inline" : "none");
                }
                return (VasDrpAtt)n_oVasDrp2[x_sID];
            }
            else
            {
                VasDrpAtt _oVasDrpAtt = new VasDrpAtt();
                if (x_bDisplay == null)
                    _oVasDrpAtt = _oVasDrpAtt.SaveVasDrp(x_iSel, x_bEnabled, null);
                else
                {
                    _oVasDrpAtt = _oVasDrpAtt.SaveVasDrp(x_iSel, x_bEnabled, null)
                        .ModifyStyle("Display", ((bool)x_bDisplay) ? "inline" : "none");
                }
                n_oVasDrp2.Add(x_sID, _oVasDrpAtt);
                return (VasDrpAtt)n_oVasDrp2[x_sID];
            }
            return new VasDrpAtt();
        }


        public int GetVasDrp1Selected(string x_sID)
        {
            if (string.IsNullOrEmpty(x_sID)) return -1;
            if (n_oVasDrp1.Contains(x_sID)) return ((VasDrpAtt)n_oVasDrp1[x_sID]).SelectedIndex;
            return -1;
        }

        public VasDrpAtt GetVasDrp1Att(string x_sID)
        {
            if (string.IsNullOrEmpty(x_sID)) return new VasDrpAtt();
            if (n_oVasDrp1.Contains(x_sID)) return ((VasDrpAtt)n_oVasDrp1[x_sID]);
            return new VasDrpAtt();
        }

        public int GetVasDrp2Selected(string x_sID)
        {
            if (string.IsNullOrEmpty(x_sID)) return -1;
            if (n_oVasDrp2.Contains(x_sID)) return ((VasDrpAtt)n_oVasDrp2[x_sID]).SelectedIndex;
            return -1;
        }

        public VasDrpAtt GetVasDrp2Att(string x_sID)
        {
            if (string.IsNullOrEmpty(x_sID)) return new VasDrpAtt();
            if (n_oVasDrp2.Contains(x_sID)) return ((VasDrpAtt)n_oVasDrp2[x_sID]);
            return new VasDrpAtt();
        }
        #endregion

        #region Equals
        public bool Equals(VasViewerController x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_oVasDrp1.Equals(x_oObj.m_oVasDrp1)) { return false; }
            if (!this.m_oVasDrp2.Equals(x_oObj.m_oVasDrp2)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.m_oVasDrp1 = new Hashtable();
            this.m_oVasDrp2 = new Hashtable();
        }
        #endregion Release

        #region DeepClone
        public VasViewerController DeepClone()
        {
            VasViewerController VasViewerController_Clone = new VasViewerController();
            VasViewerController_Clone.SetVasDrp1(this.m_oVasDrp1);
            VasViewerController_Clone.SetVasDrp2(this.m_oVasDrp2);
            return VasViewerController_Clone;
        }
        #endregion Clone

    }
}
