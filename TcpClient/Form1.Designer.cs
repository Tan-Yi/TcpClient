namespace TcpClient
{
    partial class form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ipAddressBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.portBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.contentBox = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.inputBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.sendButton = new DevComponents.DotNetBar.ButtonX();
            this.connectButton = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // ipAddressBox
            // 
            // 
            // 
            // 
            this.ipAddressBox.Border.Class = "TextBoxBorder";
            this.ipAddressBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipAddressBox.Location = new System.Drawing.Point(170, 42);
            this.ipAddressBox.Name = "ipAddressBox";
            this.ipAddressBox.PreventEnterBeep = true;
            this.ipAddressBox.Size = new System.Drawing.Size(100, 21);
            this.ipAddressBox.TabIndex = 0;
            // 
            // portBox
            // 
            // 
            // 
            // 
            this.portBox.Border.Class = "TextBoxBorder";
            this.portBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.portBox.Location = new System.Drawing.Point(419, 42);
            this.portBox.Name = "portBox";
            this.portBox.PreventEnterBeep = true;
            this.portBox.Size = new System.Drawing.Size(100, 21);
            this.portBox.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(76, 42);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "labelX1";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(338, 42);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "labelX2";
            // 
            // contentBox
            // 
            // 
            // 
            // 
            this.contentBox.BackgroundStyle.Class = "RichTextBoxBorder";
            this.contentBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.contentBox.Location = new System.Drawing.Point(76, 95);
            this.contentBox.Name = "contentBox";
            this.contentBox.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset" +
    "134 \\\'cb\\\'ce\\\'cc\\\'e5;}}\r\n\\viewkind4\\uc1\\pard\\lang2052\\f0\\fs18\\par\r\n}\r\n";
            this.contentBox.Size = new System.Drawing.Size(443, 179);
            this.contentBox.TabIndex = 4;
            // 
            // inputBox
            // 
            // 
            // 
            // 
            this.inputBox.Border.Class = "TextBoxBorder";
            this.inputBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.inputBox.Location = new System.Drawing.Point(106, 332);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.PreventEnterBeep = true;
            this.inputBox.Size = new System.Drawing.Size(363, 86);
            this.inputBox.TabIndex = 5;
            // 
            // sendButton
            // 
            this.sendButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.sendButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.sendButton.Location = new System.Drawing.Point(522, 332);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Send";
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.connectButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.connectButton.Location = new System.Drawing.Point(564, 41);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.connectButton.TabIndex = 7;
            this.connectButton.Text = "Connect";
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.ipAddressBox);
            this.Name = "form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form1_FormClosing);
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX ipAddressBox;
        private DevComponents.DotNetBar.Controls.TextBoxX portBox;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX inputBox;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx contentBox;
        private DevComponents.DotNetBar.ButtonX sendButton;
        private DevComponents.DotNetBar.ButtonX connectButton;
    }
}

