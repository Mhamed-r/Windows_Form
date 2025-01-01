namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num;
        int count;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != string.Empty)
            {

                num = float.Parse(Txt_resualt.Text);
                txt_display.Text = Txt_resualt.Text + "/";
                Txt_resualt.Clear();
                count = 4;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != string.Empty)
            {

                num = float.Parse(Txt_resualt.Text);
                txt_display.Text = Txt_resualt.Text + "-";
                Txt_resualt.Clear();
                count = 1;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            if (Txt_resualt.Text == "0") { Txt_resualt.Clear(); }

            int x_1 = 1;
            Txt_resualt.Text += x_1.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            txt_display.Text = "0";
            Txt_resualt.Text = "0";
        }

        private void Btn_plus_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != string.Empty)
            {

                num = float.Parse(Txt_resualt.Text);
                txt_display.Text = Txt_resualt.Text + "+";
                Txt_resualt.Clear();
                count = 2;

            }
        }

        private void Btn_mul_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != string.Empty)
            {

                num = float.Parse(Txt_resualt.Text);
                txt_display.Text = Txt_resualt.Text + "*";
                Txt_resualt.Clear();
                count = 3;

            }
        }

        private void Btn_equal_Click(object sender, EventArgs e)
        {
            float Final;
            switch (count)
            {
                case 1:
                    Final = num - float.Parse(Txt_resualt.Text);
                    txt_display.Text = txt_display.Text + Txt_resualt.Text + "=" + Final.ToString();
                    // Txt_resualt.Text.Replace(Txt_resualt.Text, Final.ToString());
                    Txt_resualt.Text= Final.ToString();

                    break;
                case 2:
                    Final = num + float.Parse(Txt_resualt.Text);
                    txt_display.Text = txt_display.Text + Txt_resualt.Text + "=" + Final.ToString();
                    // Txt_resualt.Text.Replace(Txt_resualt.Text, Final.ToString());
                    Txt_resualt.Text = Final.ToString();




                    break;
                case 3:
                    Final = num * float.Parse(Txt_resualt.Text);
                    txt_display.Text = txt_display.Text + Txt_resualt.Text + "=" + Final.ToString();
                    // Txt_resualt.Text.Replace(Txt_resualt.Text, Final.ToString());
                    Txt_resualt.Text = Final.ToString();



                    break;
                case 4:
                    Final = num / float.Parse(Txt_resualt.Text);
                    txt_display.Text = txt_display.Text + Txt_resualt.Text + "=" + Final.ToString();
                    //Txt_resualt.Text.Replace(Txt_resualt.Text, Final.ToString());
                    Txt_resualt.Text = Final.ToString();



                    break;



                default:
                    Txt_resualt.Clear();
                    break;
            }
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            if (Txt_resualt.Text == "0") { Txt_resualt.Clear(); }
            int x_2 = 2;
            Txt_resualt.Text += x_2.ToString();
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            if (Txt_resualt.Text == "0") { Txt_resualt.Clear(); }

            int x_3 = 3;
            Txt_resualt.Text += x_3.ToString();
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            if (Txt_resualt.Text == "0") { Txt_resualt.Clear(); }

            int x_4 = 4;
            Txt_resualt.Text += x_4.ToString();
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            if (Txt_resualt.Text == "0") { Txt_resualt.Clear(); }

            int x_5 = 5;
            Txt_resualt.Text += x_5.ToString();
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            if (Txt_resualt.Text == "0") { Txt_resualt.Clear(); }

            int x_6 = 6;
            Txt_resualt.Text += x_6.ToString();
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            if (Txt_resualt.Text == "0") { Txt_resualt.Clear(); }

            int x_7 = 7;
            Txt_resualt.Text += x_7.ToString();
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            if (Txt_resualt.Text == "0") { Txt_resualt.Clear(); }

            int x_8 = 8;
            Txt_resualt.Text += x_8.ToString();
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            if (Txt_resualt.Text == "0") { Txt_resualt.Clear(); }

            int x_9 = 9;
            Txt_resualt.Text += x_9.ToString();
        }

        private void txt_display_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            if (Txt_resualt.Text == "0") { Txt_resualt.Clear(); }

            int x_0 = 0;
            Txt_resualt.Text += x_0.ToString();
        }
    }
}
