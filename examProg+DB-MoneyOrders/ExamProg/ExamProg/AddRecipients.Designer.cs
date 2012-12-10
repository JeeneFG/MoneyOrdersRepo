namespace ExamProg
{
    partial class AddRecipients
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
            System.Windows.Forms.Label recipientNameLabel;
            this.recipientNameTextBox = new System.Windows.Forms.TextBox();
            this.recipientsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            recipientNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recipientsInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // recipientNameLabel
            // 
            recipientNameLabel.AutoSize = true;
            recipientNameLabel.Location = new System.Drawing.Point(12, 20);
            recipientNameLabel.Name = "recipientNameLabel";
            recipientNameLabel.Size = new System.Drawing.Size(86, 13);
            recipientNameLabel.TabIndex = 1;
            recipientNameLabel.Text = "Recipient Name:";
            // 
            // recipientNameTextBox
            // 
            this.recipientNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipientsInfoBindingSource, "RecipientName", true));
            this.recipientNameTextBox.Location = new System.Drawing.Point(104, 17);
            this.recipientNameTextBox.Name = "recipientNameTextBox";
            this.recipientNameTextBox.Size = new System.Drawing.Size(127, 20);
            this.recipientNameTextBox.TabIndex = 2;
            // 
            // recipientsInfoBindingSource
            // 
            this.recipientsInfoBindingSource.DataSource = typeof(ExamProgLibrary.RecipientsInfo);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(113, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddRecipients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 82);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(recipientNameLabel);
            this.Controls.Add(this.recipientNameTextBox);
            this.Name = "AddRecipients";
            this.Text = "AddRecipients";
            this.Load += new System.EventHandler(this.AddRecipients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipientsInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource recipientsInfoBindingSource;
        private System.Windows.Forms.TextBox recipientNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}