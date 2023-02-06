
namespace LdapLoginExample
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDomainPath = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelDomainPath = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonSearchGroupMember = new System.Windows.Forms.Button();
            this.labelGroup = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.textBoxOu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSetToProduction = new System.Windows.Forms.Button();
            this.buttonSetToUat = new System.Windows.Forms.Button();
            this.buttonExport900Excel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDomainPath
            // 
            this.textBoxDomainPath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDomainPath.Location = new System.Drawing.Point(117, 9);
            this.textBoxDomainPath.Name = "textBoxDomainPath";
            this.textBoxDomainPath.Size = new System.Drawing.Size(306, 32);
            this.textBoxDomainPath.TabIndex = 0;
            this.textBoxDomainPath.Text = "megabank.megafg.net";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(117, 85);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(306, 32);
            this.textBoxUserName.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(117, 124);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(306, 32);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelDomainPath
            // 
            this.labelDomainPath.AutoSize = true;
            this.labelDomainPath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDomainPath.Location = new System.Drawing.Point(16, 12);
            this.labelDomainPath.Name = "labelDomainPath";
            this.labelDomainPath.Size = new System.Drawing.Size(93, 24);
            this.labelDomainPath.TabIndex = 3;
            this.labelDomainPath.Text = "LdapPath:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(7, 87);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(102, 24);
            this.labelUserName.TabIndex = 4;
            this.labelUserName.Text = "UserName:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(15, 127);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(94, 24);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(11, 173);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(119, 46);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "TestLogin";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(11, 369);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(812, 440);
            this.textBoxResult.TabIndex = 7;
            // 
            // buttonSearchGroupMember
            // 
            this.buttonSearchGroupMember.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchGroupMember.Location = new System.Drawing.Point(12, 295);
            this.buttonSearchGroupMember.Name = "buttonSearchGroupMember";
            this.buttonSearchGroupMember.Size = new System.Drawing.Size(224, 46);
            this.buttonSearchGroupMember.TabIndex = 8;
            this.buttonSearchGroupMember.Text = "SearchGroupMember";
            this.buttonSearchGroupMember.UseVisualStyleBackColor = true;
            this.buttonSearchGroupMember.Click += new System.EventHandler(this.buttonSearchGroupMember_Click);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.Location = new System.Drawing.Point(34, 241);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(68, 24);
            this.labelGroup.TabIndex = 10;
            this.labelGroup.Text = "Group:";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroup.Location = new System.Drawing.Point(110, 238);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(306, 32);
            this.textBoxGroup.TabIndex = 11;
            this.textBoxGroup.Text = "WLFSYS";
            // 
            // textBoxOu
            // 
            this.textBoxOu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOu.Location = new System.Drawing.Point(117, 45);
            this.textBoxOu.Name = "textBoxOu";
            this.textBoxOu.Size = new System.Drawing.Size(306, 32);
            this.textBoxOu.TabIndex = 12;
            this.textBoxOu.Text = "DC=megabank,DC=megafg,DC=net";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "ou:";
            // 
            // buttonSetToProduction
            // 
            this.buttonSetToProduction.Location = new System.Drawing.Point(453, 9);
            this.buttonSetToProduction.Name = "buttonSetToProduction";
            this.buttonSetToProduction.Size = new System.Drawing.Size(157, 38);
            this.buttonSetToProduction.TabIndex = 14;
            this.buttonSetToProduction.Text = "SetToProduction";
            this.buttonSetToProduction.UseVisualStyleBackColor = true;
            this.buttonSetToProduction.Click += new System.EventHandler(this.buttonSetToProduction_Click);
            // 
            // buttonSetToUat
            // 
            this.buttonSetToUat.Location = new System.Drawing.Point(453, 53);
            this.buttonSetToUat.Name = "buttonSetToUat";
            this.buttonSetToUat.Size = new System.Drawing.Size(157, 38);
            this.buttonSetToUat.TabIndex = 15;
            this.buttonSetToUat.Text = "SetToUat";
            this.buttonSetToUat.UseVisualStyleBackColor = true;
            this.buttonSetToUat.Click += new System.EventHandler(this.buttonSetToUat_Click);
            // 
            // buttonExport900Excel
            // 
            this.buttonExport900Excel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport900Excel.Location = new System.Drawing.Point(252, 295);
            this.buttonExport900Excel.Name = "buttonExport900Excel";
            this.buttonExport900Excel.Size = new System.Drawing.Size(209, 46);
            this.buttonExport900Excel.TabIndex = 16;
            this.buttonExport900Excel.Text = "Export900Excel";
            this.buttonExport900Excel.UseVisualStyleBackColor = true;
            this.buttonExport900Excel.Click += new System.EventHandler(this.buttonExport900Excel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 821);
            this.Controls.Add(this.buttonExport900Excel);
            this.Controls.Add(this.buttonSetToUat);
            this.Controls.Add(this.buttonSetToProduction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOu);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.buttonSearchGroupMember);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelDomainPath);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxDomainPath);
            this.Name = "MainForm";
            this.Text = "Ad Login Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDomainPath;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelDomainPath;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonSearchGroupMember;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.TextBox textBoxOu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSetToProduction;
        private System.Windows.Forms.Button buttonSetToUat;
        private System.Windows.Forms.Button buttonExport900Excel;
    }
}

