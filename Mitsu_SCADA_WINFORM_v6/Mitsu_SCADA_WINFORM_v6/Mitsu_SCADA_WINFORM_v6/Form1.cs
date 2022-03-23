using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPCAutomation;

namespace Mitsu_SCADA_WINFORM_v6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fnLogin.Not_Login(); // Gọi chương trình con login
            KEPServerEX_Connect();
        }
        //==========================WATCHDOG================================
        string Watchdog_value = "0"; // đọc lên tag Watchdog
        private void timerWatchdog_Tick(object sender, EventArgs e)
        {
            class_Watchdog.WatchdogStatus(btnConnect, Watchdog_value);
        }
        //==========================CHƯƠNG TRÌNH CON CLASS==================
        classStatusDisplay statusDisplay = new classStatusDisplay();
        class_Login fnLogin = new class_Login();
        //==========================KEPServerEX CONNECT=====================
        static int tagNumber = 42;      // Cài đặt số lượng tag của project
        static int PLCscantime = 500;  // Cài đặt thời gian quét PLC
        // Gọi các kết nối OPC
        public OPCAutomation.OPCServer AnOPCServer;
        public OPCAutomation.OPCServer OPCServer;
        public OPCAutomation.OPCGroups OPCGroup;
        public OPCAutomation.OPCGroup PLC;
        public string Groupname;

        static int arrlength = tagNumber + 1;
        Array OPtags = KEPServerEX.tagread(arrlength);
        Array tagID = KEPServerEX.tagID(arrlength);
        Array WriteItems = Array.CreateInstance(typeof(object), arrlength);
        Array tagHandles = Array.CreateInstance(typeof(Int32), arrlength);
        Array OPCError = Array.CreateInstance(typeof(Int32), arrlength);
        Array dataType = Array.CreateInstance(typeof(Int16), arrlength);
        Array AccessPaths = Array.CreateInstance(typeof(string), arrlength);

        private void KEPServerEX_Connect()
        {
            string IOServer = "Kepware.KEPServerEX.V6";
            string IOGroup = "OPCGroup1";
            OPCServer = new OPCAutomation.OPCServer();
            OPCServer.Connect(IOServer, "");
            PLC = OPCServer.OPCGroups.Add(IOGroup);
            PLC.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(dataScan);
            PLC.UpdateRate = PLCscantime;
            PLC.IsSubscribed = PLC.IsActive;
            PLC.OPCItems.DefaultIsActive = true;
            PLC.OPCItems.AddItems(tagNumber, ref OPtags, ref tagID,
                out tagHandles, out OPCError, dataType, AccessPaths);
        }
        //==========================ĐỌC DỮ LIỆU TAG========================
        private void dataScan(int ID, int NumItems, ref Array tagID,
            ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            for (int i = 1; i <= NumItems; i++)
            {
                // Khai báo biến chung
                int getTagID = Convert.ToInt32(tagID.GetValue(i));
                string tagValue = ItemValues.GetValue(i).ToString();  
                if(getTagID == 42)
                {
                    Watchdog_value = tagValue;
                }

            }

        }
        //=================================================================
        private void btnGreenhouse1_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            Greenhouse1 gr1 = new Greenhouse1();
            gr1.TopLevel = false;
            mainPanel.Controls.Add(gr1);
            gr1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gr1.Dock = DockStyle.Fill;
            gr1.Show();
        }
        private void btnGreenhouse2_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            Greenhouse2 gr2 = new Greenhouse2();
            gr2.TopLevel = false;
            mainPanel.Controls.Add(gr2);
            gr2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gr2.Dock = DockStyle.Fill;
            gr2.Show();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            BackColor = Color.Red;
        }

        private void btnLoginLogout_Click(object sender, EventArgs e)
        {
            form_Login loginForm = new form_Login();
            loginForm.Show();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            OPCServer.Disconnect();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            KEPServerEX_Connect();
        }

    }
}
