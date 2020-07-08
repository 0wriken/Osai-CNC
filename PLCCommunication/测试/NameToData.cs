using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CndexLinkDotNet;
namespace PLCCommunication
{
    public static class NameToData
    {

        struct TargetConnection
        {
            public CndexLinkDotNet.Cndex Server;
            public short Session;
            public short ThreadNum;
        };
        private static TargetConnection m_TC = new TargetConnection();
        private static Int32 ErrClass;
        private static Int32 ErrNum;
        private static Int16 Process;
        private static bool OpenFlag = false;
        private static short Phase = 0; private static TargetConnection m_DiagnTC;
        enum PROGR_STATE
        {
            STAND_BY = 0,
            START,
            TEST_VARIABLES,
            TEST_AXES,
            WAIT_CYCLE_OFF1,
            AXES_GO_BACK,
            WAIT_CYCLE_OFF2,
            TEST_NCINFO,
            TEST_END,
            ERROR
        };
        public static int OpenOsaiCom()
        {
            m_TC = new TargetConnection();
            m_TC.Server = new Cndex();
            String ip_str = "http://192.168.0.2:8080/";
            if (m_TC.Server.OpenSession_C(ip_str, out m_TC.Session, out ErrClass, out ErrNum) == 0)
                return 0;
            return 0;
            if (m_TC.Server.BootPhaseEnquiry_C(m_TC.Session, out Phase, out ErrClass, out ErrNum) == 0)
                return 0;
            OpenFlag = true;
            return 1;
        }
        /// <summary>
        /// 函数作用：读取Double类型数据 
        /// 函数返回值:正确时候返回数值 错误码888  
        /// </summary>
        /// <param name="mkey"></param>
        /// <param name="isAddress"></param>
        /// <returns></returns>
        public static int DoubleAddrRead(string mkey, Boolean isAddress = false)
        {
            double[] InDou = new double[1];
            string[] AddrCode;
            if (OpenFlag)
            {
                if (isAddress)
                {
                    AddrCode = System.Text.RegularExpressions.Regex.Split(mkey, @"(\d+)");
                }
                else
                {
                    string AddrStr = NameToAddress.AddressDictRead(mkey);
                    if (AddrStr != null)
                        AddrCode = System.Text.RegularExpressions.Regex.Split(AddrStr, @"(\d+)");
                    else
                        return 888;
                }
                short CODE = 0;
                short Addrindex = 0;
                if (AddrCode.Length == 0)
                    return 888;
                GetDoubleCode(AddrCode, ref CODE, ref Addrindex);
                if (m_TC.Server.ReadVarDouble_C(m_TC.Session, CODE, 0, Addrindex, 1, InDou, out ErrClass, out ErrNum) != 0)
                {
                    return Convert.ToInt32(InDou[0]);
                }
                else
                    return 888;
            }
            return 999;
        }


        private static void GetDoubleCode(string[] AddrCode, ref short CODE, ref short index)
        {
            switch (AddrCode[0])
            {
                case "MD":
                    CODE = CndexLinkDotNet.Cndex.MD_CODE;
                    break;
                case "GD":
                    CODE = CndexLinkDotNet.Cndex.GD_CODE;
                    break;
                case "PD":
                    CODE = CndexLinkDotNet.Cndex.PD_CODE;
                    break;
                case "UD":
                    CODE = CndexLinkDotNet.Cndex.UD_CODE;
                    break;
                case "SN":
                    CODE = CndexLinkDotNet.Cndex.SN_CODE;
                    break;
                case "H":
                    CODE = CndexLinkDotNet.Cndex.H_CODE;
                    break;
                case "SYMO_D":
                    CODE = CndexLinkDotNet.Cndex.SYMO_D_CODE;
                    break;
                case "SYMORET_D":
                    CODE = CndexLinkDotNet.Cndex.SYMORET_D_CODE;
                    break;
            }
           index = Convert.ToInt16(AddrCode[1]);
        }
        private static void GetSingleCode(string[] AddrCode, ref short CODE, ref short index)
        {
            switch (AddrCode[0])
            {
                case "MD":
                    CODE = CndexLinkDotNet.Cndex.MD_CODE;
                    break;
                case "GD":
                    CODE = CndexLinkDotNet.Cndex.GD_CODE;
                    break;
                case "SD":
                    CODE = CndexLinkDotNet.Cndex.SD_CODE;
                    break;
                case "PD":
                    CODE = CndexLinkDotNet.Cndex.PD_CODE;
                    break;
                case "UD":
                    CODE = CndexLinkDotNet.Cndex.UD_CODE;
                    break;
                case "L":
                    CODE = CndexLinkDotNet.Cndex.L_CODE;
                    break;
                case "E":
                    CODE = CndexLinkDotNet.Cndex.E_CODE;
                    break;
                case "SN":
                    CODE = CndexLinkDotNet.Cndex.SN_CODE;
                    break;
                case "SYMO_D":
                    CODE = CndexLinkDotNet.Cndex.SYMO_D_CODE;
                    break;
                case "SYMORET_D":
                    CODE = CndexLinkDotNet.Cndex.SYMORET_D_CODE;
                    break;
                case "H":
                    CODE = CndexLinkDotNet.Cndex.H_CODE;
                    break;
            }
           index = Convert.ToInt16(AddrCode[1]);
        }
        private static void GetTextCode(string[] AddrCode, ref short CODE, ref short index)
        {
            switch (AddrCode[0])
            {
                case "A":
                    CODE = CndexLinkDotNet.Cndex.A_CODE;
                    break;
                case "AA":
                    CODE = CndexLinkDotNet.Cndex.AA_CODE;
                    break;
                case "SC":
                    CODE = CndexLinkDotNet.Cndex.SC_CODE;
                    break;
                case "SYMO_A":
                    CODE = CndexLinkDotNet.Cndex.SYMO_A_CODE;
                    break;
                case "LS":
                    CODE = CndexLinkDotNet.Cndex.LS_CODE;
                    break;
            }
            index = Convert.ToInt16(AddrCode[1]);
        }




        /// <summary>
        /// 函数作用：从地址读取单字数据
        /// 函数返回值:错误码 888 读取失败  999 通讯接口失效
        /// </summary>
        /// <param name="mkey"></param>
        /// <param name="isAddress"></param>
        /// <returns></returns>

        public static UInt16 SingleAddrRead(String mkey, Boolean isAddress = false)
        {
            Int16[] InBuffer = { 0 };
            string[] AddrCode;
            if (OpenFlag)
            {
                if (isAddress)
                {
                    AddrCode = System.Text.RegularExpressions.Regex.Split(mkey, @"(\d+)");
                }
                else
                {
                    string AddrStr = NameToAddress.AddressDictRead(mkey);
                    if (AddrStr != null)
                        AddrCode = System.Text.RegularExpressions.Regex.Split(AddrStr, @"(\d+)");
                    else
                        return 888;
                }
                short CODE = 0;
                short Addrindex = 0;
                if (AddrCode.Length == 0)
                    return 888;
                GetSingleCode(AddrCode, ref CODE, ref Addrindex);

                if (m_TC.Server.ReadVarWord_C(m_TC.Session, CODE, 0, Addrindex, 1, InBuffer, out ErrClass, out ErrNum) > 0)
                    return Convert.ToUInt16(InBuffer[0]);
                else
                    return 888;
            }
            else
                return 999;
        }
        /// <summary>
        /// 函数作用;读取某一位数据
        ///函数返回值:当改位为1时 返回 true 为 0或者错误返回0
        /// </summary>
        /// <param name="mkey"></param>
        /// <param name="bit"></param>
        /// <param name="isAddress"></param>
        /// <returns></returns>
        public static bool SingleAddrReadBit(String mkey, int bit, Boolean isAddress = false)
        {
            UInt16 num = 0;
            num = SingleAddrRead(mkey, isAddress);
            if (num == 888 || num == 999)
                return false;
            if (num == 0)
                return false;
            else
            {
                if (Convert.ToUInt16((num >> bit) & 1) == 1)
                {
                    return true;
                }
                else
                    return false;
            }
            return false;

        }
        /// <summary>
        /// 函数作用:读取Float数据 ，没有对应类型的api使用Double
        /// </summary>
        /// <param name="mkey"></param>
        /// <param name="isAddress"></param>
        /// <returns></returns>
        public static Int16 ReadAddressFloat(String mkey, Boolean isAddress = false)
        {
            return Convert.ToInt16(DoubleAddrRead(mkey, isAddress));
        }
        /// <summary>
        /// 函数作用:读取地址下的字符串数据
        ///函数返回值:
        /// </summary>
        public static string StringAddrRead(string mkey, int length, Boolean isAddress = false)
        {
            string[] AddrCode ;
            string Intext;
            short Length = Convert.ToInt16(length);
            if (!OpenFlag)
            {
                if (isAddress)
                {
                    AddrCode = System.Text.RegularExpressions.Regex.Split(mkey, @"(\d+)");
                }
                else
                {
                    string AddrStr = NameToAddress.AddressDictRead(mkey);
                    if (AddrStr != null)
                        AddrCode = System.Text.RegularExpressions.Regex.Split(AddrStr, @"(\d+)");
                    else
                        return null;
                }
                short CODE = 0;
                short Addrindex = 0;
                if (AddrCode.Length == 0)
                    return null;
                GetTextCode(AddrCode, ref CODE, ref Addrindex);

                if (m_TC.Server.ReadVarText_C(m_TC.Session,CODE , 1, Addrindex, Length, out Intext, out ErrClass, out ErrNum) > 0)
                    return Intext;
                else
                    return null;
        }
            return null;
        }
    }
}
