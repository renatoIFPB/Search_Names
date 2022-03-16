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
    public partial class Frm_Menu : Form
    {
        List<Name> males;
        List<Name> females;
        public Frm_Menu()
        {
            InitializeComponent();
            Set_names_forms();
            Initialize_lists_names();
        }

        public void Set_list_males()
        {
            Lst_Names.Items.Clear();
            foreach (var name in males)
            {
                Lst_Names.Items.Add(name.name);
            }
        }

        public void Set_list_female()
        {
            Lst_Names.Items.Clear();
            foreach (var name in females)
            {
                Lst_Names.Items.Add(name.name);
            }
        }

        private Name Get_obj_name(List<Name> list)
        {
            var index = Lst_Names.SelectedIndex;
            if (index >= 0 && Lst_Names.CanSelect)
                return list[index];
            return null;
        }

        private void Show_info_name(Name name)
        {
            if (name == null)
                return;

            Lbl_Name_Res_Value.Text = name.name;
            Lbl_Origin_Res_Value.Text = name.origin;
            Lbl_Meaning_Res_Value.Text = name.meaning;
            Lnk_Link_Value.Text = name.link;
        }

        public void Initialize_lists_names()
        {
            var reader = new FileLocal();
            males = reader.ReadAndSaveToClass(@"..\\..\\..\\data\\m.csv");
            females = reader.ReadAndSaveToClass(@"..\\..\\..\\data\\f.csv");
        }

        private void Check_radio_and_list_names()
        {
            if (RdB_Male.Checked == true)
                Set_list_males();
            else if (RdB_Female.Checked == true)
                Set_list_female();
            else
                Console.WriteLine("Preencher o campo genero");
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Check_radio_and_list_names();
        }

        private void Lst_Names_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RdB_Female.Checked)
                Show_info_name(Get_obj_name(females));
            else
                Show_info_name(Get_obj_name(males));
        }

        public void Set_names_forms()
        {
            Btn_Favorite.Text = "Favorite";
            RdB_Female.Text = "Female";
            RdB_Male.Text = "Male";
            GprB_Search.Text = "Search";
            GrpB_Genus.Text = "Genus";
            Btn_Search.Text = "Search";
            Lbl_Name.Text = "Name";
            Lbl_Meaning.Text = "Meaning";
            Lbl_Origin.Text = "Origin";
            Lbl_Name_Res.Text = "Name";
            Lbl_Origin_Res.Text = "Origin";
            Lbl_Meaning_Res.Text = "Meaning";
            Lbl_Link.Text = "Link";

            Txtb_Name.Text = "";
            TxtB_Meaning.Text = "";
            Lbl_Name_Res_Value.Text = "             ";
            Lbl_Origin_Res_Value.Text = "";
            Lbl_Meaning_Res_Value.Text = "";
            Lnk_Link_Value.Text = "";

        }
    }
}
