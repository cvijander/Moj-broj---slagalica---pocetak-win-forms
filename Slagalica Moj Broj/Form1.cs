namespace Slagalica_Moj_Broj
{
    public partial class Form1 : Form
    {
        private int brojKlikova = 0;
        private int aktuelniBroj = 0;
        private int brojOdabranihCifara = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pboxKontrolni.Image = new Bitmap("0.png");
        }

        private void pboxKontrolni_Click(object sender, EventArgs e)
        {
            if (brojKlikova == 0)
            {
                timer1.Enabled = true;
            }
            else
            {
                brojOdabranihCifara++;
                if (brojOdabranihCifara == 1)
                {
                    pboxTrazeniBroj1.Image = new Bitmap(aktuelniBroj + ".png");
                }
                else if (brojOdabranihCifara == 2)
                {
                    pboxTrazeniBroj2.Image = new Bitmap(aktuelniBroj + ".png");
                }
                else if (brojOdabranihCifara == 3)
                {
                    pboxTrazeniBroj3.Image = new Bitmap(aktuelniBroj + ".png");
                }
                else if (brojOdabranihCifara == 4)
                {
                    pboxPonudjeni1.Image = new Bitmap(aktuelniBroj + ".png");
                }
                else if (brojOdabranihCifara == 5)
                {
                    pboxPonudjeni2.Image = new Bitmap(aktuelniBroj + ".png");
                }
                else if (brojOdabranihCifara == 6)
                {
                    pboxPonudjeni3.Image = new Bitmap(aktuelniBroj + ".png");
                }
                else if (brojOdabranihCifara == 7)
                {
                    pboxPonudjeni4.Image = new Bitmap(aktuelniBroj + ".png");
                }
                else if (brojOdabranihCifara == 8)
                {
                    pboxPonudjeni5.Image = new Bitmap(aktuelniBroj + ".png");
                }
                else if (brojOdabranihCifara == 9)
                {
                    pboxPonudjeni6.Image = new Bitmap(aktuelniBroj + ".png");
                }
            }
            brojKlikova++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            aktuelniBroj++;
            if (aktuelniBroj == 10) aktuelniBroj = 0;

            pboxKontrolni.Image = new Bitmap(aktuelniBroj + ".png");
        }
    }
}