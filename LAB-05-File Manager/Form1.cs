using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Manager
{
    public partial class Form1 : Form
    {
        List<ReadOnly> readOnlies = new List<ReadOnly>();
        List<Editable> editable = new List<Editable>();
        static int FileCount = 0;
        static int TotalFileSize = 0;
        public Form1()
        {
            InitializeComponent();
            FileListBox.Items.Add("Name\tType\t\tSize(B)");
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            if (FileTypeComboBox.Text == "Read Only")
            {
                ReadOnly r1 = new ReadOnly(FileNameTextBox.Text, FileContentTextBox.Text);
                readOnlies.Add(r1);
                FileCount++;
                TotalFileSize+= r1.GetFileSize();
            }

            else
            {
                Editable e1 = new Editable(FileNameTextBox.Text, FileContentTextBox.Text);
                editable.Add(e1);
                FileCount++;
                TotalFileSize += e1.GetFileSize();
            }

            MessageBox.Show("File Added Successfully");

            FileNameTextBox.Clear();
            FileContentTextBox.Clear();
            FileNameTextBox.Focus();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            string s = RFileNameTextBox.Text;
            int flag = 0;

            for (int i = 0; i < readOnlies.Count; i++)
            {
                ReadOnly r = readOnlies[i];
                if (r.GetFileName() == s) 
                { 
                    readOnlies.Remove(r);
                    FileCount--;
                    TotalFileSize-= r.GetFileSize();
                    flag++;
                }
            }

            for (int i = 0; i < editable.Count; i++)
            {
                Editable ed = editable[i];
                if (ed.GetFileName() == s)
                {
                    editable.Remove(ed);
                    FileCount--;
                    TotalFileSize-= ed.GetFileSize();
                    flag++;
                }

            }

            if (flag != 0) { MessageBox.Show("File Removed SuccessFully"); }
            else { MessageBox.Show("No File of this name was Found"); }
            RFileNameTextBox.Clear();
            RFileNameTextBox.Focus();
        }

        private void FileNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ShowContentListBox.Items.Clear();
            Editable Edit = new Editable();
            int flag = 0;
            foreach(Editable ed in editable) 
            {
                string s= UFileNameTextBox.Text;
                if(ed.GetFileName()==s) { Edit = ed; flag++; break;  }
            }

            if(flag!=0)
            {
                ShowContentListBox.Items.Add(Edit.GetFileContent());
            }
            else 
            {
              ShowContentListBox.Items.Add("File Is Not Editable");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Editable Edit = new Editable();
            int flag = 0;
            foreach (Editable ed in editable)
            {
                string s = UFileNameTextBox.Text;
                if (ed.GetFileName() == s) { Edit = ed; flag++; break; }
            }

            if (flag != 0)
            {
                TotalFileSize-=Edit.GetFileSize();
                Edit.Edited(Edit,NewContentTextBox.Text);
                TotalFileSize += NewContentTextBox.TextLength;
                MessageBox.Show("File Edited Successfully");
            }
            else
            {
                MessageBox.Show("File Is Not Editable");
            }

            UFileNameTextBox.Clear();
            ShowContentListBox.Items.Clear();
            NewContentTextBox.Clear();
            UFileNameTextBox.Focus();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ContentListBox.Items.Clear();
            AllowedFeaturesListBox.Items.Clear();
            string s= VFileNameTextBox.Text;
            foreach(Editable ed in editable)
            {
                if(ed.GetFileName() == s) 
                {
                    ContentListBox.Items.Add(ed.GetFileContent());
                    AllowedFeaturesListBox.Items.Add("Share");
                    AllowedFeaturesListBox.Items.Add("Compressed");
                    AllowedFeaturesListBox.Items.Add("Translated");
                }
            }


            foreach (ReadOnly r1 in readOnlies)
            {
                if (r1.GetFileName() == s)
                {
                    ContentListBox.Items.Add(r1.GetFileContent());
                    AllowedFeaturesListBox.Items.Add("Share");
                    AllowedFeaturesListBox.Items.Add("Print");
                    AllowedFeaturesListBox.Items.Add("Archived");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileListBox.Items.Clear();
            FileListBox.Items.Add("Name\tType\t\tSize(B)");

            TotalFileLabel.Text = $"Total File : {FileCount}";
            TotalMemoryLabel.Text = $"Total Occupied Memory : {TotalFileSize}";

            foreach(Editable ed in editable)
            {
                string s = $"{ed.GetFileName()}\t{ed.GetFileType()}\t\t{ed.GetFileSize()}";
                FileListBox.Items.Add(s);
            }

            foreach (ReadOnly r1 in readOnlies)
            {
                string s = $"{r1.GetFileName()}\t{r1.GetFileType()}\t{r1.GetFileSize()}";
                FileListBox.Items.Add(s);
            }
        }

        private void FileListLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
