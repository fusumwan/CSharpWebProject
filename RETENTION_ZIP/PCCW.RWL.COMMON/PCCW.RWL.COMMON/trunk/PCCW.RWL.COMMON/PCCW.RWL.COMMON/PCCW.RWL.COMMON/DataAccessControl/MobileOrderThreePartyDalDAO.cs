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
///-- Description:	<Description,Table :[MobileOrderThreeParty],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderThreePartyDalDAO{
        
        #region RS
        public class MobileOrderThreePartyRS
        {
            public bool n_bTpy_id = false;
            public bool n_bArthurization_person = false;
            public bool n_bContact_no = false;
            public bool n_bType = false;
            public bool n_bId_type = false;
            public bool n_bPlural = false;
            public bool n_bHkid = false;
            public bool n_bOrder_id = false;
            public bool n_bThree_party = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bTpy_id  || x_bSetShowALL || (MobileOrderThreeParty.Para.tpy_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTpy_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderThreeParty.Para.tpy_id);
                }
                if (this.n_bArthurization_person  || x_bSetShowALL || (MobileOrderThreeParty.Para.arthurization_person.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bArthurization_person=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderThreeParty.Para.arthurization_person);
                }
                if (this.n_bContact_no  || x_bSetShowALL || (MobileOrderThreeParty.Para.contact_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bContact_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderThreeParty.Para.contact_no);
                }
                if (this.n_bType  || x_bSetShowALL || (MobileOrderThreeParty.Para.type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bType=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderThreeParty.Para.type);
                }
                if (this.n_bId_type  || x_bSetShowALL || (MobileOrderThreeParty.Para.id_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderThreeParty.Para.id_type);
                }
                if (this.n_bPlural  || x_bSetShowALL || (MobileOrderThreeParty.Para.plural.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPlural=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderThreeParty.Para.plural);
                }
                if (this.n_bHkid  || x_bSetShowALL || (MobileOrderThreeParty.Para.hkid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHkid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderThreeParty.Para.hkid);
                }
                if (this.n_bOrder_id  || x_bSetShowALL || (MobileOrderThreeParty.Para.order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderThreeParty.Para.order_id);
                }
                if (this.n_bThree_party  || x_bSetShowALL || (MobileOrderThreeParty.Para.three_party.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bThree_party=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderThreeParty.Para.three_party);
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
        
        public MobileOrderThreePartyDalDAO(){
        }
        ~MobileOrderThreePartyDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderThreeParty.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderThreePartyEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderThreePartyRS x_oFieldsToReturn,MobileOrderThreePartyRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderThreePartyEntity> _oMobileOrderThreePartyList = new List<MobileOrderThreePartyEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderThreeParty _oMobileOrderThreeParty = new MobileOrderThreeParty();
                    if ((true).Equals(x_oFieldsToReturn.n_bTpy_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderThreeParty.Para.tpy_id])) { _oMobileOrderThreeParty.SetTpy_id((global::System.Nullable<long>)_oDATA[MobileOrderThreeParty.Para.tpy_id]); } else { _oMobileOrderThreeParty.SetTpy_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bArthurization_person))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderThreeParty.Para.arthurization_person])) { _oMobileOrderThreeParty.SetArthurization_person((string)_oDATA[MobileOrderThreeParty.Para.arthurization_person]); } else { _oMobileOrderThreeParty.SetArthurization_person(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bContact_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderThreeParty.Para.contact_no])) { _oMobileOrderThreeParty.SetContact_no((string)_oDATA[MobileOrderThreeParty.Para.contact_no]); } else { _oMobileOrderThreeParty.SetContact_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bType))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderThreeParty.Para.type])) { _oMobileOrderThreeParty.SetType((string)_oDATA[MobileOrderThreeParty.Para.type]); } else { _oMobileOrderThreeParty.SetType(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderThreeParty.Para.id_type])) { _oMobileOrderThreeParty.SetId_type((string)_oDATA[MobileOrderThreeParty.Para.id_type]); } else { _oMobileOrderThreeParty.SetId_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPlural))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderThreeParty.Para.plural])) { _oMobileOrderThreeParty.SetPlural((string)_oDATA[MobileOrderThreeParty.Para.plural]); } else { _oMobileOrderThreeParty.SetPlural(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHkid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderThreeParty.Para.hkid])) { _oMobileOrderThreeParty.SetHkid((string)_oDATA[MobileOrderThreeParty.Para.hkid]); } else { _oMobileOrderThreeParty.SetHkid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderThreeParty.Para.order_id])) { _oMobileOrderThreeParty.SetOrder_id((global::System.Nullable<int>)_oDATA[MobileOrderThreeParty.Para.order_id]); } else { _oMobileOrderThreeParty.SetOrder_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bThree_party))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderThreeParty.Para.three_party])) { _oMobileOrderThreeParty.SetThree_party((global::System.Nullable<bool>)_oDATA[MobileOrderThreeParty.Para.three_party]); } else { _oMobileOrderThreeParty.SetThree_party(null); }
                    }
                    _oMobileOrderThreePartyList.Add(_oMobileOrderThreeParty);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderThreePartyList;
            }
            return new List<MobileOrderThreePartyEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderThreePartyEntity> OrderBy(string x_sSort, IQueryable<MobileOrderThreePartyEntity> x_oMobileOrderThreePartyBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderThreeParty.Para.tpy_id:
                if(x_bAsc)
                    x_oMobileOrderThreePartyBaseList = x_oMobileOrderThreePartyBaseList.OrderBy(c => c.tpy_id).Select(c => c);
                else
                    x_oMobileOrderThreePartyBaseList = x_oMobileOrderThreePartyBaseList.OrderByDescending(c => c.tpy_id).Select(c => c);
                break;
                case MobileOrderThreeParty.Para.arthurization_person:
                if(x_bAsc)
                    x_oMobileOrderThreePartyBaseList = x_oMobileOrderThreePartyBaseList.OrderBy(c => c.arthurization_person).Select(c => c);
                else
                    x_oMobileOrderThreePartyBaseList = x_oMobileOrderThreePartyBaseList.OrderByDescending(c => c.arthurization_person).Select(c => c);
                break;
                case MobileOrderThreeParty.Para.contact_no:
                if(x_bAsc)
                    x_oMobileOrderThreePartyBaseList = x_oMobileOrderThreePartyBaseList.OrderBy(c => c.contact_no).Select(c => c);
                else
                    x_oMobileOrderThreePartyBaseList = x_oMobileOrderThreePartyBaseList.OrderByDescending(c => c.contact_no).Select(c => c);
                break;
                case MobileOrderThreeParty.Para.type:
                if(x_bAsc)
                    x_oMobileOrderThreePartyBaseList = x_oMobileOrderThreePartyBaseList.OrderBy(c => c.type).Select(c => c);
                else
                    x_oMobileOrderThreePartyBaseList = x_oMobileOrderThreePartyBaseList.OrderByDescending(c => c.type).Select(c => c);
                break;
                case MobileOrderThreeParty.Para.id_type:
                if(x_bAsc)
                    x_oMobileOrderThreePartyBaseList = x_oMobileOrderThreePartyBaseList.OrderBy(c => c.id_type).Select(c => c);
                else
                    x_oMobileOrderThreePartyBaseList = x_oMobileOrderThreePartyBaseList.OrderByDescending(c => c.id_type).Select(c => c);
                break;
                case MobileOrderThreeParty.Para.plural:
                if(x_bAsc)
                    x_oMobileOrderThreePartyBaseList = x_oMobileOrderThreePartyBaseList.OrderBy(c => c.plural).Select(c => c);
                else
                    x_oMobileOrderThreePartyBaseList = x_oMobileOrderThreePartyBaseList.OrderByDescending(c => c.plural).Select(c => c);
                break;
                case MobileOrderThreeParty.Para.hkid:
                if(x_bAsc)
                    x_oMobileOrderThreePartyBaseList = x_oMobileOrderThreePartyBaseList.OrderBy(c => c.hkid).Select(c => c);
                else
                    x_oMobileOrderThreePartyBaseList = x_oMobileOrderThreePartyBaseList.OrderByDescending(c => c.hkid).Select(c => c);
                break;
                case MobileOrderThreeParty.Para.order_id:
                if(x_bAsc)
                    x_oMobileOrderThreePartyBaseList = x_oMobileOrderThreePartyBaseList.OrderBy(c => c.order_id).Select(c => c);
                else
                    x_oMobileOrderThreePartyBaseList = x_oMobileOrderThreePartyBaseList.OrderByDescending(c => c.order_id).Select(c => c);
                break;
                case MobileOrderThreeParty.Para.three_party:
                if(x_bAsc)
                    x_oMobileOrderThreePartyBaseList = x_oMobileOrderThreePartyBaseList.OrderBy(c => c.three_party).Select(c => c);
                else
                    x_oMobileOrderThreePartyBaseList = x_oMobileOrderThreePartyBaseList.OrderByDescending(c => c.three_party).Select(c => c);
                break;
            }
            return x_oMobileOrderThreePartyBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderThreePartyEntity> FindAll()
        {
            MobileOrderThreePartyEntity[] _oMobileOrderThreePartysArr=  MobileOrderThreePartyRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderThreePartysArr != null)
            {
                IList<MobileOrderThreePartyEntity> _oMobileOrderThreePartysList = (IList<MobileOrderThreePartyEntity>)_oMobileOrderThreePartysArr;
                return _oMobileOrderThreePartysList;
            }
            return new List<MobileOrderThreePartyEntity>();
        }
        
        public static IList<MobileOrderThreePartyEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderThreePartyEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderThreePartyEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderThreePartyEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileOrderThreePartyRS x_oShowField = new MobileOrderThreePartyRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderThreePartyRS x_oSortField=new MobileOrderThreePartyRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderThreeParty.Para.tpy_id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileOrderThreeParty.Para.tpy_id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderThreePartyRepositoryBase _oMobileOrderThreePartyRepositoryBase = new MobileOrderThreePartyRepositoryBase(GetDB());
            return _oMobileOrderThreePartyRepositoryBase.GetCount();
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


