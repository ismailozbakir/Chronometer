namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int salise, second, minute, hour = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            digitScreen.Text = $"{hour} : {minute} : {second} : {salise}";
            salise++;

            if(salise == 60)
            {
                second++;
                salise = 0;
            }

            if (second == 60)
            {

                minute++;
                second = 0;
            }
            if (minute == 60)
            {
                hour++;
                minute = 0;
            }
        }
    }
}