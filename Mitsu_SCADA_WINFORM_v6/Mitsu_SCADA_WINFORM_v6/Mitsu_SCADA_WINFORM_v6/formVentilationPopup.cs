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
    public partial class formVentilationPopup : Form
    {
        internal static formVentilationPopup formPopup;
        public formVentilationPopup()
        {
            InitializeComponent();
            formPopup = this;
        }

        private void formVentilationPopup_Load(object sender, EventArgs e)
        {

        }
        // Chương trình con hiển thị tittle
        public void setTitle(string title)
        {
            this.Text = title;
        }
        // Tạo 2 biến tag ID cho 2 nút nhấn on/off
        public int tag_ONID;
        public int tag_OFFID;

        private void btnVentilationOpen_Click(object sender, EventArgs e)
        {
            Greenhouse1.formMain.popup_button_Clicked(tag_ONID);
        }

        private void btnVentilationClose_Click(object sender, EventArgs e)
        {
            Greenhouse1.formMain.popup_button_Clicked(tag_OFFID);
        }
    }
}
