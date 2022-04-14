using Search_Names.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_Names
{
    public partial class Frm_Menu : Form
    {
        List<Name> males;
        List<Name> females;
        List<Name> actual;
        FileLocal fileLocal = new FileLocal();
        public Frm_Menu()
        {
            InitializeComponent();
            Set_names_forms();
            Initialize_lists_names(); 
            //SaveOrigins();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            //genero -> Nome -> origem -> significado
            actual = Check_radio_and_list_names();
            actual = Search_origin_in_names(CmbB_Origin.Text);
            actual = Search_meaning_in_names(TxtB_Meaning.Text);
            actual = Search_name_in_names(Txtb_Name.Text);
            Set_list_in_ListBox(actual);
        }

        private List<Name> Search_name_in_names(string s)
        {
            var list = new List<Name>();
            foreach (var i in actual)
            {
                if (i.name.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                    list.Add(i);
            }
            return list;
        }

        private List<Name> Search_meaning_in_names(string s)
        {
            var list = new List<Name>();
            foreach (var i in actual)
            {
                if (i.meaning.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                    list.Add(i);
            }
            return list;
        }

        public List<Name> Search_origin_in_names(string s)
        {
            var list = new List<Name>();
            foreach (var i in actual)
            {
                if (i.origin.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                    list.Add(i);
            }
            return list;
        }

        private bool Check_radio_genus()
        {
            if (RdB_Male.Checked == true)
                return true;
            return false;
        }

        private void SaveOrigins()
        {
            var save_origin = new GetOriginNames();
            save_origin.ConvertObjNameToFileTxt(males, females, "..\\..\\..\\data\\origins.txt");
        }

        public void Set_list_in_ListBox(List<Name> list)
        {
            Lst_Names.Items.Clear();
            foreach (var name in list)
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

        private void Lst_Names_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_info_name(Get_obj_name(actual));
        }

        private void Show_info_name(Name name)
        {
            if (name == null)
                return;

            Lbl_Name_Res_Value.Text = name.name;
            Lbl_Origin_Res_Value.Text = name.origin;
            TxtB_Meaning_Res_Value.Text = name.meaning;
            Lnk_Link_Value.Text = name.link;
        }

        public void Initialize_lists_names()
        {
            males = fileLocal.InicializateObjNames(@"..\\..\\..\\data\\m.csv");
            females = fileLocal.InicializateObjNames(@"..\\..\\..\\data\\f.csv");
        }

        private List<Name> Check_radio_and_list_names()
        {
            if (Check_radio_genus())
                return males;
            else
                return females;
        }

        public void Set_names_forms()
        {
            Btn_Favorite.Text = "Favorite";
            RdB_Female.Text = "Female";
            RdB_Male.Text = "Male";
            RdB_Male.Checked = true;
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
            TxtB_Meaning_Res_Value.Text = "";
            Lbl_Origin_Res_Value.Text = "                     ";
            Lnk_Link_Value.Text = "";

            var list_origins = fileLocal.CreateListByFileTxt("..\\..\\..\\data\\origins.txt");
            if (list_origins == null)
                return;

            foreach (var i in list_origins)
                CmbB_Origin.Items.Add(i);
        }
        private void favoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_favorites = new Frm_Favorite();
            frm_favorites.ShowDialog();
        }

        private void Btn_Favorite_Click(object sender, EventArgs e)
        {
            var list = new List<Name>();
            list.Add(Get_obj_name(actual));
            fileLocal.WriteCsv("..\\..\\..\\data\\favorites.txt", list);
            //diologbox informando que foi salvo
        }
    }
}
