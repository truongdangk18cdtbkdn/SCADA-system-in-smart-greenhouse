using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPCAutomation; // Thư viện OPC

namespace Mitsu_SCADA_WINFORM_v6
{
    public partial class CSDL : Form
    {
        public CSDL()
        {
            InitializeComponent();
        }

        // Form load

        private void CSDL_Load(object sender, EventArgs e)
        {
            KEPServerEX_Connect();
            tbxDBName.Text = Properties.Settings.Default.SQL_DBName; //Load tên DB
        }
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
        string sqlTemperature;
        string sqlMoisture;
        string sqlTDS;
        private void dataScan(int ID, int NumItems, ref Array tagID,
            ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            for (int i = 1; i <= NumItems; i++)
            {
                // Khai báo biến chung
                int getTagID = Convert.ToInt32(tagID.GetValue(i));
                string tagValue = ItemValues.GetValue(i).ToString();
                Console.WriteLine(tagID.Length);
                //if...
                // Textbox show data
                if (getTagID == 30)
                {
                    sqlTemperature = tagValue; // Save SQL
                    textBox1.Text = tagValue;
                }
                if (getTagID == 31)
                {
                    sqlMoisture = tagValue; // Save SQL
                    textBox2.Text = tagValue;
                }
                if (getTagID == 44)
                {
                    sqlTDS = tagValue; // Save SQL
                    textBox3.Text = tagValue;
                }
                if (getTagID == 43)
                {
                    
                    if (tagValue == "True"
                        && sqlTemperature!=null
                        && sqlMoisture != null
                        && sqlTDS != null
                        )
                    {
                        // Khai báo giá trị
                        string sqltable_name = "parameter_data";
                        string collum1 = "date_time";
                        string collum2 = "temperature";
                        string collum3 = "moisture";
                        string collum4 = "total_dissolved_solids_TDS";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = sqlTemperature;
                        string data3 = sqlMoisture;
                        string data4 = sqlTDS;
                        // Hàm Ghi dữ liệu
                        classDatabase.cmd_SQLWrite(sqltable_name,
                               collum1, data1,
                               collum2, data2,
                               collum3, data3,
                               collum4, data4);
                    }
                }
            }

        }
        //==========================GHI DỮ LIỆU TAG=====================
        // Nút nhấn Edit SQL Database Name     
        private void btnEditDataName_Click(object sender, EventArgs e)
        {
            tbxDBName.Enabled = true;
            btnSaveDataName.Enabled = true;
        }
        // Nút nhấn Lưu SQL
        private void btnSaveDataName_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SQL_DBName = tbxDBName.Text;//Tên Database    
            Properties.Settings.Default.Save(); // Lưu vào Setting
            tbxDBName.Enabled = false; // Disable text field
            // Hiện thông báo
            MessageBox.Show("Sửa thành công, Khởi động lại phần mềm để cập nhật!");
        }
        // Nút nhấn hiển thị dữ liệu bảng lên Datagridview
        private void btnShowData_Click(object sender, EventArgs e)
        {
            WriteItems.SetValue(1, 45);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            WriteItems.SetValue(0, 45);
            string sqlSelect = "SELECT * FROM parameter_data;";
            classDatabase.sqlDisplay(sqlSelect, dataGridView1);
            // Đặt tên cho các cột datagridview
            dataGridView1.Columns[0].HeaderText = "Ngày Tháng";
            dataGridView1.Columns[1].HeaderText = "Nhiệt độ";
            dataGridView1.Columns[2].HeaderText = "Độ ẩm";
            dataGridView1.Columns[3].HeaderText = "TDS";
        }


    }
}
