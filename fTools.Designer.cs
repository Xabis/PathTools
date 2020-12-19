namespace TriDelta.PathTools
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
            this.txtUnitLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdAdjustAngle = new System.Windows.Forms.Button();
            this.chkAdjustAngle = new System.Windows.Forms.CheckBox();
            this.chkAdjustPitch = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdRetag = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRetagStart = new System.Windows.Forms.TextBox();
            this.grpCreateThings = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHOffset = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtZOffset = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rPlaceTop = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.rPlaceMiddle = new System.Windows.Forms.RadioButton();
            this.rPlaceBottom = new System.Windows.Forms.RadioButton();
            this.cmdSelectThingType = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rApplyZNone = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.rApplyZPitch = new System.Windows.Forms.RadioButton();
            this.rApplyZRoll = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAngleOffset = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCreateInterval = new System.Windows.Forms.TextBox();
            this.txtCreateType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdCreateThings = new System.Windows.Forms.Button();
            this.grpAdjustments = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMassCreate = new System.Windows.Forms.GroupBox();
            this.txtMassScale = new System.Windows.Forms.TextBox();
            this.lblMassScale = new System.Windows.Forms.Label();
            this.chkMassLinkNodes = new System.Windows.Forms.CheckBox();
            this.txtCoordList = new System.Windows.Forms.TextBox();
            this.cmdCreateEnMasse = new System.Windows.Forms.Button();
            this.grpLineType = new System.Windows.Forms.GroupBox();
            this.rLineTypeSpline = new System.Windows.Forms.RadioButton();
            this.rLineTypeLinear = new System.Windows.Forms.RadioButton();
            this.chkUnusedOnly = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.grpCreateThings.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpAdjustments.SuspendLayout();
            this.grpMassCreate.SuspendLayout();
            this.grpLineType.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdAdjustSpeed
            // 
            this.cmdAdjustSpeed.Location = new System.Drawing.Point(197, 63);
            this.cmdAdjustSpeed.Name = "cmdAdjustSpeed";
            this.cmdAdjustSpeed.Size = new System.Drawing.Size(75, 23);
            this.cmdAdjustSpeed.TabIndex = 0;
            this.cmdAdjustSpeed.Text = "Adjust";
            this.cmdAdjustSpeed.UseVisualStyleBackColor = true;
            this.cmdAdjustSpeed.Click += new System.EventHandler(this.cmdAdjustSpeed_Click);
            // 
            // txtUnitLength
            // 
            this.txtUnitLength.Location = new System.Drawing.Point(137, 65);
            this.txtUnitLength.Name = "txtUnitLength";
            this.txtUnitLength.Size = new System.Drawing.Size(53, 20);
            this.txtUnitLength.TabIndex = 3;
            this.txtUnitLength.Text = "1024";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Map Units";
            // 
            // txtUnitTime
            // 
            this.txtUnitTime.Location = new System.Drawing.Point(78, 65);
            this.txtUnitTime.Name = "txtUnitTime";
            this.txtUnitTime.Size = new System.Drawing.Size(53, 20);
            this.txtUnitTime.TabIndex = 5;
            this.txtUnitTime.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Octics";
            // 
            // cmdAdjustAngle
            // 
            this.cmdAdjustAngle.Location = new System.Drawing.Point(197, 19);
            this.cmdAdjustAngle.Name = "cmdAdjustAngle";
            this.cmdAdjustAngle.Size = new System.Drawing.Size(75, 23);
            this.cmdAdjustAngle.TabIndex = 7;
            this.cmdAdjustAngle.Text = "Adjust";
            this.cmdAdjustAngle.UseVisualStyleBackColor = true;
            this.cmdAdjustAngle.Click += new System.EventHandler(this.cmdAdjustAngle_Click);
            // 
            // chkAdjustAngle
            // 
            this.chkAdjustAngle.AutoSize = true;
            this.chkAdjustAngle.Checked = true;
            this.chkAdjustAngle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAdjustAngle.Location = new System.Drawing.Point(66, 23);
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
            this.chkAdjustPitch.Location = new System.Drawing.Point(126, 23);
            this.chkAdjustPitch.Name = "chkAdjustPitch";
            this.chkAdjustPitch.Size = new System.Drawing.Size(50, 17);
            this.chkAdjustPitch.TabIndex = 10;
            this.chkAdjustPitch.Text = "Pitch";
            this.chkAdjustPitch.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkUnusedOnly);
            this.groupBox2.Controls.Add(this.cmdRetag);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtRetagStart);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 62);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Retag Path";
            // 
            // cmdRetag
            // 
            this.cmdRetag.Location = new System.Drawing.Point(197, 30);
            this.cmdRetag.Name = "cmdRetag";
            this.cmdRetag.Size = new System.Drawing.Size(75, 23);
            this.cmdRetag.TabIndex = 2;
            this.cmdRetag.Text = "Retag";
            this.cmdRetag.UseVisualStyleBackColor = true;
            this.cmdRetag.Click += new System.EventHandler(this.cmdRetag_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Start Tag";
            // 
            // txtRetagStart
            // 
            this.txtRetagStart.Location = new System.Drawing.Point(6, 32);
            this.txtRetagStart.Name = "txtRetagStart";
            this.txtRetagStart.Size = new System.Drawing.Size(161, 20);
            this.txtRetagStart.TabIndex = 0;
            // 
            // grpCreateThings
            // 
            this.grpCreateThings.Controls.Add(this.label14);
            this.grpCreateThings.Controls.Add(this.label13);
            this.grpCreateThings.Controls.Add(this.txtHOffset);
            this.grpCreateThings.Controls.Add(this.label11);
            this.grpCreateThings.Controls.Add(this.txtZOffset);
            this.grpCreateThings.Controls.Add(this.panel3);
            this.grpCreateThings.Controls.Add(this.cmdSelectThingType);
            this.grpCreateThings.Controls.Add(this.panel2);
            this.grpCreateThings.Controls.Add(this.label6);
            this.grpCreateThings.Controls.Add(this.txtAngleOffset);
            this.grpCreateThings.Controls.Add(this.label5);
            this.grpCreateThings.Controls.Add(this.txtCreateInterval);
            this.grpCreateThings.Controls.Add(this.txtCreateType);
            this.grpCreateThings.Controls.Add(this.label4);
            this.grpCreateThings.Controls.Add(this.cmdCreateThings);
            this.grpCreateThings.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCreateThings.Location = new System.Drawing.Point(3, 147);
            this.grpCreateThings.Name = "grpCreateThings";
            this.grpCreateThings.Size = new System.Drawing.Size(280, 146);
            this.grpCreateThings.TabIndex = 26;
            this.grpCreateThings.TabStop = false;
            this.grpCreateThings.Text = "Create Things";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(143, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Offsets:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(187, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Height";
            // 
            // txtHOffset
            // 
            this.txtHOffset.Location = new System.Drawing.Point(190, 32);
            this.txtHOffset.Name = "txtHOffset";
            this.txtHOffset.Size = new System.Drawing.Size(38, 20);
            this.txtHOffset.TabIndex = 37;
            this.txtHOffset.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(231, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Z";
            // 
            // txtZOffset
            // 
            this.txtZOffset.Location = new System.Drawing.Point(234, 32);
            this.txtZOffset.Name = "txtZOffset";
            this.txtZOffset.Size = new System.Drawing.Size(38, 20);
            this.txtZOffset.TabIndex = 35;
            this.txtZOffset.Text = "0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rPlaceTop);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.rPlaceMiddle);
            this.panel3.Controls.Add(this.rPlaceBottom);
            this.panel3.Location = new System.Drawing.Point(9, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 38);
            this.panel3.TabIndex = 34;
            // 
            // rPlaceTop
            // 
            this.rPlaceTop.AutoSize = true;
            this.rPlaceTop.Location = new System.Drawing.Point(103, 16);
            this.rPlaceTop.Name = "rPlaceTop";
            this.rPlaceTop.Size = new System.Drawing.Size(44, 17);
            this.rPlaceTop.TabIndex = 19;
            this.rPlaceTop.Text = "Top";
            this.rPlaceTop.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Placement";
            // 
            // rPlaceMiddle
            // 
            this.rPlaceMiddle.AutoSize = true;
            this.rPlaceMiddle.Location = new System.Drawing.Point(55, 16);
            this.rPlaceMiddle.Name = "rPlaceMiddle";
            this.rPlaceMiddle.Size = new System.Drawing.Size(42, 17);
            this.rPlaceMiddle.TabIndex = 17;
            this.rPlaceMiddle.Text = "Mid";
            this.rPlaceMiddle.UseVisualStyleBackColor = true;
            // 
            // rPlaceBottom
            // 
            this.rPlaceBottom.AutoSize = true;
            this.rPlaceBottom.Checked = true;
            this.rPlaceBottom.Location = new System.Drawing.Point(6, 16);
            this.rPlaceBottom.Name = "rPlaceBottom";
            this.rPlaceBottom.Size = new System.Drawing.Size(41, 17);
            this.rPlaceBottom.TabIndex = 16;
            this.rPlaceBottom.TabStop = true;
            this.rPlaceBottom.Text = "Bot";
            this.rPlaceBottom.UseVisualStyleBackColor = true;
            // 
            // cmdSelectThingType
            // 
            this.cmdSelectThingType.Location = new System.Drawing.Point(54, 30);
            this.cmdSelectThingType.Name = "cmdSelectThingType";
            this.cmdSelectThingType.Size = new System.Drawing.Size(36, 23);
            this.cmdSelectThingType.TabIndex = 33;
            this.cmdSelectThingType.Text = "...";
            this.cmdSelectThingType.UseVisualStyleBackColor = true;
            this.cmdSelectThingType.Click += new System.EventHandler(this.cmdSelectThingType_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rApplyZNone);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.rApplyZPitch);
            this.panel2.Controls.Add(this.rApplyZRoll);
            this.panel2.Location = new System.Drawing.Point(10, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 39);
            this.panel2.TabIndex = 32;
            // 
            // rApplyZNone
            // 
            this.rApplyZNone.AutoSize = true;
            this.rApplyZNone.Location = new System.Drawing.Point(102, 16);
            this.rApplyZNone.Name = "rApplyZNone";
            this.rApplyZNone.Size = new System.Drawing.Size(51, 17);
            this.rApplyZNone.TabIndex = 23;
            this.rApplyZNone.Text = "None";
            this.rApplyZNone.UseVisualStyleBackColor = true;
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
            // rApplyZPitch
            // 
            this.rApplyZPitch.AutoSize = true;
            this.rApplyZPitch.Checked = true;
            this.rApplyZPitch.Location = new System.Drawing.Point(5, 16);
            this.rApplyZPitch.Name = "rApplyZPitch";
            this.rApplyZPitch.Size = new System.Drawing.Size(49, 17);
            this.rApplyZPitch.TabIndex = 20;
            this.rApplyZPitch.TabStop = true;
            this.rApplyZPitch.Text = "Pitch";
            this.rApplyZPitch.UseVisualStyleBackColor = true;
            // 
            // rApplyZRoll
            // 
            this.rApplyZRoll.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.rApplyZRoll.AutoSize = true;
            this.rApplyZRoll.Location = new System.Drawing.Point(56, 16);
            this.rApplyZRoll.Name = "rApplyZRoll";
            this.rApplyZRoll.Size = new System.Drawing.Size(43, 17);
            this.rApplyZRoll.TabIndex = 21;
            this.rApplyZRoll.Text = "Roll";
            this.rApplyZRoll.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Angle";
            // 
            // txtAngleOffset
            // 
            this.txtAngleOffset.Location = new System.Drawing.Point(146, 32);
            this.txtAngleOffset.Name = "txtAngleOffset";
            this.txtAngleOffset.Size = new System.Drawing.Size(38, 20);
            this.txtAngleOffset.TabIndex = 29;
            this.txtAngleOffset.Text = "90";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Interval";
            // 
            // txtCreateInterval
            // 
            this.txtCreateInterval.Location = new System.Drawing.Point(96, 32);
            this.txtCreateInterval.Name = "txtCreateInterval";
            this.txtCreateInterval.Size = new System.Drawing.Size(41, 20);
            this.txtCreateInterval.TabIndex = 27;
            this.txtCreateInterval.Text = "384";
            // 
            // txtCreateType
            // 
            this.txtCreateType.Location = new System.Drawing.Point(6, 32);
            this.txtCreateType.Name = "txtCreateType";
            this.txtCreateType.Size = new System.Drawing.Size(42, 20);
            this.txtCreateType.TabIndex = 26;
            this.txtCreateType.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Thing Type";
            // 
            // cmdCreateThings
            // 
            this.cmdCreateThings.Location = new System.Drawing.Point(197, 115);
            this.cmdCreateThings.Name = "cmdCreateThings";
            this.cmdCreateThings.Size = new System.Drawing.Size(75, 23);
            this.cmdCreateThings.TabIndex = 24;
            this.cmdCreateThings.Text = "Create";
            this.cmdCreateThings.UseVisualStyleBackColor = true;
            this.cmdCreateThings.Click += new System.EventHandler(this.cmdCreateThings_Click);
            // 
            // grpAdjustments
            // 
            this.grpAdjustments.Controls.Add(this.label9);
            this.grpAdjustments.Controls.Add(this.label1);
            this.grpAdjustments.Controls.Add(this.chkAdjustAngle);
            this.grpAdjustments.Controls.Add(this.cmdAdjustAngle);
            this.grpAdjustments.Controls.Add(this.chkAdjustPitch);
            this.grpAdjustments.Controls.Add(this.label3);
            this.grpAdjustments.Controls.Add(this.txtUnitTime);
            this.grpAdjustments.Controls.Add(this.cmdAdjustSpeed);
            this.grpAdjustments.Controls.Add(this.label2);
            this.grpAdjustments.Controls.Add(this.txtUnitLength);
            this.grpAdjustments.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpAdjustments.Location = new System.Drawing.Point(3, 50);
            this.grpAdjustments.Name = "grpAdjustments";
            this.grpAdjustments.Size = new System.Drawing.Size(280, 97);
            this.grpAdjustments.TabIndex = 27;
            this.grpAdjustments.TabStop = false;
            this.grpAdjustments.Text = "Adjustments";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Travel Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Direction:";
            // 
            // grpMassCreate
            // 
            this.grpMassCreate.Controls.Add(this.txtMassScale);
            this.grpMassCreate.Controls.Add(this.lblMassScale);
            this.grpMassCreate.Controls.Add(this.chkMassLinkNodes);
            this.grpMassCreate.Controls.Add(this.txtCoordList);
            this.grpMassCreate.Controls.Add(this.cmdCreateEnMasse);
            this.grpMassCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpMassCreate.Location = new System.Drawing.Point(3, 355);
            this.grpMassCreate.Name = "grpMassCreate";
            this.grpMassCreate.Size = new System.Drawing.Size(280, 116);
            this.grpMassCreate.TabIndex = 28;
            this.grpMassCreate.TabStop = false;
            this.grpMassCreate.Text = "Mass Node Maker (paste coords)";
            // 
            // txtMassScale
            // 
            this.txtMassScale.Location = new System.Drawing.Point(197, 55);
            this.txtMassScale.Name = "txtMassScale";
            this.txtMassScale.Size = new System.Drawing.Size(75, 20);
            this.txtMassScale.TabIndex = 4;
            this.txtMassScale.Text = "1.0";
            // 
            // lblMassScale
            // 
            this.lblMassScale.AutoSize = true;
            this.lblMassScale.Location = new System.Drawing.Point(197, 39);
            this.lblMassScale.Name = "lblMassScale";
            this.lblMassScale.Size = new System.Drawing.Size(34, 13);
            this.lblMassScale.TabIndex = 3;
            this.lblMassScale.Text = "Scale";
            // 
            // chkMassLinkNodes
            // 
            this.chkMassLinkNodes.AutoSize = true;
            this.chkMassLinkNodes.Location = new System.Drawing.Point(197, 19);
            this.chkMassLinkNodes.Name = "chkMassLinkNodes";
            this.chkMassLinkNodes.Size = new System.Drawing.Size(80, 17);
            this.chkMassLinkNodes.TabIndex = 2;
            this.chkMassLinkNodes.Text = "Link Nodes";
            this.chkMassLinkNodes.UseVisualStyleBackColor = true;
            // 
            // txtCoordList
            // 
            this.txtCoordList.Location = new System.Drawing.Point(6, 19);
            this.txtCoordList.Multiline = true;
            this.txtCoordList.Name = "txtCoordList";
            this.txtCoordList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCoordList.Size = new System.Drawing.Size(185, 91);
            this.txtCoordList.TabIndex = 1;
            // 
            // cmdCreateEnMasse
            // 
            this.cmdCreateEnMasse.Location = new System.Drawing.Point(197, 87);
            this.cmdCreateEnMasse.Name = "cmdCreateEnMasse";
            this.cmdCreateEnMasse.Size = new System.Drawing.Size(75, 23);
            this.cmdCreateEnMasse.TabIndex = 0;
            this.cmdCreateEnMasse.Text = "Create";
            this.cmdCreateEnMasse.UseVisualStyleBackColor = true;
            this.cmdCreateEnMasse.Click += new System.EventHandler(this.cmdCreateEnMasse_Click);
            // 
            // grpLineType
            // 
            this.grpLineType.Controls.Add(this.rLineTypeSpline);
            this.grpLineType.Controls.Add(this.rLineTypeLinear);
            this.grpLineType.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpLineType.Location = new System.Drawing.Point(3, 3);
            this.grpLineType.Name = "grpLineType";
            this.grpLineType.Size = new System.Drawing.Size(280, 47);
            this.grpLineType.TabIndex = 29;
            this.grpLineType.TabStop = false;
            this.grpLineType.Text = "Line Type";
            // 
            // rLineTypeSpline
            // 
            this.rLineTypeSpline.AutoSize = true;
            this.rLineTypeSpline.Checked = true;
            this.rLineTypeSpline.Location = new System.Drawing.Point(70, 19);
            this.rLineTypeSpline.Name = "rLineTypeSpline";
            this.rLineTypeSpline.Size = new System.Drawing.Size(54, 17);
            this.rLineTypeSpline.TabIndex = 19;
            this.rLineTypeSpline.TabStop = true;
            this.rLineTypeSpline.Text = "Spline";
            this.rLineTypeSpline.UseVisualStyleBackColor = true;
            // 
            // rLineTypeLinear
            // 
            this.rLineTypeLinear.AutoSize = true;
            this.rLineTypeLinear.Location = new System.Drawing.Point(10, 19);
            this.rLineTypeLinear.Name = "rLineTypeLinear";
            this.rLineTypeLinear.Size = new System.Drawing.Size(54, 17);
            this.rLineTypeLinear.TabIndex = 18;
            this.rLineTypeLinear.Text = "Linear";
            this.rLineTypeLinear.UseVisualStyleBackColor = true;
            // 
            // chkUnusedOnly
            // 
            this.chkUnusedOnly.AutoSize = true;
            this.chkUnusedOnly.Location = new System.Drawing.Point(137, 12);
            this.chkUnusedOnly.Name = "chkUnusedOnly";
            this.chkUnusedOnly.Size = new System.Drawing.Size(135, 17);
            this.chkUnusedOnly.TabIndex = 3;
            this.chkUnusedOnly.Text = "Use Only Unused TIDs";
            this.chkUnusedOnly.UseVisualStyleBackColor = true;
            // 
            // fTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 474);
            this.Controls.Add(this.grpMassCreate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpCreateThings);
            this.Controls.Add(this.grpAdjustments);
            this.Controls.Add(this.grpLineType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fTools";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Path Tools";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpCreateThings.ResumeLayout(false);
            this.grpCreateThings.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpAdjustments.ResumeLayout(false);
            this.grpAdjustments.PerformLayout();
            this.grpMassCreate.ResumeLayout(false);
            this.grpMassCreate.PerformLayout();
            this.grpLineType.ResumeLayout(false);
            this.grpLineType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAdjustSpeed;
        private System.Windows.Forms.TextBox txtUnitLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnitTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdAdjustAngle;
        private System.Windows.Forms.CheckBox chkAdjustAngle;
        private System.Windows.Forms.CheckBox chkAdjustPitch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdRetag;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRetagStart;
        private System.Windows.Forms.GroupBox grpCreateThings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rApplyZNone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rApplyZPitch;
        private System.Windows.Forms.RadioButton rApplyZRoll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAngleOffset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCreateInterval;
        private System.Windows.Forms.TextBox txtCreateType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdCreateThings;
        private System.Windows.Forms.Button cmdSelectThingType;
        private System.Windows.Forms.GroupBox grpAdjustments;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rPlaceTop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rPlaceMiddle;
        private System.Windows.Forms.RadioButton rPlaceBottom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtZOffset;
        private System.Windows.Forms.GroupBox grpMassCreate;
        private System.Windows.Forms.CheckBox chkMassLinkNodes;
        private System.Windows.Forms.TextBox txtCoordList;
        private System.Windows.Forms.Button cmdCreateEnMasse;
        private System.Windows.Forms.TextBox txtMassScale;
        private System.Windows.Forms.Label lblMassScale;
        private System.Windows.Forms.TextBox txtHOffset;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grpLineType;
        private System.Windows.Forms.RadioButton rLineTypeSpline;
        private System.Windows.Forms.RadioButton rLineTypeLinear;
        private System.Windows.Forms.CheckBox chkUnusedOnly;
    }
}