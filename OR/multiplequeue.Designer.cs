namespace OR
{
    partial class multiplequeue
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
            this.mean_arrival = new System.Windows.Forms.Label();
            this.mean_service = new System.Windows.Forms.Label();
            this.service_num = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.avg_utilization = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.po = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multiple Queue\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mean_arrival
            // 
            this.mean_arrival.AutoSize = true;
            this.mean_arrival.Location = new System.Drawing.Point(494, 129);
            this.mean_arrival.Name = "mean_arrival";
            this.mean_arrival.Size = new System.Drawing.Size(107, 16);
            this.mean_arrival.TabIndex = 1;
            this.mean_arrival.Text = "mean arrival rate";
            this.mean_arrival.Click += new System.EventHandler(this.mean_arrival_Click);
            // 
            // mean_service
            // 
            this.mean_service.AutoSize = true;
            this.mean_service.Location = new System.Drawing.Point(786, 134);
            this.mean_service.Name = "mean_service";
            this.mean_service.Size = new System.Drawing.Size(114, 16);
            this.mean_service.TabIndex = 2;
            this.mean_service.Text = "mean service rate";
            // 
            // service_num
            // 
            this.service_num.AutoSize = true;
            this.service_num.Location = new System.Drawing.Point(78, 124);
            this.service_num.Name = "service_num";
            this.service_num.Size = new System.Drawing.Size(120, 16);
            this.service_num.TabIndex = 3;
            this.service_num.Text = "number of services";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "3";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(630, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "45";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(970, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "18";
            // 
            // avg_utilization
            // 
            this.avg_utilization.Location = new System.Drawing.Point(81, 222);
            this.avg_utilization.Name = "avg_utilization";
            this.avg_utilization.Size = new System.Drawing.Size(167, 31);
            this.avg_utilization.TabIndex = 7;
            this.avg_utilization.Text = "averge utilization";
            this.avg_utilization.UseVisualStyleBackColor = true;
            this.avg_utilization.Click += new System.EventHandler(this.avg_utilization_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "averge number of customers waiting";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 31);
            this.button3.TabIndex = 9;
            this.button3.Text = "averge time spent in the system";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // po
            // 
            this.po.Location = new System.Drawing.Point(441, 222);
            this.po.Name = "po";
            this.po.Size = new System.Drawing.Size(168, 32);
            this.po.TabIndex = 10;
            this.po.Text = "po customer in system";
            this.po.UseVisualStyleBackColor = true;
            this.po.Click += new System.EventHandler(this.po_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(441, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 44);
            this.button5.TabIndex = 11;
            this.button5.Text = "averge time of customers waiting";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(441, 388);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 64);
            this.button6.TabIndex = 12;
            this.button6.Text = "avg number of customers in the service system\r\n";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(289, 231);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(657, 231);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(280, 319);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(657, 320);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 16;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(280, 404);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 17;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(657, 404);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OR.Properties.Resources.photo_5776347451521874880_x;
            this.pictureBox1.Location = new System.Drawing.Point(827, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(661, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // multiplequeue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1556, 800);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.po);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.avg_utilization);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.service_num);
            this.Controls.Add(this.mean_service);
            this.Controls.Add(this.mean_arrival);
            this.Controls.Add(this.label1);
            this.Name = "multiplequeue";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mean_arrival;
        private System.Windows.Forms.Label mean_service;
        private System.Windows.Forms.Label service_num;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button avg_utilization;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button po;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}