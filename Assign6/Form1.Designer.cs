namespace Assign6
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
            this.btnAnaSal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstBxSales = new System.Windows.Forms.ListBox();
            this.lblTotSales = new System.Windows.Forms.Label();
            this.lblAvgSalesVal = new System.Windows.Forms.Label();
            this.lblAvgSales = new System.Windows.Forms.Label();
            this.lblHighSalesVal = new System.Windows.Forms.Label();
            this.lblHighSales = new System.Windows.Forms.Label();
            this.lblTotSalesVal = new System.Windows.Forms.Label();
            this.lblLowSales = new System.Windows.Forms.Label();
            this.lvlLowSalesVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnaSal
            // 
            this.btnAnaSal.Location = new System.Drawing.Point(44, 235);
            this.btnAnaSal.Name = "btnAnaSal";
            this.btnAnaSal.Size = new System.Drawing.Size(109, 42);
            this.btnAnaSal.TabIndex = 0;
            this.btnAnaSal.Text = "Analyze Sales";
            this.btnAnaSal.UseVisualStyleBackColor = true;
            this.btnAnaSal.Click += new System.EventHandler(this.btnAnaSal_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(189, 235);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 42);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstBxSales
            // 
            this.lstBxSales.FormattingEnabled = true;
            this.lstBxSales.Location = new System.Drawing.Point(44, 33);
            this.lstBxSales.Name = "lstBxSales";
            this.lstBxSales.Size = new System.Drawing.Size(254, 173);
            this.lstBxSales.TabIndex = 2;
            // 
            // lblTotSales
            // 
            this.lblTotSales.AutoSize = true;
            this.lblTotSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotSales.Location = new System.Drawing.Point(330, 34);
            this.lblTotSales.Name = "lblTotSales";
            this.lblTotSales.Size = new System.Drawing.Size(77, 16);
            this.lblTotSales.TabIndex = 3;
            this.lblTotSales.Text = "Total Sales";
            // 
            // lblAvgSalesVal
            // 
            this.lblAvgSalesVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvgSalesVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgSalesVal.Location = new System.Drawing.Point(445, 85);
            this.lblAvgSalesVal.Name = "lblAvgSalesVal";
            this.lblAvgSalesVal.Size = new System.Drawing.Size(103, 19);
            this.lblAvgSalesVal.TabIndex = 4;
            // 
            // lblAvgSales
            // 
            this.lblAvgSales.AutoSize = true;
            this.lblAvgSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgSales.Location = new System.Drawing.Point(330, 86);
            this.lblAvgSales.Name = "lblAvgSales";
            this.lblAvgSales.Size = new System.Drawing.Size(98, 16);
            this.lblAvgSales.TabIndex = 5;
            this.lblAvgSales.Text = "Average Sales";
            // 
            // lblHighSalesVal
            // 
            this.lblHighSalesVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHighSalesVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighSalesVal.Location = new System.Drawing.Point(445, 135);
            this.lblHighSalesVal.Name = "lblHighSalesVal";
            this.lblHighSalesVal.Size = new System.Drawing.Size(103, 21);
            this.lblHighSalesVal.TabIndex = 6;
            // 
            // lblHighSales
            // 
            this.lblHighSales.AutoSize = true;
            this.lblHighSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighSales.Location = new System.Drawing.Point(330, 136);
            this.lblHighSales.Name = "lblHighSales";
            this.lblHighSales.Size = new System.Drawing.Size(92, 16);
            this.lblHighSales.TabIndex = 7;
            this.lblHighSales.Text = "Highest Sales";
            // 
            // lblTotSalesVal
            // 
            this.lblTotSalesVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotSalesVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotSalesVal.Location = new System.Drawing.Point(445, 33);
            this.lblTotSalesVal.Name = "lblTotSalesVal";
            this.lblTotSalesVal.Size = new System.Drawing.Size(103, 22);
            this.lblTotSalesVal.TabIndex = 8;
            this.lblTotSalesVal.Click += new System.EventHandler(this.lblHighSalesVal_Click);
            // 
            // lblLowSales
            // 
            this.lblLowSales.AutoSize = true;
            this.lblLowSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowSales.Location = new System.Drawing.Point(330, 187);
            this.lblLowSales.Name = "lblLowSales";
            this.lblLowSales.Size = new System.Drawing.Size(88, 16);
            this.lblLowSales.TabIndex = 9;
            this.lblLowSales.Text = "Lowest Sales";
            // 
            // lvlLowSalesVal
            // 
            this.lvlLowSalesVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvlLowSalesVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlLowSalesVal.Location = new System.Drawing.Point(445, 186);
            this.lvlLowSalesVal.Name = "lvlLowSalesVal";
            this.lvlLowSalesVal.Size = new System.Drawing.Size(103, 20);
            this.lvlLowSalesVal.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 323);
            this.Controls.Add(this.lvlLowSalesVal);
            this.Controls.Add(this.lblLowSales);
            this.Controls.Add(this.lblTotSalesVal);
            this.Controls.Add(this.lblHighSales);
            this.Controls.Add(this.lblHighSalesVal);
            this.Controls.Add(this.lblAvgSales);
            this.Controls.Add(this.lblAvgSalesVal);
            this.Controls.Add(this.lblTotSales);
            this.Controls.Add(this.lstBxSales);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAnaSal);
            this.Name = "Form1";
            this.Text = "Sales Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnaSal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstBxSales;
        private System.Windows.Forms.Label lblTotSales;
        private System.Windows.Forms.Label lblAvgSalesVal;
        private System.Windows.Forms.Label lblAvgSales;
        private System.Windows.Forms.Label lblHighSalesVal;
        private System.Windows.Forms.Label lblHighSales;
        private System.Windows.Forms.Label lblTotSalesVal;
        private System.Windows.Forms.Label lblLowSales;
        private System.Windows.Forms.Label lvlLowSalesVal;
    }
}

