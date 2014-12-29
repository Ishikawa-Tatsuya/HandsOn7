using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormsTarget
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            _comboBox.SelectedIndex = 0;
            _treeView.ExpandAll();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            _button.Text = "Clicked";
        }
    }
}
