namespace FruitStand
{
    public partial class FruitStandForm : Form
    {
    /**
     * @author: K-Andre Harris
     * @date: February 13, 2025,
     * Chapter 3 Problem 10
     * ----------------------------------------------------------------------
     * This program keeps a total of the fruit that is purchased.
     * ----------------------------------------------------------------------
     */
        private decimal total = 0.00m; // Total
        public FruitStandForm()
        {
            InitializeComponent();
            total_txt.Text = "$0.00";
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            total_txt.Clear();
            total = 0.00m; // Reset total to zero
            total_txt.Text = "$0.00";
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close(); // Close the application
        }

        private void banana_img_Click(object sender, EventArgs e)
        {
            AddTotal(0.65m);
        }

        private void apple_img_Click(object sender, EventArgs e)
        {

            AddTotal(1.35m);
        }

        private void orange_img_Click(object sender, EventArgs e)
        {
            AddTotal(1.60m);
        }

        private void pear_img_Click(object sender, EventArgs e)
        {
           AddTotal(1.20m);
        }

        private void AddTotal(decimal price)
        {
            total += price; // Update total
            total_txt.Text = $"${total:F2}"; // Display total with two decimal places
        }
    }
}
