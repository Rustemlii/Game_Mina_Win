namespace Game_Mina_Win
{
    public partial class Form1 : Form
    {
        int[] test;
        int buttonSayi = 0;
        int say;
        int say1;
        int say3;
        int qirmiziButtonSayi = 0;
        decimal netice;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            say = rnd.Next(0, 30);
            say1 = rnd.Next(0, 30);
            say3 = rnd.Next(0, 30);
            test = new int[3] { say, say1, say3 };

        }

        void Rand(Button btn)
        {

            btn.Enabled = false;
            buttonSayi += 1;
            label2.BackColor = Color.Green;
            label2.Text = $"Cehd: {buttonSayi}";


            foreach (int i in test)
            {
                if (btn.Text == i.ToString())
                {
                    qirmiziButtonSayi += 1;
                    netice = Convert.ToDecimal(buttonSayi) * 100 / 30;
                    btn.BackColor = Color.Red;
                    label2.BackColor = Color.Red;
                    if (qirmiziButtonSayi == 3)
                    {
                        label2.Text = $"Cehd: {buttonSayi} minaya düsdünüz.Qiymetlendirme {netice.ToString().Remove(6)}%";
                        MessageBox.Show($"Game Over", "Mina", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else if (qirmiziButtonSayi < 3)
                    {
                        label2.Text = $"Cehd: {buttonSayi} minaya düsdünüz.";
                        MessageBox.Show($"BOOOM", "Mina", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                    break;
                }
                else
                {
                    btn.BackColor = Color.Green;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rand(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rand(button2);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rand(button3);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rand(button4);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rand(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rand(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Rand(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Rand(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Rand(button9);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Rand(button10);

        }

        private void button11_Click(object sender, EventArgs e)
        {

            Rand(button11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Rand(button12);
        }

        private void button13_Click(object sender, EventArgs e)
        {

            Rand(button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Rand(button14);
        }

        private void button15_Click(object sender, EventArgs e)
        {

            Rand(button15);
        }

        private void button16_Click(object sender, EventArgs e)
        {

            Rand(button16);
        }

        private void button17_Click(object sender, EventArgs e)
        {

            Rand(button17);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Rand(button18);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Rand(button19);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Rand(button20);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Rand(button21);
        }

        private void button22_Click(object sender, EventArgs e)
        {

            Rand(button22);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Rand(button23);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Rand(button24);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Rand(button25);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Rand(button26);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Rand(button27);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Rand(button28);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Rand(button29);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Rand(button30);
        }


    }
}