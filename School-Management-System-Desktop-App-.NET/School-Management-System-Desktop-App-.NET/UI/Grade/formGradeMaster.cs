using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System_Desktop_App_.NET.UI.Grade
{
    public partial class formGradeMaster : Form
    {
        Boolean is_addNew = false;
        public formGradeMaster()
        {
            InitializeComponent();
        }

        private void ButtonEnable(bool is_true)
        {
            is_addNew = is_true;
            btnAdd.Enabled = !is_true;
            btnEdit.Enabled = !is_true;
            btnDelete.Enabled = !is_true;
            btnRefresh.Enabled = !is_true;
            btnExit.Enabled = !is_true;

            btnSave.Enabled = is_true;
            btnCancel.Enabled = is_true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ButtonEnable(true);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            ButtonEnable(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (is_addNew)
            {
                //Insert Function
            } 
            else
            {
                //Update Function
            }
            ButtonEnable(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ButtonEnable(true);
            is_addNew = false ;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to Delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //Delete Function
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Select all function
        }

        private void formGradeMaster_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
