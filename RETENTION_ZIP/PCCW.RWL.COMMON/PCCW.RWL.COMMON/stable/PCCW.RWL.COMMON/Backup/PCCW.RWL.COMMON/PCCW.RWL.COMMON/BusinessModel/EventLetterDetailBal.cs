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
///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-02-22>
///-- Description:	<Description,Table :[EventLetterDetail],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [EventLetterDetail] Business layer
    /// </summary>
    
    
    public class EventLetterDetailBals:Collection<EventLetterDetail>{}
    public class EventLetterDetailBal: EventLetterDetailBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public EventLetterDetailBal() : base(){
        }
        ~EventLetterDetailBal(){
            base.Release();
        }
        #endregion

        public static global::System.Linq.IQueryable<EventLetterDetailEntity> RwlLetterList(string x_Mrt_no)
        {
            EventLetterDetailRepositoryBase _oEventLetterDetailRepositoryBase = EventLetterDetailRepositoryBase.Instance();
            IQueryable<EventLetterDetailEntity> _oRwlLetterList = from sRwlLetterList in _oEventLetterDetailRepositoryBase.EventLetterDetails
                                                         where
                                                             sRwlLetterList.active == true
                                                         select sRwlLetterList;

            if (x_Mrt_no != null)
            {
                if (!string.IsNullOrEmpty(x_Mrt_no.ToString().Trim()))
                    _oRwlLetterList = _oRwlLetterList.Where(c => c.mob_num == x_Mrt_no.ToString().Trim()).Select(c => c);
            }
            return _oRwlLetterList;
        }
    }
}


