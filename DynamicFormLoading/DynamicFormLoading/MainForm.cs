using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicFormLoading
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            var mirror = new Mirror();
            var classList = mirror.GetReflectedAssembly().ToList();

            var newDynamicallyLoadedForm = new DynamicallyLoadedForm();
            newDynamicallyLoadedForm.PassedFormObject = classList[cmbObjects.SelectedIndex + 1];
            newDynamicallyLoadedForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var mirror = new Mirror();
            var classList = mirror.GetReflectedAssembly().ToList();
            foreach (Type type in classList)
            {
                //Need better, less manual way to get property name
                string editedType = type.ToString().Remove(0, 19);
                if(editedType != "IFormObject")
                {
                    cmbObjects.Items.Add(editedType.ToString());
                }
            }
        }

    }
}
