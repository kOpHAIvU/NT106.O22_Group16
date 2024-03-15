namespace Window_Form_Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        bool isOpePerform = false;
        String previousButtonText = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void numClick(object sender, EventArgs e)
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
            previousButtonText = button.Text;
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {   //Khi tiếp tục ấn phép tính mà không ấn dấu = thì sẽ tự động
                //thực hiện phép tính và đẩy sang phép tính mới
                //Nếu ấn dấu 2 lần thì sẽ chỉ nhận dấu ở lần sau cùng
                if (previousButtonText == "+" || previousButtonText == "-" || previousButtonText == "*" || previousButtonText == "/") { }
                else
                {
                    equal.PerformClick();
                    operation = button.Text;
                }
            }

                operation = button.Text;
                result = Double.Parse(resultText.Text);
                isOpePerform = true;
                previousButtonText = button.Text;
        }

        private void equalClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (operation == "+")
            {
                resultText.Text = (result + Double.Parse(resultText.Text)).ToString();
                return;
            }

            if (operation == "-")
            {
                resultText.Text = (result - Double.Parse(resultText.Text)).ToString();
                return;
            }

            if (operation == "*")
            {
                resultText.Text = (result * Double.Parse(resultText.Text)).ToString();
                return;
            }

            resultText.Text = (result / Double.Parse(resultText.Text)).ToString();
            previousButtonText = button.Text;
        }

        private void CEClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            resultText.Text = "0";
            previousButtonText = button.Text;
        }

        private void CClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            resultText.Text = "0";
            result = 0;
            previousButtonText = button.Text;
        }
    }
}

