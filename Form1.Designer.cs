namespace PizzaProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpSize = new GroupBox();
            rdoMed = new RadioButton();
            rdoLarge = new RadioButton();
            rdoSmall = new RadioButton();
            grpCrustType = new GroupBox();
            rdoThickCrust = new RadioButton();
            rdoThinCrust = new RadioButton();
            grpToppings = new GroupBox();
            chkTomato = new CheckBox();
            chkGreenPappers = new CheckBox();
            chkMusho = new CheckBox();
            chkOnion = new CheckBox();
            chkChess = new CheckBox();
            chkOlives = new CheckBox();
            grpToEat = new GroupBox();
            rdoTakeOut = new RadioButton();
            rdoEatIn = new RadioButton();
            btnOrderPizza = new Button();
            btnResetForm = new Button();
            grpOrderSummary = new GroupBox();
            lblPrice = new Label();
            lblToEat = new Label();
            lblCrustType = new Label();
            lblToppings = new Label();
            lblSize = new Label();
            lblTotalPrice = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            lbl5 = new Label();
            lbl4 = new Label();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            label6 = new Label();
            grpSize.SuspendLayout();
            grpCrustType.SuspendLayout();
            grpToppings.SuspendLayout();
            grpToEat.SuspendLayout();
            grpOrderSummary.SuspendLayout();
            SuspendLayout();
            // 
            // grpSize
            // 
            grpSize.Controls.Add(rdoMed);
            grpSize.Controls.Add(rdoLarge);
            grpSize.Controls.Add(rdoSmall);
            grpSize.Location = new Point(59, 82);
            grpSize.Name = "grpSize";
            grpSize.Size = new Size(190, 159);
            grpSize.TabIndex = 0;
            grpSize.TabStop = false;
            grpSize.Text = "Size";
            // 
            // rdoMed
            // 
            rdoMed.AutoSize = true;
            rdoMed.Checked = true;
            rdoMed.Font = new Font("Segoe UI", 7F);
            rdoMed.Location = new Point(43, 78);
            rdoMed.Name = "rdoMed";
            rdoMed.Size = new Size(85, 23);
            rdoMed.TabIndex = 4;
            rdoMed.TabStop = true;
            rdoMed.Tag = "30";
            rdoMed.Text = "Medium";
            rdoMed.UseVisualStyleBackColor = true;
            rdoMed.CheckedChanged += rdoMed_CheckedChanged;
            // 
            // rdoLarge
            // 
            rdoLarge.AutoSize = true;
            rdoLarge.Font = new Font("Segoe UI", 7F);
            rdoLarge.Location = new Point(43, 126);
            rdoLarge.Name = "rdoLarge";
            rdoLarge.Size = new Size(68, 23);
            rdoLarge.TabIndex = 3;
            rdoLarge.Tag = "50";
            rdoLarge.Text = "Large";
            rdoLarge.UseVisualStyleBackColor = true;
            rdoLarge.CheckedChanged += rdoLarge_CheckedChanged;
            // 
            // rdoSmall
            // 
            rdoSmall.AutoSize = true;
            rdoSmall.Font = new Font("Segoe UI", 7F);
            rdoSmall.Location = new Point(43, 30);
            rdoSmall.Name = "rdoSmall";
            rdoSmall.Size = new Size(66, 23);
            rdoSmall.TabIndex = 2;
            rdoSmall.Tag = "20";
            rdoSmall.Text = "Small";
            rdoSmall.UseVisualStyleBackColor = true;
            rdoSmall.CheckedChanged += rdoSmall_CheckedChanged;
            // 
            // grpCrustType
            // 
            grpCrustType.Controls.Add(rdoThickCrust);
            grpCrustType.Controls.Add(rdoThinCrust);
            grpCrustType.Location = new Point(59, 307);
            grpCrustType.Name = "grpCrustType";
            grpCrustType.Size = new Size(190, 168);
            grpCrustType.TabIndex = 1;
            grpCrustType.TabStop = false;
            grpCrustType.Text = "Crust Type";
            // 
            // rdoThickCrust
            // 
            rdoThickCrust.AutoSize = true;
            rdoThickCrust.Font = new Font("Segoe UI", 7F);
            rdoThickCrust.Location = new Point(43, 101);
            rdoThickCrust.Name = "rdoThickCrust";
            rdoThickCrust.Size = new Size(102, 23);
            rdoThickCrust.TabIndex = 7;
            rdoThickCrust.Tag = "10";
            rdoThickCrust.Text = "Thick Crust";
            rdoThickCrust.UseVisualStyleBackColor = true;
            // 
            // rdoThinCrust
            // 
            rdoThinCrust.AutoSize = true;
            rdoThinCrust.Checked = true;
            rdoThinCrust.Font = new Font("Segoe UI", 7F);
            rdoThinCrust.Location = new Point(43, 53);
            rdoThinCrust.Name = "rdoThinCrust";
            rdoThinCrust.Size = new Size(97, 23);
            rdoThinCrust.TabIndex = 5;
            rdoThinCrust.TabStop = true;
            rdoThinCrust.Text = "Thin Crust";
            rdoThinCrust.UseVisualStyleBackColor = true;
            rdoThinCrust.CheckedChanged += rdoThinCrust_CheckedChanged;
            // 
            // grpToppings
            // 
            grpToppings.Controls.Add(chkTomato);
            grpToppings.Controls.Add(chkGreenPappers);
            grpToppings.Controls.Add(chkMusho);
            grpToppings.Controls.Add(chkOnion);
            grpToppings.Controls.Add(chkChess);
            grpToppings.Controls.Add(chkOlives);
            grpToppings.Location = new Point(376, 91);
            grpToppings.Name = "grpToppings";
            grpToppings.Size = new Size(326, 159);
            grpToppings.TabIndex = 5;
            grpToppings.TabStop = false;
            grpToppings.Text = "Toppings";
            // 
            // chkTomato
            // 
            chkTomato.AutoSize = true;
            chkTomato.Font = new Font("Segoe UI", 7F);
            chkTomato.Location = new Point(34, 126);
            chkTomato.Name = "chkTomato";
            chkTomato.Size = new Size(95, 23);
            chkTomato.TabIndex = 8;
            chkTomato.Tag = "2";
            chkTomato.Text = "TomaToes";
            chkTomato.UseVisualStyleBackColor = true;
            chkTomato.CheckedChanged += chkTomato_CheckedChanged;
            // 
            // chkGreenPappers
            // 
            chkGreenPappers.AutoSize = true;
            chkGreenPappers.Font = new Font("Segoe UI", 7F);
            chkGreenPappers.Location = new Point(188, 126);
            chkGreenPappers.Name = "chkGreenPappers";
            chkGreenPappers.Size = new Size(125, 23);
            chkGreenPappers.TabIndex = 11;
            chkGreenPappers.Tag = "2";
            chkGreenPappers.Text = "Green Pappers";
            chkGreenPappers.UseVisualStyleBackColor = true;
            chkGreenPappers.CheckedChanged += chkGreenPappers_CheckedChanged;
            // 
            // chkMusho
            // 
            chkMusho.AutoSize = true;
            chkMusho.Font = new Font("Segoe UI", 7F);
            chkMusho.Location = new Point(34, 79);
            chkMusho.Name = "chkMusho";
            chkMusho.Size = new Size(109, 23);
            chkMusho.TabIndex = 7;
            chkMusho.Tag = "2";
            chkMusho.Text = "Mushrooms";
            chkMusho.UseVisualStyleBackColor = true;
            chkMusho.CheckedChanged += chkMusho_CheckedChanged;
            // 
            // chkOnion
            // 
            chkOnion.AutoSize = true;
            chkOnion.Font = new Font("Segoe UI", 7F);
            chkOnion.Location = new Point(188, 32);
            chkOnion.Name = "chkOnion";
            chkOnion.Size = new Size(73, 23);
            chkOnion.TabIndex = 9;
            chkOnion.Tag = "2";
            chkOnion.Text = "Onion";
            chkOnion.UseVisualStyleBackColor = true;
            chkOnion.CheckedChanged += chkOnion_CheckedChanged;
            // 
            // chkChess
            // 
            chkChess.AutoSize = true;
            chkChess.Font = new Font("Segoe UI", 7F);
            chkChess.Location = new Point(34, 32);
            chkChess.Name = "chkChess";
            chkChess.Size = new Size(105, 23);
            chkChess.TabIndex = 6;
            chkChess.Tag = "2";
            chkChess.Text = "Extra Chess";
            chkChess.UseVisualStyleBackColor = true;
            chkChess.CheckedChanged += chkChess_CheckedChanged;
            // 
            // chkOlives
            // 
            chkOlives.AutoSize = true;
            chkOlives.Font = new Font("Segoe UI", 7F);
            chkOlives.Location = new Point(188, 79);
            chkOlives.Name = "chkOlives";
            chkOlives.Size = new Size(72, 23);
            chkOlives.TabIndex = 10;
            chkOlives.Tag = "2";
            chkOlives.Text = "Olives";
            chkOlives.UseVisualStyleBackColor = true;
            chkOlives.CheckedChanged += chkOlives_CheckedChanged;
            // 
            // grpToEat
            // 
            grpToEat.Controls.Add(rdoTakeOut);
            grpToEat.Controls.Add(rdoEatIn);
            grpToEat.Location = new Point(382, 316);
            grpToEat.Name = "grpToEat";
            grpToEat.Size = new Size(326, 92);
            grpToEat.TabIndex = 12;
            grpToEat.TabStop = false;
            grpToEat.Text = "Where To Eat";
            // 
            // rdoTakeOut
            // 
            rdoTakeOut.AutoSize = true;
            rdoTakeOut.Checked = true;
            rdoTakeOut.Font = new Font("Segoe UI", 7F);
            rdoTakeOut.Location = new Point(182, 44);
            rdoTakeOut.Name = "rdoTakeOut";
            rdoTakeOut.Size = new Size(88, 23);
            rdoTakeOut.TabIndex = 8;
            rdoTakeOut.TabStop = true;
            rdoTakeOut.Text = "Take Out";
            rdoTakeOut.UseVisualStyleBackColor = true;
            rdoTakeOut.CheckedChanged += rdoTakeOut_CheckedChanged;
            // 
            // rdoEatIn
            // 
            rdoEatIn.AutoSize = true;
            rdoEatIn.Font = new Font("Segoe UI", 7F);
            rdoEatIn.Location = new Point(34, 44);
            rdoEatIn.Name = "rdoEatIn";
            rdoEatIn.Size = new Size(69, 23);
            rdoEatIn.TabIndex = 8;
            rdoEatIn.Tag = "";
            rdoEatIn.Text = "Eat In";
            rdoEatIn.UseVisualStyleBackColor = true;
            rdoEatIn.CheckedChanged += rdoEatIn_CheckedChanged;
            // 
            // btnOrderPizza
            // 
            btnOrderPizza.Location = new Point(382, 441);
            btnOrderPizza.Name = "btnOrderPizza";
            btnOrderPizza.Size = new Size(112, 34);
            btnOrderPizza.TabIndex = 13;
            btnOrderPizza.Text = "Order Pizza";
            btnOrderPizza.UseVisualStyleBackColor = true;
            btnOrderPizza.Click += btnOrderPizza_Click;
            // 
            // btnResetForm
            // 
            btnResetForm.Location = new Point(596, 441);
            btnResetForm.Name = "btnResetForm";
            btnResetForm.Size = new Size(112, 34);
            btnResetForm.TabIndex = 14;
            btnResetForm.Text = "Reset Form";
            btnResetForm.UseVisualStyleBackColor = true;
            btnResetForm.Click += btnResetForm_Click;
            // 
            // grpOrderSummary
            // 
            grpOrderSummary.Controls.Add(lblPrice);
            grpOrderSummary.Controls.Add(lblToEat);
            grpOrderSummary.Controls.Add(lblCrustType);
            grpOrderSummary.Controls.Add(lblToppings);
            grpOrderSummary.Controls.Add(lblSize);
            grpOrderSummary.Controls.Add(lblTotalPrice);
            grpOrderSummary.Controls.Add(label10);
            grpOrderSummary.Controls.Add(label9);
            grpOrderSummary.Controls.Add(label8);
            grpOrderSummary.Controls.Add(label7);
            grpOrderSummary.Controls.Add(lbl5);
            grpOrderSummary.Controls.Add(lbl4);
            grpOrderSummary.Controls.Add(lbl3);
            grpOrderSummary.Controls.Add(lbl2);
            grpOrderSummary.Controls.Add(lbl1);
            grpOrderSummary.Location = new Point(829, 91);
            grpOrderSummary.Name = "grpOrderSummary";
            grpOrderSummary.Size = new Size(326, 464);
            grpOrderSummary.TabIndex = 12;
            grpOrderSummary.TabStop = false;
            grpOrderSummary.Text = "Order Summary";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Stencil", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.MediumBlue;
            lblPrice.Location = new Point(136, 405);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(55, 38);
            lblPrice.TabIndex = 20;
            lblPrice.Text = "$0";
            // 
            // lblToEat
            // 
            lblToEat.AutoSize = true;
            lblToEat.Location = new Point(121, 342);
            lblToEat.Name = "lblToEat";
            lblToEat.Size = new Size(81, 25);
            lblToEat.TabIndex = 19;
            lblToEat.Text = "No Place";
            // 
            // lblCrustType
            // 
            lblCrustType.AutoSize = true;
            lblCrustType.Location = new Point(121, 250);
            lblCrustType.Name = "lblCrustType";
            lblCrustType.Size = new Size(82, 25);
            lblCrustType.TabIndex = 18;
            lblCrustType.Text = "No Crust";
            // 
            // lblToppings
            // 
            lblToppings.Location = new Point(56, 117);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(264, 99);
            lblToppings.TabIndex = 17;
            lblToppings.Text = "No Toppings";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(121, 32);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(72, 25);
            lblSize.TabIndex = 16;
            lblSize.Text = "No Size";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(130, 393);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(0, 25);
            lblTotalPrice.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(130, 317);
            label10.Name = "label10";
            label10.Size = new Size(0, 25);
            label10.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(130, 225);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(130, 141);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(130, 32);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 9;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(41, 380);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(95, 25);
            lbl5.TabIndex = 8;
            lbl5.Text = "Total Price:";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(41, 303);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(119, 25);
            lbl4.TabIndex = 6;
            lbl4.Text = "Where To Eat:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(41, 216);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(99, 25);
            lbl3.TabIndex = 4;
            lbl3.Text = "Crust Type:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(41, 79);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(89, 25);
            lbl2.TabIndex = 2;
            lbl2.Text = "Toppings:";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(41, 32);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(47, 25);
            lbl1.TabIndex = 0;
            lbl1.Text = "Size:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(317, 9);
            label6.Name = "label6";
            label6.Size = new Size(469, 60);
            label6.TabIndex = 15;
            label6.Text = "Make Your PIZZA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 592);
            Controls.Add(label6);
            Controls.Add(grpOrderSummary);
            Controls.Add(btnResetForm);
            Controls.Add(btnOrderPizza);
            Controls.Add(grpToEat);
            Controls.Add(grpToppings);
            Controls.Add(grpCrustType);
            Controls.Add(grpSize);
            Name = "Form1";
            Text = "Small";
            Load += Form1_Load;
            grpSize.ResumeLayout(false);
            grpSize.PerformLayout();
            grpCrustType.ResumeLayout(false);
            grpCrustType.PerformLayout();
            grpToppings.ResumeLayout(false);
            grpToppings.PerformLayout();
            grpToEat.ResumeLayout(false);
            grpToEat.PerformLayout();
            grpOrderSummary.ResumeLayout(false);
            grpOrderSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpSize;
        private GroupBox grpCrustType;
        private RadioButton rdoMed;
        private RadioButton rdoLarge;
        private RadioButton rdoSmall;
        private RadioButton rdoThickCrust;
        private RadioButton rdoThinCrust;
        private GroupBox grpToppings;
        private RadioButton rdoEatIn;
        private RadioButton rdoTakeOut;
        private CheckBox chkTomato;
        private CheckBox chkGreenPappers;
        private CheckBox chkMusho;
        private CheckBox chkOnion;
        private CheckBox chkChess;
        private CheckBox chkOlives;
        private GroupBox grpToEat;
        private Button btnOrderPizza;
        private Button btnResetForm;
        private GroupBox grpOrderSummary;
        private Label lbl3;
        private Label lbl2;
        private Label lbl1;
        private Label lbl5;
        private Label lbl4;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label lblTotalPrice;
        private Label label10;
        private Label label9;
        private Label lblSize;
        private Label lblToppings;
        private Label lblCrustType;
        private Label lblToEat;
        private Label lblPrice;
    }
}
