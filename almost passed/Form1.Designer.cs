
namespace almost_passed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BuildingBox = new System.Windows.Forms.TextBox();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.FloorBox = new System.Windows.Forms.TextBox();
            this.Building = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.Label();
            this.Floor = new System.Windows.Forms.Label();
            this.JumpButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShowHere = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BuildingBox
            // 
            this.BuildingBox.Location = new System.Drawing.Point(73, 23);
            this.BuildingBox.Name = "BuildingBox";
            this.BuildingBox.Size = new System.Drawing.Size(100, 23);
            this.BuildingBox.TabIndex = 0;
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(73, 69);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(100, 23);
            this.HeightBox.TabIndex = 1;
            this.HeightBox.TextChanged += new System.EventHandler(this.HeightBox_TextChanged);
            // 
            // FloorBox
            // 
            this.FloorBox.Location = new System.Drawing.Point(73, 124);
            this.FloorBox.Name = "FloorBox";
            this.FloorBox.Size = new System.Drawing.Size(100, 23);
            this.FloorBox.TabIndex = 2;
            // 
            // Building
            // 
            this.Building.AutoSize = true;
            this.Building.Location = new System.Drawing.Point(12, 29);
            this.Building.Name = "Building";
            this.Building.Size = new System.Drawing.Size(55, 17);
            this.Building.TabIndex = 3;
            this.Building.Text = "Building";
            this.Building.Click += new System.EventHandler(this.label1_Click);
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(12, 75);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(46, 17);
            this.Height.TabIndex = 4;
            this.Height.Text = "Height";
            this.Height.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Floor
            // 
            this.Floor.AutoSize = true;
            this.Floor.Location = new System.Drawing.Point(12, 130);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(38, 17);
            this.Floor.TabIndex = 5;
            this.Floor.Text = "Floor";
            this.Floor.Click += new System.EventHandler(this.label3_Click);
            // 
            // JumpButton
            // 
            this.JumpButton.Location = new System.Drawing.Point(12, 197);
            this.JumpButton.Name = "JumpButton";
            this.JumpButton.Size = new System.Drawing.Size(75, 23);
            this.JumpButton.TabIndex = 6;
            this.JumpButton.Text = "jump!";
            this.JumpButton.UseVisualStyleBackColor = true;
            this.JumpButton.Click += new System.EventHandler(this.JumpButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 39);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ShowHere
            // 
            this.ShowHere.AutoSize = true;
            this.ShowHere.Location = new System.Drawing.Point(209, 74);
            this.ShowHere.Name = "ShowHere";
            this.ShowHere.Size = new System.Drawing.Size(0, 17);
            this.ShowHere.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 323);
            this.Controls.Add(this.ShowHere);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.JumpButton);
            this.Controls.Add(this.Floor);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Building);
            this.Controls.Add(this.FloorBox);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.BuildingBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BuildingBox;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.TextBox FloorBox;
        private System.Windows.Forms.Label Building;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label Floor;
        private System.Windows.Forms.Button JumpButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ShowHere;
    }
}

