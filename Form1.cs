namespace PizzaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float calculateSizePrice()
        {
            if (rdoSmall.Checked) return Convert.ToSingle(rdoSmall.Tag);
            else if (rdoMed.Checked) return Convert.ToSingle(rdoMed.Tag);
            else if (rdoLarge.Checked) return Convert.ToSingle(rdoLarge.Tag);
            else return 0;
        }

        float calculateCrustTypePrice()
        {
            if (rdoThinCrust.Checked) return Convert.ToSingle(rdoThinCrust.Tag);
            else if (rdoThickCrust.Checked) return Convert.ToSingle(rdoThickCrust.Tag);
            else return 0;
        }

        float calculateToppingsPrice()
        {
            float price = 0;
            if (chkChess.Checked) price += Convert.ToSingle(chkChess.Tag);
            if (chkOnion.Checked) price += Convert.ToSingle(chkOnion.Tag);
            if (chkOlives.Checked) price += Convert.ToSingle(chkOlives.Tag);
            if (chkMusho.Checked) price += Convert.ToSingle(chkMusho.Tag);
            if (chkGreenPappers.Checked) price += Convert.ToSingle(chkGreenPappers.Tag);
            if (chkTomato.Checked) price += Convert.ToSingle(chkTomato.Tag);
            return price;
        }

        float calculateTotalPrice()
        {
            return calculateSizePrice() + calculateCrustTypePrice() + calculateToppingsPrice();
        }

        void UpdateTotalPrice()
        {
            lblPrice.Text = "$" + calculateTotalPrice().ToString("0.00");
        }

        private void rdoSmall_CheckedChanged(object sender, EventArgs e)
        {
            lblSize.Text = rdoSmall.Text;
            UpdateTotalPrice();
        }

        private void rdoMed_CheckedChanged(object sender, EventArgs e)
        {
            lblSize.Text = rdoMed.Text;
            UpdateTotalPrice();
        }

        private void rdoLarge_CheckedChanged(object sender, EventArgs e)
        {
            lblSize.Text = rdoLarge.Text;
            UpdateTotalPrice();
        }

        private void rdoThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustType.Text = rdoThinCrust.Text;
            UpdateTotalPrice();
        }

        private void rdoThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustType.Text = rdoThickCrust.Text;
            UpdateTotalPrice();
        }

        private void rdoEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lblToEat.Text = rdoEatIn.Text;
            UpdateTotalPrice();
        }

        private void rdoTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lblToEat.Text = rdoTakeOut.Text;
            UpdateTotalPrice();
        }

        void UpdateToppings()
        {
            List<string> selectedToppings = new List<string>();

            if (chkChess.Checked) selectedToppings.Add(chkChess.Text);
            if (chkOnion.Checked) selectedToppings.Add(chkOnion.Text);
            if (chkMusho.Checked) selectedToppings.Add(chkMusho.Text);
            if (chkOlives.Checked) selectedToppings.Add(chkOlives.Text);
            if (chkTomato.Checked) selectedToppings.Add(chkTomato.Text);
            if (chkGreenPappers.Checked) selectedToppings.Add(chkGreenPappers.Text);

            lblToppings.Text = selectedToppings.Count > 0
                ? string.Join("; ", selectedToppings)
                : "No Toppings";
        }

        private void chkChess_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }

        private void chkMusho_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }

        private void chkTomato_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }

        private void chkGreenPappers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Pizza Ordered Successfully");

                grpSize.Enabled = false;
                grpCrustType.Enabled = false;
                grpToppings.Enabled = false;
                grpToEat.Enabled = false;
                btnOrderPizza.Enabled = false;
            }
            else
            {
                MessageBox.Show("Pizza Order is canceled");
            }
        }

        void resetForm()
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                grpSize.Enabled = true;
                grpCrustType.Enabled = true;
                grpToppings.Enabled = true;
                grpToEat.Enabled = true;

                rdoSmall.Checked = false;
                rdoMed.Checked = false;
                rdoLarge.Checked = false;
                rdoThinCrust.Checked = false;
                rdoThickCrust.Checked = false;
                rdoTakeOut.Checked = false;
                rdoEatIn.Checked = false;

                chkOlives.Checked = false;
                chkChess.Checked = false;
                chkMusho.Checked = false;
                chkOnion.Checked = false;
                chkTomato.Checked = false;
                chkGreenPappers.Checked = false;

                lblSize.Text = "";
                lblCrustType.Text = "";
                lblToppings.Text = "";
                lblToEat.Text = "";
                lblPrice.Text = "$0.00";

                btnOrderPizza.Enabled = true;
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoMed.Checked = true;
            rdoThinCrust.Checked = true;
            rdoTakeOut.Checked = true;
            UpdateToppings();
            UpdateTotalPrice();
        }
    }
}
