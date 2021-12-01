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




namespace GameWolrd_Fr_En
{
  
    public partial class Form1 : Form
    {
        public Int64 i;
        string line ="";
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Valider_Click(object sender, EventArgs e)
        {
            try
            {
             //   StreamWriter sw = new StreamWriter("tB_WorldEnglish.txt", true, Encoding.ASCII);  //écrire
             StreamReader sr = new StreamReader("tB_WorldEnglish.txt");
           
                while (line != null)
                {
                    tB_WorldEnglish.Text = line;
                    line = sr.ReadLine();
                }
                sr.Close();
                //sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
