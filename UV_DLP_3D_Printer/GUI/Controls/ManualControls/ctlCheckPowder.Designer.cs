namespace UV_DLP_3D_Printer.GUI.Controls.ManualControls
{
    partial class ctlCheckPowder
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
            this.btnCleanPrintHead = new System.Windows.Forms.Button();
            this.btnCapping = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ctlRFrame1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlRFrame();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(43, 17);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(352, 38);
            this.lblTitle.TabIndex = 72;
            this.lblTitle.Text = "Check powder/Feed level";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCleanPrintHead
            // 
            this.btnCleanPrintHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCleanPrintHead.Location = new System.Drawing.Point(43, 70);
            this.btnCleanPrintHead.Margin = new System.Windows.Forms.Padding(6);
            this.btnCleanPrintHead.Name = "btnCleanPrintHead";
            this.btnCleanPrintHead.Size = new System.Drawing.Size(466, 44);
            this.btnCleanPrintHead.TabIndex = 88;
            this.btnCleanPrintHead.Text = "Level Feeding Box";
            this.btnCleanPrintHead.UseVisualStyleBackColor = true;
            this.btnCleanPrintHead.Click += new System.EventHandler(this.btnCleanPrintHead_Click);
            // 
            // btnCapping
            // 
            this.btnCapping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCapping.Location = new System.Drawing.Point(43, 134);
            this.btnCapping.Margin = new System.Windows.Forms.Padding(6);
            this.btnCapping.Name = "btnCapping";
            this.btnCapping.Size = new System.Drawing.Size(466, 44);
            this.btnCapping.TabIndex = 89;
            this.btnCapping.Text = "Level Printing Box";
            this.btnCapping.UseVisualStyleBackColor = true;
            this.btnCapping.Click += new System.EventHandler(this.btnCapping_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(43, 198);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(466, 44);
            this.button1.TabIndex = 90;
            this.button1.Text = "Level Fluid";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctlRFrame1
            // 
            this.ctlRFrame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ctlRFrame1.Location = new System.Drawing.Point(6, 6);
            this.ctlRFrame1.Margin = new System.Windows.Forms.Padding(6);
            this.ctlRFrame1.Name = "ctlRFrame1";
            this.ctlRFrame1.Size = new System.Drawing.Size(542, 294);
            this.ctlRFrame1.TabIndex = 82;
            // 
            // ctlCheckPowder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCapping);
            this.Controls.Add(this.btnCleanPrintHead);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctlRFrame1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctlCheckPowder";
            this.Size = new System.Drawing.Size(562, 344);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private CustomGUI.ctlRFrame ctlRFrame1;
        private System.Windows.Forms.Button btnCleanPrintHead;
        private System.Windows.Forms.Button btnCapping;
        private System.Windows.Forms.Button button1;
    }
}
