using System;
using System.Windows.Forms;

namespace Testbench
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            InitializeControls();

        }

        private void InitializeControls()
        {
            Text = "T-Bench";

            btnSvcState.Text = "Run Service State";
            btnSigStrength.Text = "Run Signal Strength";
            btnTestSvc.Text = "Test Service State";
            btnClose.Text = "&Close";
        }

        private void btnSvcState_Click(object sender, EventArgs e)
        {

            //string strIn = "{mVoiceRegState=0(IN_SERVICE), mDataRegState=0(IN_SERVICE), mChannelNumber=2147483647, duplexMode()=0, mCellBandwidths=[], mVoiceOperatorAlphaLong=CHN-UNICOM, mVoiceOperatorAlphaShort=UNICOM, mDataOperatorAlphaLong=CHN-UNICOM, mDataOperatorAlphaShort=UNICOM, isManualNetworkSelection=false(automatic), getRilVoiceRadioTechnology=14(LTE), getRilDataRadioTechnology=14(LTE), mCssIndicator=unsupported, mNetworkId=-1, mSystemId=-1, mCdmaRoamingIndicator=-1, mCdmaDefaultRoamingIndicator=-1, mIsEmergencyOnly=false, isUsingCarrierAggregation=true, mLteEarfcnRsrpBoost=0, mNetworkRegistrationInfos=[NetworkRegistrationInfo{ domain=CS transportType=WWAN registrationState=HOME roamingType=NOT_ROAMING accessNetworkTechnology=LTE rejectCause=0 emergencyEnabled=false availableServices=[VOICE,SMS,VIDEO] cellIdentity=CellIdentityLte:{ mCi=8844831 mPci=2147483647 mTac=6167 mEarfcn=2147483647 mBandwidth=2147483647 mMcc=null mMnc=null mAlphaLong= mAlphaShort=} voiceSpecificInfo=VoiceSpecificRegistrationInfo { mCssSupported=false mRoamingIndicator=1 mSystemIsInPrl=0 mDefaultRoamingIndicator=0} dataSpecificInfo=null nrState=NONE}, NetworkRegistrationInfo{ domain=PS transportType=WWAN registrationState=HOME roamingType=NOT_ROAMING accessNetworkTechnology=LTE rejectCause=-1 emergencyEnabled=false availableServices=[DATA] cellIdentity=CellIdentityLte:{ mCi=8844831 mPci=317 mTac=6167 mEarfcn=2147483647 mBandwidth=2147483647 mMcc=460 mMnc=null mAlphaLong= mAlphaShort=} voiceSpecificInfo=null dataSpecificInfo=android.telephony.DataSpecificRegistrationInfo :{ maxDataCalls = 20 isDcNrRestricted = false isNrAvailable = false isEnDcAvailable = false LteVopsSupportInfo :  mVopsSupport = 1 mEmcBearerSupport = 1 mIsUsingCarrierAggregation = true } nrState=NONE}], mNrFrequencyRange=-1, mOperatorAlphaLongRaw=CHN-UNICOM, mOperatorAlphaShortRaw=UNICOM, mIsIwlanPreferred=false}";
            string strIn = "{mVoiceRegState=0(IN_SERVICE), mDataRegState=0(IN_SERVICE), mChannelNumber=6400, duplexMode()=1, mCellBandwidths=[], isManualNetworkSelection=false(automatic), getRilVoiceRadioTechnology=14(LTE), getRilDataRadioTechnology=14(LTE), mCssIndicator=unsupported, mCdmaRoamingIndicator=-1, mCdmaDefaultRoamingIndicator=-1, VoiceRegType=0, ImsVoiceAvail=2, Snap=0, MobileVoice=IN_SERVICE, MobileVoiceRat=Unknown, MobileData=IN_SERVICE, MobileDataRoamingType=home, MobileDataRat=LTE PsOnly=false FemtocellInd=0 SprDisplayRoam=false EndcStatus=0 RestrictDcnr=0 NrBearerStatus=1 5gStatus=1 RRCState=1 NrIconType=0, mIsEmergencyOnly=false, isUsingCarrierAggregation=true, mLteEarfcnRsrpBoost=0, mNetworkRegistrationInfos=[NetworkRegistrationInfo{ domain=CS transportType=WWAN registrationState=HOME roamingType=NOT_ROAMING accessNetworkTechnology=LTE rejectCause=0 emergencyEnabled=false availableServices=[VOICE,SMS,VIDEO] cellIdentity=CellIdentityLte:{ mCi=43553792 mPci=111 mTac=21025 mEarfcn=6400 mBandwidth=0 mMcc=262 mMnc=01 mAlphaLong=Telekom.de mAlphaShort=TDG} voiceSpecificInfo=VoiceSpecificRegistrationInfo { mCssSupported=false mRoamingIndicator=0 mSystemIsInPrl=0 mDefaultRoamingIndicator=0} dataSpecificInfo=null nrState=NONE}, NetworkRegistrationInfo{ domain=PS transportType=WWAN registrationState=HOME roamingType=NOT_ROAMING accessNetworkTechnology=LTE rejectCause=0 emergencyEnabled=false availableServices=[DATA] cellIdentity=CellIdentityLte:{ mCi=43553792 mPci=111 mTac=21025 mEarfcn=6400 mBandwidth=0 mMcc=262 mMnc=01 mAlphaLong=Telekom.de mAlphaShort=TDG} voiceSpecificInfo=null dataSpecificInfo=android.telephony.DataSpecificRegistrationInfo :{ maxDataCalls = 4 isDcNrRestricted = false isNrAvailable = false isEnDcAvailable = false LteVopsSupportInfo :  mVopsSupport = 2 mEmcBearerSupport = 2 mIsUsingCarrierAggregation = true } nrState=CONNECTED}], mNrFrequencyRange=-1, mIsIwlanPreferred=false}";
            
            CServiceState serviceState =  new CServiceState();

            #region Array[0]
            Console.WriteLine("Array[0]");
            Console.WriteLine("VoiceRegState: " + serviceState.GetVoiceRegState(strIn));
            Console.WriteLine("DataRegState: " + serviceState.GetDataRegState(strIn));
            Console.WriteLine("ChannelNumber: " + serviceState.GetChannelNumber(strIn));
            Console.WriteLine("DuplexMode: " + serviceState.GetDuplexMode(strIn));
            Console.WriteLine("CellBandwidths: " + serviceState.GetCellBandwidths(strIn));
            Console.WriteLine("ManualNetworkSelection: " + serviceState.GetManualNetworkSelection(strIn));
            Console.WriteLine("VoiceRadioTechnology: " + serviceState.GetVoiceRadioTechnology(strIn));
            Console.WriteLine("DataRadioTechnology: " + serviceState.GetDataRadioTechnology(strIn));
            Console.WriteLine("CssIndicator: " + serviceState.GetCssIndicator(strIn));
            Console.WriteLine("CdmaRoamingIndicator: " + serviceState.GetCdmaRoamingIndicator(strIn));
            Console.WriteLine("CdmaDefaultRoamingIndicator: " + serviceState.GetCdmaDefaultRoamingIndicator(strIn));
            Console.WriteLine("VoiceRegType: " + serviceState.GetVoiceRegType(strIn));
            Console.WriteLine("ImsVoiceAvail: " + serviceState.GetImsVoiceAvail(strIn));
            Console.WriteLine("Snap: " + serviceState.GetSnap(strIn));
            Console.WriteLine("MobileVoice: " + serviceState.GetMobileVoice(strIn));
            Console.WriteLine("MobileVoiceRat: " + serviceState.GetMobileVoiceRat(strIn));
            Console.WriteLine("MobileData: " + serviceState.GetMobileData(strIn));
            Console.WriteLine("MobileDataRoamingType: " + serviceState.GetMobileDataRoamingType(strIn));
            Console.WriteLine("MobileDataRat: " + serviceState.GetMobileDataRat(strIn));
            Console.WriteLine("PsOnly: " + serviceState.GetPsOnly(strIn));
            Console.WriteLine("FemtocellInd: " + serviceState.GetFemtocellInd(strIn));
            Console.WriteLine("SprDisplayRoam: " + serviceState.GetSprDisplayRoam(strIn));
            Console.WriteLine("EndcStatus: " + serviceState.GetEndcStatus(strIn));
            Console.WriteLine("RestrictDcnr: " + serviceState.GetRestrictDcnr(strIn));
            Console.WriteLine("NrBearerStatus: " + serviceState.GetNrBearerStatus(strIn));
            Console.WriteLine("5GStatus: " + serviceState.Get5GStatus(strIn));
            Console.WriteLine("RRCState: " + serviceState.GetRRCState(strIn));
            Console.WriteLine("NrIconType: " + serviceState.GetNrIconType(strIn));
            Console.WriteLine("IsEmergencyOnly: " + serviceState.GetIsEmergencyOnly(strIn));
            Console.WriteLine("IsUsingCarrierAggregation: " + serviceState.GetIsUsingCarrierAggregation(strIn));
            Console.WriteLine("LteEarfcnRsrpBoost: " + serviceState.GetLteEarfcnRsrpBoost(strIn));
            Console.WriteLine("Domain: " + serviceState.GetDomain(strIn));
            Console.WriteLine("TransportType: " + serviceState.GetTransportType(strIn));
            Console.WriteLine("RegistrationState: " + serviceState.GetRegistrationState(strIn));
            Console.WriteLine("RoamingType: " + serviceState.GetRoamingType(strIn));
            Console.WriteLine("AccessNetworkTechnology: " + serviceState.GetAccessNetworkTechnology(strIn));
            Console.WriteLine("RejectCause: " + serviceState.GetRejectCause(strIn));
            Console.WriteLine("EmergencyEnabled: " + serviceState.GetEmergencyEnabled(strIn));
            Console.WriteLine("AvailableServices: " + serviceState.GetAvailableServices(strIn)); 
            #endregion

            #region Array[1]
            Console.WriteLine("Array[1]");
            Console.WriteLine("DataCi: " + serviceState.GetDataCi(strIn));
            Console.WriteLine("DataPci: " + serviceState.GetDataPci(strIn));
            Console.WriteLine("DataTac: " + serviceState.GetDataTac(strIn));
            Console.WriteLine("DataEarfcn: " + serviceState.GetDataEarfcn(strIn));
            Console.WriteLine("DataBandwidth: " + serviceState.GetDataBandwidth(strIn));
            Console.WriteLine("DataMcc: " + serviceState.GetDataMcc(strIn));
            Console.WriteLine("DataMnc: " + serviceState.GetDataMnc(strIn));
            Console.WriteLine("DataAlphaLong: " + serviceState.GetDataAlphaLong(strIn));
            Console.WriteLine("DataAlphaShort: " + serviceState.GetDataAlphaShort(strIn));
            Console.WriteLine("DataCssSupported: " + serviceState.GetDataCssSupported(strIn));
            Console.WriteLine("DataRoamingIndicator: " + serviceState.GetDataRoamingIndicator(strIn));
            Console.WriteLine("DataSystemIsInPrl: " + serviceState.GetDataSystemIsInPrl(strIn));
            Console.WriteLine("DataDefaultRoamingIndicator: " + serviceState.GetDataDefaultRoamingIndicator(strIn));
            Console.WriteLine("DataDataSpecificInfo: " + serviceState.GetDataDataSpecificInfo(strIn));
            Console.WriteLine("DataNrState: " + serviceState.GetDataNrState(strIn));
            Console.WriteLine("DataDomain: " + serviceState.GetDataDomain(strIn));
            Console.WriteLine("DataTransportType: " + serviceState.GetDataTransportType(strIn));
            Console.WriteLine("DataRegistrationState: " + serviceState.GetDataRegistrationState(strIn));
            Console.WriteLine("GetDataRoamingType: " + serviceState.GetDataRoamingType(strIn));
            Console.WriteLine("DataAccessNetworkTechnology: " + serviceState.GetDataAccessNetworkTechnology(strIn));
            Console.WriteLine("DataRejectCause: " + serviceState.GetDataRejectCause(strIn));
            Console.WriteLine("DataEmergencyEnabled: " + serviceState.GetDataEmergencyEnabled(strIn));
            Console.WriteLine("DataAvailableServices: " + serviceState.GetDataAvailableServices(strIn));

            #endregion

            #region Array[2]
            Console.WriteLine("Array[2]");
            Console.WriteLine("VoiceCi: " + serviceState.GetVoiceCi(strIn));
            Console.WriteLine("VoicePci: " + serviceState.GetVoicePci(strIn));
            Console.WriteLine("VoiceTac: " + serviceState.GetVoiceTac(strIn));
            Console.WriteLine("VoiceEarfcn: " + serviceState.GetVoiceEarfcn(strIn));
            Console.WriteLine("VoiceBandwidth: " + serviceState.GetVoiceBandwidth(strIn));
            Console.WriteLine("VoiceMcc: " + serviceState.GetVoiceMcc(strIn));
            Console.WriteLine("VoiceMnc: " + serviceState.GetVoiceMnc(strIn));
            Console.WriteLine("VoiceAlphaLong: " + serviceState.GetVoiceAlphaLong(strIn));
            Console.WriteLine("VoiceAlphaShort: " + serviceState.GetVoiceAlphaShort(strIn));
            Console.WriteLine("VoiceSpecificInfo: " + serviceState.GetVoiceVoiceSpecificInfo(strIn));

            #endregion

            #region Array[3][4]

            Console.WriteLine("Array[3][4]");
            Console.WriteLine("MaxDataCalls: " + serviceState.GetMaxDataCalls(strIn));
            Console.WriteLine("isDcNrRestricted: " + serviceState.GetisDcNrRestricted(strIn));
            Console.WriteLine("isNrAvailable: " + serviceState.GetisNrAvailable(strIn));
            Console.WriteLine("isEnDcAvailable: " + serviceState.GetisEnDcAvailable(strIn));
            Console.WriteLine("VopsSupport: " + serviceState.GetVopsSupport(strIn));
            Console.WriteLine("EmcBearerSupport: " + serviceState.GetEmcBearerSupport(strIn));
            Console.WriteLine("IsUsingCarrierAggregation: " + serviceState.GetSpcIsUsingCarrierAggregation(strIn));
            Console.WriteLine("NrState: " + serviceState.GetSpcNrState(strIn));
            Console.WriteLine("NrFrequencyRange: " + serviceState.GetNrFrequencyRange(strIn));
            Console.WriteLine("IsIwlanPreferred: " + serviceState.GetIsIwlanPreferred(strIn));

            #endregion
        }

        private void btnSigStrength_Click(object sender, EventArgs e)
        {
            //string strIn = "SignalStrength:{mCdma=CellSignalStrengthCdma: cdmaDbm=2147483647 cdmaEcio=2147483647 evdoDbm=2147483647 evdoEcio=2147483647 evdoSnr=2147483647 level=0,mGsm=CellSignalStrengthGsm: rssi=2147483647 ber=2147483647 mTa=2147483647 mLevel=0,mWcdma=CellSignalStrengthWcdma: ss=2147483647 ber=2147483647 rscp=2147483647 ecno=2147483647 level=0,mTdscdma=CellSignalStrengthTdscdma: rssi=2147483647 ber=2147483647 rscp=2147483647 level=0,mLte=CellSignalStrengthLte: rssi=-55 rsrp=-84 rsrq=-14 rssnr=300 cqi=2147483647 ta=2147483647 level=4,mNr=CellSignalStrengthNr:{ csiRsrp = 2147483647 csiRsrq = 2147483647 csiSinr = 2147483647 ssRsrp = 2147483647 ssRsrq = 2147483647 ssSinr = 2147483647 level = 0 },primary=CellSignalStrengthLte}";
            string strIn = "SignalStrength:{mCdma=Invalid,mGsm=Invalid,mWcdma=Invalid,mTdscdma=Invalid,mLte=CellSignalStrengthLte: rssi=-103 rsrp=-108 rsrq=-9 rssnr=30 cqi=9 ta=2147483647 level=2,mNr=Invalid,SignalBarInfo{ lteLevel=2 nrLevel=2 },rat=14,primary=CellSignalStrengthLte}";

            CSignalStrength SignalStrength = new CSignalStrength();
            SignalStrength.GetCellSignalStrengthCdma(strIn);
            
            Console.WriteLine($"GSM RSSI: {SignalStrength.GsmRssi}");
            Console.WriteLine($"GSM Bit-Error Rate: {SignalStrength.GsmBer}");
            Console.WriteLine($"GSM Timing Advance: {SignalStrength.GsmTa}");
            Console.WriteLine($"GSM Level: {SignalStrength.GsmLevel}");

            Console.WriteLine($"WCDMA SS: {SignalStrength.WcdmaSs}");
            Console.WriteLine($"WCDMA RSCP: {SignalStrength.WcdmaRscp}");
            Console.WriteLine($"WCDMA Bit-Error Rate: {SignalStrength.WcdmaBer}");
            Console.WriteLine($"WCDMA ECNO: {SignalStrength.WcdmaEcno}");
            Console.WriteLine($"WCDMA Level: {SignalStrength.WcdmaLevel}");
            
            Console.WriteLine($"TDSCDMA RSSI: {SignalStrength.TdscdmaRssi}");
            Console.WriteLine($"TDSCDMA RSCP: {SignalStrength.TdscdmaRscp}");
            Console.WriteLine($"TDSCDMA Bit-Error Rate: {SignalStrength.TdscdmaBer}");
            Console.WriteLine($"TDSCDMA Level: {SignalStrength.TdscdmaLevel}");

            Console.WriteLine($"LTE RSSI: {SignalStrength.LteRssi}");
            Console.WriteLine($"LTE RSRP: {SignalStrength.LteRsrp}");
            Console.WriteLine($"LTE RSRQ: {SignalStrength.LteRsrq}");
            Console.WriteLine($"LTE RSSNR: {SignalStrength.LteRssnr}");
            Console.WriteLine($"LTE CQI: {SignalStrength.LteCqi}");
            Console.WriteLine($"LTE Timing Advance: {SignalStrength.LteTa}");
            Console.WriteLine($"LTE Level: {SignalStrength.LteLevel}");

            Console.WriteLine($"5G RSRP: {SignalStrength.NrCsiRsrp}");
            Console.WriteLine($"5G RSRQ: {SignalStrength.NrCsiRsrq}");
            Console.WriteLine($"5G SINR: {SignalStrength.NrCsiSinr}");
            Console.WriteLine($"5G ssRSRP: {SignalStrength.NrSsRsrp}");
            Console.WriteLine($"5G ssRSRQ: {SignalStrength.NrSsRsrq}");
            Console.WriteLine($"5G ssSINR: {SignalStrength.NrSsSinr}");
            Console.WriteLine($"5G LEVEL: {SignalStrength.NrLevel}");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTestSvc_Click(object sender, EventArgs e)
        {
            FrmTest frmTest = new FrmTest();
            frmTest.id = 1;
            frmTest.ShowDialog();
        }
    }
}
