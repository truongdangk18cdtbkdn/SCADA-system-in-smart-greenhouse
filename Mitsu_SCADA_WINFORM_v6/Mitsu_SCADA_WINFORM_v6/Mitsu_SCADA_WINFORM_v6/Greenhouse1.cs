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
    public partial class Greenhouse1 : Form
    {
        internal static Greenhouse1 formMain;
        public Greenhouse1()
        {
            InitializeComponent();
            formMain = this; // Tạo reference form main
        }

        private void Greenhouse1_Load(object sender, EventArgs e)
        {
            KEPServerEX_Connect();
        }
        
        //==========================CHƯƠNG TRÌNH CON CLASS==================
        classStatusDisplay statusDisplay = new classStatusDisplay();
        class_Login fnLogin = new class_Login();
        //==========================KEPServerEX CONNECT=====================
        static int tagNumber = 45;      // Cài đặt số lượng tag của project
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
        // Chương trình con kết nối (Connect)
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
        //==========================ĐỌC DỮ LIỆU TAG=====================
        private void dataScan(int ID, int NumItems, ref Array tagID,
            ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            for (int i = 1; i <= NumItems; i++)
            {
                // Khai báo biến chung
                int getTagID = Convert.ToInt32(tagID.GetValue(i));
                string tagValue = ItemValues.GetValue(i).ToString();
                // Lấy giá trị tag
                // Đèn báo
                if (getTagID == 35 && getTagID == 36)
                {
                    statusDisplay.sttTwoStatus(symValve1, tagValue);
                    statusDisplay.sttTwoStatus(symPipe13, tagValue);
                    statusDisplay.sttTwoStatus(symPipe23, tagValue);
                    statusDisplay.sttTwoStatus(symPipe3, tagValue);
                    statusDisplay.sttTwoStatus(symOutPipe1, tagValue);
                    statusDisplay.sttTwoStatus(symOutPipe2, tagValue);
                    statusDisplay.sttTwoStatus(symOutPipe3, tagValue);
                    statusDisplay.sttTwoStatus(symOutPipe4, tagValue);
                    statusDisplay.sttTwoStatus(symOutPipe5, tagValue);
                    statusDisplay.sttTwoStatus(symOutPipe6, tagValue);
                    statusDisplay.sttTwoStatus(symVoi1, tagValue);
                    statusDisplay.sttTwoStatus(symVoi2, tagValue);
                    statusDisplay.sttTwoStatus(symVoi3, tagValue);
                    statusDisplay.sttTwoStatus(symVoi4, tagValue);
                }
                if (getTagID == 35)
                {
                    statusDisplay.sttTwoStatus(symDripPump, tagValue);
                    statusDisplay.sttTwoStatus(symOutPipe1, tagValue);
                    statusDisplay.sttTwoStatus(symOutPipe2, tagValue);
                    statusDisplay.sttTwoStatus(symOutPipe3, tagValue);
                    statusDisplay.sttTwoStatus(symOutPipe4, tagValue);
                    statusDisplay.sttTwoStatus(symOutPipe5, tagValue);
                    statusDisplay.sttTwoStatus(symOutPipe6, tagValue);
                    statusDisplay.sttTwoStatus(symVoi1, tagValue);
                    statusDisplay.sttTwoStatus(symVoi2, tagValue);
                    statusDisplay.sttTwoStatus(symVoi3, tagValue);
                    statusDisplay.sttTwoStatus(symVoi4, tagValue);
                }
                if (getTagID == 36)
                {
                    statusDisplay.sttTwoStatus(symValve1, tagValue);
                    statusDisplay.sttTwoStatus(symPipe13, tagValue);
                    statusDisplay.sttTwoStatus(symPipe23, tagValue);
                    statusDisplay.sttTwoStatus(symPipe3, tagValue);
                }
                if (getTagID == 37)
                {
                    statusDisplay.sttTwoStatus(symValve2, tagValue);
                    statusDisplay.sttTwoStatus(symPipe13, tagValue);
                    statusDisplay.sttTwoStatus(symPipe23, tagValue);
                    statusDisplay.sttTwoStatus(symPipe3, tagValue);
                }
                if (getTagID == 38)
                {
                    statusDisplay.sttTwoStatus(symVentilationFan1, tagValue);
                    statusDisplay.sttTwoStatus(symVentilationFan2, tagValue);
                    statusDisplay.sttTwoStatus(symVentilationFan3, tagValue);
                    statusDisplay.sttTwoStatus(symVentilationFan4, tagValue);
                }
                if (getTagID == 39)
                {
                    statusDisplay.sttTwoStatus(symCoolingFan1, tagValue);
                    statusDisplay.sttTwoStatus(symCoolingFan2, tagValue);
                    statusDisplay.sttTwoStatus(symCoolingFan3, tagValue);
                }
                if (getTagID == 40)
                {
                    statusDisplay.sttTwoStatus(symHeater, tagValue);
                }
                if (getTagID == 41)
                {
                    statusDisplay.sttTwoStatus(symLight1, tagValue);
                    statusDisplay.sttTwoStatus(symLight2, tagValue);
                }
                //label
                if (getTagID == 28)
                {
                    labSetTemperature.Text = tagValue;
                    tbxTemperature.Text = tagValue;
                }
                if (getTagID == 29)
                {
                    labSetMoisture.Text = tagValue;
                    tbxMoisture.Text = tagValue;
                }
                // textbox
 /*               if (getTagID == 30)
                {
                    tbxTemperature.Text = tagValue;
                }
                if (getTagID == 31)
                {
                    tbxMoisture.Text = tagValue;
                }*/
            }
        }
        //==============GHI DỮ LIỆU VÀO CÁC TAG===================
        
        //==========================TRUYỀN DỮ LIỆU POPUP WINDOW====================
        public void popup_button_Clicked(int tagID)
        {
            WriteItems.SetValue(1, tagID);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            WriteItems.SetValue(0, tagID);
        }

        public void symVentilationFan1_Click_1(object sender, EventArgs e)
        {

            formVentilationPopup frmpopup = new formVentilationPopup();
            frmpopup.tag_ONID = 14;   // ID tag Chạy ventilation Fan
            frmpopup.tag_OFFID = 15;  // ID tag Dung ventilation Fan
            frmpopup.Show();
            formVentilationPopup.formPopup.setTitle("Ventilation Control");
        }

        public void symDripPump_Click(object sender, EventArgs e)
        {
            formVentilationPopup frmpopup = new formVentilationPopup();
            frmpopup.tag_ONID = 8;   // ID tag Chạy
            frmpopup.tag_OFFID = 9;  // ID tag Dung
            frmpopup.Show();
            formVentilationPopup.formPopup.setTitle("Drip Pump Control");
        }

        private void tbxTemperature_TextChanged(object sender, EventArgs e)
        {

        }
        // Nút nhấn sửa Giá trị Cài đặt Nhiệt độ
        private void btnEditTemp_Click(object sender, EventArgs e)
        {
            tbxSetTemperature.Enabled = true;
            btnSaveTemp.Enabled = true;
        }

        private void btnSaveTemp_Click(object sender, EventArgs e)
        {
            WriteItems.SetValue(tbxSetTemperature.Text, 28);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            tbxSetTemperature.Enabled = false;
            btnSaveTemp.Enabled = false;
            MessageBox.Show("Đã cài đặt nhiệt độ của NHÀ KÍNH [1]");
        }

        private void btnEditMoisture_Click(object sender, EventArgs e)
        {
            tbxSetMoisture.Enabled = true;
            btnSaveMoisture.Enabled = true;
        }

        private void btnSaveMoisture_Click(object sender, EventArgs e)
        {
            WriteItems.SetValue(tbxSetMoisture.Text, 29);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            tbxSetMoisture.Enabled = false;
            btnSaveMoisture.Enabled = false;
            MessageBox.Show("Đã cài đặt độ ẩm đất của NHÀ KÍNH [1]");
        }

    }
}
