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

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-05-Wed>
///-- Description:	<Description,Class :HsCultureComparer>
///-- =============================================
namespace NEURON.ENTITY.FRAMEWORK
{

    public class HsCultureComparer : IEqualityComparer
    {

        protected CaseInsensitiveComparer n_oHsComparer = null;
        #region m_oHsComparer
        protected CaseInsensitiveComparer m_oHsComparer
        {
            get
            {
                return this.n_oHsComparer;
            }
            set
            {
                this.n_oHsComparer = value;
            }
        }
        #endregion m_oHsComparer


        #region Constructor & Destructor
        public HsCultureComparer()
        {
            n_oHsComparer = CaseInsensitiveComparer.DefaultInvariant;
        }

        public HsCultureComparer(CultureInfo x_oCulture)
        {
            n_oHsComparer = new CaseInsensitiveComparer(x_oCulture);
        }

        public HsCultureComparer(CaseInsensitiveComparer x_oHsComparer)
        {
            n_oHsComparer = x_oHsComparer;
        }

        ~HsCultureComparer() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public CaseInsensitiveComparer GetHsComparer() { return this.m_oHsComparer; }

        public bool SetHsComparer(CaseInsensitiveComparer value)
        {
            this.n_oHsComparer = value;
            return true;
        }
        #endregion

        public new bool Equals(object x, object y)
        {
            if (n_oHsComparer.Compare(x, y) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(object obj)
        {
            return obj.ToString().ToLower().GetHashCode();
        }

        #region Equals
        public bool Equals(HsCultureComparer x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_oHsComparer.Equals(x_oObj.m_oHsComparer)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.m_oHsComparer = null;
        }
        #endregion Release


        #region Clone
        public HsCultureComparer Clone()
        {
            HsCultureComparer HsCultureComparer_Clone = new HsCultureComparer();
            HsCultureComparer_Clone.SetHsComparer(this.m_oHsComparer);
            return HsCultureComparer_Clone;
        }
        #endregion Clone

    }
}
