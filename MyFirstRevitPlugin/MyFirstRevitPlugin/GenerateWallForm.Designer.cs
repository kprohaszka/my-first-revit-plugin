
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
            this.InformativeLabel1 = new System.Windows.Forms.Label();
            this.XCoordinateLabel = new System.Windows.Forms.Label();
            this.YCoordinateLabel = new System.Windows.Forms.Label();
            this.XCoordinateTextBox1 = new System.Windows.Forms.TextBox();
            this.XCoordinateTextBox2 = new System.Windows.Forms.TextBox();
            this.YCoordinateTextBox1 = new System.Windows.Forms.TextBox();
            this.YCoordinateTextBox2 = new System.Windows.Forms.TextBox();
            this.InformativeLabel2 = new System.Windows.Forms.Label();
            this.InformativeLabel3 = new System.Windows.Forms.Label();
            this.InformativeLabel4 = new System.Windows.Forms.Label();
            this.InformativeLabel5 = new System.Windows.Forms.Label();
            this.InformativeLebel6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ActionCancelButton
            // 
            this.ActionCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionCancelButton.Location = new System.Drawing.Point(135, 344);
            this.ActionCancelButton.Name = "ActionCancelButton";
            this.ActionCancelButton.Size = new System.Drawing.Size(169, 65);
            this.ActionCancelButton.TabIndex = 0;
            this.ActionCancelButton.Text = "Cancel";
            this.ActionCancelButton.UseVisualStyleBackColor = true;
            this.ActionCancelButton.Click += new System.EventHandler(this.ActionCancelButton_Click);
            // 
            // GenerateWallButton
            // 
            this.GenerateWallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateWallButton.Location = new System.Drawing.Point(529, 344);
            this.GenerateWallButton.Name = "GenerateWallButton";
            this.GenerateWallButton.Size = new System.Drawing.Size(169, 65);
            this.GenerateWallButton.TabIndex = 1;
            this.GenerateWallButton.Text = "Generate Wall";
            this.GenerateWallButton.UseVisualStyleBackColor = true;
            this.GenerateWallButton.Click += new System.EventHandler(this.GenerateWallButton_Click);
            // 
            // InformativeLabel1
            // 
            this.InformativeLabel1.AutoSize = true;
            this.InformativeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformativeLabel1.Location = new System.Drawing.Point(144, 30);
            this.InformativeLabel1.Name = "InformativeLabel1";
            this.InformativeLabel1.Size = new System.Drawing.Size(554, 25);
            this.InformativeLabel1.TabIndex = 2;
            this.InformativeLabel1.Text = "Please enter two coordinate pairs to draw a wall between them:";
            this.InformativeLabel1.Click += new System.EventHandler(this.InformativeLabel1_Click);
            // 
            // XCoordinateLabel
            // 
            this.XCoordinateLabel.AutoSize = true;
            this.XCoordinateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XCoordinateLabel.Location = new System.Drawing.Point(298, 102);
            this.XCoordinateLabel.Name = "XCoordinateLabel";
            this.XCoordinateLabel.Size = new System.Drawing.Size(115, 22);
            this.XCoordinateLabel.TabIndex = 3;
            this.XCoordinateLabel.Text = "X Coordinate";
            this.XCoordinateLabel.Click += new System.EventHandler(this.XCoordinateLabel_Click);
            // 
            // YCoordinateLabel
            // 
            this.YCoordinateLabel.AutoSize = true;
            this.YCoordinateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YCoordinateLabel.Location = new System.Drawing.Point(443, 102);
            this.YCoordinateLabel.Name = "YCoordinateLabel";
            this.YCoordinateLabel.Size = new System.Drawing.Size(115, 22);
            this.YCoordinateLabel.TabIndex = 4;
            this.YCoordinateLabel.Text = "Y Coordinate";
            this.YCoordinateLabel.Click += new System.EventHandler(this.YCoordinateLabel_Click);
            // 
            // XCoordinateTextBox1
            // 
            this.XCoordinateTextBox1.Location = new System.Drawing.Point(302, 142);
            this.XCoordinateTextBox1.Name = "XCoordinateTextBox1";
            this.XCoordinateTextBox1.Size = new System.Drawing.Size(111, 20);
            this.XCoordinateTextBox1.TabIndex = 5;
            this.XCoordinateTextBox1.TextChanged += new System.EventHandler(this.XCoordinateTextBox1_TextChanged);
            // 
            // XCoordinateTextBox2
            // 
            this.XCoordinateTextBox2.Location = new System.Drawing.Point(302, 169);
            this.XCoordinateTextBox2.Name = "XCoordinateTextBox2";
            this.XCoordinateTextBox2.Size = new System.Drawing.Size(111, 20);
            this.XCoordinateTextBox2.TabIndex = 6;
            this.XCoordinateTextBox2.TextChanged += new System.EventHandler(this.XCoordinateTextBox2_TextChanged);
            // 
            // YCoordinateTextBox1
            // 
            this.YCoordinateTextBox1.Location = new System.Drawing.Point(447, 142);
            this.YCoordinateTextBox1.Name = "YCoordinateTextBox1";
            this.YCoordinateTextBox1.Size = new System.Drawing.Size(111, 20);
            this.YCoordinateTextBox1.TabIndex = 7;
            this.YCoordinateTextBox1.TextChanged += new System.EventHandler(this.YCoordinateTextBox1_TextChanged);
            // 
            // YCoordinateTextBox2
            // 
            this.YCoordinateTextBox2.Location = new System.Drawing.Point(447, 168);
            this.YCoordinateTextBox2.Name = "YCoordinateTextBox2";
            this.YCoordinateTextBox2.Size = new System.Drawing.Size(111, 20);
            this.YCoordinateTextBox2.TabIndex = 8;
            this.YCoordinateTextBox2.TextChanged += new System.EventHandler(this.YCoordinateTextBox2_TextChanged);
            // 
            // InformativeLabel2
            // 
            this.InformativeLabel2.AutoSize = true;
            this.InformativeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformativeLabel2.Location = new System.Drawing.Point(189, 245);
            this.InformativeLabel2.Name = "InformativeLabel2";
            this.InformativeLabel2.Size = new System.Drawing.Size(451, 20);
            this.InformativeLabel2.TabIndex = 9;
            this.InformativeLabel2.Text = "Please use the following format when entering the coordinates:";
            this.InformativeLabel2.Click += new System.EventHandler(this.InformativeLabel2_Click);
            // 
            // InformativeLabel3
            // 
            this.InformativeLabel3.AutoSize = true;
            this.InformativeLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformativeLabel3.Location = new System.Drawing.Point(346, 277);
            this.InformativeLabel3.Name = "InformativeLabel3";
            this.InformativeLabel3.Size = new System.Drawing.Size(111, 17);
            this.InformativeLabel3.TabIndex = 10;
            this.InformativeLabel3.Text = "(-) 4.112432650";
            this.InformativeLabel3.Click += new System.EventHandler(this.InformativeLabel3_Click);
            // 
            // InformativeLabel4
            // 
            this.InformativeLabel4.AutoSize = true;
            this.InformativeLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformativeLabel4.Location = new System.Drawing.Point(357, 307);
            this.InformativeLabel4.Name = "InformativeLabel4";
            this.InformativeLabel4.Size = new System.Drawing.Size(100, 17);
            this.InformativeLabel4.TabIndex = 11;
            this.InformativeLabel4.Text = "37.214416525";
            this.InformativeLabel4.Click += new System.EventHandler(this.InformativeLabel4_Click);
            // 
            // InformativeLabel5
            // 
            this.InformativeLabel5.AutoSize = true;
            this.InformativeLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformativeLabel5.Location = new System.Drawing.Point(132, 142);
            this.InformativeLabel5.Name = "InformativeLabel5";
            this.InformativeLabel5.Size = new System.Drawing.Size(141, 17);
            this.InformativeLabel5.TabIndex = 12;
            this.InformativeLabel5.Text = "First Coordinate Pair:";
            // 
            // InformativeLebel6
            // 
            this.InformativeLebel6.AutoSize = true;
            this.InformativeLebel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.InformativeLebel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformativeLebel6.Location = new System.Drawing.Point(132, 169);
            this.InformativeLebel6.Name = "InformativeLebel6";
            this.InformativeLebel6.Size = new System.Drawing.Size(162, 17);
            this.InformativeLebel6.TabIndex = 13;
            this.InformativeLebel6.Text = "Second Coordinate Pair:";
            this.InformativeLebel6.Click += new System.EventHandler(this.InformativeLebel6_Click);
            // 
            // GenerateWallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InformativeLebel6);
            this.Controls.Add(this.InformativeLabel5);
            this.Controls.Add(this.InformativeLabel4);
            this.Controls.Add(this.InformativeLabel3);
            this.Controls.Add(this.InformativeLabel2);
            this.Controls.Add(this.YCoordinateTextBox2);
            this.Controls.Add(this.YCoordinateTextBox1);
            this.Controls.Add(this.XCoordinateTextBox2);
            this.Controls.Add(this.XCoordinateTextBox1);
            this.Controls.Add(this.YCoordinateLabel);
            this.Controls.Add(this.XCoordinateLabel);
            this.Controls.Add(this.InformativeLabel1);
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
        private System.Windows.Forms.Label InformativeLabel1;
        private System.Windows.Forms.Label XCoordinateLabel;
        private System.Windows.Forms.Label YCoordinateLabel;
        private System.Windows.Forms.TextBox XCoordinateTextBox1;
        private System.Windows.Forms.TextBox XCoordinateTextBox2;
        private System.Windows.Forms.TextBox YCoordinateTextBox1;
        private System.Windows.Forms.TextBox YCoordinateTextBox2;
        private System.Windows.Forms.Label InformativeLabel2;
        private System.Windows.Forms.Label InformativeLabel3;
        private System.Windows.Forms.Label InformativeLabel4;
        private System.Windows.Forms.Label InformativeLabel5;
        private System.Windows.Forms.Label InformativeLebel6;
    }
}