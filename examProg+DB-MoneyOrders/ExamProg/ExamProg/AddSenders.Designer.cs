namespace ExamProg
{
    partial class AddSenders
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
            System.Windows.Forms.Label senderNameLabel;
            this.sendersInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senderNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            senderNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sendersInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sendersInfoBindingSource
            // 
            this.sendersInfoBindingSource.DataSource = typeof(ExamProgLibrary.SendersInfo);
            // 
            // senderNameLabel
            // 
            senderNameLabel.AutoSize = true;
            senderNameLabel.Location = new System.Drawing.Point(12, 19);
            senderNameLabel.Name = "senderNameLabel";
            senderNameLabel.Size = new System.Drawing.Size(75, 13);
            senderNameLabel.TabIndex = 1;
            senderNameLabel.Text = "Sender Name:";
            // 
            // senderNameTextBox
            // 
            this.senderNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sendersInfoBindingSource, "SenderName", true));
            this.senderNameTextBox.Location = new System.Drawing.Point(93, 16);
            this.senderNameTextBox.Name = "senderNameTextBox";
            this.senderNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.senderNameTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 48);
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
            this.button2.Location = new System.Drawing.Point(106, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddSenders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 80);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(senderNameLabel);
            this.Controls.Add(this.senderNameTextBox);
            this.Name = "AddSenders";
            this.Text = "AddSenders";
            this.Load += new System.EventHandler(this.AddSenders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sendersInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource sendersInfoBindingSource;
        private System.Windows.Forms.TextBox senderNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}