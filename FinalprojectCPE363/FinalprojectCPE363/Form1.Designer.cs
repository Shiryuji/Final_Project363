namespace FinalprojectCPE363
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stdID = new System.Windows.Forms.Label();
            this.stdname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.barnch = new System.Windows.Forms.Label();
            this.txtstd_id = new System.Windows.Forms.TextBox();
            this.txtstd_name = new System.Windows.Forms.TextBox();
            this.txtstd_lname = new System.Windows.Forms.TextBox();
            this.combo_branch = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1003, 320);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stdID
            // 
            this.stdID.AutoSize = true;
            this.stdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdID.Location = new System.Drawing.Point(93, 424);
            this.stdID.Name = "stdID";
            this.stdID.Size = new System.Drawing.Size(167, 37);
            this.stdID.TabIndex = 1;
            this.stdID.Text = "StudentID";
            // 
            // stdname
            // 
            this.stdname.AutoSize = true;
            this.stdname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdname.Location = new System.Drawing.Point(93, 486);
            this.stdname.Name = "stdname";
            this.stdname.Size = new System.Drawing.Size(224, 37);
            this.stdname.TabIndex = 2;
            this.stdname.Text = "StudentName";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(93, 553);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(271, 37);
            this.lname.TabIndex = 3;
            this.lname.Text = "StudentSurname";
            // 
            // barnch
            // 
            this.barnch.AutoSize = true;
            this.barnch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barnch.Location = new System.Drawing.Point(93, 621);
            this.barnch.Name = "barnch";
            this.barnch.Size = new System.Drawing.Size(125, 37);
            this.barnch.TabIndex = 4;
            this.barnch.Text = "Branch";
            // 
            // txtstd_id
            // 
            this.txtstd_id.Location = new System.Drawing.Point(402, 419);
            this.txtstd_id.Multiline = true;
            this.txtstd_id.Name = "txtstd_id";
            this.txtstd_id.Size = new System.Drawing.Size(320, 42);
            this.txtstd_id.TabIndex = 5;
            // 
            // txtstd_name
            // 
            this.txtstd_name.Location = new System.Drawing.Point(402, 481);
            this.txtstd_name.Multiline = true;
            this.txtstd_name.Name = "txtstd_name";
            this.txtstd_name.Size = new System.Drawing.Size(320, 42);
            this.txtstd_name.TabIndex = 6;
            // 
            // txtstd_lname
            // 
            this.txtstd_lname.Location = new System.Drawing.Point(402, 548);
            this.txtstd_lname.Multiline = true;
            this.txtstd_lname.Name = "txtstd_lname";
            this.txtstd_lname.Size = new System.Drawing.Size(320, 42);
            this.txtstd_lname.TabIndex = 7;
            // 
            // combo_branch
            // 
            this.combo_branch.FormattingEnabled = true;
            this.combo_branch.Location = new System.Drawing.Point(402, 625);
            this.combo_branch.Name = "combo_branch";
            this.combo_branch.Size = new System.Drawing.Size(320, 33);
            this.combo_branch.TabIndex = 8;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(791, 368);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(213, 92);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(791, 486);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(213, 92);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(791, 598);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(213, 92);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AccessibleDescription = " ";
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 717);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.combo_branch);
            this.Controls.Add(this.txtstd_lname);
            this.Controls.Add(this.txtstd_name);
            this.Controls.Add(this.txtstd_id);
            this.Controls.Add(this.barnch);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.stdname);
            this.Controls.Add(this.stdID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label stdID;
        private System.Windows.Forms.Label stdname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label barnch;
        private System.Windows.Forms.TextBox txtstd_id;
        private System.Windows.Forms.TextBox txtstd_name;
        private System.Windows.Forms.TextBox txtstd_lname;
        private System.Windows.Forms.ComboBox combo_branch;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
    }
}

