namespace UV_DLP_3D_Printer.GUI.Controls.ManualControls
{
    partial class ctlAdvancedManual
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctlMoveX = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ctlMoveY = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ctlXspeed = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.ctlYspeed = new System.Windows.Forms.NumericUpDown();
            this.btnZspeed = new System.Windows.Forms.Button();
            this.ctlZspeed = new System.Windows.Forms.NumericUpDown();
            this.btnYspeed = new System.Windows.Forms.Button();
            this.btnXspeed = new System.Windows.Forms.Button();
            this.btnMoveYaxis = new System.Windows.Forms.Button();
            this.btnMoveXaxis = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtMovePrinting = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoveFeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpread = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numAmountLayers = new System.Windows.Forms.NumericUpDown();
            this.btnMoveFeed = new System.Windows.Forms.Button();
            this.btnMovePrinting = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ctlRFrame1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlRFrame();
            ((System.ComponentModel.ISupportInitialize)(this.ctlMoveX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlMoveY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlXspeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlYspeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlZspeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountLayers)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(32, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 29);
            this.label3.TabIndex = 94;
            this.label3.Text = "Move X-axis :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(32, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 29);
            this.label4.TabIndex = 97;
            this.label4.Text = "Move Y-axis :";
            // 
            // ctlMoveX
            // 
            this.ctlMoveX.Location = new System.Drawing.Point(252, 68);
            this.ctlMoveX.Margin = new System.Windows.Forms.Padding(6);
            this.ctlMoveX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ctlMoveX.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ctlMoveX.Name = "ctlMoveX";
            this.ctlMoveX.Size = new System.Drawing.Size(196, 31);
            this.ctlMoveX.TabIndex = 96;
            this.ctlMoveX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(32, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 29);
            this.label6.TabIndex = 100;
            this.label6.Text = "X speed :";
            // 
            // ctlMoveY
            // 
            this.ctlMoveY.Location = new System.Drawing.Point(252, 137);
            this.ctlMoveY.Margin = new System.Windows.Forms.Padding(6);
            this.ctlMoveY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ctlMoveY.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ctlMoveY.Name = "ctlMoveY";
            this.ctlMoveY.Size = new System.Drawing.Size(196, 31);
            this.ctlMoveY.TabIndex = 99;
            this.ctlMoveY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(32, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 29);
            this.label7.TabIndex = 103;
            this.label7.Text = "Y speed :";
            // 
            // ctlXspeed
            // 
            this.ctlXspeed.Location = new System.Drawing.Point(252, 206);
            this.ctlXspeed.Margin = new System.Windows.Forms.Padding(6);
            this.ctlXspeed.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ctlXspeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ctlXspeed.Name = "ctlXspeed";
            this.ctlXspeed.Size = new System.Drawing.Size(196, 31);
            this.ctlXspeed.TabIndex = 102;
            this.ctlXspeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(32, 345);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 29);
            this.label8.TabIndex = 106;
            this.label8.Text = "Z speed :";
            // 
            // ctlYspeed
            // 
            this.ctlYspeed.Location = new System.Drawing.Point(252, 275);
            this.ctlYspeed.Margin = new System.Windows.Forms.Padding(6);
            this.ctlYspeed.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ctlYspeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ctlYspeed.Name = "ctlYspeed";
            this.ctlYspeed.Size = new System.Drawing.Size(196, 31);
            this.ctlYspeed.TabIndex = 105;
            this.ctlYspeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnZspeed
            // 
            this.btnZspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnZspeed.Location = new System.Drawing.Point(477, 337);
            this.btnZspeed.Margin = new System.Windows.Forms.Padding(6);
            this.btnZspeed.Name = "btnZspeed";
            this.btnZspeed.Size = new System.Drawing.Size(82, 44);
            this.btnZspeed.TabIndex = 82;
            this.btnZspeed.Text = "OK";
            this.btnZspeed.UseVisualStyleBackColor = true;
            this.btnZspeed.Click += new System.EventHandler(this.btnZspeed_Click);
            // 
            // ctlZspeed
            // 
            this.ctlZspeed.Location = new System.Drawing.Point(252, 344);
            this.ctlZspeed.Margin = new System.Windows.Forms.Padding(6);
            this.ctlZspeed.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ctlZspeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ctlZspeed.Name = "ctlZspeed";
            this.ctlZspeed.Size = new System.Drawing.Size(196, 31);
            this.ctlZspeed.TabIndex = 108;
            this.ctlZspeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnYspeed
            // 
            this.btnYspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnYspeed.Location = new System.Drawing.Point(477, 268);
            this.btnYspeed.Margin = new System.Windows.Forms.Padding(6);
            this.btnYspeed.Name = "btnYspeed";
            this.btnYspeed.Size = new System.Drawing.Size(82, 44);
            this.btnYspeed.TabIndex = 80;
            this.btnYspeed.Text = "OK";
            this.btnYspeed.UseVisualStyleBackColor = true;
            this.btnYspeed.Click += new System.EventHandler(this.btnYspeed_Click);
            // 
            // btnXspeed
            // 
            this.btnXspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXspeed.Location = new System.Drawing.Point(477, 199);
            this.btnXspeed.Margin = new System.Windows.Forms.Padding(6);
            this.btnXspeed.Name = "btnXspeed";
            this.btnXspeed.Size = new System.Drawing.Size(82, 44);
            this.btnXspeed.TabIndex = 79;
            this.btnXspeed.Text = "OK";
            this.btnXspeed.UseVisualStyleBackColor = true;
            this.btnXspeed.Click += new System.EventHandler(this.btnXspeed_Click);
            // 
            // btnMoveYaxis
            // 
            this.btnMoveYaxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMoveYaxis.Location = new System.Drawing.Point(477, 130);
            this.btnMoveYaxis.Margin = new System.Windows.Forms.Padding(6);
            this.btnMoveYaxis.Name = "btnMoveYaxis";
            this.btnMoveYaxis.Size = new System.Drawing.Size(82, 44);
            this.btnMoveYaxis.TabIndex = 76;
            this.btnMoveYaxis.Text = "OK";
            this.btnMoveYaxis.UseVisualStyleBackColor = true;
            this.btnMoveYaxis.Click += new System.EventHandler(this.btnMoveYaxis_Click);
            // 
            // btnMoveXaxis
            // 
            this.btnMoveXaxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMoveXaxis.Location = new System.Drawing.Point(477, 61);
            this.btnMoveXaxis.Margin = new System.Windows.Forms.Padding(6);
            this.btnMoveXaxis.Name = "btnMoveXaxis";
            this.btnMoveXaxis.Size = new System.Drawing.Size(82, 44);
            this.btnMoveXaxis.TabIndex = 75;
            this.btnMoveXaxis.Text = "OK";
            this.btnMoveXaxis.UseVisualStyleBackColor = true;
            this.btnMoveXaxis.Click += new System.EventHandler(this.btnMoveXaxis_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(32, 17);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(514, 38);
            this.lblTitle.TabIndex = 72;
            this.lblTitle.Text = "Move PrintHeads";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMovePrinting
            // 
            this.txtMovePrinting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtMovePrinting.Location = new System.Drawing.Point(252, 483);
            this.txtMovePrinting.Margin = new System.Windows.Forms.Padding(6);
            this.txtMovePrinting.Name = "txtMovePrinting";
            this.txtMovePrinting.Size = new System.Drawing.Size(196, 35);
            this.txtMovePrinting.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(32, 483);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
            this.label2.TabIndex = 78;
            this.label2.Text = "Move printing";
            // 
            // txtMoveFeed
            // 
            this.txtMoveFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtMoveFeed.Location = new System.Drawing.Point(252, 424);
            this.txtMoveFeed.Margin = new System.Windows.Forms.Padding(6);
            this.txtMoveFeed.Name = "txtMoveFeed";
            this.txtMoveFeed.Size = new System.Drawing.Size(196, 35);
            this.txtMoveFeed.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(32, 433);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 76;
            this.label1.Text = "Move feed";
            // 
            // btnSpread
            // 
            this.btnSpread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSpread.Location = new System.Drawing.Point(441, 646);
            this.btnSpread.Margin = new System.Windows.Forms.Padding(6);
            this.btnSpread.Name = "btnSpread";
            this.btnSpread.Size = new System.Drawing.Size(118, 44);
            this.btnSpread.TabIndex = 2;
            this.btnSpread.Text = "Spread";
            this.btnSpread.UseVisualStyleBackColor = true;
            this.btnSpread.Click += new System.EventHandler(this.btnSpread_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(32, 654);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Amount of layers";
            // 
            // numAmountLayers
            // 
            this.numAmountLayers.Location = new System.Drawing.Point(252, 648);
            this.numAmountLayers.Margin = new System.Windows.Forms.Padding(6);
            this.numAmountLayers.Name = "numAmountLayers";
            this.numAmountLayers.Size = new System.Drawing.Size(164, 31);
            this.numAmountLayers.TabIndex = 87;
            // 
            // btnMoveFeed
            // 
            this.btnMoveFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMoveFeed.Location = new System.Drawing.Point(477, 420);
            this.btnMoveFeed.Margin = new System.Windows.Forms.Padding(6);
            this.btnMoveFeed.Name = "btnMoveFeed";
            this.btnMoveFeed.Size = new System.Drawing.Size(82, 44);
            this.btnMoveFeed.TabIndex = 83;
            this.btnMoveFeed.Text = "OK";
            this.btnMoveFeed.UseVisualStyleBackColor = true;
            this.btnMoveFeed.Click += new System.EventHandler(this.btnMoveFeed_Click);
            // 
            // btnMovePrinting
            // 
            this.btnMovePrinting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMovePrinting.Location = new System.Drawing.Point(477, 485);
            this.btnMovePrinting.Margin = new System.Windows.Forms.Padding(6);
            this.btnMovePrinting.Name = "btnMovePrinting";
            this.btnMovePrinting.Size = new System.Drawing.Size(82, 44);
            this.btnMovePrinting.TabIndex = 84;
            this.btnMovePrinting.Text = "OK";
            this.btnMovePrinting.UseVisualStyleBackColor = true;
            this.btnMovePrinting.Click += new System.EventHandler(this.btnMovePrinting_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(32, 596);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(514, 38);
            this.label9.TabIndex = 72;
            this.label9.Text = "Spread powder";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctlRFrame1
            // 
            this.ctlRFrame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ctlRFrame1.Location = new System.Drawing.Point(6, 6);
            this.ctlRFrame1.Margin = new System.Windows.Forms.Padding(6);
            this.ctlRFrame1.Name = "ctlRFrame1";
            this.ctlRFrame1.Size = new System.Drawing.Size(594, 742);
            this.ctlRFrame1.TabIndex = 82;
            // 
            // ctlAdvancedManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnSpread);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numAmountLayers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctlMoveX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ctlMoveY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ctlXspeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ctlYspeed);
            this.Controls.Add(this.btnZspeed);
            this.Controls.Add(this.ctlZspeed);
            this.Controls.Add(this.btnYspeed);
            this.Controls.Add(this.btnMoveXaxis);
            this.Controls.Add(this.btnMoveYaxis);
            this.Controls.Add(this.btnXspeed);
            this.Controls.Add(this.btnMovePrinting);
            this.Controls.Add(this.btnMoveFeed);
            this.Controls.Add(this.txtMovePrinting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMoveFeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctlRFrame1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctlAdvancedManual";
            this.Size = new System.Drawing.Size(624, 785);
            ((System.ComponentModel.ISupportInitialize)(this.ctlMoveX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlMoveY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlXspeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlYspeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlZspeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountLayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtMovePrinting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoveFeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSpread;
        private System.Windows.Forms.Label label5;
        private CustomGUI.ctlRFrame ctlRFrame1;
        private System.Windows.Forms.Button btnMoveYaxis;
        private System.Windows.Forms.Button btnMoveXaxis;
        private System.Windows.Forms.Button btnMoveFeed;
        private System.Windows.Forms.Button btnMovePrinting;
        private System.Windows.Forms.Button btnZspeed;
        private System.Windows.Forms.Button btnYspeed;
        private System.Windows.Forms.Button btnXspeed;
        private System.Windows.Forms.NumericUpDown numAmountLayers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ctlMoveX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ctlMoveY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ctlXspeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown ctlYspeed;
        private System.Windows.Forms.NumericUpDown ctlZspeed;
        private System.Windows.Forms.Label label9;
    }
}
