namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        DateTime dt1, dt2;
        long dd1, dd2;
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Today.ToString());

            //MessageBox.Show(DateTime.Now.ToString());
            //MessageBox.Show(dateTimePicker1.Value.ToString());
            //dateTimePicker1.Value
            //textBox1.Text = DateTime.Now.Ticks.ToString();
            dd1 = DateTime.Now.Ticks;
            dt1 = new DateTime(dd1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = (((DateTime.Now.Ticks/TimeSpan.TicksPerDay) - (dateTimePicker1.Value.Ticks / TimeSpan.TicksPerDay))/365).ToString()+" YIL ";
            textBox1.Text += (((DateTime.Now.Ticks / TimeSpan.TicksPerDay) - (dateTimePicker1.Value.Ticks / TimeSpan.TicksPerDay) % 365)/30 ).ToString()+ " AY ";
            if ((DateTime.Now.DayOfYear - dateTimePicker1.Value.DayOfYear) <0)
            textBox1.Text += (30+(DateTime.Now.DayOfYear - dateTimePicker1.Value.DayOfYear) % 30).ToString()+ " GÜN ";
            else
                textBox1.Text += ((DateTime.Now.DayOfYear - dateTimePicker1.Value.DayOfYear) % 30).ToString() + " GÜN ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dd2 = DateTime.Now.Ticks;
            dt2 = new DateTime(dd2);
            textBox1.Text = (dd2 - dd1).ToString();
            textBox2.Text = (dt2 - dt1).ToString();
            textBox2.Text = ((dt2 - dt1)/TimeSpan.TicksPerMillisecond).ToString();

        }
    }
}