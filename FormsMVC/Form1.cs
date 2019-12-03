using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsMVC
{
    public partial class FormMain : Form
    {
        TriangleController controller;
        
        public FormMain(TriangleController controller)
        {
            InitializeComponent();
            this.controller = controller;
            controller.OnError += ErrorMessage;
        }

        public void ErrorMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        private void btnTriangleSave_Click(object sender, EventArgs e)
        {
            if (controller.Create(txtA.Text, txtB.Text, txtC.Text))
            {
                controller.Show();
            }            
        }

        public void TriangleShow(TriangleModel model)
        {
            MessageBox.Show(
                $"Perimeter: {model.Perimeter()}\n" +
                $"Area: {model.Area()}");
        }
    }
}
