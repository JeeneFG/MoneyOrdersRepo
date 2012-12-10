namespace ExamProg
{
    partial class AddOrders
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label orderSummaLabel;
            System.Windows.Forms.Label recipientNameLabel;
            System.Windows.Forms.Label senderNameLabel;
            System.Windows.Forms.Label orderViewNameLabel;
            this.ordersListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.orderSummaTextBox = new System.Windows.Forms.TextBox();
            this.orderViewsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipientsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipientNameComboBox = new System.Windows.Forms.ComboBox();
            this.sendersInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senderNameComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.orderViewNameComboBox = new System.Windows.Forms.ComboBox();
            dateLabel = new System.Windows.Forms.Label();
            orderSummaLabel = new System.Windows.Forms.Label();
            recipientNameLabel = new System.Windows.Forms.Label();
            senderNameLabel = new System.Windows.Forms.Label();
            orderViewNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderViewsInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipientsInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(24, 16);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Date:";
            // 
            // orderSummaLabel
            // 
            orderSummaLabel.AutoSize = true;
            orderSummaLabel.Location = new System.Drawing.Point(31, 56);
            orderSummaLabel.Name = "orderSummaLabel";
            orderSummaLabel.Size = new System.Drawing.Size(74, 13);
            orderSummaLabel.TabIndex = 2;
            orderSummaLabel.Text = "Order Summa:";
            // 
            // recipientNameLabel
            // 
            recipientNameLabel.AutoSize = true;
            recipientNameLabel.Location = new System.Drawing.Point(19, 110);
            recipientNameLabel.Name = "recipientNameLabel";
            recipientNameLabel.Size = new System.Drawing.Size(86, 13);
            recipientNameLabel.TabIndex = 6;
            recipientNameLabel.Text = "Recipient Name:";
            // 
            // senderNameLabel
            // 
            senderNameLabel.AutoSize = true;
            senderNameLabel.Location = new System.Drawing.Point(31, 136);
            senderNameLabel.Name = "senderNameLabel";
            senderNameLabel.Size = new System.Drawing.Size(75, 13);
            senderNameLabel.TabIndex = 8;
            senderNameLabel.Text = "Sender Name:";
            // 
            // orderViewNameLabel
            // 
            orderViewNameLabel.AutoSize = true;
            orderViewNameLabel.Location = new System.Drawing.Point(12, 83);
            orderViewNameLabel.Name = "orderViewNameLabel";
            orderViewNameLabel.Size = new System.Drawing.Size(93, 13);
            orderViewNameLabel.TabIndex = 12;
            orderViewNameLabel.Text = "Order View Name:";
            // 
            // ordersListBindingSource
            // 
            this.ordersListBindingSource.DataSource = typeof(ExamProgLibrary.OrdersInfo);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersListBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(73, 12);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 2;
            // 
            // orderSummaTextBox
            // 
            this.orderSummaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersListBindingSource, "OrderSumma", true));
            this.orderSummaTextBox.Location = new System.Drawing.Point(111, 53);
            this.orderSummaTextBox.Name = "orderSummaTextBox";
            this.orderSummaTextBox.Size = new System.Drawing.Size(137, 20);
            this.orderSummaTextBox.TabIndex = 3;
            // 
            // orderViewsInfoBindingSource
            // 
            this.orderViewsInfoBindingSource.DataSource = typeof(ExamProgLibrary.OrderViewsInfo);
            // 
            // recipientsInfoBindingSource
            // 
            this.recipientsInfoBindingSource.DataSource = typeof(ExamProgLibrary.RecipientsInfo);
            // 
            // recipientNameComboBox
            // 
            this.recipientNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipientsInfoBindingSource, "RecipientName", true));
            this.recipientNameComboBox.DataSource = this.recipientsInfoBindingSource;
            this.recipientNameComboBox.DisplayMember = "RecipientName";
            this.recipientNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recipientNameComboBox.FormattingEnabled = true;
            this.recipientNameComboBox.Location = new System.Drawing.Point(111, 107);
            this.recipientNameComboBox.Name = "recipientNameComboBox";
            this.recipientNameComboBox.Size = new System.Drawing.Size(137, 21);
            this.recipientNameComboBox.TabIndex = 7;
            this.recipientNameComboBox.ValueMember = "RecipientName";
            // 
            // sendersInfoBindingSource
            // 
            this.sendersInfoBindingSource.DataSource = typeof(ExamProgLibrary.SendersInfo);
            // 
            // senderNameComboBox
            // 
            this.senderNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sendersInfoBindingSource, "SenderName", true));
            this.senderNameComboBox.DataSource = this.sendersInfoBindingSource;
            this.senderNameComboBox.DisplayMember = "SenderName";
            this.senderNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.senderNameComboBox.FormattingEnabled = true;
            this.senderNameComboBox.Location = new System.Drawing.Point(112, 133);
            this.senderNameComboBox.Name = "senderNameComboBox";
            this.senderNameComboBox.Size = new System.Drawing.Size(136, 21);
            this.senderNameComboBox.TabIndex = 9;
            this.senderNameComboBox.ValueMember = "SenderName";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(145, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // orderViewNameComboBox
            // 
            this.orderViewNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderViewsInfoBindingSource, "OrderViewName", true));
            this.orderViewNameComboBox.DataSource = this.orderViewsInfoBindingSource;
            this.orderViewNameComboBox.DisplayMember = "OrderViewName";
            this.orderViewNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderViewNameComboBox.FormattingEnabled = true;
            this.orderViewNameComboBox.Location = new System.Drawing.Point(111, 80);
            this.orderViewNameComboBox.Name = "orderViewNameComboBox";
            this.orderViewNameComboBox.Size = new System.Drawing.Size(137, 21);
            this.orderViewNameComboBox.TabIndex = 13;
            this.orderViewNameComboBox.ValueMember = "OrderViewName";
            // 
            // AddOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 246);
            this.Controls.Add(orderViewNameLabel);
            this.Controls.Add(this.orderViewNameComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(senderNameLabel);
            this.Controls.Add(this.senderNameComboBox);
            this.Controls.Add(recipientNameLabel);
            this.Controls.Add(this.recipientNameComboBox);
            this.Controls.Add(orderSummaLabel);
            this.Controls.Add(this.orderSummaTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Name = "AddOrders";
            this.Text = "AddOrders";
            this.Load += new System.EventHandler(this.AddOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderViewsInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipientsInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ordersListBindingSource;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox orderSummaTextBox;
        private System.Windows.Forms.BindingSource orderViewsInfoBindingSource;
        private System.Windows.Forms.BindingSource recipientsInfoBindingSource;
        private System.Windows.Forms.ComboBox recipientNameComboBox;
        private System.Windows.Forms.BindingSource sendersInfoBindingSource;
        private System.Windows.Forms.ComboBox senderNameComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox orderViewNameComboBox;
    }
}