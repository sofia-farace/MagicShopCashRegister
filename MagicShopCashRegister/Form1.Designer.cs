namespace MagicShopCashRegister
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.wandsLabel = new System.Windows.Forms.Label();
            this.cauldronsLabel = new System.Windows.Forms.Label();
            this.cloackLabel = new System.Windows.Forms.Label();
            this.wandsInput = new System.Windows.Forms.TextBox();
            this.cauldronsInput = new System.Windows.Forms.TextBox();
            this.cloaksInput = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.easterEggLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Purple;
            this.titleLabel.Font = new System.Drawing.Font("Curlz MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(-3, -1);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(659, 75);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "  The Magic Shop";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wandsLabel
            // 
            this.wandsLabel.AutoSize = true;
            this.wandsLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wandsLabel.ForeColor = System.Drawing.Color.Black;
            this.wandsLabel.Location = new System.Drawing.Point(29, 94);
            this.wandsLabel.Name = "wandsLabel";
            this.wandsLabel.Size = new System.Drawing.Size(157, 21);
            this.wandsLabel.TabIndex = 1;
            this.wandsLabel.Text = "Magic Wands:";
            // 
            // cauldronsLabel
            // 
            this.cauldronsLabel.AutoSize = true;
            this.cauldronsLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cauldronsLabel.Location = new System.Drawing.Point(29, 124);
            this.cauldronsLabel.Name = "cauldronsLabel";
            this.cauldronsLabel.Size = new System.Drawing.Size(137, 21);
            this.cauldronsLabel.TabIndex = 2;
            this.cauldronsLabel.Text = "Cauldrons:";
            // 
            // cloackLabel
            // 
            this.cloackLabel.AutoSize = true;
            this.cloackLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloackLabel.Location = new System.Drawing.Point(29, 154);
            this.cloackLabel.Name = "cloackLabel";
            this.cloackLabel.Size = new System.Drawing.Size(95, 21);
            this.cloackLabel.TabIndex = 3;
            this.cloackLabel.Text = "Cloaks:";
            // 
            // wandsInput
            // 
            this.wandsInput.BackColor = System.Drawing.Color.Violet;
            this.wandsInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wandsInput.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wandsInput.Location = new System.Drawing.Point(212, 94);
            this.wandsInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wandsInput.Name = "wandsInput";
            this.wandsInput.Size = new System.Drawing.Size(72, 22);
            this.wandsInput.TabIndex = 4;
            // 
            // cauldronsInput
            // 
            this.cauldronsInput.BackColor = System.Drawing.Color.Violet;
            this.cauldronsInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cauldronsInput.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cauldronsInput.Location = new System.Drawing.Point(212, 124);
            this.cauldronsInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cauldronsInput.Name = "cauldronsInput";
            this.cauldronsInput.Size = new System.Drawing.Size(72, 22);
            this.cauldronsInput.TabIndex = 5;
            // 
            // cloaksInput
            // 
            this.cloaksInput.BackColor = System.Drawing.Color.Violet;
            this.cloaksInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cloaksInput.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloaksInput.Location = new System.Drawing.Point(212, 154);
            this.cloaksInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cloaksInput.Name = "cloaksInput";
            this.cloaksInput.Size = new System.Drawing.Size(72, 22);
            this.cloaksInput.TabIndex = 6;
            // 
            // calcButton
            // 
            this.calcButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.calcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(26, 194);
            this.calcButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(260, 31);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "CALCULATE";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(29, 239);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(117, 21);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(29, 271);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(52, 21);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(29, 302);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(78, 21);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total:";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.Location = new System.Drawing.Point(167, 239);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(117, 21);
            this.subtotalOutput.TabIndex = 11;
            this.subtotalOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // taxOutput
            // 
            this.taxOutput.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(167, 271);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(117, 21);
            this.taxOutput.TabIndex = 12;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalOutput
            // 
            this.totalOutput.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(167, 302);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(117, 21);
            this.totalOutput.TabIndex = 13;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.Black;
            this.changeButton.Location = new System.Drawing.Point(24, 358);
            this.changeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(260, 31);
            this.changeButton.TabIndex = 14;
            this.changeButton.Text = "CALCULATE CHANGE";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(25, 399);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(99, 21);
            this.changeLabel.TabIndex = 15;
            this.changeLabel.Text = "Change:";
            // 
            // changeOutput
            // 
            this.changeOutput.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(167, 399);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(117, 21);
            this.changeOutput.TabIndex = 16;
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // receiptButton
            // 
            this.receiptButton.Enabled = false;
            this.receiptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.ForeColor = System.Drawing.Color.Black;
            this.receiptButton.Location = new System.Drawing.Point(24, 434);
            this.receiptButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(260, 31);
            this.receiptButton.TabIndex = 17;
            this.receiptButton.Text = "PRINT RECEIPT";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Plum;
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(341, 94);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(279, 326);
            this.outputLabel.TabIndex = 18;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(29, 332);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(120, 21);
            this.tenderedLabel.TabIndex = 19;
            this.tenderedLabel.Text = "Tendered:";
            // 
            // tenderedInput
            // 
            this.tenderedInput.BackColor = System.Drawing.Color.Violet;
            this.tenderedInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tenderedInput.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.Location = new System.Drawing.Point(212, 332);
            this.tenderedInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(72, 22);
            this.tenderedInput.TabIndex = 20;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Enabled = false;
            this.newOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.ForeColor = System.Drawing.Color.Black;
            this.newOrderButton.Location = new System.Drawing.Point(341, 423);
            this.newOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(279, 31);
            this.newOrderButton.TabIndex = 21;
            this.newOrderButton.Text = "NEW MAGICAL ORDER";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // easterEggLabel
            // 
            this.easterEggLabel.BackColor = System.Drawing.Color.Purple;
            this.easterEggLabel.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easterEggLabel.Location = new System.Drawing.Point(341, 19);
            this.easterEggLabel.Name = "easterEggLabel";
            this.easterEggLabel.Size = new System.Drawing.Size(279, 45);
            this.easterEggLabel.TabIndex = 22;
            this.easterEggLabel.Text = "*ATTENTION: DO NOT PERFORM DANGEROUS SPELLS*\r\n\r\n";
            this.easterEggLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.BackgroundImage = global::MagicShopCashRegister.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(312, 476);
            this.Controls.Add(this.easterEggLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.cloaksInput);
            this.Controls.Add(this.cauldronsInput);
            this.Controls.Add(this.wandsInput);
            this.Controls.Add(this.cloackLabel);
            this.Controls.Add(this.cauldronsLabel);
            this.Controls.Add(this.wandsLabel);
            this.Controls.Add(this.titleLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Magic Shop Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label wandsLabel;
        private System.Windows.Forms.Label cauldronsLabel;
        private System.Windows.Forms.Label cloackLabel;
        private System.Windows.Forms.TextBox wandsInput;
        private System.Windows.Forms.TextBox cauldronsInput;
        private System.Windows.Forms.TextBox cloaksInput;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label easterEggLabel;
    }
}

