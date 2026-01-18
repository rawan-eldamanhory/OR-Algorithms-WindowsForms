using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace OR
{
    partial class simplex
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxNumberOfVariables = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfConstraints = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(13, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter number of variables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(13, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter number of constraints ";
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.Teal;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOk.Location = new System.Drawing.Point(163, 371);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(96, 39);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxNumberOfVariables
            // 
            this.textBoxNumberOfVariables.Location = new System.Drawing.Point(333, 119);
            this.textBoxNumberOfVariables.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumberOfVariables.MaxLength = 2;
            this.textBoxNumberOfVariables.Name = "textBoxNumberOfVariables";
            this.textBoxNumberOfVariables.Size = new System.Drawing.Size(93, 22);
            this.textBoxNumberOfVariables.TabIndex = 3;
            // 
            // textBoxNumberOfConstraints
            // 
            this.textBoxNumberOfConstraints.Location = new System.Drawing.Point(333, 246);
            this.textBoxNumberOfConstraints.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumberOfConstraints.MaxLength = 2;
            this.textBoxNumberOfConstraints.Name = "textBoxNumberOfConstraints";
            this.textBoxNumberOfConstraints.Size = new System.Drawing.Size(93, 22);
            this.textBoxNumberOfConstraints.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OR.Properties.Resources.hero;
            this.pictureBox1.Location = new System.Drawing.Point(525, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // simplex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1023, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxNumberOfConstraints);
            this.Controls.Add(this.textBoxNumberOfVariables);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "simplex";
            this.Text = "SIMPLEX";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxNumberOfVariables;
        private System.Windows.Forms.TextBox textBoxNumberOfConstraints;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}