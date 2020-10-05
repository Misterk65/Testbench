using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testbench
{
    class CSignalStrength
    {
        //CDMA
        public int CdmaDbm { get; private set; }
        public int CdmaEcio { get; private set; }
        public int EvdoDbm { get; private set; }
        public int EvdoEcio { get; private set; }
        public int EvdoSnr { get; private set; }
        public int CdmaLevel { get; private set; }
        //GSM
        public int GsmRssi { get; private set; }
        public int GsmBer { get; private set; }
        public int GsmTa { get; private set; }
        public int GsmLevel { get; private set; }
        //WCDMA 
        public  int WcdmaSs { get; private set; }
        public  int WcdmaBer { get; private set; }
        public  int WcdmaRscp { get; private set; }
        public  int WcdmaEcno { get; private set; }
        public  int WcdmaLevel { get; private set; }
        //TDSCDMA 
        public int TdscdmaRssi { get; private set; }
        public int TdscdmaBer { get; private set; }
        public int TdscdmaRscp { get; private set; }
        public int TdscdmaLevel { get; private set; }
        //LTE
        public int LteRssi { get; private set; }
        public int LteRsrp { get; private set; }
        public int LteRsrq { get; private set; }
        public int LteRssnr { get; private set; }
        public int LteCqi { get; private set; }
        public int LteTa { get; private set; }
        public int LteLevel { get; private set; }
        //5GNR
        public int NrCsiRsrp { get; private set; }
        public int NrCsiRsrq { get; private set; }
        public int NrCsiSinr { get; private set; }
        public int NrSsRsrp { get; private set; }
        public int NrSsRsrq { get; private set; }
        public int NrSsSinr { get; private set; }
        public int NrLevel { get; private set; }


        //Methods private
        private string PrepareString(string strIn, string ident)
        {
            try
            {
                string strOut = string.Empty;
                string[] firstIteration = strIn.Split(',');

                //If CDMA or NR some more preparation is needed

                if (ident == "cdma")
                {
                    foreach (var item in PrepareCdma(firstIteration[0]).Split(' '))
                    {
                        string[] y = item.Split('=');
                        strOut = strOut + y[1] + ",";
                    }

                    strOut = strOut.Substring(0, strOut.Length - 1);

                    if (!strOut.ToLower().Contains("invalid"))
                    {
                        string[] x = strOut.Split(',');
                        CdmaDbm = Convert.ToInt32(x[0]);
                        CdmaEcio = Convert.ToInt32(x[1]);
                        EvdoDbm = Convert.ToInt32(x[2]);
                        EvdoEcio = Convert.ToInt32(x[3]);
                        EvdoSnr = Convert.ToInt32(x[4]);
                        CdmaLevel = Convert.ToInt32(x[5]);
                    }
                    else
                    {
                        CdmaDbm = 2147483647;
                        CdmaEcio = 2147483647;
                        EvdoDbm = 2147483647;
                        EvdoEcio = 2147483647;
                        EvdoSnr = 2147483647;
                        CdmaLevel = 2147483647;
                    }

                }
                else if (ident == "5gnr")
                {
                    if (!firstIteration[5].ToLower().Contains("invalid")) //Samsung
                    {
                        string[] y = Prepare5gnr(firstIteration[firstIteration.Length - 2]).Split(' ');
                        strOut = y[2] + "," + y[5] + "," + y[8] + "," + y[11] + "," + y[14] + "," + y[17] + "," + y[20];
                        NrCsiRsrp = Convert.ToInt32(y[2]);
                        NrCsiRsrq = Convert.ToInt32(y[5]);
                        NrCsiSinr = Convert.ToInt32(y[8]);
                        NrSsRsrp = Convert.ToInt32(y[11]);
                        NrSsRsrq = Convert.ToInt32(y[14]);
                        NrSsSinr = Convert.ToInt32(y[17]);
                        NrLevel = Convert.ToInt32(y[20]); 
                    }
                    else
                    {
                        NrCsiRsrp = 2147483647;
                        NrCsiRsrq = 2147483647;
                        NrCsiSinr = 2147483647;
                        NrSsRsrp = 2147483647;
                        NrSsRsrq = 2147483647;
                        NrSsSinr = 2147483647;
                        NrLevel = 0; 
                    }
                }
                else
                {
                    foreach (var element in firstIteration)
                    {
                        string process = element.TrimStart();
                        process = process.TrimEnd();

                        if (process.StartsWith(ident))
                        {
                            string[] x = element.Split(' ');

                            foreach (var item in x)
                            {
                                string[] y = item.Split('=');
                                strOut = strOut + y[1] + ",";
                            }

                            if (ident == "mGsm")
                            {

                                if (!strOut.ToLower().Contains("invalid"))
                                {
                                    string[] y = strOut.Split(',');
                                    GsmRssi = Convert.ToInt32(y[1]);
                                    GsmBer = Convert.ToInt32(y[2]);
                                    GsmTa = Convert.ToInt32(y[3]);
                                    GsmLevel = Convert.ToInt32(y[4]);
                                }
                                else
                                {
                                    GsmRssi = 2147483647;
                                    GsmBer = 2147483647;
                                    GsmTa = 2147483647;
                                    GsmLevel = 2147483647;
                                }
                            }
                            else if (ident == "mWcdma")
                            {
                                if (!strOut.ToLower().Contains("invalid"))
                                {
                                    string[] y = strOut.Split(',');
                                    WcdmaSs = Convert.ToInt32(y[1]);;
                                    WcdmaRscp = Convert.ToInt32(y[2]);;
                                    WcdmaBer = Convert.ToInt32(y[3]);;
                                    WcdmaEcno = Convert.ToInt32(y[4]);;
                                    WcdmaLevel = Convert.ToInt32(y[5]);;
                                }
                                else
                                {
                                    WcdmaSs = 2147483647;
                                    WcdmaRscp = 2147483647;
                                    WcdmaBer = 2147483647;
                                    WcdmaEcno = 2147483647;
                                    WcdmaLevel = 0;
                                }
                            }
                            else if (ident == "mTdscdma")
                            {
                                if (!strOut.ToLower().Contains("invalid"))
                                {
                                    string[] y = strOut.Split(',');
                                    TdscdmaRssi = Convert.ToInt32(y[1]);;
                                    TdscdmaBer = Convert.ToInt32(y[2]);;
                                    TdscdmaRscp = Convert.ToInt32(y[3]);;
                                    TdscdmaLevel = Convert.ToInt32(y[4]);;
                                }
                                else
                                {
                                    TdscdmaRssi = 2147483647;
                                    TdscdmaBer = 2147483647;
                                    TdscdmaRscp = 2147483647;
                                    TdscdmaLevel = 0;
                                }
                            }
                            else if (ident == "mLte")
                            {
                                if (!strOut.ToLower().Contains("invalid"))
                                {
                                    string[] y = strOut.Split(',');
                                    LteRssi = Convert.ToInt32(y[1]);
                                    LteRsrp = Convert.ToInt32(y[2]);
                                    LteRsrq = Convert.ToInt32(y[3]);
                                    LteRssnr = Convert.ToInt32(y[4]);
                                    LteCqi = Convert.ToInt32(y[5]);
                                    LteTa = Convert.ToInt32(y[6]);
                                    LteLevel = Convert.ToInt32(y[7]);
                                }
                                else
                                {
                                    LteRssi = 2147483647;
                                    LteRsrp = 2147483647;
                                    LteRsrq = 2147483647;
                                    LteRssnr = 2147483647;
                                    LteCqi = 2147483647;
                                    LteTa = 2147483647;
                                    LteLevel = 2147483647;
                                }
                            }
                        }
                    }
                }

                return strOut;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private string PrepareCdma(string strIn)
        {
            string[] process = strIn.Split(':');

            string strOut = process[process.Length - 1].TrimStart();

            return strOut;
        }

        private string Prepare5gnr(string strIn)
        {
            strIn = strIn.Substring(0, strIn.Length - 2);
            string[] process = strIn.Split('{');
            string strOut = process[process.Length - 1].TrimStart();

            return strOut;
        }

        //Methods public
        public void GetCellSignalStrengthCdma(string strIn)
        {
            PrepareString(strIn,"cdma");
            PrepareString(strIn,"mGsm");
            PrepareString(strIn,"mWcdma");
            PrepareString(strIn,"mTdscdma");
            PrepareString(strIn,"mLte");
            PrepareString(strIn,"5gnr");
        }
    }
}
