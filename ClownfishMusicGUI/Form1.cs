using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClownfishMusicGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            panelMainSubmenu.Visible = false;
            panelSettingsSubmenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelMainSubmenu.Visible == true)
                panelMainSubmenu.Visible = false;
            if (panelSettingsSubmenu.Visible == true)
                panelSettingsSubmenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #region Main Menu
        private void mainButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMainSubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //..
            OpenChildForm(new Form2());
            //..
            HideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //Code
            //..
            HideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //Code
            //..
            HideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //Code
            //..
            HideSubMenu();
        }
        #endregion

        #region Settings
        private void button9_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSettingsSubmenu);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //Code
            //..
            HideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //Code
            //..
            HideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //Code
            //..
            HideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //Code
            //..
            HideSubMenu();
        }
        #endregion

        // <------------------------------- Other Button ------------------------------->
        private void otherButton_Click(object sender, EventArgs e)
        {
            //..
            //Code
            //..
            HideSubMenu();
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(childForm);
            containerPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
    }
}
