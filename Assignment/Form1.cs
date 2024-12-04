namespace Assignment
{
    public partial class Form1 : Form
    {
        int number;
        public Form1()
        {
            InitializeComponent();
            Random random = new Random();
            number = random.Next(1, 1000);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
        }

        private void textBox1_KeyPress(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 4) textBox1.Text = null;
            else if (textBox1.Text.Length != 0)
            {
                Console.WriteLine(number);
                int boxText = int.Parse(textBox1.Text);
                if (boxText == number)
                {
                    this.BackColor = Color.Gray;
                    this.label3.Text = "Correct!";
                    this.textBox1.Enabled = false;
                }
                else if (boxText >= (number - 50)) 
                {
                    this.BackColor = Color.Red;
                    this.label3.Text = "Too low. try a higher number";
                }
                else
                {
                    this.label3.Text = "Too low. try a higher number";
                    this.BackColor = Color.Blue;
                }
            }
            else
            {
                this.label3.Text = "Guess result appears here.";
                this.BackColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = null;
            this.textBox1.Enabled = true;
            Random random = new Random();
            number = random.Next(1, 1000);
        }
    }
}
