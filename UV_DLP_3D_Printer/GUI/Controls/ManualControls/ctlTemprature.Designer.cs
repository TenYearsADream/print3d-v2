namespace UV_DLP_3D_Printer.GUI.Controls.ManualControls
{
    partial class ctlTemprature
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctlRFrame1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlRFrame();
            this.btnSurface = new System.Windows.Forms.Button();
            this.btnEnviroment = new System.Windows.Forms.Button();
            this.btnReadFluid = new System.Windows.Forms.Button();
            this.chkHeater = new System.Windows.Forms.CheckBox();
            this.numSetFluid = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSetFluid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSetFluid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(43, 17);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(352, 38);
            this.lblTitle.TabIndex = 72;
            this.lblTitle.Text = "Control Temperature";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctlRFrame1
            // 
            this.ctlRFrame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ctlRFrame1.Location = new System.Drawing.Point(6, 6);
            this.ctlRFrame1.Margin = new System.Windows.Forms.Padding(6);
            this.ctlRFrame1.Name = "ctlRFrame1";
            this.ctlRFrame1.Size = new System.Drawing.Size(542, 445);
            this.ctlRFrame1.TabIndex = 82;
            // 
            // btnSurface
            // 
            this.btnSurface.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSurface.Location = new System.Drawing.Point(43, 70);
            this.btnSurface.Margin = new System.Windows.Forms.Padding(6);
            this.btnSurface.Name = "btnSurface";
            this.btnSurface.Size = new System.Drawing.Size(466, 44);
            this.btnSurface.TabIndex = 88;
            this.btnSurface.Text = "Temperature Surface Powder";
            this.btnSurface.UseVisualStyleBackColor = true;
            this.btnSurface.Click += new System.EventHandler(this.btnCleanPrintHead_Click);
            // 
            // btnEnviroment
            // 
            this.btnEnviroment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEnviroment.Location = new System.Drawing.Point(43, 134);
            this.btnEnviroment.Margin = new System.Windows.Forms.Padding(6);
            this.btnEnviroment.Name = "btnEnviroment";
            this.btnEnviroment.Size = new System.Drawing.Size(466, 44);
            this.btnEnviroment.TabIndex = 89;
            this.btnEnviroment.Text = "Temperature Enviroment";
            this.btnEnviroment.UseVisualStyleBackColor = true;
            this.btnEnviroment.Click += new System.EventHandler(this.btnCapping_Click);
            // 
            // btnReadFluid
            // 
            this.btnReadFluid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnReadFluid.Location = new System.Drawing.Point(43, 198);
            this.btnReadFluid.Margin = new System.Windows.Forms.Padding(6);
            this.btnReadFluid.Name = "btnReadFluid";
            this.btnReadFluid.Size = new System.Drawing.Size(466, 44);
            this.btnReadFluid.TabIndex = 90;
            this.btnReadFluid.Text = "Read Fluid Temperature";
            this.btnReadFluid.UseVisualStyleBackColor = true;
            this.btnReadFluid.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkHeater
            // 
            this.chkHeater.AutoSize = true;
            this.chkHeater.Location = new System.Drawing.Point(43, 268);
            this.chkHeater.Margin = new System.Windows.Forms.Padding(6);
            this.chkHeater.Name = "chkHeater";
            this.chkHeater.Size = new System.Drawing.Size(134, 29);
            this.chkHeater.TabIndex = 98;
            this.chkHeater.Text = "IR Heater";
            this.chkHeater.UseVisualStyleBackColor = true;
            // 
            // numSetFluid
            // 
            this.numSetFluid.Location = new System.Drawing.Point(311, 373);
            this.numSetFluid.Margin = new System.Windows.Forms.Padding(6);
            this.numSetFluid.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numSetFluid.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSetFluid.Name = "numSetFluid";
            this.numSetFluid.Size = new System.Drawing.Size(100, 31);
            this.numSetFluid.TabIndex = 97;
            this.numSetFluid.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(43, 374);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 29);
            this.label5.TabIndex = 95;
            this.label5.Text = "Set Fluid Temperature";
            // 
            // btnSetFluid
            // 
            this.btnSetFluid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSetFluid.Location = new System.Drawing.Point(433, 366);
            this.btnSetFluid.Margin = new System.Windows.Forms.Padding(6);
            this.btnSetFluid.Name = "btnSetFluid";
            this.btnSetFluid.Size = new System.Drawing.Size(76, 44);
            this.btnSetFluid.TabIndex = 96;
            this.btnSetFluid.Text = "OK";
            this.btnSetFluid.UseVisualStyleBackColor = true;
            this.btnSetFluid.Click += new System.EventHandler(this.btnSetFluid_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(433, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 44);
            this.button1.TabIndex = 100;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(43, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 99;
            this.label1.Text = "Set heater intensity";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(311, 317);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 31);
            this.numericUpDown1.TabIndex = 101;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ctlTemprature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.chkHeater);
            this.Controls.Add(this.btnSetFluid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numSetFluid);
            this.Controls.Add(this.btnReadFluid);
            this.Controls.Add(this.btnEnviroment);
            this.Controls.Add(this.btnSurface);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctlRFrame1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctlTemprature";
            this.Size = new System.Drawing.Size(554, 462);
            ((System.ComponentModel.ISupportInitialize)(this.numSetFluid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private CustomGUI.ctlRFrame ctlRFrame1;
        private System.Windows.Forms.Button btnSurface;
        private System.Windows.Forms.Button btnEnviroment;
        private System.Windows.Forms.Button btnReadFluid;
        private System.Windows.Forms.CheckBox chkHeater;
        private System.Windows.Forms.NumericUpDown numSetFluid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSetFluid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
