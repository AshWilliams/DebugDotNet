using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAppFileNotFound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //This file doesn't exist, ergo, should throw an exception
                string text = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");

                // Display the file contents to the console. Variable text is a string.
                System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
