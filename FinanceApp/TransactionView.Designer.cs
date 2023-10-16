
namespace FinanceApp
{
    partial class TransactionView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgTransactions = new System.Windows.Forms.DataGridView();
            this.btnUpdateTransaction = new System.Windows.Forms.Button();
            this.btnRetrieveTransactions = new System.Windows.Forms.Button();
            this.btnDeleteTransaction = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnOpenLogin = new System.Windows.Forms.Button();
            this.btnOpenWeeklySummary = new System.Windows.Forms.Button();
            this.btnOpenForecast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(118, 98);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(210, 26);
            this.txtAmount.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Transaction";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addTransaction);
            // 
            // dgTransactions
            // 
            this.dgTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransactions.Location = new System.Drawing.Point(33, 225);
            this.dgTransactions.Name = "dgTransactions";
            this.dgTransactions.RowHeadersWidth = 62;
            this.dgTransactions.RowTemplate.Height = 28;
            this.dgTransactions.Size = new System.Drawing.Size(723, 182);
            this.dgTransactions.TabIndex = 5;
            this.dgTransactions.SelectionChanged += new System.EventHandler(this.dgTransactions_SelectionChanged);
            // 
            // btnUpdateTransaction
            // 
            this.btnUpdateTransaction.Location = new System.Drawing.Point(380, 35);
            this.btnUpdateTransaction.Name = "btnUpdateTransaction";
            this.btnUpdateTransaction.Size = new System.Drawing.Size(170, 40);
            this.btnUpdateTransaction.TabIndex = 6;
            this.btnUpdateTransaction.Text = "Update Transaction";
            this.btnUpdateTransaction.UseVisualStyleBackColor = true;
            this.btnUpdateTransaction.Click += new System.EventHandler(this.updateTransaction);
            // 
            // btnRetrieveTransactions
            // 
            this.btnRetrieveTransactions.Location = new System.Drawing.Point(548, 92);
            this.btnRetrieveTransactions.Name = "btnRetrieveTransactions";
            this.btnRetrieveTransactions.Size = new System.Drawing.Size(208, 40);
            this.btnRetrieveTransactions.TabIndex = 7;
            this.btnRetrieveTransactions.Text = "Retrieve Transactions";
            this.btnRetrieveTransactions.UseVisualStyleBackColor = true;
            this.btnRetrieveTransactions.Click += new System.EventHandler(this.retrieveTransactions);
            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.Location = new System.Drawing.Point(572, 35);
            this.btnDeleteTransaction.Name = "btnDeleteTransaction";
            this.btnDeleteTransaction.Size = new System.Drawing.Size(184, 40);
            this.btnDeleteTransaction.TabIndex = 8;
            this.btnDeleteTransaction.Text = "Delete Transaction";
            this.btnDeleteTransaction.UseVisualStyleBackColor = true;
            this.btnDeleteTransaction.Click += new System.EventHandler(this.deleteTransaction);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "income",
            "expense"});
            this.cmbType.Location = new System.Drawing.Point(118, 42);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(210, 28);
            this.cmbType.TabIndex = 9;
            this.cmbType.Text = "-- Select Type --";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(644, 154);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 40);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.clearFields);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(118, 154);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(210, 26);
            this.dtpDate.TabIndex = 12;
            // 
            // btnOpenLogin
            // 
            this.btnOpenLogin.Location = new System.Drawing.Point(33, 439);
            this.btnOpenLogin.Name = "btnOpenLogin";
            this.btnOpenLogin.Size = new System.Drawing.Size(75, 40);
            this.btnOpenLogin.TabIndex = 13;
            this.btnOpenLogin.Text = "Logout";
            this.btnOpenLogin.UseVisualStyleBackColor = true;
            this.btnOpenLogin.Click += new System.EventHandler(this.showLoginForm);
            // 
            // btnOpenWeeklySummary
            // 
            this.btnOpenWeeklySummary.Location = new System.Drawing.Point(322, 439);
            this.btnOpenWeeklySummary.Name = "btnOpenWeeklySummary";
            this.btnOpenWeeklySummary.Size = new System.Drawing.Size(153, 40);
            this.btnOpenWeeklySummary.TabIndex = 14;
            this.btnOpenWeeklySummary.Text = "Weekly Summary";
            this.btnOpenWeeklySummary.UseVisualStyleBackColor = true;
            this.btnOpenWeeklySummary.Click += new System.EventHandler(this.showWeeklySummaryForm);
            // 
            // btnOpenForecast
            // 
            this.btnOpenForecast.Location = new System.Drawing.Point(661, 439);
            this.btnOpenForecast.Name = "btnOpenForecast";
            this.btnOpenForecast.Size = new System.Drawing.Size(95, 40);
            this.btnOpenForecast.TabIndex = 15;
            this.btnOpenForecast.Text = "Forecast";
            this.btnOpenForecast.UseVisualStyleBackColor = true;
            this.btnOpenForecast.Click += new System.EventHandler(this.showForecastForm);
            // 
            // TransactionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnOpenForecast);
            this.Controls.Add(this.btnOpenWeeklySummary);
            this.Controls.Add(this.btnOpenLogin);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnDeleteTransaction);
            this.Controls.Add(this.btnRetrieveTransactions);
            this.Controls.Add(this.btnUpdateTransaction);
            this.Controls.Add(this.dgTransactions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TransactionView";
            this.Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgTransactions;
        private System.Windows.Forms.Button btnUpdateTransaction;
        private System.Windows.Forms.Button btnRetrieveTransactions;
        private System.Windows.Forms.Button btnDeleteTransaction;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnOpenLogin;
        private System.Windows.Forms.Button btnOpenWeeklySummary;
        private System.Windows.Forms.Button btnOpenForecast;
    }
}