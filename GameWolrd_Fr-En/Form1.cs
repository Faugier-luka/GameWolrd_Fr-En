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
        string tabFrench;
        string lineEnglish ="";
        string lineFrench = "";
        string[] tabEnglish = new string[3000];
        string[] tabFrancais = new string[3000];
        int nombreEnglish, nombreFrancais;

        public Form1()
        {
            InitializeComponent();
        }
        //   StreamWriter sw = new StreamWriter("tB_WorldEnglish.txt", true, Encoding.ASCII);  //écrire
        private void b_Gener_Click(object sender, EventArgs e)
        {
            
            try
            {
                lectureFichier();
                nombreEnglish = RandomNombre();
                nombreFrancais = RandomNombre();
                tB_WorldEnglish.Text = tabEnglish[nombreEnglish];

               
                tabFrench = tB_WorldFrench.Text;

                tb_C_English.Text = tabEnglish[nombreEnglish];
                tb_C_French.Text = tabFrancais[nombreFrancais];

              


            }
            catch (Exception ex)
            {
                tB_WorldEnglish.Text = "Exception:" + ex.Message;
            }
        }
        private void button_Valider_Click(object sender, EventArgs e)
        {
           
            if (tB_WorldFrench.Text == tb_C_French.Text)
            {
                tB_WorldFrench.Text = "OK";
            }
            else
            {
                tB_WorldFrench.Text = "pas ok";
            }
        }
        public  int RandomNombre()
        {
            Random aleatoire = new Random();
            int entierUnChiffre = aleatoire.Next(0,171);
            return entierUnChiffre;
        }
        public void lectureFichier()
        {
            //C://Users/lfaugier/source/repos/Faugier-luka/GameWolrd_Fr-En/WorldEnglish.txt // pc fixe
            // C://Users/User/Source/Repos/Faugier-luka/GameWorld_Fr-En/WorldEnglish.txt // pc protable
            StreamReader sr = new StreamReader("C://Users/User/source/repos/Faugier-luka/GameWolrd_Fr-En/WorldEnglish.txt");// lecture
            StreamReader sre = new StreamReader("C://Users/User/source/repos/Faugier-luka/GameWolrd_Fr-En/WorldFrench.txt");
            int i = 0;
            while (lineEnglish != null)
            {
                tB_WorldEnglish.Text = lineEnglish;
                lineEnglish = sr.ReadLine();
                tabEnglish[i] = lineEnglish;
                i += 1;
            } // fabrication du tableau
            int y = 0;
            while (lineFrench != null)
            {
                tB_WorldFrench.Text = lineFrench;
                lineFrench = sre.ReadLine();
                tabFrancais[y] = lineFrench;
                y++;
            }

            sr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //aucune idée a ne pas faire
        }

       
    }
}
