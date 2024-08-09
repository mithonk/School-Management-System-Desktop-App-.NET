using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System_Desktop_App_.NET.UI
{
    public partial class formDashboard : Form
    {
        public formDashboard()
        {
            InitializeComponent();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Student.formStudentMaster formStudentMaster = new UI.Student.formStudentMaster();
            formStudentMaster.MdiParent = this;
            formStudentMaster.Show();
        }

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Subject.formSubjectMaster formSubjectMaster = new UI.Subject.formSubjectMaster();
            formSubjectMaster.MdiParent = this;
            formSubjectMaster.Show();
        }

        private void gradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Grade.formGradeMaster formGradeMaster = new UI.Grade.formGradeMaster();
            formGradeMaster.MdiParent = this;
            formGradeMaster.Show();
        }
    }
}
