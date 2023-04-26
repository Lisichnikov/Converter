namespace Converter
{
    public partial class Конвертер : Form
    {
        public Конвертер()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);

            // из сантиметров
            if (radioButton1.Checked && radioButton5.Checked)
            {
                textBox2.Text = $"{a}";
            }
            if (radioButton1.Checked && radioButton7.Checked)
            {
                textBox2.Text = $"{a * 0.393701}";
            }
            if (radioButton1.Checked && radioButton8.Checked)
            {
                textBox2.Text = $"{a * 0.0328084}";
            }
            if (radioButton1.Checked && radioButton6.Checked)
            {
                textBox2.Text = $"{a * 0.0109361}";
            }

            // из дюймов
            if (radioButton2.Checked && radioButton5.Checked)
            {
                textBox2.Text = $"{a * 2.54}";
            }
            if (radioButton2.Checked && radioButton7.Checked)
            {
                textBox2.Text = $"{a}";
            }
            if (radioButton2.Checked && radioButton8.Checked)
            {
                textBox2.Text = $"{a * 0.0833333}";
            }
            if (radioButton2.Checked && radioButton6.Checked)
            {
                textBox2.Text = $"{a * 0.0277778}";
            }

            // из футов
            if (radioButton3.Checked && radioButton5.Checked)
            {
                textBox2.Text = $"{a * 30.48}";
            }
            if (radioButton3.Checked && radioButton7.Checked)
            {
                textBox2.Text = $"{a * 12}";
            }
            if (radioButton3.Checked && radioButton8.Checked)
            {
                textBox2.Text = $"{a}";
            }
            if (radioButton3.Checked && radioButton6.Checked)
            {
                textBox2.Text = $"{a * 0.333333}";
            }

            // из ярдов
            if (radioButton4.Checked && radioButton5.Checked)
            {
                textBox2.Text = $"{a * 91.44}";
            }
            if (radioButton4.Checked && radioButton7.Checked)
            {
                textBox2.Text = $"{a * 36}";
            }
            if (radioButton4.Checked && radioButton8.Checked)
            {
                textBox2.Text = $"{a * 3}";
            }
            if (radioButton4.Checked && radioButton6.Checked)
            {
                textBox2.Text = $"{a}";
            }
        }
    }
}