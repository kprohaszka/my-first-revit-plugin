
namespace MyFirstRevitPlugin
{
    partial class GenerateWallForm
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
            this.ActionCancelButton = new System.Windows.Forms.Button();
            this.GenerateWallButton = new System.Windows.Forms.Button();
            this.InformativeLabel = new System.Windows.Forms.Label();
            this.XCoordinateLabel = new System.Windows.Forms.Label();
            this.YCoordinateLabel = new System.Windows.Forms.Label();
            this.XCoordinateTextBox1 = new System.Windows.Forms.TextBox();
            this.XCoordinateTextBox2 = new System.Windows.Forms.TextBox();
            this.YCoordinateTextBox1 = new System.Windows.Forms.TextBox();
            this.YCoordinateTextBox2 = new System.Windows.Forms.TextBox();
            this.InformativeLabel2 = new System.Windows.Forms.Label();
            this.InformativeLabel4 = new System.Windows.Forms.Label();
            this.InformativeLabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ActionCancelButton
            // 
            this.ActionCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionCancelButton.Location = new System.Drawing.Point(119, 340);
            this.ActionCancelButton.Name = "ActionCancelButton";
            this.ActionCancelButton.Size = new System.Drawing.Size(207, 72);
            this.ActionCancelButton.TabIndex = 2;
            this.ActionCancelButton.Text = "Cancel";
            this.ActionCancelButton.UseVisualStyleBackColor = true;
            // 
            // GenerateWallButton
            // 
            this.GenerateWallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateWallButton.Location = new System.Drawing.Point(453, 340);
            this.GenerateWallButton.Name = "GenerateWallButton";
            this.GenerateWallButton.Size = new System.Drawing.Size(207, 72);
            this.GenerateWallButton.TabIndex = 3;
            this.GenerateWallButton.Text = "Generate Wall";
            this.GenerateWallButton.UseVisualStyleBackColor = true;
            // 
            // InformativeLabel
            // 
            this.InformativeLabel.AutoSize = true;
            this.InformativeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformativeLabel.Location = new System.Drawing.Point(139, 19);
            this.InformativeLabel.Name = "InformativeLabel";
            this.InformativeLabel.Size = new System.Drawing.Size(554, 25);
            this.InformativeLabel.TabIndex = 4;
            this.InformativeLabel.Text = "Please enter two coordinate pairs to draw a wall between them:";
            // 
            // XCoordinateLabel
            // 
            this.XCoordinateLabel.AutoSize = true;
            this.XCoordinateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XCoordinateLabel.Location = new System.Drawing.Point(224, 78);
            this.XCoordinateLabel.Name = "XCoordinateLabel";
            this.XCoordinateLabel.Size = new System.Drawing.Size(102, 20);
            this.XCoordinateLabel.TabIndex = 5;
            this.XCoordinateLabel.Text = "X Coordinate";
            // 
            // YCoordinateLabel
            // 
            this.YCoordinateLabel.AutoSize = true;
            this.YCoordinateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YCoordinateLabel.Location = new System.Drawing.Point(449, 78);
            this.YCoordinateLabel.Name = "YCoordinateLabel";
            this.YCoordinateLabel.Size = new System.Drawing.Size(102, 20);
            this.YCoordinateLabel.TabIndex = 6;
            this.YCoordinateLabel.Text = "Y Coordinate";
            this.YCoordinateLabel.Click += new System.EventHandler(this.YCoordinateLabel_Click);
            // 
            // XCoordinateTextBox1
            // 
            this.XCoordinateTextBox1.Location = new System.Drawing.Point(226, 119);
            this.XCoordinateTextBox1.Name = "XCoordinateTextBox1";
            this.XCoordinateTextBox1.Size = new System.Drawing.Size(100, 20);
            this.XCoordinateTextBox1.TabIndex = 7;
            // 
            // XCoordinateTextBox2
            // 
            this.XCoordinateTextBox2.Location = new System.Drawing.Point(226, 165);
            this.XCoordinateTextBox2.Name = "XCoordinateTextBox2";
            this.XCoordinateTextBox2.Size = new System.Drawing.Size(100, 20);
            this.XCoordinateTextBox2.TabIndex = 11;
            // 
            // YCoordinateTextBox1
            // 
            this.YCoordinateTextBox1.Location = new System.Drawing.Point(451, 119);
            this.YCoordinateTextBox1.Name = "YCoordinateTextBox1";
            this.YCoordinateTextBox1.Size = new System.Drawing.Size(100, 20);
            this.YCoordinateTextBox1.TabIndex = 12;
            // 
            // YCoordinateTextBox2
            // 
            this.YCoordinateTextBox2.Location = new System.Drawing.Point(451, 165);
            this.YCoordinateTextBox2.Name = "YCoordinateTextBox2";
            this.YCoordinateTextBox2.Size = new System.Drawing.Size(100, 20);
            this.YCoordinateTextBox2.TabIndex = 13;
            // 
            // InformativeLabel2
            // 
            this.InformativeLabel2.AutoSize = true;
            this.InformativeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformativeLabel2.Location = new System.Drawing.Point(183, 215);
            this.InformativeLabel2.Name = "InformativeLabel2";
            this.InformativeLabel2.Size = new System.Drawing.Size(451, 20);
            this.InformativeLabel2.TabIndex = 14;
            this.InformativeLabel2.Text = "Please use the following format when entering the coordinates:";
            // 
            // InformativeLabel4
            // 
            this.InformativeLabel4.AutoSize = true;
            this.InformativeLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformativeLabel4.Location = new System.Drawing.Point(345, 249);
            this.InformativeLabel4.Name = "InformativeLabel4";
            this.InformativeLabel4.Size = new System.Drawing.Size(111, 18);
            this.InformativeLabel4.TabIndex = 15;
            this.InformativeLabel4.Text = "(-) 4.112432650";
            // 
            // InformativeLabel3
            // 
            this.InformativeLabel3.AutoSize = true;
            this.InformativeLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformativeLabel3.Location = new System.Drawing.Point(356, 279);
            this.InformativeLabel3.Name = "InformativeLabel3";
            this.InformativeLabel3.Size = new System.Drawing.Size(100, 18);
            this.InformativeLabel3.TabIndex = 16;
            this.InformativeLabel3.Text = "37.214416525";
            // 
            // GenerateWallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InformativeLabel3);
            this.Controls.Add(this.InformativeLabel4);
            this.Controls.Add(this.InformativeLabel2);
            this.Controls.Add(this.YCoordinateTextBox2);
            this.Controls.Add(this.YCoordinateTextBox1);
            this.Controls.Add(this.XCoordinateTextBox2);
            this.Controls.Add(this.XCoordinateTextBox1);
            this.Controls.Add(this.YCoordinateLabel);
            this.Controls.Add(this.XCoordinateLabel);
            this.Controls.Add(this.InformativeLabel);
            this.Controls.Add(this.GenerateWallButton);
            this.Controls.Add(this.ActionCancelButton);
            this.Name = "GenerateWallForm";
            this.Text = "GenerateWallForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ActionCancelButton;
        private System.Windows.Forms.Button GenerateWallButton;
        private System.Windows.Forms.Label InformativeLabel;
        private System.Windows.Forms.Label XCoordinateLabel;
        private System.Windows.Forms.Label YCoordinateLabel;
        private System.Windows.Forms.TextBox XCoordinateTextBox1;
        private System.Windows.Forms.TextBox XCoordinateTextBox2;
        private System.Windows.Forms.TextBox YCoordinateTextBox1;
        private System.Windows.Forms.TextBox YCoordinateTextBox2;
        private System.Windows.Forms.Label InformativeLabel2;
        private System.Windows.Forms.Label InformativeLabel4;
        private System.Windows.Forms.Label InformativeLabel3;
    }
}