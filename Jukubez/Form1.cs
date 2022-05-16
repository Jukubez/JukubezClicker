namespace Jukubez
{
    public partial class Form1 : Form
    {

        private int dolarki;
        public int Dolarki
        {
            set
            {
                dolarki = value;
                label1.Text = "Kredyty: $" + value.ToString();
            }
            get
            {
                return dolarki;
            }


        }
        int buttonLevel;
        int Wartosc1;
        int Czas1;
        int Czas2;
        int Czas3;
        int UpgradeButton;
        int Wartosc2;
        int Wartosc3;

        public Form1()
        {
            InitializeComponent();
            Dolarki = 0;
            buttonLevel = 1;
            Wartosc1 = 25;
            Czas1 = 0;
            Czas2 = 0;
            Czas3 = 0;
            UpgradeButton = 1;
            Wartosc2 = 100;
            Wartosc3 = 250;

            WartoscTextBox1.Text = Wartosc1.ToString();
            CzasTextBox1.Text = Czas1.ToString();
            CzasTextBox2.Text = Czas2.ToString();
            CzasTextBox3.Text = Czas3.ToString();
            WartoscTextBox2.Text = Wartosc2.ToString();
            WartoscTextBox3.Text = Wartosc3.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dolarki += (int)Math.Pow(10, buttonLevel - 1);
        }

        private void UpgradeButton_Click(object sender, EventArgs e)
        {
            int upgradeCost = (int)Math.Pow(5, buttonLevel);
            if (Dolarki >= upgradeCost)
            {
                buttonLevel++;
                ButtonTextBox.Text = buttonLevel.ToString();
                Dolarki -= upgradeCost;
                string nextUpgradeCost = "($" + Math.Pow(5, buttonLevel).ToString() + ")";
                upgradebutton.Text = "Upgrade\n" + nextUpgradeCost;
            }
        }

        private void WartoscUpgradeButton1_Click(object sender, EventArgs e)
        {
            int upgradeCost2 = Wartosc1 * 20;
            if (Dolarki >= upgradeCost2)
            {
                Wartosc1 += 20;
                WartoscTextBox1.Text = Wartosc1.ToString();
                Dolarki -= upgradeCost2;

            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Dolarki += Wartosc1;
        }

        private void CzasUpgradeButton1_Click(object sender, EventArgs e)
        {
            int upgradeCost = Czas1 * 50;
            if (Dolarki >= upgradeCost)
            {
                Czas1++;
                CzasTextBox1.Text = Czas1.ToString();
                Timer1.Interval = (60 / Czas1) * 50;
                if (!Timer1.Enabled)
                    Timer1.Enabled = true;
                Dolarki -= upgradeCost;
            }
        }

        private void CzasUpgradeButton2_Click(object sender, EventArgs e)
        {
            int upgradeCost = Czas2 * 1500;
            if (Dolarki >= upgradeCost)
            {
                Czas2++;
                CzasTextBox2.Text = Czas2.ToString();
                Timer2.Interval = (60 / Czas2) * 10;
                if (!Timer2.Enabled)
                    Timer2.Enabled = true;
                Dolarki -= upgradeCost;
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Dolarki += Wartosc2;
        }

        private void CzasUpgradeButton3_Click(object sender, EventArgs e)
        {
            int upgradeCost = Czas3 * 5000;
            if (Dolarki >= upgradeCost)
            {
                Czas3++;
                CzasTextBox3.Text = Czas3.ToString();
                Timer3.Interval = (60 / Czas3) * 10;
                if (!Timer3.Enabled)
                    Timer3.Enabled = true;
                Dolarki -= upgradeCost;

            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            Dolarki += Wartosc3;
        }

        private void WartoscUpgradeButton2_Click(object sender, EventArgs e)
        {
            int upgradeCost2 = Wartosc2;
            if (Dolarki >= upgradeCost2)
            {

                Wartosc2 += 100;
                WartoscTextBox2.Text = Wartosc2.ToString();
                Dolarki -= upgradeCost2;
            }
        }

        private void WartoscUpgradeButton3_Click(object sender, EventArgs e)
        {
            int upgradeCost2 = Wartosc3 * 10;
            if (Dolarki >= upgradeCost2)
            {

                Wartosc3 += 200;
                WartoscTextBox3.Text = Wartosc3.ToString();
                dolarki -= upgradeCost2;
            }
        }
    }
}