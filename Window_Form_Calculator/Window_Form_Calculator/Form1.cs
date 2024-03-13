namespace Window_Form_Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (resultText.Text == "0")
                resultText.Clear();
            Button button = (Button)sender;
            resultText.Text = resultText.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(resultText.Text);
        }

        private void buttonCE(object sender, EventArgs e)
        {
            resultText.Text = "0";
        }

        private void buttonC(object sender, EventArgs e)
        {
            resultText.Text = "0";
            result = 0;
        }

        private void button_equal(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    resultText.Text = (result + Double.Parse(resultText.Text)).ToString();
                    break;
                case "-":
                    resultText.Text = (result - Double.Parse(resultText.Text)).ToString();
                    break;
                case "*":
                    resultText.Text = (result * Double.Parse(resultText.Text)).ToString();
                    break;
                case "/":
                    resultText.Text = (result / Double.Parse(resultText.Text)).ToString();
                    break;
            }
        }
    }
}
