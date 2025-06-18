namespace WinFormsApp3
{
    public partial class Form1 : Form
    {

        String operation = "";
        double firstNumber = 0;
        bool isoperation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            RESULT.Text = "0";
            RESULT_L.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

            if (RESULT.Text == "0" || isoperation)
            {
                RESULT.Clear();
            }
            Button btn = (Button)sender;

            if (btn.Text == ".") {
                if (!RESULT.Text.Contains("."))
                {

                    RESULT.Text = RESULT.Text + btn.Text;
                }
            }
            else {
                RESULT.Text = RESULT.Text + btn.Text;
            }

              
            isoperation = false;
        }

        private void Operation(object sender, EventArgs e)
        {

            if (firstNumber != 0)
            {
                button19.PerformClick();
                Button btn = (Button)sender;
                operation = btn.Text;
                firstNumber = double.Parse(RESULT.Text);
                RESULT_L.Text = firstNumber + " " + operation;
                isoperation = true;

            }
            else
            {
                Button btn = (Button)sender;
                operation = btn.Text;
                firstNumber = double.Parse(RESULT.Text);
                RESULT_L.Text = firstNumber + " " + operation;
                isoperation = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            RESULT.Text = "0";

        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (operation) {
                case "+":

                    RESULT.Text = (firstNumber + double.Parse(RESULT.Text)).ToString();
                    break;

                case "-":

                    RESULT.Text = (firstNumber - double.Parse(RESULT.Text)).ToString();
                    break;

                case "*":

                    RESULT.Text = (firstNumber * double.Parse(RESULT.Text)).ToString();
                    break;

                case "/":

                    RESULT.Text = (firstNumber / double.Parse(RESULT.Text)).ToString();
                    break;
            }
        }
    }
}
