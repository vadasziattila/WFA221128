namespace WFA221128
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RB_FF = new System.Windows.Forms.RadioButton();
            this.RB_No = new System.Windows.Forms.RadioButton();
            this.DTP_Szul = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_ujSzemely = new System.Windows.Forms.Button();
            this.TXTB_Nev = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(776, 319);
            this.dgv.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // RB_FF
            // 
            this.RB_FF.AutoSize = true;
            this.RB_FF.Checked = true;
            this.RB_FF.Location = new System.Drawing.Point(612, 375);
            this.RB_FF.Name = "RB_FF";
            this.RB_FF.Size = new System.Drawing.Size(48, 19);
            this.RB_FF.TabIndex = 1;
            this.RB_FF.TabStop = true;
            this.RB_FF.Text = "Férfi";
            this.RB_FF.UseVisualStyleBackColor = true;
            // 
            // RB_No
            // 
            this.RB_No.AutoSize = true;
            this.RB_No.Location = new System.Drawing.Point(747, 373);
            this.RB_No.Name = "RB_No";
            this.RB_No.Size = new System.Drawing.Size(41, 19);
            this.RB_No.TabIndex = 2;
            this.RB_No.Text = "Nő";
            this.RB_No.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.DTP_Szul.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Szul.Location = new System.Drawing.Point(612, 400);
            this.DTP_Szul.Name = "dateTimePicker1";
            this.DTP_Szul.Size = new System.Drawing.Size(176, 23);
            this.DTP_Szul.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Született:";
            // 
            // BTN_ujSzemely
            // 
            this.BTN_ujSzemely.Location = new System.Drawing.Point(570, 439);
            this.BTN_ujSzemely.Name = "BTN_ujSzemely";
            this.BTN_ujSzemely.Size = new System.Drawing.Size(162, 45);
            this.BTN_ujSzemely.TabIndex = 7;
            this.BTN_ujSzemely.Text = "ÚJ SZEMÉLY HOZZÁADÁSA";
            this.BTN_ujSzemely.UseVisualStyleBackColor = true;
            this.BTN_ujSzemely.Click += new System.EventHandler(this.BTN_ujSzemely_Click);
            // 
            // TXTB_Nev
            // 
            this.TXTB_Nev.Location = new System.Drawing.Point(612, 348);
            this.TXTB_Nev.Name = "TXTB_Nev";
            this.TXTB_Nev.Size = new System.Drawing.Size(176, 23);
            this.TXTB_Nev.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.TXTB_Nev);
            this.Controls.Add(this.BTN_ujSzemely);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTP_Szul);
            this.Controls.Add(this.RB_No);
            this.Controls.Add(this.RB_FF);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private RadioButton RB_FF;
        private RadioButton RB_No;
        private DateTimePicker DTP_Szul;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BTN_ujSzemely;
        private TextBox TXTB_Nev;
    }
}