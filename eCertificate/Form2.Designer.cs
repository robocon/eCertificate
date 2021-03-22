
namespace eCertificate
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notify = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchIdCard = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.showUserLogin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.userFullName = new System.Windows.Forms.Label();
            this.userIdcard = new System.Windows.Forms.Label();
            this.userDiag = new System.Windows.Forms.Label();
            this.userRegular = new System.Windows.Forms.Label();
            this.userDoctor = new System.Windows.Forms.Label();
            this.userAddress = new System.Windows.Forms.Label();
            this.userDateDiag = new System.Windows.Forms.Label();
            this.userHos = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.showHosName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.notify);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.searchIdCard);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหา";
            // 
            // notify
            // 
            this.notify.AutoSize = true;
            this.notify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notify.Location = new System.Drawing.Point(16, 64);
            this.notify.Name = "notify";
            this.notify.Size = new System.Drawing.Size(14, 20);
            this.notify.TabIndex = 27;
            this.notify.Text = "-";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(296, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "บัตรปชช :";
            // 
            // searchIdCard
            // 
            this.searchIdCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIdCard.Location = new System.Drawing.Point(88, 32);
            this.searchIdCard.Name = "searchIdCard";
            this.searchIdCard.Size = new System.Drawing.Size(200, 26);
            this.searchIdCard.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(608, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "ชื่อผู้ใช้ : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(888, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(104, 32);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "ออกจากระบบ";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // showUserLogin
            // 
            this.showUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showUserLogin.Location = new System.Drawing.Point(672, 16);
            this.showUserLogin.Name = "showUserLogin";
            this.showUserLogin.Size = new System.Drawing.Size(208, 24);
            this.showUserLogin.TabIndex = 4;
            this.showUserLogin.Text = "xxxx";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 128);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "ชื่อ-สกุล :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "เลขบัตรประชาชน :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "โรคที่ตรวจพบ :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "กฎกระทรวง :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "แพทย์ผู้ตรวจ :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "ที่อยู่ :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "วันที่ได้รับการตรวจ :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "โรงพยาบาล :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // userFullName
            // 
            this.userFullName.AutoSize = true;
            this.userFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFullName.Location = new System.Drawing.Point(144, 128);
            this.userFullName.Name = "userFullName";
            this.userFullName.Size = new System.Drawing.Size(14, 20);
            this.userFullName.TabIndex = 14;
            this.userFullName.Text = "-";
            // 
            // userIdcard
            // 
            this.userIdcard.AutoSize = true;
            this.userIdcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdcard.Location = new System.Drawing.Point(144, 152);
            this.userIdcard.Name = "userIdcard";
            this.userIdcard.Size = new System.Drawing.Size(14, 20);
            this.userIdcard.TabIndex = 15;
            this.userIdcard.Text = "-";
            // 
            // userDiag
            // 
            this.userDiag.AutoSize = true;
            this.userDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDiag.Location = new System.Drawing.Point(144, 176);
            this.userDiag.Name = "userDiag";
            this.userDiag.Size = new System.Drawing.Size(14, 20);
            this.userDiag.TabIndex = 16;
            this.userDiag.Text = "-";
            // 
            // userRegular
            // 
            this.userRegular.AutoSize = true;
            this.userRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegular.Location = new System.Drawing.Point(144, 200);
            this.userRegular.Name = "userRegular";
            this.userRegular.Size = new System.Drawing.Size(14, 20);
            this.userRegular.TabIndex = 17;
            this.userRegular.Text = "-";
            // 
            // userDoctor
            // 
            this.userDoctor.AutoSize = true;
            this.userDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDoctor.Location = new System.Drawing.Point(144, 224);
            this.userDoctor.Name = "userDoctor";
            this.userDoctor.Size = new System.Drawing.Size(14, 20);
            this.userDoctor.TabIndex = 18;
            this.userDoctor.Text = "-";
            // 
            // userAddress
            // 
            this.userAddress.AutoSize = true;
            this.userAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAddress.Location = new System.Drawing.Point(144, 296);
            this.userAddress.Name = "userAddress";
            this.userAddress.Size = new System.Drawing.Size(14, 20);
            this.userAddress.TabIndex = 21;
            this.userAddress.Text = "-";
            // 
            // userDateDiag
            // 
            this.userDateDiag.AutoSize = true;
            this.userDateDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDateDiag.Location = new System.Drawing.Point(144, 320);
            this.userDateDiag.Name = "userDateDiag";
            this.userDateDiag.Size = new System.Drawing.Size(14, 20);
            this.userDateDiag.TabIndex = 22;
            this.userDateDiag.Text = "-";
            // 
            // userHos
            // 
            this.userHos.AutoSize = true;
            this.userHos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userHos.Location = new System.Drawing.Point(144, 344);
            this.userHos.Name = "userHos";
            this.userHos.Size = new System.Drawing.Size(14, 20);
            this.userHos.TabIndex = 23;
            this.userHos.Text = "-";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(608, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 24);
            this.label14.TabIndex = 24;
            this.label14.Text = "รพ. : ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // showHosName
            // 
            this.showHosName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showHosName.Location = new System.Drawing.Point(672, 40);
            this.showHosName.Name = "showHosName";
            this.showHosName.Size = new System.Drawing.Size(208, 24);
            this.showHosName.TabIndex = 25;
            this.showHosName.Text = "xxxx";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.showHosName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.userHos);
            this.Controls.Add(this.userDateDiag);
            this.Controls.Add(this.userAddress);
            this.Controls.Add(this.userDoctor);
            this.Controls.Add(this.userRegular);
            this.Controls.Add(this.userDiag);
            this.Controls.Add(this.userIdcard);
            this.Controls.Add(this.userFullName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showUserLogin);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "e-medical-certificate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchIdCard;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label showUserLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label userFullName;
        private System.Windows.Forms.Label userIdcard;
        private System.Windows.Forms.Label userDiag;
        private System.Windows.Forms.Label userRegular;
        private System.Windows.Forms.Label userDoctor;
        private System.Windows.Forms.Label userAddress;
        private System.Windows.Forms.Label userDateDiag;
        private System.Windows.Forms.Label userHos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label showHosName;
        private System.Windows.Forms.Label notify;
    }
}