using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;


///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2011-02-28>
///-- Description:	<Description,Class :SundayActivation, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class SundayActivation : IDisposable
    {

        protected string n_sID_NO_TYPE = global::System.String.Empty;
        #region ID_NO_TYPE
        public string ID_NO_TYPE
        {
            get
            {

                return this.n_sID_NO_TYPE;
            }
            set
            {
                this.n_sID_NO_TYPE = value;
            }
        }
        #endregion ID_NO_TYPE


        protected string n_sVAS_PRICE9 = global::System.String.Empty;
        #region VAS_PRICE9
        public string VAS_PRICE9
        {
            get
            {
                return this.n_sVAS_PRICE9;
            }
            set
            {
                this.n_sVAS_PRICE9 = value;
            }
        }
        #endregion VAS_PRICE9


        protected string n_sVAS_PRICE13 = global::System.String.Empty;
        #region VAS_PRICE13
        public string VAS_PRICE13
        {
            get
            {
                return this.n_sVAS_PRICE13;
            }
            set
            {
                this.n_sVAS_PRICE13 = value;
            }
        }
        #endregion VAS_PRICE13


        protected string n_sBIL_DISTRICT = global::System.String.Empty;
        #region BIL_DISTRICT
        public string BIL_DISTRICT
        {
            get
            {
                return this.n_sBIL_DISTRICT;
            }
            set
            {
                this.n_sBIL_DISTRICT = value;
            }
        }
        #endregion BIL_DISTRICT


        protected string n_sIMEI = global::System.String.Empty;
        #region IMEI
        public string IMEI
        {
            get
            {
                return this.n_sIMEI;
            }
            set
            {
                this.n_sIMEI = value;
            }
        }
        #endregion IMEI


        protected string n_sHS_C_HOLDER_NAME2 = global::System.String.Empty;
        #region HS_C_HOLDER_NAME2
        public string HS_C_HOLDER_NAME2
        {
            get
            {
                return this.n_sHS_C_HOLDER_NAME2;
            }
            set
            {
                this.n_sHS_C_HOLDER_NAME2 = value;
            }
        }
        #endregion HS_C_HOLDER_NAME2


        protected string n_sBILL_ADDRESS_1 = global::System.String.Empty;
        #region BILL_ADDRESS_1
        public string BILL_ADDRESS_1
        {
            get
            {
                return this.n_sBILL_ADDRESS_1;
            }
            set
            {
                this.n_sBILL_ADDRESS_1 = value;
            }
        }
        #endregion BILL_ADDRESS_1


        protected string n_sHS_EXP_2 = global::System.String.Empty;
        #region HS_EXP_2
        public string HS_EXP_2
        {
            get
            {
                return this.n_sHS_EXP_2;
            }
            set
            {
                this.n_sHS_EXP_2 = value;
            }
        }
        #endregion HS_EXP_2


        protected string n_sBANK_NAME = global::System.String.Empty;
        #region BANK_NAME
        public string BANK_NAME
        {
            get
            {
                return this.n_sBANK_NAME;
            }
            set
            {
                this.n_sBANK_NAME = value;
            }
        }
        #endregion BANK_NAME


        protected string n_sMP_CARD_OWNER = global::System.String.Empty;
        #region MP_CARD_OWNER
        public string MP_CARD_OWNER
        {
            get
            {
                return this.n_sMP_CARD_OWNER;
            }
            set
            {
                this.n_sMP_CARD_OWNER = value;
            }
        }
        #endregion MP_CARD_OWNER


        protected string n_sEXPIRY_DATE = global::System.String.Empty;
        #region EXPIRY_DATE
        public string EXPIRY_DATE
        {
            get
            {
                return this.n_sEXPIRY_DATE;
            }
            set
            {
                this.n_sEXPIRY_DATE = value;
            }
        }
        #endregion EXPIRY_DATE


        protected string n_sEMAIL_SUPPRESS = global::System.String.Empty;
        #region EMAIL_SUPPRESS
        public string EMAIL_SUPPRESS
        {
            get
            {
                return this.n_sEMAIL_SUPPRESS;
            }
            set
            {
                this.n_sEMAIL_SUPPRESS = value;
            }
        }
        #endregion EMAIL_SUPPRESS


        protected string n_sHS_C_HOLDER_INSTAL = global::System.String.Empty;
        #region HS_C_HOLDER_INSTAL
        public string HS_C_HOLDER_INSTAL
        {
            get
            {
                return this.n_sHS_C_HOLDER_INSTAL;
            }
            set
            {
                this.n_sHS_C_HOLDER_INSTAL = value;
            }
        }
        #endregion HS_C_HOLDER_INSTAL


        protected string n_sEMAIL = global::System.String.Empty;
        #region EMAIL
        public string EMAIL
        {
            get
            {
                return this.n_sEMAIL;
            }
            set
            {
                this.n_sEMAIL = value;
            }
        }
        #endregion EMAIL


        protected string n_sVAS_PRICE19 = global::System.String.Empty;
        #region VAS_PRICE19
        public string VAS_PRICE19
        {
            get
            {
                return this.n_sVAS_PRICE19;
            }
            set
            {
                this.n_sVAS_PRICE19 = value;
            }
        }
        #endregion VAS_PRICE19


        protected string n_sMP_C_HOLDER_NAME = global::System.String.Empty;
        #region MP_C_HOLDER_NAME
        public string MP_C_HOLDER_NAME
        {
            get
            {
                return this.n_sMP_C_HOLDER_NAME;
            }
            set
            {
                this.n_sMP_C_HOLDER_NAME = value;
            }
        }
        #endregion MP_C_HOLDER_NAME


        protected string n_sMOBILE_NO = global::System.String.Empty;
        #region MOBILE_NO
        public string MOBILE_NO
        {
            get
            {
                return this.n_sMOBILE_NO;
            }
            set
            {
                this.n_sMOBILE_NO = value;
            }
        }
        #endregion MOBILE_NO


        protected string n_sMP_3_PARTY_NAME = global::System.String.Empty;
        #region MP_3_PARTY_NAME
        public string MP_3_PARTY_NAME
        {
            get
            {
                return this.n_sMP_3_PARTY_NAME;
            }
            set
            {
                this.n_sMP_3_PARTY_NAME = value;
            }
        }
        #endregion MP_3_PARTY_NAME


        protected string n_sRATE_PLAN = global::System.String.Empty;
        #region RATE_PLAN
        public string RATE_PLAN
        {
            get
            {
                return this.n_sRATE_PLAN;
            }
            set
            {
                this.n_sRATE_PLAN = value;
            }
        }
        #endregion RATE_PLAN


        protected string n_sOLD_SUB_NAME_MNP = global::System.String.Empty;
        #region OLD_SUB_NAME_MNP
        public string OLD_SUB_NAME_MNP
        {
            get
            {
                return this.n_sOLD_SUB_NAME_MNP;
            }
            set
            {
                this.n_sOLD_SUB_NAME_MNP = value;
            }
        }
        #endregion OLD_SUB_NAME_MNP


        protected global::System.Nullable<DateTime> n_dCREATE_DATE = null;
        #region CREATE_DATE
        public global::System.Nullable<DateTime> CREATE_DATE
        {
            get
            {
                return this.n_dCREATE_DATE;
            }
            set
            {
                this.n_dCREATE_DATE = value;
            }
        }
        #endregion CREATE_DATE


        protected string n_sDUMMY2 = string.Empty;
        #region DUMMY2
        public string DUMMY2
        {
            get
            {
                return this.n_sDUMMY2;
            }
            set
            {
                this.n_sDUMMY2 = value;
            }
        }
        #endregion DUMMY2


        protected string n_sVAS_NAME18 = global::System.String.Empty;
        #region VAS_NAME18
        public string VAS_NAME18
        {
            get
            {
                return this.n_sVAS_NAME18;
            }
            set
            {
                this.n_sVAS_NAME18 = value;
            }
        }
        #endregion VAS_NAME18


        protected string n_sCONTACT_PERSON = global::System.String.Empty;
        #region CONTACT_PERSON
        public string CONTACT_PERSON
        {
            get
            {
                return this.n_sCONTACT_PERSON;
            }
            set
            {
                this.n_sCONTACT_PERSON = value;
            }
        }
        #endregion CONTACT_PERSON


        protected string n_sVAS_PRICE5 = global::System.String.Empty;
        #region VAS_PRICE5
        public string VAS_PRICE5
        {
            get
            {
                return this.n_sVAS_PRICE5;
            }
            set
            {
                this.n_sVAS_PRICE5 = value;
            }
        }
        #endregion VAS_PRICE5


        protected string n_sIDD_ROAMING = global::System.String.Empty;
        #region IDD_ROAMING
        public string IDD_ROAMING
        {
            get
            {
                return this.n_sIDD_ROAMING;
            }
            set
            {
                this.n_sIDD_ROAMING = value;
            }
        }
        #endregion IDD_ROAMING


        protected string n_sVAS_NAME17 = global::System.String.Empty;
        #region VAS_NAME17
        public string VAS_NAME17
        {
            get
            {
                return this.n_sVAS_NAME17;
            }
            set
            {
                this.n_sVAS_NAME17 = value;
            }
        }
        #endregion VAS_NAME17


        protected string n_sVAS_PRICE18 = global::System.String.Empty;
        #region VAS_PRICE18
        public string VAS_PRICE18
        {
            get
            {
                return this.n_sVAS_PRICE18;
            }
            set
            {
                this.n_sVAS_PRICE18 = value;
            }
        }
        #endregion VAS_PRICE18


        protected string n_sREFERENCENO = global::System.String.Empty;
        #region REFERENCENO
        public string REFERENCENO
        {
            get
            {
                return this.n_sREFERENCENO;
            }
            set
            {
                this.n_sREFERENCENO = value;
            }
        }
        #endregion REFERENCENO


        protected string n_sVAS_PRICE3 = global::System.String.Empty;
        #region VAS_PRICE3
        public string VAS_PRICE3
        {
            get
            {
                return this.n_sVAS_PRICE3;
            }
            set
            {
                this.n_sVAS_PRICE3 = value;
            }
        }
        #endregion VAS_PRICE3


        protected string n_sPAYMENT_LIMIT = global::System.String.Empty;
        #region PAYMENT_LIMIT
        public string PAYMENT_LIMIT
        {
            get
            {
                return this.n_sPAYMENT_LIMIT;
            }
            set
            {
                this.n_sPAYMENT_LIMIT = value;
            }
        }
        #endregion PAYMENT_LIMIT


        protected string n_sMP_3_PARTY_ID = global::System.String.Empty;
        #region MP_3_PARTY_ID
        public string MP_3_PARTY_ID
        {
            get
            {
                return this.n_sMP_3_PARTY_ID;
            }
            set
            {
                this.n_sMP_3_PARTY_ID = value;
            }
        }
        #endregion MP_3_PARTY_ID


        protected string n_sN2_REGISTERED_NAME = global::System.String.Empty;
        #region N2_REGISTERED_NAME
        public string N2_REGISTERED_NAME
        {
            get
            {
                return this.n_sN2_REGISTERED_NAME;
            }
            set
            {
                this.n_sN2_REGISTERED_NAME = value;
            }
        }
        #endregion N2_REGISTERED_NAME


        protected string n_sD_MAILL_SUPPRESS = global::System.String.Empty;
        #region D_MAILL_SUPPRESS
        public string D_MAILL_SUPPRESS
        {
            get
            {
                return this.n_sD_MAILL_SUPPRESS;
            }
            set
            {
                this.n_sD_MAILL_SUPPRESS = value;
            }
        }
        #endregion D_MAILL_SUPPRESS


        protected string n_sAUTO_PAY = global::System.String.Empty;
        #region AUTO_PAY
        public string AUTO_PAY
        {
            get
            {
                return this.n_sAUTO_PAY;
            }
            set
            {
                this.n_sAUTO_PAY = value;
            }
        }
        #endregion AUTO_PAY


        protected string n_sIDD_0060 = global::System.String.Empty;
        #region IDD_0060
        public string IDD_0060
        {
            get
            {
                return this.n_sIDD_0060;
            }
            set
            {
                this.n_sIDD_0060 = value;
            }
        }
        #endregion IDD_0060


        protected string n_sCUSTOMER_GROUP = global::System.String.Empty;
        #region CUSTOMER_GROUP
        public string CUSTOMER_GROUP
        {
            get
            {
                return this.n_sCUSTOMER_GROUP;
            }
            set
            {
                this.n_sCUSTOMER_GROUP = value;
            }
        }
        #endregion CUSTOMER_GROUP


        protected string n_sVAS_PRICE10 = global::System.String.Empty;
        #region VAS_PRICE10
        public string VAS_PRICE10
        {
            get
            {
                return this.n_sVAS_PRICE10;
            }
            set
            {
                this.n_sVAS_PRICE10 = value;
            }
        }
        #endregion VAS_PRICE10


        protected string n_sVAS_NAME12 = global::System.String.Empty;
        #region VAS_NAME12
        public string VAS_NAME12
        {
            get
            {
                return this.n_sVAS_NAME12;
            }
            set
            {
                this.n_sVAS_NAME12 = value;
            }
        }
        #endregion VAS_NAME12


        protected string n_sVAS_PRICE4 = global::System.String.Empty;
        #region VAS_PRICE4
        public string VAS_PRICE4
        {
            get
            {
                return this.n_sVAS_PRICE4;
            }
            set
            {
                this.n_sVAS_PRICE4 = value;
            }
        }
        #endregion VAS_PRICE4


        protected string n_sVAS_NAME13 = global::System.String.Empty;
        #region VAS_NAME13
        public string VAS_NAME13
        {
            get
            {
                return this.n_sVAS_NAME13;
            }
            set
            {
                this.n_sVAS_NAME13 = value;
            }
        }
        #endregion VAS_NAME13


        protected string n_sHS_PAY_AMT_INSTAL = global::System.String.Empty;
        #region HS_PAY_AMT_INSTAL
        public string HS_PAY_AMT_INSTAL
        {
            get
            {
                return this.n_sHS_PAY_AMT_INSTAL;
            }
            set
            {
                this.n_sHS_PAY_AMT_INSTAL = value;
            }
        }
        #endregion HS_PAY_AMT_INSTAL


        protected string n_sSEC_SERVICE_PASSWORD = global::System.String.Empty;
        #region SEC_SERVICE_PASSWORD
        public string SEC_SERVICE_PASSWORD
        {
            get
            {
                return this.n_sSEC_SERVICE_PASSWORD;
            }
            set
            {
                this.n_sSEC_SERVICE_PASSWORD = value;
            }
        }
        #endregion SEC_SERVICE_PASSWORD


        protected string n_sNETVIGATOR_FSA_NO = global::System.String.Empty;
        #region NETVIGATOR_FSA_NO
        public string NETVIGATOR_FSA_NO
        {
            get
            {
                return this.n_sNETVIGATOR_FSA_NO;
            }
            set
            {
                this.n_sNETVIGATOR_FSA_NO = value;
            }
        }
        #endregion NETVIGATOR_FSA_NO


        protected string n_sSTUDENT_HK_ID = global::System.String.Empty;
        #region STUDENT_HK_ID
        public string STUDENT_HK_ID
        {
            get
            {
                return this.n_sSTUDENT_HK_ID;
            }
            set
            {
                this.n_sSTUDENT_HK_ID = value;
            }
        }
        #endregion STUDENT_HK_ID


        protected string n_sVOICE_LANGUAGE = global::System.String.Empty;
        #region VOICE_LANGUAGE
        public string VOICE_LANGUAGE
        {
            get
            {
                return this.n_sVOICE_LANGUAGE;
            }
            set
            {
                this.n_sVOICE_LANGUAGE = value;
            }
        }
        #endregion VOICE_LANGUAGE


        protected string n_sMP_APP_CODE = global::System.String.Empty;
        #region MP_APP_CODE
        public string MP_APP_CODE
        {
            get
            {
                return this.n_sMP_APP_CODE;
            }
            set
            {
                this.n_sMP_APP_CODE = value;
            }
        }
        #endregion MP_APP_CODE


        protected string n_sEMAIL_BILL = global::System.String.Empty;
        #region EMAIL_BILL
        public string EMAIL_BILL
        {
            get
            {
                return this.n_sEMAIL_BILL;
            }
            set
            {
                this.n_sEMAIL_BILL = value;
            }
        }
        #endregion EMAIL_BILL


        protected string n_sCREDIT_CARD_TYPE = global::System.String.Empty;
        #region CREDIT_CARD_TYPE
        public string CREDIT_CARD_TYPE
        {
            get
            {
                return this.n_sCREDIT_CARD_TYPE;
            }
            set
            {
                this.n_sCREDIT_CARD_TYPE = value;
            }
        }
        #endregion CREDIT_CARD_TYPE


        protected string n_sBANK_ACCOUNT = global::System.String.Empty;
        #region BANK_ACCOUNT
        public string BANK_ACCOUNT
        {
            get
            {
                return this.n_sBANK_ACCOUNT;
            }
            set
            {
                this.n_sBANK_ACCOUNT = value;
            }
        }
        #endregion BANK_ACCOUNT


        protected string n_sREG_ST_NAME = global::System.String.Empty;
        #region REG_ST_NAME
        public string REG_ST_NAME
        {
            get
            {
                return this.n_sREG_ST_NAME;
            }
            set
            {
                this.n_sREG_ST_NAME = value;
            }
        }
        #endregion REG_ST_NAME


        protected string n_sCHINA_ROAMING = global::System.String.Empty;
        #region CHINA_ROAMING
        public string CHINA_ROAMING
        {
            get
            {
                return this.n_sCHINA_ROAMING;
            }
            set
            {
                this.n_sCHINA_ROAMING = value;
            }
        }
        #endregion CHINA_ROAMING


        protected global::System.Nullable<DateTime> n_dDUMMY3 = null;
        #region DUMMY3
        public global::System.Nullable<DateTime> DUMMY3
        {
            get
            {
                return this.n_dDUMMY3;
            }
            set
            {
                this.n_dDUMMY3 = value;
            }
        }
        #endregion DUMMY3


        protected string n_sHS_EXP_INSTAL = global::System.String.Empty;
        #region HS_EXP_INSTAL
        public string HS_EXP_INSTAL
        {
            get
            {
                return this.n_sHS_EXP_INSTAL;
            }
            set
            {
                this.n_sHS_EXP_INSTAL = value;
            }
        }
        #endregion HS_EXP_INSTAL


        protected string n_sACTUAL_USER = global::System.String.Empty;
        #region ACTUAL_USER
        public string ACTUAL_USER
        {
            get
            {
                return this.n_sACTUAL_USER;
            }
            set
            {
                this.n_sACTUAL_USER = value;
            }
        }
        #endregion ACTUAL_USER


        protected string n_sTICKET_NO = global::System.String.Empty;
        #region TICKET_NO
        public string TICKET_NO
        {
            get
            {
                return this.n_sTICKET_NO;
            }
            set
            {
                this.n_sTICKET_NO = value;
            }
        }
        #endregion TICKET_NO


        protected string n_sVAS_NAME14 = global::System.String.Empty;
        #region VAS_NAME14
        public string VAS_NAME14
        {
            get
            {
                return this.n_sVAS_NAME14;
            }
            set
            {
                this.n_sVAS_NAME14 = value;
            }
        }
        #endregion VAS_NAME14


        protected string n_sCUT_OVER_WINDOW = global::System.String.Empty;
        #region CUT_OVER_WINDOW
        public string CUT_OVER_WINDOW
        {
            get
            {
                return this.n_sCUT_OVER_WINDOW;
            }
            set
            {
                this.n_sCUT_OVER_WINDOW = value;
            }
        }
        #endregion CUT_OVER_WINDOW


        protected string n_sPREPAID_SIM_TO_POSTPAID = global::System.String.Empty;
        #region PREPAID_SIM_TO_POSTPAID
        public string PREPAID_SIM_TO_POSTPAID
        {
            get
            {
                return this.n_sPREPAID_SIM_TO_POSTPAID;
            }
            set
            {
                this.n_sPREPAID_SIM_TO_POSTPAID = value;
            }
        }
        #endregion PREPAID_SIM_TO_POSTPAID


        protected string n_sCUT_OVER_DATE_MNP = global::System.String.Empty;
        #region CUT_OVER_DATE_MNP
        public string CUT_OVER_DATE_MNP
        {
            get
            {
                return this.n_sCUT_OVER_DATE_MNP;
            }
            set
            {
                this.n_sCUT_OVER_DATE_MNP = value;
            }
        }
        #endregion CUT_OVER_DATE_MNP


        protected global::System.Nullable<DateTime> n_dHS_PAYMENT_TYPE2 = null;
        #region HS_PAYMENT_TYPE2
        public global::System.Nullable<DateTime> HS_PAYMENT_TYPE2
        {
            get
            {
                return this.n_dHS_PAYMENT_TYPE2;
            }
            set
            {
                this.n_dHS_PAYMENT_TYPE2 = value;
            }
        }
        #endregion HS_PAYMENT_TYPE2


        protected string n_sMP_AMOUNT = global::System.String.Empty;
        #region MP_AMOUNT
        public string MP_AMOUNT
        {
            get
            {
                return this.n_sMP_AMOUNT;
            }
            set
            {
                this.n_sMP_AMOUNT = value;
            }
        }
        #endregion MP_AMOUNT


        protected string n_sSEC_SERVICE_NO = global::System.String.Empty;
        #region SEC_SERVICE_NO
        public string SEC_SERVICE_NO
        {
            get
            {
                return this.n_sSEC_SERVICE_NO;
            }
            set
            {
                this.n_sSEC_SERVICE_NO = value;
            }
        }
        #endregion SEC_SERVICE_NO


        protected string n_sVAS_PRICE14 = global::System.String.Empty;
        #region VAS_PRICE14
        public string VAS_PRICE14
        {
            get
            {
                return this.n_sVAS_PRICE14;
            }
            set
            {
                this.n_sVAS_PRICE14 = value;
            }
        }
        #endregion VAS_PRICE14


        protected string n_sREG_BLOCK = global::System.String.Empty;
        #region REG_BLOCK
        public string REG_BLOCK
        {
            get
            {
                return this.n_sREG_BLOCK;
            }
            set
            {
                this.n_sREG_BLOCK = value;
            }
        }
        #endregion REG_BLOCK


        protected string n_sBIL_BUILDING = global::System.String.Empty;
        #region BIL_BUILDING
        public string BIL_BUILDING
        {
            get
            {
                return this.n_sBIL_BUILDING;
            }
            set
            {
                this.n_sBIL_BUILDING = value;
            }
        }
        #endregion BIL_BUILDING


        protected string n_sVAS_NAME5 = global::System.String.Empty;
        #region VAS_NAME5
        public string VAS_NAME5
        {
            get
            {
                return this.n_sVAS_NAME5;
            }
            set
            {
                this.n_sVAS_NAME5 = value;
            }
        }
        #endregion VAS_NAME5


        protected string n_sID_NO = global::System.String.Empty;
        #region ID_NO
        public string ID_NO
        {
            get
            {
                return this.n_sID_NO;
            }
            set
            {
                this.n_sID_NO = value;
            }
        }
        #endregion ID_NO


        protected string n_sSEC_LANGUAGE = global::System.String.Empty;
        #region SEC_LANGUAGE
        public string SEC_LANGUAGE
        {
            get
            {
                return this.n_sSEC_LANGUAGE;
            }
            set
            {
                this.n_sSEC_LANGUAGE = value;
            }
        }
        #endregion SEC_LANGUAGE


        protected string n_sVAS_PRICE7 = global::System.String.Empty;
        #region VAS_PRICE7
        public string VAS_PRICE7
        {
            get
            {
                return this.n_sVAS_PRICE7;
            }
            set
            {
                this.n_sVAS_PRICE7 = value;
            }
        }
        #endregion VAS_PRICE7


        protected string n_sREG_ESTATE = global::System.String.Empty;
        #region REG_ESTATE
        public string REG_ESTATE
        {
            get
            {
                return this.n_sREG_ESTATE;
            }
            set
            {
                this.n_sREG_ESTATE = value;
            }
        }
        #endregion REG_ESTATE


        protected string n_sBILL_ADDRESS_3 = global::System.String.Empty;
        #region BILL_ADDRESS_3
        public string BILL_ADDRESS_3
        {
            get
            {
                return this.n_sBILL_ADDRESS_3;
            }
            set
            {
                this.n_sBILL_ADDRESS_3 = value;
            }
        }
        #endregion BILL_ADDRESS_3


        protected string n_sHS_APP_CODE_INSTAL = global::System.String.Empty;
        #region HS_APP_CODE_INSTAL
        public string HS_APP_CODE_INSTAL
        {
            get
            {
                return this.n_sHS_APP_CODE_INSTAL;
            }
            set
            {
                this.n_sHS_APP_CODE_INSTAL = value;
            }
        }
        #endregion HS_APP_CODE_INSTAL


        protected string n_sFAX = global::System.String.Empty;
        #region FAX
        public string FAX
        {
            get
            {
                return this.n_sFAX;
            }
            set
            {
                this.n_sFAX = value;
            }
        }
        #endregion FAX


        protected string n_sBIL_FLOOR = global::System.String.Empty;
        #region BIL_FLOOR
        public string BIL_FLOOR
        {
            get
            {
                return this.n_sBIL_FLOOR;
            }
            set
            {
                this.n_sBIL_FLOOR = value;
            }
        }
        #endregion BIL_FLOOR


        protected string n_sOLD_SUB_HK_ID = global::System.String.Empty;
        #region OLD_SUB_HK_ID
        public string OLD_SUB_HK_ID
        {
            get
            {
                return this.n_sOLD_SUB_HK_ID;
            }
            set
            {
                this.n_sOLD_SUB_HK_ID = value;
            }
        }
        #endregion OLD_SUB_HK_ID


        protected string n_sVAS_PRICE11 = global::System.String.Empty;
        #region VAS_PRICE11
        public string VAS_PRICE11
        {
            get
            {
                return this.n_sVAS_PRICE11;
            }
            set
            {
                this.n_sVAS_PRICE11 = value;
            }
        }
        #endregion VAS_PRICE11


        protected string n_sMP_CARDNO = global::System.String.Empty;
        #region MP_CARDNO
        public string MP_CARDNO
        {
            get
            {
                return this.n_sMP_CARDNO;
            }
            set
            {
                this.n_sMP_CARDNO = value;
            }
        }
        #endregion MP_CARDNO


        protected string n_sADDRESS_1 = global::System.String.Empty;
        #region ADDRESS_1
        public string ADDRESS_1
        {
            get
            {
                return this.n_sADDRESS_1;
            }
            set
            {
                this.n_sADDRESS_1 = value;
            }
        }
        #endregion ADDRESS_1


        protected string n_sADDRESS_2 = global::System.String.Empty;
        #region ADDRESS_2
        public string ADDRESS_2
        {
            get
            {
                return this.n_sADDRESS_2;
            }
            set
            {
                this.n_sADDRESS_2 = value;
            }
        }
        #endregion ADDRESS_2


        protected string n_sADDRESS_3 = global::System.String.Empty;
        #region ADDRESS_3
        public string ADDRESS_3
        {
            get
            {
                return this.n_sADDRESS_3;
            }
            set
            {
                this.n_sADDRESS_3 = value;
            }
        }
        #endregion ADDRESS_3


        protected string n_sREG_FLOOR = global::System.String.Empty;
        #region REG_FLOOR
        public string REG_FLOOR
        {
            get
            {
                return this.n_sREG_FLOOR;
            }
            set
            {
                this.n_sREG_FLOOR = value;
            }
        }
        #endregion REG_FLOOR


        protected string n_sFEATURE = global::System.String.Empty;
        #region FEATURE
        public string FEATURE
        {
            get
            {
                return this.n_sFEATURE;
            }
            set
            {
                this.n_sFEATURE = value;
            }
        }
        #endregion FEATURE


        protected global::System.Nullable<DateTime> n_dBIL_AREA = null;
        #region BIL_AREA
        public global::System.Nullable<DateTime> BIL_AREA
        {
            get
            {
                return this.n_dBIL_AREA;
            }
            set
            {
                this.n_dBIL_AREA = value;
            }
        }
        #endregion BIL_AREA


        protected string n_sVAS_PRICE6 = global::System.String.Empty;
        #region VAS_PRICE6
        public string VAS_PRICE6
        {
            get
            {
                return this.n_sVAS_PRICE6;
            }
            set
            {
                this.n_sVAS_PRICE6 = value;
            }
        }
        #endregion VAS_PRICE6


        protected string n_sJOINT_PROMOTION_CODE = global::System.String.Empty;
        #region JOINT_PROMOTION_CODE
        public string JOINT_PROMOTION_CODE
        {
            get
            {
                return this.n_sJOINT_PROMOTION_CODE;
            }
            set
            {
                this.n_sJOINT_PROMOTION_CODE = value;
            }
        }
        #endregion JOINT_PROMOTION_CODE


        protected string n_sOFFICE_TEL = global::System.String.Empty;
        #region OFFICE_TEL
        public string OFFICE_TEL
        {
            get
            {
                return this.n_sOFFICE_TEL;
            }
            set
            {
                this.n_sOFFICE_TEL = value;
            }
        }
        #endregion OFFICE_TEL


        protected string n_sVAS_PRICE16 = global::System.String.Empty;
        #region VAS_PRICE16
        public string VAS_PRICE16
        {
            get
            {
                return this.n_sVAS_PRICE16;
            }
            set
            {
                this.n_sVAS_PRICE16 = value;
            }
        }
        #endregion VAS_PRICE16


        protected string n_sBIL_BLOCK = global::System.String.Empty;
        #region BIL_BLOCK
        public string BIL_BLOCK
        {
            get
            {
                return this.n_sBIL_BLOCK;
            }
            set
            {
                this.n_sBIL_BLOCK = value;
            }
        }
        #endregion BIL_BLOCK


        protected string n_sHS_CARD_NO2 = global::System.String.Empty;
        #region HS_CARD_NO2
        public string HS_CARD_NO2
        {
            get
            {
                return this.n_sHS_CARD_NO2;
            }
            set
            {
                this.n_sHS_CARD_NO2 = value;
            }
        }
        #endregion HS_CARD_NO2


        protected string n_sEXTG_AC_TYPE = global::System.String.Empty;
        #region EXTG_AC_TYPE
        public string EXTG_AC_TYPE
        {
            get
            {
                return this.n_sEXTG_AC_TYPE;
            }
            set
            {
                this.n_sEXTG_AC_TYPE = value;
            }
        }
        #endregion EXTG_AC_TYPE


        protected string n_sVAS_NAME19 = global::System.String.Empty;
        #region VAS_NAME19
        public string VAS_NAME19
        {
            get
            {
                return this.n_sVAS_NAME19;
            }
            set
            {
                this.n_sVAS_NAME19 = value;
            }
        }
        #endregion VAS_NAME19


        protected string n_sTELEMARKETING_SUPPRESS = global::System.String.Empty;
        #region TELEMARKETING_SUPPRESS
        public string TELEMARKETING_SUPPRESS
        {
            get
            {
                return this.n_sTELEMARKETING_SUPPRESS;
            }
            set
            {
                this.n_sTELEMARKETING_SUPPRESS = value;
            }
        }
        #endregion TELEMARKETING_SUPPRESS


        protected string n_sHS_PERIOD_INSTAL = global::System.String.Empty;
        #region HS_PERIOD_INSTAL
        public string HS_PERIOD_INSTAL
        {
            get
            {
                return this.n_sHS_PERIOD_INSTAL;
            }
            set
            {
                this.n_sHS_PERIOD_INSTAL = value;
            }
        }
        #endregion HS_PERIOD_INSTAL


        protected string n_sBIL_FLAT = global::System.String.Empty;
        #region BIL_FLAT
        public string BIL_FLAT
        {
            get
            {
                return this.n_sBIL_FLAT;
            }
            set
            {
                this.n_sBIL_FLAT = value;
            }
        }
        #endregion BIL_FLAT


        protected string n_sSMARK_EXP = global::System.String.Empty;
        #region SMARK_EXP
        public string SMARK_EXP
        {
            get
            {
                return this.n_sSMARK_EXP;
            }
            set
            {
                this.n_sSMARK_EXP = value;
            }
        }
        #endregion SMARK_EXP


        protected string n_sSMS_LANGUAGE = global::System.String.Empty;
        #region SMS_LANGUAGE
        public string SMS_LANGUAGE
        {
            get
            {
                return this.n_sSMS_LANGUAGE;
            }
            set
            {
                this.n_sSMS_LANGUAGE = value;
            }
        }
        #endregion SMS_LANGUAGE


        protected string n_sVAS_PRICE20 = global::System.String.Empty;
        #region VAS_PRICE20
        public string VAS_PRICE20
        {
            get
            {
                return this.n_sVAS_PRICE20;
            }
            set
            {
                this.n_sVAS_PRICE20 = value;
            }
        }
        #endregion VAS_PRICE20


        protected string n_sVAS_NAME11 = global::System.String.Empty;
        #region VAS_NAME11
        public string VAS_NAME11
        {
            get
            {
                return this.n_sVAS_NAME11;
            }
            set
            {
                this.n_sVAS_NAME11 = value;
            }
        }
        #endregion VAS_NAME11


        protected string n_sTRADE_FIELD_2 = global::System.String.Empty;
        #region TRADE_FIELD_2
        public string TRADE_FIELD_2
        {
            get
            {
                return this.n_sTRADE_FIELD_2;
            }
            set
            {
                this.n_sTRADE_FIELD_2 = value;
            }
        }
        #endregion TRADE_FIELD_2


        protected string n_sVAS_NAME10 = global::System.String.Empty;
        #region VAS_NAME10
        public string VAS_NAME10
        {
            get
            {
                return this.n_sVAS_NAME10;
            }
            set
            {
                this.n_sVAS_NAME10 = value;
            }
        }
        #endregion VAS_NAME10


        protected string n_sTRADE_FIELD_1 = global::System.String.Empty;
        #region TRADE_FIELD_1
        public string TRADE_FIELD_1
        {
            get
            {
                return this.n_sTRADE_FIELD_1;
            }
            set
            {
                this.n_sTRADE_FIELD_1 = value;
            }
        }
        #endregion TRADE_FIELD_1


        protected string n_sVAS_PRICE12 = global::System.String.Empty;
        #region VAS_PRICE12
        public string VAS_PRICE12
        {
            get
            {
                return this.n_sVAS_PRICE12;
            }
            set
            {
                this.n_sVAS_PRICE12 = value;
            }
        }
        #endregion VAS_PRICE12


        protected string n_dDUMMY1 = null;
        #region DUMMY1
        public string DUMMY1
        {
            get
            {
                return this.n_dDUMMY1;
            }
            set
            {
                this.n_dDUMMY1 = value;
            }
        }
        #endregion DUMMY1


        protected string n_sEXTG_AC_NO = global::System.String.Empty;
        #region EXTG_AC_NO
        public string EXTG_AC_NO
        {
            get
            {
                return this.n_sEXTG_AC_NO;
            }
            set
            {
                this.n_sEXTG_AC_NO = value;
            }
        }
        #endregion EXTG_AC_NO


        protected string n_sBILL_ADDRESS_2 = global::System.String.Empty;
        #region BILL_ADDRESS_2
        public string BILL_ADDRESS_2
        {
            get
            {
                return this.n_sBILL_ADDRESS_2;
            }
            set
            {
                this.n_sBILL_ADDRESS_2 = value;
            }
        }
        #endregion BILL_ADDRESS_2


        protected global::System.Nullable<DateTime> n_dSMARK_EXP_DATE = null;
        #region SMARK_EXP_DATE
        public global::System.Nullable<DateTime> SMARK_EXP_DATE
        {
            get
            {
                return this.n_dSMARK_EXP_DATE;
            }
            set
            {
                this.n_dSMARK_EXP_DATE = value;
            }
        }
        #endregion SMARK_EXP_DATE


        protected string n_sVAS_NAME9 = global::System.String.Empty;
        #region VAS_NAME9
        public string VAS_NAME9
        {
            get
            {
                return this.n_sVAS_NAME9;
            }
            set
            {
                this.n_sVAS_NAME9 = value;
            }
        }
        #endregion VAS_NAME9


        protected string n_sREG_ST_NO = global::System.String.Empty;
        #region REG_ST_NO
        public string REG_ST_NO
        {
            get
            {
                return this.n_sREG_ST_NO;
            }
            set
            {
                this.n_sREG_ST_NO = value;
            }
        }
        #endregion REG_ST_NO


        protected string n_sSEC_GREETING = global::System.String.Empty;
        #region SEC_GREETING
        public string SEC_GREETING
        {
            get
            {
                return this.n_sSEC_GREETING;
            }
            set
            {
                this.n_sSEC_GREETING = value;
            }
        }
        #endregion SEC_GREETING


        protected string n_sVAS_PRICE2 = global::System.String.Empty;
        #region VAS_PRICE2
        public string VAS_PRICE2
        {
            get
            {
                return this.n_sVAS_PRICE2;
            }
            set
            {
                this.n_sVAS_PRICE2 = value;
            }
        }
        #endregion VAS_PRICE2


        protected string n_sHANDSET_DESC = global::System.String.Empty;
        #region HANDSET_DESC
        public string HANDSET_DESC
        {
            get
            {
                return this.n_sHANDSET_DESC;
            }
            set
            {
                this.n_sHANDSET_DESC = value;
            }
        }
        #endregion HANDSET_DESC


        protected string n_sREG_BUILDING = global::System.String.Empty;
        #region REG_BUILDING
        public string REG_BUILDING
        {
            get
            {
                return this.n_sREG_BUILDING;
            }
            set
            {
                this.n_sREG_BUILDING = value;
            }
        }
        #endregion REG_BUILDING


        protected string n_sVAS_NAME2 = global::System.String.Empty;
        #region VAS_NAME2
        public string VAS_NAME2
        {
            get
            {
                return this.n_sVAS_NAME2;
            }
            set
            {
                this.n_sVAS_NAME2 = value;
            }
        }
        #endregion VAS_NAME2


        protected string n_sVAS_NAME4 = global::System.String.Empty;
        #region VAS_NAME4
        public string VAS_NAME4
        {
            get
            {
                return this.n_sVAS_NAME4;
            }
            set
            {
                this.n_sVAS_NAME4 = value;
            }
        }
        #endregion VAS_NAME4


        protected string n_sBIL_ST_NAME = global::System.String.Empty;
        #region BIL_ST_NAME
        public string BIL_ST_NAME
        {
            get
            {
                return this.n_sBIL_ST_NAME;
            }
            set
            {
                this.n_sBIL_ST_NAME = value;
            }
        }
        #endregion BIL_ST_NAME


        protected string n_sVAS_NAME6 = global::System.String.Empty;
        #region VAS_NAME6
        public string VAS_NAME6
        {
            get
            {
                return this.n_sVAS_NAME6;
            }
            set
            {
                this.n_sVAS_NAME6 = value;
            }
        }
        #endregion VAS_NAME6


        protected string n_sVAS_NAME7 = global::System.String.Empty;
        #region VAS_NAME7
        public string VAS_NAME7
        {
            get
            {
                return this.n_sVAS_NAME7;
            }
            set
            {
                this.n_sVAS_NAME7 = value;
            }
        }
        #endregion VAS_NAME7


        protected string n_sAGREEMENT_DATE = global::System.String.Empty;
        #region AGREEMENT_DATE
        public string AGREEMENT_DATE
        {
            get
            {
                return this.n_sAGREEMENT_DATE;
            }
            set
            {
                this.n_sAGREEMENT_DATE = value;
            }
        }
        #endregion AGREEMENT_DATE


        protected string n_sVAS_PRICE15 = global::System.String.Empty;
        #region VAS_PRICE15
        public string VAS_PRICE15
        {
            get
            {
                return this.n_sVAS_PRICE15;
            }
            set
            {
                this.n_sVAS_PRICE15 = value;
            }
        }
        #endregion VAS_PRICE15


        protected string n_sREG_FLAT = global::System.String.Empty;
        #region REG_FLAT
        public string REG_FLAT
        {
            get
            {
                return this.n_sREG_FLAT;
            }
            set
            {
                this.n_sREG_FLAT = value;
            }
        }
        #endregion REG_FLAT


        protected string n_sCONTACT_TEL = global::System.String.Empty;
        #region CONTACT_TEL
        public string CONTACT_TEL
        {
            get
            {
                return this.n_sCONTACT_TEL;
            }
            set
            {
                this.n_sCONTACT_TEL = value;
            }
        }
        #endregion CONTACT_TEL


        protected string n_sHS_PAY_AMT2 = global::System.String.Empty;
        #region HS_PAY_AMT2
        public string HS_PAY_AMT2
        {
            get
            {
                return this.n_sHS_PAY_AMT2;
            }
            set
            {
                this.n_sHS_PAY_AMT2 = value;
            }
        }
        #endregion HS_PAY_AMT2


        protected string n_sSALESMAN_CODE = global::System.String.Empty;
        #region SALESMAN_CODE
        public string SALESMAN_CODE
        {
            get
            {
                return this.n_sSALESMAN_CODE;
            }
            set
            {
                this.n_sSALESMAN_CODE = value;
            }
        }
        #endregion SALESMAN_CODE


        protected string n_sVAS_NAME15 = global::System.String.Empty;
        #region VAS_NAME15
        public string VAS_NAME15
        {
            get
            {
                return this.n_sVAS_NAME15;
            }
            set
            {
                this.n_sVAS_NAME15 = value;
            }
        }
        #endregion VAS_NAME15


        protected string n_sBILL_CU_NAME = global::System.String.Empty;
        #region BILL_CU_NAME
        public string BILL_CU_NAME
        {
            get
            {
                return this.n_sBILL_CU_NAME;
            }
            set
            {
                this.n_sBILL_CU_NAME = value;
            }
        }
        #endregion BILL_CU_NAME


        protected string n_sVAS_PRICE8 = global::System.String.Empty;
        #region VAS_PRICE8
        public string VAS_PRICE8
        {
            get
            {
                return this.n_sVAS_PRICE8;
            }
            set
            {
                this.n_sVAS_PRICE8 = value;
            }
        }
        #endregion VAS_PRICE8


        protected string n_sDNO = global::System.String.Empty;
        #region DNO
        public string DNO
        {
            get
            {
                return this.n_sDNO;
            }
            set
            {
                this.n_sDNO = value;
            }
        }
        #endregion DNO


        protected string n_sREG_DISTRICT = global::System.String.Empty;
        #region REG_DISTRICT
        public string REG_DISTRICT
        {
            get
            {
                return this.n_sREG_DISTRICT;
            }
            set
            {
                this.n_sREG_DISTRICT = value;
            }
        }
        #endregion REG_DISTRICT


        protected string n_sSTUDENT_BIRTH_D = global::System.String.Empty;
        #region STUDENT_BIRTH_D
        public string STUDENT_BIRTH_D
        {
            get
            {
                return this.n_sSTUDENT_BIRTH_D;
            }
            set
            {
                this.n_sSTUDENT_BIRTH_D = value;
            }
        }
        #endregion STUDENT_BIRTH_D


        protected string n_sVAS_PRICE1 = global::System.String.Empty;
        #region VAS_PRICE1
        public string VAS_PRICE1
        {
            get
            {
                return this.n_sVAS_PRICE1;
            }
            set
            {
                this.n_sVAS_PRICE1 = value;
            }
        }
        #endregion VAS_PRICE1


        protected string n_sMP_3_BANK_ACCOUNT = global::System.String.Empty;
        #region MP_3_BANK_ACCOUNT
        public string MP_3_BANK_ACCOUNT
        {
            get
            {
                return this.n_sMP_3_BANK_ACCOUNT;
            }
            set
            {
                this.n_sMP_3_BANK_ACCOUNT = value;
            }
        }
        #endregion MP_3_BANK_ACCOUNT


        protected string n_sVAS_NAME8 = global::System.String.Empty;
        #region VAS_NAME8
        public string VAS_NAME8
        {
            get
            {
                return this.n_sVAS_NAME8;
            }
            set
            {
                this.n_sVAS_NAME8 = value;
            }
        }
        #endregion VAS_NAME8


        protected string n_sOLD_SUB_ID_TYPE_MNP = global::System.String.Empty;
        #region OLD_SUB_ID_TYPE_MNP
        public string OLD_SUB_ID_TYPE_MNP
        {
            get
            {
                return this.n_sOLD_SUB_ID_TYPE_MNP;
            }
            set
            {
                this.n_sOLD_SUB_ID_TYPE_MNP = value;
            }
        }
        #endregion OLD_SUB_ID_TYPE_MNP


        protected string n_sREGION_CITY = global::System.String.Empty;
        #region REGION_CITY
        public string REGION_CITY
        {
            get
            {
                return this.n_sREGION_CITY;
            }
            set
            {
                this.n_sREGION_CITY = value;
            }
        }
        #endregion REGION_CITY


        protected string n_sCREATED_BY = global::System.String.Empty;
        #region CREATED_BY
        public string CREATED_BY
        {
            get
            {
                return this.n_sCREATED_BY;
            }
            set
            {
                this.n_sCREATED_BY = value;
            }
        }
        #endregion CREATED_BY


        protected string n_sVAS_NAME20 = global::System.String.Empty;
        #region VAS_NAME20
        public string VAS_NAME20
        {
            get
            {
                return this.n_sVAS_NAME20;
            }
            set
            {
                this.n_sVAS_NAME20 = value;
            }
        }
        #endregion VAS_NAME20


        protected string n_sVAS_PRICE17 = global::System.String.Empty;
        #region VAS_PRICE17
        public string VAS_PRICE17
        {
            get
            {
                return this.n_sVAS_PRICE17;
            }
            set
            {
                this.n_sVAS_PRICE17 = value;
            }
        }
        #endregion VAS_PRICE17


        protected string n_sCARD_NO = global::System.String.Empty;
        #region CARD_NO
        public string CARD_NO
        {
            get
            {
                return this.n_sCARD_NO;
            }
            set
            {
                this.n_sCARD_NO = value;
            }
        }
        #endregion CARD_NO


        protected string n_sVAS_NAME1 = global::System.String.Empty;
        #region VAS_NAME1
        public string VAS_NAME1
        {
            get
            {
                return this.n_sVAS_NAME1;
            }
            set
            {
                this.n_sVAS_NAME1 = value;
            }
        }
        #endregion VAS_NAME1


        protected string n_sCUT_OVER_TIME_MNP = global::System.String.Empty;
        #region CUT_OVER_TIME_MNP
        public string CUT_OVER_TIME_MNP
        {
            get
            {
                return this.n_sCUT_OVER_TIME_MNP;
            }
            set
            {
                this.n_sCUT_OVER_TIME_MNP = value;
            }
        }
        #endregion CUT_OVER_TIME_MNP


        protected string n_sVAS_NAME3 = global::System.String.Empty;
        #region VAS_NAME3
        public string VAS_NAME3
        {
            get
            {
                return this.n_sVAS_NAME3;
            }
            set
            {
                this.n_sVAS_NAME3 = value;
            }
        }
        #endregion VAS_NAME3


        protected string n_sBIL_ST_NO = global::System.String.Empty;
        #region BIL_ST_NO
        public string BIL_ST_NO
        {
            get
            {
                return this.n_sBIL_ST_NO;
            }
            set
            {
                this.n_sBIL_ST_NO = value;
            }
        }
        #endregion BIL_ST_NO


        protected string n_sHS_CARD_NO_INSTAL = global::System.String.Empty;
        #region HS_CARD_NO_INSTAL
        public string HS_CARD_NO_INSTAL
        {
            get
            {
                return this.n_sHS_CARD_NO_INSTAL;
            }
            set
            {
                this.n_sHS_CARD_NO_INSTAL = value;
            }
        }
        #endregion HS_CARD_NO_INSTAL


        protected string n_sOWNER_NAME = global::System.String.Empty;
        #region OWNER_NAME
        public string OWNER_NAME
        {
            get
            {
                return this.n_sOWNER_NAME;
            }
            set
            {
                this.n_sOWNER_NAME = value;
            }
        }
        #endregion OWNER_NAME


        protected string n_sPCCW_LANDLINE_NO = global::System.String.Empty;
        #region PCCW_LANDLINE_NO
        public string PCCW_LANDLINE_NO
        {
            get
            {
                return this.n_sPCCW_LANDLINE_NO;
            }
            set
            {
                this.n_sPCCW_LANDLINE_NO = value;
            }
        }
        #endregion PCCW_LANDLINE_NO


        protected string n_sSIM_CARD_NO = global::System.String.Empty;
        #region SIM_CARD_NO
        public string SIM_CARD_NO
        {
            get
            {
                return this.n_sSIM_CARD_NO;
            }
            set
            {
                this.n_sSIM_CARD_NO = value;
            }
        }
        #endregion SIM_CARD_NO


        protected string n_sBIL_ESTATE = global::System.String.Empty;
        #region BIL_ESTATE
        public string BIL_ESTATE
        {
            get
            {
                return this.n_sBIL_ESTATE;
            }
            set
            {
                this.n_sBIL_ESTATE = value;
            }
        }
        #endregion BIL_ESTATE


        protected string n_sMOBILE_0060 = global::System.String.Empty;
        #region MOBILE_0060
        public string MOBILE_0060
        {
            get
            {
                return this.n_sMOBILE_0060;
            }
            set
            {
                this.n_sMOBILE_0060 = value;
            }
        }
        #endregion MOBILE_0060


        protected string n_sMP_EXPIRYDATE = global::System.String.Empty;
        #region MP_EXPIRYDATE
        public string MP_EXPIRYDATE
        {
            get
            {
                return this.n_sMP_EXPIRYDATE;
            }
            set
            {
                this.n_sMP_EXPIRYDATE = value;
            }
        }
        #endregion MP_EXPIRYDATE


        protected string n_sSMS_SUPPRESS = global::System.String.Empty;
        #region SMS_SUPPRESS
        public string SMS_SUPPRESS
        {
            get
            {
                return this.n_sSMS_SUPPRESS;
            }
            set
            {
                this.n_sSMS_SUPPRESS = value;
            }
        }
        #endregion SMS_SUPPRESS


        protected string n_sAGREEMENT_NO = global::System.String.Empty;
        #region AGREEMENT_NO
        public string AGREEMENT_NO
        {
            get
            {
                return this.n_sAGREEMENT_NO;
            }
            set
            {
                this.n_sAGREEMENT_NO = value;
            }
        }
        #endregion AGREEMENT_NO


        protected string n_sACTIVATION_DATE = global::System.String.Empty;
        #region ACTIVATION_DATE
        public string ACTIVATION_DATE
        {
            get
            {
                return this.n_sACTIVATION_DATE;
            }
            set
            {
                this.n_sACTIVATION_DATE = value;
            }
        }
        #endregion ACTIVATION_DATE


        protected string n_sFAMILY_REFERRAL_DN = global::System.String.Empty;
        #region FAMILY_REFERRAL_DN
        public string FAMILY_REFERRAL_DN
        {
            get
            {
                return this.n_sFAMILY_REFERRAL_DN;
            }
            set
            {
                this.n_sFAMILY_REFERRAL_DN = value;
            }
        }
        #endregion FAMILY_REFERRAL_DN


        protected string n_sPAYMENT_TYPE = global::System.String.Empty;
        #region PAYMENT_TYPE
        public string PAYMENT_TYPE
        {
            get
            {
                return this.n_sPAYMENT_TYPE;
            }
            set
            {
                this.n_sPAYMENT_TYPE = value;
            }
        }
        #endregion PAYMENT_TYPE


        protected string n_sPREPAID_SIM_NO = global::System.String.Empty;
        #region PREPAID_SIM_NO
        public string PREPAID_SIM_NO
        {
            get
            {
                return this.n_sPREPAID_SIM_NO;
            }
            set
            {
                this.n_sPREPAID_SIM_NO = value;
            }
        }
        #endregion PREPAID_SIM_NO


        protected string n_sHS_APP_CODE2 = global::System.String.Empty;
        #region HS_APP_CODE2
        public string HS_APP_CODE2
        {
            get
            {
                return this.n_sHS_APP_CODE2;
            }
            set
            {
                this.n_sHS_APP_CODE2 = value;
            }
        }
        #endregion HS_APP_CODE2


        protected string n_sVAS_NAME16 = global::System.String.Empty;
        #region VAS_NAME16
        public string VAS_NAME16
        {
            get
            {
                return this.n_sVAS_NAME16;
            }
            set
            {
                this.n_sVAS_NAME16 = value;
            }
        }
        #endregion VAS_NAME16


        protected global::System.Nullable<DateTime> n_dREG_AREA = null;
        #region REG_AREA
        public global::System.Nullable<DateTime> REG_AREA
        {
            get
            {
                return this.n_dREG_AREA;
            }
            set
            {
                this.n_dREG_AREA = value;
            }
        }
        #endregion REG_AREA

        #region Para
        public class Para
        {
            public const string ID_NO_TYPE = "ID_NO_TYPE";
            public const string VAS_PRICE9 = "VAS_PRICE9";
            public const string VAS_PRICE13 = "VAS_PRICE13";
            public const string BIL_DISTRICT = "BIL_DISTRICT";
            public const string IMEI = "IMEI";
            public const string HS_C_HOLDER_NAME2 = "HS_C_HOLDER_NAME2";
            public const string BILL_ADDRESS_1 = "BILL_ADDRESS_1";
            public const string HS_EXP_2 = "HS_EXP_2";
            public const string BANK_NAME = "BANK_NAME";
            public const string MP_CARD_OWNER = "MP_CARD_OWNER";
            public const string EXPIRY_DATE = "EXPIRY_DATE";
            public const string EMAIL_SUPPRESS = "EMAIL_SUPPRESS";
            public const string HS_C_HOLDER_INSTAL = "HS_C_HOLDER_INSTAL";
            public const string EMAIL = "EMAIL";
            public const string VAS_PRICE19 = "VAS_PRICE19";
            public const string MP_C_HOLDER_NAME = "MP_C_HOLDER_NAME";
            public const string MOBILE_NO = "MOBILE_NO";
            public const string MP_3_PARTY_NAME = "MP_3_PARTY_NAME";
            public const string RATE_PLAN = "RATE_PLAN";
            public const string OLD_SUB_NAME_MNP = "OLD_SUB_NAME_MNP";
            public const string CREATE_DATE = "CREATE_DATE";
            public const string DUMMY2 = "DUMMY2";
            public const string VAS_NAME18 = "VAS_NAME18";
            public const string CONTACT_PERSON = "CONTACT_PERSON";
            public const string VAS_PRICE5 = "VAS_PRICE5";
            public const string IDD_ROAMING = "IDD_ROAMING";
            public const string VAS_NAME17 = "VAS_NAME17";
            public const string VAS_PRICE18 = "VAS_PRICE18";
            public const string REFERENCENO = "REFERENCENO";
            public const string VAS_PRICE3 = "VAS_PRICE3";
            public const string PAYMENT_LIMIT = "PAYMENT_LIMIT";
            public const string MP_3_PARTY_ID = "MP_3_PARTY_ID";
            public const string N2_REGISTERED_NAME = "N2_REGISTERED_NAME";
            public const string D_MAILL_SUPPRESS = "D_MAILL_SUPPRESS";
            public const string AUTO_PAY = "AUTO_PAY";
            public const string IDD_0060 = "IDD_0060";
            public const string CUSTOMER_GROUP = "CUSTOMER_GROUP";
            public const string VAS_PRICE10 = "VAS_PRICE10";
            public const string VAS_NAME12 = "VAS_NAME12";
            public const string VAS_PRICE4 = "VAS_PRICE4";
            public const string VAS_NAME13 = "VAS_NAME13";
            public const string HS_PAY_AMT_INSTAL = "HS_PAY_AMT_INSTAL";
            public const string SEC_SERVICE_PASSWORD = "SEC_SERVICE_PASSWORD";
            public const string NETVIGATOR_FSA_NO = "NETVIGATOR_FSA_NO";
            public const string STUDENT_HK_ID = "STUDENT_HK_ID";
            public const string VOICE_LANGUAGE = "VOICE_LANGUAGE";
            public const string MP_APP_CODE = "MP_APP_CODE";
            public const string EMAIL_BILL = "EMAIL_BILL";
            public const string CREDIT_CARD_TYPE = "CREDIT_CARD_TYPE";
            public const string BANK_ACCOUNT = "BANK_ACCOUNT";
            public const string REG_ST_NAME = "REG_ST_NAME";
            public const string CHINA_ROAMING = "CHINA_ROAMING";
            public const string DUMMY3 = "DUMMY3";
            public const string HS_EXP_INSTAL = "HS_EXP_INSTAL";
            public const string ACTUAL_USER = "ACTUAL_USER";
            public const string TICKET_NO = "TICKET_NO";
            public const string VAS_NAME14 = "VAS_NAME14";
            public const string CUT_OVER_WINDOW = "CUT_OVER_WINDOW";
            public const string PREPAID_SIM_TO_POSTPAID = "PREPAID_SIM_TO_POSTPAID";
            public const string CUT_OVER_DATE_MNP = "CUT_OVER_DATE_MNP";
            public const string HS_PAYMENT_TYPE2 = "HS_PAYMENT_TYPE2";
            public const string MP_AMOUNT = "MP_AMOUNT";
            public const string SEC_SERVICE_NO = "SEC_SERVICE_NO";
            public const string VAS_PRICE14 = "VAS_PRICE14";
            public const string REG_BLOCK = "REG_BLOCK";
            public const string BIL_BUILDING = "BIL_BUILDING";
            public const string VAS_NAME5 = "VAS_NAME5";
            public const string ID_NO = "ID_NO";
            public const string SEC_LANGUAGE = "SEC_LANGUAGE";
            public const string VAS_PRICE7 = "VAS_PRICE7";
            public const string REG_ESTATE = "REG_ESTATE";
            public const string BILL_ADDRESS_3 = "BILL_ADDRESS_3";
            public const string HS_APP_CODE_INSTAL = "HS_APP_CODE_INSTAL";
            public const string FAX = "FAX";
            public const string BIL_FLOOR = "BIL_FLOOR";
            public const string OLD_SUB_HK_ID = "OLD_SUB_HK_ID";
            public const string VAS_PRICE11 = "VAS_PRICE11";
            public const string MP_CARDNO = "MP_CARDNO";
            public const string ADDRESS_1 = "ADDRESS_1";
            public const string ADDRESS_2 = "ADDRESS_2";
            public const string ADDRESS_3 = "ADDRESS_3";
            public const string REG_FLOOR = "REG_FLOOR";
            public const string FEATURE = "FEATURE";
            public const string BIL_AREA = "BIL_AREA";
            public const string VAS_PRICE6 = "VAS_PRICE6";
            public const string JOINT_PROMOTION_CODE = "JOINT_PROMOTION_CODE";
            public const string OFFICE_TEL = "OFFICE_TEL";
            public const string VAS_PRICE16 = "VAS_PRICE16";
            public const string BIL_BLOCK = "BIL_BLOCK";
            public const string HS_CARD_NO2 = "HS_CARD_NO2";
            public const string EXTG_AC_TYPE = "EXTG_AC_TYPE";
            public const string VAS_NAME19 = "VAS_NAME19";
            public const string TELEMARKETING_SUPPRESS = "TELEMARKETING_SUPPRESS";
            public const string HS_PERIOD_INSTAL = "HS_PERIOD_INSTAL";
            public const string BIL_FLAT = "BIL_FLAT";
            public const string SMARK_EXP = "SMARK_EXP";
            public const string SMS_LANGUAGE = "SMS_LANGUAGE";
            public const string VAS_PRICE20 = "VAS_PRICE20";
            public const string VAS_NAME11 = "VAS_NAME11";
            public const string TRADE_FIELD_2 = "TRADE_FIELD_2";
            public const string VAS_NAME10 = "VAS_NAME10";
            public const string TRADE_FIELD_1 = "TRADE_FIELD_1";
            public const string VAS_PRICE12 = "VAS_PRICE12";
            public const string DUMMY1 = "DUMMY1";
            public const string EXTG_AC_NO = "EXTG_AC_NO";
            public const string BILL_ADDRESS_2 = "BILL_ADDRESS_2";
            public const string SMARK_EXP_DATE = "SMARK_EXP_DATE";
            public const string VAS_NAME9 = "VAS_NAME9";
            public const string REG_ST_NO = "REG_ST_NO";
            public const string SEC_GREETING = "SEC_GREETING";
            public const string VAS_PRICE2 = "VAS_PRICE2";
            public const string HANDSET_DESC = "HANDSET_DESC";
            public const string REG_BUILDING = "REG_BUILDING";
            public const string VAS_NAME2 = "VAS_NAME2";
            public const string VAS_NAME4 = "VAS_NAME4";
            public const string BIL_ST_NAME = "BIL_ST_NAME";
            public const string VAS_NAME6 = "VAS_NAME6";
            public const string VAS_NAME7 = "VAS_NAME7";
            public const string AGREEMENT_DATE = "AGREEMENT_DATE";
            public const string VAS_PRICE15 = "VAS_PRICE15";
            public const string REG_FLAT = "REG_FLAT";
            public const string CONTACT_TEL = "CONTACT_TEL";
            public const string HS_PAY_AMT2 = "HS_PAY_AMT2";
            public const string SALESMAN_CODE = "SALESMAN_CODE";
            public const string VAS_NAME15 = "VAS_NAME15";
            public const string BILL_CU_NAME = "BILL_CU_NAME";
            public const string VAS_PRICE8 = "VAS_PRICE8";
            public const string DNO = "DNO";
            public const string REG_DISTRICT = "REG_DISTRICT";
            public const string STUDENT_BIRTH_D = "STUDENT_BIRTH_D";
            public const string VAS_PRICE1 = "VAS_PRICE1";
            public const string MP_3_BANK_ACCOUNT = "MP_3_BANK_ACCOUNT";
            public const string VAS_NAME8 = "VAS_NAME8";
            public const string OLD_SUB_ID_TYPE_MNP = "OLD_SUB_ID_TYPE_MNP";
            public const string REGION_CITY = "REGION_CITY";
            public const string CREATED_BY = "CREATED_BY";
            public const string VAS_NAME20 = "VAS_NAME20";
            public const string VAS_PRICE17 = "VAS_PRICE17";
            public const string CARD_NO = "CARD_NO";
            public const string VAS_NAME1 = "VAS_NAME1";
            public const string CUT_OVER_TIME_MNP = "CUT_OVER_TIME_MNP";
            public const string VAS_NAME3 = "VAS_NAME3";
            public const string BIL_ST_NO = "BIL_ST_NO";
            public const string HS_CARD_NO_INSTAL = "HS_CARD_NO_INSTAL";
            public const string OWNER_NAME = "OWNER_NAME";
            public const string PCCW_LANDLINE_NO = "PCCW_LANDLINE_NO";
            public const string SIM_CARD_NO = "SIM_CARD_NO";
            public const string BIL_ESTATE = "BIL_ESTATE";
            public const string MOBILE_0060 = "MOBILE_0060";
            public const string MP_EXPIRYDATE = "MP_EXPIRYDATE";
            public const string SMS_SUPPRESS = "SMS_SUPPRESS";
            public const string AGREEMENT_NO = "AGREEMENT_NO";
            public const string ACTIVATION_DATE = "ACTIVATION_DATE";
            public const string FAMILY_REFERRAL_DN = "FAMILY_REFERRAL_DN";
            public const string PAYMENT_TYPE = "PAYMENT_TYPE";
            public const string PREPAID_SIM_NO = "PREPAID_SIM_NO";
            public const string HS_APP_CODE2 = "HS_APP_CODE2";
            public const string VAS_NAME16 = "VAS_NAME16";
            public const string REG_AREA = "REG_AREA";
        }
        #endregion Para

        #region Constructor & Destructor
        public SundayActivation() { }

        public SundayActivation(string x_sID_NO_TYPE, string x_sVAS_PRICE9, string x_sVAS_PRICE13, string x_sBIL_DISTRICT, string x_sIMEI, string x_sHS_C_HOLDER_NAME2, string x_sBILL_ADDRESS_1, string x_sHS_EXP_2, string x_sBANK_NAME, string x_sMP_CARD_OWNER, string x_sEXPIRY_DATE, string x_sEMAIL_SUPPRESS, string x_sHS_C_HOLDER_INSTAL, string x_sEMAIL, string x_sVAS_PRICE19, string x_sMP_C_HOLDER_NAME, string x_sMOBILE_NO, string x_sMP_3_PARTY_NAME, string x_sRATE_PLAN, string x_sOLD_SUB_NAME_MNP, DateTime x_dCREATE_DATE, string x_dDUMMY2, string x_sVAS_NAME18, string x_sCONTACT_PERSON, string x_sVAS_PRICE5, string x_sIDD_ROAMING, string x_sVAS_NAME17, string x_sVAS_PRICE18, string x_sREFERENCENO, string x_sVAS_PRICE3, string x_sPAYMENT_LIMIT, string x_sMP_3_PARTY_ID, string x_sN2_REGISTERED_NAME, string x_sD_MAILL_SUPPRESS, string x_sAUTO_PAY, string x_sIDD_0060, string x_sCUSTOMER_GROUP, string x_sVAS_PRICE10, string x_sVAS_NAME12, string x_sVAS_PRICE4, string x_sVAS_NAME13, string x_sHS_PAY_AMT_INSTAL, string x_sSEC_SERVICE_PASSWORD, string x_sNETVIGATOR_FSA_NO, string x_sSTUDENT_HK_ID, string x_sVOICE_LANGUAGE, string x_sMP_APP_CODE, string x_sEMAIL_BILL, string x_sCREDIT_CARD_TYPE, string x_sBANK_ACCOUNT, string x_sREG_ST_NAME, string x_sCHINA_ROAMING, DateTime x_dDUMMY3, string x_sHS_EXP_INSTAL, string x_sACTUAL_USER, string x_sTICKET_NO, string x_sVAS_NAME14, string x_sCUT_OVER_WINDOW, string x_sPREPAID_SIM_TO_POSTPAID, string x_sCUT_OVER_DATE_MNP, DateTime x_dHS_PAYMENT_TYPE2, string x_sMP_AMOUNT, string x_sSEC_SERVICE_NO, string x_sVAS_PRICE14, string x_sREG_BLOCK, string x_sBIL_BUILDING, string x_sVAS_NAME5, string x_sID_NO, string x_sSEC_LANGUAGE, string x_sVAS_PRICE7, string x_sREG_ESTATE, string x_sBILL_ADDRESS_3, string x_sHS_APP_CODE_INSTAL, string x_sFAX, string x_sBIL_FLOOR, string x_sOLD_SUB_HK_ID, string x_sVAS_PRICE11, string x_sMP_CARDNO, string x_sADDRESS_1, string x_sADDRESS_2, string x_sADDRESS_3, string x_sREG_FLOOR, string x_sFEATURE, DateTime x_dBIL_AREA, string x_sVAS_PRICE6, string x_sJOINT_PROMOTION_CODE, string x_sOFFICE_TEL, string x_sVAS_PRICE16, string x_sBIL_BLOCK, string x_sHS_CARD_NO2, string x_sEXTG_AC_TYPE, string x_sVAS_NAME19, string x_sTELEMARKETING_SUPPRESS, string x_sHS_PERIOD_INSTAL, string x_sBIL_FLAT, string x_sSMARK_EXP, string x_sSMS_LANGUAGE, string x_sVAS_PRICE20, string x_sVAS_NAME11, string x_sTRADE_FIELD_2, string x_sVAS_NAME10, string x_sTRADE_FIELD_1, string x_sVAS_PRICE12, string x_sDUMMY1, string x_sEXTG_AC_NO, string x_sBILL_ADDRESS_2, DateTime x_dSMARK_EXP_DATE, string x_sVAS_NAME9, string x_sREG_ST_NO, string x_sSEC_GREETING, string x_sVAS_PRICE2, string x_sHANDSET_DESC, string x_sREG_BUILDING, string x_sVAS_NAME2, string x_sVAS_NAME4, string x_sBIL_ST_NAME, string x_sVAS_NAME6, string x_sVAS_NAME7, string x_sAGREEMENT_DATE, string x_sVAS_PRICE15, string x_sREG_FLAT, string x_sCONTACT_TEL, string x_sHS_PAY_AMT2, string x_sSALESMAN_CODE, string x_sVAS_NAME15, string x_sBILL_CU_NAME, string x_sVAS_PRICE8, string x_sDNO, string x_sREG_DISTRICT, string x_sSTUDENT_BIRTH_D, string x_sVAS_PRICE1, string x_sMP_3_BANK_ACCOUNT, string x_sVAS_NAME8, string x_sOLD_SUB_ID_TYPE_MNP, string x_sREGION_CITY, string x_sCREATED_BY, string x_sVAS_NAME20, string x_sVAS_PRICE17, string x_sCARD_NO, string x_sVAS_NAME1, string x_sCUT_OVER_TIME_MNP, string x_sVAS_NAME3, string x_sBIL_ST_NO, string x_sHS_CARD_NO_INSTAL, string x_sOWNER_NAME, string x_sPCCW_LANDLINE_NO, string x_sSIM_CARD_NO, string x_sBIL_ESTATE, string x_sMOBILE_0060, string x_sMP_EXPIRYDATE, string x_sSMS_SUPPRESS, string x_sAGREEMENT_NO, string x_sACTIVATION_DATE, string x_sFAMILY_REFERRAL_DN, string x_sPAYMENT_TYPE, string x_sPREPAID_SIM_NO, string x_sHS_APP_CODE2, string x_sVAS_NAME16, DateTime x_dREG_AREA)
        {
            ID_NO_TYPE = x_sID_NO_TYPE;
            VAS_PRICE9 = x_sVAS_PRICE9;
            VAS_PRICE13 = x_sVAS_PRICE13;
            BIL_DISTRICT = x_sBIL_DISTRICT;
            IMEI = x_sIMEI;
            HS_C_HOLDER_NAME2 = x_sHS_C_HOLDER_NAME2;
            BILL_ADDRESS_1 = x_sBILL_ADDRESS_1;
            HS_EXP_2 = x_sHS_EXP_2;
            BANK_NAME = x_sBANK_NAME;
            MP_CARD_OWNER = x_sMP_CARD_OWNER;
            EXPIRY_DATE = x_sEXPIRY_DATE;
            EMAIL_SUPPRESS = x_sEMAIL_SUPPRESS;
            HS_C_HOLDER_INSTAL = x_sHS_C_HOLDER_INSTAL;
            EMAIL = x_sEMAIL;
            VAS_PRICE19 = x_sVAS_PRICE19;
            MP_C_HOLDER_NAME = x_sMP_C_HOLDER_NAME;
            MOBILE_NO = x_sMOBILE_NO;
            MP_3_PARTY_NAME = x_sMP_3_PARTY_NAME;
            RATE_PLAN = x_sRATE_PLAN;
            OLD_SUB_NAME_MNP = x_sOLD_SUB_NAME_MNP;
            CREATE_DATE = x_dCREATE_DATE;
            DUMMY2 = x_dDUMMY2;
            VAS_NAME18 = x_sVAS_NAME18;
            CONTACT_PERSON = x_sCONTACT_PERSON;
            VAS_PRICE5 = x_sVAS_PRICE5;
            IDD_ROAMING = x_sIDD_ROAMING;
            VAS_NAME17 = x_sVAS_NAME17;
            VAS_PRICE18 = x_sVAS_PRICE18;
            REFERENCENO = x_sREFERENCENO;
            VAS_PRICE3 = x_sVAS_PRICE3;
            PAYMENT_LIMIT = x_sPAYMENT_LIMIT;
            MP_3_PARTY_ID = x_sMP_3_PARTY_ID;
            N2_REGISTERED_NAME = x_sN2_REGISTERED_NAME;
            D_MAILL_SUPPRESS = x_sD_MAILL_SUPPRESS;
            AUTO_PAY = x_sAUTO_PAY;
            IDD_0060 = x_sIDD_0060;
            CUSTOMER_GROUP = x_sCUSTOMER_GROUP;
            VAS_PRICE10 = x_sVAS_PRICE10;
            VAS_NAME12 = x_sVAS_NAME12;
            VAS_PRICE4 = x_sVAS_PRICE4;
            VAS_NAME13 = x_sVAS_NAME13;
            HS_PAY_AMT_INSTAL = x_sHS_PAY_AMT_INSTAL;
            SEC_SERVICE_PASSWORD = x_sSEC_SERVICE_PASSWORD;
            NETVIGATOR_FSA_NO = x_sNETVIGATOR_FSA_NO;
            STUDENT_HK_ID = x_sSTUDENT_HK_ID;
            VOICE_LANGUAGE = x_sVOICE_LANGUAGE;
            MP_APP_CODE = x_sMP_APP_CODE;
            EMAIL_BILL = x_sEMAIL_BILL;
            CREDIT_CARD_TYPE = x_sCREDIT_CARD_TYPE;
            BANK_ACCOUNT = x_sBANK_ACCOUNT;
            REG_ST_NAME = x_sREG_ST_NAME;
            CHINA_ROAMING = x_sCHINA_ROAMING;
            DUMMY3 = x_dDUMMY3;
            HS_EXP_INSTAL = x_sHS_EXP_INSTAL;
            ACTUAL_USER = x_sACTUAL_USER;
            TICKET_NO = x_sTICKET_NO;
            VAS_NAME14 = x_sVAS_NAME14;
            CUT_OVER_WINDOW = x_sCUT_OVER_WINDOW;
            PREPAID_SIM_TO_POSTPAID = x_sPREPAID_SIM_TO_POSTPAID;
            CUT_OVER_DATE_MNP = x_sCUT_OVER_DATE_MNP;
            HS_PAYMENT_TYPE2 = x_dHS_PAYMENT_TYPE2;
            MP_AMOUNT = x_sMP_AMOUNT;
            SEC_SERVICE_NO = x_sSEC_SERVICE_NO;
            VAS_PRICE14 = x_sVAS_PRICE14;
            REG_BLOCK = x_sREG_BLOCK;
            BIL_BUILDING = x_sBIL_BUILDING;
            VAS_NAME5 = x_sVAS_NAME5;
            ID_NO = x_sID_NO;
            SEC_LANGUAGE = x_sSEC_LANGUAGE;
            VAS_PRICE7 = x_sVAS_PRICE7;
            REG_ESTATE = x_sREG_ESTATE;
            BILL_ADDRESS_3 = x_sBILL_ADDRESS_3;
            HS_APP_CODE_INSTAL = x_sHS_APP_CODE_INSTAL;
            FAX = x_sFAX;
            BIL_FLOOR = x_sBIL_FLOOR;
            OLD_SUB_HK_ID = x_sOLD_SUB_HK_ID;
            VAS_PRICE11 = x_sVAS_PRICE11;
            MP_CARDNO = x_sMP_CARDNO;
            ADDRESS_1 = x_sADDRESS_1;
            ADDRESS_2 = x_sADDRESS_2;
            ADDRESS_3 = x_sADDRESS_3;
            REG_FLOOR = x_sREG_FLOOR;
            FEATURE = x_sFEATURE;
            BIL_AREA = x_dBIL_AREA;
            VAS_PRICE6 = x_sVAS_PRICE6;
            JOINT_PROMOTION_CODE = x_sJOINT_PROMOTION_CODE;
            OFFICE_TEL = x_sOFFICE_TEL;
            VAS_PRICE16 = x_sVAS_PRICE16;
            BIL_BLOCK = x_sBIL_BLOCK;
            HS_CARD_NO2 = x_sHS_CARD_NO2;
            EXTG_AC_TYPE = x_sEXTG_AC_TYPE;
            VAS_NAME19 = x_sVAS_NAME19;
            TELEMARKETING_SUPPRESS = x_sTELEMARKETING_SUPPRESS;
            HS_PERIOD_INSTAL = x_sHS_PERIOD_INSTAL;
            BIL_FLAT = x_sBIL_FLAT;
            SMARK_EXP = x_sSMARK_EXP;
            SMS_LANGUAGE = x_sSMS_LANGUAGE;
            VAS_PRICE20 = x_sVAS_PRICE20;
            VAS_NAME11 = x_sVAS_NAME11;
            TRADE_FIELD_2 = x_sTRADE_FIELD_2;
            VAS_NAME10 = x_sVAS_NAME10;
            TRADE_FIELD_1 = x_sTRADE_FIELD_1;
            VAS_PRICE12 = x_sVAS_PRICE12;
            DUMMY1 = x_sDUMMY1;
            EXTG_AC_NO = x_sEXTG_AC_NO;
            BILL_ADDRESS_2 = x_sBILL_ADDRESS_2;
            SMARK_EXP_DATE = x_dSMARK_EXP_DATE;
            VAS_NAME9 = x_sVAS_NAME9;
            REG_ST_NO = x_sREG_ST_NO;
            SEC_GREETING = x_sSEC_GREETING;
            VAS_PRICE2 = x_sVAS_PRICE2;
            HANDSET_DESC = x_sHANDSET_DESC;
            REG_BUILDING = x_sREG_BUILDING;
            VAS_NAME2 = x_sVAS_NAME2;
            VAS_NAME4 = x_sVAS_NAME4;
            BIL_ST_NAME = x_sBIL_ST_NAME;
            VAS_NAME6 = x_sVAS_NAME6;
            VAS_NAME7 = x_sVAS_NAME7;
            AGREEMENT_DATE = x_sAGREEMENT_DATE;
            VAS_PRICE15 = x_sVAS_PRICE15;
            REG_FLAT = x_sREG_FLAT;
            CONTACT_TEL = x_sCONTACT_TEL;
            HS_PAY_AMT2 = x_sHS_PAY_AMT2;
            SALESMAN_CODE = x_sSALESMAN_CODE;
            VAS_NAME15 = x_sVAS_NAME15;
            BILL_CU_NAME = x_sBILL_CU_NAME;
            VAS_PRICE8 = x_sVAS_PRICE8;
            DNO = x_sDNO;
            REG_DISTRICT = x_sREG_DISTRICT;
            STUDENT_BIRTH_D = x_sSTUDENT_BIRTH_D;
            VAS_PRICE1 = x_sVAS_PRICE1;
            MP_3_BANK_ACCOUNT = x_sMP_3_BANK_ACCOUNT;
            VAS_NAME8 = x_sVAS_NAME8;
            OLD_SUB_ID_TYPE_MNP = x_sOLD_SUB_ID_TYPE_MNP;
            REGION_CITY = x_sREGION_CITY;
            CREATED_BY = x_sCREATED_BY;
            VAS_NAME20 = x_sVAS_NAME20;
            VAS_PRICE17 = x_sVAS_PRICE17;
            CARD_NO = x_sCARD_NO;
            VAS_NAME1 = x_sVAS_NAME1;
            CUT_OVER_TIME_MNP = x_sCUT_OVER_TIME_MNP;
            VAS_NAME3 = x_sVAS_NAME3;
            BIL_ST_NO = x_sBIL_ST_NO;
            HS_CARD_NO_INSTAL = x_sHS_CARD_NO_INSTAL;
            OWNER_NAME = x_sOWNER_NAME;
            PCCW_LANDLINE_NO = x_sPCCW_LANDLINE_NO;
            SIM_CARD_NO = x_sSIM_CARD_NO;
            BIL_ESTATE = x_sBIL_ESTATE;
            MOBILE_0060 = x_sMOBILE_0060;
            MP_EXPIRYDATE = x_sMP_EXPIRYDATE;
            SMS_SUPPRESS = x_sSMS_SUPPRESS;
            AGREEMENT_NO = x_sAGREEMENT_NO;
            ACTIVATION_DATE = x_sACTIVATION_DATE;
            FAMILY_REFERRAL_DN = x_sFAMILY_REFERRAL_DN;
            PAYMENT_TYPE = x_sPAYMENT_TYPE;
            PREPAID_SIM_NO = x_sPREPAID_SIM_NO;
            HS_APP_CODE2 = x_sHS_APP_CODE2;
            VAS_NAME16 = x_sVAS_NAME16;
            REG_AREA = x_dREG_AREA;
        }

        ~SundayActivation() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetID_NO_TYPE() { return this.ID_NO_TYPE; }
        public string GetVAS_PRICE9() { return this.VAS_PRICE9; }
        public string GetVAS_PRICE13() { return this.VAS_PRICE13; }
        public string GetBIL_DISTRICT() { return this.BIL_DISTRICT; }
        public string GetIMEI() { return this.IMEI; }
        public string GetHS_C_HOLDER_NAME2() { return this.HS_C_HOLDER_NAME2; }
        public string GetBILL_ADDRESS_1() { return this.BILL_ADDRESS_1; }
        public string GetHS_EXP_2() { return this.HS_EXP_2; }
        public string GetBANK_NAME() { return this.BANK_NAME; }
        public string GetMP_CARD_OWNER() { return this.MP_CARD_OWNER; }
        public string GetEXPIRY_DATE() { return this.EXPIRY_DATE; }
        public string GetEMAIL_SUPPRESS() { return this.EMAIL_SUPPRESS; }
        public string GetHS_C_HOLDER_INSTAL() { return this.HS_C_HOLDER_INSTAL; }
        public string GetEMAIL() { return this.EMAIL; }
        public string GetVAS_PRICE19() { return this.VAS_PRICE19; }
        public string GetMP_C_HOLDER_NAME() { return this.MP_C_HOLDER_NAME; }
        public string GetMOBILE_NO() { return this.MOBILE_NO; }
        public string GetMP_3_PARTY_NAME() { return this.MP_3_PARTY_NAME; }
        public string GetRATE_PLAN() { return this.RATE_PLAN; }
        public string GetOLD_SUB_NAME_MNP() { return this.OLD_SUB_NAME_MNP; }
        public global::System.Nullable<DateTime> GetCREATE_DATE() { return this.CREATE_DATE; }
        public string GetDUMMY2() { return this.DUMMY2; }
        public string GetVAS_NAME18() { return this.VAS_NAME18; }
        public string GetCONTACT_PERSON() { return this.CONTACT_PERSON; }
        public string GetVAS_PRICE5() { return this.VAS_PRICE5; }
        public string GetIDD_ROAMING() { return this.IDD_ROAMING; }
        public string GetVAS_NAME17() { return this.VAS_NAME17; }
        public string GetVAS_PRICE18() { return this.VAS_PRICE18; }
        public string GetREFERENCENO() { return this.REFERENCENO; }
        public string GetVAS_PRICE3() { return this.VAS_PRICE3; }
        public string GetPAYMENT_LIMIT() { return this.PAYMENT_LIMIT; }
        public string GetMP_3_PARTY_ID() { return this.MP_3_PARTY_ID; }
        public string GetN2_REGISTERED_NAME() { return this.N2_REGISTERED_NAME; }
        public string GetD_MAILL_SUPPRESS() { return this.D_MAILL_SUPPRESS; }
        public string GetAUTO_PAY() { return this.AUTO_PAY; }
        public string GetIDD_0060() { return this.IDD_0060; }
        public string GetCUSTOMER_GROUP() { return this.CUSTOMER_GROUP; }
        public string GetVAS_PRICE10() { return this.VAS_PRICE10; }
        public string GetVAS_NAME12() { return this.VAS_NAME12; }
        public string GetVAS_PRICE4() { return this.VAS_PRICE4; }
        public string GetVAS_NAME13() { return this.VAS_NAME13; }
        public string GetHS_PAY_AMT_INSTAL() { return this.HS_PAY_AMT_INSTAL; }
        public string GetSEC_SERVICE_PASSWORD() { return this.SEC_SERVICE_PASSWORD; }
        public string GetNETVIGATOR_FSA_NO() { return this.NETVIGATOR_FSA_NO; }
        public string GetSTUDENT_HK_ID() { return this.STUDENT_HK_ID; }
        public string GetVOICE_LANGUAGE() { return this.VOICE_LANGUAGE; }
        public string GetMP_APP_CODE() { return this.MP_APP_CODE; }
        public string GetEMAIL_BILL() { return this.EMAIL_BILL; }
        public string GetCREDIT_CARD_TYPE() { return this.CREDIT_CARD_TYPE; }
        public string GetBANK_ACCOUNT() { return this.BANK_ACCOUNT; }
        public string GetREG_ST_NAME() { return this.REG_ST_NAME; }
        public string GetCHINA_ROAMING() { return this.CHINA_ROAMING; }
        public global::System.Nullable<DateTime> GetDUMMY3() { return this.DUMMY3; }
        public string GetHS_EXP_INSTAL() { return this.HS_EXP_INSTAL; }
        public string GetACTUAL_USER() { return this.ACTUAL_USER; }
        public string GetTICKET_NO() { return this.TICKET_NO; }
        public string GetVAS_NAME14() { return this.VAS_NAME14; }
        public string GetCUT_OVER_WINDOW() { return this.CUT_OVER_WINDOW; }
        public string GetPREPAID_SIM_TO_POSTPAID() { return this.PREPAID_SIM_TO_POSTPAID; }
        public string GetCUT_OVER_DATE_MNP() { return this.CUT_OVER_DATE_MNP; }
        public global::System.Nullable<DateTime> GetHS_PAYMENT_TYPE2() { return this.HS_PAYMENT_TYPE2; }
        public string GetMP_AMOUNT() { return this.MP_AMOUNT; }
        public string GetSEC_SERVICE_NO() { return this.SEC_SERVICE_NO; }
        public string GetVAS_PRICE14() { return this.VAS_PRICE14; }
        public string GetREG_BLOCK() { return this.REG_BLOCK; }
        public string GetBIL_BUILDING() { return this.BIL_BUILDING; }
        public string GetVAS_NAME5() { return this.VAS_NAME5; }
        public string GetID_NO() { return this.ID_NO; }
        public string GetSEC_LANGUAGE() { return this.SEC_LANGUAGE; }
        public string GetVAS_PRICE7() { return this.VAS_PRICE7; }
        public string GetREG_ESTATE() { return this.REG_ESTATE; }
        public string GetBILL_ADDRESS_3() { return this.BILL_ADDRESS_3; }
        public string GetHS_APP_CODE_INSTAL() { return this.HS_APP_CODE_INSTAL; }
        public string GetFAX() { return this.FAX; }
        public string GetBIL_FLOOR() { return this.BIL_FLOOR; }
        public string GetOLD_SUB_HK_ID() { return this.OLD_SUB_HK_ID; }
        public string GetVAS_PRICE11() { return this.VAS_PRICE11; }
        public string GetMP_CARDNO() { return this.MP_CARDNO; }
        public string GetADDRESS_1() { return this.ADDRESS_1; }
        public string GetADDRESS_2() { return this.ADDRESS_2; }
        public string GetADDRESS_3() { return this.ADDRESS_3; }
        public string GetREG_FLOOR() { return this.REG_FLOOR; }
        public string GetFEATURE() { return this.FEATURE; }
        public global::System.Nullable<DateTime> GetBIL_AREA() { return this.BIL_AREA; }
        public string GetVAS_PRICE6() { return this.VAS_PRICE6; }
        public string GetJOINT_PROMOTION_CODE() { return this.JOINT_PROMOTION_CODE; }
        public string GetOFFICE_TEL() { return this.OFFICE_TEL; }
        public string GetVAS_PRICE16() { return this.VAS_PRICE16; }
        public string GetBIL_BLOCK() { return this.BIL_BLOCK; }
        public string GetHS_CARD_NO2() { return this.HS_CARD_NO2; }
        public string GetEXTG_AC_TYPE() { return this.EXTG_AC_TYPE; }
        public string GetVAS_NAME19() { return this.VAS_NAME19; }
        public string GetTELEMARKETING_SUPPRESS() { return this.TELEMARKETING_SUPPRESS; }
        public string GetHS_PERIOD_INSTAL() { return this.HS_PERIOD_INSTAL; }
        public string GetBIL_FLAT() { return this.BIL_FLAT; }
        public string GetSMARK_EXP() { return this.SMARK_EXP; }
        public string GetSMS_LANGUAGE() { return this.SMS_LANGUAGE; }
        public string GetVAS_PRICE20() { return this.VAS_PRICE20; }
        public string GetVAS_NAME11() { return this.VAS_NAME11; }
        public string GetTRADE_FIELD_2() { return this.TRADE_FIELD_2; }
        public string GetVAS_NAME10() { return this.VAS_NAME10; }
        public string GetTRADE_FIELD_1() { return this.TRADE_FIELD_1; }
        public string GetVAS_PRICE12() { return this.VAS_PRICE12; }
        public string GetDUMMY1() { return this.DUMMY1; }
        public string GetEXTG_AC_NO() { return this.EXTG_AC_NO; }
        public string GetBILL_ADDRESS_2() { return this.BILL_ADDRESS_2; }
        public global::System.Nullable<DateTime> GetSMARK_EXP_DATE() { return this.SMARK_EXP_DATE; }
        public string GetVAS_NAME9() { return this.VAS_NAME9; }
        public string GetREG_ST_NO() { return this.REG_ST_NO; }
        public string GetSEC_GREETING() { return this.SEC_GREETING; }
        public string GetVAS_PRICE2() { return this.VAS_PRICE2; }
        public string GetHANDSET_DESC() { return this.HANDSET_DESC; }
        public string GetREG_BUILDING() { return this.REG_BUILDING; }
        public string GetVAS_NAME2() { return this.VAS_NAME2; }
        public string GetVAS_NAME4() { return this.VAS_NAME4; }
        public string GetBIL_ST_NAME() { return this.BIL_ST_NAME; }
        public string GetVAS_NAME6() { return this.VAS_NAME6; }
        public string GetVAS_NAME7() { return this.VAS_NAME7; }
        public string GetAGREEMENT_DATE() { return this.AGREEMENT_DATE; }
        public string GetVAS_PRICE15() { return this.VAS_PRICE15; }
        public string GetREG_FLAT() { return this.REG_FLAT; }
        public string GetCONTACT_TEL() { return this.CONTACT_TEL; }
        public string GetHS_PAY_AMT2() { return this.HS_PAY_AMT2; }
        public string GetSALESMAN_CODE() { return this.SALESMAN_CODE; }
        public string GetVAS_NAME15() { return this.VAS_NAME15; }
        public string GetBILL_CU_NAME() { return this.BILL_CU_NAME; }
        public string GetVAS_PRICE8() { return this.VAS_PRICE8; }
        public string GetDNO() { return this.DNO; }
        public string GetREG_DISTRICT() { return this.REG_DISTRICT; }
        public string GetSTUDENT_BIRTH_D() { return this.STUDENT_BIRTH_D; }
        public string GetVAS_PRICE1() { return this.VAS_PRICE1; }
        public string GetMP_3_BANK_ACCOUNT() { return this.MP_3_BANK_ACCOUNT; }
        public string GetVAS_NAME8() { return this.VAS_NAME8; }
        public string GetOLD_SUB_ID_TYPE_MNP() { return this.OLD_SUB_ID_TYPE_MNP; }
        public string GetREGION_CITY() { return this.REGION_CITY; }
        public string GetCREATED_BY() { return this.CREATED_BY; }
        public string GetVAS_NAME20() { return this.VAS_NAME20; }
        public string GetVAS_PRICE17() { return this.VAS_PRICE17; }
        public string GetCARD_NO() { return this.CARD_NO; }
        public string GetVAS_NAME1() { return this.VAS_NAME1; }
        public string GetCUT_OVER_TIME_MNP() { return this.CUT_OVER_TIME_MNP; }
        public string GetVAS_NAME3() { return this.VAS_NAME3; }
        public string GetBIL_ST_NO() { return this.BIL_ST_NO; }
        public string GetHS_CARD_NO_INSTAL() { return this.HS_CARD_NO_INSTAL; }
        public string GetOWNER_NAME() { return this.OWNER_NAME; }
        public string GetPCCW_LANDLINE_NO() { return this.PCCW_LANDLINE_NO; }
        public string GetSIM_CARD_NO() { return this.SIM_CARD_NO; }
        public string GetBIL_ESTATE() { return this.BIL_ESTATE; }
        public string GetMOBILE_0060() { return this.MOBILE_0060; }
        public string GetMP_EXPIRYDATE() { return this.MP_EXPIRYDATE; }
        public string GetSMS_SUPPRESS() { return this.SMS_SUPPRESS; }
        public string GetAGREEMENT_NO() { return this.AGREEMENT_NO; }
        public string GetACTIVATION_DATE() { return this.ACTIVATION_DATE; }
        public string GetFAMILY_REFERRAL_DN() { return this.FAMILY_REFERRAL_DN; }
        public string GetPAYMENT_TYPE() { return this.PAYMENT_TYPE; }
        public string GetPREPAID_SIM_NO() { return this.PREPAID_SIM_NO; }
        public string GetHS_APP_CODE2() { return this.HS_APP_CODE2; }
        public string GetVAS_NAME16() { return this.VAS_NAME16; }
        public global::System.Nullable<DateTime> GetREG_AREA() { return this.REG_AREA; }

        public bool SetID_NO_TYPE(string value)
        {
            this.ID_NO_TYPE = value;
            return true;
        }
        public bool SetVAS_PRICE9(string value)
        {
            this.VAS_PRICE9 = value;
            return true;
        }
        public bool SetVAS_PRICE13(string value)
        {
            this.VAS_PRICE13 = value;
            return true;
        }
        public bool SetBIL_DISTRICT(string value)
        {
            this.BIL_DISTRICT = value;
            return true;
        }
        public bool SetIMEI(string value)
        {
            this.IMEI = value;
            return true;
        }
        public bool SetHS_C_HOLDER_NAME2(string value)
        {
            this.HS_C_HOLDER_NAME2 = value;
            return true;
        }
        public bool SetBILL_ADDRESS_1(string value)
        {
            this.BILL_ADDRESS_1 = value;
            return true;
        }
        public bool SetHS_EXP_2(string value)
        {
            this.HS_EXP_2 = value;
            return true;
        }
        public bool SetBANK_NAME(string value)
        {
            this.BANK_NAME = value;
            return true;
        }
        public bool SetMP_CARD_OWNER(string value)
        {
            this.MP_CARD_OWNER = value;
            return true;
        }
        public bool SetEXPIRY_DATE(string value)
        {
            this.EXPIRY_DATE = value;
            return true;
        }
        public bool SetEMAIL_SUPPRESS(string value)
        {
            this.EMAIL_SUPPRESS = value;
            return true;
        }
        public bool SetHS_C_HOLDER_INSTAL(string value)
        {
            this.HS_C_HOLDER_INSTAL = value;
            return true;
        }
        public bool SetEMAIL(string value)
        {
            this.EMAIL = value;
            return true;
        }
        public bool SetVAS_PRICE19(string value)
        {
            this.VAS_PRICE19 = value;
            return true;
        }
        public bool SetMP_C_HOLDER_NAME(string value)
        {
            this.MP_C_HOLDER_NAME = value;
            return true;
        }
        public bool SetMOBILE_NO(string value)
        {
            this.MOBILE_NO = value;
            return true;
        }
        public bool SetMP_3_PARTY_NAME(string value)
        {
            this.MP_3_PARTY_NAME = value;
            return true;
        }
        public bool SetRATE_PLAN(string value)
        {
            this.RATE_PLAN = value;
            return true;
        }
        public bool SetOLD_SUB_NAME_MNP(string value)
        {
            this.OLD_SUB_NAME_MNP = value;
            return true;
        }
        public bool SetCREATE_DATE(global::System.Nullable<DateTime> value)
        {
            this.CREATE_DATE = value;
            return true;
        }
        public bool SetDUMMY2(string value)
        {
            this.DUMMY2 = value;
            return true;
        }
        public bool SetVAS_NAME18(string value)
        {
            this.VAS_NAME18 = value;
            return true;
        }
        public bool SetCONTACT_PERSON(string value)
        {
            this.CONTACT_PERSON = value;
            return true;
        }
        public bool SetVAS_PRICE5(string value)
        {
            this.VAS_PRICE5 = value;
            return true;
        }
        public bool SetIDD_ROAMING(string value)
        {
            this.IDD_ROAMING = value;
            return true;
        }
        public bool SetVAS_NAME17(string value)
        {
            this.VAS_NAME17 = value;
            return true;
        }
        public bool SetVAS_PRICE18(string value)
        {
            this.VAS_PRICE18 = value;
            return true;
        }
        public bool SetREFERENCENO(string value)
        {
            this.REFERENCENO = value;
            return true;
        }
        public bool SetVAS_PRICE3(string value)
        {
            this.VAS_PRICE3 = value;
            return true;
        }
        public bool SetPAYMENT_LIMIT(string value)
        {
            this.PAYMENT_LIMIT = value;
            return true;
        }
        public bool SetMP_3_PARTY_ID(string value)
        {
            this.MP_3_PARTY_ID = value;
            return true;
        }
        public bool SetN2_REGISTERED_NAME(string value)
        {
            this.N2_REGISTERED_NAME = value;
            return true;
        }
        public bool SetD_MAILL_SUPPRESS(string value)
        {
            this.D_MAILL_SUPPRESS = value;
            return true;
        }
        public bool SetAUTO_PAY(string value)
        {
            this.AUTO_PAY = value;
            return true;
        }
        public bool SetIDD_0060(string value)
        {
            this.IDD_0060 = value;
            return true;
        }
        public bool SetCUSTOMER_GROUP(string value)
        {
            this.CUSTOMER_GROUP = value;
            return true;
        }
        public bool SetVAS_PRICE10(string value)
        {
            this.VAS_PRICE10 = value;
            return true;
        }
        public bool SetVAS_NAME12(string value)
        {
            this.VAS_NAME12 = value;
            return true;
        }
        public bool SetVAS_PRICE4(string value)
        {
            this.VAS_PRICE4 = value;
            return true;
        }
        public bool SetVAS_NAME13(string value)
        {
            this.VAS_NAME13 = value;
            return true;
        }
        public bool SetHS_PAY_AMT_INSTAL(string value)
        {
            this.HS_PAY_AMT_INSTAL = value;
            return true;
        }
        public bool SetSEC_SERVICE_PASSWORD(string value)
        {
            this.SEC_SERVICE_PASSWORD = value;
            return true;
        }
        public bool SetNETVIGATOR_FSA_NO(string value)
        {
            this.NETVIGATOR_FSA_NO = value;
            return true;
        }
        public bool SetSTUDENT_HK_ID(string value)
        {
            this.STUDENT_HK_ID = value;
            return true;
        }
        public bool SetVOICE_LANGUAGE(string value)
        {
            this.VOICE_LANGUAGE = value;
            return true;
        }
        public bool SetMP_APP_CODE(string value)
        {
            this.MP_APP_CODE = value;
            return true;
        }
        public bool SetEMAIL_BILL(string value)
        {
            this.EMAIL_BILL = value;
            return true;
        }
        public bool SetCREDIT_CARD_TYPE(string value)
        {
            this.CREDIT_CARD_TYPE = value;
            return true;
        }
        public bool SetBANK_ACCOUNT(string value)
        {
            this.BANK_ACCOUNT = value;
            return true;
        }
        public bool SetREG_ST_NAME(string value)
        {
            this.REG_ST_NAME = value;
            return true;
        }
        public bool SetCHINA_ROAMING(string value)
        {
            this.CHINA_ROAMING = value;
            return true;
        }
        public bool SetDUMMY3(global::System.Nullable<DateTime> value)
        {
            this.DUMMY3 = value;
            return true;
        }
        public bool SetHS_EXP_INSTAL(string value)
        {
            this.HS_EXP_INSTAL = value;
            return true;
        }
        public bool SetACTUAL_USER(string value)
        {
            this.ACTUAL_USER = value;
            return true;
        }
        public bool SetTICKET_NO(string value)
        {
            this.TICKET_NO = value;
            return true;
        }
        public bool SetVAS_NAME14(string value)
        {
            this.VAS_NAME14 = value;
            return true;
        }
        public bool SetCUT_OVER_WINDOW(string value)
        {
            this.CUT_OVER_WINDOW = value;
            return true;
        }
        public bool SetPREPAID_SIM_TO_POSTPAID(string value)
        {
            this.PREPAID_SIM_TO_POSTPAID = value;
            return true;
        }
        public bool SetCUT_OVER_DATE_MNP(string value)
        {
            this.CUT_OVER_DATE_MNP = value;
            return true;
        }
        public bool SetHS_PAYMENT_TYPE2(global::System.Nullable<DateTime> value)
        {
            this.HS_PAYMENT_TYPE2 = value;
            return true;
        }
        public bool SetMP_AMOUNT(string value)
        {
            this.MP_AMOUNT = value;
            return true;
        }
        public bool SetSEC_SERVICE_NO(string value)
        {
            this.SEC_SERVICE_NO = value;
            return true;
        }
        public bool SetVAS_PRICE14(string value)
        {
            this.VAS_PRICE14 = value;
            return true;
        }
        public bool SetREG_BLOCK(string value)
        {
            this.REG_BLOCK = value;
            return true;
        }
        public bool SetBIL_BUILDING(string value)
        {
            this.BIL_BUILDING = value;
            return true;
        }
        public bool SetVAS_NAME5(string value)
        {
            this.VAS_NAME5 = value;
            return true;
        }
        public bool SetID_NO(string value)
        {
            this.ID_NO = value;
            return true;
        }
        public bool SetSEC_LANGUAGE(string value)
        {
            this.SEC_LANGUAGE = value;
            return true;
        }
        public bool SetVAS_PRICE7(string value)
        {
            this.VAS_PRICE7 = value;
            return true;
        }
        public bool SetREG_ESTATE(string value)
        {
            this.REG_ESTATE = value;
            return true;
        }
        public bool SetBILL_ADDRESS_3(string value)
        {
            this.BILL_ADDRESS_3 = value;
            return true;
        }
        public bool SetHS_APP_CODE_INSTAL(string value)
        {
            this.HS_APP_CODE_INSTAL = value;
            return true;
        }
        public bool SetFAX(string value)
        {
            this.FAX = value;
            return true;
        }
        public bool SetBIL_FLOOR(string value)
        {
            this.BIL_FLOOR = value;
            return true;
        }
        public bool SetOLD_SUB_HK_ID(string value)
        {
            this.OLD_SUB_HK_ID = value;
            return true;
        }
        public bool SetVAS_PRICE11(string value)
        {
            this.VAS_PRICE11 = value;
            return true;
        }
        public bool SetMP_CARDNO(string value)
        {
            this.MP_CARDNO = value;
            return true;
        }
        public bool SetADDRESS_1(string value)
        {
            this.ADDRESS_1 = value;
            return true;
        }
        public bool SetADDRESS_2(string value)
        {
            this.ADDRESS_2 = value;
            return true;
        }
        public bool SetADDRESS_3(string value)
        {
            this.ADDRESS_3 = value;
            return true;
        }
        public bool SetREG_FLOOR(string value)
        {
            this.REG_FLOOR = value;
            return true;
        }
        public bool SetFEATURE(string value)
        {
            this.FEATURE = value;
            return true;
        }
        public bool SetBIL_AREA(global::System.Nullable<DateTime> value)
        {
            this.BIL_AREA = value;
            return true;
        }
        public bool SetVAS_PRICE6(string value)
        {
            this.VAS_PRICE6 = value;
            return true;
        }
        public bool SetJOINT_PROMOTION_CODE(string value)
        {
            this.JOINT_PROMOTION_CODE = value;
            return true;
        }
        public bool SetOFFICE_TEL(string value)
        {
            this.OFFICE_TEL = value;
            return true;
        }
        public bool SetVAS_PRICE16(string value)
        {
            this.VAS_PRICE16 = value;
            return true;
        }
        public bool SetBIL_BLOCK(string value)
        {
            this.BIL_BLOCK = value;
            return true;
        }
        public bool SetHS_CARD_NO2(string value)
        {
            this.HS_CARD_NO2 = value;
            return true;
        }
        public bool SetEXTG_AC_TYPE(string value)
        {
            this.EXTG_AC_TYPE = value;
            return true;
        }
        public bool SetVAS_NAME19(string value)
        {
            this.VAS_NAME19 = value;
            return true;
        }
        public bool SetTELEMARKETING_SUPPRESS(string value)
        {
            this.TELEMARKETING_SUPPRESS = value;
            return true;
        }
        public bool SetHS_PERIOD_INSTAL(string value)
        {
            this.HS_PERIOD_INSTAL = value;
            return true;
        }
        public bool SetBIL_FLAT(string value)
        {
            this.BIL_FLAT = value;
            return true;
        }
        public bool SetSMARK_EXP(string value)
        {
            this.SMARK_EXP = value;
            return true;
        }
        public bool SetSMS_LANGUAGE(string value)
        {
            this.SMS_LANGUAGE = value;
            return true;
        }
        public bool SetVAS_PRICE20(string value)
        {
            this.VAS_PRICE20 = value;
            return true;
        }
        public bool SetVAS_NAME11(string value)
        {
            this.VAS_NAME11 = value;
            return true;
        }
        public bool SetTRADE_FIELD_2(string value)
        {
            this.TRADE_FIELD_2 = value;
            return true;
        }
        public bool SetVAS_NAME10(string value)
        {
            this.VAS_NAME10 = value;
            return true;
        }
        public bool SetTRADE_FIELD_1(string value)
        {
            this.TRADE_FIELD_1 = value;
            return true;
        }
        public bool SetVAS_PRICE12(string value)
        {
            this.VAS_PRICE12 = value;
            return true;
        }
        public bool SetDUMMY1(string value)
        {
            this.DUMMY1 = value;
            return true;
        }
        public bool SetEXTG_AC_NO(string value)
        {
            this.EXTG_AC_NO = value;
            return true;
        }
        public bool SetBILL_ADDRESS_2(string value)
        {
            this.BILL_ADDRESS_2 = value;
            return true;
        }
        public bool SetSMARK_EXP_DATE(global::System.Nullable<DateTime> value)
        {
            this.SMARK_EXP_DATE = value;
            return true;
        }
        public bool SetVAS_NAME9(string value)
        {
            this.VAS_NAME9 = value;
            return true;
        }
        public bool SetREG_ST_NO(string value)
        {
            this.REG_ST_NO = value;
            return true;
        }
        public bool SetSEC_GREETING(string value)
        {
            this.SEC_GREETING = value;
            return true;
        }
        public bool SetVAS_PRICE2(string value)
        {
            this.VAS_PRICE2 = value;
            return true;
        }
        public bool SetHANDSET_DESC(string value)
        {
            this.HANDSET_DESC = value;
            return true;
        }
        public bool SetREG_BUILDING(string value)
        {
            this.REG_BUILDING = value;
            return true;
        }
        public bool SetVAS_NAME2(string value)
        {
            this.VAS_NAME2 = value;
            return true;
        }
        public bool SetVAS_NAME4(string value)
        {
            this.VAS_NAME4 = value;
            return true;
        }
        public bool SetBIL_ST_NAME(string value)
        {
            this.BIL_ST_NAME = value;
            return true;
        }
        public bool SetVAS_NAME6(string value)
        {
            this.VAS_NAME6 = value;
            return true;
        }
        public bool SetVAS_NAME7(string value)
        {
            this.VAS_NAME7 = value;
            return true;
        }
        public bool SetAGREEMENT_DATE(string value)
        {
            this.AGREEMENT_DATE = value;
            return true;
        }
        public bool SetVAS_PRICE15(string value)
        {
            this.VAS_PRICE15 = value;
            return true;
        }
        public bool SetREG_FLAT(string value)
        {
            this.REG_FLAT = value;
            return true;
        }
        public bool SetCONTACT_TEL(string value)
        {
            this.CONTACT_TEL = value;
            return true;
        }
        public bool SetHS_PAY_AMT2(string value)
        {
            this.HS_PAY_AMT2 = value;
            return true;
        }
        public bool SetSALESMAN_CODE(string value)
        {
            this.SALESMAN_CODE = value;
            return true;
        }
        public bool SetVAS_NAME15(string value)
        {
            this.VAS_NAME15 = value;
            return true;
        }
        public bool SetBILL_CU_NAME(string value)
        {
            this.BILL_CU_NAME = value;
            return true;
        }
        public bool SetVAS_PRICE8(string value)
        {
            this.VAS_PRICE8 = value;
            return true;
        }
        public bool SetDNO(string value)
        {
            this.DNO = value;
            return true;
        }
        public bool SetREG_DISTRICT(string value)
        {
            this.REG_DISTRICT = value;
            return true;
        }
        public bool SetSTUDENT_BIRTH_D(string value)
        {
            this.STUDENT_BIRTH_D = value;
            return true;
        }
        public bool SetVAS_PRICE1(string value)
        {
            this.VAS_PRICE1 = value;
            return true;
        }
        public bool SetMP_3_BANK_ACCOUNT(string value)
        {
            this.MP_3_BANK_ACCOUNT = value;
            return true;
        }
        public bool SetVAS_NAME8(string value)
        {
            this.VAS_NAME8 = value;
            return true;
        }
        public bool SetOLD_SUB_ID_TYPE_MNP(string value)
        {
            this.OLD_SUB_ID_TYPE_MNP = value;
            return true;
        }
        public bool SetREGION_CITY(string value)
        {
            this.REGION_CITY = value;
            return true;
        }
        public bool SetCREATED_BY(string value)
        {
            this.CREATED_BY = value;
            return true;
        }
        public bool SetVAS_NAME20(string value)
        {
            this.VAS_NAME20 = value;
            return true;
        }
        public bool SetVAS_PRICE17(string value)
        {
            this.VAS_PRICE17 = value;
            return true;
        }
        public bool SetCARD_NO(string value)
        {
            this.CARD_NO = value;
            return true;
        }
        public bool SetVAS_NAME1(string value)
        {
            this.VAS_NAME1 = value;
            return true;
        }
        public bool SetCUT_OVER_TIME_MNP(string value)
        {
            this.CUT_OVER_TIME_MNP = value;
            return true;
        }
        public bool SetVAS_NAME3(string value)
        {
            this.VAS_NAME3 = value;
            return true;
        }
        public bool SetBIL_ST_NO(string value)
        {
            this.BIL_ST_NO = value;
            return true;
        }
        public bool SetHS_CARD_NO_INSTAL(string value)
        {
            this.HS_CARD_NO_INSTAL = value;
            return true;
        }
        public bool SetOWNER_NAME(string value)
        {
            this.OWNER_NAME = value;
            return true;
        }
        public bool SetPCCW_LANDLINE_NO(string value)
        {
            this.PCCW_LANDLINE_NO = value;
            return true;
        }
        public bool SetSIM_CARD_NO(string value)
        {
            this.SIM_CARD_NO = value;
            return true;
        }
        public bool SetBIL_ESTATE(string value)
        {
            this.BIL_ESTATE = value;
            return true;
        }
        public bool SetMOBILE_0060(string value)
        {
            this.MOBILE_0060 = value;
            return true;
        }
        public bool SetMP_EXPIRYDATE(string value)
        {
            this.MP_EXPIRYDATE = value;
            return true;
        }
        public bool SetSMS_SUPPRESS(string value)
        {
            this.SMS_SUPPRESS = value;
            return true;
        }
        public bool SetAGREEMENT_NO(string value)
        {
            this.AGREEMENT_NO = value;
            return true;
        }
        public bool SetACTIVATION_DATE(string value)
        {
            this.ACTIVATION_DATE = value;
            return true;
        }
        public bool SetFAMILY_REFERRAL_DN(string value)
        {
            this.FAMILY_REFERRAL_DN = value;
            return true;
        }
        public bool SetPAYMENT_TYPE(string value)
        {
            this.PAYMENT_TYPE = value;
            return true;
        }
        public bool SetPREPAID_SIM_NO(string value)
        {
            this.PREPAID_SIM_NO = value;
            return true;
        }
        public bool SetHS_APP_CODE2(string value)
        {
            this.HS_APP_CODE2 = value;
            return true;
        }
        public bool SetVAS_NAME16(string value)
        {
            this.VAS_NAME16 = value;
            return true;
        }
        public bool SetREG_AREA(global::System.Nullable<DateTime> value)
        {
            this.REG_AREA = value;
            return true;
        }
        #endregion

        #region Insert
        public bool CreateRecord()
        {
            StringBuilder _oQuery = new StringBuilder();
            StringBuilder _oValueQuery = new StringBuilder();
            StringBuilder _oInsertValueQuery = new StringBuilder();
            if (!string.IsNullOrEmpty(this.REFERENCENO))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.REFERENCENO);
                _oInsertValueQuery.Append("'" + this.REFERENCENO.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.STUDENT_BIRTH_D))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.STUDENT_BIRTH_D);
                _oInsertValueQuery.Append("'" + this.STUDENT_BIRTH_D.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.MP_CARD_OWNER))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.MP_CARD_OWNER);
                _oInsertValueQuery.Append("'" + this.MP_CARD_OWNER.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.MP_3_PARTY_NAME))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.MP_3_PARTY_NAME);
                _oInsertValueQuery.Append("'" + this.MP_3_PARTY_NAME.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.MP_CARDNO))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.MP_CARDNO);
                _oInsertValueQuery.Append("'" + this.MP_CARDNO.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.MP_C_HOLDER_NAME))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.MP_C_HOLDER_NAME);
                _oInsertValueQuery.Append("'" + this.MP_C_HOLDER_NAME.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.MP_3_PARTY_ID))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.MP_3_PARTY_ID);
                _oInsertValueQuery.Append("'" + this.MP_3_PARTY_ID.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.MP_EXPIRYDATE))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.MP_EXPIRYDATE);
                _oInsertValueQuery.Append("'" + this.MP_EXPIRYDATE.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.CUSTOMER_GROUP))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.CUSTOMER_GROUP);
                _oInsertValueQuery.Append("'" + this.CUSTOMER_GROUP.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.SMS_SUPPRESS))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.SMS_SUPPRESS);
                _oInsertValueQuery.Append("'" + this.SMS_SUPPRESS.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.EMAIL))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.EMAIL);
                _oInsertValueQuery.Append("'" + this.EMAIL.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.BILL_ADDRESS_1))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.BILL_ADDRESS_1);
                _oInsertValueQuery.Append("'" + this.BILL_ADDRESS_1.Trim().Replace("'", "''") + "'");
            }

            if (!string.IsNullOrEmpty(this.EMAIL_BILL))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.EMAIL_BILL);
                _oInsertValueQuery.Append("'" + this.EMAIL_BILL.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.PAYMENT_TYPE))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.PAYMENT_TYPE);
                _oInsertValueQuery.Append("'" + this.PAYMENT_TYPE.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.STUDENT_HK_ID))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.STUDENT_HK_ID);
                _oInsertValueQuery.Append("'" + this.STUDENT_HK_ID.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.BILL_CU_NAME))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.BILL_CU_NAME);
                _oInsertValueQuery.Append("'" + this.BILL_CU_NAME.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.N2_REGISTERED_NAME))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.N2_REGISTERED_NAME);
                _oInsertValueQuery.Append("'" + this.N2_REGISTERED_NAME.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.TICKET_NO))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.TICKET_NO);
                _oInsertValueQuery.Append("'" + this.TICKET_NO.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.ADDRESS_1))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.ADDRESS_1);
                _oInsertValueQuery.Append("'" + this.ADDRESS_1.Trim().Replace("'", "''") + "'");
            }

            if (!string.IsNullOrEmpty(this.AGREEMENT_DATE))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.AGREEMENT_DATE);
                _oInsertValueQuery.Append("'" + this.AGREEMENT_DATE.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.AGREEMENT_NO))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.AGREEMENT_NO);
                _oInsertValueQuery.Append("'" + this.AGREEMENT_NO.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.REGION_CITY))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.REGION_CITY);
                _oInsertValueQuery.Append("'" + this.REGION_CITY.Trim() + "'");
            }


            if (!string.IsNullOrEmpty(this.ID_NO_TYPE))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.ID_NO_TYPE);
                _oInsertValueQuery.Append("'" + this.ID_NO_TYPE.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.ID_NO))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.ID_NO);
                _oInsertValueQuery.Append("'" + this.ID_NO.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.BILL_ADDRESS_3))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.BILL_ADDRESS_3);
                _oInsertValueQuery.Append("'" + this.BILL_ADDRESS_3.Trim() + "'");
            }

            if (!string.IsNullOrEmpty(this.BANK_ACCOUNT))
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.BANK_ACCOUNT);
                _oInsertValueQuery.Append("'" + this.BANK_ACCOUNT.Trim() + "'");
            }

            if (this.CREATE_DATE != null)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.CREATE_DATE);
                _oInsertValueQuery.Append(" to_date('" + ((DateTime)this.CREATE_DATE).ToString("dd/MM/yyyy") + "','dd/mm/yyyy')  ");
            }


            if (this.SMARK_EXP_DATE != null)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.SMARK_EXP_DATE);
                _oInsertValueQuery.Append(" to_date('" + ((DateTime)this.SMARK_EXP_DATE).ToString("dd/MM/yyyy") + "','dd/mm/yyyy')  ");
            }

            
            
           if (!string.IsNullOrEmpty(this.PREPAID_SIM_TO_POSTPAID))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.PREPAID_SIM_TO_POSTPAID);
               _oInsertValueQuery.Append("'" + this.PREPAID_SIM_TO_POSTPAID.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.OLD_SUB_HK_ID))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.OLD_SUB_HK_ID);
               _oInsertValueQuery.Append("'" + this.OLD_SUB_HK_ID.Trim() + "'");
           }


           if (!string.IsNullOrEmpty(this.JOINT_PROMOTION_CODE))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.JOINT_PROMOTION_CODE);
               _oInsertValueQuery.Append("'" + this.JOINT_PROMOTION_CODE.Trim() + "'");
           }


           if (!string.IsNullOrEmpty(this.HANDSET_DESC))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.HANDSET_DESC);
               _oInsertValueQuery.Append("'" + this.HANDSET_DESC.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.IMEI))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.IMEI);
               _oInsertValueQuery.Append("'" + this.IMEI.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.DNO))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.DNO);
               _oInsertValueQuery.Append("'" + this.DNO.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.FAX))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.FAX);
               _oInsertValueQuery.Append("'" + this.FAX.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.VAS_NAME15))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_NAME15);
               _oInsertValueQuery.Append("'" + this.VAS_NAME15.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.CONTACT_PERSON))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.CONTACT_PERSON);
               _oInsertValueQuery.Append("'" + this.CONTACT_PERSON.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.OWNER_NAME))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.OWNER_NAME);
               _oInsertValueQuery.Append("'" + this.OWNER_NAME.Trim() + "'");
           }

           
           if (!string.IsNullOrEmpty(this.BANK_NAME))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.BANK_NAME);
               _oInsertValueQuery.Append("'" + this.BANK_NAME.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.OLD_SUB_NAME_MNP))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.OLD_SUB_NAME_MNP);
               _oInsertValueQuery.Append("'" + this.OLD_SUB_NAME_MNP.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.REG_BUILDING))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.REG_BUILDING);
               _oInsertValueQuery.Append("'" + this.REG_BUILDING.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.REG_ESTATE))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.REG_ESTATE);
               _oInsertValueQuery.Append("'" + this.REG_ESTATE.Trim() + "'");
           }


           if (!string.IsNullOrEmpty(this.REG_ST_NAME))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.REG_ST_NAME);
               _oInsertValueQuery.Append("'" + this.REG_ST_NAME.Trim() + "'");
           }


           if (!string.IsNullOrEmpty(this.REG_DISTRICT))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.REG_DISTRICT);
               _oInsertValueQuery.Append("'" + this.REG_DISTRICT.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.BIL_BUILDING))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.BIL_BUILDING);
               _oInsertValueQuery.Append("'" + this.BIL_BUILDING.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.BIL_ESTATE))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.BIL_ESTATE);
               _oInsertValueQuery.Append("'" + this.BIL_ESTATE.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.BIL_ST_NAME))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.BIL_ST_NAME);
               _oInsertValueQuery.Append("'" + this.BIL_ST_NAME.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.BIL_DISTRICT))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.BIL_DISTRICT);
               _oInsertValueQuery.Append("'" + this.BIL_DISTRICT.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.VAS_NAME1))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_NAME1);
               _oInsertValueQuery.Append("'" + this.VAS_NAME1.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.VAS_NAME2))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_NAME2);
               _oInsertValueQuery.Append("'" + this.VAS_NAME2.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.VAS_NAME3))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_NAME3);
               _oInsertValueQuery.Append("'" + this.VAS_NAME3.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.VAS_NAME4))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_NAME4);
               _oInsertValueQuery.Append("'" + this.VAS_NAME4.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.VAS_NAME5))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_NAME5);
               _oInsertValueQuery.Append("'" + this.VAS_NAME5.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.VAS_NAME6))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_NAME6);
               _oInsertValueQuery.Append("'" + this.VAS_NAME6.Trim() + "'");
           }
           if (!string.IsNullOrEmpty(this.VAS_NAME7))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_NAME7);
               _oInsertValueQuery.Append("'" + this.VAS_NAME7.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.VAS_NAME8))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_NAME8);
               _oInsertValueQuery.Append("'" + this.VAS_NAME8.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.VAS_NAME9))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_NAME9);
               _oInsertValueQuery.Append("'" + this.VAS_NAME9.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.VAS_NAME10))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_NAME10);
               _oInsertValueQuery.Append("'" + this.VAS_NAME10.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.VAS_NAME11))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_NAME11);
               _oInsertValueQuery.Append("'" + this.VAS_NAME11.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.VAS_NAME12))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_NAME12);
               _oInsertValueQuery.Append("'" + this.VAS_NAME12.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.VAS_NAME13))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_NAME13);
               _oInsertValueQuery.Append("'" + this.VAS_NAME13.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.VAS_NAME14))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_NAME14);
               _oInsertValueQuery.Append("'" + this.VAS_NAME14.Trim() + "'");
           }
           if (!string.IsNullOrEmpty(this.FAMILY_REFERRAL_DN))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.FAMILY_REFERRAL_DN);
               _oInsertValueQuery.Append("'" + this.FAMILY_REFERRAL_DN.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.VAS_NAME16))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_NAME16);
               _oInsertValueQuery.Append("'" + this.VAS_NAME16.Trim() + "'");
           }
           if (!string.IsNullOrEmpty(this.VAS_NAME17))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_NAME17);
               _oInsertValueQuery.Append("'" + this.VAS_NAME17.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.VAS_NAME19))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_NAME19);
               _oInsertValueQuery.Append("'" + this.VAS_NAME19.Trim() + "'");
           }
           if (!string.IsNullOrEmpty(this.VAS_NAME20))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_NAME20);
               _oInsertValueQuery.Append("'" + this.VAS_NAME20.Trim() + "'");
           }
           if (!string.IsNullOrEmpty(this.DUMMY1))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.DUMMY1);
               _oInsertValueQuery.Append("'" + this.DUMMY1.Trim() + "'");
           }
           if (!string.IsNullOrEmpty(this.VAS_PRICE4))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.VAS_PRICE4);
               _oInsertValueQuery.Append("'" + this.VAS_PRICE4.Trim() + "'");
           }

           if (!string.IsNullOrEmpty(this.OFFICE_TEL))
           {
               if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
               if (!_oInsertValueQuery.ToString().Equals(string.Empty)) { _oInsertValueQuery.Append(","); }
               _oValueQuery.Append(SundayActivation.Para.OFFICE_TEL);
               _oInsertValueQuery.Append("'" + this.OFFICE_TEL.Trim() + "'");
           }

            bool _bFlag = false;
            if (!_oValueQuery.ToString().Equals(string.Empty) &&
                !_oInsertValueQuery.ToString().Equals(string.Empty))
            {
                _oQuery.Append("INSERT INTO Sunday_Activation (");
                _oQuery.Append(_oValueQuery);
                _oQuery.Append(") VALUES (");
                _oQuery.Append(_oInsertValueQuery);
                _oQuery.Append(")");
                _bFlag = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
                if (_bFlag) WebFunc.SaveQuery(_oQuery.ToString());
                return _bFlag;
            }
            return _bFlag;
        }
        #endregion

        #region Save
        public bool Save()
        {
            StringBuilder _oQuery = new StringBuilder();
            StringBuilder _oValueQuery = new StringBuilder();

            if (this.REFERENCENO != null || this.REFERENCENO == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.REFERENCENO + "=");
                _oValueQuery.Append("'" + this.REFERENCENO.Trim() + "'");
            }

            if (this.STUDENT_BIRTH_D != null || this.STUDENT_BIRTH_D == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.STUDENT_BIRTH_D + "=");
                _oValueQuery.Append("'" + this.STUDENT_BIRTH_D.Trim() + "'");
            }

            if (this.MP_CARD_OWNER != null || this.MP_CARD_OWNER == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.MP_CARD_OWNER + "=");
                _oValueQuery.Append("'" + this.MP_CARD_OWNER.Trim() + "'");
            }

            if (this.MP_3_PARTY_NAME != null || this.MP_3_PARTY_NAME == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.MP_3_PARTY_NAME + "=");
                _oValueQuery.Append("'" + this.MP_3_PARTY_NAME.Trim() + "'");
            }

            if (this.MP_CARDNO != null || this.MP_CARDNO == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.MP_CARDNO + "=");
                _oValueQuery.Append("'" + this.MP_CARDNO.Trim() + "'");
            }

            if (this.MP_C_HOLDER_NAME != null || this.MP_C_HOLDER_NAME == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.MP_C_HOLDER_NAME + "=");
                _oValueQuery.Append("'" + this.MP_C_HOLDER_NAME.Trim() + "'");
            }

            if (this.MP_3_PARTY_ID != null || this.MP_3_PARTY_ID == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.MP_3_PARTY_ID + "=");
                _oValueQuery.Append("'" + this.MP_3_PARTY_ID.Trim() + "'");
            }

            if (this.MP_EXPIRYDATE != null || this.MP_EXPIRYDATE == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.MP_EXPIRYDATE + "=");
                _oValueQuery.Append("'" + this.MP_EXPIRYDATE.Trim() + "'");
            }

            if (this.CUSTOMER_GROUP != null || this.CUSTOMER_GROUP == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.CUSTOMER_GROUP + "=");
                _oValueQuery.Append("'" + this.CUSTOMER_GROUP.Trim() + "'");
            }

            if (this.SMS_SUPPRESS != null || this.SMS_SUPPRESS == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.SMS_SUPPRESS + "=");
                _oValueQuery.Append("'" + this.SMS_SUPPRESS.Trim() + "'");
            }

            if (this.EMAIL != null || this.EMAIL == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.EMAIL + "=");
                _oValueQuery.Append("'" + this.EMAIL.Trim() + "'");
            }

            if (this.BILL_ADDRESS_1 != null || this.BILL_ADDRESS_1 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.BILL_ADDRESS_1 + "=");
                _oValueQuery.Append("'" + this.BILL_ADDRESS_1.Trim().Replace("'", "''") + "'");
            }

            if (this.EMAIL_BILL != null || this.EMAIL_BILL == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.EMAIL_BILL + "=");
                _oValueQuery.Append("'" + this.EMAIL_BILL.Trim() + "'");
            }

            if (this.PAYMENT_TYPE != null || this.PAYMENT_TYPE == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.PAYMENT_TYPE + "=");
                _oValueQuery.Append("'" + this.PAYMENT_TYPE.Trim() + "'");
            }

            if (this.STUDENT_HK_ID != null || this.STUDENT_HK_ID == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.STUDENT_HK_ID + "=");
                _oValueQuery.Append("'" + this.STUDENT_HK_ID.Trim() + "'");
            }

            if (this.BILL_CU_NAME != null || this.BILL_CU_NAME == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.BILL_CU_NAME + "=");
                _oValueQuery.Append("'" + this.BILL_CU_NAME.Trim() + "'");
            }

            if (this.N2_REGISTERED_NAME != null || this.N2_REGISTERED_NAME == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.N2_REGISTERED_NAME + "=");
                _oValueQuery.Append("'" + this.N2_REGISTERED_NAME.Trim() + "'");
            }

            if (this.TICKET_NO != null || this.TICKET_NO == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.TICKET_NO + "=");
                _oValueQuery.Append("'" + this.TICKET_NO.Trim() + "'");
            }

            if (this.ADDRESS_1 != null || this.ADDRESS_1 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.ADDRESS_1 + "=");
                _oValueQuery.Append("'" + this.ADDRESS_1.Trim().Replace("'", "''") + "'");
            }

            if (this.AGREEMENT_DATE != null || this.AGREEMENT_DATE == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.AGREEMENT_DATE + "=");
                _oValueQuery.Append("'" + this.AGREEMENT_DATE.Trim() + "'");
            }

            if (this.AGREEMENT_NO != null || this.AGREEMENT_NO == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.AGREEMENT_NO + "=");
                _oValueQuery.Append("'" + this.AGREEMENT_NO.Trim() + "'");
            }

            if (this.REGION_CITY != null || this.REGION_CITY == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.REGION_CITY + "=");
                _oValueQuery.Append("'" + this.REGION_CITY.Trim() + "'");
            }

            if (this.ID_NO_TYPE != null || this.ID_NO_TYPE == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.ID_NO_TYPE + "=");
                _oValueQuery.Append("'" + this.ID_NO_TYPE.Trim() + "'");
            }

            if (this.ID_NO != null || this.ID_NO == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.ID_NO + "=");
                _oValueQuery.Append("'" + this.ID_NO.Trim() + "'");
            }

            if (this.BILL_ADDRESS_3 != null || this.BILL_ADDRESS_3 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.BILL_ADDRESS_3 + "=");
                _oValueQuery.Append("'" + this.BILL_ADDRESS_3.Trim() + "'");
            }

            if (this.BANK_ACCOUNT != null || this.BANK_ACCOUNT == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.BANK_ACCOUNT + "=");
                _oValueQuery.Append("'" + this.BANK_ACCOUNT.Trim() + "'");
            }


            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.CREATE_DATE + "=");
                if (this.CREATE_DATE != null)
                {
                    _oValueQuery.Append(" to_date('" + ((DateTime)this.CREATE_DATE).ToString("dd/MM/yyyy") + "','dd/MM/yyyy') ");
                }
                else
                {
                    _oValueQuery.Append("''");
                }
            }

            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.SMARK_EXP_DATE + "=");
                if (this.SMARK_EXP_DATE != null)
                {
                    _oValueQuery.Append(" to_date('" + ((DateTime)this.SMARK_EXP_DATE).ToString("dd/MM/yyyy") + "','dd/MM/yyyy') ");
                }
                else
                {
                    _oValueQuery.Append("''");
                }
            }
           

            if (this.PREPAID_SIM_TO_POSTPAID != null || this.PREPAID_SIM_TO_POSTPAID == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.PREPAID_SIM_TO_POSTPAID + "=");
                _oValueQuery.Append("'" + this.PREPAID_SIM_TO_POSTPAID.Trim() + "'");
            }

            if (this.OLD_SUB_HK_ID != null || this.OLD_SUB_HK_ID == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.OLD_SUB_HK_ID + "=");
                _oValueQuery.Append("'" + this.OLD_SUB_HK_ID.Trim() + "'");
            }

            if (this.JOINT_PROMOTION_CODE != null || this.JOINT_PROMOTION_CODE == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.JOINT_PROMOTION_CODE + "=");
                _oValueQuery.Append("'" + this.JOINT_PROMOTION_CODE.Trim() + "'");
            }

 

            if (this.HANDSET_DESC != null || this.HANDSET_DESC == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.HANDSET_DESC + "=");
                _oValueQuery.Append("'" + this.HANDSET_DESC.Trim() + "'");
            }

            if (this.IMEI != null || this.IMEI == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.IMEI + "=");
                _oValueQuery.Append("'" + this.IMEI.Trim() + "'");
            }

            if (this.DNO != null || this.DNO == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.DNO + "=");
                _oValueQuery.Append("'" + this.DNO.Trim() + "'");
            }

            if (this.FAX != null || this.FAX == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.FAX + "=");
                _oValueQuery.Append("'" + this.FAX.Trim() + "'");
            }

            if (this.VAS_NAME15 != null || this.VAS_NAME15 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_NAME15 + "=");
                _oValueQuery.Append("'" + this.VAS_NAME15.Trim() + "'");
            }

            if (this.CONTACT_PERSON != null || this.CONTACT_PERSON == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.CONTACT_PERSON + "=");
                _oValueQuery.Append("'" + this.CONTACT_PERSON.Trim() + "'");
            }

            if (this.OWNER_NAME != null || this.OWNER_NAME == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.OWNER_NAME + "=");
                _oValueQuery.Append("'" + this.OWNER_NAME.Trim() + "'");
            }

            if (this.BANK_NAME != null || this.BANK_NAME == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.BANK_NAME + "=");
                _oValueQuery.Append("'" + this.BANK_NAME.Trim() + "'");
            }

            if (this.OLD_SUB_NAME_MNP != null || this.OLD_SUB_NAME_MNP == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.OLD_SUB_NAME_MNP + "=");
                _oValueQuery.Append("'" + this.OLD_SUB_NAME_MNP.Trim() + "'");
            }

            if (this.REG_BUILDING != null || this.REG_BUILDING == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.REG_BUILDING + "=");
                _oValueQuery.Append("'" + this.REG_BUILDING.Trim() + "'");
            }

            if (this.REG_ESTATE != null || this.REG_ESTATE == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.REG_ESTATE + "=");
                _oValueQuery.Append("'" + this.REG_ESTATE.Trim() + "'");
            }

            if (this.REG_ST_NAME != null || this.REG_ST_NAME == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.REG_ST_NAME + "=");
                _oValueQuery.Append("'" + this.REG_ST_NAME.Trim() + "'");
            }

            if (this.REG_DISTRICT != null || this.REG_DISTRICT == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.REG_DISTRICT + "=");
                _oValueQuery.Append("'" + this.REG_DISTRICT.Trim() + "'");
            }

            if (this.BIL_BUILDING != null || this.BIL_BUILDING == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.BIL_BUILDING + "=");
                _oValueQuery.Append("'" + this.BIL_BUILDING.Trim() + "'");
            }

            if (this.BIL_ESTATE != null || this.BIL_ESTATE == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.BIL_ESTATE + "=");
                _oValueQuery.Append("'" + this.BIL_ESTATE.Trim() + "'");
            }

            if (this.BIL_ST_NAME != null || this.BIL_ST_NAME == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.BIL_ST_NAME + "=");
                _oValueQuery.Append("'" + this.BIL_ST_NAME.Trim() + "'");
            }

            if (this.BIL_DISTRICT != null || this.BIL_DISTRICT == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.BIL_DISTRICT + "=");
                _oValueQuery.Append("'" + this.BIL_DISTRICT.Trim() + "'");
            }


            if (this.VAS_NAME1 != null || this.VAS_NAME1 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_NAME1 + "=");
                _oValueQuery.Append("'" + this.VAS_NAME1.Trim() + "'");
            }

            if (this.VAS_NAME2 != null || this.VAS_NAME2 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_NAME2 + "=");
                _oValueQuery.Append("'" + this.VAS_NAME2.Trim() + "'");
            }

            if (this.VAS_NAME3 != null || this.VAS_NAME3 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_NAME3 + "=");
                _oValueQuery.Append("'" + this.VAS_NAME3.Trim() + "'");
            }

            if (this.VAS_NAME4 != null || this.VAS_NAME4 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_NAME4 + "=");
                _oValueQuery.Append("'" + this.VAS_NAME4.Trim() + "'");
            }

            if (this.VAS_NAME5 != null || this.VAS_NAME5 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_NAME5 + "=");
                _oValueQuery.Append("'" + this.VAS_NAME5.Trim() + "'");
            }

            if (this.VAS_NAME6 != null || this.VAS_NAME6 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_NAME6 + "=");
                _oValueQuery.Append("'" + this.VAS_NAME6.Trim() + "'");
            }

            if (this.VAS_NAME7 != null || this.VAS_NAME7 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_NAME7 + "=");
                _oValueQuery.Append("'" + this.VAS_NAME7.Trim() + "'");
            }

            if (this.VAS_NAME8 != null || this.VAS_NAME8 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_NAME8 + "=");
                _oValueQuery.Append("'" + this.VAS_NAME8.Trim() + "'");
            }

            if (this.VAS_NAME9 != null || this.VAS_NAME9 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_NAME9 + "=");
                _oValueQuery.Append("'" + this.VAS_NAME9.Trim() + "'");
            }

            if (this.VAS_NAME10 != null || this.VAS_NAME10 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_NAME10 + "=");
                _oValueQuery.Append("'" + this.VAS_NAME10.Trim() + "'");
            }

            if (this.VAS_NAME11 != null || this.VAS_NAME11 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_NAME11 + "=");
                _oValueQuery.Append("'" + this.VAS_NAME11.Trim() + "'");
            }

            if (this.VAS_NAME12 != null || this.VAS_NAME12 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_NAME12 + "=");
                _oValueQuery.Append("'" + this.VAS_NAME12.Trim() + "'");
            }

            if (this.VAS_NAME13!= null || this.VAS_NAME13 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_NAME13 + "=");
                _oValueQuery.Append("'" + this.VAS_NAME13.Trim() + "'");
            }

            if (this.VAS_NAME14 != null || this.VAS_NAME14 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_NAME14 + "=");
                _oValueQuery.Append("'" + this.VAS_NAME14.Trim() + "'");
            }

            if (this.VAS_NAME16 != null || this.VAS_NAME16 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_NAME16 + "=");
                _oValueQuery.Append("'" + this.VAS_NAME16.Trim() + "'");
            }

            if (this.VAS_NAME17 != null || this.VAS_NAME17 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_NAME17 + "=");
                _oValueQuery.Append("'" + this.VAS_NAME17.Trim() + "'");
            }

            if (this.VAS_NAME19 != null || this.VAS_NAME19 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_NAME19 + "=");
                _oValueQuery.Append("'" + this.VAS_NAME19.Trim() + "'");
            }

            if (this.VAS_NAME20 != null || this.VAS_NAME20 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_NAME20 + "=");
                _oValueQuery.Append("'" + this.VAS_NAME20.Trim() + "'");
            }

            if (this.DUMMY1 != null || this.DUMMY1 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.DUMMY1 + "=");
                _oValueQuery.Append("'" + this.DUMMY1.Trim() + "'");
            }

            if (this.VAS_PRICE4 != null || this.VAS_PRICE4 == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.VAS_PRICE4 + "=");
                _oValueQuery.Append("'" + this.VAS_PRICE4.Trim() + "'");
            }

            if (this.OFFICE_TEL != null || this.OFFICE_TEL == string.Empty)
            {
                if (!_oValueQuery.ToString().Equals(string.Empty)) { _oValueQuery.Append(","); }
                _oValueQuery.Append(SundayActivation.Para.OFFICE_TEL + "=");
                _oValueQuery.Append("'" + this.OFFICE_TEL.Trim() + "'");
            }

            bool _bFlag = false;
            if (!_oValueQuery.ToString().Equals(string.Empty))
            {
                _oQuery.Append(" UPDATE Sunday_Activation SET ");
                _oQuery.Append(_oValueQuery.ToString());
                _oQuery.Append(" WHERE REFERENCENO='" + this.REFERENCENO.Trim() + "' AND ROWNUM<=1");

                bool _bHave = false;
                string _sSelectQuery = "SELECT REFERENCENO FROM Sunday_Activation WHERE REFERENCENO='" + this.REFERENCENO + "'";
                OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sSelectQuery);
                if (_oDr.Read())
                    _bHave = true;
                else
                    _bHave = false;
                _oDr.Close();
                _oDr.Dispose();

                if (_bHave)
                {
                    _bFlag = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
                    if (_bFlag) WebFunc.SaveQuery(_oQuery.ToString());
                }
                else
                    CreateRecord();
            }
            return _bFlag;
        }
        #endregion

        protected bool bFound = false;

        public bool IsFound()
        {
            return bFound;
        }

        public bool Load(string x_sREFERENCENO)
        {
            if (string.IsNullOrEmpty(x_sREFERENCENO))
                return false;

            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append(" SELECT * ");
            /*
            _oQuery.Append(SundayActivation.Para.REFERENCENO + ",");
            _oQuery.Append(SundayActivation.Para.MP_CARD_OWNER + ",");
            _oQuery.Append(SundayActivation.Para.MP_3_PARTY_NAME + ",");
            _oQuery.Append(SundayActivation.Para.MP_CARDNO + ",");
            _oQuery.Append(SundayActivation.Para.MP_C_HOLDER_NAME + ",");
            _oQuery.Append(SundayActivation.Para.MP_3_PARTY_ID + ",");
            _oQuery.Append(SundayActivation.Para.MP_EXPIRYDATE + ",");
            _oQuery.Append(SundayActivation.Para.CUSTOMER_GROUP + ",");
            _oQuery.Append(SundayActivation.Para.SMS_SUPPRESS + ",");
            _oQuery.Append(SundayActivation.Para.EMAIL + ",");
            _oQuery.Append(SundayActivation.Para.BILL_ADDRESS_1 + ",");
            _oQuery.Append(SundayActivation.Para.EMAIL_BILL + ",");
            _oQuery.Append(SundayActivation.Para.PAYMENT_TYPE + ",");
            _oQuery.Append(SundayActivation.Para.STUDENT_HK_ID + ",");
            _oQuery.Append(SundayActivation.Para.BILL_CU_NAME + ",");
            _oQuery.Append(SundayActivation.Para.N2_REGISTERED_NAME + ",");
            _oQuery.Append(SundayActivation.Para.TICKET_NO + ",");
            _oQuery.Append(SundayActivation.Para.ADDRESS_1 + ",");
            _oQuery.Append(SundayActivation.Para.AGREEMENT_DATE + ",");
            _oQuery.Append(SundayActivation.Para.AGREEMENT_NO);
             */
            _oQuery.Append(" FROM Sunday_Activation WHERE REFERENCENO='" + x_sREFERENCENO + "' AND ROWNUM<=1 ");
            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
            if (_oDr.Read())
            {
                this.REFERENCENO = Func.FR(_oDr[SundayActivation.Para.REFERENCENO]);
                this.ID_NO_TYPE = Func.FR(_oDr[SundayActivation.Para.ID_NO_TYPE]);
                this.BILL_ADDRESS_3 = Func.FR(_oDr[SundayActivation.Para.BILL_ADDRESS_3]);
                this.STUDENT_BIRTH_D = Func.FR(_oDr[SundayActivation.Para.STUDENT_BIRTH_D]);
                this.MP_CARD_OWNER = Func.FR(_oDr[SundayActivation.Para.MP_CARD_OWNER]);
                this.MP_3_PARTY_NAME = Func.FR(_oDr[SundayActivation.Para.MP_3_PARTY_NAME]);
                this.MP_CARDNO = Func.FR(_oDr[SundayActivation.Para.MP_CARDNO]);
                this.MP_C_HOLDER_NAME = Func.FR(_oDr[SundayActivation.Para.MP_C_HOLDER_NAME]);
                this.MP_3_PARTY_ID = Func.FR(_oDr[SundayActivation.Para.MP_3_PARTY_ID]);
                this.MP_EXPIRYDATE = Func.FR(_oDr[SundayActivation.Para.MP_EXPIRYDATE]);
                this.CUSTOMER_GROUP = Func.FR(_oDr[SundayActivation.Para.CUSTOMER_GROUP]);
                this.SMS_SUPPRESS = Func.FR(_oDr[SundayActivation.Para.SMS_SUPPRESS]);
                this.EMAIL = Func.FR(_oDr[SundayActivation.Para.EMAIL]);
                this.BILL_ADDRESS_1 = Func.FR(_oDr[SundayActivation.Para.BILL_ADDRESS_1]);
                this.EMAIL_BILL = Func.FR(_oDr[SundayActivation.Para.EMAIL_BILL]);
                this.PAYMENT_TYPE = Func.FR(_oDr[SundayActivation.Para.PAYMENT_TYPE]);
                this.STUDENT_HK_ID = Func.FR(_oDr[SundayActivation.Para.STUDENT_HK_ID]);
                this.BILL_CU_NAME = Func.FR(_oDr[SundayActivation.Para.BILL_CU_NAME]);
                this.N2_REGISTERED_NAME = Func.FR(_oDr[SundayActivation.Para.N2_REGISTERED_NAME]);
                this.TICKET_NO = Func.FR(_oDr[SundayActivation.Para.TICKET_NO]);
                this.ADDRESS_1 = Func.FR(_oDr[SundayActivation.Para.ADDRESS_1]);
                this.AGREEMENT_DATE = Func.FR(_oDr[SundayActivation.Para.AGREEMENT_DATE]);
                this.AGREEMENT_NO = Func.FR(_oDr[SundayActivation.Para.AGREEMENT_NO]);
                this.BANK_ACCOUNT = Func.FR(_oDr[SundayActivation.Para.BANK_ACCOUNT]);
                if (!Convert.IsDBNull(_oDr[SundayActivation.Para.CREATE_DATE])) {
                    this.CREATE_DATE = (System.Nullable<DateTime>)_oDr[SundayActivation.Para.CREATE_DATE];
                }
                else { this.CREATE_DATE = null; }

                if (!Convert.IsDBNull(_oDr[SundayActivation.Para.SMARK_EXP_DATE]))
                {
                    this.SMARK_EXP_DATE = (System.Nullable<DateTime>)_oDr[SundayActivation.Para.SMARK_EXP_DATE];
                }
                else { this.SMARK_EXP_DATE = null; }
                

                this.PREPAID_SIM_TO_POSTPAID = Func.FR(_oDr[SundayActivation.Para.PREPAID_SIM_TO_POSTPAID]);
                this.OLD_SUB_HK_ID = Func.FR(_oDr[SundayActivation.Para.OLD_SUB_HK_ID]);
                this.JOINT_PROMOTION_CODE = Func.FR(_oDr[SundayActivation.Para.JOINT_PROMOTION_CODE]);
                this.DUMMY2 = Func.FR(_oDr[SundayActivation.Para.DUMMY2]);
                this.HANDSET_DESC = Func.FR(_oDr[SundayActivation.Para.HANDSET_DESC]);
                this.IMEI = Func.FR(_oDr[SundayActivation.Para.IMEI]);
                this.DNO = Func.FR(_oDr[SundayActivation.Para.DNO]);

                this.FAX = Func.FR(_oDr[SundayActivation.Para.FAX]);
                this.VAS_NAME15 = Func.FR(_oDr[SundayActivation.Para.VAS_NAME15]);
                this.CONTACT_PERSON = Func.FR(_oDr[SundayActivation.Para.CONTACT_PERSON]);
                this.OWNER_NAME = Func.FR(_oDr[SundayActivation.Para.OWNER_NAME]);
                this.BANK_NAME = Func.FR(_oDr[SundayActivation.Para.BANK_NAME]);
                this.OLD_SUB_NAME_MNP = Func.FR(_oDr[SundayActivation.Para.OLD_SUB_NAME_MNP]);
                this.REG_BUILDING = Func.FR(_oDr[SundayActivation.Para.REG_BUILDING]);
                this.REG_ESTATE = Func.FR(_oDr[SundayActivation.Para.REG_ESTATE]);
                this.REG_ST_NAME = Func.FR(_oDr[SundayActivation.Para.REG_ST_NAME]);
                this.REG_DISTRICT = Func.FR(_oDr[SundayActivation.Para.REG_DISTRICT]);
                this.BIL_BUILDING = Func.FR(_oDr[SundayActivation.Para.BIL_BUILDING]);
                this.BIL_ESTATE = Func.FR(_oDr[SundayActivation.Para.BIL_ESTATE]);
                this.BIL_ST_NAME = Func.FR(_oDr[SundayActivation.Para.BIL_ST_NAME]);
                this.BIL_DISTRICT = Func.FR(_oDr[SundayActivation.Para.BIL_DISTRICT]);
                this.VAS_NAME1 = Func.FR(_oDr[SundayActivation.Para.VAS_NAME1]);
                this.VAS_NAME2 = Func.FR(_oDr[SundayActivation.Para.VAS_NAME2]);
                this.VAS_NAME3 = Func.FR(_oDr[SundayActivation.Para.VAS_NAME3]);
                this.VAS_NAME4 = Func.FR(_oDr[SundayActivation.Para.VAS_NAME4]);
                this.VAS_NAME5 = Func.FR(_oDr[SundayActivation.Para.VAS_NAME5]);
                this.VAS_NAME6 = Func.FR(_oDr[SundayActivation.Para.VAS_NAME6]);
                this.VAS_NAME7 = Func.FR(_oDr[SundayActivation.Para.VAS_NAME7]);
                this.VAS_NAME8 = Func.FR(_oDr[SundayActivation.Para.VAS_NAME8]);
                this.VAS_NAME9 = Func.FR(_oDr[SundayActivation.Para.VAS_NAME9]);
                this.VAS_NAME10 = Func.FR(_oDr[SundayActivation.Para.VAS_NAME10]);
                this.VAS_NAME11 = Func.FR(_oDr[SundayActivation.Para.VAS_NAME11]);
                this.VAS_NAME12 = Func.FR(_oDr[SundayActivation.Para.VAS_NAME12]);
                this.VAS_NAME13 = Func.FR(_oDr[SundayActivation.Para.VAS_NAME13]);
                this.VAS_NAME14 = Func.FR(_oDr[SundayActivation.Para.VAS_NAME14]);
                this.VAS_NAME16= Func.FR(_oDr[SundayActivation.Para.VAS_NAME16]);
                this.VAS_NAME17 = Func.FR(_oDr[SundayActivation.Para.VAS_NAME17]);
                this.FAMILY_REFERRAL_DN = Func.FR(_oDr[SundayActivation.Para.FAMILY_REFERRAL_DN]);
                this.VAS_NAME19 = Func.FR(_oDr[SundayActivation.Para.VAS_NAME19]);
                this.VAS_NAME20 = Func.FR(_oDr[SundayActivation.Para.VAS_NAME20]);
                this.DUMMY1 = Func.FR(_oDr[SundayActivation.Para.DUMMY1]);
                this.VAS_PRICE4 = Func.FR(_oDr[SundayActivation.Para.VAS_PRICE4]);
                this.OFFICE_TEL = Func.FR(_oDr[SundayActivation.Para.OFFICE_TEL]);
                bFound = true;
            }
            else
            {
                _oDr.Close();
                _oDr.Dispose();
                return false;
            }
            _oDr.Close();
            _oDr.Dispose();

            return true;
        }


        #region Equals
        public bool Equals(SundayActivation x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.ID_NO_TYPE.Equals(x_oObj.ID_NO_TYPE)) { return false; }
            if (!this.VAS_PRICE9.Equals(x_oObj.VAS_PRICE9)) { return false; }
            if (!this.VAS_PRICE13.Equals(x_oObj.VAS_PRICE13)) { return false; }
            if (!this.BIL_DISTRICT.Equals(x_oObj.BIL_DISTRICT)) { return false; }
            if (!this.IMEI.Equals(x_oObj.IMEI)) { return false; }
            if (!this.HS_C_HOLDER_NAME2.Equals(x_oObj.HS_C_HOLDER_NAME2)) { return false; }
            if (!this.BILL_ADDRESS_1.Equals(x_oObj.BILL_ADDRESS_1)) { return false; }
            if (!this.HS_EXP_2.Equals(x_oObj.HS_EXP_2)) { return false; }
            if (!this.BANK_NAME.Equals(x_oObj.BANK_NAME)) { return false; }
            if (!this.MP_CARD_OWNER.Equals(x_oObj.MP_CARD_OWNER)) { return false; }
            if (!this.EXPIRY_DATE.Equals(x_oObj.EXPIRY_DATE)) { return false; }
            if (!this.EMAIL_SUPPRESS.Equals(x_oObj.EMAIL_SUPPRESS)) { return false; }
            if (!this.HS_C_HOLDER_INSTAL.Equals(x_oObj.HS_C_HOLDER_INSTAL)) { return false; }
            if (!this.EMAIL.Equals(x_oObj.EMAIL)) { return false; }
            if (!this.VAS_PRICE19.Equals(x_oObj.VAS_PRICE19)) { return false; }
            if (!this.MP_C_HOLDER_NAME.Equals(x_oObj.MP_C_HOLDER_NAME)) { return false; }
            if (!this.MOBILE_NO.Equals(x_oObj.MOBILE_NO)) { return false; }
            if (!this.MP_3_PARTY_NAME.Equals(x_oObj.MP_3_PARTY_NAME)) { return false; }
            if (!this.RATE_PLAN.Equals(x_oObj.RATE_PLAN)) { return false; }
            if (!this.OLD_SUB_NAME_MNP.Equals(x_oObj.OLD_SUB_NAME_MNP)) { return false; }
            if (!this.CREATE_DATE.Equals(x_oObj.CREATE_DATE)) { return false; }
            if (!this.DUMMY2.Equals(x_oObj.DUMMY2)) { return false; }
            if (!this.VAS_NAME18.Equals(x_oObj.VAS_NAME18)) { return false; }
            if (!this.CONTACT_PERSON.Equals(x_oObj.CONTACT_PERSON)) { return false; }
            if (!this.VAS_PRICE5.Equals(x_oObj.VAS_PRICE5)) { return false; }
            if (!this.IDD_ROAMING.Equals(x_oObj.IDD_ROAMING)) { return false; }
            if (!this.VAS_NAME17.Equals(x_oObj.VAS_NAME17)) { return false; }
            if (!this.VAS_PRICE18.Equals(x_oObj.VAS_PRICE18)) { return false; }
            if (!this.REFERENCENO.Equals(x_oObj.REFERENCENO)) { return false; }
            if (!this.VAS_PRICE3.Equals(x_oObj.VAS_PRICE3)) { return false; }
            if (!this.PAYMENT_LIMIT.Equals(x_oObj.PAYMENT_LIMIT)) { return false; }
            if (!this.MP_3_PARTY_ID.Equals(x_oObj.MP_3_PARTY_ID)) { return false; }
            if (!this.N2_REGISTERED_NAME.Equals(x_oObj.N2_REGISTERED_NAME)) { return false; }
            if (!this.D_MAILL_SUPPRESS.Equals(x_oObj.D_MAILL_SUPPRESS)) { return false; }
            if (!this.AUTO_PAY.Equals(x_oObj.AUTO_PAY)) { return false; }
            if (!this.IDD_0060.Equals(x_oObj.IDD_0060)) { return false; }
            if (!this.CUSTOMER_GROUP.Equals(x_oObj.CUSTOMER_GROUP)) { return false; }
            if (!this.VAS_PRICE10.Equals(x_oObj.VAS_PRICE10)) { return false; }
            if (!this.VAS_NAME12.Equals(x_oObj.VAS_NAME12)) { return false; }
            if (!this.VAS_PRICE4.Equals(x_oObj.VAS_PRICE4)) { return false; }
            if (!this.VAS_NAME13.Equals(x_oObj.VAS_NAME13)) { return false; }
            if (!this.HS_PAY_AMT_INSTAL.Equals(x_oObj.HS_PAY_AMT_INSTAL)) { return false; }
            if (!this.SEC_SERVICE_PASSWORD.Equals(x_oObj.SEC_SERVICE_PASSWORD)) { return false; }
            if (!this.NETVIGATOR_FSA_NO.Equals(x_oObj.NETVIGATOR_FSA_NO)) { return false; }
            if (!this.STUDENT_HK_ID.Equals(x_oObj.STUDENT_HK_ID)) { return false; }
            if (!this.VOICE_LANGUAGE.Equals(x_oObj.VOICE_LANGUAGE)) { return false; }
            if (!this.MP_APP_CODE.Equals(x_oObj.MP_APP_CODE)) { return false; }
            if (!this.EMAIL_BILL.Equals(x_oObj.EMAIL_BILL)) { return false; }
            if (!this.CREDIT_CARD_TYPE.Equals(x_oObj.CREDIT_CARD_TYPE)) { return false; }
            if (!this.BANK_ACCOUNT.Equals(x_oObj.BANK_ACCOUNT)) { return false; }
            if (!this.REG_ST_NAME.Equals(x_oObj.REG_ST_NAME)) { return false; }
            if (!this.CHINA_ROAMING.Equals(x_oObj.CHINA_ROAMING)) { return false; }
            if (!this.DUMMY3.Equals(x_oObj.DUMMY3)) { return false; }
            if (!this.HS_EXP_INSTAL.Equals(x_oObj.HS_EXP_INSTAL)) { return false; }
            if (!this.ACTUAL_USER.Equals(x_oObj.ACTUAL_USER)) { return false; }
            if (!this.TICKET_NO.Equals(x_oObj.TICKET_NO)) { return false; }
            if (!this.VAS_NAME14.Equals(x_oObj.VAS_NAME14)) { return false; }
            if (!this.CUT_OVER_WINDOW.Equals(x_oObj.CUT_OVER_WINDOW)) { return false; }
            if (!this.PREPAID_SIM_TO_POSTPAID.Equals(x_oObj.PREPAID_SIM_TO_POSTPAID)) { return false; }
            if (!this.CUT_OVER_DATE_MNP.Equals(x_oObj.CUT_OVER_DATE_MNP)) { return false; }
            if (!this.HS_PAYMENT_TYPE2.Equals(x_oObj.HS_PAYMENT_TYPE2)) { return false; }
            if (!this.MP_AMOUNT.Equals(x_oObj.MP_AMOUNT)) { return false; }
            if (!this.SEC_SERVICE_NO.Equals(x_oObj.SEC_SERVICE_NO)) { return false; }
            if (!this.VAS_PRICE14.Equals(x_oObj.VAS_PRICE14)) { return false; }
            if (!this.REG_BLOCK.Equals(x_oObj.REG_BLOCK)) { return false; }
            if (!this.BIL_BUILDING.Equals(x_oObj.BIL_BUILDING)) { return false; }
            if (!this.VAS_NAME5.Equals(x_oObj.VAS_NAME5)) { return false; }
            if (!this.ID_NO.Equals(x_oObj.ID_NO)) { return false; }
            if (!this.SEC_LANGUAGE.Equals(x_oObj.SEC_LANGUAGE)) { return false; }
            if (!this.VAS_PRICE7.Equals(x_oObj.VAS_PRICE7)) { return false; }
            if (!this.REG_ESTATE.Equals(x_oObj.REG_ESTATE)) { return false; }
            if (!this.BILL_ADDRESS_3.Equals(x_oObj.BILL_ADDRESS_3)) { return false; }
            if (!this.HS_APP_CODE_INSTAL.Equals(x_oObj.HS_APP_CODE_INSTAL)) { return false; }
            if (!this.FAX.Equals(x_oObj.FAX)) { return false; }
            if (!this.BIL_FLOOR.Equals(x_oObj.BIL_FLOOR)) { return false; }
            if (!this.OLD_SUB_HK_ID.Equals(x_oObj.OLD_SUB_HK_ID)) { return false; }
            if (!this.VAS_PRICE11.Equals(x_oObj.VAS_PRICE11)) { return false; }
            if (!this.MP_CARDNO.Equals(x_oObj.MP_CARDNO)) { return false; }
            if (!this.ADDRESS_1.Equals(x_oObj.ADDRESS_1)) { return false; }
            if (!this.ADDRESS_2.Equals(x_oObj.ADDRESS_2)) { return false; }
            if (!this.ADDRESS_3.Equals(x_oObj.ADDRESS_3)) { return false; }
            if (!this.REG_FLOOR.Equals(x_oObj.REG_FLOOR)) { return false; }
            if (!this.FEATURE.Equals(x_oObj.FEATURE)) { return false; }
            if (!this.BIL_AREA.Equals(x_oObj.BIL_AREA)) { return false; }
            if (!this.VAS_PRICE6.Equals(x_oObj.VAS_PRICE6)) { return false; }
            if (!this.JOINT_PROMOTION_CODE.Equals(x_oObj.JOINT_PROMOTION_CODE)) { return false; }
            if (!this.OFFICE_TEL.Equals(x_oObj.OFFICE_TEL)) { return false; }
            if (!this.VAS_PRICE16.Equals(x_oObj.VAS_PRICE16)) { return false; }
            if (!this.BIL_BLOCK.Equals(x_oObj.BIL_BLOCK)) { return false; }
            if (!this.HS_CARD_NO2.Equals(x_oObj.HS_CARD_NO2)) { return false; }
            if (!this.EXTG_AC_TYPE.Equals(x_oObj.EXTG_AC_TYPE)) { return false; }
            if (!this.VAS_NAME19.Equals(x_oObj.VAS_NAME19)) { return false; }
            if (!this.TELEMARKETING_SUPPRESS.Equals(x_oObj.TELEMARKETING_SUPPRESS)) { return false; }
            if (!this.HS_PERIOD_INSTAL.Equals(x_oObj.HS_PERIOD_INSTAL)) { return false; }
            if (!this.BIL_FLAT.Equals(x_oObj.BIL_FLAT)) { return false; }
            if (!this.SMARK_EXP.Equals(x_oObj.SMARK_EXP)) { return false; }
            if (!this.SMS_LANGUAGE.Equals(x_oObj.SMS_LANGUAGE)) { return false; }
            if (!this.VAS_PRICE20.Equals(x_oObj.VAS_PRICE20)) { return false; }
            if (!this.VAS_NAME11.Equals(x_oObj.VAS_NAME11)) { return false; }
            if (!this.TRADE_FIELD_2.Equals(x_oObj.TRADE_FIELD_2)) { return false; }
            if (!this.VAS_NAME10.Equals(x_oObj.VAS_NAME10)) { return false; }
            if (!this.TRADE_FIELD_1.Equals(x_oObj.TRADE_FIELD_1)) { return false; }
            if (!this.VAS_PRICE12.Equals(x_oObj.VAS_PRICE12)) { return false; }
            if (!this.DUMMY1.Equals(x_oObj.DUMMY1)) { return false; }
            if (!this.EXTG_AC_NO.Equals(x_oObj.EXTG_AC_NO)) { return false; }
            if (!this.BILL_ADDRESS_2.Equals(x_oObj.BILL_ADDRESS_2)) { return false; }
            if (!this.SMARK_EXP_DATE.Equals(x_oObj.SMARK_EXP_DATE)) { return false; }
            if (!this.VAS_NAME9.Equals(x_oObj.VAS_NAME9)) { return false; }
            if (!this.REG_ST_NO.Equals(x_oObj.REG_ST_NO)) { return false; }
            if (!this.SEC_GREETING.Equals(x_oObj.SEC_GREETING)) { return false; }
            if (!this.VAS_PRICE2.Equals(x_oObj.VAS_PRICE2)) { return false; }
            if (!this.HANDSET_DESC.Equals(x_oObj.HANDSET_DESC)) { return false; }
            if (!this.REG_BUILDING.Equals(x_oObj.REG_BUILDING)) { return false; }
            if (!this.VAS_NAME2.Equals(x_oObj.VAS_NAME2)) { return false; }
            if (!this.VAS_NAME4.Equals(x_oObj.VAS_NAME4)) { return false; }
            if (!this.BIL_ST_NAME.Equals(x_oObj.BIL_ST_NAME)) { return false; }
            if (!this.VAS_NAME6.Equals(x_oObj.VAS_NAME6)) { return false; }
            if (!this.VAS_NAME7.Equals(x_oObj.VAS_NAME7)) { return false; }
            if (!this.AGREEMENT_DATE.Equals(x_oObj.AGREEMENT_DATE)) { return false; }
            if (!this.VAS_PRICE15.Equals(x_oObj.VAS_PRICE15)) { return false; }
            if (!this.REG_FLAT.Equals(x_oObj.REG_FLAT)) { return false; }
            if (!this.CONTACT_TEL.Equals(x_oObj.CONTACT_TEL)) { return false; }
            if (!this.HS_PAY_AMT2.Equals(x_oObj.HS_PAY_AMT2)) { return false; }
            if (!this.SALESMAN_CODE.Equals(x_oObj.SALESMAN_CODE)) { return false; }
            if (!this.VAS_NAME15.Equals(x_oObj.VAS_NAME15)) { return false; }
            if (!this.BILL_CU_NAME.Equals(x_oObj.BILL_CU_NAME)) { return false; }
            if (!this.VAS_PRICE8.Equals(x_oObj.VAS_PRICE8)) { return false; }
            if (!this.DNO.Equals(x_oObj.DNO)) { return false; }
            if (!this.REG_DISTRICT.Equals(x_oObj.REG_DISTRICT)) { return false; }
            if (!this.STUDENT_BIRTH_D.Equals(x_oObj.STUDENT_BIRTH_D)) { return false; }
            if (!this.VAS_PRICE1.Equals(x_oObj.VAS_PRICE1)) { return false; }
            if (!this.MP_3_BANK_ACCOUNT.Equals(x_oObj.MP_3_BANK_ACCOUNT)) { return false; }
            if (!this.VAS_NAME8.Equals(x_oObj.VAS_NAME8)) { return false; }
            if (!this.OLD_SUB_ID_TYPE_MNP.Equals(x_oObj.OLD_SUB_ID_TYPE_MNP)) { return false; }
            if (!this.REGION_CITY.Equals(x_oObj.REGION_CITY)) { return false; }
            if (!this.CREATED_BY.Equals(x_oObj.CREATED_BY)) { return false; }
            if (!this.VAS_NAME20.Equals(x_oObj.VAS_NAME20)) { return false; }
            if (!this.VAS_PRICE17.Equals(x_oObj.VAS_PRICE17)) { return false; }
            if (!this.CARD_NO.Equals(x_oObj.CARD_NO)) { return false; }
            if (!this.VAS_NAME1.Equals(x_oObj.VAS_NAME1)) { return false; }
            if (!this.CUT_OVER_TIME_MNP.Equals(x_oObj.CUT_OVER_TIME_MNP)) { return false; }
            if (!this.VAS_NAME3.Equals(x_oObj.VAS_NAME3)) { return false; }
            if (!this.BIL_ST_NO.Equals(x_oObj.BIL_ST_NO)) { return false; }
            if (!this.HS_CARD_NO_INSTAL.Equals(x_oObj.HS_CARD_NO_INSTAL)) { return false; }
            if (!this.OWNER_NAME.Equals(x_oObj.OWNER_NAME)) { return false; }
            if (!this.PCCW_LANDLINE_NO.Equals(x_oObj.PCCW_LANDLINE_NO)) { return false; }
            if (!this.SIM_CARD_NO.Equals(x_oObj.SIM_CARD_NO)) { return false; }
            if (!this.BIL_ESTATE.Equals(x_oObj.BIL_ESTATE)) { return false; }
            if (!this.MOBILE_0060.Equals(x_oObj.MOBILE_0060)) { return false; }
            if (!this.MP_EXPIRYDATE.Equals(x_oObj.MP_EXPIRYDATE)) { return false; }
            if (!this.SMS_SUPPRESS.Equals(x_oObj.SMS_SUPPRESS)) { return false; }
            if (!this.AGREEMENT_NO.Equals(x_oObj.AGREEMENT_NO)) { return false; }
            if (!this.ACTIVATION_DATE.Equals(x_oObj.ACTIVATION_DATE)) { return false; }
            if (!this.FAMILY_REFERRAL_DN.Equals(x_oObj.FAMILY_REFERRAL_DN)) { return false; }
            if (!this.PAYMENT_TYPE.Equals(x_oObj.PAYMENT_TYPE)) { return false; }
            if (!this.PREPAID_SIM_NO.Equals(x_oObj.PREPAID_SIM_NO)) { return false; }
            if (!this.HS_APP_CODE2.Equals(x_oObj.HS_APP_CODE2)) { return false; }
            if (!this.VAS_NAME16.Equals(x_oObj.VAS_NAME16)) { return false; }
            if (!this.REG_AREA.Equals(x_oObj.REG_AREA)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.ID_NO_TYPE = global::System.String.Empty;
            this.VAS_PRICE9 = global::System.String.Empty;
            this.VAS_PRICE13 = global::System.String.Empty;
            this.BIL_DISTRICT = global::System.String.Empty;
            this.IMEI = global::System.String.Empty;
            this.HS_C_HOLDER_NAME2 = global::System.String.Empty;
            this.BILL_ADDRESS_1 = global::System.String.Empty;
            this.HS_EXP_2 = global::System.String.Empty;
            this.BANK_NAME = global::System.String.Empty;
            this.MP_CARD_OWNER = global::System.String.Empty;
            this.EXPIRY_DATE = global::System.String.Empty;
            this.EMAIL_SUPPRESS = global::System.String.Empty;
            this.HS_C_HOLDER_INSTAL = global::System.String.Empty;
            this.EMAIL = global::System.String.Empty;
            this.VAS_PRICE19 = global::System.String.Empty;
            this.MP_C_HOLDER_NAME = global::System.String.Empty;
            this.MOBILE_NO = global::System.String.Empty;
            this.MP_3_PARTY_NAME = global::System.String.Empty;
            this.RATE_PLAN = global::System.String.Empty;
            this.OLD_SUB_NAME_MNP = global::System.String.Empty;
            this.CREATE_DATE = null;
            this.DUMMY2 = null;
            this.VAS_NAME18 = global::System.String.Empty;
            this.CONTACT_PERSON = global::System.String.Empty;
            this.VAS_PRICE5 = global::System.String.Empty;
            this.IDD_ROAMING = global::System.String.Empty;
            this.VAS_NAME17 = global::System.String.Empty;
            this.VAS_PRICE18 = global::System.String.Empty;
            this.REFERENCENO = global::System.String.Empty;
            this.VAS_PRICE3 = global::System.String.Empty;
            this.PAYMENT_LIMIT = global::System.String.Empty;
            this.MP_3_PARTY_ID = global::System.String.Empty;
            this.N2_REGISTERED_NAME = global::System.String.Empty;
            this.D_MAILL_SUPPRESS = global::System.String.Empty;
            this.AUTO_PAY = global::System.String.Empty;
            this.IDD_0060 = global::System.String.Empty;
            this.CUSTOMER_GROUP = global::System.String.Empty;
            this.VAS_PRICE10 = global::System.String.Empty;
            this.VAS_NAME12 = global::System.String.Empty;
            this.VAS_PRICE4 = global::System.String.Empty;
            this.VAS_NAME13 = global::System.String.Empty;
            this.HS_PAY_AMT_INSTAL = global::System.String.Empty;
            this.SEC_SERVICE_PASSWORD = global::System.String.Empty;
            this.NETVIGATOR_FSA_NO = global::System.String.Empty;
            this.STUDENT_HK_ID = global::System.String.Empty;
            this.VOICE_LANGUAGE = global::System.String.Empty;
            this.MP_APP_CODE = global::System.String.Empty;
            this.EMAIL_BILL = global::System.String.Empty;
            this.CREDIT_CARD_TYPE = global::System.String.Empty;
            this.BANK_ACCOUNT = global::System.String.Empty;
            this.REG_ST_NAME = global::System.String.Empty;
            this.CHINA_ROAMING = global::System.String.Empty;
            this.DUMMY3 = null;
            this.HS_EXP_INSTAL = global::System.String.Empty;
            this.ACTUAL_USER = global::System.String.Empty;
            this.TICKET_NO = global::System.String.Empty;
            this.VAS_NAME14 = global::System.String.Empty;
            this.CUT_OVER_WINDOW = global::System.String.Empty;
            this.PREPAID_SIM_TO_POSTPAID = global::System.String.Empty;
            this.CUT_OVER_DATE_MNP = global::System.String.Empty;
            this.HS_PAYMENT_TYPE2 = null;
            this.MP_AMOUNT = global::System.String.Empty;
            this.SEC_SERVICE_NO = global::System.String.Empty;
            this.VAS_PRICE14 = global::System.String.Empty;
            this.REG_BLOCK = global::System.String.Empty;
            this.BIL_BUILDING = global::System.String.Empty;
            this.VAS_NAME5 = global::System.String.Empty;
            this.ID_NO = global::System.String.Empty;
            this.SEC_LANGUAGE = global::System.String.Empty;
            this.VAS_PRICE7 = global::System.String.Empty;
            this.REG_ESTATE = global::System.String.Empty;
            this.BILL_ADDRESS_3 = global::System.String.Empty;
            this.HS_APP_CODE_INSTAL = global::System.String.Empty;
            this.FAX = global::System.String.Empty;
            this.BIL_FLOOR = global::System.String.Empty;
            this.OLD_SUB_HK_ID = global::System.String.Empty;
            this.VAS_PRICE11 = global::System.String.Empty;
            this.MP_CARDNO = global::System.String.Empty;
            this.ADDRESS_1 = global::System.String.Empty;
            this.ADDRESS_2 = global::System.String.Empty;
            this.ADDRESS_3 = global::System.String.Empty;
            this.REG_FLOOR = global::System.String.Empty;
            this.FEATURE = global::System.String.Empty;
            this.BIL_AREA = null;
            this.VAS_PRICE6 = global::System.String.Empty;
            this.JOINT_PROMOTION_CODE = global::System.String.Empty;
            this.OFFICE_TEL = global::System.String.Empty;
            this.VAS_PRICE16 = global::System.String.Empty;
            this.BIL_BLOCK = global::System.String.Empty;
            this.HS_CARD_NO2 = global::System.String.Empty;
            this.EXTG_AC_TYPE = global::System.String.Empty;
            this.VAS_NAME19 = global::System.String.Empty;
            this.TELEMARKETING_SUPPRESS = global::System.String.Empty;
            this.HS_PERIOD_INSTAL = global::System.String.Empty;
            this.BIL_FLAT = global::System.String.Empty;
            this.SMARK_EXP = global::System.String.Empty;
            this.SMS_LANGUAGE = global::System.String.Empty;
            this.VAS_PRICE20 = global::System.String.Empty;
            this.VAS_NAME11 = global::System.String.Empty;
            this.TRADE_FIELD_2 = global::System.String.Empty;
            this.VAS_NAME10 = global::System.String.Empty;
            this.TRADE_FIELD_1 = global::System.String.Empty;
            this.VAS_PRICE12 = global::System.String.Empty;
            this.DUMMY1 = global::System.String.Empty;
            this.EXTG_AC_NO = global::System.String.Empty;
            this.BILL_ADDRESS_2 = global::System.String.Empty;
            this.SMARK_EXP_DATE = null;
            this.VAS_NAME9 = global::System.String.Empty;
            this.REG_ST_NO = global::System.String.Empty;
            this.SEC_GREETING = global::System.String.Empty;
            this.VAS_PRICE2 = global::System.String.Empty;
            this.HANDSET_DESC = global::System.String.Empty;
            this.REG_BUILDING = global::System.String.Empty;
            this.VAS_NAME2 = global::System.String.Empty;
            this.VAS_NAME4 = global::System.String.Empty;
            this.BIL_ST_NAME = global::System.String.Empty;
            this.VAS_NAME6 = global::System.String.Empty;
            this.VAS_NAME7 = global::System.String.Empty;
            this.AGREEMENT_DATE = global::System.String.Empty;
            this.VAS_PRICE15 = global::System.String.Empty;
            this.REG_FLAT = global::System.String.Empty;
            this.CONTACT_TEL = global::System.String.Empty;
            this.HS_PAY_AMT2 = global::System.String.Empty;
            this.SALESMAN_CODE = global::System.String.Empty;
            this.VAS_NAME15 = global::System.String.Empty;
            this.BILL_CU_NAME = global::System.String.Empty;
            this.VAS_PRICE8 = global::System.String.Empty;
            this.DNO = global::System.String.Empty;
            this.REG_DISTRICT = global::System.String.Empty;
            this.STUDENT_BIRTH_D = global::System.String.Empty;
            this.VAS_PRICE1 = global::System.String.Empty;
            this.MP_3_BANK_ACCOUNT = global::System.String.Empty;
            this.VAS_NAME8 = global::System.String.Empty;
            this.OLD_SUB_ID_TYPE_MNP = global::System.String.Empty;
            this.REGION_CITY = global::System.String.Empty;
            this.CREATED_BY = global::System.String.Empty;
            this.VAS_NAME20 = global::System.String.Empty;
            this.VAS_PRICE17 = global::System.String.Empty;
            this.CARD_NO = global::System.String.Empty;
            this.VAS_NAME1 = global::System.String.Empty;
            this.CUT_OVER_TIME_MNP = global::System.String.Empty;
            this.VAS_NAME3 = global::System.String.Empty;
            this.BIL_ST_NO = global::System.String.Empty;
            this.HS_CARD_NO_INSTAL = global::System.String.Empty;
            this.OWNER_NAME = global::System.String.Empty;
            this.PCCW_LANDLINE_NO = global::System.String.Empty;
            this.SIM_CARD_NO = global::System.String.Empty;
            this.BIL_ESTATE = global::System.String.Empty;
            this.MOBILE_0060 = global::System.String.Empty;
            this.MP_EXPIRYDATE = global::System.String.Empty;
            this.SMS_SUPPRESS = global::System.String.Empty;
            this.AGREEMENT_NO = global::System.String.Empty;
            this.ACTIVATION_DATE = global::System.String.Empty;
            this.FAMILY_REFERRAL_DN = global::System.String.Empty;
            this.PAYMENT_TYPE = global::System.String.Empty;
            this.PREPAID_SIM_NO = global::System.String.Empty;
            this.HS_APP_CODE2 = global::System.String.Empty;
            this.VAS_NAME16 = global::System.String.Empty;
            this.REG_AREA = null;
        }
        #endregion Release


        #region Clone
        public SundayActivation DeepClone()
        {
            SundayActivation SundayActivation_Clone = new SundayActivation();
            SundayActivation_Clone.SetID_NO_TYPE(this.ID_NO_TYPE);
            SundayActivation_Clone.SetVAS_PRICE9(this.VAS_PRICE9);
            SundayActivation_Clone.SetVAS_PRICE13(this.VAS_PRICE13);
            SundayActivation_Clone.SetBIL_DISTRICT(this.BIL_DISTRICT);
            SundayActivation_Clone.SetIMEI(this.IMEI);
            SundayActivation_Clone.SetHS_C_HOLDER_NAME2(this.HS_C_HOLDER_NAME2);
            SundayActivation_Clone.SetBILL_ADDRESS_1(this.BILL_ADDRESS_1);
            SundayActivation_Clone.SetHS_EXP_2(this.HS_EXP_2);
            SundayActivation_Clone.SetBANK_NAME(this.BANK_NAME);
            SundayActivation_Clone.SetMP_CARD_OWNER(this.MP_CARD_OWNER);
            SundayActivation_Clone.SetEXPIRY_DATE(this.EXPIRY_DATE);
            SundayActivation_Clone.SetEMAIL_SUPPRESS(this.EMAIL_SUPPRESS);
            SundayActivation_Clone.SetHS_C_HOLDER_INSTAL(this.HS_C_HOLDER_INSTAL);
            SundayActivation_Clone.SetEMAIL(this.EMAIL);
            SundayActivation_Clone.SetVAS_PRICE19(this.VAS_PRICE19);
            SundayActivation_Clone.SetMP_C_HOLDER_NAME(this.MP_C_HOLDER_NAME);
            SundayActivation_Clone.SetMOBILE_NO(this.MOBILE_NO);
            SundayActivation_Clone.SetMP_3_PARTY_NAME(this.MP_3_PARTY_NAME);
            SundayActivation_Clone.SetRATE_PLAN(this.RATE_PLAN);
            SundayActivation_Clone.SetOLD_SUB_NAME_MNP(this.OLD_SUB_NAME_MNP);
            SundayActivation_Clone.SetCREATE_DATE(this.CREATE_DATE);
            SundayActivation_Clone.SetDUMMY2(this.DUMMY2);
            SundayActivation_Clone.SetVAS_NAME18(this.VAS_NAME18);
            SundayActivation_Clone.SetCONTACT_PERSON(this.CONTACT_PERSON);
            SundayActivation_Clone.SetVAS_PRICE5(this.VAS_PRICE5);
            SundayActivation_Clone.SetIDD_ROAMING(this.IDD_ROAMING);
            SundayActivation_Clone.SetVAS_NAME17(this.VAS_NAME17);
            SundayActivation_Clone.SetVAS_PRICE18(this.VAS_PRICE18);
            SundayActivation_Clone.SetREFERENCENO(this.REFERENCENO);
            SundayActivation_Clone.SetVAS_PRICE3(this.VAS_PRICE3);
            SundayActivation_Clone.SetPAYMENT_LIMIT(this.PAYMENT_LIMIT);
            SundayActivation_Clone.SetMP_3_PARTY_ID(this.MP_3_PARTY_ID);
            SundayActivation_Clone.SetN2_REGISTERED_NAME(this.N2_REGISTERED_NAME);
            SundayActivation_Clone.SetD_MAILL_SUPPRESS(this.D_MAILL_SUPPRESS);
            SundayActivation_Clone.SetAUTO_PAY(this.AUTO_PAY);
            SundayActivation_Clone.SetIDD_0060(this.IDD_0060);
            SundayActivation_Clone.SetCUSTOMER_GROUP(this.CUSTOMER_GROUP);
            SundayActivation_Clone.SetVAS_PRICE10(this.VAS_PRICE10);
            SundayActivation_Clone.SetVAS_NAME12(this.VAS_NAME12);
            SundayActivation_Clone.SetVAS_PRICE4(this.VAS_PRICE4);
            SundayActivation_Clone.SetVAS_NAME13(this.VAS_NAME13);
            SundayActivation_Clone.SetHS_PAY_AMT_INSTAL(this.HS_PAY_AMT_INSTAL);
            SundayActivation_Clone.SetSEC_SERVICE_PASSWORD(this.SEC_SERVICE_PASSWORD);
            SundayActivation_Clone.SetNETVIGATOR_FSA_NO(this.NETVIGATOR_FSA_NO);
            SundayActivation_Clone.SetSTUDENT_HK_ID(this.STUDENT_HK_ID);
            SundayActivation_Clone.SetVOICE_LANGUAGE(this.VOICE_LANGUAGE);
            SundayActivation_Clone.SetMP_APP_CODE(this.MP_APP_CODE);
            SundayActivation_Clone.SetEMAIL_BILL(this.EMAIL_BILL);
            SundayActivation_Clone.SetCREDIT_CARD_TYPE(this.CREDIT_CARD_TYPE);
            SundayActivation_Clone.SetBANK_ACCOUNT(this.BANK_ACCOUNT);
            SundayActivation_Clone.SetREG_ST_NAME(this.REG_ST_NAME);
            SundayActivation_Clone.SetCHINA_ROAMING(this.CHINA_ROAMING);
            SundayActivation_Clone.SetDUMMY3(this.DUMMY3);
            SundayActivation_Clone.SetHS_EXP_INSTAL(this.HS_EXP_INSTAL);
            SundayActivation_Clone.SetACTUAL_USER(this.ACTUAL_USER);
            SundayActivation_Clone.SetTICKET_NO(this.TICKET_NO);
            SundayActivation_Clone.SetVAS_NAME14(this.VAS_NAME14);
            SundayActivation_Clone.SetCUT_OVER_WINDOW(this.CUT_OVER_WINDOW);
            SundayActivation_Clone.SetPREPAID_SIM_TO_POSTPAID(this.PREPAID_SIM_TO_POSTPAID);
            SundayActivation_Clone.SetCUT_OVER_DATE_MNP(this.CUT_OVER_DATE_MNP);
            SundayActivation_Clone.SetHS_PAYMENT_TYPE2(this.HS_PAYMENT_TYPE2);
            SundayActivation_Clone.SetMP_AMOUNT(this.MP_AMOUNT);
            SundayActivation_Clone.SetSEC_SERVICE_NO(this.SEC_SERVICE_NO);
            SundayActivation_Clone.SetVAS_PRICE14(this.VAS_PRICE14);
            SundayActivation_Clone.SetREG_BLOCK(this.REG_BLOCK);
            SundayActivation_Clone.SetBIL_BUILDING(this.BIL_BUILDING);
            SundayActivation_Clone.SetVAS_NAME5(this.VAS_NAME5);
            SundayActivation_Clone.SetID_NO(this.ID_NO);
            SundayActivation_Clone.SetSEC_LANGUAGE(this.SEC_LANGUAGE);
            SundayActivation_Clone.SetVAS_PRICE7(this.VAS_PRICE7);
            SundayActivation_Clone.SetREG_ESTATE(this.REG_ESTATE);
            SundayActivation_Clone.SetBILL_ADDRESS_3(this.BILL_ADDRESS_3);
            SundayActivation_Clone.SetHS_APP_CODE_INSTAL(this.HS_APP_CODE_INSTAL);
            SundayActivation_Clone.SetFAX(this.FAX);
            SundayActivation_Clone.SetBIL_FLOOR(this.BIL_FLOOR);
            SundayActivation_Clone.SetOLD_SUB_HK_ID(this.OLD_SUB_HK_ID);
            SundayActivation_Clone.SetVAS_PRICE11(this.VAS_PRICE11);
            SundayActivation_Clone.SetMP_CARDNO(this.MP_CARDNO);
            SundayActivation_Clone.SetADDRESS_1(this.ADDRESS_1);
            SundayActivation_Clone.SetADDRESS_2(this.ADDRESS_2);
            SundayActivation_Clone.SetADDRESS_3(this.ADDRESS_3);
            SundayActivation_Clone.SetREG_FLOOR(this.REG_FLOOR);
            SundayActivation_Clone.SetFEATURE(this.FEATURE);
            SundayActivation_Clone.SetBIL_AREA(this.BIL_AREA);
            SundayActivation_Clone.SetVAS_PRICE6(this.VAS_PRICE6);
            SundayActivation_Clone.SetJOINT_PROMOTION_CODE(this.JOINT_PROMOTION_CODE);
            SundayActivation_Clone.SetOFFICE_TEL(this.OFFICE_TEL);
            SundayActivation_Clone.SetVAS_PRICE16(this.VAS_PRICE16);
            SundayActivation_Clone.SetBIL_BLOCK(this.BIL_BLOCK);
            SundayActivation_Clone.SetHS_CARD_NO2(this.HS_CARD_NO2);
            SundayActivation_Clone.SetEXTG_AC_TYPE(this.EXTG_AC_TYPE);
            SundayActivation_Clone.SetVAS_NAME19(this.VAS_NAME19);
            SundayActivation_Clone.SetTELEMARKETING_SUPPRESS(this.TELEMARKETING_SUPPRESS);
            SundayActivation_Clone.SetHS_PERIOD_INSTAL(this.HS_PERIOD_INSTAL);
            SundayActivation_Clone.SetBIL_FLAT(this.BIL_FLAT);
            SundayActivation_Clone.SetSMARK_EXP(this.SMARK_EXP);
            SundayActivation_Clone.SetSMS_LANGUAGE(this.SMS_LANGUAGE);
            SundayActivation_Clone.SetVAS_PRICE20(this.VAS_PRICE20);
            SundayActivation_Clone.SetVAS_NAME11(this.VAS_NAME11);
            SundayActivation_Clone.SetTRADE_FIELD_2(this.TRADE_FIELD_2);
            SundayActivation_Clone.SetVAS_NAME10(this.VAS_NAME10);
            SundayActivation_Clone.SetTRADE_FIELD_1(this.TRADE_FIELD_1);
            SundayActivation_Clone.SetVAS_PRICE12(this.VAS_PRICE12);
            SundayActivation_Clone.SetDUMMY1(this.DUMMY1);
            SundayActivation_Clone.SetEXTG_AC_NO(this.EXTG_AC_NO);
            SundayActivation_Clone.SetBILL_ADDRESS_2(this.BILL_ADDRESS_2);
            SundayActivation_Clone.SetSMARK_EXP_DATE(this.SMARK_EXP_DATE);
            SundayActivation_Clone.SetVAS_NAME9(this.VAS_NAME9);
            SundayActivation_Clone.SetREG_ST_NO(this.REG_ST_NO);
            SundayActivation_Clone.SetSEC_GREETING(this.SEC_GREETING);
            SundayActivation_Clone.SetVAS_PRICE2(this.VAS_PRICE2);
            SundayActivation_Clone.SetHANDSET_DESC(this.HANDSET_DESC);
            SundayActivation_Clone.SetREG_BUILDING(this.REG_BUILDING);
            SundayActivation_Clone.SetVAS_NAME2(this.VAS_NAME2);
            SundayActivation_Clone.SetVAS_NAME4(this.VAS_NAME4);
            SundayActivation_Clone.SetBIL_ST_NAME(this.BIL_ST_NAME);
            SundayActivation_Clone.SetVAS_NAME6(this.VAS_NAME6);
            SundayActivation_Clone.SetVAS_NAME7(this.VAS_NAME7);
            SundayActivation_Clone.SetAGREEMENT_DATE(this.AGREEMENT_DATE);
            SundayActivation_Clone.SetVAS_PRICE15(this.VAS_PRICE15);
            SundayActivation_Clone.SetREG_FLAT(this.REG_FLAT);
            SundayActivation_Clone.SetCONTACT_TEL(this.CONTACT_TEL);
            SundayActivation_Clone.SetHS_PAY_AMT2(this.HS_PAY_AMT2);
            SundayActivation_Clone.SetSALESMAN_CODE(this.SALESMAN_CODE);
            SundayActivation_Clone.SetVAS_NAME15(this.VAS_NAME15);
            SundayActivation_Clone.SetBILL_CU_NAME(this.BILL_CU_NAME);
            SundayActivation_Clone.SetVAS_PRICE8(this.VAS_PRICE8);
            SundayActivation_Clone.SetDNO(this.DNO);
            SundayActivation_Clone.SetREG_DISTRICT(this.REG_DISTRICT);
            SundayActivation_Clone.SetSTUDENT_BIRTH_D(this.STUDENT_BIRTH_D);
            SundayActivation_Clone.SetVAS_PRICE1(this.VAS_PRICE1);
            SundayActivation_Clone.SetMP_3_BANK_ACCOUNT(this.MP_3_BANK_ACCOUNT);
            SundayActivation_Clone.SetVAS_NAME8(this.VAS_NAME8);
            SundayActivation_Clone.SetOLD_SUB_ID_TYPE_MNP(this.OLD_SUB_ID_TYPE_MNP);
            SundayActivation_Clone.SetREGION_CITY(this.REGION_CITY);
            SundayActivation_Clone.SetCREATED_BY(this.CREATED_BY);
            SundayActivation_Clone.SetVAS_NAME20(this.VAS_NAME20);
            SundayActivation_Clone.SetVAS_PRICE17(this.VAS_PRICE17);
            SundayActivation_Clone.SetCARD_NO(this.CARD_NO);
            SundayActivation_Clone.SetVAS_NAME1(this.VAS_NAME1);
            SundayActivation_Clone.SetCUT_OVER_TIME_MNP(this.CUT_OVER_TIME_MNP);
            SundayActivation_Clone.SetVAS_NAME3(this.VAS_NAME3);
            SundayActivation_Clone.SetBIL_ST_NO(this.BIL_ST_NO);
            SundayActivation_Clone.SetHS_CARD_NO_INSTAL(this.HS_CARD_NO_INSTAL);
            SundayActivation_Clone.SetOWNER_NAME(this.OWNER_NAME);
            SundayActivation_Clone.SetPCCW_LANDLINE_NO(this.PCCW_LANDLINE_NO);
            SundayActivation_Clone.SetSIM_CARD_NO(this.SIM_CARD_NO);
            SundayActivation_Clone.SetBIL_ESTATE(this.BIL_ESTATE);
            SundayActivation_Clone.SetMOBILE_0060(this.MOBILE_0060);
            SundayActivation_Clone.SetMP_EXPIRYDATE(this.MP_EXPIRYDATE);
            SundayActivation_Clone.SetSMS_SUPPRESS(this.SMS_SUPPRESS);
            SundayActivation_Clone.SetAGREEMENT_NO(this.AGREEMENT_NO);
            SundayActivation_Clone.SetACTIVATION_DATE(this.ACTIVATION_DATE);
            SundayActivation_Clone.SetFAMILY_REFERRAL_DN(this.FAMILY_REFERRAL_DN);
            SundayActivation_Clone.SetPAYMENT_TYPE(this.PAYMENT_TYPE);
            SundayActivation_Clone.SetPREPAID_SIM_NO(this.PREPAID_SIM_NO);
            SundayActivation_Clone.SetHS_APP_CODE2(this.HS_APP_CODE2);
            SundayActivation_Clone.SetVAS_NAME16(this.VAS_NAME16);
            SundayActivation_Clone.SetREG_AREA(this.REG_AREA);
            return SundayActivation_Clone;
        }
        #endregion Clone

        void IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }
    }
}
