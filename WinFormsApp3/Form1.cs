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

richTextBox1.ResetText(); // oчуCмо RichTextBox // перевірясмо чи TextBox с порожнім

            if (string.IsNullOrEmpty(textBox1.Text))

                7 / додамо текст у RichTextBox i переходимо на новий рядок(л) richTextBox1.AppendText("Елемент 1: Порожньо\n");

else

                // додамо текст з TextBox у RichTextBox і переходимо на новий рядок (\n)

                richTextBox1.AppendText("Eneмент 1:" + textBox1.Text + '\n'); if (string.IsNullOrEmpty(textBox2.Text))

                richTextBox1.AppendText("Eneмент 2: Порожньо\n"); richTextBox1.AppendText("Enемент 2: textBox2.Text + '\n'); else

if (string.IsNullOrEmpty(textBox3.Text)) richTextBox1.AppendText("Enемент 3: Порожньо\n");

            else

                richTextBox1.AppendText("Eneueнт 3: textBox3.Text + '\n');

if (string.IsNullOrEmpty(textBox4.Text)) richTextBox1.AppendText("Enemент 4: ПорожьO\n");
            else

                richTextBox1.AppendText("Eneмewт 4:" + textBox4.Text + '\n');

            if (string.IsNullOrEmpty(textBox5.Text)) richTextBoxi.AppendText("Елемент 5: Порожньо\n");

            else richTextBox1.AppendText("Enesenт 5: textBox5.Text + '\n');

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