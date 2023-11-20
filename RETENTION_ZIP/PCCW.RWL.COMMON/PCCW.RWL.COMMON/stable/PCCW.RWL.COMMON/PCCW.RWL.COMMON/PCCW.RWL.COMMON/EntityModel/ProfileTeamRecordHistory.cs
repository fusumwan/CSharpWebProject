using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;


///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2011-01-14>
///-- Description:	<Description,Table :[ProfileTeamRecordHistory],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [ProfileTeamRecordHistory] Object Base layer
    /// </summary>
    public class ProfileTeamRecordHistorys:Collection<ProfileTeamRecordHistory>{}
    public class ProfileTeamRecordHistory: ProfileTeamRecordHistoryEntity{
        
        #region Constructor
        
        public ProfileTeamRecordHistory() : base(){
        }
        public ProfileTeamRecordHistory(MSSQLConnect x_oDB) : base(x_oDB){
        }
        
        public ProfileTeamRecordHistory(MSSQLConnect x_oDB,global::System.Nullable<long> x_lHis_id) : base(x_oDB,x_lHis_id) {
        }
        
        ~ProfileTeamRecordHistory(){
            base.Release();
        }
        #endregion
        
        
    }
}


