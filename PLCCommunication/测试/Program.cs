using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLCCommunication
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //NameToData.DoubleAddrRead("PD1289");
            NameToAddress.AddAddress("GCodeFilePath", "A31100");
            NameToData.StringAddrRead("GCodeFilePath", 255);
        }
    }
}
