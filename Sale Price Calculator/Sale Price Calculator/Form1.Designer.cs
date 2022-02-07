﻿
namespace Sale_Price_Calculator
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
            this.originalPriceLabel = new System.Windows.Forms.Label();
            this.discPercentLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.outputSalePriceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originalPriceLabel
            // 
            this.originalPriceLabel.AutoSize = true;
            this.originalPriceLabel.BackColor = System.Drawing.Color.Snow;
            this.originalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalPriceLabel.Location = new System.Drawing.Point(43, 28);
            this.originalPriceLabel.Name = "originalPriceLabel";
            this.originalPriceLabel.Size = new System.Drawing.Size(204, 18);
            this.originalPriceLabel.TabIndex = 1;
            this.originalPriceLabel.Text = "ENTER ITEM\'S ORIGINAL PRICE:\r\n";
            this.originalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // discPercentLabel
            // 
            this.discPercentLabel.AutoSize = true;
            this.discPercentLabel.BackColor = System.Drawing.Color.Snow;
            this.discPercentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discPercentLabel.Location = new System.Drawing.Point(19, 66);
            this.discPercentLabel.Name = "discPercentLabel";
            this.discPercentLabel.Size = new System.Drawing.Size(228, 18);
            this.discPercentLabel.TabIndex = 2;
            this.discPercentLabel.Text = "ENTER ITEM\'S DISCOUNT PERCENT:\r\n";
            this.discPercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.Snow;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(75, 118);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(172, 18);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "CALCULATED SALE PRICE:";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Snow;
            this.textBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.textBox1.Location = new System.Drawing.Point(274, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Snow;
            this.textBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.textBox2.Location = new System.Drawing.Point(274, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputSalePriceLabel
            // 
            this.outputSalePriceLabel.BackColor = System.Drawing.Color.Snow;
            this.outputSalePriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputSalePriceLabel.Location = new System.Drawing.Point(274, 110);
            this.outputSalePriceLabel.Name = "outputSalePriceLabel";
            this.outputSalePriceLabel.Size = new System.Drawing.Size(100, 25);
            this.outputSalePriceLabel.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Snow;
            this.calculateButton.Location = new System.Drawing.Point(24, 166);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(104, 66);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "CALCULATE SALE PRICE";
            this.calculateButton.UseVisualStyleBackColor = false;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Snow;
            this.clearButton.Location = new System.Drawing.Point(146, 166);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 66);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "CLEAR DATA";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Snow;
            this.exitButton.Location = new System.Drawing.Point(268, 166);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(104, 66);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "EXIT CALCULATOR PROGRAM";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 257);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputSalePriceLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.discPercentLabel);
            this.Controls.Add(this.originalPriceLabel);
            this.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Firebrick;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originalPriceLabel;
        private System.Windows.Forms.Label discPercentLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label outputSalePriceLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

