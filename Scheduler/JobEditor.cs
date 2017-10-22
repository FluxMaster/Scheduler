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
        }

        private void JobEditor_Load(object sender, EventArgs e)
        {
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            loadList();
            //call loadlist method
        }

        //loads data from csv file to textbox
        private void loadList()
        {
            String temp="";
            int count = 1;
            try
            {
                //directory two folders up from current directory
                string directory = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
                StreamReader sr = new StreamReader(directory+"/"+"Jobs/Jobs.csv");
                String text = "";
                String[] lines;

                //load data from csv file to textbox using comma as delimiter
                while (!sr.EndOfStream)
                {
                    text = sr.ReadLine();
                    lines = text.Split(','); //use comma as delimiter

                    temp+= lines[0] + "," +
                    Day.numberToDay(Int32.Parse(lines[1])) + "," +
                    Day.numberToTime(Int32.Parse(lines[2])) + "," +
                    lines[3] +"\r\n";
                    count++;
                }
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Failed to open file at line "+count);
            }
            
            listTxtBox.Text = temp;
        }


        //saves all text from textbox to csv file, overwrites it
        private void saveBtn_Click(object sender, EventArgs e)
        {
            //String temp = "";
            String[] lines;
            String text = "";
            int count = 1;
            try
            {
                //goes two directories up
               // string directory = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();

                //object to write to file
               // StreamWriter sw = new StreamWriter(directory + "/" + "Jobs/Jobs.csv");

                //goes line by line through textbox using comma as delimiter
                for (int x=0;x<listTxtBox.Lines.Length;x++)
                {
                    text += listTxtBox.Lines[x].Split(',');
                    text += "\n";
                    /*lines = listTxtBox.Lines[x].Split(',');
                    sw.Write(lines[0] + "," +
                        lines[1] + "," +
                        Day.numberToDay(Int32.Parse(lines[2])) + "," +
                        Day.numberToTime(Int32.Parse(lines[3])) + "\n");
                    count++;*/
                }
                MessageBox.Show(text);
                //sw.Close();
            }
            catch
            {
                MessageBox.Show("Failed to save file at line "+count);
            }
            
        }
    }
}
