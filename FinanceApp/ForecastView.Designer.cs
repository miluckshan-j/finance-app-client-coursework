
namespace FinanceApp
{
    partial class ForecastView
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
            this.dtForecast = new System.Windows.Forms.DateTimePicker();
            this.btnForecast = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExpectedIncome = new System.Windows.Forms.Label();
            this.lblExpectedExpense = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income and Expense Forecast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // dtForecast
            // 
            this.dtForecast.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtForecast.Location = new System.Drawing.Point(105, 76);
            this.dtForecast.Name = "dtForecast";
            this.dtForecast.Size = new System.Drawing.Size(278, 26);
            this.dtForecast.TabIndex = 2;
            // 
            // btnForecast
            // 
            this.btnForecast.Location = new System.Drawing.Point(411, 71);
            this.btnForecast.Name = "btnForecast";
            this.btnForecast.Size = new System.Drawing.Size(87, 40);
            this.btnForecast.TabIndex = 3;
            this.btnForecast.Text = "Forecast";
            this.btnForecast.UseVisualStyleBackColor = true;
            this.btnForecast.Click += new System.EventHandler(this.forecast);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Expected Income";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Expected Expense";
            // 
            // lblExpectedIncome
            // 
            this.lblExpectedIncome.AutoSize = true;
            this.lblExpectedIncome.Location = new System.Drawing.Point(209, 151);
            this.lblExpectedIncome.Name = "lblExpectedIncome";
            this.lblExpectedIncome.Size = new System.Drawing.Size(31, 20);
            this.lblExpectedIncome.TabIndex = 6;
            this.lblExpectedIncome.Text = "0 $";
            // 
            // lblExpectedExpense
            // 
            this.lblExpectedExpense.AutoSize = true;
            this.lblExpectedExpense.Location = new System.Drawing.Point(209, 195);
            this.lblExpectedExpense.Name = "lblExpectedExpense";
            this.lblExpectedExpense.Size = new System.Drawing.Size(31, 20);
            this.lblExpectedExpense.TabIndex = 7;
            this.lblExpectedExpense.Text = "0 $";
            // 
            // ForecastView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 249);
            this.Controls.Add(this.lblExpectedExpense);
            this.Controls.Add(this.lblExpectedIncome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnForecast);
            this.Controls.Add(this.dtForecast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ForecastView";
            this.Text = "Forecast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtForecast;
        private System.Windows.Forms.Button btnForecast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblExpectedIncome;
        private System.Windows.Forms.Label lblExpectedExpense;
    }
}