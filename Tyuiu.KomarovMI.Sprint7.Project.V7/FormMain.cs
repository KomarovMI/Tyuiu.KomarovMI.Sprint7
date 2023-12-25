using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Tyuiu.KomarovMI.Sprint7.Project.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_KMI.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            

        }

        private void buttonAboutme_KMI_Click(object sender, EventArgs e)
        {
            FormAboutme formAbout = new FormAboutme();
            formAbout.ShowDialog();
        }

       
        

        private void buttonRules_KMI_Click(object sender, EventArgs e)
        {
            FormRules formRules = new FormRules();
            formRules.ShowDialog();
        }

        private void buttonChooseFile_KMI_Click(object sender, EventArgs e)
        {
            FormFunction formFunction = new FormFunction();
            formFunction.ShowDialog();
        }
    }
}
