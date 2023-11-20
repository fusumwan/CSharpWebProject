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
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;

using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-03-08>
///-- Description:	<Description,Table :[CSSDB].[dbo].[channel_team_map],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [CSSDB].[dbo].[channel_team_map] Object Base layer
    /// </summary>
    public class Channel_team_maps:Collection<Channel_team_map>{}
    public class Channel_team_map: Channel_team_mapBase{
        
        #region Constructor
        
        public Channel_team_map() : base(){
        }
        public Channel_team_map(MSSQLConnect x_oDB) : base(x_oDB){
        }
        
        public Channel_team_map(MSSQLConnect x_oDB,System.Nullable<int> x_iId) : base(x_oDB,x_iId) {
        }
        
        ~Channel_team_map(){
            base.Release();
        }
        #endregion
        
        
    }
}


