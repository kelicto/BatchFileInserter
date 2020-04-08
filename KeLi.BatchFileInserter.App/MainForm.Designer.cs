namespace KeLi.BatchFileInserter.App
{
    partial class MainForm
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
            this.ofdPat = new System.Windows.Forms.OpenFileDialog();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtContext = new System.Windows.Forms.TextBox();
            this.txtLineNumber = new System.Windows.Forms.TextBox();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.lblStep3 = new System.Windows.Forms.Label();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.lblStep4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ofdPat
            // 
            this.ofdPat.Filter = "Pat files|*.pat";
            this.ofdPat.Multiselect = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 32);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 244);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // txtContext
            // 
            this.txtContext.Location = new System.Drawing.Point(12, 136);
            this.txtContext.Multiline = true;
            this.txtContext.Name = "txtContext";
            this.txtContext.Size = new System.Drawing.Size(242, 79);
            this.txtContext.TabIndex = 2;
            this.txtContext.Text = ";%TYPE=MODEL";
            // 
            // txtLineNumber
            // 
            this.txtLineNumber.Location = new System.Drawing.Point(12, 85);
            this.txtLineNumber.Name = "txtLineNumber";
            this.txtLineNumber.Size = new System.Drawing.Size(48, 21);
            this.txtLineNumber.TabIndex = 1;
            this.txtLineNumber.Text = "2";
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.Location = new System.Drawing.Point(10, 70);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(221, 12);
            this.lblStep2.TabIndex = 4;
            this.lblStep2.Text = "Step 2: Inputs inserted line number.";
            // 
            // lblStep3
            // 
            this.lblStep3.AutoSize = true;
            this.lblStep3.Location = new System.Drawing.Point(10, 121);
            this.lblStep3.Name = "lblStep3";
            this.lblStep3.Size = new System.Drawing.Size(197, 12);
            this.lblStep3.TabIndex = 5;
            this.lblStep3.Text = "Step 3: Inputs inserted context.";
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.Location = new System.Drawing.Point(10, 17);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(137, 12);
            this.lblStep1.TabIndex = 6;
            this.lblStep1.Text = "Step 1: Selects files.";
            // 
            // lblStep4
            // 
            this.lblStep4.AutoSize = true;
            this.lblStep4.Location = new System.Drawing.Point(10, 229);
            this.lblStep4.Name = "lblStep4";
            this.lblStep4.Size = new System.Drawing.Size(125, 12);
            this.lblStep4.TabIndex = 7;
            this.lblStep4.Text = "Step 4: Starts task.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 282);
            this.Controls.Add(this.lblStep4);
            this.Controls.Add(this.lblStep1);
            this.Controls.Add(this.lblStep3);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.txtLineNumber);
            this.Controls.Add(this.txtContext);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch File Inserter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdPat;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtContext;
        private System.Windows.Forms.TextBox txtLineNumber;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.Label lblStep3;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Label lblStep4;
    }
}

