namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ������� ������� ������
            char number = e.KeyChar;

            // ��������� �������. �����, ������� BackSpace � ������� � ASCII
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                // ��������� ���� ������� �������
                e.Handled = true;
            }
            
            //��������� ���� �� ��� �������
            if((textBox2.Text.Contains(',') == true) && (number == 44))
            {
                e.Handled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double numb = 0.0;
            numb = Convert.ToDouble(textBox2.Text);
            if(checkBox2.Checked == true)
            {
                numb = numb / 2.54;
            }
            else
            {
                numb = numb * 2.54;
            }
            label6.Text = numb.ToString();
        }
    }
}