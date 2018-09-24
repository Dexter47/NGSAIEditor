namespace NGSAIWriter
{
    partial class FormGenerateSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenerateSQL));
            this.txt_generatedSQL = new System.Windows.Forms.TextBox();
            this.btn_file_export = new System.Windows.Forms.Button();
            this.btn_clipboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_generatedSQL
            // 
            this.txt_generatedSQL.Location = new System.Drawing.Point(12, 12);
            this.txt_generatedSQL.Multiline = true;
            this.txt_generatedSQL.Name = "txt_generatedSQL";
            this.txt_generatedSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_generatedSQL.Size = new System.Drawing.Size(690, 365);
            this.txt_generatedSQL.TabIndex = 0;
            // 
            // btn_file_export
            // 
            this.btn_file_export.Location = new System.Drawing.Point(12, 383);
            this.btn_file_export.Name = "btn_file_export";
            this.btn_file_export.Size = new System.Drawing.Size(131, 34);
            this.btn_file_export.TabIndex = 1;
            this.btn_file_export.Text = "Save to File";
            this.btn_file_export.UseVisualStyleBackColor = true;
            this.btn_file_export.Click += new System.EventHandler(this.btn_file_export_Click);
            // 
            // btn_clipboard
            // 
            this.btn_clipboard.Location = new System.Drawing.Point(549, 383);
            this.btn_clipboard.Name = "btn_clipboard";
            this.btn_clipboard.Size = new System.Drawing.Size(153, 34);
            this.btn_clipboard.TabIndex = 2;
            this.btn_clipboard.Text = "Copy to Clipboard";
            this.btn_clipboard.UseVisualStyleBackColor = true;
            this.btn_clipboard.Click += new System.EventHandler(this.btn_clipboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "A file will be saved following the TrinityCore SQL naming convention (YYYY_MM_DD_" +
    "NN_custom_world.sql).";
            // 
            // FormGenerateSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clipboard);
            this.Controls.Add(this.btn_file_export);
            this.Controls.Add(this.txt_generatedSQL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGenerateSQL";
            this.Text = "Export";
            this.Load += new System.EventHandler(this.FormGenerateSQL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_generatedSQL;
        private System.Windows.Forms.Button btn_file_export;
        private System.Windows.Forms.Button btn_clipboard;
        private System.Windows.Forms.Label label1;
    }
}