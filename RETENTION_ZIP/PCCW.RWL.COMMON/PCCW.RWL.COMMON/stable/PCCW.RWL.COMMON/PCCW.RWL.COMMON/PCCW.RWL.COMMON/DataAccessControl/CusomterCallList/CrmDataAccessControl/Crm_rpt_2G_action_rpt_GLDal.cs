using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
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
///-- Create date: <Create Date 2009-07-13>
///-- Description:	<Description,Table :[crm_rpt_2G_action_rpt_GL],DataAccess layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [crm_rpt_2G_action_rpt_GL] DataAccess layer
    /// </summary>
    
    public class Crm_rpt_2G_action_rpt_GLDals:Collection<Crm_rpt_2G_action_rpt_GL>{}
    public class Crm_rpt_2G_action_rpt_GLDal: Crm_rpt_2G_action_rpt_GLDalDAO{
        
        #region Constructor
        
        public Crm_rpt_2G_action_rpt_GLDal() : base(){
        }
        ~Crm_rpt_2G_action_rpt_GLDal(){
            base.Release();
        }
        #endregion
        
        
    }
}


