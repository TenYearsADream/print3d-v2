namespace UV_DLP_3D_Printer.GUI.Controls.ManualControls
{
    partial class ctlSeviceStation
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
            this.btnCleanPrintHead = new System.Windows.Forms.Button();
            this.btnCapping = new System.Windows.Forms.Button();
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
            this.lblTitle.Text = "Service Station";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctlRFrame1
            // 
            this.ctlRFrame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ctlRFrame1.Location = new System.Drawing.Point(6, 6);
            this.ctlRFrame1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ctlRFrame1.Name = "ctlRFrame1";
            this.ctlRFrame1.Size = new System.Drawing.Size(542, 204);
            this.ctlRFrame1.TabIndex = 82;
            // 
            // btnCleanPrintHead
            // 
            this.btnCleanPrintHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCleanPrintHead.Location = new System.Drawing.Point(43, 70);
            this.btnCleanPrintHead.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCleanPrintHead.Name = "btnCleanPrintHead";
            this.btnCleanPrintHead.Size = new System.Drawing.Size(466, 44);
            this.btnCleanPrintHead.TabIndex = 88;
            this.btnCleanPrintHead.Text = "Clean Print Heads";
            this.btnCleanPrintHead.UseVisualStyleBackColor = true;
            this.btnCleanPrintHead.Click += new System.EventHandler(this.btnCleanPrintHead_Click);
            // 
            // btnCapping
            // 
            this.btnCapping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCapping.Location = new System.Drawing.Point(43, 134);
            this.btnCapping.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCapping.Name = "btnCapping";
            this.btnCapping.Size = new System.Drawing.Size(466, 44);
            this.btnCapping.TabIndex = 89;
            this.btnCapping.Text = "Hard Clean Print Heads";
            this.btnCapping.UseVisualStyleBackColor = true;
            this.btnCapping.Click += new System.EventHandler(this.btnCapping_Click);
            // 
            // ctlSeviceStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnCapping);
            this.Controls.Add(this.btnCleanPrintHead);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctlRFrame1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ctlSeviceStation";
            this.Size = new System.Drawing.Size(556, 222);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private CustomGUI.ctlRFrame ctlRFrame1;
        private System.Windows.Forms.Button btnCleanPrintHead;
        private System.Windows.Forms.Button btnCapping;
    }
}
