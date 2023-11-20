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
///-- Create date: <Create Date 2010-06-11>
///-- Description:	<Description,Table :[MobileAutoProgram],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileAutoProgramDalDAO{
        
        #region RS
        public class MobileAutoProgramRS
        {
            public bool n_bRdate = false;
            public bool n_bAuto_name = false;
            public bool n_bId = false;
            public bool n_bGuid = false;
            public bool n_bActive = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bRdate  || x_bSetShowALL || (MobileAutoProgram.Para.rdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileAutoProgram.Para.rdate);
                }
                if (this.n_bAuto_name  || x_bSetShowALL || (MobileAutoProgram.Para.auto_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAuto_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileAutoProgram.Para.auto_name);
                }
                if (this.n_bId  || x_bSetShowALL || (MobileAutoProgram.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileAutoProgram.Para.id);
                }
                if (this.n_bGuid  || x_bSetShowALL || (MobileAutoProgram.Para.guid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGuid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileAutoProgram.Para.guid);
                }
                if (this.n_bActive  || x_bSetShowALL || (MobileAutoProgram.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileAutoProgram.Para.active);
                }
                return _oFR.ToString();
            }
            
            public string FieldsToReturn()
            {
                return this.FieldsToReturn(string.Empty,false);
            }
            
        }
        #endregion
        #region Constructor
        
        public MobileAutoProgramDalDAO(){
        }
        ~MobileAutoProgramDalDAO(){
            this.Release();
        }
        #endregion
        
        #region Search Engine
        public static global::System.Data.SqlClient.SqlDataReader DrSearch(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, string x_sFieldsToReturn,string x_sSortByField,bool x_bAscDirection)
        {
            SearchUtils _oSearchUtils = new SearchUtils();
            _oSearchUtils.SetSearchItems(x_oSearchItems);
            _oSearchUtils.SetRowFilter(x_sRowFilter);
            _oSearchUtils.SetStart(x_lStart);
            _oSearchUtils.SetLimit(x_lLimit);
            _oSearchUtils.SetFieldsToReturn(x_sFieldsToReturn);
            _oSearchUtils.SetOrderByField(x_sSortByField);
            _oSearchUtils.SetAscDirection(x_bAscDirection);
            _oSearchUtils.SetTable(MobileAutoProgram.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileAutoProgramEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileAutoProgramRS x_oFieldsToReturn,MobileAutoProgramRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileAutoProgramEntity> _oMobileAutoProgramList = new List<MobileAutoProgramEntity>();
                
                while (_oDATA.Read())
                {
                    MobileAutoProgram _oMobileAutoProgram = new MobileAutoProgram();
                    if ((true).Equals(x_oFieldsToReturn.n_bRdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileAutoProgram.Para.rdate])) { _oMobileAutoProgram.SetRdate((global::System.Nullable<DateTime>)_oDATA[MobileAutoProgram.Para.rdate]); } else { _oMobileAutoProgram.SetRdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAuto_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileAutoProgram.Para.auto_name])) { _oMobileAutoProgram.SetAuto_name((string)_oDATA[MobileAutoProgram.Para.auto_name]); } else { _oMobileAutoProgram.SetAuto_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileAutoProgram.Para.id])) { _oMobileAutoProgram.SetId((global::System.Nullable<int>)_oDATA[MobileAutoProgram.Para.id]); } else { _oMobileAutoProgram.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGuid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileAutoProgram.Para.guid])) { _oMobileAutoProgram.SetGuid((global::System.Nullable<Guid>)_oDATA[MobileAutoProgram.Para.guid]); } else { _oMobileAutoProgram.SetGuid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileAutoProgram.Para.active])) { _oMobileAutoProgram.SetActive((global::System.Nullable<bool>)_oDATA[MobileAutoProgram.Para.active]); } else { _oMobileAutoProgram.SetActive(null); }
                    }
                    _oMobileAutoProgramList.Add(_oMobileAutoProgram);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileAutoProgramList;
            }
            return new List<MobileAutoProgramEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileAutoProgramEntity> OrderBy(string x_sSort, IQueryable<MobileAutoProgramEntity> x_oMobileAutoProgramBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileAutoProgram.Para.rdate:
                if(x_bAsc)
                    x_oMobileAutoProgramBaseList = x_oMobileAutoProgramBaseList.OrderBy(c => c.rdate).Select(c => c);
                else
                    x_oMobileAutoProgramBaseList = x_oMobileAutoProgramBaseList.OrderByDescending(c => c.rdate).Select(c => c);
                break;
                case MobileAutoProgram.Para.auto_name:
                if(x_bAsc)
                    x_oMobileAutoProgramBaseList = x_oMobileAutoProgramBaseList.OrderBy(c => c.auto_name).Select(c => c);
                else
                    x_oMobileAutoProgramBaseList = x_oMobileAutoProgramBaseList.OrderByDescending(c => c.auto_name).Select(c => c);
                break;
                case MobileAutoProgram.Para.id:
                if(x_bAsc)
                    x_oMobileAutoProgramBaseList = x_oMobileAutoProgramBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oMobileAutoProgramBaseList = x_oMobileAutoProgramBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case MobileAutoProgram.Para.guid:
                if(x_bAsc)
                    x_oMobileAutoProgramBaseList = x_oMobileAutoProgramBaseList.OrderBy(c => c.guid).Select(c => c);
                else
                    x_oMobileAutoProgramBaseList = x_oMobileAutoProgramBaseList.OrderByDescending(c => c.guid).Select(c => c);
                break;
                case MobileAutoProgram.Para.active:
                if(x_bAsc)
                    x_oMobileAutoProgramBaseList = x_oMobileAutoProgramBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileAutoProgramBaseList = x_oMobileAutoProgramBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
            }
            return x_oMobileAutoProgramBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileAutoProgramEntity> FindAll()
        {
            MobileAutoProgramEntity[] _oMobileAutoProgramsArr=  MobileAutoProgramRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileAutoProgramsArr != null)
            {
                IList<MobileAutoProgramEntity> _oMobileAutoProgramsList = (IList<MobileAutoProgramEntity>)_oMobileAutoProgramsArr;
                return _oMobileAutoProgramsList;
            }
            return new List<MobileAutoProgramEntity>();
        }
        
        public static IList<MobileAutoProgramEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileAutoProgramEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileAutoProgramEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileAutoProgramEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileAutoProgramRS x_oShowField = new MobileAutoProgramRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileAutoProgramRS x_oSortField=new MobileAutoProgramRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileAutoProgram.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileAutoProgram.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileAutoProgramRepositoryBase _oMobileAutoProgramRepositoryBase = new MobileAutoProgramRepositoryBase(GetDB());
            return _oMobileAutoProgramRepositoryBase.GetCount();
        }
        #endregion
        
        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion
        #region
        public void Release(){}
        #endregion
    }
}


