namespace Energy_Simulation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Floor5btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Floor4btn = new System.Windows.Forms.Button();
            this.Floor3btn = new System.Windows.Forms.Button();
            this.Floor2btn = new System.Windows.Forms.Button();
            this.Floor1btn = new System.Windows.Forms.Button();
            this.FloorPlanImage = new System.Windows.Forms.PictureBox();
            this.SelFloorText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.SpawnLocation = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorPlanImage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.Floor5btn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Floor4btn);
            this.panel1.Controls.Add(this.Floor3btn);
            this.panel1.Controls.Add(this.Floor2btn);
            this.panel1.Controls.Add(this.Floor1btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 524);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(43, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Floors:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Smart Energy TM";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(156, 96);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(82, 469);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Floor5btn
            // 
            this.Floor5btn.BackColor = System.Drawing.Color.DarkSalmon;
            this.Floor5btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Floor5btn.FlatAppearance.BorderSize = 0;
            this.Floor5btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Floor5btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Floor5btn.Location = new System.Drawing.Point(0, 378);
            this.Floor5btn.Margin = new System.Windows.Forms.Padding(0);
            this.Floor5btn.Name = "Floor5btn";
            this.Floor5btn.Size = new System.Drawing.Size(136, 71);
            this.Floor5btn.TabIndex = 11;
            this.Floor5btn.Text = "Floor5";
            this.Floor5btn.UseVisualStyleBackColor = false;
            this.Floor5btn.Click += new System.EventHandler(this.Floor5btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 471);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Floor4btn
            // 
            this.Floor4btn.BackColor = System.Drawing.Color.DarkSalmon;
            this.Floor4btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Floor4btn.FlatAppearance.BorderSize = 0;
            this.Floor4btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Floor4btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Floor4btn.Location = new System.Drawing.Point(0, 307);
            this.Floor4btn.Margin = new System.Windows.Forms.Padding(0);
            this.Floor4btn.Name = "Floor4btn";
            this.Floor4btn.Size = new System.Drawing.Size(136, 71);
            this.Floor4btn.TabIndex = 10;
            this.Floor4btn.Text = "Floor 4";
            this.Floor4btn.UseVisualStyleBackColor = false;
            this.Floor4btn.Click += new System.EventHandler(this.Floor4btn_Click);
            // 
            // Floor3btn
            // 
            this.Floor3btn.BackColor = System.Drawing.Color.DarkSalmon;
            this.Floor3btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Floor3btn.FlatAppearance.BorderSize = 0;
            this.Floor3btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Floor3btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Floor3btn.Location = new System.Drawing.Point(0, 236);
            this.Floor3btn.Margin = new System.Windows.Forms.Padding(0);
            this.Floor3btn.Name = "Floor3btn";
            this.Floor3btn.Size = new System.Drawing.Size(136, 71);
            this.Floor3btn.TabIndex = 9;
            this.Floor3btn.Text = "Floor 3";
            this.Floor3btn.UseVisualStyleBackColor = false;
            this.Floor3btn.Click += new System.EventHandler(this.Floor3btn_Click);
            // 
            // Floor2btn
            // 
            this.Floor2btn.BackColor = System.Drawing.Color.DarkSalmon;
            this.Floor2btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Floor2btn.FlatAppearance.BorderSize = 0;
            this.Floor2btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Floor2btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Floor2btn.Location = new System.Drawing.Point(0, 165);
            this.Floor2btn.Margin = new System.Windows.Forms.Padding(0);
            this.Floor2btn.Name = "Floor2btn";
            this.Floor2btn.Size = new System.Drawing.Size(136, 71);
            this.Floor2btn.TabIndex = 8;
            this.Floor2btn.Text = "Floor 2";
            this.Floor2btn.UseVisualStyleBackColor = false;
            this.Floor2btn.Click += new System.EventHandler(this.Floor2btn_Click);
            // 
            // Floor1btn
            // 
            this.Floor1btn.BackColor = System.Drawing.Color.DarkSalmon;
            this.Floor1btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Floor1btn.FlatAppearance.BorderSize = 0;
            this.Floor1btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Floor1btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Floor1btn.Location = new System.Drawing.Point(0, 94);
            this.Floor1btn.Margin = new System.Windows.Forms.Padding(0);
            this.Floor1btn.Name = "Floor1btn";
            this.Floor1btn.Size = new System.Drawing.Size(136, 71);
            this.Floor1btn.TabIndex = 2;
            this.Floor1btn.Text = "Floor 1";
            this.Floor1btn.UseVisualStyleBackColor = false;
            this.Floor1btn.Click += new System.EventHandler(this.Floor1btn_Click);
            // 
            // FloorPlanImage
            // 
            this.FloorPlanImage.Location = new System.Drawing.Point(142, 102);
            this.FloorPlanImage.Name = "FloorPlanImage";
            this.FloorPlanImage.Size = new System.Drawing.Size(704, 410);
            this.FloorPlanImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FloorPlanImage.TabIndex = 1;
            this.FloorPlanImage.TabStop = false;
            // 
            // SelFloorText
            // 
            this.SelFloorText.AutoSize = true;
            this.SelFloorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelFloorText.Location = new System.Drawing.Point(26, 28);
            this.SelFloorText.Name = "SelFloorText";
            this.SelFloorText.Size = new System.Drawing.Size(198, 36);
            this.SelFloorText.TabIndex = 0;
            this.SelFloorText.Text = "Select a Floor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.SelFloorText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(136, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 96);
            this.panel2.TabIndex = 2;
            // 
            // Tick
            // 
            this.Tick.Interval = 1000;
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(986, 489);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(58, 17);
            this.TimeLabel.TabIndex = 11;
            this.TimeLabel.Text = "1 H/Sec";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(942, 450);
            this.trackBar1.Maximum = 72;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(132, 56);
            this.trackBar1.SmallChange = 0;
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(952, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "Start/Pause";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SpawnLocation
            // 
            this.SpawnLocation.AutoSize = true;
            this.SpawnLocation.Location = new System.Drawing.Point(714, 121);
            this.SpawnLocation.Name = "SpawnLocation";
            this.SpawnLocation.Size = new System.Drawing.Size(108, 17);
            this.SpawnLocation.TabIndex = 14;
            this.SpawnLocation.Text = "Spawn Location";
            // 
            // button2
            // 
            this.button2.AllowDrop = true;
            this.button2.Location = new System.Drawing.Point(21, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 76);
            this.button2.TabIndex = 12;
            this.button2.Text = "Create Light";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AllowDrop = true;
            this.button3.Location = new System.Drawing.Point(21, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 76);
            this.button3.TabIndex = 13;
            this.button3.Text = "Create TV";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AllowDrop = true;
            this.button4.Location = new System.Drawing.Point(21, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 76);
            this.button4.TabIndex = 14;
            this.button4.Text = "Create Oven";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(942, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 258);
            this.panel3.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.AllowDrop = true;
            this.button5.Location = new System.Drawing.Point(21, 422);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 76);
            this.button5.TabIndex = 17;
            this.button5.Text = "Create Boiler";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.AllowDrop = true;
            this.button6.Location = new System.Drawing.Point(21, 340);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 76);
            this.button6.TabIndex = 16;
            this.button6.Text = "Create Heater";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.AllowDrop = true;
            this.button7.Location = new System.Drawing.Point(21, 258);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 76);
            this.button7.TabIndex = 15;
            this.button7.Text = "Create Shower";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 524);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SpawnLocation);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.FloorPlanImage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorPlanImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox FloorPlanImage;
        private System.Windows.Forms.Button Floor1btn;
        private System.Windows.Forms.Button Floor5btn;
        private System.Windows.Forms.Button Floor4btn;
        private System.Windows.Forms.Button Floor3btn;
        private System.Windows.Forms.Button Floor2btn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label SelFloorText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer Tick;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SpawnLocation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

