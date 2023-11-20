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
///-- Create date: <Create Date 2010-12-17>
///-- Description:	<Description,Table :[MobileOrderIssueRestrictionProfile],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [MobileOrderIssueRestrictionProfile] Object Base layer
    /// </summary>
    public class MobileOrderIssueRestrictionProfiles:Collection<MobileOrderIssueRestrictionProfile>{}
    public class MobileOrderIssueRestrictionProfile: MobileOrderIssueRestrictionProfileEntity{
        
        #region Constructor
        
        public MobileOrderIssueRestrictionProfile() : base(){
        }
        public MobileOrderIssueRestrictionProfile(MSSQLConnect x_oDB) : base(x_oDB){
        }
        
        public MobileOrderIssueRestrictionProfile(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid) : base(x_oDB,x_iMid) {
        }
        
        ~MobileOrderIssueRestrictionProfile(){
            base.Release();
        }
        #endregion
        
        
    }
}


