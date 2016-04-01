namespace DynamicFormLoading
{
    partial class MainForm
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
            this.btnGenerateForm = new System.Windows.Forms.Button();
            this.cmbObjects = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGenerateForm
            // 
            this.btnGenerateForm.Location = new System.Drawing.Point(37, 70);
            this.btnGenerateForm.Name = "btnGenerateForm";
            this.btnGenerateForm.Size = new System.Drawing.Size(121, 23);
            this.btnGenerateForm.TabIndex = 0;
            this.btnGenerateForm.Text = "Generate Form";
            this.btnGenerateForm.UseVisualStyleBackColor = true;
            this.btnGenerateForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbObjects
            // 
            this.cmbObjects.FormattingEnabled = true;
            this.cmbObjects.Location = new System.Drawing.Point(37, 28);
            this.cmbObjects.Name = "cmbObjects";
            this.cmbObjects.Size = new System.Drawing.Size(121, 24);
            this.cmbObjects.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 123);
            this.Controls.Add(this.cmbObjects);
            this.Controls.Add(this.btnGenerateForm);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateForm;
        private System.Windows.Forms.ComboBox cmbObjects;
    }
}

