using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Odbc;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;


public partial class MappingDownloadMenu : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        WebFunc.PrivilegeCheck(this.Page);
        if (!IsPostBack) { TableGen(); }
    }

    #region TableGen
    public void TableGen()
    {
        if (!"".Equals(WebFunc.qsTable))
        {
            switch (WebFunc.qsTable)
            {
                case "BusinessTrade":
                    this.BusinessTradeRaw();
                    break;
                case "HandSetOfferedBasket":
                    this.HandSetOfferedBasketRaw();
                    break;
                case "ProductItemCode":
                    this.ProductItemCodeRaw();
                    break;
                case "GiftBasket":
                    this.GiftBasketRaw();
                    break;
                case "Accessory":
                    this.AccessoryRaw();
                    break;
                case "RetentionPlan":
                    this.RetentionPlanRaw();
                    break;
                case "RebateGroup":
                    this.RebateGroupRaw();
                    break;
                case "SpecialPremium":
                    this.SpecialPremiumRaw();
                    break;
                case "BankCode":
                    this.BankCodeRaw();
                    break;
                case "MobileOrderMonthlyFee":
                    this.MobileOrderMonthlyFeeRaw();
                    break;
                case "TariffFeeSchedule":
                    this.TariffFeeScheduleRaw();
                    break;
                case "MobileOrderFallout":
                    this.MobileOrderFalloutRaw();
                    break;
                case "SuspendEventDetail":
                    this.SuspendEventDetailRaw();
                    break;
                case "BusinessVas":
                    this.BusinessVasRaw();
                    break;
                case "BusinessVasDescription":
                    this.BusinessVasDescriptionRaw();
                    break;
                case "AutoSelectionProperty":
                    this.AutoSelectionPropertyRaw();
                    break;
                case "BundleMapping":
                    this.BundleMappingRaw();
                    break;
            }
        }
    }
    #endregion

    #region BusinessTradeRaw
    protected void BusinessTradeRaw()
    {
        BusinessTradeReport _oBusinessTradeReport = new BusinessTradeReport(this.Page, "application/x-excel");
        _oBusinessTradeReport.SetFileName(WebFunc.qsTable + ".xls");
        _oBusinessTradeReport.SetStartRecordIndex(-1);
        _oBusinessTradeReport.SetLimitRecordIndex(-1);
        _oBusinessTradeReport.SetAllView(false);
        BusinessTradeInfo _oBusinessTradeInfo = _oBusinessTradeReport.GetBusinessTradeInfo();

        _oBusinessTradeInfo.Fields(BusinessTrade.Para.mid).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.program).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.normal_rebate_type).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.rate_plan).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.con_per).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.rebate).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.free_mon).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.issue_type).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.hs_model).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.hs_model_name).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.premium_1).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.premium_2).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.trade_field).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.bundle_name).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.plan_fee).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.channel).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.sdate).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.edate).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.cid).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.cdate).IsView = true;
        _oBusinessTradeInfo.Fields(BusinessTrade.Para.remarks).IsView = true;

        _oBusinessTradeReport.ResetTable(_oBusinessTradeInfo);
        _oBusinessTradeReport.ExportReport(true,false);
    }
    #endregion

    #region HandSetOfferedBasketRaw
    protected void HandSetOfferedBasketRaw()
    {
        HandSetOfferedBasketReport _oHandSetOfferedBasketReport = new HandSetOfferedBasketReport(this.Page, "application/x-excel");
        _oHandSetOfferedBasketReport.SetFileName(WebFunc.qsTable + ".xls");
        _oHandSetOfferedBasketReport.SetStartRecordIndex(-1);
        _oHandSetOfferedBasketReport.SetLimitRecordIndex(-1);
        _oHandSetOfferedBasketReport.SetAllView(true);
        _oHandSetOfferedBasketReport.ExportReport(true,false);
    }
    #endregion

    #region ProductItemCodeRaw
    protected void ProductItemCodeRaw()
    {
        ProductItemCodeReport _oProductItemCodeReport = new ProductItemCodeReport(this.Page, "application/x-excel");
        _oProductItemCodeReport.SetFileName(WebFunc.qsTable + ".xls");
        _oProductItemCodeReport.SetStartRecordIndex(-1);
        _oProductItemCodeReport.SetLimitRecordIndex(-1);
        _oProductItemCodeReport.ExportReport();
    }
    #endregion

    #region GiftBasketRaw
    protected void GiftBasketRaw()
    {
        GiftBasketReport _oGiftBasketReport = new GiftBasketReport(this.Page, "application/x-excel");
        _oGiftBasketReport.SetFileName(WebFunc.qsTable + ".xls");
        _oGiftBasketReport.SetStartRecordIndex(-1);
        _oGiftBasketReport.SetLimitRecordIndex(-1);
        _oGiftBasketReport.ExportReport();
    }
    #endregion

    #region AccessoryRaw
    protected void AccessoryRaw()
    {
        AccessoryReport _oAccessoryReport = new AccessoryReport(this.Page, "application/x-excel");
        _oAccessoryReport.SetFileName(WebFunc.qsTable + ".xls");
        _oAccessoryReport.SetStartRecordIndex(-1);
        _oAccessoryReport.SetLimitRecordIndex(-1);
        _oAccessoryReport.ExportReport();
    }
    #endregion

    #region RetentionPlanRaw
    protected void RetentionPlanRaw()
    {
        RetentionPlanReport _oRetentionPlanReport = new RetentionPlanReport(this.Page, "application/x-excel");
        _oRetentionPlanReport.SetFileName(WebFunc.qsTable + ".xls");
        _oRetentionPlanReport.SetStartRecordIndex(-1);
        _oRetentionPlanReport.SetLimitRecordIndex(-1);
        _oRetentionPlanReport.ExportReport();
    }
    #endregion

    #region RebateGroupRaw
    protected void RebateGroupRaw()
    {
        RebateGroupReport _oRebateGroupReport = new RebateGroupReport(this.Page, "application/x-excel");
        _oRebateGroupReport.SetFileName(WebFunc.qsTable + ".xls");
        _oRebateGroupReport.SetStartRecordIndex(-1);
        _oRebateGroupReport.SetLimitRecordIndex(-1);
        _oRebateGroupReport.ExportReport();
    }
    #endregion

    #region SpecialPremiumRaw
    protected void SpecialPremiumRaw()
    {
        SpecialPremiumReport _oSpecialPremiumReport = new SpecialPremiumReport(this.Page, "application/x-excel");
        _oSpecialPremiumReport.SetFileName(WebFunc.qsTable + ".xls");
        _oSpecialPremiumReport.SetStartRecordIndex(-1);
        _oSpecialPremiumReport.SetLimitRecordIndex(-1);
        _oSpecialPremiumReport.ExportReport();
    }
    #endregion

    #region BankCodeRaw
    protected void BankCodeRaw()
    {
        BankCodeReport _oBankCodeReport = new BankCodeReport(this.Page, "application/x-excel");
        _oBankCodeReport.SetFileName(WebFunc.qsTable + ".xls");
        _oBankCodeReport.SetStartRecordIndex(-1);
        _oBankCodeReport.SetLimitRecordIndex(-1);
        _oBankCodeReport.ExportReport();
    }
    #endregion

    #region MobileOrderMonthlyFeeRaw
    protected void MobileOrderMonthlyFeeRaw()
    {
        MobileOrderMonthlyFeeReport _oMobileOrderMonthlyFeeReport = new MobileOrderMonthlyFeeReport(this.Page, "application/x-excel");
        _oMobileOrderMonthlyFeeReport.SetFileName(WebFunc.qsTable + ".xls");
        _oMobileOrderMonthlyFeeReport.SetStartRecordIndex(-1);
        _oMobileOrderMonthlyFeeReport.SetLimitRecordIndex(-1);
        _oMobileOrderMonthlyFeeReport.ExportReport();
    }
    #endregion

    #region TariffFeeScheduleRaw
    protected void TariffFeeScheduleRaw()
    {
        TariffFeeScheduleReport _oTariffFeeScheduleReport = new TariffFeeScheduleReport(this.Page, "application/x-excel");
        _oTariffFeeScheduleReport.SetFileName(WebFunc.qsTable + ".xls");
        _oTariffFeeScheduleReport.SetStartRecordIndex(-1);
        _oTariffFeeScheduleReport.SetLimitRecordIndex(-1);
        _oTariffFeeScheduleReport.ExportReport();
    }
    #endregion

    #region MobileOrderFalloutRaw
    protected void MobileOrderFalloutRaw()
    {
        MobileOrderFalloutReport _oMobileOrderFalloutReport = new MobileOrderFalloutReport(this.Page, "application/x-excel");
        _oMobileOrderFalloutReport.SetFileName(WebFunc.qsTable + ".xls");
        _oMobileOrderFalloutReport.SetStartRecordIndex(-1);
        _oMobileOrderFalloutReport.SetLimitRecordIndex(-1);
        _oMobileOrderFalloutReport.ExportReport();
    }
    #endregion

    #region SuspendEventDetailRaw
    protected void SuspendEventDetailRaw()
    {
        SuspendEventDetailReport _oSuspendEventDetailReport = new SuspendEventDetailReport(this.Page, "application/x-excel");
        _oSuspendEventDetailReport.SetFileName(WebFunc.qsTable + ".xls");
        _oSuspendEventDetailReport.SetStartRecordIndex(-1);
        _oSuspendEventDetailReport.SetLimitRecordIndex(-1);
        _oSuspendEventDetailReport.ExportReport();
    }
    #endregion

    #region BusinessVasRaw
    protected void BusinessVasRaw()
    {
        BusinessVasReport _oBusinessVasReport = new BusinessVasReport(this.Page, "application/x-excel");
        _oBusinessVasReport.SetFileName(WebFunc.qsTable + ".xls");
        _oBusinessVasReport.SetStartRecordIndex(-1);
        _oBusinessVasReport.SetLimitRecordIndex(-1);
        _oBusinessVasReport.ExportReport();
    }
    #endregion

    #region BusinessVasDescriptionRaw
    protected void BusinessVasDescriptionRaw()
    {
        BusinessVasDescriptionReport _oBusinessVasDescriptionReport = new BusinessVasDescriptionReport(this.Page, "application/x-excel");
        _oBusinessVasDescriptionReport.SetFileName(WebFunc.qsTable + ".xls");
        _oBusinessVasDescriptionReport.SetStartRecordIndex(-1);
        _oBusinessVasDescriptionReport.SetLimitRecordIndex(-1);
        _oBusinessVasDescriptionReport.ExportReport();
    }
    #endregion

    #region AutoSelectionPropertyRaw
    protected void AutoSelectionPropertyRaw()
    {
        AutoSelectionPropertyReport _oAutoSelectionPropertyReport = new AutoSelectionPropertyReport(this.Page, "application/x-excel");
        _oAutoSelectionPropertyReport.SetFileName("Tier.xls");
        _oAutoSelectionPropertyReport.SetStartRecordIndex(-1);
        _oAutoSelectionPropertyReport.SetLimitRecordIndex(-1);
        _oAutoSelectionPropertyReport.SetAllView(true);
        AutoSelectionPropertyInfo _oAutoSelectionPropertyInfo = _oAutoSelectionPropertyReport.GetAutoSelectionPropertyInfo();
        _oAutoSelectionPropertyInfo.Fields(AutoSelectionProperty.Para.id).IsView = false;



        _oAutoSelectionPropertyReport.ResetTable(_oAutoSelectionPropertyInfo);

        _oAutoSelectionPropertyReport.ExportReport();
    }
    #endregion


    #region BundleMappingRaw
    protected void BundleMappingRaw()
    {
        BundleMappingReport _oBundleMappingReport = new BundleMappingReport(this.Page, "application/x-excel");
        _oBundleMappingReport.SetFileName("BundleMapping.xls");
        _oBundleMappingReport.SetStartRecordIndex(-1);
        _oBundleMappingReport.SetLimitRecordIndex(-1);
        _oBundleMappingReport.SetAllView(true);
        BundleMappingInfo _oBundleMappingInfo = _oBundleMappingReport.GetBundleMappingInfo();
        _oBundleMappingReport.ResetTable(_oBundleMappingInfo);
        _oBundleMappingReport.ExportReport();
    }
    #endregion

    #region GetDB
    protected MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        _oDB.bWithNoLock = true;
        return _oDB;
    }
    #endregion

    #region Get Oracle DB
    protected ODBCConnect GetORDB()
    {
        ODBCConnect _oDB = new ODBCConnect();
        _oDB.SetConnStr(Configurator.DBName.ORADNS+((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
}
