namespace C_AwaitTask_AsyncTask_TaskWhenAll_C_TaskConfusion
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            btnStartCookingSync = new Button();
            lbLogs = new ListBox();
            btnYumurtalariKir = new Button();
            btnYumurtalariCirp = new Button();
            btnTuzEkle = new Button();
            btnOcagiAc = new Button();
            btnTavayiIsit = new Button();
            btnYagEkle = new Button();
            btnYumurtalariDok = new Button();
            btnYumurtalariPisir = new Button();
            btnYemegiServisYap = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            btnStartAsyncCooking = new Button();
            SuspendLayout();
            // 
            // btnStartCookingSync
            // 
            btnStartCookingSync.Location = new Point(12, 12);
            btnStartCookingSync.Name = "btnStartCookingSync";
            btnStartCookingSync.Size = new Size(436, 82);
            btnStartCookingSync.TabIndex = 0;
            btnStartCookingSync.Text = "Start Cooking Sync";
            btnStartCookingSync.UseVisualStyleBackColor = true;
            btnStartCookingSync.Click += btnStartCookingSync_Click;
            // 
            // lbLogs
            // 
            lbLogs.FormattingEnabled = true;
            lbLogs.ItemHeight = 15;
            lbLogs.Location = new Point(12, 277);
            lbLogs.Name = "lbLogs";
            lbLogs.Size = new Size(436, 154);
            lbLogs.TabIndex = 2;
            // 
            // btnYumurtalariKir
            // 
            btnYumurtalariKir.Location = new Point(454, 12);
            btnYumurtalariKir.Name = "btnYumurtalariKir";
            btnYumurtalariKir.Size = new Size(159, 38);
            btnYumurtalariKir.TabIndex = 3;
            btnYumurtalariKir.Text = "Yumurtaları Kır";
            btnYumurtalariKir.UseVisualStyleBackColor = true;
            // 
            // btnYumurtalariCirp
            // 
            btnYumurtalariCirp.Location = new Point(454, 56);
            btnYumurtalariCirp.Name = "btnYumurtalariCirp";
            btnYumurtalariCirp.Size = new Size(159, 38);
            btnYumurtalariCirp.TabIndex = 3;
            btnYumurtalariCirp.Text = "Yumurtaları Çırp";
            btnYumurtalariCirp.UseVisualStyleBackColor = true;
            // 
            // btnTuzEkle
            // 
            btnTuzEkle.Location = new Point(454, 100);
            btnTuzEkle.Name = "btnTuzEkle";
            btnTuzEkle.Size = new Size(159, 38);
            btnTuzEkle.TabIndex = 3;
            btnTuzEkle.Text = "Tuz Ekle";
            btnTuzEkle.UseVisualStyleBackColor = true;
            // 
            // btnOcagiAc
            // 
            btnOcagiAc.Location = new Point(454, 144);
            btnOcagiAc.Name = "btnOcagiAc";
            btnOcagiAc.Size = new Size(159, 38);
            btnOcagiAc.TabIndex = 3;
            btnOcagiAc.Text = "Ocağı Aç";
            btnOcagiAc.UseVisualStyleBackColor = true;
            // 
            // btnTavayiIsit
            // 
            btnTavayiIsit.Location = new Point(454, 188);
            btnTavayiIsit.Name = "btnTavayiIsit";
            btnTavayiIsit.Size = new Size(159, 38);
            btnTavayiIsit.TabIndex = 3;
            btnTavayiIsit.Text = "Tavayı Isıt";
            btnTavayiIsit.UseVisualStyleBackColor = true;
            // 
            // btnYagEkle
            // 
            btnYagEkle.Location = new Point(454, 232);
            btnYagEkle.Name = "btnYagEkle";
            btnYagEkle.Size = new Size(159, 38);
            btnYagEkle.TabIndex = 3;
            btnYagEkle.Text = "Yağı Dök";
            btnYagEkle.UseVisualStyleBackColor = true;
            // 
            // btnYumurtalariDok
            // 
            btnYumurtalariDok.Location = new Point(454, 276);
            btnYumurtalariDok.Name = "btnYumurtalariDok";
            btnYumurtalariDok.Size = new Size(159, 38);
            btnYumurtalariDok.TabIndex = 3;
            btnYumurtalariDok.Text = "Yumurtayı Ekle";
            btnYumurtalariDok.UseVisualStyleBackColor = true;
            // 
            // btnYumurtalariPisir
            // 
            btnYumurtalariPisir.Location = new Point(454, 320);
            btnYumurtalariPisir.Name = "btnYumurtalariPisir";
            btnYumurtalariPisir.Size = new Size(159, 38);
            btnYumurtalariPisir.TabIndex = 3;
            btnYumurtalariPisir.Text = "Pişir";
            btnYumurtalariPisir.UseVisualStyleBackColor = true;
            // 
            // btnYemegiServisYap
            // 
            btnYemegiServisYap.Location = new Point(454, 364);
            btnYemegiServisYap.Name = "btnYemegiServisYap";
            btnYemegiServisYap.Size = new Size(159, 38);
            btnYemegiServisYap.TabIndex = 3;
            btnYemegiServisYap.Text = "Servis Et";
            btnYemegiServisYap.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(454, 416);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(50, 15);
            lblTimer.TabIndex = 4;
            lblTimer.Text = "lblTimer";
            // 
            // btnStartAsyncCooking
            // 
            btnStartAsyncCooking.Location = new Point(12, 100);
            btnStartAsyncCooking.Name = "btnStartAsyncCooking";
            btnStartAsyncCooking.Size = new Size(436, 82);
            btnStartAsyncCooking.TabIndex = 5;
            btnStartAsyncCooking.Text = "Start Cooking Async";
            btnStartAsyncCooking.UseVisualStyleBackColor = true;
            btnStartAsyncCooking.Click += btnStartAsyncCooking_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 455);
            Controls.Add(btnStartAsyncCooking);
            Controls.Add(lblTimer);
            Controls.Add(btnYemegiServisYap);
            Controls.Add(btnYumurtalariPisir);
            Controls.Add(btnYumurtalariDok);
            Controls.Add(btnYagEkle);
            Controls.Add(btnTavayiIsit);
            Controls.Add(btnOcagiAc);
            Controls.Add(btnTuzEkle);
            Controls.Add(btnYumurtalariCirp);
            Controls.Add(btnYumurtalariKir);
            Controls.Add(lbLogs);
            Controls.Add(btnStartCookingSync);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task async/await";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartCookingSync;
        private ListBox lbLogs;
        private Button btnYumurtalariKir;
        private Button btnYumurtalariCirp;
        private Button btnTuzEkle;
        private Button btnOcagiAc;
        private Button btnTavayiIsit;
        private Button btnYagEkle;
        private Button btnYumurtalariDok;
        private Button btnYumurtalariPisir;
        private Button btnYemegiServisYap;
        private System.Windows.Forms.Timer timer1;
        private Label lblTimer;
        private Button btnStartAsyncCooking;
    }
}
