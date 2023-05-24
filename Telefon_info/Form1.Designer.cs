
namespace Telefon_info
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Telefonbok_header = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Class_label = new System.Windows.Forms.Label();
            this.Number_label = new System.Windows.Forms.Label();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.Class_textbox = new System.Windows.Forms.TextBox();
            this.Data_grid = new System.Windows.Forms.DataGridView();
            this.Email_label = new System.Windows.Forms.Label();
            this.Email_textbox = new System.Windows.Forms.TextBox();
            this.Comfirm_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Remove_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Number_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Telefonbok_header
            // 
            this.Telefonbok_header.Font = new System.Drawing.Font("Adobe Devanagari", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefonbok_header.Location = new System.Drawing.Point(230, 9);
            this.Telefonbok_header.Name = "Telefonbok_header";
            this.Telefonbok_header.Size = new System.Drawing.Size(340, 95);
            this.Telefonbok_header.TabIndex = 0;
            this.Telefonbok_header.Text = "Telefonbok";
            this.Telefonbok_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Name_label
            // 
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.Location = new System.Drawing.Point(108, 118);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(124, 37);
            this.Name_label.TabIndex = 1;
            this.Name_label.Text = "Fulla namn:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Class_label
            // 
            this.Class_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class_label.Location = new System.Drawing.Point(108, 155);
            this.Class_label.Name = "Class_label";
            this.Class_label.Size = new System.Drawing.Size(124, 37);
            this.Class_label.TabIndex = 2;
            this.Class_label.Text = "Klass:";
            // 
            // Number_label
            // 
            this.Number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_label.Location = new System.Drawing.Point(108, 188);
            this.Number_label.Name = "Number_label";
            this.Number_label.Size = new System.Drawing.Size(163, 37);
            this.Number_label.TabIndex = 3;
            this.Number_label.Text = "Telefonnummer:";
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(277, 122);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(221, 22);
            this.Name_textbox.TabIndex = 4;
            // 
            // Class_textbox
            // 
            this.Class_textbox.Location = new System.Drawing.Point(277, 155);
            this.Class_textbox.Name = "Class_textbox";
            this.Class_textbox.Size = new System.Drawing.Size(221, 22);
            this.Class_textbox.TabIndex = 5;
            // 
            // Data_grid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Data_grid.Location = new System.Drawing.Point(38, 272);
            this.Data_grid.Name = "Data_grid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Data_grid.RowHeadersWidth = 51;
            this.Data_grid.RowTemplate.Height = 24;
            this.Data_grid.Size = new System.Drawing.Size(725, 166);
            this.Data_grid.TabIndex = 7;
            // 
            // Email_label
            // 
            this.Email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_label.Location = new System.Drawing.Point(108, 225);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(163, 37);
            this.Email_label.TabIndex = 8;
            this.Email_label.Text = "Email:";
            // 
            // Email_textbox
            // 
            this.Email_textbox.Location = new System.Drawing.Point(277, 225);
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.Size = new System.Drawing.Size(221, 22);
            this.Email_textbox.TabIndex = 9;
            // 
            // Comfirm_button
            // 
            this.Comfirm_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Comfirm_button.Location = new System.Drawing.Point(521, 112);
            this.Comfirm_button.Name = "Comfirm_button";
            this.Comfirm_button.Size = new System.Drawing.Size(96, 43);
            this.Comfirm_button.TabIndex = 10;
            this.Comfirm_button.Text = "Comfirm";
            this.Comfirm_button.UseVisualStyleBackColor = false;
            this.Comfirm_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Cancel_button.Location = new System.Drawing.Point(521, 166);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(96, 43);
            this.Cancel_button.TabIndex = 11;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Remove_button
            // 
            this.Remove_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Remove_button.Location = new System.Drawing.Point(521, 219);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(96, 43);
            this.Remove_button.TabIndex = 12;
            this.Remove_button.Text = "Remove";
            this.Remove_button.UseVisualStyleBackColor = false;
            this.Remove_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // Update_button
            // 
            this.Update_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Update_button.Location = new System.Drawing.Point(38, 272);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(68, 29);
            this.Update_button.TabIndex = 13;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = false;
            this.Update_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button4_MouseClick);
            // 
            // Number_textbox
            // 
            this.Number_textbox.Location = new System.Drawing.Point(277, 192);
            this.Number_textbox.Name = "Number_textbox";
            this.Number_textbox.Size = new System.Drawing.Size(221, 22);
            this.Number_textbox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Number_textbox);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Comfirm_button);
            this.Controls.Add(this.Email_textbox);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.Data_grid);
            this.Controls.Add(this.Class_textbox);
            this.Controls.Add(this.Name_textbox);
            this.Controls.Add(this.Number_label);
            this.Controls.Add(this.Class_label);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Telefonbok_header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Telefonbok";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Telefonbok_header;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label Class_label;
        private System.Windows.Forms.Label Number_label;
        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.TextBox Class_textbox;
        private System.Windows.Forms.DataGridView Data_grid;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.TextBox Email_textbox;
        private System.Windows.Forms.Button Comfirm_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Remove_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.TextBox Number_textbox;
    }
}

