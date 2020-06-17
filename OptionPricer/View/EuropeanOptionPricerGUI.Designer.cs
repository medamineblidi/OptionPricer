namespace OptionPricer
{
    partial class EuropeanOptionPricerGUI
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.StockPriceTextBox = new System.Windows.Forms.TextBox();
            this.RiskFreeInterestRateTextBox = new System.Windows.Forms.TextBox();
            this.StdDerivUnderlyingTextBox = new System.Windows.Forms.TextBox();
            this.strikePriceTextBox = new System.Windows.Forms.TextBox();
            this.timeToMatTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.stockPriceLabel = new System.Windows.Forms.Label();
            this.strikePriceLabel = new System.Windows.Forms.Label();
            this.timeToMatLabel = new System.Windows.Forms.Label();
            this.stdDeviationUnderlyingLabel = new System.Windows.Forms.Label();
            this.riskFreeInterestRateLabel = new System.Windows.Forms.Label();
            this.Pricebutton = new System.Windows.Forms.Button();
            this.optionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.optionTypeLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.floatPrecisionTextBox = new System.Windows.Forms.TextBox();
            this.floatPrecisionLabel = new System.Windows.Forms.Label();
            this.exStockPriceLabel = new System.Windows.Forms.Label();
            this.exStrikePriceLabel = new System.Windows.Forms.Label();
            this.exTimeToMatLabel = new System.Windows.Forms.Label();
            this.exStdDeviationUndLabel = new System.Windows.Forms.Label();
            this.exRiskFreeInterstRateLabel = new System.Windows.Forms.Label();
            this.exFloatPrecisionLabel = new System.Windows.Forms.Label();
            this.cultureLabel = new System.Windows.Forms.Label();
            this.cultureComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // StockPriceTextBox
            // 
            this.StockPriceTextBox.Location = new System.Drawing.Point(267, 96);
            this.StockPriceTextBox.Name = "StockPriceTextBox";
            this.StockPriceTextBox.Size = new System.Drawing.Size(154, 22);
            this.StockPriceTextBox.TabIndex = 1;
            // 
            // RiskFreeInterestRateTextBox
            // 
            this.RiskFreeInterestRateTextBox.Location = new System.Drawing.Point(267, 215);
            this.RiskFreeInterestRateTextBox.Name = "RiskFreeInterestRateTextBox";
            this.RiskFreeInterestRateTextBox.Size = new System.Drawing.Size(154, 22);
            this.RiskFreeInterestRateTextBox.TabIndex = 5;
            // 
            // StdDerivUnderlyingTextBox
            // 
            this.StdDerivUnderlyingTextBox.Location = new System.Drawing.Point(267, 183);
            this.StdDerivUnderlyingTextBox.Name = "StdDerivUnderlyingTextBox";
            this.StdDerivUnderlyingTextBox.Size = new System.Drawing.Size(154, 22);
            this.StdDerivUnderlyingTextBox.TabIndex = 4;
            // 
            // strikePriceTextBox
            // 
            this.strikePriceTextBox.Location = new System.Drawing.Point(267, 124);
            this.strikePriceTextBox.Name = "strikePriceTextBox";
            this.strikePriceTextBox.Size = new System.Drawing.Size(154, 22);
            this.strikePriceTextBox.TabIndex = 2;
            // 
            // timeToMatTextBox
            // 
            this.timeToMatTextBox.Location = new System.Drawing.Point(267, 155);
            this.timeToMatTextBox.Name = "timeToMatTextBox";
            this.timeToMatTextBox.Size = new System.Drawing.Size(154, 22);
            this.timeToMatTextBox.TabIndex = 3;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(40, 30);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(199, 17);
            this.inputLabel.TabIndex = 5;
            this.inputLabel.Text = "Please enter input parameters";
            // 
            // stockPriceLabel
            // 
            this.stockPriceLabel.AutoSize = true;
            this.stockPriceLabel.Location = new System.Drawing.Point(183, 99);
            this.stockPriceLabel.Name = "stockPriceLabel";
            this.stockPriceLabel.Size = new System.Drawing.Size(78, 17);
            this.stockPriceLabel.TabIndex = 6;
            this.stockPriceLabel.Text = "Stock price";
            // 
            // strikePriceLabel
            // 
            this.strikePriceLabel.AutoSize = true;
            this.strikePriceLabel.Location = new System.Drawing.Point(183, 127);
            this.strikePriceLabel.Name = "strikePriceLabel";
            this.strikePriceLabel.Size = new System.Drawing.Size(79, 17);
            this.strikePriceLabel.TabIndex = 7;
            this.strikePriceLabel.Text = "Strike price";
            // 
            // timeToMatLabel
            // 
            this.timeToMatLabel.AutoSize = true;
            this.timeToMatLabel.Location = new System.Drawing.Point(99, 158);
            this.timeToMatLabel.Name = "timeToMatLabel";
            this.timeToMatLabel.Size = new System.Drawing.Size(163, 17);
            this.timeToMatLabel.TabIndex = 8;
            this.timeToMatLabel.Text = "Time to maturity in years";
            // 
            // stdDeviationUnderlyingLabel
            // 
            this.stdDeviationUnderlyingLabel.AutoSize = true;
            this.stdDeviationUnderlyingLabel.Location = new System.Drawing.Point(11, 186);
            this.stdDeviationUnderlyingLabel.Name = "stdDeviationUnderlyingLabel";
            this.stdDeviationUnderlyingLabel.Size = new System.Drawing.Size(250, 17);
            this.stdDeviationUnderlyingLabel.TabIndex = 9;
            this.stdDeviationUnderlyingLabel.Text = "Standard deviation of underlying stock";
            // 
            // riskFreeInterestRateLabel
            // 
            this.riskFreeInterestRateLabel.AutoSize = true;
            this.riskFreeInterestRateLabel.Location = new System.Drawing.Point(117, 218);
            this.riskFreeInterestRateLabel.Name = "riskFreeInterestRateLabel";
            this.riskFreeInterestRateLabel.Size = new System.Drawing.Size(145, 17);
            this.riskFreeInterestRateLabel.TabIndex = 10;
            this.riskFreeInterestRateLabel.Text = "Risk-free interest rate";
            // 
            // Pricebutton
            // 
            this.Pricebutton.Location = new System.Drawing.Point(315, 331);
            this.Pricebutton.Name = "Pricebutton";
            this.Pricebutton.Size = new System.Drawing.Size(106, 26);
            this.Pricebutton.TabIndex = 8;
            this.Pricebutton.Text = "Price";
            this.Pricebutton.UseVisualStyleBackColor = true;
            this.Pricebutton.Click += new System.EventHandler(this.Pricebutton_Click);
            // 
            // optionTypeComboBox
            // 
            this.optionTypeComboBox.FormattingEnabled = true;
            this.optionTypeComboBox.Items.AddRange(new object[] {
            "Call",
            "Put"});
            this.optionTypeComboBox.Location = new System.Drawing.Point(267, 248);
            this.optionTypeComboBox.Name = "optionTypeComboBox";
            this.optionTypeComboBox.Size = new System.Drawing.Size(154, 24);
            this.optionTypeComboBox.TabIndex = 6;
            // 
            // optionTypeLabel
            // 
            this.optionTypeLabel.AutoSize = true;
            this.optionTypeLabel.Location = new System.Drawing.Point(180, 248);
            this.optionTypeLabel.Name = "optionTypeLabel";
            this.optionTypeLabel.Size = new System.Drawing.Size(81, 17);
            this.optionTypeLabel.TabIndex = 14;
            this.optionTypeLabel.Text = "Option type";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(615, 312);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 17);
            this.resultLabel.TabIndex = 15;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(183, 384);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(106, 26);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear Input";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(315, 383);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(106, 27);
            this.historyButton.TabIndex = 10;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = true;
            // 
            // floatPrecisionTextBox
            // 
            this.floatPrecisionTextBox.Location = new System.Drawing.Point(268, 286);
            this.floatPrecisionTextBox.Name = "floatPrecisionTextBox";
            this.floatPrecisionTextBox.Size = new System.Drawing.Size(154, 22);
            this.floatPrecisionTextBox.TabIndex = 7;
            this.floatPrecisionTextBox.Text = "4";
            // 
            // floatPrecisionLabel
            // 
            this.floatPrecisionLabel.AutoSize = true;
            this.floatPrecisionLabel.Location = new System.Drawing.Point(161, 289);
            this.floatPrecisionLabel.Name = "floatPrecisionLabel";
            this.floatPrecisionLabel.Size = new System.Drawing.Size(101, 17);
            this.floatPrecisionLabel.TabIndex = 18;
            this.floatPrecisionLabel.Text = "Float Precision";
            // 
            // exStockPriceLabel
            // 
            this.exStockPriceLabel.AutoSize = true;
            this.exStockPriceLabel.Location = new System.Drawing.Point(441, 99);
            this.exStockPriceLabel.Name = "exStockPriceLabel";
            this.exStockPriceLabel.Size = new System.Drawing.Size(56, 17);
            this.exStockPriceLabel.TabIndex = 19;
            this.exStockPriceLabel.Text = "(ex. 50)";
            // 
            // exStrikePriceLabel
            // 
            this.exStrikePriceLabel.AutoSize = true;
            this.exStrikePriceLabel.Location = new System.Drawing.Point(441, 127);
            this.exStrikePriceLabel.Name = "exStrikePriceLabel";
            this.exStrikePriceLabel.Size = new System.Drawing.Size(56, 17);
            this.exStrikePriceLabel.TabIndex = 20;
            this.exStrikePriceLabel.Text = "(ex. 55)";
            // 
            // exTimeToMatLabel
            // 
            this.exTimeToMatLabel.AutoSize = true;
            this.exTimeToMatLabel.Location = new System.Drawing.Point(441, 158);
            this.exTimeToMatLabel.Name = "exTimeToMatLabel";
            this.exTimeToMatLabel.Size = new System.Drawing.Size(48, 17);
            this.exTimeToMatLabel.TabIndex = 21;
            this.exTimeToMatLabel.Text = "(ex. 1)";
            // 
            // exStdDeviationUndLabel
            // 
            this.exStdDeviationUndLabel.AutoSize = true;
            this.exStdDeviationUndLabel.Location = new System.Drawing.Point(441, 186);
            this.exStdDeviationUndLabel.Name = "exStdDeviationUndLabel";
            this.exStdDeviationUndLabel.Size = new System.Drawing.Size(60, 17);
            this.exStdDeviationUndLabel.TabIndex = 22;
            this.exStdDeviationUndLabel.Text = "(ex. 0,2)";
            // 
            // exRiskFreeInterstRateLabel
            // 
            this.exRiskFreeInterstRateLabel.AutoSize = true;
            this.exRiskFreeInterstRateLabel.Location = new System.Drawing.Point(441, 218);
            this.exRiskFreeInterstRateLabel.Name = "exRiskFreeInterstRateLabel";
            this.exRiskFreeInterstRateLabel.Size = new System.Drawing.Size(68, 17);
            this.exRiskFreeInterstRateLabel.TabIndex = 23;
            this.exRiskFreeInterstRateLabel.Text = "(ex. 0,09)";
            // 
            // exFloatPrecisionLabel
            // 
            this.exFloatPrecisionLabel.AutoSize = true;
            this.exFloatPrecisionLabel.Location = new System.Drawing.Point(441, 289);
            this.exFloatPrecisionLabel.Name = "exFloatPrecisionLabel";
            this.exFloatPrecisionLabel.Size = new System.Drawing.Size(48, 17);
            this.exFloatPrecisionLabel.TabIndex = 24;
            this.exFloatPrecisionLabel.Text = "(ex. 4)";
            // 
            // cultureLabel
            // 
            this.cultureLabel.AutoSize = true;
            this.cultureLabel.Location = new System.Drawing.Point(208, 69);
            this.cultureLabel.Name = "cultureLabel";
            this.cultureLabel.Size = new System.Drawing.Size(53, 17);
            this.cultureLabel.TabIndex = 25;
            this.cultureLabel.Text = "Culture";
            // 
            // cultureComboBox
            // 
            this.cultureComboBox.FormattingEnabled = true;
            this.cultureComboBox.Items.AddRange(new object[] {
            "en-GB",
            "fr-FR",
            "es-ES"});
            this.cultureComboBox.Location = new System.Drawing.Point(268, 66);
            this.cultureComboBox.Name = "cultureComboBox";
            this.cultureComboBox.Size = new System.Drawing.Size(153, 24);
            this.cultureComboBox.TabIndex = 0;
            // 
            // EuropeanOptionPricerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cultureComboBox);
            this.Controls.Add(this.cultureLabel);
            this.Controls.Add(this.exFloatPrecisionLabel);
            this.Controls.Add(this.exRiskFreeInterstRateLabel);
            this.Controls.Add(this.exStdDeviationUndLabel);
            this.Controls.Add(this.exTimeToMatLabel);
            this.Controls.Add(this.exStrikePriceLabel);
            this.Controls.Add(this.exStockPriceLabel);
            this.Controls.Add(this.floatPrecisionLabel);
            this.Controls.Add(this.floatPrecisionTextBox);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.optionTypeLabel);
            this.Controls.Add(this.optionTypeComboBox);
            this.Controls.Add(this.Pricebutton);
            this.Controls.Add(this.riskFreeInterestRateLabel);
            this.Controls.Add(this.stdDeviationUnderlyingLabel);
            this.Controls.Add(this.timeToMatLabel);
            this.Controls.Add(this.strikePriceLabel);
            this.Controls.Add(this.stockPriceLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.timeToMatTextBox);
            this.Controls.Add(this.strikePriceTextBox);
            this.Controls.Add(this.StdDerivUnderlyingTextBox);
            this.Controls.Add(this.RiskFreeInterestRateTextBox);
            this.Controls.Add(this.StockPriceTextBox);
            this.Name = "EuropeanOptionPricerGUI";
            this.Text = "Options Pricer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StockPriceTextBox;
        private System.Windows.Forms.TextBox RiskFreeInterestRateTextBox;
        private System.Windows.Forms.TextBox StdDerivUnderlyingTextBox;
        private System.Windows.Forms.TextBox strikePriceTextBox;
        private System.Windows.Forms.TextBox timeToMatTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label stockPriceLabel;
        private System.Windows.Forms.Label strikePriceLabel;
        private System.Windows.Forms.Label timeToMatLabel;
        private System.Windows.Forms.Label stdDeviationUnderlyingLabel;
        private System.Windows.Forms.Label riskFreeInterestRateLabel;
        private System.Windows.Forms.Button Pricebutton;
        private System.Windows.Forms.ComboBox optionTypeComboBox;
        private System.Windows.Forms.Label optionTypeLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.TextBox floatPrecisionTextBox;
        private System.Windows.Forms.Label floatPrecisionLabel;
        private System.Windows.Forms.Label exStockPriceLabel;
        private System.Windows.Forms.Label exStrikePriceLabel;
        private System.Windows.Forms.Label exTimeToMatLabel;
        private System.Windows.Forms.Label exStdDeviationUndLabel;
        private System.Windows.Forms.Label exRiskFreeInterstRateLabel;
        private System.Windows.Forms.Label exFloatPrecisionLabel;
        private System.Windows.Forms.Label cultureLabel;
        private System.Windows.Forms.ComboBox cultureComboBox;
    }
}

