
namespace StealYoSpeed
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
            this.list_item = new System.Windows.Forms.ListBox();
            this.input_id = new System.Windows.Forms.TextBox();
            this.button_enterid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_name = new System.Windows.Forms.TextBox();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.contain_browser = new System.Windows.Forms.Panel();
            this.console = new System.Windows.Forms.RichTextBox();
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.input_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.list_buy = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_item
            // 
            this.list_item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list_item.FormattingEnabled = true;
            this.list_item.Location = new System.Drawing.Point(12, 94);
            this.list_item.Name = "list_item";
            this.list_item.Size = new System.Drawing.Size(306, 628);
            this.list_item.TabIndex = 0;
            // 
            // input_id
            // 
            this.input_id.Location = new System.Drawing.Point(12, 12);
            this.input_id.Name = "input_id";
            this.input_id.Size = new System.Drawing.Size(186, 20);
            this.input_id.TabIndex = 1;
            this.input_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_id_KeyPress);
            // 
            // button_enterid
            // 
            this.button_enterid.Location = new System.Drawing.Point(151, 68);
            this.button_enterid.Name = "button_enterid";
            this.button_enterid.Size = new System.Drawing.Size(48, 20);
            this.button_enterid.TabIndex = 3;
            this.button_enterid.Text = "GO";
            this.button_enterid.UseVisualStyleBackColor = true;
            this.button_enterid.Click += new System.EventHandler(this.button_enterid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(151, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(154, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(12, 40);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(185, 20);
            this.input_name.TabIndex = 5;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(324, 94);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(26, 23);
            this.button_remove.TabIndex = 7;
            this.button_remove.Text = "━";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_start
            // 
            this.button_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(324, 671);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(186, 49);
            this.button_start.TabIndex = 9;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // contain_browser
            // 
            this.contain_browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contain_browser.Location = new System.Drawing.Point(516, 14);
            this.contain_browser.Name = "contain_browser";
            this.contain_browser.Size = new System.Drawing.Size(740, 500);
            this.contain_browser.TabIndex = 10;
            // 
            // console
            // 
            this.console.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.console.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.Location = new System.Drawing.Point(516, 520);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(740, 200);
            this.console.TabIndex = 11;
            this.console.Text = "";
            this.console.TextChanged += new System.EventHandler(this.console_TextChanged);
            // 
            // Update
            // 
            this.Update.Enabled = true;
            this.Update.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // input_price
            // 
            this.input_price.Location = new System.Drawing.Point(13, 69);
            this.input_price.Name = "input_price";
            this.input_price.Size = new System.Drawing.Size(131, 20);
            this.input_price.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(102, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Robux";
            // 
            // list_buy
            // 
            this.list_buy.FormattingEnabled = true;
            this.list_buy.Location = new System.Drawing.Point(324, 520);
            this.list_buy.Name = "list_buy";
            this.list_buy.Size = new System.Drawing.Size(186, 147);
            this.list_buy.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Attempting to buy ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "STATUS:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(383, 146);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(27, 13);
            this.status.TabIndex = 17;
            this.status.Text = "OFF";
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(324, 11);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(92, 73);
            this.login.TabIndex = 18;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // logout
            // 
            this.logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(418, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(92, 73);
            this.logout.TabIndex = 19;
            this.logout.Text = "OUT";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 732);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.login);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.list_buy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_price);
            this.Controls.Add(this.console);
            this.Controls.Add(this.contain_browser);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_enterid);
            this.Controls.Add(this.input_id);
            this.Controls.Add(this.list_item);
            this.Name = "Form1";
            this.Text = "StealYoSpeed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_item;
        private System.Windows.Forms.TextBox input_id;
        private System.Windows.Forms.Button button_enterid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Panel contain_browser;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Timer Update;
        private System.Windows.Forms.TextBox input_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox list_buy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button logout;
    }
}

