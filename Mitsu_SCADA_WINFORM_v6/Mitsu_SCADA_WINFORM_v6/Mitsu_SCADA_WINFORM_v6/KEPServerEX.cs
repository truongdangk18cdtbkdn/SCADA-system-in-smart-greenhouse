using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitsu_SCADA_WINFORM_v6
{
    class KEPServerEX
    {
        public static string[] tagread(int tagnumber)
        {   //-------------Control---------------//
            string tagID_1 = "Channel1.Device1.btnStart";
            string tagID_2 = "Channel1.Device1.btnStop";
            string tagID_3 = "Channel1.Device1.btnWindowOpen";
            string tagID_4 = "Channel1.Device1.btnWindowClose";
            string tagID_5 = "Channel1.Device1.btnDoorOpen";
            string tagID_6 = "Channel1.Device1.btnDoorClose";
            string tagID_7 = "Channel1.Device1.btnUpdateParameters";
            string tagID_8 = "Channel1.Device1.btnDripPumpOpen";
            string tagID_9 = "Channel1.Device1.btnDripPumpClose";
            string tagID_10 = "Channel1.Device1.btnValve1Open";
            string tagID_11 = "Channel1.Device1.btnValve1Close";
            string tagID_12 = "Channel1.Device1.btnValve2Open";
            string tagID_13 = "Channel1.Device1.btnValve2Close";
            string tagID_14 = "Channel1.Device1.btnVentilationOpen";
            string tagID_15 = "Channel1.Device1.btnVentilationClose";
            string tagID_16 = "Channel1.Device1.btnCoolingFanOpen";
            string tagID_17 = "Channel1.Device1.btnCoolingFanClose";
            string tagID_18 = "Channel1.Device1.btnHeaterOpen";
            string tagID_19 = "Channel1.Device1.btnHeaterClose";
            string tagID_20 = "Channel1.Device1.btnLampOpen";
            string tagID_21 = "Channel1.Device1.btnLampClose";
            string tagID_22 = "Channel1.Device1.vFanOpenTime";
            string tagID_23 = "Channel1.Device1.vFanCloseTime";
            string tagID_24 = "Channel1.Device1.cFanOpenTime";
            string tagID_25 = "Channel1.Device1.cFanCloseTime";
            string tagID_26 = "Channel1.Device1.dripIterationTime";
            string tagID_27 = "Channel1.Device1.dripIrrigatedTime";
            string tagID_28 = "Channel1.Device1.setTemperature";
            string tagID_29 = "Channel1.Device1.setMoisture";
            string tagID_30 = "Channel1.Device1.actualTemperature";
            string tagID_31 = "Channel1.Device1.actualMoisture";
            //-------------State---------------//
            string tagID_32 = "Channel1.Device1.statusSystem";
            string tagID_33 = "Channel1.Device1.statusWindow";
            string tagID_34 = "Channel1.Device1.statusDoor";
            string tagID_35 = "Channel1.Device1.statusDripPump";
            string tagID_36 = "Channel1.Device1.statusValve1";
            string tagID_37 = "Channel1.Device1.statusValve2";
            string tagID_38 = "Channel1.Device1.statusVentilation";
            string tagID_39 = "Channel1.Device1.statusCoolingFan";
            string tagID_40 = "Channel1.Device1.statusHeater";
            string tagID_41 = "Channel1.Device1.statusLamp";
            string tagID_42 = "Channel1.Device1.Watchdog";

            string[] tags;
            tags = new string[tagnumber];
            tags.SetValue(tagID_1, 1);
            tags.SetValue(tagID_2, 2);
            tags.SetValue(tagID_3, 3);
            tags.SetValue(tagID_4, 4);
            tags.SetValue(tagID_5, 5);
            tags.SetValue(tagID_6, 6);
            tags.SetValue(tagID_7, 7);
            tags.SetValue(tagID_8, 8);
            tags.SetValue(tagID_9, 9);
            tags.SetValue(tagID_10, 10);
            tags.SetValue(tagID_11, 11);
            tags.SetValue(tagID_12, 12);
            tags.SetValue(tagID_13, 13);
            tags.SetValue(tagID_14, 14);
            tags.SetValue(tagID_15, 15);
            tags.SetValue(tagID_16, 16);
            tags.SetValue(tagID_17, 17);
            tags.SetValue(tagID_18, 18);
            tags.SetValue(tagID_19, 19);
            tags.SetValue(tagID_20, 20);
            tags.SetValue(tagID_21, 21);
            tags.SetValue(tagID_22, 22);
            tags.SetValue(tagID_23, 23);
            tags.SetValue(tagID_24, 24);
            tags.SetValue(tagID_25, 25);
            tags.SetValue(tagID_26, 26);
            tags.SetValue(tagID_27, 27);
            tags.SetValue(tagID_28, 28);
            tags.SetValue(tagID_29, 29);
            tags.SetValue(tagID_30, 30);
            tags.SetValue(tagID_31, 31);
            tags.SetValue(tagID_32, 32);
            tags.SetValue(tagID_33, 33);
            tags.SetValue(tagID_34, 34);
            tags.SetValue(tagID_35, 35);
            tags.SetValue(tagID_36, 36);
            tags.SetValue(tagID_37, 37);
            tags.SetValue(tagID_38, 38);
            tags.SetValue(tagID_39, 39);
            tags.SetValue(tagID_40, 40);
            tags.SetValue(tagID_41, 41);
            tags.SetValue(tagID_42, 42);
            return tags;
        }
        // Class tạo array đọc ID tags
        public static Int32[] tagID(int tagnumber)
        {
            Int32[] cltarr;
            cltarr = new Int32[tagnumber];
            for (int i = 1; i < tagnumber; i++)
            {
                cltarr.SetValue(i, i);
            }
            return cltarr;
        }
    }
}
