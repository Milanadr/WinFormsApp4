using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            private void button1_Click(object sender, EventArgs e)

richTextBox1.ResetText(); // o��C�� RichTextBox // ���������� �� TextBox � �������

            if (string.IsNullOrEmpty(textBox1.Text))

                7 / ������ ����� � RichTextBox i ���������� �� ����� �����(�) richTextBox1.AppendText("������� 1: ��������\n");

else

                // ������ ����� � TextBox � RichTextBox � ���������� �� ����� ����� (\n)

                richTextBox1.AppendText("Ene���� 1:" + textBox1.Text + '\n'); if (string.IsNullOrEmpty(textBox2.Text))

                richTextBox1.AppendText("Ene���� 2: ��������\n"); richTextBox1.AppendText("En����� 2: textBox2.Text + '\n'); else

if (string.IsNullOrEmpty(textBox3.Text)) richTextBox1.AppendText("En����� 3: ��������\n");

            else

                richTextBox1.AppendText("Eneue�� 3: textBox3.Text + '\n');

if (string.IsNullOrEmpty(textBox4.Text)) richTextBox1.AppendText("Enem��� 4: ������O\n");
            else

                richTextBox1.AppendText("Ene�ew� 4:" + textBox4.Text + '\n');

            if (string.IsNullOrEmpty(textBox5.Text)) richTextBoxi.AppendText("������� 5: ��������\n");

            else richTextBox1.AppendText("Enesen� 5: textBox5.Text + '\n');

        }
        public partial class Form1 : Form


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}