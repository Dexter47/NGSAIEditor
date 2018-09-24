namespace NGSAIWriter
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.gb_connectionString = new System.Windows.Forms.GroupBox();
            this.txt_cs_database = new System.Windows.Forms.TextBox();
            this.lbl_db = new System.Windows.Forms.Label();
            this.btn_cs_connect = new System.Windows.Forms.Button();
            this.nud_port = new System.Windows.Forms.NumericUpDown();
            this.txt_cs_password = new System.Windows.Forms.TextBox();
            this.txt_cs_user = new System.Windows.Forms.TextBox();
            this.txt_cs_host = new System.Windows.Forms.TextBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_host = new System.Windows.Forms.Label();
            this.lbl_messages = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_displaySAI = new System.Windows.Forms.Button();
            this.hplbl_wowhead = new System.Windows.Forms.LinkLabel();
            this.lbl_sai_count = new System.Windows.Forms.Label();
            this.lbl_sai_enabled = new System.Windows.Forms.Label();
            this.lbl_cr_entry_i = new System.Windows.Forms.Label();
            this.lbl_cr_name_i = new System.Windows.Forms.Label();
            this.txt_srch_creature = new System.Windows.Forms.TextBox();
            this.lbl_srch_creature = new System.Windows.Forms.Label();
            this.btn_srch_ok = new System.Windows.Forms.Button();
            this.bgw_database = new System.ComponentModel.BackgroundWorker();
            this.bgw_srch = new System.ComponentModel.BackgroundWorker();
            this.gb_spells = new System.Windows.Forms.GroupBox();
            this.btn_clear_stash = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.lbl_stashed_queries_counter = new System.Windows.Forms.Label();
            this.txt_spell_name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_generateSAI = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.gb_help = new System.Windows.Forms.GroupBox();
            this.txt_help = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tparam3 = new System.Windows.Forms.TextBox();
            this.txt_tparam2 = new System.Windows.Forms.TextBox();
            this.txt_tparam1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_targets = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_ef_never_repeat = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_repeat_cast_max = new System.Windows.Forms.TextBox();
            this.txt_repeat_cast_min = new System.Windows.Forms.TextBox();
            this.txt_first_cast_max = new System.Windows.Forms.TextBox();
            this.txt_first_cast_min = new System.Windows.Forms.TextBox();
            this.txt_spell = new System.Windows.Forms.TextBox();
            this.gb_connectionString.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).BeginInit();
            this.panel1.SuspendLayout();
            this.gb_spells.SuspendLayout();
            this.gb_help.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_connectionString
            // 
            this.gb_connectionString.Controls.Add(this.txt_cs_database);
            this.gb_connectionString.Controls.Add(this.lbl_db);
            this.gb_connectionString.Controls.Add(this.btn_cs_connect);
            this.gb_connectionString.Controls.Add(this.nud_port);
            this.gb_connectionString.Controls.Add(this.txt_cs_password);
            this.gb_connectionString.Controls.Add(this.txt_cs_user);
            this.gb_connectionString.Controls.Add(this.txt_cs_host);
            this.gb_connectionString.Controls.Add(this.lbl_port);
            this.gb_connectionString.Controls.Add(this.lbl_password);
            this.gb_connectionString.Controls.Add(this.lbl_user);
            this.gb_connectionString.Controls.Add(this.lbl_host);
            this.gb_connectionString.Location = new System.Drawing.Point(665, 12);
            this.gb_connectionString.Name = "gb_connectionString";
            this.gb_connectionString.Size = new System.Drawing.Size(200, 220);
            this.gb_connectionString.TabIndex = 0;
            this.gb_connectionString.TabStop = false;
            this.gb_connectionString.Text = "Database Connection";
            // 
            // txt_cs_database
            // 
            this.txt_cs_database.Location = new System.Drawing.Point(94, 117);
            this.txt_cs_database.Name = "txt_cs_database";
            this.txt_cs_database.Size = new System.Drawing.Size(100, 22);
            this.txt_cs_database.TabIndex = 4;
            // 
            // lbl_db
            // 
            this.lbl_db.AutoSize = true;
            this.lbl_db.Location = new System.Drawing.Point(15, 122);
            this.lbl_db.Name = "lbl_db";
            this.lbl_db.Size = new System.Drawing.Size(69, 17);
            this.lbl_db.TabIndex = 9;
            this.lbl_db.Text = "Database";
            // 
            // btn_cs_connect
            // 
            this.btn_cs_connect.Location = new System.Drawing.Point(46, 191);
            this.btn_cs_connect.Name = "btn_cs_connect";
            this.btn_cs_connect.Size = new System.Drawing.Size(120, 23);
            this.btn_cs_connect.TabIndex = 6;
            this.btn_cs_connect.Text = "Test Connection";
            this.btn_cs_connect.UseVisualStyleBackColor = true;
            this.btn_cs_connect.Click += new System.EventHandler(this.btn_cs_connect_Click);
            // 
            // nud_port
            // 
            this.nud_port.Location = new System.Drawing.Point(94, 145);
            this.nud_port.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nud_port.Name = "nud_port";
            this.nud_port.Size = new System.Drawing.Size(100, 22);
            this.nud_port.TabIndex = 5;
            this.nud_port.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // txt_cs_password
            // 
            this.txt_cs_password.Location = new System.Drawing.Point(94, 87);
            this.txt_cs_password.Name = "txt_cs_password";
            this.txt_cs_password.PasswordChar = '*';
            this.txt_cs_password.Size = new System.Drawing.Size(100, 22);
            this.txt_cs_password.TabIndex = 3;
            // 
            // txt_cs_user
            // 
            this.txt_cs_user.Location = new System.Drawing.Point(94, 60);
            this.txt_cs_user.Name = "txt_cs_user";
            this.txt_cs_user.Size = new System.Drawing.Size(100, 22);
            this.txt_cs_user.TabIndex = 2;
            this.txt_cs_user.Text = "trinity";
            // 
            // txt_cs_host
            // 
            this.txt_cs_host.Location = new System.Drawing.Point(94, 31);
            this.txt_cs_host.Name = "txt_cs_host";
            this.txt_cs_host.Size = new System.Drawing.Size(100, 22);
            this.txt_cs_host.TabIndex = 1;
            this.txt_cs_host.Text = "localhost";
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(18, 150);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(34, 17);
            this.lbl_port.TabIndex = 4;
            this.lbl_port.Text = "Port";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(15, 90);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(69, 17);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(15, 63);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(38, 17);
            this.lbl_user.TabIndex = 2;
            this.lbl_user.Text = "User";
            // 
            // lbl_host
            // 
            this.lbl_host.AutoSize = true;
            this.lbl_host.Location = new System.Drawing.Point(15, 34);
            this.lbl_host.Name = "lbl_host";
            this.lbl_host.Size = new System.Drawing.Size(37, 17);
            this.lbl_host.TabIndex = 1;
            this.lbl_host.Text = "Host";
            // 
            // lbl_messages
            // 
            this.lbl_messages.AutoSize = true;
            this.lbl_messages.Location = new System.Drawing.Point(12, 693);
            this.lbl_messages.Name = "lbl_messages";
            this.lbl_messages.Size = new System.Drawing.Size(87, 17);
            this.lbl_messages.TabIndex = 1;
            this.lbl_messages.Text = "Standing by.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Smart AI Editor";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_displaySAI);
            this.panel1.Controls.Add(this.hplbl_wowhead);
            this.panel1.Controls.Add(this.lbl_sai_count);
            this.panel1.Controls.Add(this.lbl_sai_enabled);
            this.panel1.Controls.Add(this.lbl_cr_entry_i);
            this.panel1.Controls.Add(this.lbl_cr_name_i);
            this.panel1.Location = new System.Drawing.Point(25, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 125);
            this.panel1.TabIndex = 3;
            // 
            // btn_displaySAI
            // 
            this.btn_displaySAI.Location = new System.Drawing.Point(311, 76);
            this.btn_displaySAI.Name = "btn_displaySAI";
            this.btn_displaySAI.Size = new System.Drawing.Size(128, 29);
            this.btn_displaySAI.TabIndex = 5;
            this.btn_displaySAI.Text = "Display SAI";
            this.btn_displaySAI.UseVisualStyleBackColor = true;
            this.btn_displaySAI.Click += new System.EventHandler(this.button1_Click);
            // 
            // hplbl_wowhead
            // 
            this.hplbl_wowhead.AutoSize = true;
            this.hplbl_wowhead.Location = new System.Drawing.Point(13, 82);
            this.hplbl_wowhead.Name = "hplbl_wowhead";
            this.hplbl_wowhead.Size = new System.Drawing.Size(205, 17);
            this.hplbl_wowhead.TabIndex = 4;
            this.hplbl_wowhead.TabStop = true;
            this.hplbl_wowhead.Text = "https://www.wowhead.com/npc=";
            this.hplbl_wowhead.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hplbl_wowhead_LinkClicked);
            // 
            // lbl_sai_count
            // 
            this.lbl_sai_count.AutoSize = true;
            this.lbl_sai_count.Location = new System.Drawing.Point(308, 52);
            this.lbl_sai_count.Name = "lbl_sai_count";
            this.lbl_sai_count.Size = new System.Drawing.Size(131, 17);
            this.lbl_sai_count.TabIndex = 3;
            this.lbl_sai_count.Text = "Lines of SAI Found:";
            // 
            // lbl_sai_enabled
            // 
            this.lbl_sai_enabled.AutoSize = true;
            this.lbl_sai_enabled.Location = new System.Drawing.Point(308, 22);
            this.lbl_sai_enabled.Name = "lbl_sai_enabled";
            this.lbl_sai_enabled.Size = new System.Drawing.Size(89, 17);
            this.lbl_sai_enabled.TabIndex = 2;
            this.lbl_sai_enabled.Text = "SAI Enabled:";
            // 
            // lbl_cr_entry_i
            // 
            this.lbl_cr_entry_i.AutoSize = true;
            this.lbl_cr_entry_i.Location = new System.Drawing.Point(13, 52);
            this.lbl_cr_entry_i.Name = "lbl_cr_entry_i";
            this.lbl_cr_entry_i.Size = new System.Drawing.Size(108, 17);
            this.lbl_cr_entry_i.TabIndex = 1;
            this.lbl_cr_entry_i.Text = "Creature Entry: ";
            // 
            // lbl_cr_name_i
            // 
            this.lbl_cr_name_i.AutoSize = true;
            this.lbl_cr_name_i.Location = new System.Drawing.Point(13, 22);
            this.lbl_cr_name_i.Name = "lbl_cr_name_i";
            this.lbl_cr_name_i.Size = new System.Drawing.Size(112, 17);
            this.lbl_cr_name_i.TabIndex = 0;
            this.lbl_cr_name_i.Text = "Creature Name: ";
            // 
            // txt_srch_creature
            // 
            this.txt_srch_creature.Location = new System.Drawing.Point(330, 75);
            this.txt_srch_creature.Name = "txt_srch_creature";
            this.txt_srch_creature.Size = new System.Drawing.Size(139, 22);
            this.txt_srch_creature.TabIndex = 4;
            // 
            // lbl_srch_creature
            // 
            this.lbl_srch_creature.AutoSize = true;
            this.lbl_srch_creature.Location = new System.Drawing.Point(231, 78);
            this.lbl_srch_creature.Name = "lbl_srch_creature";
            this.lbl_srch_creature.Size = new System.Drawing.Size(80, 17);
            this.lbl_srch_creature.TabIndex = 5;
            this.lbl_srch_creature.Text = "Creature ID";
            // 
            // btn_srch_ok
            // 
            this.btn_srch_ok.Location = new System.Drawing.Point(490, 74);
            this.btn_srch_ok.Name = "btn_srch_ok";
            this.btn_srch_ok.Size = new System.Drawing.Size(42, 25);
            this.btn_srch_ok.TabIndex = 6;
            this.btn_srch_ok.Text = "OK";
            this.btn_srch_ok.UseVisualStyleBackColor = true;
            this.btn_srch_ok.Click += new System.EventHandler(this.btn_srch_ok_Click);
            // 
            // bgw_database
            // 
            this.bgw_database.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_database_DoWork);
            // 
            // bgw_srch
            // 
            this.bgw_srch.WorkerReportsProgress = true;
            this.bgw_srch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_srch_DoWork);
            // 
            // gb_spells
            // 
            this.gb_spells.Controls.Add(this.btn_clear_stash);
            this.gb_spells.Controls.Add(this.btn_export);
            this.gb_spells.Controls.Add(this.lbl_stashed_queries_counter);
            this.gb_spells.Controls.Add(this.txt_spell_name);
            this.gb_spells.Controls.Add(this.label14);
            this.gb_spells.Controls.Add(this.btn_generateSAI);
            this.gb_spells.Controls.Add(this.label13);
            this.gb_spells.Controls.Add(this.gb_help);
            this.gb_spells.Controls.Add(this.label12);
            this.gb_spells.Controls.Add(this.label11);
            this.gb_spells.Controls.Add(this.label10);
            this.gb_spells.Controls.Add(this.txt_tparam3);
            this.gb_spells.Controls.Add(this.txt_tparam2);
            this.gb_spells.Controls.Add(this.txt_tparam1);
            this.gb_spells.Controls.Add(this.label9);
            this.gb_spells.Controls.Add(this.cb_targets);
            this.gb_spells.Controls.Add(this.label8);
            this.gb_spells.Controls.Add(this.label7);
            this.gb_spells.Controls.Add(this.label2);
            this.gb_spells.Controls.Add(this.label6);
            this.gb_spells.Controls.Add(this.label5);
            this.gb_spells.Controls.Add(this.label4);
            this.gb_spells.Controls.Add(this.cb_ef_never_repeat);
            this.gb_spells.Controls.Add(this.label3);
            this.gb_spells.Controls.Add(this.txt_repeat_cast_max);
            this.gb_spells.Controls.Add(this.txt_repeat_cast_min);
            this.gb_spells.Controls.Add(this.txt_first_cast_max);
            this.gb_spells.Controls.Add(this.txt_first_cast_min);
            this.gb_spells.Controls.Add(this.txt_spell);
            this.gb_spells.Location = new System.Drawing.Point(15, 265);
            this.gb_spells.Name = "gb_spells";
            this.gb_spells.Size = new System.Drawing.Size(872, 425);
            this.gb_spells.TabIndex = 7;
            this.gb_spells.TabStop = false;
            this.gb_spells.Text = "Combat Spells";
            this.gb_spells.Enter += new System.EventHandler(this.gb_spells_Enter);
            // 
            // btn_clear_stash
            // 
            this.btn_clear_stash.Location = new System.Drawing.Point(736, 378);
            this.btn_clear_stash.Name = "btn_clear_stash";
            this.btn_clear_stash.Size = new System.Drawing.Size(119, 29);
            this.btn_clear_stash.TabIndex = 29;
            this.btn_clear_stash.Text = "Clear Stash";
            this.btn_clear_stash.UseVisualStyleBackColor = true;
            this.btn_clear_stash.Click += new System.EventHandler(this.btn_clear_stash_Click);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(736, 343);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(119, 29);
            this.btn_export.TabIndex = 28;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // lbl_stashed_queries_counter
            // 
            this.lbl_stashed_queries_counter.AutoSize = true;
            this.lbl_stashed_queries_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stashed_queries_counter.Location = new System.Drawing.Point(6, 402);
            this.lbl_stashed_queries_counter.Name = "lbl_stashed_queries_counter";
            this.lbl_stashed_queries_counter.Size = new System.Drawing.Size(144, 20);
            this.lbl_stashed_queries_counter.TabIndex = 27;
            this.lbl_stashed_queries_counter.Text = "Stashed Queries: ";
            // 
            // txt_spell_name
            // 
            this.txt_spell_name.Location = new System.Drawing.Point(482, 125);
            this.txt_spell_name.Name = "txt_spell_name";
            this.txt_spell_name.Size = new System.Drawing.Size(248, 22);
            this.txt_spell_name.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(396, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "Spell Name";
            // 
            // btn_generateSAI
            // 
            this.btn_generateSAI.Location = new System.Drawing.Point(736, 308);
            this.btn_generateSAI.Name = "btn_generateSAI";
            this.btn_generateSAI.Size = new System.Drawing.Size(117, 29);
            this.btn_generateSAI.TabIndex = 6;
            this.btn_generateSAI.Text = "Generate";
            this.btn_generateSAI.UseVisualStyleBackColor = true;
            this.btn_generateSAI.Click += new System.EventHandler(this.btn_generateSAI_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 373);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(448, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "For further documentation, check the TrinityCore wiki page.";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // gb_help
            // 
            this.gb_help.Controls.Add(this.txt_help);
            this.gb_help.Location = new System.Drawing.Point(16, 270);
            this.gb_help.Name = "gb_help";
            this.gb_help.Size = new System.Drawing.Size(714, 100);
            this.gb_help.TabIndex = 23;
            this.gb_help.TabStop = false;
            this.gb_help.Text = "Help";
            this.gb_help.Visible = false;
            // 
            // txt_help
            // 
            this.txt_help.Location = new System.Drawing.Point(10, 21);
            this.txt_help.Multiline = true;
            this.txt_help.Name = "txt_help";
            this.txt_help.ReadOnly = true;
            this.txt_help.Size = new System.Drawing.Size(691, 73);
            this.txt_help.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(510, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Param 3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(246, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Param 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Param 1";
            // 
            // txt_tparam3
            // 
            this.txt_tparam3.Location = new System.Drawing.Point(617, 233);
            this.txt_tparam3.Name = "txt_tparam3";
            this.txt_tparam3.Size = new System.Drawing.Size(100, 22);
            this.txt_tparam3.TabIndex = 19;
            this.txt_tparam3.Text = "0";
            this.txt_tparam3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_tparam2
            // 
            this.txt_tparam2.Location = new System.Drawing.Point(356, 235);
            this.txt_tparam2.Name = "txt_tparam2";
            this.txt_tparam2.Size = new System.Drawing.Size(100, 22);
            this.txt_tparam2.TabIndex = 18;
            this.txt_tparam2.Text = "0";
            this.txt_tparam2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_tparam1
            // 
            this.txt_tparam1.Location = new System.Drawing.Point(128, 235);
            this.txt_tparam1.Name = "txt_tparam1";
            this.txt_tparam1.Size = new System.Drawing.Size(100, 22);
            this.txt_tparam1.TabIndex = 17;
            this.txt_tparam1.Text = "0";
            this.txt_tparam1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Target Params";
            // 
            // cb_targets
            // 
            this.cb_targets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_targets.FormattingEnabled = true;
            this.cb_targets.Items.AddRange(new object[] {
            "NONE (No targets, huh, AOE spells) - 0",
            "SELF (Target our creature) - 1",
            "VICTIM (Current targeted unit) - 2",
            "SECOND AGGRO (Second in threat list) - 3",
            "LAST AGGRO (Last in threat list) - 4",
            "RANDOM (Anyone in the target list) - 5",
            "RANDOM NOT TOP (Anyone in the threat list, except current target) - 6",
            "PLAYER IN RANGE (Random player in the specified distance) - 17",
            "CLOSEST CREATURE (Closest creature with ENTRY provided) - 19",
            "CLOSEST PLAYER (Closest player within distance provided) - 21",
            "CLOSEST ENEMY (Any attackable unit within range) - 25",
            "CLOSEsT FRIENDLY (Any friendly unit within range) - 26",
            "FARTHEST (farthest unit in the threat list) - 28"});
            this.cb_targets.Location = new System.Drawing.Point(92, 158);
            this.cb_targets.Name = "cb_targets";
            this.cb_targets.Size = new System.Drawing.Size(638, 24);
            this.cb_targets.TabIndex = 15;
            this.cb_targets.SelectedIndexChanged += new System.EventHandler(this.cb_targets_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Target";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Miliseconds.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Repeat it after";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(621, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Miliseconds.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "when in combat for";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start casting";
            // 
            // cb_ef_never_repeat
            // 
            this.cb_ef_never_repeat.AutoSize = true;
            this.cb_ef_never_repeat.Location = new System.Drawing.Point(51, 124);
            this.cb_ef_never_repeat.Name = "cb_ef_never_repeat";
            this.cb_ef_never_repeat.Size = new System.Drawing.Size(135, 21);
            this.cb_ef_never_repeat.TabIndex = 8;
            this.cb_ef_never_repeat.Text = "Never repeat it it";
            this.cb_ef_never_repeat.UseVisualStyleBackColor = true;
            this.cb_ef_never_repeat.MouseHover += new System.EventHandler(this.cb_ef_never_repeat_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Or ";
            // 
            // txt_repeat_cast_max
            // 
            this.txt_repeat_cast_max.Location = new System.Drawing.Point(250, 79);
            this.txt_repeat_cast_max.Name = "txt_repeat_cast_max";
            this.txt_repeat_cast_max.Size = new System.Drawing.Size(100, 22);
            this.txt_repeat_cast_max.TabIndex = 6;
            this.txt_repeat_cast_max.Text = "<MAX>";
            this.txt_repeat_cast_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_repeat_cast_max.Click += new System.EventHandler(this.txt_repeat_cast_max_Click);
            // 
            // txt_repeat_cast_min
            // 
            this.txt_repeat_cast_min.Location = new System.Drawing.Point(128, 76);
            this.txt_repeat_cast_min.Name = "txt_repeat_cast_min";
            this.txt_repeat_cast_min.Size = new System.Drawing.Size(100, 22);
            this.txt_repeat_cast_min.TabIndex = 5;
            this.txt_repeat_cast_min.Text = "<MIN>";
            this.txt_repeat_cast_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_repeat_cast_min.Click += new System.EventHandler(this.txt_repeat_cast_min_Click);
            // 
            // txt_first_cast_max
            // 
            this.txt_first_cast_max.Location = new System.Drawing.Point(503, 37);
            this.txt_first_cast_max.Name = "txt_first_cast_max";
            this.txt_first_cast_max.Size = new System.Drawing.Size(100, 22);
            this.txt_first_cast_max.TabIndex = 3;
            this.txt_first_cast_max.Text = "<MAX>";
            this.txt_first_cast_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_first_cast_max.Click += new System.EventHandler(this.txt_first_cast_max_Click);
            // 
            // txt_first_cast_min
            // 
            this.txt_first_cast_min.Location = new System.Drawing.Point(377, 37);
            this.txt_first_cast_min.Name = "txt_first_cast_min";
            this.txt_first_cast_min.Size = new System.Drawing.Size(100, 22);
            this.txt_first_cast_min.TabIndex = 2;
            this.txt_first_cast_min.Text = "<MIN>";
            this.txt_first_cast_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_first_cast_min.Click += new System.EventHandler(this.txt_first_cast_min_Click);
            // 
            // txt_spell
            // 
            this.txt_spell.Location = new System.Drawing.Point(107, 37);
            this.txt_spell.Name = "txt_spell";
            this.txt_spell.Size = new System.Drawing.Size(100, 22);
            this.txt_spell.TabIndex = 1;
            this.txt_spell.Text = "<SPELL ID>";
            this.txt_spell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_spell.Click += new System.EventHandler(this.txt_spell_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 730);
            this.Controls.Add(this.gb_spells);
            this.Controls.Add(this.btn_srch_ok);
            this.Controls.Add(this.lbl_srch_creature);
            this.Controls.Add(this.txt_srch_creature);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_messages);
            this.Controls.Add(this.gb_connectionString);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "SAI Editor - Combat Spells";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gb_connectionString.ResumeLayout(false);
            this.gb_connectionString.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_spells.ResumeLayout(false);
            this.gb_spells.PerformLayout();
            this.gb_help.ResumeLayout(false);
            this.gb_help.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_connectionString;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_host;
        private System.Windows.Forms.NumericUpDown nud_port;
        private System.Windows.Forms.TextBox txt_cs_password;
        private System.Windows.Forms.TextBox txt_cs_user;
        private System.Windows.Forms.TextBox txt_cs_host;
        private System.Windows.Forms.Button btn_cs_connect;
        private System.Windows.Forms.Label lbl_messages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_srch_creature;
        private System.Windows.Forms.Label lbl_srch_creature;
        private System.Windows.Forms.Button btn_srch_ok;
        private System.ComponentModel.BackgroundWorker bgw_database;
        private System.Windows.Forms.TextBox txt_cs_database;
        private System.Windows.Forms.Label lbl_db;
        private System.Windows.Forms.Label lbl_sai_count;
        private System.Windows.Forms.Label lbl_sai_enabled;
        private System.Windows.Forms.Label lbl_cr_entry_i;
        private System.Windows.Forms.Label lbl_cr_name_i;
        private System.Windows.Forms.LinkLabel hplbl_wowhead;
        private System.ComponentModel.BackgroundWorker bgw_srch;
        private System.Windows.Forms.Button btn_displaySAI;
        private System.Windows.Forms.GroupBox gb_spells;
        private System.Windows.Forms.TextBox txt_spell;
        private System.Windows.Forms.TextBox txt_first_cast_max;
        private System.Windows.Forms.TextBox txt_first_cast_min;
        private System.Windows.Forms.CheckBox cb_ef_never_repeat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_repeat_cast_max;
        private System.Windows.Forms.TextBox txt_repeat_cast_min;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_targets;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tparam3;
        private System.Windows.Forms.TextBox txt_tparam2;
        private System.Windows.Forms.TextBox txt_tparam1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gb_help;
        private System.Windows.Forms.TextBox txt_help;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_generateSAI;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_spell_name;
        private System.Windows.Forms.Label lbl_stashed_queries_counter;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_clear_stash;
    }
}

