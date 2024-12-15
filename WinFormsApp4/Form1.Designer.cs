namespace WinFormsApp4
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
            dgv = new DataGridView();
            name_tb = new TextBox();
            desc_tb = new TextBox();
            cat_tb = new TextBox();
            insert_btn = new Button();
            update_btn = new Button();
            clear_btn = new Button();
            delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(239, 12);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 62;
            dgv.Size = new Size(795, 426);
            dgv.TabIndex = 0;
            // 
            // name_tb
            // 
            name_tb.Location = new Point(39, 32);
            name_tb.Name = "name_tb";
            name_tb.Size = new Size(150, 31);
            name_tb.TabIndex = 1;
            name_tb.TextChanged += name_tb_TextChanged;
            // 
            // desc_tb
            // 
            desc_tb.Location = new Point(39, 82);
            desc_tb.Name = "desc_tb";
            desc_tb.Size = new Size(150, 31);
            desc_tb.TabIndex = 2;
            desc_tb.TextChanged += desc_tb_TextChanged;
            // 
            // cat_tb
            // 
            cat_tb.Location = new Point(39, 129);
            cat_tb.Name = "cat_tb";
            cat_tb.Size = new Size(150, 31);
            cat_tb.TabIndex = 3;
            cat_tb.TextChanged += cat_tb_TextChanged;
            // 
            // insert_btn
            // 
            insert_btn.Location = new Point(39, 192);
            insert_btn.Name = "insert_btn";
            insert_btn.Size = new Size(112, 34);
            insert_btn.TabIndex = 4;
            insert_btn.Text = "insert";
            insert_btn.UseVisualStyleBackColor = true;
            insert_btn.Click += insert_btn_Click;
            // 
            // update_btn
            // 
            update_btn.Location = new Point(39, 246);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(112, 34);
            update_btn.TabIndex = 5;
            update_btn.Text = "update";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(39, 359);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(112, 34);
            clear_btn.TabIndex = 7;
            clear_btn.Text = "clear";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click_1;
            // 
            // delete
            // 
            delete.Location = new Point(39, 304);
            delete.Name = "delete";
            delete.Size = new Size(112, 34);
            delete.TabIndex = 8;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delete);
            Controls.Add(clear_btn);
            Controls.Add(update_btn);
            Controls.Add(insert_btn);
            Controls.Add(cat_tb);
            Controls.Add(desc_tb);
            Controls.Add(name_tb);
            Controls.Add(dgv);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private TextBox name_tb;
        private TextBox desc_tb;
        private TextBox cat_tb;
        private Button insert_btn;
        private Button update_btn;
        private Button clear_btn;
        private Button delete;
    }
}
