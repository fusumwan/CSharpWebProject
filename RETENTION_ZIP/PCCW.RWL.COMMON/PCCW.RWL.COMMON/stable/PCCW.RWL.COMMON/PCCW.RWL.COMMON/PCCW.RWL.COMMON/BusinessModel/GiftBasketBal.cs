using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.ENTITY.FRAMEWORK.STOCK;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-02-22>
///-- Description:	<Description,Table :[GiftBasket],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [GiftBasket] Business layer
    /// </summary>
    
    
    public class GiftBasketBals:Collection<GiftBasket>{}
    public class GiftBasketBal: GiftBasketBalBase{

        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public GiftBasketBal() : base(){
        }
        ~GiftBasketBal(){
            base.Release();
        }
        #endregion

        #region GiftListBox
        public static Hashtable ListBoxGift()
        {
            Hashtable _oGiftList = new Hashtable();
            global::System.Data.SqlClient.SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch("select gift_desc,gift_code from " + Configurator.MSSQLTablePrefix + "GiftBasket with (nolock) where active=1 order by gift_desc");
            while (_oReader.Read())
            {
                if (!_oGiftList.ContainsKey(_oReader["gift_code"].ToString()))
                    _oGiftList.Add(_oReader["gift_code"].ToString(), _oReader["gift_desc"].ToString());
            }
            if(_oReader!=null) _oReader.Close();
            return _oGiftList;
        }

        public static ObjectArr ListBoxGiftNoSort()
        {
            ObjectArr _oGiftList = new ObjectArr();
            global::System.Data.SqlClient.SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT gift_desc,gift_code FROM " + Configurator.MSSQLTablePrefix + "GiftBasket WITH (nolock) WHERE active=1 ORDER BY gift_desc");
            while (_oReader.Read())
            {
                if (!_oGiftList.ContainsKey(_oReader[GiftBasket.Para.gift_desc].ToString()))
                    _oGiftList.Add(_oReader[GiftBasket.Para.gift_desc].ToString(), _oReader[GiftBasket.Para.gift_code].ToString());
            }
            if (_oReader != null)
            {
                _oReader.Close();
                _oReader.Dispose();
            }
            return _oGiftList;
        }
        #endregion

        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.bWithNoLock = true;
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion



    }
}


