using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Xml.Linq;
using log4net;

using NEURON.ENTITY.FRAMEWORK;
/// <summary>
/// Summary description for RWLFramework
/// </summary>
namespace PCCW.RWL.CORE
{
    public class RWLFramework : EntityFramework
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        public static BasicConfiguratorManager Config
        {
            get
            {
                return BasicConfiguratorManager.Instance();
            }
        }

        public static CurrentUserSetting CurrentUser
        {
            get
            {
                return CurrentUserSetting.Instance();
            }
        }


        public RWLFramework()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static T Control<T>()
        {
            try
            {
                return RWLFramework.Environment.Model<T>();
            }
            catch (Exception exp)
            {
                throw new BusinessObjectNotFoundException(exp.ToString());
            }
            return default(T);
        }

        public static void DataBaseConfigSetting()
        {
            Configurator _oConfigurator = Configurator.Instance();
            _oConfigurator.MSSQLConnName = "MobileRetentionOrderDB";
            _oConfigurator.ODBCConnName = "ORADNS";
            RWLFramework.Config.BasicConfigurator.Configure(_oConfigurator);
        }

        #region SystemMemory
        public static void PreLoadDataToMemory()
        {
            PreLoadDataToMemory(false);
        }

        public static void PreLoadDataToMemory(bool x_bMustReload)
        {
            LocationTimeMemory.Instance().PreLoadDataToMemory(x_bMustReload);
            VasCreateHolderControl.Instance().PreLoadDataToMemory(x_bMustReload);
            MobileOneLevel.Instance().PreloadMobileLevelDescToMemory(x_bMustReload);
            AccessRightControl.Instance().PreLoadDataToMemory(x_bMustReload);
        }

        #endregion


        #region Asset Model
        public static void InitModel()
        {
            if (RWLFramework.Environment.GetAssetCount() < 29)
                RWLFramework.Environment.AssetRelease();

            if (!RWLFramework.Environment.IsInitEnvironment())
            {
                VasAutoSetScript.Instance().InitVasSetScript();
                RWLFramework.Environment.AssetModel(typeof(EDFRWLCombineSynchronizationl));
                RWLFramework.Environment.AssetModel(typeof(AccessoryIMEIControl));
                RWLFramework.Environment.AssetModel(typeof(AoInStockControl));
                RWLFramework.Environment.AssetModel(typeof(BundleMappingPropertyControler));
                RWLFramework.Environment.AssetModel(typeof(BusinessContractPeriodControler));
                RWLFramework.Environment.AssetModel(typeof(BusinessDeliveryFalloutProfile));

                RWLFramework.Environment.AssetModel(typeof(BusinessRatePlanManagement));
                RWLFramework.Environment.AssetModel(typeof(CustomerCallListDocumentDAO));
                RWLFramework.Environment.AssetModel(typeof(DeliveryTimeTrackable));
                RWLFramework.Environment.AssetModel(typeof(EDFAOControler));
                RWLFramework.Environment.AssetModel(typeof(FreeBusinessRelationControler));

                RWLFramework.Environment.AssetModel(typeof(FromRegisterControler));
                RWLFramework.Environment.AssetModel(typeof(GiftControl));
                RWLFramework.Environment.AssetModel(typeof(GiftIMEIControl));
                RWLFramework.Environment.AssetModel(typeof(HandSetEnvironment));
                RWLFramework.Environment.AssetModel(typeof(IMEIGiftStatusControl));

                RWLFramework.Environment.AssetModel(typeof(IMEISoldAwaitControl));
                RWLFramework.Environment.AssetModel(typeof(MobileCsaOperationCenter));
                RWLFramework.Environment.AssetModel(typeof(MobileOrderViewControler));
                RWLFramework.Environment.AssetModel(typeof(MobileSequentialCountProfile));
                RWLFramework.Environment.AssetModel(typeof(ODBMrtGwChk));

                RWLFramework.Environment.AssetModel(typeof(ORGFeeProfile));
                RWLFramework.Environment.AssetModel(typeof(PaymentOfferProfile));
                RWLFramework.Environment.AssetModel(typeof(RebateProfileControler));
                RWLFramework.Environment.AssetModel(typeof(RwlReportSYSControl));

                RWLFramework.Environment.AssetModel(typeof(SaleManCodeProfile));
                RWLFramework.Environment.AssetModel(typeof(SimMrtControl));
                RWLFramework.Environment.AssetModel(typeof(TradingSystemHandSetProvider));
                RWLFramework.Environment.AssetModel(typeof(TradingSystemPremiumProvider));



            }
        }
        #endregion
    }
}