using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class ScheduleMaker : Form
    {
        private String name;
        private String employeeID;
        private TextBox[,] schedule;


        public ScheduleMaker()
        {
            InitializeComponent();

            //initialize 2d array of textboxes for timeslots
            schedule = new TextBox[,] { { txtBox1, txtBox2, txtBox3, txtBox4, txtBox5, txtBox6, txtBox7}
                ,{txtBox8, txtBox9, txtBox10, txtBox11, txtBox12, txtBox13, txtBox14 }
                ,{txtBox15, txtBox16, txtBox17, txtBox18, txtBox19, txtBox20, txtBox21}
                ,{txtBox22, txtBox23, txtBox24, txtBox25, txtBox26, txtBox27, txtBox28}
                ,{txtBox29, txtBox30, txtBox31, txtBox32, txtBox33, txtBox34, txtBox35}
                ,{txtBox36, txtBox37, txtBox38, txtBox39, txtBox40, txtBox41, txtBox42}
                ,{txtBox43, txtBox44, txtBox45, txtBox46, txtBox47, txtBox48, txtBox49}
                ,{txtBox50, txtBox51, txtBox52, txtBox53, txtBox54, txtBox55, txtBox56}
                ,{txtBox57, txtBox58, txtBox59, txtBox60, txtBox61, txtBox62, txtBox63}
                ,{txtBox64, txtBox65, txtBox66, txtBox67, txtBox68, txtBox69, txtBox70}
                ,{txtBox71, txtBox72, txtBox73, txtBox74, txtBox75, txtBox76, txtBox77}
                ,{txtBox78, txtBox79, txtBox80, txtBox81, txtBox82, txtBox83, txtBox84}
                ,{txtBox85, txtBox86, txtBox87, txtBox88, txtBox89, txtBox90, txtBox91}
                ,{txtBox92, txtBox93, txtBox94, txtBox95, txtBox96, txtBox97, txtBox98}
                ,{txtBox99, txtBox100, txtBox101, txtBox102, txtBox103, txtBox104, txtBox105}
                ,{txtBox106,txtBox107, txtBox108, txtBox109, txtBox110, txtBox111, txtBox112}
                ,{txtBox113, txtBox114, txtBox115, txtBox116, txtBox117, txtBox118, txtBox119}
                ,{txtBox120, txtBox121, txtBox122, txtBox123, txtBox124, txtBox125, txtBox126}
                ,{txtBox127, txtBox128, txtBox129, txtBox130, txtBox131, txtBox132, txtBox133}
                ,{txtBox134, txtBox135, txtBox136, txtBox137, txtBox138, txtBox139, txtBox140}
                ,{txtBox141, txtBox142, txtBox143,txtBox144, txtBox145, txtBox146, txtBox147}
                ,{txtBox148, txtBox149, txtBox150, txtBox151, txtBox152, txtBox153, txtBox154}
                ,{txtBox155, txtBox156, txtBox157, txtBox158, txtBox159, txtBox160, txtBox161}
                ,{txtBox162, txtBox163, txtBox164, txtBox165, txtBox166, txtBox167, txtBox168 } };

        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        //opens a dialogbox to select a csv file when load schedule button clicked and loads data into form if possible
        private void loadBtn_Click(object sender, EventArgs e)
        {
            //create openfiledialogbox object that only lets you open csv files
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open CSV File";
            theDialog.Filter = "CSV files|*.csv";
            theDialog.InitialDirectory = @"C:\";

            if (theDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    //streamreader object to read from opened file
                    System.IO.StreamReader sr = new
                    System.IO.StreamReader(theDialog.FileName);

                    String text="";
                    String[] lines;

                    //reads employee name from first line of file and puts it in appropriate textbox 
                    text = sr.ReadLine();
                    lines = text.Split(','); //use comma as delimiter
                    nameTxtBox.Text=lines[1];   //use index 1 to skip label
                    
                    //reads employeeID and puts it in appropriate textbox
                    text = sr.ReadLine();
                    lines = text.Split(',');    //use comma as delimiter
                    employeeIDTxtBox.Text=lines[1]; //use index 1 to skip label

                    //skip extra stuff
                    sr.ReadLine();
                    sr.ReadLine();

                    //reads rest of file
                    while (!sr.EndOfStream)
                    {
                        //places rest of csv file in 2d array of textboxes named schedule
                        for(int row=0;row<24;row++)
                        {
                            text = sr.ReadLine();
                            lines = text.Split(',');    //use comma as delimiter
                            for(int col=0;col<7;col++)
                            {
                                schedule[row, col].Text = lines[col+1];
                            }
                        }
                    }
                    sr.Close(); 

                }
                catch 
                {
                    MessageBox.Show("Error: unable to laod file.","Error");

                    //clear all textboxes
                    nameTxtBox.Text = "";
                    employeeIDTxtBox.Text = "";
                    for(int row=0;row<24;row++)
                    {
                        for(int col=0;col<7;col++)
                        {
                            schedule[row, col].Text = "";
                        }
                    }
                }
            }
        }

        //displays instructions when instruction button clicked
        private void instBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Enter your name and ID. For each time slot that you are not available, type any text into the corresponding box.", "Instructions");
        }

        //saves all info on form to a csv file when save schedule button clicked
        private void saveBtn_Click(object sender, EventArgs e)
        {
            name = nameTxtBox.Text;
            employeeID = employeeIDTxtBox.Text;

            //checks if name textbox is empty
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.","Error");
            }

            //checks if employeeID textbox is empty
            else if(String.IsNullOrEmpty(employeeID))
            {
                MessageBox.Show("Please enter an employee id.", "Error");
            }

            else 
            {
                //creates a savefiledalog box that only lets you create csv files
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "CSV file|*.csv";
                saveFileDialog1.Title = "Save a CSV File";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    System.IO.FileStream fs =
                       (System.IO.FileStream)saveFileDialog1.OpenFile();

                    //create streamwrite object to write to filestream
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine("Name:," + name);
                        sw.WriteLine("Employee ID:," + employeeID);
                        sw.WriteLine();
                        sw.WriteLine("Schedule,Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday");

                        //writes first row of schedule textboxes with appropriate timeframe to csv file
                        sw.Write("12am-1am,");
                        for(int column=0;column<7; column++)
                        {
                            sw.Write(schedule[0, column].Text+",");
                        }
                        sw.WriteLine();

                        //writes next 11 rows of schedule textboxes with appropriate timeframes to csv file
                        for(int row=1;row<12;row++)
                        {
                            sw.Write(row.ToString() + "-" + (row + 1)+",");//timeframe
                            for (int column=0;column<7;column++)
                            {
                                sw.Write(schedule[row,column].Text+",");
                            }
                            sw.WriteLine();
                        }

                        //writes 12th row of textboxes with appropriate timeframe to csv file
                        sw.Write("12pm-1pm,");
                        for (int column = 0; column < 7; column++)
                        {
                            sw.Write(schedule[12, column].Text + ",");
                        }
                        sw.WriteLine();

                        //writtes 13th-23rd row of textboxes with appropriate timeframes to csv file
                        for (int row = 13, time = 1; row < 24 && time < 12; row++,time++)
                        {
                            sw.Write(time + "-" + (time + 1) + ",");//timeframe
                            for (int column = 0; column < 7; column++)
                            {
                                sw.Write(schedule[row, column].Text + ",");
                            }
                            sw.WriteLine();
                        }
                    }
                    fs.Close(); //close filestream object
                }
            }
        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}