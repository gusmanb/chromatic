namespace ChromaCorrection
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ndROY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ndROX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ndGOY = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ndGOX = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ndBOY = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.ndBOX = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pbComposite = new System.Windows.Forms.PictureBox();
            this.pbRed = new System.Windows.Forms.PictureBox();
            this.pbGreen = new System.Windows.Forms.PictureBox();
            this.pbBlue = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndROY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndROX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndGOY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndGOX)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndBOY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndBOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComposite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ndROY);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ndROX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(617, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Red";
            // 
            // ndROY
            // 
            this.ndROY.Location = new System.Drawing.Point(58, 44);
            this.ndROY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ndROY.Name = "ndROY";
            this.ndROY.Size = new System.Drawing.Size(49, 20);
            this.ndROY.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Offset Y";
            // 
            // ndROX
            // 
            this.ndROX.Location = new System.Drawing.Point(58, 18);
            this.ndROX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ndROX.Name = "ndROX";
            this.ndROX.Size = new System.Drawing.Size(49, 20);
            this.ndROX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Offset X";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ndGOY);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.ndGOX);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(617, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(122, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Green";
            // 
            // ndGOY
            // 
            this.ndGOY.Location = new System.Drawing.Point(58, 44);
            this.ndGOY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ndGOY.Name = "ndGOY";
            this.ndGOY.Size = new System.Drawing.Size(49, 20);
            this.ndGOY.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Offset Y";
            // 
            // ndGOX
            // 
            this.ndGOX.Location = new System.Drawing.Point(58, 18);
            this.ndGOX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ndGOX.Name = "ndGOX";
            this.ndGOX.Size = new System.Drawing.Size(49, 20);
            this.ndGOX.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Offset X";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ndBOY);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.ndBOX);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(617, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 75);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Blue";
            // 
            // ndBOY
            // 
            this.ndBOY.Location = new System.Drawing.Point(58, 44);
            this.ndBOY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ndBOY.Name = "ndBOY";
            this.ndBOY.Size = new System.Drawing.Size(49, 20);
            this.ndBOY.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Offset Y";
            // 
            // ndBOX
            // 
            this.ndBOX.Location = new System.Drawing.Point(58, 18);
            this.ndBOX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ndBOX.Name = "ndBOX";
            this.ndBOX.Size = new System.Drawing.Size(49, 20);
            this.ndBOX.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Offset X";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(617, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbComposite
            // 
            this.pbComposite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbComposite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbComposite.Location = new System.Drawing.Point(12, 12);
            this.pbComposite.Name = "pbComposite";
            this.pbComposite.Size = new System.Drawing.Size(599, 411);
            this.pbComposite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbComposite.TabIndex = 4;
            this.pbComposite.TabStop = false;
            // 
            // pbRed
            // 
            this.pbRed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRed.Location = new System.Drawing.Point(20, 429);
            this.pbRed.Name = "pbRed";
            this.pbRed.Size = new System.Drawing.Size(235, 160);
            this.pbRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRed.TabIndex = 5;
            this.pbRed.TabStop = false;
            // 
            // pbGreen
            // 
            this.pbGreen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGreen.Location = new System.Drawing.Point(261, 429);
            this.pbGreen.Name = "pbGreen";
            this.pbGreen.Size = new System.Drawing.Size(235, 160);
            this.pbGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGreen.TabIndex = 6;
            this.pbGreen.TabStop = false;
            // 
            // pbBlue
            // 
            this.pbBlue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBlue.Location = new System.Drawing.Point(502, 429);
            this.pbBlue.Name = "pbBlue";
            this.pbBlue.Size = new System.Drawing.Size(235, 160);
            this.pbBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBlue.TabIndex = 7;
            this.pbBlue.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(617, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(617, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(617, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(122, 75);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Simmetric adjustment";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(67, 46);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "→";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(67, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "←";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "↓";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "↑";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 598);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pbBlue);
            this.Controls.Add(this.pbGreen);
            this.Controls.Add(this.pbRed);
            this.Controls.Add(this.pbComposite);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(766, 544);
            this.Name = "Main";
            this.Text = "Chromatic aberration corrector";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndROY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndROX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndGOY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndGOX)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndBOY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndBOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComposite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown ndROY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ndROX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown ndGOY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ndGOX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown ndBOY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown ndBOX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbComposite;
        private System.Windows.Forms.PictureBox pbRed;
        private System.Windows.Forms.PictureBox pbGreen;
        private System.Windows.Forms.PictureBox pbBlue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

