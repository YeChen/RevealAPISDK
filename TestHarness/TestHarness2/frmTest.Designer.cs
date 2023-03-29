
namespace TestHarness2
{
    partial class frmTest
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
            this.btTest = new System.Windows.Forms.Button();
            this.btV2Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtProjects = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btListProjects = new System.Windows.Forms.Button();
            this.btRunSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCaseID = new System.Windows.Forms.TextBox();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btReadText = new System.Windows.Forms.Button();
            this.txtDocId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btCreateField = new System.Windows.Forms.Button();
            this.btUpdateField = new System.Windows.Forms.Button();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFieldValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btReindex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTest
            // 
            this.btTest.Location = new System.Drawing.Point(164, 213);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(238, 71);
            this.btTest.TabIndex = 0;
            this.btTest.Text = "Test v1 Login";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // btV2Login
            // 
            this.btV2Login.Location = new System.Drawing.Point(164, 309);
            this.btV2Login.Name = "btV2Login";
            this.btV2Login.Size = new System.Drawing.Size(238, 71);
            this.btV2Login.TabIndex = 1;
            this.btV2Login.Text = "Test v2 Login";
            this.btV2Login.UseVisualStyleBackColor = true;
            this.btV2Login.Click += new System.EventHandler(this.btV2Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(161, 81);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(526, 26);
            this.txtUser.TabIndex = 4;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(164, 146);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(516, 26);
            this.txtPwd.TabIndex = 5;
            // 
            // txtProjects
            // 
            this.txtProjects.Location = new System.Drawing.Point(754, 70);
            this.txtProjects.Multiline = true;
            this.txtProjects.Name = "txtProjects";
            this.txtProjects.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtProjects.Size = new System.Drawing.Size(778, 1023);
            this.txtProjects.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Results";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "API URL";
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtURL.Location = new System.Drawing.Point(161, 31);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(526, 26);
            this.txtURL.TabIndex = 9;
            this.txtURL.Text = "https://consulting.us-east-1.reveal11.cloud/rest/api/v2/login";
            // 
            // btListProjects
            // 
            this.btListProjects.Location = new System.Drawing.Point(161, 406);
            this.btListProjects.Name = "btListProjects";
            this.btListProjects.Size = new System.Drawing.Size(238, 71);
            this.btListProjects.TabIndex = 11;
            this.btListProjects.Text = "List Projects";
            this.btListProjects.UseVisualStyleBackColor = true;
            this.btListProjects.Click += new System.EventHandler(this.btListProjects_Click);
            // 
            // btRunSearch
            // 
            this.btRunSearch.Location = new System.Drawing.Point(164, 510);
            this.btRunSearch.Name = "btRunSearch";
            this.btRunSearch.Size = new System.Drawing.Size(238, 71);
            this.btRunSearch.TabIndex = 12;
            this.btRunSearch.Text = "Run Search";
            this.btRunSearch.UseVisualStyleBackColor = true;
            this.btRunSearch.Click += new System.EventHandler(this.btRunSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Case ID";
            // 
            // txtCaseID
            // 
            this.txtCaseID.Location = new System.Drawing.Point(508, 517);
            this.txtCaseID.Name = "txtCaseID";
            this.txtCaseID.Size = new System.Drawing.Size(104, 26);
            this.txtCaseID.TabIndex = 14;
            this.txtCaseID.Text = "170";
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(508, 558);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(104, 26);
            this.txtSearchID.TabIndex = 16;
            this.txtSearchID.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 561);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Search ID";
            // 
            // btReadText
            // 
            this.btReadText.Location = new System.Drawing.Point(164, 631);
            this.btReadText.Name = "btReadText";
            this.btReadText.Size = new System.Drawing.Size(238, 71);
            this.btReadText.TabIndex = 17;
            this.btReadText.Text = "Read Text (V1)";
            this.btReadText.UseVisualStyleBackColor = true;
            this.btReadText.Click += new System.EventHandler(this.btReadText_Click);
            // 
            // txtDocId
            // 
            this.txtDocId.Location = new System.Drawing.Point(508, 676);
            this.txtDocId.Name = "txtDocId";
            this.txtDocId.Size = new System.Drawing.Size(104, 26);
            this.txtDocId.TabIndex = 19;
            this.txtDocId.Text = "78, 73";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 679);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "DocId";
            // 
            // btCreateField
            // 
            this.btCreateField.Location = new System.Drawing.Point(164, 743);
            this.btCreateField.Name = "btCreateField";
            this.btCreateField.Size = new System.Drawing.Size(238, 71);
            this.btCreateField.TabIndex = 20;
            this.btCreateField.Text = "Create field";
            this.btCreateField.UseVisualStyleBackColor = true;
            this.btCreateField.Click += new System.EventHandler(this.btCreateField_Click);
            // 
            // btUpdateField
            // 
            this.btUpdateField.Location = new System.Drawing.Point(161, 903);
            this.btUpdateField.Name = "btUpdateField";
            this.btUpdateField.Size = new System.Drawing.Size(238, 71);
            this.btUpdateField.TabIndex = 21;
            this.btUpdateField.Text = "Update Above Field";
            this.btUpdateField.UseVisualStyleBackColor = true;
            this.btUpdateField.Click += new System.EventHandler(this.btUpdateText_Click);
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(455, 788);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(157, 26);
            this.txtFieldName.TabIndex = 23;
            this.txtFieldName.Text = "TranslatedABC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 755);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "fieldname";
            // 
            // txtFieldValue
            // 
            this.txtFieldValue.Location = new System.Drawing.Point(432, 903);
            this.txtFieldValue.Multiline = true;
            this.txtFieldValue.Name = "txtFieldValue";
            this.txtFieldValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFieldValue.Size = new System.Drawing.Size(287, 80);
            this.txtFieldValue.TabIndex = 24;
            this.txtFieldValue.Text = "hello world!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(431, 870);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 30);
            this.label9.TabIndex = 25;
            this.label9.Text = "Value";
            // 
            // btReindex
            // 
            this.btReindex.Location = new System.Drawing.Point(164, 1022);
            this.btReindex.Name = "btReindex";
            this.btReindex.Size = new System.Drawing.Size(238, 71);
            this.btReindex.TabIndex = 26;
            this.btReindex.Text = "ReIndex";
            this.btReindex.UseVisualStyleBackColor = true;
            this.btReindex.Click += new System.EventHandler(this.btReindex_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 1243);
            this.Controls.Add(this.btReindex);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFieldValue);
            this.Controls.Add(this.txtFieldName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btUpdateField);
            this.Controls.Add(this.btCreateField);
            this.Controls.Add(this.txtDocId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btReadText);
            this.Controls.Add(this.txtSearchID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCaseID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btRunSearch);
            this.Controls.Add(this.btListProjects);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProjects);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btV2Login);
            this.Controls.Add(this.btTest);
            this.Name = "frmTest";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.Button btV2Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtProjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btListProjects;
        private System.Windows.Forms.Button btRunSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCaseID;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btReadText;
        private System.Windows.Forms.TextBox txtDocId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCreateField;
        private System.Windows.Forms.Button btUpdateField;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFieldValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btReindex;
    }
}

