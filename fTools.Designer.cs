﻿namespace TriDelta.PathTools
{
    partial class fTools
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
         this.cmdAdjustSpeed = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.txtUnitLength = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.txtUnitTime = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.cmdAdjustAngle = new System.Windows.Forms.Button();
         this.lstPathPoints = new System.Windows.Forms.ComboBox();
         this.chkAdjustAngle = new System.Windows.Forms.CheckBox();
         this.chkAdjustPitch = new System.Windows.Forms.CheckBox();
         this.cmdCreateThings = new System.Windows.Forms.Button();
         this.label4 = new System.Windows.Forms.Label();
         this.txtCreateType = new System.Windows.Forms.TextBox();
         this.txtCreateInterval = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.rLineTypeLinear = new System.Windows.Forms.RadioButton();
         this.rLineTypeSpline = new System.Windows.Forms.RadioButton();
         this.txtAngleOffset = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.rApplyZPitch = new System.Windows.Forms.RadioButton();
         this.rApplyZRoll = new System.Windows.Forms.RadioButton();
         this.panel1 = new System.Windows.Forms.Panel();
         this.label7 = new System.Windows.Forms.Label();
         this.panel2 = new System.Windows.Forms.Panel();
         this.label8 = new System.Windows.Forms.Label();
         this.rApplyZNone = new System.Windows.Forms.RadioButton();
         this.panel1.SuspendLayout();
         this.panel2.SuspendLayout();
         this.SuspendLayout();
         // 
         // cmdAdjustSpeed
         // 
         this.cmdAdjustSpeed.Location = new System.Drawing.Point(187, 107);
         this.cmdAdjustSpeed.Name = "cmdAdjustSpeed";
         this.cmdAdjustSpeed.Size = new System.Drawing.Size(85, 23);
         this.cmdAdjustSpeed.TabIndex = 0;
         this.cmdAdjustSpeed.Text = "Adjust Speed";
         this.cmdAdjustSpeed.UseVisualStyleBackColor = true;
         this.cmdAdjustSpeed.Click += new System.EventHandler(this.cmdAdjustSpeed_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(8, 12);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(131, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "Starting Interpolation Point";
         // 
         // txtUnitLength
         // 
         this.txtUnitLength.Location = new System.Drawing.Point(77, 109);
         this.txtUnitLength.Name = "txtUnitLength";
         this.txtUnitLength.Size = new System.Drawing.Size(104, 20);
         this.txtUnitLength.TabIndex = 3;
         this.txtUnitLength.Text = "1024";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(77, 90);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(97, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "for linedef length of";
         // 
         // txtUnitTime
         // 
         this.txtUnitTime.Location = new System.Drawing.Point(11, 109);
         this.txtUnitTime.Name = "txtUnitTime";
         this.txtUnitTime.Size = new System.Drawing.Size(60, 20);
         this.txtUnitTime.TabIndex = 5;
         this.txtUnitTime.Text = "8";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(8, 90);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(63, 13);
         this.label3.TabIndex = 6;
         this.label3.Text = "Travel Time";
         // 
         // cmdAdjustAngle
         // 
         this.cmdAdjustAngle.Location = new System.Drawing.Point(187, 58);
         this.cmdAdjustAngle.Name = "cmdAdjustAngle";
         this.cmdAdjustAngle.Size = new System.Drawing.Size(85, 23);
         this.cmdAdjustAngle.TabIndex = 7;
         this.cmdAdjustAngle.Text = "Adjust Angle";
         this.cmdAdjustAngle.UseVisualStyleBackColor = true;
         this.cmdAdjustAngle.Click += new System.EventHandler(this.cmdAdjustAngle_Click);
         // 
         // lstPathPoints
         // 
         this.lstPathPoints.FormattingEnabled = true;
         this.lstPathPoints.Location = new System.Drawing.Point(11, 28);
         this.lstPathPoints.Name = "lstPathPoints";
         this.lstPathPoints.Size = new System.Drawing.Size(261, 21);
         this.lstPathPoints.TabIndex = 8;
         // 
         // chkAdjustAngle
         // 
         this.chkAdjustAngle.AutoSize = true;
         this.chkAdjustAngle.Checked = true;
         this.chkAdjustAngle.CheckState = System.Windows.Forms.CheckState.Checked;
         this.chkAdjustAngle.Location = new System.Drawing.Point(12, 62);
         this.chkAdjustAngle.Name = "chkAdjustAngle";
         this.chkAdjustAngle.Size = new System.Drawing.Size(53, 17);
         this.chkAdjustAngle.TabIndex = 9;
         this.chkAdjustAngle.Text = "Angle";
         this.chkAdjustAngle.UseVisualStyleBackColor = true;
         // 
         // chkAdjustPitch
         // 
         this.chkAdjustPitch.AutoSize = true;
         this.chkAdjustPitch.Checked = true;
         this.chkAdjustPitch.CheckState = System.Windows.Forms.CheckState.Checked;
         this.chkAdjustPitch.Location = new System.Drawing.Point(77, 62);
         this.chkAdjustPitch.Name = "chkAdjustPitch";
         this.chkAdjustPitch.Size = new System.Drawing.Size(50, 17);
         this.chkAdjustPitch.TabIndex = 10;
         this.chkAdjustPitch.Text = "Pitch";
         this.chkAdjustPitch.UseVisualStyleBackColor = true;
         // 
         // cmdCreateThings
         // 
         this.cmdCreateThings.Location = new System.Drawing.Point(187, 245);
         this.cmdCreateThings.Name = "cmdCreateThings";
         this.cmdCreateThings.Size = new System.Drawing.Size(85, 21);
         this.cmdCreateThings.TabIndex = 11;
         this.cmdCreateThings.Text = "Create Things";
         this.cmdCreateThings.UseVisualStyleBackColor = true;
         this.cmdCreateThings.Click += new System.EventHandler(this.cmdCreateThings_Click);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(8, 143);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(61, 13);
         this.label4.TabIndex = 12;
         this.label4.Text = "Thing Type";
         // 
         // txtCreateType
         // 
         this.txtCreateType.Location = new System.Drawing.Point(11, 159);
         this.txtCreateType.Name = "txtCreateType";
         this.txtCreateType.Size = new System.Drawing.Size(55, 20);
         this.txtCreateType.TabIndex = 13;
         this.txtCreateType.Text = "28001";
         // 
         // txtCreateInterval
         // 
         this.txtCreateInterval.Location = new System.Drawing.Point(70, 159);
         this.txtCreateInterval.Name = "txtCreateInterval";
         this.txtCreateInterval.Size = new System.Drawing.Size(41, 20);
         this.txtCreateInterval.TabIndex = 14;
         this.txtCreateInterval.Text = "256";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(69, 143);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(42, 13);
         this.label5.TabIndex = 15;
         this.label5.Text = "Interval";
         // 
         // rLineTypeLinear
         // 
         this.rLineTypeLinear.AutoSize = true;
         this.rLineTypeLinear.Location = new System.Drawing.Point(3, 16);
         this.rLineTypeLinear.Name = "rLineTypeLinear";
         this.rLineTypeLinear.Size = new System.Drawing.Size(54, 17);
         this.rLineTypeLinear.TabIndex = 16;
         this.rLineTypeLinear.Text = "Linear";
         this.rLineTypeLinear.UseVisualStyleBackColor = true;
         // 
         // rLineTypeSpline
         // 
         this.rLineTypeSpline.AutoSize = true;
         this.rLineTypeSpline.Checked = true;
         this.rLineTypeSpline.Location = new System.Drawing.Point(63, 16);
         this.rLineTypeSpline.Name = "rLineTypeSpline";
         this.rLineTypeSpline.Size = new System.Drawing.Size(54, 17);
         this.rLineTypeSpline.TabIndex = 17;
         this.rLineTypeSpline.TabStop = true;
         this.rLineTypeSpline.Text = "Spline";
         this.rLineTypeSpline.UseVisualStyleBackColor = true;
         // 
         // txtAngleOffset
         // 
         this.txtAngleOffset.Location = new System.Drawing.Point(117, 159);
         this.txtAngleOffset.Name = "txtAngleOffset";
         this.txtAngleOffset.Size = new System.Drawing.Size(64, 20);
         this.txtAngleOffset.TabIndex = 18;
         this.txtAngleOffset.Text = "90";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(117, 143);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(65, 13);
         this.label6.TabIndex = 19;
         this.label6.Text = "Angle Offset";
         // 
         // rApplyZPitch
         // 
         this.rApplyZPitch.AutoSize = true;
         this.rApplyZPitch.Location = new System.Drawing.Point(4, 16);
         this.rApplyZPitch.Name = "rApplyZPitch";
         this.rApplyZPitch.Size = new System.Drawing.Size(49, 17);
         this.rApplyZPitch.TabIndex = 20;
         this.rApplyZPitch.Text = "Pitch";
         this.rApplyZPitch.UseVisualStyleBackColor = true;
         // 
         // rApplyZRoll
         // 
         this.rApplyZRoll.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
         this.rApplyZRoll.AutoSize = true;
         this.rApplyZRoll.Checked = true;
         this.rApplyZRoll.Location = new System.Drawing.Point(59, 16);
         this.rApplyZRoll.Name = "rApplyZRoll";
         this.rApplyZRoll.Size = new System.Drawing.Size(43, 17);
         this.rApplyZRoll.TabIndex = 21;
         this.rApplyZRoll.TabStop = true;
         this.rApplyZRoll.Text = "Roll";
         this.rApplyZRoll.UseVisualStyleBackColor = true;
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.label7);
         this.panel1.Controls.Add(this.rLineTypeSpline);
         this.panel1.Controls.Add(this.rLineTypeLinear);
         this.panel1.Location = new System.Drawing.Point(12, 185);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(133, 38);
         this.panel1.TabIndex = 22;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(3, 0);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(84, 13);
         this.label7.TabIndex = 18;
         this.label7.Text = "Placement Type";
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.rApplyZNone);
         this.panel2.Controls.Add(this.label8);
         this.panel2.Controls.Add(this.rApplyZPitch);
         this.panel2.Controls.Add(this.rApplyZRoll);
         this.panel2.Location = new System.Drawing.Point(12, 229);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(163, 39);
         this.panel2.TabIndex = 23;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(3, 0);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(89, 13);
         this.label8.TabIndex = 22;
         this.label8.Text = "Apply Z Angle To";
         // 
         // rApplyZNone
         // 
         this.rApplyZNone.AutoSize = true;
         this.rApplyZNone.Location = new System.Drawing.Point(108, 16);
         this.rApplyZNone.Name = "rApplyZNone";
         this.rApplyZNone.Size = new System.Drawing.Size(51, 17);
         this.rApplyZNone.TabIndex = 23;
         this.rApplyZNone.TabStop = true;
         this.rApplyZNone.Text = "None";
         this.rApplyZNone.UseVisualStyleBackColor = true;
         // 
         // fTools
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 279);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.txtAngleOffset);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.txtCreateInterval);
         this.Controls.Add(this.txtCreateType);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.cmdCreateThings);
         this.Controls.Add(this.chkAdjustPitch);
         this.Controls.Add(this.chkAdjustAngle);
         this.Controls.Add(this.lstPathPoints);
         this.Controls.Add(this.cmdAdjustAngle);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.txtUnitTime);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtUnitLength);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.cmdAdjustSpeed);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "fTools";
         this.Text = "Path Tools";
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAdjustSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnitLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnitTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdAdjustAngle;
        private System.Windows.Forms.ComboBox lstPathPoints;
        private System.Windows.Forms.CheckBox chkAdjustAngle;
        private System.Windows.Forms.CheckBox chkAdjustPitch;
        private System.Windows.Forms.Button cmdCreateThings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCreateType;
        private System.Windows.Forms.TextBox txtCreateInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rLineTypeLinear;
        private System.Windows.Forms.RadioButton rLineTypeSpline;
        private System.Windows.Forms.TextBox txtAngleOffset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rApplyZPitch;
        private System.Windows.Forms.RadioButton rApplyZRoll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rApplyZNone;
        private System.Windows.Forms.Label label8;
    }
}