
namespace Telefon_info
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Comfirm_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.ID_textbox = new System.Windows.Forms.TextBox();
            this.ID_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Comfirm_button
            // 
            this.Comfirm_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Comfirm_button.Location = new System.Drawing.Point(122, 99);
            this.Comfirm_button.Name = "Comfirm_button";
            this.Comfirm_button.Size = new System.Drawing.Size(96, 43);
            this.Comfirm_button.TabIndex = 11;
            this.Comfirm_button.Text = "Comfirm";
            this.Comfirm_button.UseVisualStyleBackColor = false;
            this.Comfirm_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Cancel_button.Location = new System.Drawing.Point(247, 99);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(96, 43);
            this.Cancel_button.TabIndex = 12;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // ID_textbox
            // 
            this.ID_textbox.Location = new System.Drawing.Point(122, 47);
            this.ID_textbox.Name = "ID_textbox";
            this.ID_textbox.Size = new System.Drawing.Size(221, 22);
            this.ID_textbox.TabIndex = 14;
            // 
            // ID_label
            // 
            this.ID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.Location = new System.Drawing.Point(58, 43);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(44, 33);
            this.ID_label.TabIndex = 15;
            this.ID_label.Text = "ID:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(429, 184);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.ID_textbox);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Comfirm_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Telefonbok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Comfirm_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.TextBox ID_textbox;
        private System.Windows.Forms.Label ID_label;
    }
}