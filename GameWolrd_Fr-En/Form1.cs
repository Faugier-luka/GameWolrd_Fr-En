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
        int nbrF, nbrC, nombreEnglish, nombreFrancais, possition = 0, posTabDb, posTabFin;
        string tabFrench, lineEnglish ="", lineFrench = "";
        string[] tabEnglish = new string[3000];
        string[] tabFrancais = new string[3000];
       

        public Form1()
        {
            InitializeComponent();
            infoVal();
            lectureFichier();
            cb_Mot.SelectedText = "0";

        }
        //   StreamWriter sw = new StreamWriter("tB_WorldEnglish.txt", true, Encoding.ASCII);  //écrire
        private void b_Gener_Click(object sender, EventArgs e)
        {
            try
            {
                nombreEnglish = RandomNombre();
                nombreFrancais = RandomNombre();               
                tabFrench = tB_WorldFrench.Text;
                tb_C_English.Text = tabEnglish[nombreEnglish];
                tb_C_French.Text = tabFrancais[nombreFrancais];


                if (possition == 0)
                {
                    tB_WorldEnglish.Text = tabEnglish[nombreEnglish];
                }
                else if (possition == 1)
                {
                    tB_WorldFrench.Text = tabFrancais[nombreFrancais];
                }
               
            }
            catch (Exception ex)
            {
                tB_WorldEnglish.Text = "Exception:" + ex.Message;
            }
        }
        private void button_Valider_Click(object sender, EventArgs e)
        {
            if (possition == 0)
            {
                correctionFE();
            }
            else if (possition == 1)
            {
                correctionEF();
            }
            message();
          }
        private void b_enchange_Click(object sender, EventArgs e)
        {
            if (possition == 0)
            {
                possition = 1;
                tB_WorldEnglish.Enabled = true;
                tB_WorldFrench.Enabled = false;
            }
            else if (possition == 1)
            {
                possition = 0;
                tB_WorldEnglish.Enabled = false;
                tB_WorldFrench.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            infoVal();
        }

        public void message()
        {
            if (nbrC == 31)
            {
                tB_WorldFrench.Text = "";
                tB_WorldEnglish.Text = "";
                tbNombreCorrecte.Text = "";
                tbNombreFaux.Text = "";
                tb_nombreVisibleF.Text = "";
                tb_nombreVisibleV.Text = "";
                nbrC = 0;
                MessageBox.Show("vous avez ganier", "fin du chargement de la bare", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (nbrF == 31)
            {
                tB_WorldFrench.Text = "";
                tB_WorldEnglish.Text = "";
                tbNombreCorrecte.Text = "";
                tbNombreFaux.Text = "";
                tb_nombreVisibleV.Text = "";
                tb_nombreVisibleF.Text = "";
                nbrF = 0;
                MessageBox.Show("vous avez perdu", "fin du chargement de la bare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void correctionFE()
        {
            if (tB_WorldFrench.Text == tb_C_French.Text)
            {
                tbNombreCorrecte.Text += "I";
                nbrC++;
                tb_nombreVisibleV.Text = nbrC.ToString();
            }
            else
            {
               
                tbNombreFaux.Text += "I";
                nbrF++;
                tb_nombreVisibleF.Text = nbrF.ToString();
            }
            tB_WorldFrench.Text = "";
        }

        public void correctionEF()
        {
           
            if (tB_WorldEnglish.Text == tb_C_English.Text)
            {
                tbNombreCorrecte.Text += "I";
                nbrC++;
                tb_nombreVisibleV.Text = nbrC.ToString();
            }
            else
            {
               
                tbNombreFaux.Text += "I";
                nbrF++;
                tb_nombreVisibleF.Text = nbrF.ToString();
            }
            tB_WorldEnglish.Text = "";
        }

        public  int RandomNombre()
        {
            Random aleatoire = new Random();
            int entierUnChiffre = aleatoire.Next(posTabDb,posTabFin);
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

        public void infoVal()
        {
            string result = cb_Mot.Text;
            switch (result)
            {
                case "0 à 100":
                    posTabDb = 0;
                    posTabFin = 100;
                    break;
                case "101 à 200":
                    posTabDb = 101;
                    posTabFin = 200;
                    break;
                case "201 à 300":
                    posTabDb = 201;
                    posTabFin = 300;
                    break;
                case "301 à 400":
                    posTabDb = 301;
                    posTabFin = 400;
                    break;
                case "401 à 500":
                    posTabDb = 401;
                    posTabFin = 500;
                    break;
                case "501 à 600":
                    posTabDb = 501;
                    posTabFin = 600;
                    break;
                case "601 à 700":
                    posTabDb = 601;
                    posTabFin = 700;
                    break;
                case "701 à 800":
                    posTabDb = 701;
                    posTabFin = 800;
                    break;
                case "801 à 900":
                    posTabDb = 801;
                    posTabFin = 900;
                    break;
                case "901 à 1000":
                    posTabDb = 901;
                    posTabFin = 1000;
                    break;
                case "1001 0 1100":
                    posTabDb = 1001; 
                    posTabFin = 1100;
                    break;
                case "1101 à 1200":
                    posTabDb = 1101;
                    posTabFin = 1200;
                    break;
                case "1201 à 1300":
                    posTabDb = 1201;
                    posTabFin = 1300;
                    break;
                case "1301 à 1400":
                    posTabDb = 1301;
                    posTabFin = 1400;
                    break;
                case "1401 à 1500":
                    posTabDb = 1401;
                    posTabFin = 1500;
                    break;
                case "1501 à 1600":
                    posTabDb = 1501;
                    posTabFin = 1600;
                    break;
                case "1601 à 1700":
                    posTabDb = 1601;
                    posTabFin = 1700;
                    break;
                case "1701 à 1800":
                    posTabDb = 1701;
                    posTabFin = 1800;
                    break;
                case "1801 à 1900":
                    posTabDb = 1801;
                    posTabFin = 1900;
                    break;
                case "1901 à 2000":
                    posTabDb = 1901;
                    posTabFin = 2000;
                    break;
                case "2001 à 2100":
                    posTabDb = 2001;
                    posTabFin = 2100;
                    break;
                case " 2101 à 2200":
                    posTabDb = 2101;
                    posTabFin = 2200;
                    break;
                case "2201 à 2300":
                    posTabDb = 2201;
                    posTabFin = 2300;
                    break;
                case "2301 à 2400":
                    posTabDb = 2301;
                    posTabFin = 2400;
                    break;
                case "2401 à 2500":
                    posTabDb = 2401;
                    posTabFin = 2500;
                    break;
                case "2501 à 2600":
                    posTabDb = 2501;
                    posTabFin = 2600;
                    break;
                case "2601 à 2700":
                    posTabDb = 2601;
                    posTabFin = 2700;
                    break;
                case "2701 à 2800":
                    posTabDb = 2701;
                    posTabFin = 2800;
                    break;
                case "2801 à 2900":
                    posTabDb = 2801;
                    posTabFin = 2900;
                    break;
                case "2901 à 3000":
                    posTabDb = 2901;
                    posTabFin = 3000;
                    break;
                default:
                    posTabDb = 0;
                    posTabFin = 100;
                    break;
            }
        }      
    }
}
