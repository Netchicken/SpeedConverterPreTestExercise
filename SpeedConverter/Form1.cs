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
            const int START_SPEED = 60;
            const int END_SPEED = 130;
            const int INTERVAL = 10;
            const double KPH_TO_MPH = 0.6214;
            const double MPH_TO_KPH = 1.60934;

            // Variables
            int kph;        // Kilometers per hour
            double mph;     // Miles per hour

            // Display the table of speeds.
            for (kph = START_SPEED; kph <= END_SPEED; kph += INTERVAL)
            {
                // Calculate miles per hour.
                mph = kph * KPH_TO_MPH;

                // Display the conversion.
                outputListBox.Items.Add(kph.ToString("n1") +
                    " KPH is the same as " + mph.ToString("n1") + " MPH");
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
    }
}