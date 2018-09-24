namespace NGSAIWriter
{
    partial class FormSAIRows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSAIRows));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_data = new System.Windows.Forms.TabControl();
            this.tp_all_sai = new System.Windows.Forms.TabPage();
            this.lv_sai = new System.Windows.Forms.ListView();
            this.tp_spells = new System.Windows.Forms.TabPage();
            this.lbl_spell_list = new System.Windows.Forms.Label();
            this.lbl_spells_rows = new System.Windows.Forms.Label();
            this.lv_spells = new System.Windows.Forms.ListView();
            this.lv_sai_spells = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.tb_data.SuspendLayout();
            this.tp_all_sai.SuspendLayout();
            this.tp_spells.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_data);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 484);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Showing Rows";
            // 
            // tb_data
            // 
            this.tb_data.Controls.Add(this.tp_all_sai);
            this.tb_data.Controls.Add(this.tp_spells);
            this.tb_data.Location = new System.Drawing.Point(6, 21);
            this.tb_data.Name = "tb_data";
            this.tb_data.SelectedIndex = 0;
            this.tb_data.Size = new System.Drawing.Size(876, 457);
            this.tb_data.TabIndex = 1;
            // 
            // tp_all_sai
            // 
            this.tp_all_sai.Controls.Add(this.lv_sai);
            this.tp_all_sai.Location = new System.Drawing.Point(4, 25);
            this.tp_all_sai.Name = "tp_all_sai";
            this.tp_all_sai.Padding = new System.Windows.Forms.Padding(3);
            this.tp_all_sai.Size = new System.Drawing.Size(868, 428);
            this.tp_all_sai.TabIndex = 0;
            this.tp_all_sai.Text = "All";
            this.tp_all_sai.UseVisualStyleBackColor = true;
            // 
            // lv_sai
            // 
            this.lv_sai.Location = new System.Drawing.Point(6, 17);
            this.lv_sai.MaximumSize = new System.Drawing.Size(869, 387);
            this.lv_sai.Name = "lv_sai";
            this.lv_sai.Size = new System.Drawing.Size(856, 387);
            this.lv_sai.TabIndex = 0;
            this.lv_sai.UseCompatibleStateImageBehavior = false;
            this.lv_sai.View = System.Windows.Forms.View.Details;
            // 
            // tp_spells
            // 
            this.tp_spells.Controls.Add(this.lbl_spell_list);
            this.tp_spells.Controls.Add(this.lbl_spells_rows);
            this.tp_spells.Controls.Add(this.lv_spells);
            this.tp_spells.Controls.Add(this.lv_sai_spells);
            this.tp_spells.Location = new System.Drawing.Point(4, 25);
            this.tp_spells.Name = "tp_spells";
            this.tp_spells.Padding = new System.Windows.Forms.Padding(3);
            this.tp_spells.Size = new System.Drawing.Size(868, 428);
            this.tp_spells.TabIndex = 1;
            this.tp_spells.Text = "Spells Cast";
            this.tp_spells.UseVisualStyleBackColor = true;
            // 
            // lbl_spell_list
            // 
            this.lbl_spell_list.AutoSize = true;
            this.lbl_spell_list.Location = new System.Drawing.Point(6, 216);
            this.lbl_spell_list.Name = "lbl_spell_list";
            this.lbl_spell_list.Size = new System.Drawing.Size(78, 17);
            this.lbl_spell_list.TabIndex = 3;
            this.lbl_spell_list.Text = "Spells Cast";
            // 
            // lbl_spells_rows
            // 
            this.lbl_spells_rows.AutoSize = true;
            this.lbl_spells_rows.Location = new System.Drawing.Point(6, 3);
            this.lbl_spells_rows.Name = "lbl_spells_rows";
            this.lbl_spells_rows.Size = new System.Drawing.Size(74, 17);
            this.lbl_spells_rows.TabIndex = 2;
            this.lbl_spells_rows.Text = "SQL Rows";
            // 
            // lv_spells
            // 
            this.lv_spells.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_spells.HotTracking = true;
            this.lv_spells.HoverSelection = true;
            this.lv_spells.Location = new System.Drawing.Point(6, 236);
            this.lv_spells.Name = "lv_spells";
            this.lv_spells.Size = new System.Drawing.Size(855, 128);
            this.lv_spells.TabIndex = 1;
            this.lv_spells.UseCompatibleStateImageBehavior = false;
            this.lv_spells.View = System.Windows.Forms.View.List;
            this.lv_spells.ItemActivate += new System.EventHandler(this.lv_spells_ItemActivate);
            // 
            // lv_sai_spells
            // 
            this.lv_sai_spells.Location = new System.Drawing.Point(6, 21);
            this.lv_sai_spells.Name = "lv_sai_spells";
            this.lv_sai_spells.Size = new System.Drawing.Size(856, 181);
            this.lv_sai_spells.TabIndex = 0;
            this.lv_sai_spells.UseCompatibleStateImageBehavior = false;
            this.lv_sai_spells.View = System.Windows.Forms.View.Details;
            // 
            // FormSAIRows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 509);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSAIRows";
            this.Text = "SmartAI Viewer";
            this.Load += new System.EventHandler(this.FormSAIRows_Load);
            this.groupBox1.ResumeLayout(false);
            this.tb_data.ResumeLayout(false);
            this.tp_all_sai.ResumeLayout(false);
            this.tp_spells.ResumeLayout(false);
            this.tp_spells.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lv_sai;
        private System.Windows.Forms.TabControl tb_data;
        private System.Windows.Forms.TabPage tp_all_sai;
        private System.Windows.Forms.TabPage tp_spells;
        private System.Windows.Forms.ListView lv_sai_spells;
        private System.Windows.Forms.ListView lv_spells;
        private System.Windows.Forms.Label lbl_spells_rows;
        private System.Windows.Forms.Label lbl_spell_list;
    }
}