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

namespace Scheduler
{
    public partial class JobEditor : Form
    {
        public JobEditor()
        {
            InitializeComponent();
            loadList();
        }

        //accessor methods so code in other forms can use the listTxtBox properties
        public string TextBoxValue
        {
            get
            {
                return listTxtBox.Text;
            }
            set
            {
                listTxtBox.Text = value;
            }
        }

        //saves all text from textbox to csv file, overwrites it
        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveList();
        }

        private void saveList()
        {
            String[] lines;
            int count = 1;
            try
            {
                //goes two directories up
                string directory = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
                //object to write to file
                using (StreamWriter sw = new StreamWriter(directory + "/" + "Jobs/Jobs.csv"))
                {

                    //goes line by line through textbox using comma as delimiter
                    for (int x = 0; x < listTxtBox.Lines.Length - 1; x++)
                    {
                        lines = listTxtBox.Lines[x].Split(',');

                        sw.Write(lines[0] + "," +
                               Day.dayToNumber((lines[1])) + "," +
                               Day.timeToNumber((lines[2])) + "," + lines[3] + "\n");
                        count++;
                    }
                    sw.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to save file at line " + count/*+" "+ex*/);
            }
        }
        private void loadBtn_Click(object sender, EventArgs e)
        {
            loadList();
            //call loadlist method
        }

        //loads data from csv file to textbox
        private void loadList()
        {
            String temp = "";
            int count = 1;
            try
            {
                //directory two folders up from current directory
                string directory = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
                using (StreamReader sr = new StreamReader(directory + "/" + "Jobs/Jobs.csv"))
                {
                    String text = "";
                    String[] lines;

                    //load data from csv file to textbox using comma as delimiter
                    while (!sr.EndOfStream)
                    {
                        text = sr.ReadLine();
                        lines = text.Split(','); //use comma as delimiter

                        temp += lines[0] + "," +
                        Day.numberToDay(Int32.Parse(lines[1])) + "," +
                        Day.numberToTime(Int32.Parse(lines[2])) + "," +
                        lines[3] + "\r\n";
                        count++;
                    }
                    sr.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to open file at line " + count/*+" "+ex*/);
            }

            listTxtBox.Text = temp;
        }

        //creates instance of Addjob form and shows it
        private void addBtn_Click(object sender, EventArgs e)
        {
            AddJob addform = new AddJob();
            addform.ShowDialog();

        }
    }
}
