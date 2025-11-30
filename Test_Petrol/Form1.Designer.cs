namespace Test_Petrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblOtogaz = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblGazyagi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblDiesel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblKursunsuz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtPlaka = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.BtnDepoDoldur = new System.Windows.Forms.Button();
            this.TxtOtogazFiyat = new System.Windows.Forms.TextBox();
            this.TxtGazyagıFiyat = new System.Windows.Forms.TextBox();
            this.TxtDieselFİyat = new System.Windows.Forms.TextBox();
            this.TxtKursunsuzFiyat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblOtogazLitre = new System.Windows.Forms.Label();
            this.LblGazLitre = new System.Windows.Forms.Label();
            this.LblDiesselLitre = new System.Windows.Forms.Label();
            this.LblKursunsuzLitre = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Lblkasa = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbAlisTur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAlınacakMiktar = new System.Windows.Forms.TextBox();
            this.TxtAlisTutar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSatinAl = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblOtogaz);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.LblGazyagi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.LblDiesel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblKursunsuz);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(246, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Benzin İstasyonu Fiyatları";
            // 
            // LblOtogaz
            // 
            this.LblOtogaz.AutoSize = true;
            this.LblOtogaz.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOtogaz.Location = new System.Drawing.Point(136, 131);
            this.LblOtogaz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblOtogaz.Name = "LblOtogaz";
            this.LblOtogaz.Size = new System.Drawing.Size(42, 18);
            this.LblOtogaz.TabIndex = 9;
            this.LblOtogaz.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(10, 131);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "PO/gaz Otogaz:";
            // 
            // LblGazyagi
            // 
            this.LblGazyagi.AutoSize = true;
            this.LblGazyagi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGazyagi.Location = new System.Drawing.Point(136, 107);
            this.LblGazyagi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGazyagi.Name = "LblGazyagi";
            this.LblGazyagi.Size = new System.Drawing.Size(42, 18);
            this.LblGazyagi.TabIndex = 7;
            this.LblGazyagi.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(61, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Gazyağı:";
            // 
            // LblDiesel
            // 
            this.LblDiesel.AutoSize = true;
            this.LblDiesel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDiesel.Location = new System.Drawing.Point(136, 78);
            this.LblDiesel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDiesel.Name = "LblDiesel";
            this.LblDiesel.Size = new System.Drawing.Size(42, 18);
            this.LblDiesel.TabIndex = 5;
            this.LblDiesel.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "V/Max Diesel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(137, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Litre Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(44, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yakıt Türü";
            // 
            // LblKursunsuz
            // 
            this.LblKursunsuz.AutoSize = true;
            this.LblKursunsuz.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKursunsuz.Location = new System.Drawing.Point(136, 52);
            this.LblKursunsuz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblKursunsuz.Name = "LblKursunsuz";
            this.LblKursunsuz.Size = new System.Drawing.Size(42, 18);
            this.LblKursunsuz.TabIndex = 1;
            this.LblKursunsuz.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kurşunsuz 95:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.TxtPlaka);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.BtnDepoDoldur);
            this.groupBox2.Controls.Add(this.TxtOtogazFiyat);
            this.groupBox2.Controls.Add(this.TxtGazyagıFiyat);
            this.groupBox2.Controls.Add(this.TxtDieselFİyat);
            this.groupBox2.Controls.Add(this.TxtKursunsuzFiyat);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(268, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(234, 332);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Dolum Listesi";
            // 
            // TxtPlaka
            // 
            this.TxtPlaka.Location = new System.Drawing.Point(118, 162);
            this.TxtPlaka.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPlaka.Name = "TxtPlaka";
            this.TxtPlaka.Size = new System.Drawing.Size(110, 20);
            this.TxtPlaka.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(58, 162);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 18);
            this.label20.TabIndex = 16;
            this.label20.Text = "Plaka:";
            // 
            // BtnDepoDoldur
            // 
            this.BtnDepoDoldur.Location = new System.Drawing.Point(7, 189);
            this.BtnDepoDoldur.Name = "BtnDepoDoldur";
            this.BtnDepoDoldur.Size = new System.Drawing.Size(220, 38);
            this.BtnDepoDoldur.TabIndex = 10;
            this.BtnDepoDoldur.Text = "Depo Doldur";
            this.BtnDepoDoldur.UseVisualStyleBackColor = true;
            this.BtnDepoDoldur.Click += new System.EventHandler(this.BtnDepoDoldur_Click);
            // 
            // TxtOtogazFiyat
            // 
            this.TxtOtogazFiyat.Location = new System.Drawing.Point(119, 135);
            this.TxtOtogazFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOtogazFiyat.Name = "TxtOtogazFiyat";
            this.TxtOtogazFiyat.Size = new System.Drawing.Size(110, 20);
            this.TxtOtogazFiyat.TabIndex = 9;
            // 
            // TxtGazyagıFiyat
            // 
            this.TxtGazyagıFiyat.Location = new System.Drawing.Point(119, 107);
            this.TxtGazyagıFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.TxtGazyagıFiyat.Name = "TxtGazyagıFiyat";
            this.TxtGazyagıFiyat.Size = new System.Drawing.Size(110, 20);
            this.TxtGazyagıFiyat.TabIndex = 8;
            // 
            // TxtDieselFİyat
            // 
            this.TxtDieselFİyat.Location = new System.Drawing.Point(119, 76);
            this.TxtDieselFİyat.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDieselFİyat.Name = "TxtDieselFİyat";
            this.TxtDieselFİyat.Size = new System.Drawing.Size(110, 20);
            this.TxtDieselFİyat.TabIndex = 7;
            // 
            // TxtKursunsuzFiyat
            // 
            this.TxtKursunsuzFiyat.Location = new System.Drawing.Point(119, 43);
            this.TxtKursunsuzFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.TxtKursunsuzFiyat.Name = "TxtKursunsuzFiyat";
            this.TxtKursunsuzFiyat.Size = new System.Drawing.Size(110, 20);
            this.TxtKursunsuzFiyat.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(155, 18);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 18);
            this.label12.TabIndex = 5;
            this.label12.Text = "Tutar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(22, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "Litre";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblOtogazLitre);
            this.groupBox3.Controls.Add(this.LblGazLitre);
            this.groupBox3.Controls.Add(this.LblDiesselLitre);
            this.groupBox3.Controls.Add(this.LblKursunsuzLitre);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.progressBar4);
            this.groupBox3.Controls.Add(this.progressBar3);
            this.groupBox3.Controls.Add(this.progressBar2);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Location = new System.Drawing.Point(510, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(313, 260);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Benzinlikteki Depo Toplamları";
            // 
            // LblOtogazLitre
            // 
            this.LblOtogazLitre.AutoSize = true;
            this.LblOtogazLitre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOtogazLitre.Location = new System.Drawing.Point(241, 135);
            this.LblOtogazLitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblOtogazLitre.Name = "LblOtogazLitre";
            this.LblOtogazLitre.Size = new System.Drawing.Size(42, 18);
            this.LblOtogazLitre.TabIndex = 14;
            this.LblOtogazLitre.Text = "0,00";
            // 
            // LblGazLitre
            // 
            this.LblGazLitre.AutoSize = true;
            this.LblGazLitre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGazLitre.Location = new System.Drawing.Point(241, 102);
            this.LblGazLitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGazLitre.Name = "LblGazLitre";
            this.LblGazLitre.Size = new System.Drawing.Size(42, 18);
            this.LblGazLitre.TabIndex = 13;
            this.LblGazLitre.Text = "0,00";
            // 
            // LblDiesselLitre
            // 
            this.LblDiesselLitre.AutoSize = true;
            this.LblDiesselLitre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDiesselLitre.Location = new System.Drawing.Point(241, 75);
            this.LblDiesselLitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDiesselLitre.Name = "LblDiesselLitre";
            this.LblDiesselLitre.Size = new System.Drawing.Size(42, 18);
            this.LblDiesselLitre.TabIndex = 12;
            this.LblDiesselLitre.Text = "0,00";
            // 
            // LblKursunsuzLitre
            // 
            this.LblKursunsuzLitre.AutoSize = true;
            this.LblKursunsuzLitre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKursunsuzLitre.Location = new System.Drawing.Point(241, 45);
            this.LblKursunsuzLitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblKursunsuzLitre.Name = "LblKursunsuzLitre";
            this.LblKursunsuzLitre.Size = new System.Drawing.Size(42, 18);
            this.LblKursunsuzLitre.TabIndex = 10;
            this.LblKursunsuzLitre.Text = "0,00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(50, 18);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 18);
            this.label13.TabIndex = 11;
            this.label13.Text = "Depo Petrol Miktarı";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(7, 131);
            this.progressBar4.Maximum = 10000;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(227, 23);
            this.progressBar4.TabIndex = 3;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(7, 102);
            this.progressBar3.Maximum = 10000;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(227, 23);
            this.progressBar3.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(7, 73);
            this.progressBar2.Maximum = 10000;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(227, 23);
            this.progressBar2.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 45);
            this.progressBar1.Maximum = 10000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(227, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Lblkasa);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Location = new System.Drawing.Point(510, 280);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 65);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Benzinlik Kasa Toplamı";
            // 
            // Lblkasa
            // 
            this.Lblkasa.AutoSize = true;
            this.Lblkasa.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblkasa.Location = new System.Drawing.Point(50, 25);
            this.Lblkasa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lblkasa.Name = "Lblkasa";
            this.Lblkasa.Size = new System.Drawing.Size(42, 18);
            this.Lblkasa.TabIndex = 11;
            this.Lblkasa.Text = "0,00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(7, 25);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 18);
            this.label18.TabIndex = 10;
            this.label18.Text = "Kasa:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(7, 43);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(109, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(7, 76);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(109, 20);
            this.numericUpDown2.TabIndex = 19;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(7, 109);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(109, 20);
            this.numericUpDown3.TabIndex = 20;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(7, 134);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(109, 20);
            this.numericUpDown4.TabIndex = 21;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnSatinAl);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.TxtAlisTutar);
            this.groupBox5.Controls.Add(this.TxtAlınacakMiktar);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.cmbAlisTur);
            this.groupBox5.Location = new System.Drawing.Point(13, 185);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(246, 160);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Satın Al";
            // 
            // cmbAlisTur
            // 
            this.cmbAlisTur.FormattingEnabled = true;
            this.cmbAlisTur.Items.AddRange(new object[] {
            "Kurşunsuz 95",
            "V/Max Diesel",
            "Gazyağı",
            "PO/gaz Otogaz"});
            this.cmbAlisTur.Location = new System.Drawing.Point(118, 48);
            this.cmbAlisTur.Name = "cmbAlisTur";
            this.cmbAlisTur.Size = new System.Drawing.Size(121, 22);
            this.cmbAlisTur.TabIndex = 0;
            this.cmbAlisTur.SelectedIndexChanged += new System.EventHandler(this.cmbAlisTur_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alınacak Miktar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Benzin Türü";
            // 
            // TxtAlınacakMiktar
            // 
            this.TxtAlınacakMiktar.Location = new System.Drawing.Point(8, 50);
            this.TxtAlınacakMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAlınacakMiktar.Name = "TxtAlınacakMiktar";
            this.TxtAlınacakMiktar.Size = new System.Drawing.Size(100, 20);
            this.TxtAlınacakMiktar.TabIndex = 22;
            this.TxtAlınacakMiktar.TextChanged += new System.EventHandler(this.TxtAlınacakMiktar_TextChanged);
            // 
            // TxtAlisTutar
            // 
            this.TxtAlisTutar.Location = new System.Drawing.Point(10, 95);
            this.TxtAlisTutar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAlisTutar.Name = "TxtAlisTutar";
            this.TxtAlisTutar.Size = new System.Drawing.Size(100, 20);
            this.TxtAlisTutar.TabIndex = 23;
            this.TxtAlisTutar.TextChanged += new System.EventHandler(this.TxtAlisTutar_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 14);
            this.label7.TabIndex = 24;
            this.label7.Text = "Alış Tutar";
            // 
            // BtnSatinAl
            // 
            this.BtnSatinAl.Location = new System.Drawing.Point(118, 92);
            this.BtnSatinAl.Name = "BtnSatinAl";
            this.BtnSatinAl.Size = new System.Drawing.Size(121, 23);
            this.BtnSatinAl.TabIndex = 25;
            this.BtnSatinAl.Text = "Satın Al";
            this.BtnSatinAl.UseVisualStyleBackColor = true;
            this.BtnSatinAl.Click += new System.EventHandler(this.BtnSatinAl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(20, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Petrol Station";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(850, 358);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senzin Benzinlikleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label LblOtogaz;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblGazyagi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblDiesel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblKursunsuz;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnDepoDoldur;
        private System.Windows.Forms.TextBox TxtOtogazFiyat;
        private System.Windows.Forms.TextBox TxtGazyagıFiyat;
        private System.Windows.Forms.TextBox TxtDieselFİyat;
        private System.Windows.Forms.TextBox TxtKursunsuzFiyat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtPlaka;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label LblOtogazLitre;
        private System.Windows.Forms.Label LblGazLitre;
        private System.Windows.Forms.Label LblDiesselLitre;
        private System.Windows.Forms.Label LblKursunsuzLitre;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Lblkasa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAlisTur;
        private System.Windows.Forms.Button BtnSatinAl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtAlisTutar;
        private System.Windows.Forms.TextBox TxtAlınacakMiktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

