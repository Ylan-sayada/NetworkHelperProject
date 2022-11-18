namespace NetworkHelperProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.MenuPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.maskFounderButtonPage = new System.Windows.Forms.Button();
            this.subnetButtonPage = new System.Windows.Forms.Button();
            this.CIDRButtonPage = new System.Windows.Forms.Button();
            this.pingHimButtonPage = new System.Windows.Forms.Button();
            this.NetworkInformationPage = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.networkInfo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PingHimPage = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.PingHimResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AdressToPing = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FindCIDRPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.resultCIDR = new System.Windows.Forms.Label();
            this.CIDR_result_label = new System.Windows.Forms.Label();
            this.IP_ToCIDR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.findCIDR_btn = new System.Windows.Forms.Button();
            this.CIDRFindBtn = new System.Windows.Forms.Button();
            this.MaskFounderPage = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.resultMaskFound = new System.Windows.Forms.Label();
            this.result_label_maskFounder = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.ipToFindMask = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SendHttpRequesrtPage = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.MenuPage.SuspendLayout();
            this.NetworkInformationPage.SuspendLayout();
            this.PingHimPage.SuspendLayout();
            this.FindCIDRPage.SuspendLayout();
            this.MaskFounderPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.MenuPage);
            this.tabControl.Controls.Add(this.NetworkInformationPage);
            this.tabControl.Controls.Add(this.PingHimPage);
            this.tabControl.Controls.Add(this.FindCIDRPage);
            this.tabControl.Controls.Add(this.MaskFounderPage);
            this.tabControl.Controls.Add(this.SendHttpRequesrtPage);
            this.tabControl.Location = new System.Drawing.Point(-8, -31);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(815, 489);
            this.tabControl.TabIndex = 0;
            // 
            // MenuPage
            // 
            this.MenuPage.Controls.Add(this.label1);
            this.MenuPage.Controls.Add(this.maskFounderButtonPage);
            this.MenuPage.Controls.Add(this.subnetButtonPage);
            this.MenuPage.Controls.Add(this.CIDRButtonPage);
            this.MenuPage.Controls.Add(this.pingHimButtonPage);
            this.MenuPage.Location = new System.Drawing.Point(4, 24);
            this.MenuPage.Name = "MenuPage";
            this.MenuPage.Padding = new System.Windows.Forms.Padding(3);
            this.MenuPage.Size = new System.Drawing.Size(807, 461);
            this.MenuPage.TabIndex = 0;
            this.MenuPage.Text = "Menu";
            this.MenuPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(184, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 86);
            this.label1.TabIndex = 7;
            this.label1.Text = "Network Helper ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // maskFounderButtonPage
            // 
            this.maskFounderButtonPage.Location = new System.Drawing.Point(220, 234);
            this.maskFounderButtonPage.Name = "maskFounderButtonPage";
            this.maskFounderButtonPage.Size = new System.Drawing.Size(108, 48);
            this.maskFounderButtonPage.TabIndex = 6;
            this.maskFounderButtonPage.Text = "Mask Founder";
            this.maskFounderButtonPage.UseVisualStyleBackColor = true;
            this.maskFounderButtonPage.Click += new System.EventHandler(this.maskFounderButtonPage_Click);
            // 
            // subnetButtonPage
            // 
            this.subnetButtonPage.Location = new System.Drawing.Point(220, 129);
            this.subnetButtonPage.Name = "subnetButtonPage";
            this.subnetButtonPage.Size = new System.Drawing.Size(108, 48);
            this.subnetButtonPage.TabIndex = 5;
            this.subnetButtonPage.Text = "My network information";
            this.subnetButtonPage.UseVisualStyleBackColor = true;
            this.subnetButtonPage.Click += new System.EventHandler(this.subnetButtonPage_Click);
            // 
            // CIDRButtonPage
            // 
            this.CIDRButtonPage.Location = new System.Drawing.Point(514, 234);
            this.CIDRButtonPage.Name = "CIDRButtonPage";
            this.CIDRButtonPage.Size = new System.Drawing.Size(108, 48);
            this.CIDRButtonPage.TabIndex = 4;
            this.CIDRButtonPage.Text = "Find the CIDR";
            this.CIDRButtonPage.UseVisualStyleBackColor = true;
            this.CIDRButtonPage.Click += new System.EventHandler(this.CIDRButtonPage_Click);
            // 
            // pingHimButtonPage
            // 
            this.pingHimButtonPage.Location = new System.Drawing.Point(514, 128);
            this.pingHimButtonPage.Name = "pingHimButtonPage";
            this.pingHimButtonPage.Size = new System.Drawing.Size(108, 49);
            this.pingHimButtonPage.TabIndex = 3;
            this.pingHimButtonPage.Text = "Ping Him";
            this.pingHimButtonPage.UseVisualStyleBackColor = true;
            this.pingHimButtonPage.Click += new System.EventHandler(this.pingHimButtonPage_Click);
            // 
            // NetworkInformationPage
            // 
            this.NetworkInformationPage.Controls.Add(this.button2);
            this.NetworkInformationPage.Controls.Add(this.networkInfo);
            this.NetworkInformationPage.Controls.Add(this.label8);
            this.NetworkInformationPage.Location = new System.Drawing.Point(4, 24);
            this.NetworkInformationPage.Name = "NetworkInformationPage";
            this.NetworkInformationPage.Padding = new System.Windows.Forms.Padding(3);
            this.NetworkInformationPage.Size = new System.Drawing.Size(807, 461);
            this.NetworkInformationPage.TabIndex = 1;
            this.NetworkInformationPage.Text = "Network information";
            this.NetworkInformationPage.UseVisualStyleBackColor = true;
            this.NetworkInformationPage.Click += new System.EventHandler(this.NetworkInformationPage_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "return to menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // networkInfo
            // 
            this.networkInfo.AcceptsReturn = true;
            this.networkInfo.AcceptsTab = true;
            this.networkInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.networkInfo.Location = new System.Drawing.Point(59, 77);
            this.networkInfo.Multiline = true;
            this.networkInfo.Name = "networkInfo";
            this.networkInfo.ReadOnly = true;
            this.networkInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.networkInfo.Size = new System.Drawing.Size(714, 357);
            this.networkInfo.TabIndex = 3;
            this.networkInfo.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(283, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Network informations";
            // 
            // PingHimPage
            // 
            this.PingHimPage.Controls.Add(this.button4);
            this.PingHimPage.Controls.Add(this.PingHimResult);
            this.PingHimPage.Controls.Add(this.label5);
            this.PingHimPage.Controls.Add(this.AdressToPing);
            this.PingHimPage.Controls.Add(this.button3);
            this.PingHimPage.Controls.Add(this.label3);
            this.PingHimPage.Location = new System.Drawing.Point(4, 24);
            this.PingHimPage.Name = "PingHimPage";
            this.PingHimPage.Size = new System.Drawing.Size(807, 461);
            this.PingHimPage.TabIndex = 2;
            this.PingHimPage.Text = "Ping him";
            this.PingHimPage.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 36);
            this.button4.TabIndex = 5;
            this.button4.Text = "back to menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PingHimResult
            // 
            this.PingHimResult.AutoSize = true;
            this.PingHimResult.Location = new System.Drawing.Point(289, 311);
            this.PingHimResult.Name = "PingHimResult";
            this.PingHimResult.Size = new System.Drawing.Size(0, 15);
            this.PingHimResult.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "The Adress to send ping";
            // 
            // AdressToPing
            // 
            this.AdressToPing.Location = new System.Drawing.Point(273, 165);
            this.AdressToPing.Name = "AdressToPing";
            this.AdressToPing.Size = new System.Drawing.Size(221, 23);
            this.AdressToPing.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(351, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(339, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ping Him";
            // 
            // FindCIDRPage
            // 
            this.FindCIDRPage.Controls.Add(this.button1);
            this.FindCIDRPage.Controls.Add(this.label4);
            this.FindCIDRPage.Controls.Add(this.resultCIDR);
            this.FindCIDRPage.Controls.Add(this.CIDR_result_label);
            this.FindCIDRPage.Controls.Add(this.IP_ToCIDR);
            this.FindCIDRPage.Controls.Add(this.label2);
            this.FindCIDRPage.Controls.Add(this.findCIDR_btn);
            this.FindCIDRPage.Controls.Add(this.CIDRFindBtn);
            this.FindCIDRPage.Location = new System.Drawing.Point(4, 24);
            this.FindCIDRPage.Name = "FindCIDRPage";
            this.FindCIDRPage.Size = new System.Drawing.Size(807, 461);
            this.FindCIDRPage.TabIndex = 3;
            this.FindCIDRPage.Text = "Find the CIDR";
            this.FindCIDRPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "back to menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Submit a mask";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // resultCIDR
            // 
            this.resultCIDR.AutoSize = true;
            this.resultCIDR.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultCIDR.Location = new System.Drawing.Point(365, 323);
            this.resultCIDR.Name = "resultCIDR";
            this.resultCIDR.Size = new System.Drawing.Size(0, 37);
            this.resultCIDR.TabIndex = 4;
            // 
            // CIDR_result_label
            // 
            this.CIDR_result_label.AutoSize = true;
            this.CIDR_result_label.Location = new System.Drawing.Point(365, 288);
            this.CIDR_result_label.Name = "CIDR_result_label";
            this.CIDR_result_label.Size = new System.Drawing.Size(48, 15);
            this.CIDR_result_label.TabIndex = 3;
            this.CIDR_result_label.Text = "Result : ";
            this.CIDR_result_label.Visible = false;
            this.CIDR_result_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // IP_ToCIDR
            // 
            this.IP_ToCIDR.Location = new System.Drawing.Point(288, 179);
            this.IP_ToCIDR.Name = "IP_ToCIDR";
            this.IP_ToCIDR.Size = new System.Drawing.Size(198, 23);
            this.IP_ToCIDR.TabIndex = 2;
            this.IP_ToCIDR.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(300, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Find CIDR Tool";
            // 
            // findCIDR_btn
            // 
            this.findCIDR_btn.Location = new System.Drawing.Point(332, 219);
            this.findCIDR_btn.Name = "findCIDR_btn";
            this.findCIDR_btn.Size = new System.Drawing.Size(113, 41);
            this.findCIDR_btn.TabIndex = 0;
            this.findCIDR_btn.Text = "Find it!";
            this.findCIDR_btn.UseVisualStyleBackColor = true;
            this.findCIDR_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CIDRFindBtn
            // 
            this.CIDRFindBtn.Location = new System.Drawing.Point(332, 219);
            this.CIDRFindBtn.Name = "CIDRFindBtn";
            this.CIDRFindBtn.Size = new System.Drawing.Size(113, 41);
            this.CIDRFindBtn.TabIndex = 0;
            this.CIDRFindBtn.Text = "Find it!";
            this.CIDRFindBtn.UseVisualStyleBackColor = true;
            // 
            // MaskFounderPage
            // 
            this.MaskFounderPage.Controls.Add(this.button6);
            this.MaskFounderPage.Controls.Add(this.resultMaskFound);
            this.MaskFounderPage.Controls.Add(this.result_label_maskFounder);
            this.MaskFounderPage.Controls.Add(this.button5);
            this.MaskFounderPage.Controls.Add(this.ipToFindMask);
            this.MaskFounderPage.Controls.Add(this.label7);
            this.MaskFounderPage.Controls.Add(this.label6);
            this.MaskFounderPage.Location = new System.Drawing.Point(4, 24);
            this.MaskFounderPage.Name = "MaskFounderPage";
            this.MaskFounderPage.Size = new System.Drawing.Size(807, 461);
            this.MaskFounderPage.TabIndex = 4;
            this.MaskFounderPage.Text = "Mask Founder";
            this.MaskFounderPage.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 40);
            this.button6.TabIndex = 6;
            this.button6.Text = "return to menu";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // resultMaskFound
            // 
            this.resultMaskFound.AutoSize = true;
            this.resultMaskFound.Location = new System.Drawing.Point(265, 310);
            this.resultMaskFound.Name = "resultMaskFound";
            this.resultMaskFound.Size = new System.Drawing.Size(0, 15);
            this.resultMaskFound.TabIndex = 5;
            this.resultMaskFound.Click += new System.EventHandler(this.label9_Click);
            // 
            // result_label_maskFounder
            // 
            this.result_label_maskFounder.AutoSize = true;
            this.result_label_maskFounder.Location = new System.Drawing.Point(265, 282);
            this.result_label_maskFounder.Name = "result_label_maskFounder";
            this.result_label_maskFounder.Size = new System.Drawing.Size(48, 15);
            this.result_label_maskFounder.TabIndex = 4;
            this.result_label_maskFounder.Text = "Result : ";
            this.result_label_maskFounder.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(307, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Find the mask !";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ipToFindMask
            // 
            this.ipToFindMask.Location = new System.Drawing.Point(265, 170);
            this.ipToFindMask.Name = "ipToFindMask";
            this.ipToFindMask.Size = new System.Drawing.Size(202, 23);
            this.ipToFindMask.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ip Adress : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(285, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mask Founder";
            // 
            // SendHttpRequesrtPage
            // 
            this.SendHttpRequesrtPage.Location = new System.Drawing.Point(4, 24);
            this.SendHttpRequesrtPage.Name = "SendHttpRequesrtPage";
            this.SendHttpRequesrtPage.Size = new System.Drawing.Size(807, 461);
            this.SendHttpRequesrtPage.TabIndex = 5;
            this.SendHttpRequesrtPage.Text = "Send Http Request";
            this.SendHttpRequesrtPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.MenuPage.ResumeLayout(false);
            this.MenuPage.PerformLayout();
            this.NetworkInformationPage.ResumeLayout(false);
            this.NetworkInformationPage.PerformLayout();
            this.PingHimPage.ResumeLayout(false);
            this.PingHimPage.PerformLayout();
            this.FindCIDRPage.ResumeLayout(false);
            this.FindCIDRPage.PerformLayout();
            this.MaskFounderPage.ResumeLayout(false);
            this.MaskFounderPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage MenuPage;
        private TabPage NetworkInformationPage;
        private Label label1;
        private Button maskFounderButtonPage;
        private Button subnetButtonPage;
        private Button CIDRButtonPage;
        private Button pingHimButtonPage;
        private TabPage PingHimPage;
        private TabPage FindCIDRPage;
        private TabPage MaskFounderPage;
        private TabPage SendHttpRequesrtPage;
        private TextBox IP_ToCIDR;
        private Label label2;
        private Button CIDRFindBtn;
        private Label CIDR_result_label;
        private Label resultCIDR;
        private Label label4;
        private Button findCIDR_btn;
        private Button button1;
        private Label label5;
        private TextBox AdressToPing;
        private Button button3;
        private Label label3;
        private Label PingHimResult;
        private Button button4;
        private Label resultMaskFound;
        private Label result_label_maskFounder;
        private Button button5;
        private TextBox ipToFindMask;
        private Label label7;
        private Label label6;
        private Button button6;
        private Label label8;
        private TextBox networkInfo;
        private Button button2;
    }
}