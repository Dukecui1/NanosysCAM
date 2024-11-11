using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Nanosys1000Software
{
    public partial class ProgramForm : Form
    {
        public ProgramForm()
        {
            InitializeComponent();
        }

        private void button_saveNC_Click(object sender, EventArgs e)
        {            
            SaveFileDialog sfdlg = new SaveFileDialog();
            sfdlg.Title = "Save the NC program";
            sfdlg.Filter = "Text file(*.txt)|*.txt|All files(*.*)|*.*";
            sfdlg.RestoreDirectory = true;
            sfdlg.FileName = "NC Program1";
            if (sfdlg.ShowDialog() == DialogResult.OK && sfdlg.FileName.Length > 0)
            {
                try
                {
                    richTextBox1.SaveFile(sfdlg.FileName, RichTextBoxStreamType.PlainText);                

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void ProgramForm_Load(object sender, EventArgs e)
        {
            string str;
            
            if (File.Exists("NC program.txt"))
            {
                StreamReader sr = new StreamReader("NC program.txt");
                try
                {
                    str = sr.ReadToEnd();
                    richTextBox1.Text = str;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sr.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
