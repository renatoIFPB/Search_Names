using Search_Names.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_Names
{
    public partial class Frm_Favorite : Form
    {
        public Frm_Favorite()
        {
            InitializeComponent();
            Set_names_forms();
        }

        public void Set_names_forms()
        {
            Lbl_Name_Res.Text = "Name";
            Lbl_Origin_Res.Text = "Origin";
            Lbl_Meaning_Res.Text = "Meaning";
            Lbl_Link.Text = "Link";
            Btn_Finish.Text = "Finish";
            Btn_Delete.Text = "Delete";

            Lbl_Name_Res_Value.Text = "             ";
            TxtB_Meaning_Res_Value.Text = "";
            Lbl_Origin_Res_Value.Text = "                     ";
            Lnk_Link_Value.Text = "";

            var reader = new FileLocal();
            var list_origins = reader.ReadCsv("..\\..\\..\\data\\favorites.txt");

            foreach (var i in list_origins)
                Lst_Names.Items.Add(i.name);

        }

        private void Btn_Finish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
