using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp18
{
    public partial class AddTextForm : Form
    {
        public string Text { get; private set; }
        public int InputX { get; private set; }
        public int InputY { get; private set; }
        public AddTextForm()
        {
            InitializeComponent();
        }

        private void InputText_TextChanged(object sender, EventArgs e)
        { }
        private void OkBTN_Click(object sender, EventArgs e)
        {
            Text = InputText.Text;
            InputX = (int)NumericUpDownX.Value;
            InputY = (int)NumericUpDownY.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
