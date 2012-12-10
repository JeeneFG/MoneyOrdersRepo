namespace ExamProg
{
    partial class AddOrderViews
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
            System.Windows.Forms.Label orderViewNameLabel;
            this.orderViewNameTextBox = new System.Windows.Forms.TextBox();
            this.orderViewsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            orderViewNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderViewsInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderViewNameLabel
            // 
            orderViewNameLabel.AutoSize = true;
            orderViewNameLabel.Location = new System.Drawing.Point(11, 15);
            orderViewNameLabel.Name = "orderViewNameLabel";
            orderViewNameLabel.Size = new System.Drawing.Size(93, 13);
            orderViewNameLabel.TabIndex = 1;
            orderViewNameLabel.Text = "Order View Name:";
            // 
            // orderViewNameTextBox
            // 
            this.orderViewNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderViewsInfoBindingSource, "OrderViewName", true));
            this.orderViewNameTextBox.Location = new System.Drawing.Point(110, 12);
            this.orderViewNameTextBox.Name = "orderViewNameTextBox";
            this.orderViewNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderViewNameTextBox.TabIndex = 2;
            // 
            // orderViewsInfoBindingSource
            // 
            this.orderViewsInfoBindingSource.DataSource = typeof(ExamProgLibrary.OrderViewsInfo);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 45);
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
            this.button2.Location = new System.Drawing.Point(110, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddOrderViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 86);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(orderViewNameLabel);
            this.Controls.Add(this.orderViewNameTextBox);
            this.Name = "AddOrderViews";
            this.Text = "AddOrderViews";
            this.Load += new System.EventHandler(this.AddOrderViews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderViewsInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource orderViewsInfoBindingSource;
        private System.Windows.Forms.TextBox orderViewNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}