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
      
       string line ="";
 
  

        public Form1()
        {
            InitializeComponent();
        }
            //   StreamWriter sw = new StreamWriter("tB_WorldEnglish.txt", true, Encoding.ASCII);  //écrire

        private void button_Valider_Click(object sender, EventArgs e)
        {
             tB_WorldEnglish.Text = "";
            string []tab1 = new string[3000];
            int i = 0;
            try
            {
                //C://Users/lfaugier/source/repos/Faugier-luka/GameWolrd_Fr-En/WorldEnglish.txt // pc fixe
                // C://Users/User/Source/Repos/Faugier-luka/GameWorld_Fr-En/WorldEnglish.txt // pc protable
                StreamReader sr = new StreamReader("C://Users/User/source/repos/Faugier-luka/GameWolrd_Fr-En/WorldEnglish.txt");// lecture
        
                while (line != null)
                {
                    tB_WorldEnglish.Text = line;
                    line = sr.ReadLine();
                    tab1[i] = line;
                    i+=1;
                } // fabrication du tableau

             

                sr.Close();
           
              
;              tB_WorldEnglish.Text = RandomTab();
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
        public int RandomTab()
        {
            int rand_num;
            Random rd = new Random();
            rand_num = rd.Next(100,200);
            return rand_num;
            
        }

    }
}
