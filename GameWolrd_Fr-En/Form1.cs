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
            //   StreamWriter sw = new StreamWriter("tB_WorldEnglish.txt", true, Encoding.ASCII);  //écrire

        private void button_Valider_Click(object sender, EventArgs e)
        {
      
            try
            {
           
             StreamReader sr = new StreamReader("C://Users/lfaugier/source/repos/Faugier-luka/GameWolrd_Fr-En/WorldEnglish.txt");// lecture
           
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
                tB_WorldEnglish.Text = "Exception:" + ex.Message;
            }
            /*finally
            {
                tB_WorldEnglish.Text = "Executing finally block.";
            }*/
        }
    }
}
