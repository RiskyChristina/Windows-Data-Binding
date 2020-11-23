namespace InventoryManager.WinForms
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
            System.Windows.Forms.Label fileLabel;
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.selectfileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            fileLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.Location = new System.Drawing.Point(57, 11);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.ReadOnly = true;
            this.filenameTextBox.Size = new System.Drawing.Size(697, 20);
            this.filenameTextBox.TabIndex = 0;
            // 
            // selectfileButton
            // 
            this.selectfileButton.Location = new System.Drawing.Point(760, 10);
            this.selectfileButton.Name = "selectfileButton";
            this.selectfileButton.Size = new System.Drawing.Size(28, 23);
            this.selectfileButton.TabIndex = 1;
            this.selectfileButton.Text = "...";
            this.selectfileButton.UseVisualStyleBackColor = true;
            this.selectfileButton.Click += new System.EventHandler(this.selectfileButton_Click);
            // 
            // fileLabel
            // 
            fileLabel.AutoSize = true;
            fileLabel.Location = new System.Drawing.Point(25, 15);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new System.Drawing.Size(26, 13);
            fileLabel.TabIndex = 2;
            fileLabel.Text = "File:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files(*json)|*.json";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(fileLabel);
            this.Controls.Add(this.selectfileButton);
            this.Controls.Add(this.filenameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Inventory Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.Button selectfileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

