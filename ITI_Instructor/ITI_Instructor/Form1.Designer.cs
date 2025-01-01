namespace ITI_Instructor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGV_getdata = new DataGridView();
            btn_get = new Button();
            Txt_Name = new TextBox();
            Txt_Degree = new TextBox();
            NUD_Salary = new NumericUpDown();
            Cb_dept = new ComboBox();
            lb_Name = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_reset = new Button();
            label1 = new Label();
            txt_id = new TextBox();
            btn_updatedb = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_getdata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Salary).BeginInit();
            SuspendLayout();
            // 
            // DGV_getdata
            // 
            DGV_getdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_getdata.Dock = DockStyle.Left;
            DGV_getdata.Location = new Point(0, 0);
            DGV_getdata.Name = "DGV_getdata";
            DGV_getdata.RowHeadersWidth = 51;
            DGV_getdata.Size = new Size(491, 459);
            DGV_getdata.TabIndex = 0;
            DGV_getdata.RowHeaderMouseDoubleClick += DGV_getdata_RowHeaderMouseDoubleClick;
            // 
            // btn_get
            // 
            btn_get.Location = new Point(542, 12);
            btn_get.Name = "btn_get";
            btn_get.Size = new Size(313, 47);
            btn_get.TabIndex = 1;
            btn_get.Text = "Show Data";
            btn_get.UseVisualStyleBackColor = true;
            btn_get.Click += btn_get_Click;
            // 
            // Txt_Name
            // 
            Txt_Name.Location = new Point(651, 114);
            Txt_Name.Name = "Txt_Name";
            Txt_Name.Size = new Size(151, 27);
            Txt_Name.TabIndex = 2;
            // 
            // Txt_Degree
            // 
            Txt_Degree.Location = new Point(651, 177);
            Txt_Degree.Name = "Txt_Degree";
            Txt_Degree.Size = new Size(151, 27);
            Txt_Degree.TabIndex = 3;
            // 
            // NUD_Salary
            // 
            NUD_Salary.DecimalPlaces = 2;
            NUD_Salary.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            NUD_Salary.Location = new Point(651, 243);
            NUD_Salary.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NUD_Salary.Name = "NUD_Salary";
            NUD_Salary.Size = new Size(151, 27);
            NUD_Salary.TabIndex = 4;
            // 
            // Cb_dept
            // 
            Cb_dept.FormattingEnabled = true;
            Cb_dept.Location = new Point(651, 316);
            Cb_dept.Name = "Cb_dept";
            Cb_dept.Size = new Size(151, 28);
            Cb_dept.TabIndex = 5;
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Location = new Point(542, 119);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(49, 20);
            lb_Name.TabIndex = 6;
            lb_Name.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(542, 184);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 7;
            label2.Text = "Degree";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(542, 243);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 8;
            label3.Text = "Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(542, 316);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 9;
            label4.Text = "Dept_id";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(616, 362);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 10;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(497, 362);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 11;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(730, 362);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 12;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(837, 362);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(94, 29);
            btn_reset.TabIndex = 13;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(542, 73);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 14;
            label1.Text = "ID";
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(651, 70);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(59, 27);
            txt_id.TabIndex = 15;
            // 
            // btn_updatedb
            // 
            btn_updatedb.Location = new Point(542, 400);
            btn_updatedb.Name = "btn_updatedb";
            btn_updatedb.Size = new Size(313, 47);
            btn_updatedb.TabIndex = 16;
            btn_updatedb.Text = "Update Data Base";
            btn_updatedb.UseVisualStyleBackColor = true;
            btn_updatedb.Click += btn_updatedb_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 459);
            Controls.Add(btn_updatedb);
            Controls.Add(txt_id);
            Controls.Add(label1);
            Controls.Add(btn_reset);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lb_Name);
            Controls.Add(Cb_dept);
            Controls.Add(NUD_Salary);
            Controls.Add(Txt_Degree);
            Controls.Add(Txt_Name);
            Controls.Add(btn_get);
            Controls.Add(DGV_getdata);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGV_getdata).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Salary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_getdata;
        private Button btn_get;
        private TextBox Txt_Name;
        private TextBox Txt_Degree;
        private NumericUpDown NUD_Salary;
        private ComboBox Cb_dept;
        private Label lb_Name;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_reset;
        private Label label1;
        private TextBox txt_id;
        private Button btn_updatedb;
    }


}

