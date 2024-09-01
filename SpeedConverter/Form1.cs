namespace SpeedConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // Constants

            const double KPH_TO_MPH = 0.6214;
            const double MPH_TO_KPH = 1.60934;

            // Variables
            double kph;        // Kilometers per hour
            double mph;     // Miles per hour
                            //  double speedCounter = 0;

            double startSpeed = 0, endSpeed = 0, speedInterval = 0;

            //input validation
            if ((double.TryParse(txtStartSpeed.Text, out startSpeed)))
            {
                double.TryParse(txtStartSpeed.Text, out startSpeed);
            }
            else
            {
                MessageBox.Show("Invalid data in Start Speed");
            }

            if ((double.TryParse(txtEndSpeed.Text, out endSpeed)))
            {
                double.TryParse(txtEndSpeed.Text, out endSpeed);
            }
            else
            {
                MessageBox.Show("Invalid data in End Speed");
            }
            //if ((double.TryParse(txtSpeedInterval.Text, out speedInterval)))
            //{
            //    double.TryParse(txtSpeedInterval.Text, out speedInterval);
            //}
            //else
            //{
            //    MessageBox.Show("Invalid data in Speed Interval");
            //}


            if (rbKphToMph.Checked)
            {


                // Display the table of speeds.
                for (int i = (int)startSpeed; i <= endSpeed; i++)
                {
                    // Calculate miles per hour.
                    mph = i * KPH_TO_MPH;

                    // Display the conversion.
                    outputListBox.Items.Add(i.ToString("n1") +
                        " KPH is the same as " + mph.ToString("n1") + " MPH");
                }

            }

            if (rbMphToKph.Checked)
            {
                // Display the speed table.
                for (int i = (int)startSpeed; i <= endSpeed; i++)
                {
                    // Calculate miles per hour.
                    kph = i * MPH_TO_KPH;

                    // Display the conversion.
                    outputListBox.Items.Add(i.ToString("n1") +
                        " MPH is the same as " + kph.ToString("n1") + " KPH");
                }


            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void outputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
        }
    }
}