using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using InventoryManager.Data;

namespace InventoryManager.WinForms
{
    public partial class MainForm : Form
    {
        
        private World World
        { 
            get => mWorld; 
            set => mWorld = value; 
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectfileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                filenameTextBox.Text = openFileDialog.FileName;
            }
        }

        private World mWorld;
    }
}
