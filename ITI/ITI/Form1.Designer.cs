namespace ITI
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DGV_data = new DataGridView();
            txt_crname = new TextBox();
            nud_crduration = new NumericUpDown();
            cb_topic = new ComboBox();
            lb_name = new Label();
            lb_topic = new Label();
            lb_duration = new Label();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_reset = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_data).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_crduration).BeginInit();
            SuspendLayout();
            // 
            // DGV_data
            // 
            DGV_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DGV_data.DefaultCellStyle = dataGridViewCellStyle1;
            DGV_data.Dock = DockStyle.Bottom;
            DGV_data.Location = new Point(0, 228);
            DGV_data.Name = "DGV_data";
            DGV_data.RowHeadersWidth = 51;
            DGV_data.Size = new Size(719, 238);
            DGV_data.TabIndex = 0;
            DGV_data.RowHeaderMouseDoubleClick += DGV_data_RowHeaderMouseDoubleClick;
            // 
            // txt_crname
            // 
            txt_crname.Location = new Point(125, 23);
            txt_crname.Name = "txt_crname";
            txt_crname.Size = new Size(241, 27);
            txt_crname.TabIndex = 1;
            // 
            // nud_crduration
            // 
            nud_crduration.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nud_crduration.Location = new Point(466, 24);
            nud_crduration.Name = "nud_crduration";
            nud_crduration.Size = new Size(241, 27);
            nud_crduration.TabIndex = 2;
            // 
            // cb_topic
            // 
            cb_topic.FormattingEnabled = true;
            cb_topic.Location = new Point(125, 82);
            cb_topic.Name = "cb_topic";
            cb_topic.Size = new Size(241, 28);
            cb_topic.TabIndex = 3;
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Location = new Point(25, 27);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(94, 20);
            lb_name.TabIndex = 4;
            lb_name.Text = "CourseName";
            // 
            // lb_topic
            // 
            lb_topic.AutoSize = true;
            lb_topic.Location = new Point(50, 90);
            lb_topic.Name = "lb_topic";
            lb_topic.Size = new Size(45, 20);
            lb_topic.TabIndex = 5;
            lb_topic.Text = "Topic";
            // 
            // lb_duration
            // 
            lb_duration.AutoSize = true;
            lb_duration.Location = new Point(393, 26);
            lb_duration.Name = "lb_duration";
            lb_duration.Size = new Size(67, 20);
            lb_duration.TabIndex = 6;
            lb_duration.Text = "Duration";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(237, 157);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 7;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(83, 157);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 8;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(391, 157);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(545, 157);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(94, 29);
            btn_reset.TabIndex = 10;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 466);
            Controls.Add(btn_reset);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(lb_duration);
            Controls.Add(lb_topic);
            Controls.Add(lb_name);
            Controls.Add(cb_topic);
            Controls.Add(nud_crduration);
            Controls.Add(txt_crname);
            Controls.Add(DGV_data);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_data).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_crduration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_data;
        private TextBox txt_crname;
        private NumericUpDown nud_crduration;
        private ComboBox cb_topic;
        private Label lb_name;
        private Label lb_topic;
        private Label lb_duration;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_reset;
    }
}
