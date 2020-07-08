using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CndexLinkDotNet;

namespace 测试
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct TargetConnection
        {
            public CndexLinkDotNet.Cndex Server;
            public short Session;
            public short ThreadNum;
        }
        TargetConnection m_TC = new TargetConnection();
        TargetConnection m_DiagnTC;
        Int32 ErrClass;
        Int32 ErrNum;
        Int16 Process;
        short Phase = 0;
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

            Cndex.AXIS_TABLE AxisRecord;
            Cndex.TOOL_TABLE ToolRecord;
            Cndex.USER_TABLE UserRecord;
            Cndex.OFFSET_TABLE OffsetRecord;

        private void button1_Click(object sender, EventArgs e)
        {
            m_TC = new TargetConnection();
            m_TC.Server = new Cndex();
            String ip_str = "http://192.168.0.2:8080/";
            if (m_TC.Server.OpenSession_C(ip_str, out m_TC.Session, out ErrClass, out ErrNum) == 0)
                MessageBox.Show("连接通信失败");
            if (m_TC.Server.BootPhaseEnquiry_C(m_TC.Session, out Phase, out ErrClass, out ErrNum) == 0)
                MessageBox.Show("初始化引导程序失败");
            #region "读写操作"
            double[] OutDou = new double[1] { 1.0 };
            double[] InDou = { 0,0};
            if (m_TC.Server.WriteVarDouble_C(m_TC.Session, CndexLinkDotNet.Cndex.MD_CODE, 0, 100, 1, OutDou, out ErrClass, out ErrNum) == 0)
                MessageBox.Show("写入double有误");
            if (m_TC.Server.ReadVarDouble_C(m_TC.Session, CndexLinkDotNet.Cndex.MD_CODE, 0, 100, 3, InDou, out ErrClass, out ErrNum) == 0)
                MessageBox.Show("读取double有误");
            for(int i=0;i<1;i++)
            {
                Console.WriteLine("写入{0}",OutDou[i].ToString());
                Console.WriteLine("读取{0},长度{1}",InDou[i].ToString(),InDou.Length);
            }
            String text = "hell World";
            if (m_TC.Server.WriteVarText_C(m_TC.Session,
                                              CndexLinkDotNet.Cndex.SC_CODE,
                                              1,
                                              11,
                                             (short)text.Length,
                                              text,
                                              out ErrClass,
                                              out ErrNum) == 0)
               MessageBox.Show("写入文本错误");
            String Intext="";
               if (m_TC.Server.ReadVarText_C(m_TC.Session, CndexLinkDotNet.Cndex.SC_CODE, 1,14,10, out Intext, out ErrClass, out ErrNum)> 0)
            Console.WriteLine("读取到的文本信息{0}", Intext);
             Int16[] InBuffer = { 0 };
            if (m_TC.Server.WriteVarWordBit_C(m_TC.Session, CndexLinkDotNet.Cndex.M_CODE, 0, 160, 0, 1, out ErrClass, out ErrNum) == 0)
               MessageBox.Show("写位失败");
            if (m_TC.Server.ReadVarWord_C(m_TC.Session, Cndex.M_CODE, 0, 160, 1, InBuffer, out ErrClass, out ErrNum) > 0)
               Console.WriteLine("读取位{0}", InBuffer[0]);
            #endregion
            #region "读写速度"
            //StringBuilder tm = new StringBuilder();
            //double[] readtext = new double[3];
            //double[] writeTetx = new double[3] { 1.0, 2.0, 3.0 };
            ////DateTime oldtime = DateTime.Now;
            ////    for (int i = 0; i < 100; i++)
            ////    {
            ////        //wriken 测试读取的速率 double 写入数据有问题
            ////         if (m_TC.Server.WriteVarDouble_C(m_TC.Session, CndexLinkDotNet.Cndex.MD_CODE, 0, 100, 1, writeTetx, out ErrClass, out ErrNum) == 0)
            ////            MessageBox.Show("写入double有误");
            ////        if (m_TC.Server.ReadVarDouble_C(m_TC.Session, CndexLinkDotNet.Cndex.MD_CODE, 0, 100, 3, readtext, out ErrClass, out ErrNum) == 0)
            ////            MessageBox.Show("读取double有误");
            ////    }
            ////    DateTime newtime = DateTime.Now;
            ////    long testtime = (long)(newtime.Ticks - oldtime.Ticks);
            ////TimeSpan ts = new TimeSpan(testtime);
            ////Console.WriteLine("double的读写的速度{0}秒", ts.TotalSeconds);
            ////DateTime oldtime = DateTime.Now;
            //DateTime oldtime = DateTime.Now;
            //for (int i = 0; i < 100; i++)
            //{
            //    if (m_TC.Server.WriteVarWordBit_C(m_TC.Session, CndexLinkDotNet.Cndex.M_CODE, 0, 150, 0, 1, out ErrClass, out ErrNum) == 0)
            //        MessageBox.Show("写位失败");
            //    if (m_TC.Server.ReadVarWord_C(m_TC.Session, Cndex.M_CODE, 0, 150, 1, InBuffer, out ErrClass, out ErrNum) == 0)
            //        MessageBox.Show("读取失败");
            //}
            //DateTime newtime = DateTime.Now;
            //long testtime = (long)(newtime.Ticks - oldtime.Ticks);
            //TimeSpan ts = new TimeSpan(testtime);
            //Console.WriteLine("double的读写的速度{0}秒", ts.TotalSeconds);

            //DateTime oldtime = DateTime.Now;
            //for (int i = 0; i < 100; i++)
            //{
            //    if (m_TC.Server.WriteVarText_C(m_TC.Session,
            //                                   CndexLinkDotNet.Cndex.SC_CODE,
            //                                   1,
            //                                   11,
            //                                  (short)text.Length,
            //                                   text,
            //                                   out ErrClass,
            //                                   out ErrNum) == 0)
            //        MessageBox.Show("写入文本错误");
            //    if (m_TC.Server.ReadVarText_C(m_TC.Session, CndexLinkDotNet.Cndex.SC_CODE, 1, 14, 10, out Intext, out ErrClass, out ErrNum) == 0)
            //        MessageBox.Show("读取文本错误");
            //}
            //DateTime newtime = DateTime.Now;
            //long testtime = (long)(newtime.Ticks - oldtime.Ticks);
            //TimeSpan ts = new TimeSpan(testtime);
            //Console.WriteLine("double的读写的速度{0}秒", ts.TotalSeconds);
            #endregion
            #region "文件操作"
            //if (m_TC.Server.LogFSTransferFileW_C(null, "C:\\Users\\ykweng\\Desktop\\1.txt", "IP.192.168.0.2", "PROGRAMS\\OPEN20_QVIDEO\\Bitmap\\1.txt", out ErrClass, out ErrNum) > 0)
            //    MessageBox.Show("文件传输成功");
          //  Cndex.SECURITY_LEVEL_C Level = 0;
            //if (m_TC.Server.LogFSGetSecurityLevel_C(m_TC.Session, out Level, out ErrClass, out ErrNum) == 0)
            //MessageBox.Show("获取文件加密级别失效");
            //Int16 FileNames;
            //if(m_TC.Server.LogFSLongFileNames_C(m_TC.Session,out FileNames,out ErrClass,out ErrNum)==0)
            //    MessageBox.Show("获取文件名失效");
            //Int16 HideDriver = 0;
            //Int16 UserDriver = 0;
            //if(m_TC.Server.LogFSGetNumDrive_C(m_TC.Session,out HideDriver,out UserDriver,out ErrClass,out ErrNum)==0)
            //    MessageBox.Show("获取驱动器个数失效");
            //Console.WriteLine("获取隐藏驱动器{0}使用的驱动器{1}", HideDriver,UserDriver);
          //  string DriveName = "PROGRAMS";
           // string DriveParh = string.Empty;
            //if (m_TC.Server.LogFSGetDrivePath_C(m_TC.Session,DriveName,out DriveParh,))
            #endregion
            #region "其他工具"
            short RecordNum = 1;
            //读取系统表信息
            //if (m_TC.Server.GetAxisTabRecord_C(m_TC.Session, 1, out AxisRecord, out ErrClass, out ErrNum) == 0)
            //    //     Console.WriteLine("读取轴表中的记录{0}", AxisRecord);
            //    MessageBox.Show("错误类" + ErrClass.ToString() + "错误码" + ErrNum.ToString());

            //if (m_TC.Server.GetToolTabRecord_C(m_TC.Session, RecordNum, out ToolRecord, out ErrClass, out ErrNum) == 0)
            //    //Console.WriteLine("读取工具表中的记录{0}",ToolRecord);
            //    MessageBox.Show("错误类" + ErrClass.ToString() + "错误码" + ErrNum.ToString());

            //if (m_TC.Server.GetOffsetTabRecord_C(m_TC.Session, RecordNum, out OffsetRecord, out ErrClass, out ErrNum)== 0)
            //    MessageBox.Show("错误类" + ErrClass.ToString() + "错误码" + ErrNum.ToString());
            //if (m_TC.Server.GetUserTabRecord_C(m_TC.Session, RecordNum, out UserRecord, out ErrClass, out ErrNum) == 0)
            //    MessageBox.Show("错误类" + ErrClass.ToString() + "错误码" + ErrNum.ToString());
            //if ( m_TC.Server.SetAxisTabRecord_C(m_TC.Session, RecordNum, ref AxisRecord, out ErrClass, out ErrNum)>0)
            //        Console.WriteLine("读取轴表中的记录{0}", AxisRecord);
            //if(m_TC.Server.SetToolTabRecord_C(m_TC.Session, RecordNum, ref ToolRecord, out ErrClass, out ErrNum)>0)
            //    Console.WriteLine("读取工具表中的记录{0}",ToolRecord);
            //m_TC.Server.SetOffsetTabRecord_C(m_TC.Session, RecordNum, ref OffsetRecord, out ErrClass, out ErrNum);

            //m_TC.Server.SetUserTabRecord_C(m_TC.Session, RecordNum, ref UserRecord, out ErrClass, out ErrNum);


            #endregion
        }
    }
}
