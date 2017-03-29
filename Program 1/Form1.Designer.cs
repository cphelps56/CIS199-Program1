namespace Program_1
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
            this.calculateBtn = new System.Windows.Forms.Button();
            this.squareFeetTextbox = new System.Windows.Forms.TextBox();
            this.numberOfCoatsTextbox = new System.Windows.Forms.TextBox();
            this.pricePerGallonTextbox = new System.Windows.Forms.TextBox();
            this.squareFeetWallLabel = new System.Windows.Forms.Label();
            this.numberOfCoatsLabel = new System.Windows.Forms.Label();
            this.pricePerGallonLabel = new System.Windows.Forms.Label();
            this.paintCostLabel = new System.Windows.Forms.Label();
            this.laborCostLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.numberOfGallonsLabel = new System.Windows.Forms.Label();
            this.totalSquareFeetLabel = new System.Windows.Forms.Label();
            this.laborHoursLabel = new System.Windows.Forms.Label();
            this.totalSquareFeetOutputLabel = new System.Windows.Forms.Label();
            this.totalCostOutputLabel = new System.Windows.Forms.Label();
            this.numberOfGallonsOutputLabel = new System.Windows.Forms.Label();
            this.laborHoursOutputLabel = new System.Windows.Forms.Label();
            this.paintCostOutputLabel = new System.Windows.Forms.Label();
            this.laborCostOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(115, 298);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 3;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // squareFeetTextbox
            // 
            this.squareFeetTextbox.Location = new System.Drawing.Point(166, 4);
            this.squareFeetTextbox.Name = "squareFeetTextbox";
            this.squareFeetTextbox.Size = new System.Drawing.Size(100, 20);
            this.squareFeetTextbox.TabIndex = 0;
            // 
            // numberOfCoatsTextbox
            // 
            this.numberOfCoatsTextbox.Location = new System.Drawing.Point(166, 34);
            this.numberOfCoatsTextbox.Name = "numberOfCoatsTextbox";
            this.numberOfCoatsTextbox.Size = new System.Drawing.Size(100, 20);
            this.numberOfCoatsTextbox.TabIndex = 1;
            // 
            // pricePerGallonTextbox
            // 
            this.pricePerGallonTextbox.Location = new System.Drawing.Point(166, 64);
            this.pricePerGallonTextbox.Name = "pricePerGallonTextbox";
            this.pricePerGallonTextbox.Size = new System.Drawing.Size(100, 20);
            this.pricePerGallonTextbox.TabIndex = 2;
            // 
            // squareFeetWallLabel
            // 
            this.squareFeetWallLabel.AutoSize = true;
            this.squareFeetWallLabel.Location = new System.Drawing.Point(30, 7);
            this.squareFeetWallLabel.Name = "squareFeetWallLabel";
            this.squareFeetWallLabel.Size = new System.Drawing.Size(130, 13);
            this.squareFeetWallLabel.TabIndex = 18;
            this.squareFeetWallLabel.Text = "Square feet of wall space:";
            // 
            // numberOfCoatsLabel
            // 
            this.numberOfCoatsLabel.AutoSize = true;
            this.numberOfCoatsLabel.Location = new System.Drawing.Point(34, 37);
            this.numberOfCoatsLabel.Name = "numberOfCoatsLabel";
            this.numberOfCoatsLabel.Size = new System.Drawing.Size(126, 13);
            this.numberOfCoatsLabel.TabIndex = 17;
            this.numberOfCoatsLabel.Text = "Number of coats of paint:";
            // 
            // pricePerGallonLabel
            // 
            this.pricePerGallonLabel.AutoSize = true;
            this.pricePerGallonLabel.Location = new System.Drawing.Point(39, 67);
            this.pricePerGallonLabel.Name = "pricePerGallonLabel";
            this.pricePerGallonLabel.Size = new System.Drawing.Size(121, 13);
            this.pricePerGallonLabel.TabIndex = 16;
            this.pricePerGallonLabel.Text = "Price of paint per gallon:";
            // 
            // paintCostLabel
            // 
            this.paintCostLabel.AutoSize = true;
            this.paintCostLabel.Location = new System.Drawing.Point(107, 200);
            this.paintCostLabel.Name = "paintCostLabel";
            this.paintCostLabel.Size = new System.Drawing.Size(69, 13);
            this.paintCostLabel.TabIndex = 12;
            this.paintCostLabel.Text = "Cost of paint:";
            // 
            // laborCostLabel
            // 
            this.laborCostLabel.AutoSize = true;
            this.laborCostLabel.Location = new System.Drawing.Point(107, 230);
            this.laborCostLabel.Name = "laborCostLabel";
            this.laborCostLabel.Size = new System.Drawing.Size(69, 13);
            this.laborCostLabel.TabIndex = 11;
            this.laborCostLabel.Text = "Cost of labor:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(118, 260);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(58, 13);
            this.totalCostLabel.TabIndex = 10;
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // numberOfGallonsLabel
            // 
            this.numberOfGallonsLabel.AutoSize = true;
            this.numberOfGallonsLabel.Location = new System.Drawing.Point(2, 140);
            this.numberOfGallonsLabel.Name = "numberOfGallonsLabel";
            this.numberOfGallonsLabel.Size = new System.Drawing.Size(174, 13);
            this.numberOfGallonsLabel.TabIndex = 14;
            this.numberOfGallonsLabel.Text = "Number of gallons of paint required:";
            // 
            // totalSquareFeetLabel
            // 
            this.totalSquareFeetLabel.AutoSize = true;
            this.totalSquareFeetLabel.Location = new System.Drawing.Point(86, 110);
            this.totalSquareFeetLabel.Name = "totalSquareFeetLabel";
            this.totalSquareFeetLabel.Size = new System.Drawing.Size(90, 13);
            this.totalSquareFeetLabel.TabIndex = 15;
            this.totalSquareFeetLabel.Text = "Total square feet:";
            // 
            // laborHoursLabel
            // 
            this.laborHoursLabel.AutoSize = true;
            this.laborHoursLabel.Location = new System.Drawing.Point(59, 170);
            this.laborHoursLabel.Name = "laborHoursLabel";
            this.laborHoursLabel.Size = new System.Drawing.Size(117, 13);
            this.laborHoursLabel.TabIndex = 13;
            this.laborHoursLabel.Text = "Hours of labor required:";
            // 
            // totalSquareFeetOutputLabel
            // 
            this.totalSquareFeetOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSquareFeetOutputLabel.Location = new System.Drawing.Point(182, 105);
            this.totalSquareFeetOutputLabel.Name = "totalSquareFeetOutputLabel";
            this.totalSquareFeetOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.totalSquareFeetOutputLabel.TabIndex = 4;
            this.totalSquareFeetOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCostOutputLabel
            // 
            this.totalCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOutputLabel.Location = new System.Drawing.Point(182, 255);
            this.totalCostOutputLabel.Name = "totalCostOutputLabel";
            this.totalCostOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.totalCostOutputLabel.TabIndex = 9;
            this.totalCostOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfGallonsOutputLabel
            // 
            this.numberOfGallonsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfGallonsOutputLabel.Location = new System.Drawing.Point(182, 135);
            this.numberOfGallonsOutputLabel.Name = "numberOfGallonsOutputLabel";
            this.numberOfGallonsOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.numberOfGallonsOutputLabel.TabIndex = 5;
            this.numberOfGallonsOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laborHoursOutputLabel
            // 
            this.laborHoursOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborHoursOutputLabel.Location = new System.Drawing.Point(182, 165);
            this.laborHoursOutputLabel.Name = "laborHoursOutputLabel";
            this.laborHoursOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.laborHoursOutputLabel.TabIndex = 6;
            this.laborHoursOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paintCostOutputLabel
            // 
            this.paintCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintCostOutputLabel.Location = new System.Drawing.Point(182, 195);
            this.paintCostOutputLabel.Name = "paintCostOutputLabel";
            this.paintCostOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.paintCostOutputLabel.TabIndex = 7;
            this.paintCostOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laborCostOutputLabel
            // 
            this.laborCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborCostOutputLabel.Location = new System.Drawing.Point(182, 225);
            this.laborCostOutputLabel.Name = "laborCostOutputLabel";
            this.laborCostOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.laborCostOutputLabel.TabIndex = 8;
            this.laborCostOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 333);
            this.Controls.Add(this.laborCostOutputLabel);
            this.Controls.Add(this.paintCostOutputLabel);
            this.Controls.Add(this.laborHoursOutputLabel);
            this.Controls.Add(this.numberOfGallonsOutputLabel);
            this.Controls.Add(this.totalCostOutputLabel);
            this.Controls.Add(this.totalSquareFeetOutputLabel);
            this.Controls.Add(this.laborHoursLabel);
            this.Controls.Add(this.totalSquareFeetLabel);
            this.Controls.Add(this.numberOfGallonsLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.laborCostLabel);
            this.Controls.Add(this.paintCostLabel);
            this.Controls.Add(this.pricePerGallonLabel);
            this.Controls.Add(this.numberOfCoatsLabel);
            this.Controls.Add(this.squareFeetWallLabel);
            this.Controls.Add(this.pricePerGallonTextbox);
            this.Controls.Add(this.numberOfCoatsTextbox);
            this.Controls.Add(this.squareFeetTextbox);
            this.Controls.Add(this.calculateBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox squareFeetTextbox;
        private System.Windows.Forms.TextBox numberOfCoatsTextbox;
        private System.Windows.Forms.TextBox pricePerGallonTextbox;
        private System.Windows.Forms.Label squareFeetWallLabel;
        private System.Windows.Forms.Label numberOfCoatsLabel;
        private System.Windows.Forms.Label pricePerGallonLabel;
        private System.Windows.Forms.Label paintCostLabel;
        private System.Windows.Forms.Label laborCostLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label numberOfGallonsLabel;
        private System.Windows.Forms.Label totalSquareFeetLabel;
        private System.Windows.Forms.Label laborHoursLabel;
        private System.Windows.Forms.Label totalSquareFeetOutputLabel;
        private System.Windows.Forms.Label totalCostOutputLabel;
        private System.Windows.Forms.Label numberOfGallonsOutputLabel;
        private System.Windows.Forms.Label laborHoursOutputLabel;
        private System.Windows.Forms.Label paintCostOutputLabel;
        private System.Windows.Forms.Label laborCostOutputLabel;
    }
}

