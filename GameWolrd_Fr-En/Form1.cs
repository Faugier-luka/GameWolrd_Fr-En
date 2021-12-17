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
        string []tab1;
        public Form1()
        {
            InitializeComponent();
        }
            //   StreamWriter sw = new StreamWriter("tB_WorldEnglish.txt", true, Encoding.ASCII);  //écrire

        private void button_Valider_Click(object sender, EventArgs e)
        {
      
            try
            {
                //C://Users/lfaugier/source/repos/Faugier-luka/GameWolrd_Fr-En/WorldEnglish.txt // pc fixe
                // C:/Users/User/Source/Repos/Faugier-luka/GameWorld_Fr-En/WorldEnglish.txt // pc protable
                StreamReader sr = new StreamReader("C:/Users/User/Source/Repos/Faugier-luka/GameWorld_Fr-En/WorldEnglish.txt");// lecture
                int i = 0;
                while (line != null)
                {
                    tB_WorldEnglish.Text = line;
                    line = sr.ReadLine();
                    tab1[i] = line;
                    i++;
                }
                sr.Close();
                //sw.Close();2
;                tB_WorldEnglish.Text = tab1[2];
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
