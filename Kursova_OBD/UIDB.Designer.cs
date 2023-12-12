namespace Kursova_OBD
{
    partial class UIDB
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
            tpHelf = new TabPage();
            tb1 = new TabControl();
            tpAccount = new TabPage();
            btn_ardhive = new Button();
            btn_s = new Button();
            groupBox5 = new GroupBox();
            dp_dob_add = new DateTimePicker();
            cb_famile_add = new ComboBox();
            tp_phone_add = new TextBox();
            tb_addres_add = new TextBox();
            tb_pob_add = new TextBox();
            label4 = new Label();
            label13 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            groupBox6 = new GroupBox();
            rb_m_add = new RadioButton();
            rb_f_add = new RadioButton();
            tb_middle_add = new TextBox();
            tb_name_add = new TextBox();
            tb_sirmane_add = new TextBox();
            tb_passport_add = new TextBox();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label8 = new Label();
            tpFindOne = new TabPage();
            btn_change = new Button();
            btn_find = new Button();
            groupBox3 = new GroupBox();
            dp_dob = new TextBox();
            tb_family = new TextBox();
            tb_number = new TextBox();
            tb_addres = new TextBox();
            tb_pob = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label10 = new Label();
            label11 = new Label();
            groupBox4 = new GroupBox();
            rb_m = new RadioButton();
            rb_f = new RadioButton();
            tb_maddlename = new TextBox();
            tb_name = new TextBox();
            tb_sirname = new TextBox();
            tb_passport = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            tabReport = new TabPage();
            btn_create = new Button();
            btn_save = new Button();
            btn_clean = new Button();
            groupBox2 = new GroupBox();
            dgv_report = new DataGridView();
            groupBox1 = new GroupBox();
            p_ready = new Panel();
            p_new = new Panel();
            cb_column = new ComboBox();
            label3 = new Label();
            cb_table = new ComboBox();
            label12 = new Label();
            cb_sort = new ComboBox();
            label2 = new Label();
            cb_report_name = new ComboBox();
            label28 = new Label();
            cb_type_report = new ComboBox();
            label1 = new Label();
            label9 = new Label();
            tb1.SuspendLayout();
            tpAccount.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            tpFindOne.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            tabReport.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_report).BeginInit();
            groupBox1.SuspendLayout();
            p_ready.SuspendLayout();
            p_new.SuspendLayout();
            SuspendLayout();
            // 
            // tpHelf
            // 
            tpHelf.BackColor = Color.Indigo;
            tpHelf.Location = new Point(4, 24);
            tpHelf.Name = "tpHelf";
            tpHelf.Padding = new Padding(3);
            tpHelf.Size = new Size(800, 365);
            tpHelf.TabIndex = 2;
            tpHelf.Text = "Довідник";
            // 
            // tb1
            // 
            tb1.Controls.Add(tpAccount);
            tb1.Controls.Add(tpFindOne);
            tb1.Controls.Add(tabReport);
            tb1.Controls.Add(tpHelf);
            tb1.Location = new Point(12, 12);
            tb1.Name = "tb1";
            tb1.SelectedIndex = 0;
            tb1.Size = new Size(808, 393);
            tb1.TabIndex = 0;
            // 
            // tpAccount
            // 
            tpAccount.BackColor = Color.Indigo;
            tpAccount.Controls.Add(btn_ardhive);
            tpAccount.Controls.Add(btn_s);
            tpAccount.Controls.Add(groupBox5);
            tpAccount.Controls.Add(groupBox6);
            tpAccount.Controls.Add(label8);
            tpAccount.Location = new Point(4, 24);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(800, 365);
            tpAccount.TabIndex = 0;
            tpAccount.Text = "Мешканець";
            // 
            // btn_ardhive
            // 
            btn_ardhive.BackColor = Color.Thistle;
            btn_ardhive.FlatStyle = FlatStyle.Popup;
            btn_ardhive.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ardhive.ForeColor = SystemColors.ActiveCaptionText;
            btn_ardhive.Location = new Point(388, 288);
            btn_ardhive.Name = "btn_ardhive";
            btn_ardhive.Size = new Size(336, 71);
            btn_ardhive.TabIndex = 21;
            btn_ardhive.Text = "Архівувати";
            btn_ardhive.UseVisualStyleBackColor = false;
            btn_ardhive.Click += btn_ardhive_Click;
            // 
            // btn_s
            // 
            btn_s.BackColor = Color.Thistle;
            btn_s.FlatStyle = FlatStyle.Popup;
            btn_s.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_s.ForeColor = SystemColors.ActiveCaptionText;
            btn_s.Location = new Point(46, 287);
            btn_s.Name = "btn_s";
            btn_s.Size = new Size(336, 71);
            btn_s.TabIndex = 20;
            btn_s.Text = "Зберегти";
            btn_s.UseVisualStyleBackColor = false;
            btn_s.Click += btn_s_Click;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.MediumSlateBlue;
            groupBox5.Controls.Add(dp_dob_add);
            groupBox5.Controls.Add(cb_famile_add);
            groupBox5.Controls.Add(tp_phone_add);
            groupBox5.Controls.Add(tb_addres_add);
            groupBox5.Controls.Add(tb_pob_add);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label19);
            groupBox5.Controls.Add(label20);
            groupBox5.Controls.Add(label21);
            groupBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(388, 6);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(406, 275);
            groupBox5.TabIndex = 19;
            groupBox5.TabStop = false;
            groupBox5.Text = "Особисті дані";
            // 
            // dp_dob_add
            // 
            dp_dob_add.Format = DateTimePickerFormat.Short;
            dp_dob_add.Location = new Point(204, 98);
            dp_dob_add.Name = "dp_dob_add";
            dp_dob_add.Size = new Size(188, 33);
            dp_dob_add.TabIndex = 22;
            dp_dob_add.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // cb_famile_add
            // 
            cb_famile_add.BackColor = SystemColors.MenuBar;
            cb_famile_add.FormattingEnabled = true;
            cb_famile_add.Location = new Point(203, 55);
            cb_famile_add.Name = "cb_famile_add";
            cb_famile_add.Size = new Size(189, 33);
            cb_famile_add.TabIndex = 21;
            // 
            // tp_phone_add
            // 
            tp_phone_add.BackColor = SystemColors.MenuBar;
            tp_phone_add.Location = new Point(203, 234);
            tp_phone_add.Name = "tp_phone_add";
            tp_phone_add.Size = new Size(189, 33);
            tp_phone_add.TabIndex = 20;
            // 
            // tb_addres_add
            // 
            tb_addres_add.BackColor = SystemColors.MenuBar;
            tb_addres_add.Location = new Point(203, 190);
            tb_addres_add.Name = "tb_addres_add";
            tb_addres_add.Size = new Size(189, 33);
            tb_addres_add.TabIndex = 19;
            // 
            // tb_pob_add
            // 
            tb_pob_add.BackColor = SystemColors.MenuBar;
            tb_pob_add.Location = new Point(203, 141);
            tb_pob_add.Name = "tb_pob_add";
            tb_pob_add.Size = new Size(189, 33);
            tb_pob_add.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 190);
            label4.Name = "label4";
            label4.Size = new Size(189, 25);
            label4.TabIndex = 7;
            label4.Text = "Адреса проживання";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 237);
            label13.Name = "label13";
            label13.Size = new Size(87, 25);
            label13.TabIndex = 8;
            label13.Text = "Телефон";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(19, 141);
            label19.Name = "label19";
            label19.Size = new Size(178, 25);
            label19.TabIndex = 4;
            label19.Text = "Місце народження";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(19, 55);
            label20.Name = "label20";
            label20.Size = new Size(139, 25);
            label20.TabIndex = 2;
            label20.Text = "Сімейний стан";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(19, 96);
            label21.Name = "label21";
            label21.Size = new Size(167, 25);
            label21.TabIndex = 3;
            label21.Text = "Дата народження";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.MediumSlateBlue;
            groupBox6.Controls.Add(rb_m_add);
            groupBox6.Controls.Add(rb_f_add);
            groupBox6.Controls.Add(tb_middle_add);
            groupBox6.Controls.Add(tb_name_add);
            groupBox6.Controls.Add(tb_sirmane_add);
            groupBox6.Controls.Add(tb_passport_add);
            groupBox6.Controls.Add(label22);
            groupBox6.Controls.Add(label23);
            groupBox6.Controls.Add(label24);
            groupBox6.Controls.Add(label25);
            groupBox6.Controls.Add(label26);
            groupBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.Location = new Point(6, 6);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(376, 275);
            groupBox6.TabIndex = 18;
            groupBox6.TabStop = false;
            groupBox6.Text = "Ідентифікаційні дані";
            // 
            // rb_m_add
            // 
            rb_m_add.AutoSize = true;
            rb_m_add.CausesValidation = false;
            rb_m_add.Checked = true;
            rb_m_add.Location = new Point(286, 102);
            rb_m_add.Name = "rb_m_add";
            rb_m_add.Size = new Size(43, 29);
            rb_m_add.TabIndex = 18;
            rb_m_add.TabStop = true;
            rb_m_add.Text = "Ч";
            rb_m_add.UseVisualStyleBackColor = true;
            // 
            // rb_f_add
            // 
            rb_f_add.AutoSize = true;
            rb_f_add.Location = new Point(181, 102);
            rb_f_add.Name = "rb_f_add";
            rb_f_add.Size = new Size(46, 29);
            rb_f_add.TabIndex = 18;
            rb_f_add.TabStop = true;
            rb_f_add.Text = "Ж";
            rb_f_add.UseVisualStyleBackColor = true;
            // 
            // tb_middle_add
            // 
            tb_middle_add.BackColor = SystemColors.MenuBar;
            tb_middle_add.Location = new Point(181, 236);
            tb_middle_add.Name = "tb_middle_add";
            tb_middle_add.Size = new Size(189, 33);
            tb_middle_add.TabIndex = 17;
            // 
            // tb_name_add
            // 
            tb_name_add.BackColor = SystemColors.MenuBar;
            tb_name_add.Location = new Point(181, 190);
            tb_name_add.Name = "tb_name_add";
            tb_name_add.Size = new Size(189, 33);
            tb_name_add.TabIndex = 16;
            // 
            // tb_sirmane_add
            // 
            tb_sirmane_add.BackColor = SystemColors.MenuBar;
            tb_sirmane_add.Location = new Point(181, 141);
            tb_sirmane_add.Name = "tb_sirmane_add";
            tb_sirmane_add.Size = new Size(189, 33);
            tb_sirmane_add.TabIndex = 15;
            // 
            // tb_passport_add
            // 
            tb_passport_add.BackColor = SystemColors.MenuBar;
            tb_passport_add.Location = new Point(181, 51);
            tb_passport_add.Name = "tb_passport_add";
            tb_passport_add.Size = new Size(189, 33);
            tb_passport_add.TabIndex = 14;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(19, 55);
            label22.Name = "label22";
            label22.Size = new Size(156, 25);
            label22.TabIndex = 0;
            label22.Text = "Номер паспорта";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(19, 141);
            label23.Name = "label23";
            label23.Size = new Size(97, 25);
            label23.TabIndex = 1;
            label23.Text = "Прізвище";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(19, 96);
            label24.Name = "label24";
            label24.Size = new Size(60, 25);
            label24.TabIndex = 6;
            label24.Text = "Стать";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(19, 190);
            label25.Name = "label25";
            label25.Size = new Size(44, 25);
            label25.TabIndex = 1;
            label25.Text = "Ім'я";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(19, 237);
            label26.Name = "label26";
            label26.Size = new Size(111, 25);
            label26.TabIndex = 1;
            label26.Text = "Побатькові";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 266);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 5;
            // 
            // tpFindOne
            // 
            tpFindOne.BackColor = Color.Indigo;
            tpFindOne.Controls.Add(btn_change);
            tpFindOne.Controls.Add(btn_find);
            tpFindOne.Controls.Add(groupBox3);
            tpFindOne.Controls.Add(groupBox4);
            tpFindOne.Location = new Point(4, 24);
            tpFindOne.Name = "tpFindOne";
            tpFindOne.Padding = new Padding(3);
            tpFindOne.Size = new Size(800, 365);
            tpFindOne.TabIndex = 1;
            tpFindOne.Text = "Пошук людини";
            // 
            // btn_change
            // 
            btn_change.BackColor = Color.Thistle;
            btn_change.FlatStyle = FlatStyle.Popup;
            btn_change.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_change.ForeColor = SystemColors.ActiveCaptionText;
            btn_change.Location = new Point(388, 288);
            btn_change.Name = "btn_change";
            btn_change.Size = new Size(336, 71);
            btn_change.TabIndex = 17;
            btn_change.Text = "Перенести дані для редагування";
            btn_change.UseVisualStyleBackColor = false;
            btn_change.Click += btn_change_Click;
            // 
            // btn_find
            // 
            btn_find.BackColor = Color.Thistle;
            btn_find.FlatStyle = FlatStyle.Popup;
            btn_find.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_find.ForeColor = SystemColors.ActiveCaptionText;
            btn_find.Location = new Point(46, 287);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(336, 71);
            btn_find.TabIndex = 16;
            btn_find.Text = "Шукати";
            btn_find.UseVisualStyleBackColor = false;
            btn_find.Click += btn_find_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.MediumSlateBlue;
            groupBox3.Controls.Add(dp_dob);
            groupBox3.Controls.Add(tb_family);
            groupBox3.Controls.Add(tb_number);
            groupBox3.Controls.Add(tb_addres);
            groupBox3.Controls.Add(tb_pob);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(388, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(406, 275);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Результат пошуку";
            // 
            // dp_dob
            // 
            dp_dob.BackColor = SystemColors.MenuBar;
            dp_dob.Location = new Point(203, 96);
            dp_dob.Name = "dp_dob";
            dp_dob.ReadOnly = true;
            dp_dob.Size = new Size(189, 33);
            dp_dob.TabIndex = 22;
            // 
            // tb_family
            // 
            tb_family.BackColor = SystemColors.MenuBar;
            tb_family.Location = new Point(203, 49);
            tb_family.Name = "tb_family";
            tb_family.ReadOnly = true;
            tb_family.Size = new Size(189, 33);
            tb_family.TabIndex = 21;
            // 
            // tb_number
            // 
            tb_number.BackColor = SystemColors.MenuBar;
            tb_number.Location = new Point(203, 234);
            tb_number.Name = "tb_number";
            tb_number.ReadOnly = true;
            tb_number.Size = new Size(189, 33);
            tb_number.TabIndex = 20;
            // 
            // tb_addres
            // 
            tb_addres.BackColor = SystemColors.MenuBar;
            tb_addres.Location = new Point(203, 190);
            tb_addres.Name = "tb_addres";
            tb_addres.ReadOnly = true;
            tb_addres.Size = new Size(189, 33);
            tb_addres.TabIndex = 19;
            // 
            // tb_pob
            // 
            tb_pob.BackColor = SystemColors.MenuBar;
            tb_pob.Location = new Point(203, 141);
            tb_pob.Name = "tb_pob";
            tb_pob.ReadOnly = true;
            tb_pob.Size = new Size(189, 33);
            tb_pob.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 190);
            label5.Name = "label5";
            label5.Size = new Size(189, 25);
            label5.TabIndex = 7;
            label5.Text = "Адреса проживання";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 237);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 8;
            label6.Text = "Телефон";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 141);
            label7.Name = "label7";
            label7.Size = new Size(178, 25);
            label7.TabIndex = 4;
            label7.Text = "Місце народження";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 55);
            label10.Name = "label10";
            label10.Size = new Size(139, 25);
            label10.TabIndex = 2;
            label10.Text = "Сімейний стан";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 96);
            label11.Name = "label11";
            label11.Size = new Size(167, 25);
            label11.TabIndex = 3;
            label11.Text = "Дата народження";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.MediumSlateBlue;
            groupBox4.Controls.Add(rb_m);
            groupBox4.Controls.Add(rb_f);
            groupBox4.Controls.Add(tb_maddlename);
            groupBox4.Controls.Add(tb_name);
            groupBox4.Controls.Add(tb_sirname);
            groupBox4.Controls.Add(tb_passport);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label18);
            groupBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(6, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(376, 275);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Дані для пошуку";
            // 
            // rb_m
            // 
            rb_m.AutoSize = true;
            rb_m.Location = new Point(286, 102);
            rb_m.Name = "rb_m";
            rb_m.Size = new Size(43, 29);
            rb_m.TabIndex = 18;
            rb_m.TabStop = true;
            rb_m.Text = "Ч";
            rb_m.UseVisualStyleBackColor = true;
            // 
            // rb_f
            // 
            rb_f.AutoSize = true;
            rb_f.Location = new Point(181, 102);
            rb_f.Name = "rb_f";
            rb_f.Size = new Size(46, 29);
            rb_f.TabIndex = 18;
            rb_f.TabStop = true;
            rb_f.Text = "Ж";
            rb_f.UseVisualStyleBackColor = true;
            // 
            // tb_maddlename
            // 
            tb_maddlename.BackColor = SystemColors.MenuBar;
            tb_maddlename.Location = new Point(181, 236);
            tb_maddlename.Name = "tb_maddlename";
            tb_maddlename.Size = new Size(189, 33);
            tb_maddlename.TabIndex = 17;
            // 
            // tb_name
            // 
            tb_name.BackColor = SystemColors.MenuBar;
            tb_name.Location = new Point(181, 190);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(189, 33);
            tb_name.TabIndex = 16;
            // 
            // tb_sirname
            // 
            tb_sirname.BackColor = SystemColors.MenuBar;
            tb_sirname.Location = new Point(181, 141);
            tb_sirname.Name = "tb_sirname";
            tb_sirname.Size = new Size(189, 33);
            tb_sirname.TabIndex = 15;
            // 
            // tb_passport
            // 
            tb_passport.BackColor = SystemColors.MenuBar;
            tb_passport.Location = new Point(181, 51);
            tb_passport.Name = "tb_passport";
            tb_passport.Size = new Size(189, 33);
            tb_passport.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(19, 55);
            label14.Name = "label14";
            label14.Size = new Size(156, 25);
            label14.TabIndex = 0;
            label14.Text = "Номер паспорта";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(19, 141);
            label15.Name = "label15";
            label15.Size = new Size(97, 25);
            label15.TabIndex = 1;
            label15.Text = "Прізвище";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(19, 96);
            label16.Name = "label16";
            label16.Size = new Size(60, 25);
            label16.TabIndex = 6;
            label16.Text = "Стать";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(19, 190);
            label17.Name = "label17";
            label17.Size = new Size(44, 25);
            label17.TabIndex = 1;
            label17.Text = "Ім'я";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(19, 237);
            label18.Name = "label18";
            label18.Size = new Size(111, 25);
            label18.TabIndex = 1;
            label18.Text = "Побатькові";
            // 
            // tabReport
            // 
            tabReport.AllowDrop = true;
            tabReport.BackColor = Color.Indigo;
            tabReport.Controls.Add(btn_create);
            tabReport.Controls.Add(btn_save);
            tabReport.Controls.Add(btn_clean);
            tabReport.Controls.Add(groupBox2);
            tabReport.Controls.Add(groupBox1);
            tabReport.Location = new Point(4, 24);
            tabReport.Name = "tabReport";
            tabReport.Padding = new Padding(3);
            tabReport.Size = new Size(800, 365);
            tabReport.TabIndex = 3;
            tabReport.Text = "Звіти";
            // 
            // btn_create
            // 
            btn_create.BackColor = Color.Thistle;
            btn_create.FlatStyle = FlatStyle.Popup;
            btn_create.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_create.ForeColor = SystemColors.ActiveCaptionText;
            btn_create.Location = new Point(6, 288);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(376, 33);
            btn_create.TabIndex = 17;
            btn_create.Text = "Створити звіт";
            btn_create.UseVisualStyleBackColor = false;
            btn_create.Click += btn_create_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Thistle;
            btn_save.FlatStyle = FlatStyle.Popup;
            btn_save.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_save.ForeColor = SystemColors.ActiveCaptionText;
            btn_save.Location = new Point(186, 327);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(196, 32);
            btn_save.TabIndex = 15;
            btn_save.Text = "Зберегти звіт";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_clean
            // 
            btn_clean.BackColor = Color.Thistle;
            btn_clean.FlatStyle = FlatStyle.Popup;
            btn_clean.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_clean.ForeColor = SystemColors.ActiveCaptionText;
            btn_clean.Location = new Point(8, 328);
            btn_clean.Name = "btn_clean";
            btn_clean.Size = new Size(174, 31);
            btn_clean.TabIndex = 16;
            btn_clean.Text = "Очистити поля";
            btn_clean.UseVisualStyleBackColor = false;
            btn_clean.Click += btn_clean_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.MediumSlateBlue;
            groupBox2.Controls.Add(dgv_report);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(388, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(406, 353);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Звіт";
            // 
            // dgv_report
            // 
            dgv_report.BackgroundColor = SystemColors.Window;
            dgv_report.BorderStyle = BorderStyle.None;
            dgv_report.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_report.Location = new Point(6, 32);
            dgv_report.Name = "dgv_report";
            dgv_report.RowTemplate.Height = 25;
            dgv_report.Size = new Size(394, 315);
            dgv_report.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MediumSlateBlue;
            groupBox1.Controls.Add(p_ready);
            groupBox1.Controls.Add(cb_type_report);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label9);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 275);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Налаштування";
            // 
            // p_ready
            // 
            p_ready.Controls.Add(p_new);
            p_ready.Controls.Add(cb_report_name);
            p_ready.Controls.Add(label28);
            p_ready.Enabled = false;
            p_ready.Location = new Point(7, 96);
            p_ready.Name = "p_ready";
            p_ready.Size = new Size(363, 173);
            p_ready.TabIndex = 25;
            p_ready.Visible = false;
            // 
            // p_new
            // 
            p_new.Controls.Add(cb_column);
            p_new.Controls.Add(label3);
            p_new.Controls.Add(cb_table);
            p_new.Controls.Add(label12);
            p_new.Controls.Add(cb_sort);
            p_new.Controls.Add(label2);
            p_new.Location = new Point(0, 2);
            p_new.Name = "p_new";
            p_new.Size = new Size(363, 173);
            p_new.TabIndex = 24;
            // 
            // cb_column
            // 
            cb_column.FormattingEnabled = true;
            cb_column.Items.AddRange(new object[] { "А-Я", "Я-А", "Відсутнє" });
            cb_column.Location = new Point(161, 118);
            cb_column.Name = "cb_column";
            cb_column.Size = new Size(189, 33);
            cb_column.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 105);
            label3.Name = "label3";
            label3.Size = new Size(151, 50);
            label3.TabIndex = 22;
            label3.Text = "Стовпець \r\nдля сортування:";
            // 
            // cb_table
            // 
            cb_table.FormattingEnabled = true;
            cb_table.Location = new Point(161, 7);
            cb_table.Name = "cb_table";
            cb_table.Size = new Size(189, 33);
            cb_table.TabIndex = 21;
            cb_table.SelectedIndexChanged += cb_table_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 15);
            label12.Name = "label12";
            label12.Size = new Size(155, 25);
            label12.TabIndex = 20;
            label12.Text = "Обрана таблиця";
            // 
            // cb_sort
            // 
            cb_sort.FormattingEnabled = true;
            cb_sort.Items.AddRange(new object[] { "А-Я", "Я-А", "Відсутнє" });
            cb_sort.Location = new Point(161, 52);
            cb_sort.Name = "cb_sort";
            cb_sort.Size = new Size(189, 33);
            cb_sort.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 60);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 1;
            label2.Text = "Сортування";
            // 
            // cb_report_name
            // 
            cb_report_name.FormattingEnabled = true;
            cb_report_name.Location = new Point(161, 7);
            cb_report_name.Name = "cb_report_name";
            cb_report_name.Size = new Size(189, 33);
            cb_report_name.TabIndex = 21;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(5, 15);
            label28.Name = "label28";
            label28.Size = new Size(45, 25);
            label28.TabIndex = 20;
            label28.Text = "Звіт";
            // 
            // cb_type_report
            // 
            cb_type_report.FormattingEnabled = true;
            cb_type_report.Items.AddRange(new object[] { "Вивести перелік мешканців", "Вже готовий звіт" });
            cb_type_report.Location = new Point(167, 55);
            cb_type_report.Name = "cb_type_report";
            cb_type_report.Size = new Size(189, 33);
            cb_type_report.TabIndex = 18;
            cb_type_report.SelectedIndexChanged += cb_type_report_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 55);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "Вид звіту";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 96);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 6;
            // 
            // UIDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 406);
            Controls.Add(tb1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UIDB";
            Text = "АРМ секретаря сільської ради по обліку мешканців населеного пункту";
            tb1.ResumeLayout(false);
            tpAccount.ResumeLayout(false);
            tpAccount.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            tpFindOne.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabReport.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_report).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            p_ready.ResumeLayout(false);
            p_ready.PerformLayout();
            p_new.ResumeLayout(false);
            p_new.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tpHelf;
        private TabControl tb1;
        private TabPage tpAccount;
        private Button btn_ardhive;
        private Button btn_s;
        private GroupBox groupBox5;
        private DateTimePicker dp_dob_add;
        private ComboBox cb_famile_add;
        private TextBox tp_phone_add;
        private TextBox tb_addres_add;
        private TextBox tb_pob_add;
        private Label label4;
        private Label label13;
        private Label label19;
        private Label label20;
        private Label label21;
        private GroupBox groupBox6;
        private RadioButton rb_m_add;
        private RadioButton rb_f_add;
        private TextBox tb_middle_add;
        private TextBox tb_name_add;
        private TextBox tb_sirmane_add;
        private TextBox tb_passport_add;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label8;
        private TabPage tpFindOne;
        private Button btn_change;
        private Button btn_find;
        private GroupBox groupBox3;
        private TextBox dp_dob;
        private TextBox tb_family;
        private TextBox tb_number;
        private TextBox tb_addres;
        private TextBox tb_pob;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label10;
        private Label label11;
        private GroupBox groupBox4;
        private RadioButton rb_m;
        private RadioButton rb_f;
        private TextBox tb_maddlename;
        private TextBox tb_name;
        private TextBox tb_sirname;
        private TextBox tb_passport;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TabPage tabReport;
        private Button btn_save;
        private Button btn_clean;
        private GroupBox groupBox2;
        private Panel p_new;
        private ComboBox cb_column;
        private Label label3;
        private ComboBox cb_table;
        private Label label12;
        private ComboBox cb_sort;
        private Label label2;
        private DataGridView dgv_report;
        private GroupBox groupBox1;
        private ComboBox cb_type_report;
        private Label label1;
        private Label label9;
        private Panel p_ready;
        private ComboBox cb_report_name;
        private Label label28;
        private Button btn_create;
    }
}