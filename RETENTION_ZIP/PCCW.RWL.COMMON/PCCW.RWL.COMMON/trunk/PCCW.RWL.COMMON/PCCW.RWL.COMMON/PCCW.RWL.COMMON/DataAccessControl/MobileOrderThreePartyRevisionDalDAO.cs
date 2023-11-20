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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2011-03-08>
///-- Description:	<Description,Table :[MobileOrderThreePartyRevision],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderThreePartyRevisionDalDAO{
        
        #region RS
        public class MobileOrderThreePartyRevisionRS
        {
            public bool n_bTpy_id = false;
            public bool n_bArthurization_person = false;
            public bool n_bContact_no = false;
            public bool n_bType = false;
            public bool n_bId_type = false;
            public bool n_bPlural = false;
            public bool n_bHkid = false;
            public bool n_bOrder_id = false;
            public bool n_bMid = false;
            public bool n_bThree_party = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bTpy_id  || x_bSetShowALL || (MobileOrderThreePartyRevision.Para.tpy_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTpy_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderThreePartyRevision.Para.tpy_id);
                }
                if (this.n_bArthurization_person  || x_bSetShowALL || (MobileOrderThreePartyRevision.Para.arthurization_person.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bArthurization_person=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderThreePartyRevision.Para.arthurization_person);
                }
                if (this.n_bContact_no  || x_bSetShowALL || (MobileOrderThreePartyRevision.Para.contact_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bContact_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderThreePartyRevision.Para.contact_no);
                }
                if (this.n_bType  || x_bSetShowALL || (MobileOrderThreePartyRevision.Para.type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bType=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderThreePartyRevision.Para.type);
                }
                if (this.n_bId_type  || x_bSetShowALL || (MobileOrderThreePartyRevision.Para.id_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderThreePartyRevision.Para.id_type);
                }
                if (this.n_bPlural  || x_bSetShowALL || (MobileOrderThreePartyRevision.Para.plural.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPlural=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderThreePartyRevision.Para.plural);
                }
                if (this.n_bHkid  || x_bSetShowALL || (MobileOrderThreePartyRevision.Para.hkid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHkid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderThreePartyRevision.Para.hkid);
                }
                if (this.n_bOrder_id  || x_bSetShowALL || (MobileOrderThreePartyRevision.Para.order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderThreePartyRevision.Para.order_id);
                }
                if (this.n_bMid  || x_bSetShowALL || (MobileOrderThreePartyRevision.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderThreePartyRevision.Para.mid);
                }
                if (this.n_bThree_party  || x_bSetShowALL || (MobileOrderThreePartyRevision.Para.three_party.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bThree_party=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderThreePartyRevision.Para.three_party);
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
        
        public MobileOrderThreePartyRevisionDalDAO(){
        }
        ~MobileOrderThreePartyRevisionDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderThreePartyRevision.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderThreePartyRevisionEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderThreePartyRevisionRS x_oFieldsToReturn,MobileOrderThreePartyRevisionRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderThreePartyRevisionEntity> _oMobileOrderThreePartyRevisionList = new List<MobileOrderThreePartyRevisionEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderThreePartyRevision _oMobileOrderThreePartyRevision = new MobileOrderThreePartyRevision();
                    if ((true).Equals(x_oFieldsToReturn.n_bTpy_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderThreePartyRevision.Para.tpy_id])) { _oMobileOrderThreePartyRevision.SetTpy_id((global::System.Nullable<long>)_oDATA[MobileOrderThreePartyRevision.Para.tpy_id]); } else { _oMobileOrderThreePartyRevision.SetTpy_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bArthurization_person))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderThreePartyRevision.Para.arthurization_person])) { _oMobileOrderThreePartyRevision.SetArthurization_person((string)_oDATA[MobileOrderThreePartyRevision.Para.arthurization_person]); } else { _oMobileOrderThreePartyRevision.SetArthurization_person(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bContact_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderThreePartyRevision.Para.contact_no])) { _oMobileOrderThreePartyRevision.SetContact_no((string)_oDATA[MobileOrderThreePartyRevision.Para.contact_no]); } else { _oMobileOrderThreePartyRevision.SetContact_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bType))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderThreePartyRevision.Para.type])) { _oMobileOrderThreePartyRevision.SetType((string)_oDATA[MobileOrderThreePartyRevision.Para.type]); } else { _oMobileOrderThreePartyRevision.SetType(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderThreePartyRevision.Para.id_type])) { _oMobileOrderThreePartyRevision.SetId_type((string)_oDATA[MobileOrderThreePartyRevision.Para.id_type]); } else { _oMobileOrderThreePartyRevision.SetId_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPlural))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderThreePartyRevision.Para.plural])) { _oMobileOrderThreePartyRevision.SetPlural((string)_oDATA[MobileOrderThreePartyRevision.Para.plural]); } else { _oMobileOrderThreePartyRevision.SetPlural(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHkid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderThreePartyRevision.Para.hkid])) { _oMobileOrderThreePartyRevision.SetHkid((string)_oDATA[MobileOrderThreePartyRevision.Para.hkid]); } else { _oMobileOrderThreePartyRevision.SetHkid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderThreePartyRevision.Para.order_id])) { _oMobileOrderThreePartyRevision.SetOrder_id((global::System.Nullable<int>)_oDATA[MobileOrderThreePartyRevision.Para.order_id]); } else { _oMobileOrderThreePartyRevision.SetOrder_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderThreePartyRevision.Para.mid])) { _oMobileOrderThreePartyRevision.SetMid((global::System.Nullable<long>)_oDATA[MobileOrderThreePartyRevision.Para.mid]); } else { _oMobileOrderThreePartyRevision.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bThree_party))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderThreePartyRevision.Para.three_party])) { _oMobileOrderThreePartyRevision.SetThree_party((global::System.Nullable<bool>)_oDATA[MobileOrderThreePartyRevision.Para.three_party]); } else { _oMobileOrderThreePartyRevision.SetThree_party(null); }
                    }
                    _oMobileOrderThreePartyRevisionList.Add(_oMobileOrderThreePartyRevision);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderThreePartyRevisionList;
            }
            return new List<MobileOrderThreePartyRevisionEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderThreePartyRevisionEntity> OrderBy(string x_sSort, IQueryable<MobileOrderThreePartyRevisionEntity> x_oMobileOrderThreePartyRevisionBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderThreePartyRevision.Para.tpy_id:
                if(x_bAsc)
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderBy(c => c.tpy_id).Select(c => c);
                else
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderByDescending(c => c.tpy_id).Select(c => c);
                break;
                case MobileOrderThreePartyRevision.Para.arthurization_person:
                if(x_bAsc)
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderBy(c => c.arthurization_person).Select(c => c);
                else
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderByDescending(c => c.arthurization_person).Select(c => c);
                break;
                case MobileOrderThreePartyRevision.Para.contact_no:
                if(x_bAsc)
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderBy(c => c.contact_no).Select(c => c);
                else
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderByDescending(c => c.contact_no).Select(c => c);
                break;
                case MobileOrderThreePartyRevision.Para.type:
                if(x_bAsc)
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderBy(c => c.type).Select(c => c);
                else
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderByDescending(c => c.type).Select(c => c);
                break;
                case MobileOrderThreePartyRevision.Para.id_type:
                if(x_bAsc)
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderBy(c => c.id_type).Select(c => c);
                else
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderByDescending(c => c.id_type).Select(c => c);
                break;
                case MobileOrderThreePartyRevision.Para.plural:
                if(x_bAsc)
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderBy(c => c.plural).Select(c => c);
                else
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderByDescending(c => c.plural).Select(c => c);
                break;
                case MobileOrderThreePartyRevision.Para.hkid:
                if(x_bAsc)
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderBy(c => c.hkid).Select(c => c);
                else
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderByDescending(c => c.hkid).Select(c => c);
                break;
                case MobileOrderThreePartyRevision.Para.order_id:
                if(x_bAsc)
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderBy(c => c.order_id).Select(c => c);
                else
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderByDescending(c => c.order_id).Select(c => c);
                break;
                case MobileOrderThreePartyRevision.Para.mid:
                if(x_bAsc)
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderBy(c => c.mid).Select(c => c);
                else
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderByDescending(c => c.mid).Select(c => c);
                break;
                case MobileOrderThreePartyRevision.Para.three_party:
                if(x_bAsc)
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderBy(c => c.three_party).Select(c => c);
                else
                    x_oMobileOrderThreePartyRevisionBaseList = x_oMobileOrderThreePartyRevisionBaseList.OrderByDescending(c => c.three_party).Select(c => c);
                break;
            }
            return x_oMobileOrderThreePartyRevisionBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderThreePartyRevisionEntity> FindAll()
        {
            MobileOrderThreePartyRevisionEntity[] _oMobileOrderThreePartyRevisionsArr=  MobileOrderThreePartyRevisionRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderThreePartyRevisionsArr != null)
            {
                IList<MobileOrderThreePartyRevisionEntity> _oMobileOrderThreePartyRevisionsList = (IList<MobileOrderThreePartyRevisionEntity>)_oMobileOrderThreePartyRevisionsArr;
                return _oMobileOrderThreePartyRevisionsList;
            }
            return new List<MobileOrderThreePartyRevisionEntity>();
        }
        
        public static IList<MobileOrderThreePartyRevisionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderThreePartyRevisionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderThreePartyRevisionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderThreePartyRevisionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileOrderThreePartyRevisionRS x_oShowField = new MobileOrderThreePartyRevisionRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderThreePartyRevisionRS x_oSortField=new MobileOrderThreePartyRevisionRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderThreePartyRevision.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileOrderThreePartyRevision.Para.mid, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderThreePartyRevisionRepositoryBase _oMobileOrderThreePartyRevisionRepositoryBase = new MobileOrderThreePartyRevisionRepositoryBase(GetDB());
            return _oMobileOrderThreePartyRevisionRepositoryBase.GetCount();
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


