namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// /////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

   //

        /// <summary>
        /// //////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        string CalTotal;
        int firstNum;
        int secondNum;
        String option;
        int result;

        private void num1_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "9";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            firstNum = int.Parse(textDisplay.Text);

            textDisplay.Clear(); // this clears the existing input when applying the secondNum
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            firstNum = int.Parse(textDisplay.Text);

            textDisplay.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            option = "*";
            firstNum = int.Parse(textDisplay.Text);

            textDisplay.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            option = "/";
            firstNum = int.Parse(textDisplay.Text);

            textDisplay.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textDisplay.Clear(); //A/C clears the whole thing
            result = (0);
            firstNum = (0);
            secondNum = (0);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondNum = int.Parse(textDisplay.Text);

            if (option == ("+"))
                result = firstNum + secondNum;
            if (option == ("-"))
                result = firstNum - secondNum;
            if (option == ("*"))
                result = firstNum * secondNum; 
            if (option == ("/"))
                result = firstNum / secondNum;
  
            textDisplay.Text = result + "";
        }
    }
}
