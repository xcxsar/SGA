namespace SGA
{
    partial class Asistenciass
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(131, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(749, 608);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 57);
            this.button1.TabIndex = 8;
            this.button1.Text = "Registrar o Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Cu,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(69, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(614, 293);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Alumno";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Cu
            // 
            this.Cu.HeaderText = "CURP";
            this.Cu.MinimumWidth = 6;
            this.Cu.Name = "Cu";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Asistencia";
            this.Column2.Items.AddRange(new object[] {
            "Falta"});
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Asistenciass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(988, 632);
            this.Controls.Add(this.panel3);
            this.Name = "Asistenciass";
            this.Text = "Form2";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cu;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
    }
}