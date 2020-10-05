using System;

namespace Testbench
{
    class CServiceState
    {
        #region ServiceStateCommon
        public string GetVoiceRegState(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut="";
            if (parse.Contains("mVoiceRegState="))
            {
                int first = parse.IndexOf("mVoiceRegState=");
                int last = parse.IndexOf(", ", first);
                int subStart = first + "mVoiceRegState=".Length;
                int subLength = last - (first + "mVoiceRegState=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataRegState(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("mDataRegState="))
            {
                int first = parse.IndexOf("mDataRegState=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "mDataRegState=".Length;
                int subLength = last - (first + "mDataRegState=".Length);


                parsedOut = inpStr.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetChannelNumber(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("mChannelNumber="))
            {
                int first = parse.IndexOf("mChannelNumber=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "mChannelNumber=".Length;
                int subLength = last - (first + "mChannelNumber=".Length);

                parsedOut = inpStr.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDuplexMode(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("duplexMode()="))
            {
                int first = parse.IndexOf("duplexMode()=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "duplexMode()=".Length;
                int subLength = last - (first + "duplexMode()=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetCellBandwidths(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("mCellBandwidths="))
            {
                int first = parse.IndexOf("mCellBandwidths=");
                int last = parse.IndexOf("]", first);
                int subStart = first + "mCellBandwidths=".Length;
                int subLength = last + 1 - (first + "mCellBandwidths=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetManualNetworkSelection(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("isManualNetworkSelection="))
            {
                int first = parse.IndexOf("isManualNetworkSelection=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "isManualNetworkSelection=".Length;
                int subLength = last - (first + "isManualNetworkSelection=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetVoiceRadioTechnology(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("getRilVoiceRadioTechnology="))
            {
                int first = parse.IndexOf("getRilVoiceRadioTechnology=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "getRilVoiceRadioTechnology=".Length;
                int subLength = last - (first + "getRilVoiceRadioTechnology=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataRadioTechnology(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("getRilDataRadioTechnology="))
            {
                int first = parse.IndexOf("getRilDataRadioTechnology=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "getRilDataRadioTechnology=".Length;
                int subLength = last - (first + "getRilDataRadioTechnology=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetCssIndicator(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("mCssIndicator="))
            {
                int first = parse.IndexOf("mCssIndicator=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "mCssIndicator=".Length;
                int subLength = last - (first + "mCssIndicator=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetCdmaRoamingIndicator(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("mCdmaRoamingIndicator="))
            {
                int first = parse.IndexOf("mCdmaRoamingIndicator=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "mCdmaRoamingIndicator=".Length;
                int subLength = last - (first + "mCdmaRoamingIndicator=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetCdmaDefaultRoamingIndicator(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("mCdmaDefaultRoamingIndicator="))
            {
                int first = parse.IndexOf("mCdmaDefaultRoamingIndicator=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "mCdmaDefaultRoamingIndicator=".Length;
                int subLength = last - (first + "mCdmaDefaultRoamingIndicator=".Length);

                parsedOut = parse.Substring(subStart, subLength);

            }
            else
            {
                parsedOut = "NA";
            }
            return parsedOut;
        }

        public string GetVoiceRegType(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if(parse.Contains("VoiceRegType="))
            {
                int first = parse.IndexOf("VoiceRegType=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "VoiceRegType=".Length;
                int subLength = last - (first + "VoiceRegType=".Length);

                parsedOut = parse.Substring(subStart, subLength);

                
            }
            else
            {

                parsedOut = "NA";
            }
            return parsedOut;
        }

        public string GetImsVoiceAvail(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if(parse.Contains("ImsVoiceAvail="))
            {
                int first = parse.IndexOf("ImsVoiceAvail=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "ImsVoiceAvail=".Length;
                int subLength = last - (first + "ImsVoiceAvail=".Length);

                parsedOut = parse.Substring(subStart, subLength);

            }
            else
            {
                parsedOut = "NA";
            }
            return parsedOut;
        }

        public string GetSnap(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("Snap="))
            {
                int first = parse.IndexOf("Snap=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "Snap=".Length;
                int subLength = last - (first + "Snap=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetMobileVoice(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("MobileVoice="))
            {
                int first = parse.IndexOf("MobileVoice=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "MobileVoice=".Length;
                int subLength = last - (first + "MobileVoice=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetMobileVoiceRat(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("MobileVoiceRat="))
            {
                int first = parse.IndexOf("MobileVoiceRat=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "MobileVoiceRat=".Length;
                int subLength = last - (first + "MobileVoiceRat=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetMobileData(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("MobileData="))
            {
                int first = parse.IndexOf("MobileData=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "MobileData=".Length;
                int subLength = last - (first + "MobileData=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetMobileDataRoamingType(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("MobileDataRoamingType="))
            {
                int first = parse.IndexOf("MobileDataRoamingType=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "MobileDataRoamingType=".Length;
                int subLength = last - (first + "MobileDataRoamingType=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetMobileDataRat(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("MobileDataRat="))
            {
                int first = parse.IndexOf("MobileDataRat=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "MobileDataRat=".Length;
                int subLength = last - (first + "MobileDataRat=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetPsOnly(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("PsOnly="))
            {
                int first = parse.IndexOf("PsOnly=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "PsOnly=".Length;
                int subLength = last - (first + "PsOnly=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetFemtocellInd(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("FemtocellInd="))
            {
                int first = parse.IndexOf("FemtocellInd=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "FemtocellInd=".Length;
                int subLength = last - (first + "FemtocellInd=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetSprDisplayRoam(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("SprDisplayRoam="))
            {
                int first = parse.IndexOf("SprDisplayRoam=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "SprDisplayRoam=".Length;
                int subLength = last - (first + "SprDisplayRoam=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetEndcStatus(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("EndcStatus="))
            {
                int first = parse.IndexOf("EndcStatus=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "EndcStatus=".Length;
                int subLength = last - (first + "EndcStatus=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetRestrictDcnr(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("RestrictDcnr="))
            {
                int first = parse.IndexOf("RestrictDcnr=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "RestrictDcnr=".Length;
                int subLength = last - (first + "RestrictDcnr=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetNrBearerStatus(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("NrBearerStatus="))
            {
                int first = parse.IndexOf("NrBearerStatus=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "NrBearerStatus=".Length;
                int subLength = last - (first + "NrBearerStatus=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string Get5GStatus(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("5gStatus="))
            {
                int first = parse.IndexOf("5gStatus=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "5gStatus=".Length;
                int subLength = last - (first + "5gStatus=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetRRCState(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("RRCState="))
            {
                int first = parse.IndexOf("RRCState=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "RRCState=".Length;
                int subLength = last - (first + "RRCState=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetNrIconType(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("NrIconType="))
            {
                int first = parse.IndexOf("NrIconType=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "NrIconType=".Length;
                int subLength = last - (first + "NrIconType=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetIsEmergencyOnly(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("mIsEmergencyOnly="))
            {
                int first = parse.IndexOf("mIsEmergencyOnly=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "mIsEmergencyOnly=".Length;
                int subLength = last - (first + "mIsEmergencyOnly=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetIsUsingCarrierAggregation(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("isUsingCarrierAggregation="))
            {
                int first = parse.IndexOf("isUsingCarrierAggregation=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "isUsingCarrierAggregation=".Length;
                int subLength = last - (first + "isUsingCarrierAggregation=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }

            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetLteEarfcnRsrpBoost(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("mLteEarfcnRsrpBoost="))
            {
                int first = parse.IndexOf("mLteEarfcnRsrpBoost=");
                int last = parse.IndexOf(",", first);
                int subStart = first + "mLteEarfcnRsrpBoost=".Length;
                int subLength = last - (first + "mLteEarfcnRsrpBoost=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDomain(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("domain="))
            {
                int first = parse.IndexOf("domain=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "domain=".Length;
                int subLength = last - (first + "domain=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetTransportType(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("transportType="))
            {
                int first = parse.IndexOf("transportType=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "transportType=".Length;
                int subLength = last - (first + "transportType=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetRegistrationState(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("registrationState="))
            {
                int first = parse.IndexOf("registrationState=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "registrationState=".Length;
                int subLength = last - (first + "registrationState=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetRoamingType(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("roamingType="))
            {
                int first = parse.IndexOf("roamingType=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "roamingType=".Length;
                int subLength = last - (first + "roamingType=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetAccessNetworkTechnology(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("accessNetworkTechnology="))
            {
                int first = parse.IndexOf("accessNetworkTechnology=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "accessNetworkTechnology=".Length;
                int subLength = last - (first + "accessNetworkTechnology=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetRejectCause(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("rejectCause="))
            {
                int first = parse.IndexOf("rejectCause=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "rejectCause=".Length;
                int subLength = last - (first + "rejectCause=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetEmergencyEnabled(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("emergencyEnabled="))
            {
                int first = parse.IndexOf("emergencyEnabled=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "emergencyEnabled=".Length;
                int subLength = last - (first + "emergencyEnabled=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetAvailableServices(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[0];
            string parsedOut = "";
            if (parse.Contains("availableServices="))
            {
                int first = parse.IndexOf("availableServices=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "availableServices=".Length;
                int subLength = last - (first + "availableServices=".Length);

                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        } 
        #endregion

        #region ServiceStateData

        public string GetDataCi(string inpStr)// mCi
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mCi="))
            {
                int first = parse.IndexOf("mCi=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mCi=".Length;
                int subLength = last - (first + "mCi=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataPci(string inpStr)//mPci
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mPci="))
            {
                int first = parse.IndexOf("mPci=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mPci=".Length;
                int subLength = last - (first + "mPci=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataTac(string inpStr)//mTac
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mTac="))
            {
                int first = parse.IndexOf("mTac=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mTac=".Length;
                int subLength = last - (first + "mTac=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataEarfcn(string inpStr)//mEarfcn
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mEarfcn="))
            {
                int first = parse.IndexOf("mEarfcn=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mEarfcn=".Length;
                int subLength = last - (first + "mEarfcn=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataBands(string inpStr)//mBands
        {
            string[] x = inpStr.Split(':');
            string parse = x[2];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mBands="))
            {
                int first = parse.IndexOf("mBands=");
                int last = parse.IndexOf("]", first);
                int subStart = first + "mBands=".Length;
                int subLength = last + 1 - (first + "mBands=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataBandwidth(string inpStr)//mBandwidth
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mBandwidth="))
            {
                int first = parse.IndexOf("mBandwidth=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mBandwidth=".Length;
                int subLength = last - (first + "mBandwidth=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataMcc(string inpStr)//mMcc
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mMcc="))
            {
                int first = parse.IndexOf("mMcc=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mMcc=".Length;
                int subLength = last - (first + "mMcc=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataMnc(string inpStr)//mMnc
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mMnc="))
            {
                int first = parse.IndexOf("mMnc=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mMnc=".Length;
                int subLength = last - (first + "mMnc=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataAlphaLong(string inpStr)//mAlphaLong
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mAlphaLong="))
            {
                int first = parse.IndexOf("mAlphaLong=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mAlphaLong=".Length;
                int subLength = last - (first + "mAlphaLong=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataAlphaShort(string inpStr)//mAlphaShort
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mAlphaShort="))
            {
                int first = parse.IndexOf("mAlphaShort=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mAlphaShort=".Length;
                int subLength = last - (first + "mAlphaShort=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataAdditionalPlmns(string inpStr)//mAdditionalPlmns
        {
            string[] x = inpStr.Split(':');
            string parse = x[2];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mAdditionalPlmns="))
            {
                int first = parse.IndexOf("mAdditionalPlmns=");
                int last = parse.IndexOf("}", first);
                int subStart = first + "mAdditionalPlmns=".Length;
                int subLength = last + 1 - (first + "mAdditionalPlmns=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataCsgInfo(string inpStr)//mCsgInfo
        {
            string[] x = inpStr.Split(':');
            string parse = x[2];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mCsgInfo="))
            {
                int first = parse.IndexOf("mCsgInfo=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mCsgInfo=".Length;
                int subLength = last - (first + "mCsgInfo=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataCssSupported(string inpStr)//mCssSupported
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mCssSupported="))
            {
                int first = parse.IndexOf("mCssSupported=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mCssSupported=".Length;
                int subLength = last - (first + "mCssSupported=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataRoamingIndicator(string inpStr)//mRoamingIndicator
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mRoamingIndicator="))
            {
                int first = parse.IndexOf("mRoamingIndicator=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mRoamingIndicator=".Length;
                int subLength = last - (first + "mRoamingIndicator=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataSystemIsInPrl(string inpStr)//mSystemIsInPrl
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mSystemIsInPrl="))
            {
                int first = parse.IndexOf("mSystemIsInPrl=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mSystemIsInPrl=".Length;
                int subLength = last - (first + "mSystemIsInPrl=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataDefaultRoamingIndicator(string inpStr)//mDefaultRoamingIndicator
        {
            string[] x = inpStr.Split(':');
            string parse = inpStr; //x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mDefaultRoamingIndicator="))
            {
                int first = parse.IndexOf("mDefaultRoamingIndicator=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mDefaultRoamingIndicator=".Length;
                int subLength = last - (first + "mDefaultRoamingIndicator=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataDataSpecificInfo(string inpStr)//dataSpecificInfo
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("dataSpecificInfo="))
            {
                int first = parse.IndexOf("dataSpecificInfo=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "dataSpecificInfo=".Length;
                int subLength = last - (first + "dataSpecificInfo=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataNrState(string inpStr)//nrState
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("nrState="))
            {
                int first = parse.IndexOf("nrState=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "nrState=".Length;
                int subLength = last - (first + "nrState=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDatarRplmn(string inpStr)//rRplmn=
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("rRplmn="))
            {
                int first = parse.IndexOf("rRplmn=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "rRplmn=".Length;
                int subLength = last - (first + "rRplmn=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataDomain(string inpStr)//domain
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("domain="))
            {
                int first = parse.IndexOf("domain=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "domain=".Length;
                int subLength = last - (first + "domain=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataTransportType(string inpStr)//transportType
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("transportType="))
            {
                int first = parse.IndexOf("transportType=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "transportType=".Length;
                int subLength = last - (first + "transportType=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataRegistrationState(string inpStr)//registrationState
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("registrationState="))
            {
                int first = parse.IndexOf("registrationState=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "registrationState=".Length;
                int subLength = last - (first + "registrationState=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataRoamingType(string inpStr)//roamingType
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("roamingType="))
            {
                int first = parse.IndexOf("roamingType=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "roamingType=".Length;
                int subLength = last - (first + "roamingType=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataAccessNetworkTechnology(string inpStr)//accessNetworkTechnology
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("accessNetworkTechnology="))
            {
                int first = parse.IndexOf("accessNetworkTechnology=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "accessNetworkTechnology=".Length;
                int subLength = last - (first + "accessNetworkTechnology=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataRejectCause(string inpStr)//rejectCause
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("rejectCause="))
            {
                int first = parse.IndexOf("rejectCause=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "rejectCause=".Length;
                int subLength = last - (first + "rejectCause=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataEmergencyEnabled(string inpStr)//emergencyEnabled
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("emergencyEnabled="))
            {
                int first = parse.IndexOf("emergencyEnabled=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "emergencyEnabled=".Length;
                int subLength = last - (first + "emergencyEnabled=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetDataAvailableServices(string inpStr)//availableServices
        {
            string[] x = inpStr.Split(':');
            string parse = x[1];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("availableServices="))
            {
                int first = parse.IndexOf("availableServices=");
                int last = parse.IndexOf("]", first);
                int subStart = first + "availableServices=".Length;
                int subLength = last + 1 - (first + "availableServices=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }
        #endregion

        #region ServiceStateVoice

        public string GetVoiceCi(string inpStr)//mCi
        {
            string[] x = inpStr.Split(':');
            string parse = x[2];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mCi="))
            {
                int first = parse.IndexOf("mCi=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mCi=".Length;
                int subLength = last - (first + "mCi=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetVoicePci(string inpStr)//mPci
        {
            string[] x = inpStr.Split(':');
            string parse = x[2];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mPci="))
            {
                int first = parse.IndexOf("mPci=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mPci=".Length;
                int subLength = last - (first + "mPci=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetVoiceTac(string inpStr)//mTac
        {
            string[] x = inpStr.Split(':');
            string parse = x[2];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mTac="))
            {
                int first = parse.IndexOf("mTac=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mTac=".Length;
                int subLength = last - (first + "mTac=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetVoiceEarfcn(string inpStr)//mEarfcn
        {
            string[] x = inpStr.Split(':');
            string parse = x[2];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mEarfcn="))
            {
                int first = parse.IndexOf("mEarfcn=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mEarfcn=".Length;
                int subLength = last - (first + "mEarfcn=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetVoiceBands(string inpStr)//mBands
        {
            string[] x = inpStr.Split(':');
            string parse = x[2];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mBands="))
            {
                int first = parse.IndexOf("mBands=");
                int last = parse.IndexOf("]", first);
                int subStart = first + "mBands=".Length;
                int subLength = last + 1 - (first + "mBands=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetVoiceBandwidth(string inpStr)//mBandwidth
        {
            string[] x = inpStr.Split(':');
            string parse = x[2];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mBandwidth="))
            {
                int first = parse.IndexOf("mBandwidth=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mBandwidth=".Length;
                int subLength = last - (first + "mBandwidth=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetVoiceMcc(string inpStr)//mMcc
        {
            string[] x = inpStr.Split(':');
            string parse = x[2];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mMcc="))
            {
                int first = parse.IndexOf("mMcc=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mMcc=".Length;
                int subLength = last - (first + "mMcc=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetVoiceMnc(string inpStr)//mMnc
        {
            string[] x = inpStr.Split(':');
            string parse = x[2];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mMnc="))
            {
                int first = parse.IndexOf("mMnc=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mMnc=".Length;
                int subLength = last - (first + "mMnc=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetVoiceAlphaLong(string inpStr)//mAlphaLong
        {
            string[] x = inpStr.Split(':');
            string parse = x[2];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mAlphaLong="))
            {
                int first = parse.IndexOf("mAlphaLong=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mAlphaLong=".Length;
                int subLength = last - (first + "mAlphaLong=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetVoiceAlphaShort(string inpStr)//mAlphaShort
        {
            string[] x = inpStr.Split(':');
            string parse = x[2];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mAlphaShort="))
            {
                int first = parse.IndexOf("mAlphaShort=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mAlphaShort=".Length;
                int subLength = last - (first + "mAlphaShort=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetVoiceAdditionalPlmns(string inpStr)//mAdditionalPlmns
        {
            string[] x = inpStr.Split(':');
            string parse = x[2];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mAdditionalPlmns="))
            {
                int first = parse.IndexOf("mAdditionalPlmns=");
                int last = parse.IndexOf("}", first);
                int subStart = first + "mAdditionalPlmns=".Length;
                int subLength = last + 1 - (first + "mAdditionalPlmns=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetVoiceCsgInfo(string inpStr)//mCsgInfo
        {
            string[] x = inpStr.Split(':');
            string parse = x[2];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("mCsgInfo="))
            {
                int first = parse.IndexOf("mCsgInfo=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mCsgInfo=".Length;
                int subLength = last - (first + "mCsgInfo=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetVoiceVoiceSpecificInfo(string inpStr)
        {
            string[] x = inpStr.Split(':');
            string parse = x[2];
            parse = parse.Replace("}", " }"); //add blank
            string parsedOut;
            if (parse.Contains("voiceSpecificInfo="))
            {
                int first = parse.IndexOf("voiceSpecificInfo=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "voiceSpecificInfo=".Length;
                int subLength = last - (first + "voiceSpecificInfo=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }
       

        #endregion

        #region DataSpecific

        public string GetMaxDataCalls(string inpStr) //maxDataCalls
        {
            string[] x = inpStr.Split(':');
            string parse = x[3] + x[4];
            parse = parse.Replace(" = ", "="); //eleminate spaces around =
            parse = parse.Replace("}", " }"); //add blank
            parse = parse.Replace(",", " ,"); //add blank
            string parsedOut;
            if (parse.Contains("maxDataCalls="))
            {
                int first = parse.IndexOf("maxDataCalls=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "maxDataCalls=".Length;
                int subLength = last - (first + "maxDataCalls=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetisDcNrRestricted(string inpStr)//isDcNrRestricted
        {
            string[] x = inpStr.Split(':');
            string parse = x[3] + x[4];
            parse = parse.Replace(" = ", "="); //eleminate spaces around =
            parse = parse.Replace("}", " }"); //add blank
            parse = parse.Replace(",", " ,"); //add blank
            string parsedOut;
            if (parse.Contains("isDcNrRestricted="))
            {
                int first = parse.IndexOf("isDcNrRestricted=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "isDcNrRestricted=".Length;
                int subLength = last - (first + "isDcNrRestricted=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetisNrAvailable(string inpStr)//isNrAvailable
        {
            string[] x = inpStr.Split(':');
            string parse = x[3] + x[4];
            parse = parse.Replace(" = ", "="); //eleminate spaces around =
            parse = parse.Replace("}", " }"); //add blank
            parse = parse.Replace(",", " ,"); //add blank
            string parsedOut;
            if (parse.Contains("isNrAvailable="))
            {
                int first = parse.IndexOf("isNrAvailable=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "isNrAvailable=".Length;
                int subLength = last - (first + "isNrAvailable=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetisEnDcAvailable(string inpStr)//isEnDcAvailable
        {
            string[] x = inpStr.Split(':');
            string parse = x[3] + x[4];
            parse = parse.Replace(" = ", "="); //eleminate spaces around =
            parse = parse.Replace("}", " }"); //add blank
            parse = parse.Replace(",", " ,"); //add blank
            string parsedOut;
            if (parse.Contains("isEnDcAvailable="))
            {
                int first = parse.IndexOf("isEnDcAvailable=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "isEnDcAvailable=".Length;
                int subLength = last - (first + "isEnDcAvailable=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetVopsSupport(string inpStr)//mVopsSupport
        {
            string[] x = inpStr.Split(':');
            string parse = x[3] + x[4];
            parse = parse.Replace(" = ", "="); //eleminate spaces around =
            parse = parse.Replace("}", " }"); //add blank
            parse = parse.Replace(",", " ,"); //add blank
            string parsedOut;
            if (parse.Contains("mVopsSupport="))
            {
                int first = parse.IndexOf("mVopsSupport=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mVopsSupport=".Length;
                int subLength = last - (first + "mVopsSupport=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetEmcBearerSupport(string inpStr)//mEmcBearerSupport
        {
            string[] x = inpStr.Split(':');
            string parse = x[3] + x[4];
            parse = parse.Replace(" = ", "="); //eleminate spaces around =
            parse = parse.Replace("}", " }"); //add blank
            parse = parse.Replace(",", " ,"); //add blank
            string parsedOut;
            if (parse.Contains("mEmcBearerSupport="))
            {
                int first = parse.IndexOf("mEmcBearerSupport=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mEmcBearerSupport=".Length;
                int subLength = last - (first + "mEmcBearerSupport=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetSpcIsUsingCarrierAggregation(string inpStr)//mIsUsingCarrierAggregation
        {
            string[] x = inpStr.Split(':');
            string parse = x[3] + x[4];
            parse = parse.Replace(" = ", "="); //eleminate spaces around =
            parse = parse.Replace("}", " }"); //add blank
            parse = parse.Replace(",", " ,"); //add blank
            string parsedOut;
            if (parse.Contains("mIsUsingCarrierAggregation="))
            {
                int first = parse.IndexOf("mIsUsingCarrierAggregation=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mIsUsingCarrierAggregation=".Length;
                int subLength = last - (first + "mIsUsingCarrierAggregation=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetSpcNrState(string inpStr)//nrState
        {
            string[] x = inpStr.Split(':');
            string parse = x[3] + x[4];
            parse = parse.Replace(" = ", "="); //eleminate spaces around =
            parse = parse.Replace("}", " }"); //add blank
            parse = parse.Replace(",", " ,"); //add blank
            string parsedOut;
            if (parse.Contains("nrState="))
            {
                int first = parse.IndexOf("nrState=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "nrState=".Length;
                int subLength = last - (first + "nrState=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetRplmn(string inpStr)//rRplmn
        {
            string[] x = inpStr.Split(':');
            string parse = x[3] + x[4];
            parse = parse.Replace(" = ", "="); //eleminate spaces around =
            parse = parse.Replace("}", " }"); //add blank
            parse = parse.Replace(",", " ,"); //add blank
            string parsedOut;
            if (parse.Contains("rRplmn="))
            {
                int first = parse.IndexOf("rRplmn=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "rRplmn=".Length;
                int subLength = last - (first + "rRplmn=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetNrFrequencyRange(string inpStr)//mNrFrequencyRange
        {
            string[] x = inpStr.Split(':');
            string parse = x[3] + x[4];
            parse = parse.Replace(" = ", "="); //eleminate spaces around =
            parse = parse.Replace("}", " }"); //add blank
            parse = parse.Replace(",", " ,"); //add blank
            string parsedOut;
            if (parse.Contains("mNrFrequencyRange="))
            {
                int first = parse.IndexOf("mNrFrequencyRange=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mNrFrequencyRange=".Length;
                int subLength = last - (first + "mNrFrequencyRange=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetOperatorAlphaLongRaw(string inpStr)//mOperatorAlphaLongRaw
        {
            string[] x = inpStr.Split(':');
            string parse = x[3] + x[4];
            parse = parse.Replace(" = ", "="); //eleminate spaces around =
            parse = parse.Replace("}", " }"); //add blank
            parse = parse.Replace(",", " ,"); //add blank
            string parsedOut;
            if (parse.Contains("mOperatorAlphaLongRaw="))
            {
                int first = parse.IndexOf("mOperatorAlphaLongRaw=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mOperatorAlphaLongRaw=".Length;
                int subLength = last - (first + "mOperatorAlphaLongRaw=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetIsDataRoamingFromRegistration(string inpStr)//mIsDataRoamingFromRegistration
        {
            string[] x = inpStr.Split(':');
            string parse = x[3] + x[4];
            parse = parse.Replace(" = ", "="); //eleminate spaces around =
            parse = parse.Replace("}", " }"); //add blank
            parse = parse.Replace(",", " ,"); //add blank
            string parsedOut;
            if (parse.Contains("mIsDataRoamingFromRegistration="))
            {
                int first = parse.IndexOf("mIsDataRoamingFromRegistration=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mIsDataRoamingFromRegistration=".Length;
                int subLength = last - (first + "mIsDataRoamingFromRegistration=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }

        public string GetIsIwlanPreferred(string inpStr)//mIsIwlanPreferred
        {
            string[] x = inpStr.Split(':');
            string parse = x[3] + x[4];
            parse = parse.Replace(" = ", "="); //eleminate spaces around =
            parse = parse.Replace("}", " }"); //add blank
            parse = parse.Replace(",", " ,"); //add blank
            string parsedOut;
            if (parse.Contains("mIsIwlanPreferred="))
            {
                int first = parse.IndexOf("mIsIwlanPreferred=");
                int last = parse.IndexOf(" ", first);
                int subStart = first + "mIsIwlanPreferred=".Length;
                int subLength = last - (first + "mIsIwlanPreferred=".Length);


                parsedOut = parse.Substring(subStart, subLength); 
            }
            else
            {
                parsedOut = "NA";
            }

            return parsedOut;
        }
        #endregion

        #region TestProcedures
        public string CreateServiceState(string strIn)
        {
            string strOut = "";
            string cr = Environment.NewLine;

            #region Array[0]

            strOut = "Array[0]" + cr +
                     "VoiceRegState: " + GetVoiceRegState(strIn) + cr +
                     "DataRegState: " + GetDataRegState(strIn) + cr +
                     "ChannelNumber: " + GetChannelNumber(strIn) + cr +
                     "DuplexMode: " + GetDuplexMode(strIn) + cr +
                     "CellBandwidths: " + GetCellBandwidths(strIn) + cr +
                     "ManualNetworkSelection: " + GetManualNetworkSelection(strIn) + cr +
                     "VoiceRadioTechnology: " + GetVoiceRadioTechnology(strIn) + cr +
                     "DataRadioTechnology: " + GetDataRadioTechnology(strIn) + cr +
                     "CssIndicator: " + GetCssIndicator(strIn) + cr +
                     "CdmaRoamingIndicator: " + GetCdmaRoamingIndicator(strIn) + cr +
                     "CdmaDefaultRoamingIndicator: " + GetCdmaDefaultRoamingIndicator(strIn) + cr +
                     "VoiceRegType: " + GetVoiceRegType(strIn) + cr +
                     "ImsVoiceAvail: " + GetImsVoiceAvail(strIn) + cr +
                     "Snap: " + GetSnap(strIn) + cr +
                     "MobileVoice: " + GetMobileVoice(strIn) + cr +
                     "MobileVoiceRat: " + GetMobileVoiceRat(strIn) + cr +
                     "MobileData: " + GetMobileData(strIn) + cr +
                     "MobileDataRoamingType: " + GetMobileDataRoamingType(strIn) + cr +
                     "MobileDataRat: " + GetMobileDataRat(strIn) + cr +
                     "PsOnly: " + GetPsOnly(strIn) + cr +
                     "FemtocellInd: " + GetFemtocellInd(strIn) + cr +
                     "SprDisplayRoam: " + GetSprDisplayRoam(strIn) + cr +
                     "EndcStatus: " + GetEndcStatus(strIn) + cr +
                     "RestrictDcnr: " + GetRestrictDcnr(strIn) + cr +
                     "NrBearerStatus: " + GetNrBearerStatus(strIn) + cr +
                     "5GStatus: " + Get5GStatus(strIn) + cr +
                     "RRCState: " + GetRRCState(strIn) + cr +
                     "NrIconType: " + GetNrIconType(strIn) + cr +
                     "IsEmergencyOnly: " + GetIsEmergencyOnly(strIn) + cr +
                     "IsUsingCarrierAggregation: " + GetIsUsingCarrierAggregation(strIn) + cr +
                     "LteEarfcnRsrpBoost: " + GetLteEarfcnRsrpBoost(strIn) + cr +
                     "Domain: " + GetDomain(strIn) + cr +
                     "TransportType: " + GetTransportType(strIn) + cr +
                     "RegistrationState: " + GetRegistrationState(strIn) + cr +
                     "RoamingType: " + GetRoamingType(strIn) + cr +
                     "AccessNetworkTechnology: " + GetAccessNetworkTechnology(strIn) + cr +
                     "RejectCause: " + GetRejectCause(strIn) + cr +
                     "EmergencyEnabled: " + GetEmergencyEnabled(strIn) + cr +
                     "AvailableServices: " + GetAvailableServices(strIn) + cr +

                     #endregion

                     #region Array[1]

                     "Array[1]" + cr +
                     "DataCi: " + GetDataCi(strIn) + cr +
                     "DataPci: " + GetDataPci(strIn) + cr +
                     "DataTac: " + GetDataTac(strIn) + cr +
                     "DataEarfcn: " + GetDataEarfcn(strIn) + cr +
                     "DataBands: " + GetDataBands(strIn) + cr +
                     "DataBandwidth: " + GetDataBandwidth(strIn) + cr +
                     "DataMcc: " + GetDataMcc(strIn) + cr +
                     "DataMnc: " + GetDataMnc(strIn) + cr +
                     "DataAlphaLong: " + GetDataAlphaLong(strIn) + cr +
                     "DataAlphaShort: " + GetDataAlphaShort(strIn) + cr +
                     "DataAdditionalPlmns: " + GetDataAdditionalPlmns(strIn) + cr +
                     "DataCsgInfo: " + GetDataCsgInfo(strIn) + cr +
                     "DataCssSupported: " + GetDataCssSupported(strIn) + cr +
                     "DataRoamingIndicator: " + GetDataRoamingIndicator(strIn) + cr +
                     "DataSystemIsInPrl: " + GetDataSystemIsInPrl(strIn) + cr +
                     "DataDefaultRoamingIndicator: " + GetDataDefaultRoamingIndicator(strIn) + cr +
                     "DataDataSpecificInfo: " + GetDataDataSpecificInfo(strIn) + cr +
                     "DataNrState: " + GetDataNrState(strIn) + cr +
                     "DatarRplmn: " + GetDatarRplmn(strIn) + cr +
                     "DataDomain: " + GetDataDomain(strIn) + cr +
                     "DataTransportType: " + GetDataTransportType(strIn) + cr +
                     "DataRegistrationState: " + GetDataRegistrationState(strIn) + cr +
                     "GetDataRoamingType: " + GetDataRoamingType(strIn) + cr +
                     "DataAccessNetworkTechnology: " + GetDataAccessNetworkTechnology(strIn) + cr +
                     "DataRejectCause: " + GetDataRejectCause(strIn) + cr +
                     "DataEmergencyEnabled: " + GetDataEmergencyEnabled(strIn) + cr +
                     "DataAvailableServices: " + GetDataAvailableServices(strIn) + cr +

                     #endregion

                     #region Array[2]

                     "Array[2]" + cr +
                     "VoiceCi: " + GetVoiceCi(strIn) + cr +
                     "VoicePci: " + GetVoicePci(strIn) + cr +
                     "VoiceTac: " + GetVoiceTac(strIn) + cr +
                     "VoiceEarfcn: " + GetVoiceEarfcn(strIn) + cr +
                     "VoiceBands: " + GetVoiceBands(strIn) + cr +
                     "VoiceBandwidth: " + GetVoiceBandwidth(strIn) + cr +
                     "VoiceMcc: " + GetVoiceMcc(strIn) + cr +
                     "VoiceMnc: " + GetVoiceMnc(strIn) + cr +
                     "VoiceAlphaLong: " + GetVoiceAlphaLong(strIn) + cr +
                     "VoiceAlphaShort: " + GetVoiceAlphaShort(strIn) + cr +
                     "VoiceAdditionalPlmns: " + GetVoiceAdditionalPlmns(strIn) + cr +
                     "VoiceCsgInfo: " + GetVoiceCsgInfo(strIn) + cr +
                     "VoiceSpecificInfo: " + GetVoiceVoiceSpecificInfo(strIn) + cr +

                #endregion

                #region Array[3][4]

                     "Array[3][4]" + cr +
                     "MaxDataCalls: " + GetMaxDataCalls(strIn) + cr +
                     "isDcNrRestricted: " + GetisDcNrRestricted(strIn) + cr +
                     "isNrAvailable: " + GetisNrAvailable(strIn) + cr +
                     "isEnDcAvailable: " + GetisEnDcAvailable(strIn) + cr +
                     "VopsSupport: " + GetVopsSupport(strIn) + cr +
                     "EmcBearerSupport: " + GetEmcBearerSupport(strIn) + cr +
                     "IsUsingCarrierAggregation: " + GetSpcIsUsingCarrierAggregation(strIn) + cr +
                     "NrState: " + GetSpcNrState(strIn) + cr +
                     "Rplmn: " + GetRplmn(strIn) + cr +
                     "NrFrequencyRange: " + GetNrFrequencyRange(strIn) + cr +
                     "OperatorAlphaLongRaw: " + GetOperatorAlphaLongRaw(strIn) + cr +
                     "IsDataRoamingFromRegistration: " + GetIsDataRoamingFromRegistration(strIn) + cr +
                     "IsIwlanPreferred: " + GetIsIwlanPreferred(strIn);

            #endregion

            return strOut;
        }

        public string CreateSignalStrength(string inSrt)
        {
            string strOut = "";



            return strOut;
        } 
        #endregion
    }
}
