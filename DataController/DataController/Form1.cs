using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitLayerList();
        }

        private void InitLayerList()
        {
            FileListView.Clear();
            FileListView.InsertionMark.Color = Color.Blue;
            FileListView.Columns.Add("File", 245);
        }
    }
}
