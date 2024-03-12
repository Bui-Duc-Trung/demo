namespace demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMauSac = new System.Windows.Forms.TextBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.grpGiong = new System.Windows.Forms.GroupBox();
            this.rdoCai = new System.Windows.Forms.RadioButton();
            this.rdoDuc = new System.Windows.Forms.RadioButton();
            this.lblMauSac = new System.Windows.Forms.Label();
            this.lblTenLoai = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.picAnhDongVat = new System.Windows.Forms.PictureBox();
            this.cboLuaChon = new System.Windows.Forms.ComboBox();
            this.imgCho = new System.Windows.Forms.ImageList(this.components);
            this.imgMeo = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.grpGiong.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDongVat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtMauSac);
            this.panel1.Controls.Add(this.txtTenLoai);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.grpGiong);
            this.panel1.Controls.Add(this.lblMauSac);
            this.panel1.Controls.Add(this.lblTenLoai);
            this.panel1.Controls.Add(this.lblTen);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 482);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 283);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(443, 181);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(388, 232);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 35);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(26, 232);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 35);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMauSac
            // 
            this.txtMauSac.Location = new System.Drawing.Point(128, 182);
            this.txtMauSac.Name = "txtMauSac";
            this.txtMauSac.Size = new System.Drawing.Size(341, 26);
            this.txtMauSac.TabIndex = 6;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(128, 65);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(341, 26);
            this.txtTenLoai.TabIndex = 5;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(128, 30);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(341, 26);
            this.txtTen.TabIndex = 4;
            // 
            // grpGiong
            // 
            this.grpGiong.Controls.Add(this.rdoCai);
            this.grpGiong.Controls.Add(this.rdoDuc);
            this.grpGiong.Location = new System.Drawing.Point(26, 101);
            this.grpGiong.Name = "grpGiong";
            this.grpGiong.Size = new System.Drawing.Size(443, 70);
            this.grpGiong.TabIndex = 3;
            this.grpGiong.TabStop = false;
            this.grpGiong.Text = "Giống";
            // 
            // rdoCai
            // 
            this.rdoCai.AutoSize = true;
            this.rdoCai.Location = new System.Drawing.Point(305, 34);
            this.rdoCai.Name = "rdoCai";
            this.rdoCai.Size = new System.Drawing.Size(57, 24);
            this.rdoCai.TabIndex = 1;
            this.rdoCai.TabStop = true;
            this.rdoCai.Text = "Cái";
            this.rdoCai.UseVisualStyleBackColor = true;
            // 
            // rdoDuc
            // 
            this.rdoDuc.AutoSize = true;
            this.rdoDuc.Location = new System.Drawing.Point(102, 34);
            this.rdoDuc.Name = "rdoDuc";
            this.rdoDuc.Size = new System.Drawing.Size(63, 24);
            this.rdoDuc.TabIndex = 0;
            this.rdoDuc.TabStop = true;
            this.rdoDuc.Text = "Đực";
            this.rdoDuc.UseVisualStyleBackColor = true;
            // 
            // lblMauSac
            // 
            this.lblMauSac.AutoSize = true;
            this.lblMauSac.Location = new System.Drawing.Point(22, 185);
            this.lblMauSac.Name = "lblMauSac";
            this.lblMauSac.Size = new System.Drawing.Size(73, 20);
            this.lblMauSac.TabIndex = 2;
            this.lblMauSac.Text = "Màu sắc:";
            // 
            // lblTenLoai
            // 
            this.lblTenLoai.AutoSize = true;
            this.lblTenLoai.Location = new System.Drawing.Point(22, 68);
            this.lblTenLoai.Name = "lblTenLoai";
            this.lblTenLoai.Size = new System.Drawing.Size(68, 20);
            this.lblTenLoai.TabIndex = 1;
            this.lblTenLoai.Text = "Tên loài:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(22, 36);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(40, 20);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSau);
            this.panel2.Controls.Add(this.btnTruoc);
            this.panel2.Controls.Add(this.picAnhDongVat);
            this.panel2.Controls.Add(this.cboLuaChon);
            this.panel2.Location = new System.Drawing.Point(601, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 482);
            this.panel2.TabIndex = 1;
            // 
            // btnSau
            // 
            this.btnSau.Location = new System.Drawing.Point(353, 400);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(48, 35);
            this.btnSau.TabIndex = 10;
            this.btnSau.Text = ">";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Location = new System.Drawing.Point(81, 400);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(48, 35);
            this.btnTruoc.TabIndex = 9;
            this.btnTruoc.Text = "<";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // picAnhDongVat
            // 
            this.picAnhDongVat.Location = new System.Drawing.Point(29, 79);
            this.picAnhDongVat.Name = "picAnhDongVat";
            this.picAnhDongVat.Size = new System.Drawing.Size(430, 299);
            this.picAnhDongVat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhDongVat.TabIndex = 1;
            this.picAnhDongVat.TabStop = false;
            // 
            // cboLuaChon
            // 
            this.cboLuaChon.FormattingEnabled = true;
            this.cboLuaChon.Items.AddRange(new object[] {
            "Chó",
            "Mèo"});
            this.cboLuaChon.Location = new System.Drawing.Point(29, 28);
            this.cboLuaChon.Name = "cboLuaChon";
            this.cboLuaChon.Size = new System.Drawing.Size(430, 28);
            this.cboLuaChon.TabIndex = 0;
            this.cboLuaChon.SelectedIndexChanged += new System.EventHandler(this.cboLuaChon_SelectedIndexChanged);
            // 
            // imgCho
            // 
            this.imgCho.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCho.ImageStream")));
            this.imgCho.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCho.Images.SetKeyName(0, "cho1");
            this.imgCho.Images.SetKeyName(1, "cho2");
            this.imgCho.Images.SetKeyName(2, "cho3");
            this.imgCho.Images.SetKeyName(3, "cho4");
            this.imgCho.Images.SetKeyName(4, "cho5");
            // 
            // imgMeo
            // 
            this.imgMeo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMeo.ImageStream")));
            this.imgMeo.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMeo.Images.SetKeyName(0, "meo1");
            this.imgMeo.Images.SetKeyName(1, "meo2");
            this.imgMeo.Images.SetKeyName(2, "meo3");
            this.imgMeo.Images.SetKeyName(3, "meo4");
            this.imgMeo.Images.SetKeyName(4, "meo5");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Quản lý thú cưng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpGiong.ResumeLayout(false);
            this.grpGiong.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDongVat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpGiong;
        private System.Windows.Forms.RadioButton rdoCai;
        private System.Windows.Forms.RadioButton rdoDuc;
        private System.Windows.Forms.Label lblMauSac;
        private System.Windows.Forms.Label lblTenLoai;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMauSac;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboLuaChon;
        private System.Windows.Forms.PictureBox picAnhDongVat;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.ImageList imgCho;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imgMeo;
    }
}

