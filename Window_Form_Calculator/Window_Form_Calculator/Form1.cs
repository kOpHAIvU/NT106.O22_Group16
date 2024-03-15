namespace Window_Form_Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        bool isOpePerform = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (resultText.Text == "0" || isOpePerform)
                resultText.Clear();     //Xóa số 0 khi bắt đầu gõ số đầu tiên và xóa hết số khi chọn phép tính
            isOpePerform = false;
            Button button = (Button)sender;
            if (button.Text == ".")     //không cho phép xuất hiện nhiều dấu .
            {
                if (!resultText.Text.Contains("."))
                    resultText.Text += button.Text;
            }
            else
                resultText.Text = resultText.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {   //Khi tiếp tục ấn phép tính mà không ấn dấu = thì sẽ tự động
                //thực hiện phép tính và đẩy sang phép tính mới
                equal.PerformClick();
                operation = button.Text;
                isOpePerform = true;
            }
            operation = button.Text;
            result = Double.Parse(resultText.Text);
            isOpePerform = true;
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
            switch (operation)
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

        private void resultText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

