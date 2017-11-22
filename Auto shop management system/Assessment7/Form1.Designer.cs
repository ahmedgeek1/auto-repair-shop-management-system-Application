namespace Assessment7
{
    partial class JoeAutomotive
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
            this.groupBoxOilAndLube = new System.Windows.Forms.GroupBox();
            this.checkBoxLubeJob = new System.Windows.Forms.CheckBox();
            this.checkBoxOilChange = new System.Windows.Forms.CheckBox();
            this.groupBoxFlushes = new System.Windows.Forms.GroupBox();
            this.checkBoxTransmissionFlush = new System.Windows.Forms.CheckBox();
            this.checkBoxRadiatorFlush = new System.Windows.Forms.CheckBox();
            this.groupBoxMisc = new System.Windows.Forms.GroupBox();
            this.checkBoxInspection = new System.Windows.Forms.CheckBox();
            this.checkBoxReplaceMuffler = new System.Windows.Forms.CheckBox();
            this.checkBoxTireRotation = new System.Windows.Forms.CheckBox();
            this.groupBoxPartsAndLabor = new System.Windows.Forms.GroupBox();
            this.LaborPromptLabel = new System.Windows.Forms.Label();
            this.PartsPromptLabel = new System.Windows.Forms.Label();
            this.txtBoxLaborInput = new System.Windows.Forms.TextBox();
            this.txtBoxPartsInput = new System.Windows.Forms.TextBox();
            this.groupBoxSummary = new System.Windows.Forms.GroupBox();
            this.lblPartsSummaryOutput = new System.Windows.Forms.Label();
            this.lblTaxSummaryOutput = new System.Windows.Forms.Label();
            this.lblTotalFeesSummaryOutput = new System.Windows.Forms.Label();
            this.lblServicesAndLaborSummaryOutput = new System.Windows.Forms.Label();
            this.lblTaxPrompt = new System.Windows.Forms.Label();
            this.lblServicesAndLaborPrompt = new System.Windows.Forms.Label();
            this.lblPartsPrompt = new System.Windows.Forms.Label();
            this.lblTotalFeesPrompt = new System.Windows.Forms.Label();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUserDailyPricePrompt = new System.Windows.Forms.Label();
            this.txtBoxDailyPrice = new System.Windows.Forms.TextBox();
            this.lblNumberOfDaysRentalCarPrompt = new System.Windows.Forms.Label();
            this.checkBoxRentalCar = new System.Windows.Forms.CheckBox();
            this.txtBoxNumberOfDaysRentalCar = new System.Windows.Forms.TextBox();
            this.lblRentalChargesPrompt = new System.Windows.Forms.Label();
            this.lblRentalChargesOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxOilAndLube.SuspendLayout();
            this.groupBoxFlushes.SuspendLayout();
            this.groupBoxMisc.SuspendLayout();
            this.groupBoxPartsAndLabor.SuspendLayout();
            this.groupBoxSummary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOilAndLube
            // 
            this.groupBoxOilAndLube.Controls.Add(this.checkBoxLubeJob);
            this.groupBoxOilAndLube.Controls.Add(this.checkBoxOilChange);
            this.groupBoxOilAndLube.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOilAndLube.Location = new System.Drawing.Point(21, 31);
            this.groupBoxOilAndLube.Name = "groupBoxOilAndLube";
            this.groupBoxOilAndLube.Size = new System.Drawing.Size(200, 88);
            this.groupBoxOilAndLube.TabIndex = 0;
            this.groupBoxOilAndLube.TabStop = false;
            this.groupBoxOilAndLube.Text = "Oil and Lube";
            this.groupBoxOilAndLube.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBoxLubeJob
            // 
            this.checkBoxLubeJob.AutoSize = true;
            this.checkBoxLubeJob.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxLubeJob.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLubeJob.Location = new System.Drawing.Point(6, 55);
            this.checkBoxLubeJob.Name = "checkBoxLubeJob";
            this.checkBoxLubeJob.Size = new System.Drawing.Size(135, 21);
            this.checkBoxLubeJob.TabIndex = 1;
            this.checkBoxLubeJob.Text = "Lube Job ($18.00)";
            this.checkBoxLubeJob.UseVisualStyleBackColor = true;
            // 
            // checkBoxOilChange
            // 
            this.checkBoxOilChange.AutoSize = true;
            this.checkBoxOilChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxOilChange.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOilChange.Location = new System.Drawing.Point(6, 32);
            this.checkBoxOilChange.Name = "checkBoxOilChange";
            this.checkBoxOilChange.Size = new System.Drawing.Size(148, 21);
            this.checkBoxOilChange.TabIndex = 0;
            this.checkBoxOilChange.Text = "Oil Change ($26.00)";
            this.checkBoxOilChange.UseVisualStyleBackColor = true;
            // 
            // groupBoxFlushes
            // 
            this.groupBoxFlushes.Controls.Add(this.checkBoxTransmissionFlush);
            this.groupBoxFlushes.Controls.Add(this.checkBoxRadiatorFlush);
            this.groupBoxFlushes.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFlushes.Location = new System.Drawing.Point(334, 31);
            this.groupBoxFlushes.Name = "groupBoxFlushes";
            this.groupBoxFlushes.Size = new System.Drawing.Size(222, 88);
            this.groupBoxFlushes.TabIndex = 1;
            this.groupBoxFlushes.TabStop = false;
            this.groupBoxFlushes.Text = "Flushes";
            // 
            // checkBoxTransmissionFlush
            // 
            this.checkBoxTransmissionFlush.AutoSize = true;
            this.checkBoxTransmissionFlush.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxTransmissionFlush.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTransmissionFlush.Location = new System.Drawing.Point(19, 55);
            this.checkBoxTransmissionFlush.Name = "checkBoxTransmissionFlush";
            this.checkBoxTransmissionFlush.Size = new System.Drawing.Size(195, 21);
            this.checkBoxTransmissionFlush.TabIndex = 7;
            this.checkBoxTransmissionFlush.Text = "Transmission Flush ($80.00)";
            this.checkBoxTransmissionFlush.UseVisualStyleBackColor = true;
            // 
            // checkBoxRadiatorFlush
            // 
            this.checkBoxRadiatorFlush.AutoSize = true;
            this.checkBoxRadiatorFlush.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxRadiatorFlush.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRadiatorFlush.Location = new System.Drawing.Point(19, 32);
            this.checkBoxRadiatorFlush.Name = "checkBoxRadiatorFlush";
            this.checkBoxRadiatorFlush.Size = new System.Drawing.Size(169, 21);
            this.checkBoxRadiatorFlush.TabIndex = 8;
            this.checkBoxRadiatorFlush.Text = "Radiator flush ($30.00) ";
            this.checkBoxRadiatorFlush.UseVisualStyleBackColor = true;
            // 
            // groupBoxMisc
            // 
            this.groupBoxMisc.Controls.Add(this.checkBoxInspection);
            this.groupBoxMisc.Controls.Add(this.checkBoxReplaceMuffler);
            this.groupBoxMisc.Controls.Add(this.checkBoxTireRotation);
            this.groupBoxMisc.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMisc.Location = new System.Drawing.Point(27, 139);
            this.groupBoxMisc.Name = "groupBoxMisc";
            this.groupBoxMisc.Size = new System.Drawing.Size(200, 116);
            this.groupBoxMisc.TabIndex = 2;
            this.groupBoxMisc.TabStop = false;
            this.groupBoxMisc.Text = "Misc";
            // 
            // checkBoxInspection
            // 
            this.checkBoxInspection.AutoSize = true;
            this.checkBoxInspection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxInspection.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInspection.Location = new System.Drawing.Point(6, 37);
            this.checkBoxInspection.Name = "checkBoxInspection";
            this.checkBoxInspection.Size = new System.Drawing.Size(144, 21);
            this.checkBoxInspection.TabIndex = 9;
            this.checkBoxInspection.Text = "Inspection ($15.00)";
            this.checkBoxInspection.UseVisualStyleBackColor = true;
            // 
            // checkBoxReplaceMuffler
            // 
            this.checkBoxReplaceMuffler.AutoSize = true;
            this.checkBoxReplaceMuffler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxReplaceMuffler.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxReplaceMuffler.Location = new System.Drawing.Point(6, 60);
            this.checkBoxReplaceMuffler.Name = "checkBoxReplaceMuffler";
            this.checkBoxReplaceMuffler.Size = new System.Drawing.Size(185, 21);
            this.checkBoxReplaceMuffler.TabIndex = 10;
            this.checkBoxReplaceMuffler.Text = "Replace Muffler ($100.00)";
            this.checkBoxReplaceMuffler.UseVisualStyleBackColor = true;
            // 
            // checkBoxTireRotation
            // 
            this.checkBoxTireRotation.AutoSize = true;
            this.checkBoxTireRotation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxTireRotation.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTireRotation.Location = new System.Drawing.Point(6, 83);
            this.checkBoxTireRotation.Name = "checkBoxTireRotation";
            this.checkBoxTireRotation.Size = new System.Drawing.Size(158, 21);
            this.checkBoxTireRotation.TabIndex = 11;
            this.checkBoxTireRotation.Text = "Tire Rotation ($20.00)";
            this.checkBoxTireRotation.UseVisualStyleBackColor = true;
            // 
            // groupBoxPartsAndLabor
            // 
            this.groupBoxPartsAndLabor.Controls.Add(this.LaborPromptLabel);
            this.groupBoxPartsAndLabor.Controls.Add(this.PartsPromptLabel);
            this.groupBoxPartsAndLabor.Controls.Add(this.txtBoxLaborInput);
            this.groupBoxPartsAndLabor.Controls.Add(this.txtBoxPartsInput);
            this.groupBoxPartsAndLabor.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPartsAndLabor.Location = new System.Drawing.Point(334, 139);
            this.groupBoxPartsAndLabor.Name = "groupBoxPartsAndLabor";
            this.groupBoxPartsAndLabor.Size = new System.Drawing.Size(222, 116);
            this.groupBoxPartsAndLabor.TabIndex = 2;
            this.groupBoxPartsAndLabor.TabStop = false;
            this.groupBoxPartsAndLabor.Text = "Parts and Labor";
            // 
            // LaborPromptLabel
            // 
            this.LaborPromptLabel.AutoSize = true;
            this.LaborPromptLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaborPromptLabel.Location = new System.Drawing.Point(16, 83);
            this.LaborPromptLabel.Name = "LaborPromptLabel";
            this.LaborPromptLabel.Size = new System.Drawing.Size(90, 17);
            this.LaborPromptLabel.TabIndex = 7;
            this.LaborPromptLabel.Text = "Labor (hours)";
            // 
            // PartsPromptLabel
            // 
            this.PartsPromptLabel.AutoSize = true;
            this.PartsPromptLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsPromptLabel.Location = new System.Drawing.Point(16, 38);
            this.PartsPromptLabel.Name = "PartsPromptLabel";
            this.PartsPromptLabel.Size = new System.Drawing.Size(39, 17);
            this.PartsPromptLabel.TabIndex = 8;
            this.PartsPromptLabel.Text = "Parts";
            // 
            // txtBoxLaborInput
            // 
            this.txtBoxLaborInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLaborInput.Location = new System.Drawing.Point(112, 79);
            this.txtBoxLaborInput.Name = "txtBoxLaborInput";
            this.txtBoxLaborInput.Size = new System.Drawing.Size(100, 27);
            this.txtBoxLaborInput.TabIndex = 9;
            this.txtBoxLaborInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxPartsInput
            // 
            this.txtBoxPartsInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPartsInput.Location = new System.Drawing.Point(112, 36);
            this.txtBoxPartsInput.Name = "txtBoxPartsInput";
            this.txtBoxPartsInput.Size = new System.Drawing.Size(100, 27);
            this.txtBoxPartsInput.TabIndex = 10;
            this.txtBoxPartsInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxSummary
            // 
            this.groupBoxSummary.Controls.Add(this.lblRentalChargesOutput);
            this.groupBoxSummary.Controls.Add(this.lblRentalChargesPrompt);
            this.groupBoxSummary.Controls.Add(this.lblPartsSummaryOutput);
            this.groupBoxSummary.Controls.Add(this.lblTaxSummaryOutput);
            this.groupBoxSummary.Controls.Add(this.lblTotalFeesSummaryOutput);
            this.groupBoxSummary.Controls.Add(this.lblServicesAndLaborSummaryOutput);
            this.groupBoxSummary.Controls.Add(this.lblTaxPrompt);
            this.groupBoxSummary.Controls.Add(this.lblServicesAndLaborPrompt);
            this.groupBoxSummary.Controls.Add(this.lblPartsPrompt);
            this.groupBoxSummary.Controls.Add(this.lblTotalFeesPrompt);
            this.groupBoxSummary.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSummary.Location = new System.Drawing.Point(27, 384);
            this.groupBoxSummary.Name = "groupBoxSummary";
            this.groupBoxSummary.Size = new System.Drawing.Size(529, 201);
            this.groupBoxSummary.TabIndex = 3;
            this.groupBoxSummary.TabStop = false;
            this.groupBoxSummary.Text = "Summary";
            // 
            // lblPartsSummaryOutput
            // 
            this.lblPartsSummaryOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPartsSummaryOutput.Location = new System.Drawing.Point(233, 90);
            this.lblPartsSummaryOutput.Name = "lblPartsSummaryOutput";
            this.lblPartsSummaryOutput.Size = new System.Drawing.Size(160, 25);
            this.lblPartsSummaryOutput.TabIndex = 19;
            this.lblPartsSummaryOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaxSummaryOutput
            // 
            this.lblTaxSummaryOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTaxSummaryOutput.Location = new System.Drawing.Point(235, 127);
            this.lblTaxSummaryOutput.Name = "lblTaxSummaryOutput";
            this.lblTaxSummaryOutput.Size = new System.Drawing.Size(160, 25);
            this.lblTaxSummaryOutput.TabIndex = 18;
            this.lblTaxSummaryOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalFeesSummaryOutput
            // 
            this.lblTotalFeesSummaryOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalFeesSummaryOutput.Location = new System.Drawing.Point(235, 160);
            this.lblTotalFeesSummaryOutput.Name = "lblTotalFeesSummaryOutput";
            this.lblTotalFeesSummaryOutput.Size = new System.Drawing.Size(160, 25);
            this.lblTotalFeesSummaryOutput.TabIndex = 17;
            this.lblTotalFeesSummaryOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServicesAndLaborSummaryOutput
            // 
            this.lblServicesAndLaborSummaryOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblServicesAndLaborSummaryOutput.Location = new System.Drawing.Point(233, 16);
            this.lblServicesAndLaborSummaryOutput.Name = "lblServicesAndLaborSummaryOutput";
            this.lblServicesAndLaborSummaryOutput.Size = new System.Drawing.Size(160, 25);
            this.lblServicesAndLaborSummaryOutput.TabIndex = 16;
            this.lblServicesAndLaborSummaryOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaxPrompt
            // 
            this.lblTaxPrompt.AutoSize = true;
            this.lblTaxPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxPrompt.Location = new System.Drawing.Point(28, 137);
            this.lblTaxPrompt.Name = "lblTaxPrompt";
            this.lblTaxPrompt.Size = new System.Drawing.Size(92, 17);
            this.lblTaxPrompt.TabIndex = 15;
            this.lblTaxPrompt.Text = "Tax (on parts)";
            // 
            // lblServicesAndLaborPrompt
            // 
            this.lblServicesAndLaborPrompt.AutoSize = true;
            this.lblServicesAndLaborPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicesAndLaborPrompt.Location = new System.Drawing.Point(18, 26);
            this.lblServicesAndLaborPrompt.Name = "lblServicesAndLaborPrompt";
            this.lblServicesAndLaborPrompt.Size = new System.Drawing.Size(124, 17);
            this.lblServicesAndLaborPrompt.TabIndex = 9;
            this.lblServicesAndLaborPrompt.Text = "Services and Labor";
            // 
            // lblPartsPrompt
            // 
            this.lblPartsPrompt.AutoSize = true;
            this.lblPartsPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartsPrompt.Location = new System.Drawing.Point(28, 100);
            this.lblPartsPrompt.Name = "lblPartsPrompt";
            this.lblPartsPrompt.Size = new System.Drawing.Size(39, 17);
            this.lblPartsPrompt.TabIndex = 10;
            this.lblPartsPrompt.Text = "Parts";
            // 
            // lblTotalFeesPrompt
            // 
            this.lblTotalFeesPrompt.AutoSize = true;
            this.lblTotalFeesPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFeesPrompt.Location = new System.Drawing.Point(28, 170);
            this.lblTotalFeesPrompt.Name = "lblTotalFeesPrompt";
            this.lblTotalFeesPrompt.Size = new System.Drawing.Size(69, 17);
            this.lblTotalFeesPrompt.TabIndex = 11;
            this.lblTotalFeesPrompt.Text = "Total Fees";
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.BackColor = System.Drawing.Color.Firebrick;
            this.btnCalculateTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateTotal.ForeColor = System.Drawing.Color.White;
            this.btnCalculateTotal.Location = new System.Drawing.Point(60, 621);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(161, 36);
            this.btnCalculateTotal.TabIndex = 4;
            this.btnCalculateTotal.Text = "Calculate Total";
            this.btnCalculateTotal.UseVisualStyleBackColor = false;
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Firebrick;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(246, 621);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 36);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(382, 621);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUserDailyPricePrompt);
            this.groupBox1.Controls.Add(this.txtBoxDailyPrice);
            this.groupBox1.Controls.Add(this.lblNumberOfDaysRentalCarPrompt);
            this.groupBox1.Controls.Add(this.checkBoxRentalCar);
            this.groupBox1.Controls.Add(this.txtBoxNumberOfDaysRentalCar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 92);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rental Services";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // lblUserDailyPricePrompt
            // 
            this.lblUserDailyPricePrompt.AutoSize = true;
            this.lblUserDailyPricePrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDailyPricePrompt.Location = new System.Drawing.Point(267, 22);
            this.lblUserDailyPricePrompt.Name = "lblUserDailyPricePrompt";
            this.lblUserDailyPricePrompt.Size = new System.Drawing.Size(72, 17);
            this.lblUserDailyPricePrompt.TabIndex = 4;
            this.lblUserDailyPricePrompt.Text = "Daily price";
            // 
            // txtBoxDailyPrice
            // 
            this.txtBoxDailyPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDailyPrice.Location = new System.Drawing.Point(369, 17);
            this.txtBoxDailyPrice.Name = "txtBoxDailyPrice";
            this.txtBoxDailyPrice.Size = new System.Drawing.Size(128, 27);
            this.txtBoxDailyPrice.TabIndex = 3;
            this.txtBoxDailyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumberOfDaysRentalCarPrompt
            // 
            this.lblNumberOfDaysRentalCarPrompt.AutoSize = true;
            this.lblNumberOfDaysRentalCarPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDaysRentalCarPrompt.Location = new System.Drawing.Point(62, 58);
            this.lblNumberOfDaysRentalCarPrompt.Name = "lblNumberOfDaysRentalCarPrompt";
            this.lblNumberOfDaysRentalCarPrompt.Size = new System.Drawing.Size(207, 17);
            this.lblNumberOfDaysRentalCarPrompt.TabIndex = 2;
            this.lblNumberOfDaysRentalCarPrompt.Text = "Please enter the number of days";
            // 
            // checkBoxRentalCar
            // 
            this.checkBoxRentalCar.AutoSize = true;
            this.checkBoxRentalCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxRentalCar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRentalCar.Location = new System.Drawing.Point(19, 28);
            this.checkBoxRentalCar.Name = "checkBoxRentalCar";
            this.checkBoxRentalCar.Size = new System.Drawing.Size(98, 21);
            this.checkBoxRentalCar.TabIndex = 0;
            this.checkBoxRentalCar.Text = "A rental Car";
            this.checkBoxRentalCar.UseVisualStyleBackColor = true;
            this.checkBoxRentalCar.CheckedChanged += new System.EventHandler(this.checkBoxRentalCar_CheckedChanged);
            // 
            // txtBoxNumberOfDaysRentalCar
            // 
            this.txtBoxNumberOfDaysRentalCar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumberOfDaysRentalCar.Location = new System.Drawing.Point(285, 53);
            this.txtBoxNumberOfDaysRentalCar.Name = "txtBoxNumberOfDaysRentalCar";
            this.txtBoxNumberOfDaysRentalCar.Size = new System.Drawing.Size(128, 27);
            this.txtBoxNumberOfDaysRentalCar.TabIndex = 1;
            this.txtBoxNumberOfDaysRentalCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRentalChargesPrompt
            // 
            this.lblRentalChargesPrompt.AutoSize = true;
            this.lblRentalChargesPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalChargesPrompt.Location = new System.Drawing.Point(28, 61);
            this.lblRentalChargesPrompt.Name = "lblRentalChargesPrompt";
            this.lblRentalChargesPrompt.Size = new System.Drawing.Size(100, 17);
            this.lblRentalChargesPrompt.TabIndex = 20;
            this.lblRentalChargesPrompt.Text = "Rental Charges";
            // 
            // lblRentalChargesOutput
            // 
            this.lblRentalChargesOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRentalChargesOutput.Location = new System.Drawing.Point(232, 51);
            this.lblRentalChargesOutput.Name = "lblRentalChargesOutput";
            this.lblRentalChargesOutput.Size = new System.Drawing.Size(161, 23);
            this.lblRentalChargesOutput.TabIndex = 21;
            this.lblRentalChargesOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(497, 656);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "© Ahmed Matoussi";
            // 
            // JoeAutomotive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(628, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateTotal);
            this.Controls.Add(this.groupBoxSummary);
            this.Controls.Add(this.groupBoxPartsAndLabor);
            this.Controls.Add(this.groupBoxMisc);
            this.Controls.Add(this.groupBoxFlushes);
            this.Controls.Add(this.groupBoxOilAndLube);
            this.Name = "JoeAutomotive";
            this.Text = "Joe’s Automotive";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxOilAndLube.ResumeLayout(false);
            this.groupBoxOilAndLube.PerformLayout();
            this.groupBoxFlushes.ResumeLayout(false);
            this.groupBoxFlushes.PerformLayout();
            this.groupBoxMisc.ResumeLayout(false);
            this.groupBoxMisc.PerformLayout();
            this.groupBoxPartsAndLabor.ResumeLayout(false);
            this.groupBoxPartsAndLabor.PerformLayout();
            this.groupBoxSummary.ResumeLayout(false);
            this.groupBoxSummary.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOilAndLube;
        private System.Windows.Forms.CheckBox checkBoxLubeJob;
        private System.Windows.Forms.CheckBox checkBoxOilChange;
        private System.Windows.Forms.GroupBox groupBoxFlushes;
        private System.Windows.Forms.CheckBox checkBoxTransmissionFlush;
        private System.Windows.Forms.CheckBox checkBoxRadiatorFlush;
        private System.Windows.Forms.GroupBox groupBoxMisc;
        private System.Windows.Forms.CheckBox checkBoxInspection;
        private System.Windows.Forms.CheckBox checkBoxReplaceMuffler;
        private System.Windows.Forms.CheckBox checkBoxTireRotation;
        private System.Windows.Forms.GroupBox groupBoxPartsAndLabor;
        private System.Windows.Forms.Label LaborPromptLabel;
        private System.Windows.Forms.Label PartsPromptLabel;
        private System.Windows.Forms.TextBox txtBoxLaborInput;
        private System.Windows.Forms.TextBox txtBoxPartsInput;
        private System.Windows.Forms.GroupBox groupBoxSummary;
        private System.Windows.Forms.Label lblServicesAndLaborPrompt;
        private System.Windows.Forms.Label lblPartsPrompt;
        private System.Windows.Forms.Label lblTotalFeesPrompt;
        private System.Windows.Forms.Button btnCalculateTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTaxPrompt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumberOfDaysRentalCarPrompt;
        private System.Windows.Forms.CheckBox checkBoxRentalCar;
        private System.Windows.Forms.TextBox txtBoxNumberOfDaysRentalCar;
        private System.Windows.Forms.Label lblUserDailyPricePrompt;
        private System.Windows.Forms.TextBox txtBoxDailyPrice;
        private System.Windows.Forms.Label lblPartsSummaryOutput;
        private System.Windows.Forms.Label lblTaxSummaryOutput;
        private System.Windows.Forms.Label lblTotalFeesSummaryOutput;
        private System.Windows.Forms.Label lblServicesAndLaborSummaryOutput;
        private System.Windows.Forms.Label lblRentalChargesOutput;
        private System.Windows.Forms.Label lblRentalChargesPrompt;
        private System.Windows.Forms.Label label2;
    }
}

