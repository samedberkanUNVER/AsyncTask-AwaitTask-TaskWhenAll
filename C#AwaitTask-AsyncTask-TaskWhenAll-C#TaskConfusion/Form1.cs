using System.Diagnostics;

namespace C_AwaitTask_AsyncTask_TaskWhenAll_C_TaskConfusion
{
    public partial class frmMain : Form
    {
        private readonly System.Windows.Forms.Timer timer;
        public frmMain()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Tick += (sender, e) =>
            {
                lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
            };
            timer.Interval = 1000;
            timer.Start();
        }

        private void btnStartCookingSync_Click(object sender, EventArgs e)
        {
            PrepareScreenForStarting();

            var sw = Stopwatch.StartNew();


            YumurtalariKir();
            YumurtalariCirp();
            TuzEkle();
            OcagiAc();
            TavayiIsit();
            YagEkle();
            YumurtalariDok();
            YumurtalariPisir();
            YemegiServisYap();



            sw.Stop();
            AddLog($"Toplam Yemek Piþirme Süresi {sw.ElapsedMilliseconds:0} ms");


        }

        private void PrepareScreenForStarting()
        {
            lbLogs.Text = string.Empty;
            AdjustButtongs(1, true);


        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void AddLog(string log)
        {
            if (lbLogs.InvokeRequired)
            {
                lbLogs.Invoke(new Action(()=>{
                    AddLog(log);
                })); 
            }

            lbLogs.Items.Add(log);
        }

        #region Sync Methods
        public void YumurtalariKir()
        {
            Task.Delay(500).Wait();
            AddLog("Yumurtalarý kýrdým");
            AdjustButtongs(1);
        }
        public void YumurtalariCirp()
        {
            Task.Delay(500).Wait();
            AddLog("Yumurtalarý çýrptým");
            AdjustButtongs(2);
        }
        public void TuzEkle()
        {
            Task.Delay(500).Wait();
            AddLog("Tuz Ekledim");
            AdjustButtongs(3);
        }
        public void OcagiAc()
        {
            Task.Delay(500).Wait();
            AddLog("Ocaðý açtým");
            AdjustButtongs(4);
        }
        public void TavayiIsit()
        {
            Task.Delay(500).Wait();
            AddLog("Tavayý Isýttým");
            AdjustButtongs(5);
        }
        public void YagEkle()
        {
            Task.Delay(500).Wait();
            AddLog("Yað ekledim");
            AdjustButtongs(6);
        }
        public void YumurtalariDok()
        {
            Task.Delay(500).Wait();
            AddLog("Yumurtalarý döktüm");
            AdjustButtongs(7);
        }
        public void YumurtalariPisir()
        {
            Task.Delay(500).Wait();
            AddLog("Yumurtalarý piþirdim");
            AdjustButtongs(8);
        }
        public void YemegiServisYap()
        {
            Task.Delay(500).Wait();
            AddLog("Yemeði servis yaptým");
            AdjustButtongs(9);
        }
        #endregion
        #region Async Methods

        public async Task YumurtalariKirAsync()
        {
            await Task.Delay(500);
            AddLog("Yumurtalarý kýrdým");
            AdjustButtongs(1);
        }
        public async Task YumurtalariCirpAsync()
        {
            await Task.Delay(500);
            AddLog("Yumurtalarý çýrptým");
            AdjustButtongs(2);
        }
        public async Task TuzEkleAsync()
        {
            await Task.Delay(500);
            AddLog("Tuz Ekledim");
            AdjustButtongs(3);
        }
        public async Task OcagiAcAsync()
        {
            await Task.Delay(500);
            AddLog("Ocaðý açtým");
            AdjustButtongs(4);
        }
        public async Task TavayiIsitAsync()
        {
            await Task.Delay(500);
            AddLog("Tavayý Isýttým");
            AdjustButtongs(5);
        }
        public async Task YagEkleAsync()
        {
            await Task.Delay(500);
            AddLog("Yað ekledim");
            AdjustButtongs(6);
        }
        public async Task YumurtalariDokAsync()
        {
            await Task.Delay(500);
            AddLog("Yumurtalarý döktüm");
            AdjustButtongs(7);
        }
        public async Task YumurtalariPisirAsync()
        {
            await Task.Delay(500);
            AddLog("Yumurtalarý piþirdim");
            AdjustButtongs(8);
        }
        public async Task YemegiServisYapAsync()
        {
            await Task.Delay(500);
            AddLog("Yemeði servis yaptým");
            AdjustButtongs(9);
        }

        #endregion

        private void AdjustButtongs(int v, bool forceClean = false)
        {
            Button? btn = this.Controls.Find($"btnYumurtalariKir", true).FirstOrDefault() as Button;
            Button? btn2 = this.Controls.Find($"btnYumurtalariCirp", true).FirstOrDefault() as Button;
            Button? btn3 = this.Controls.Find($"btnTuzEkle", true).FirstOrDefault() as Button;
            Button? btn4 = this.Controls.Find($"btnOcagiAc", true).FirstOrDefault() as Button;
            Button? btn5 = this.Controls.Find($"btnTavayiIsit", true).FirstOrDefault() as Button;
            Button? btn6 = this.Controls.Find($"btnYagEkle", true).FirstOrDefault() as Button;
            Button? btn7 = this.Controls.Find($"btnYumurtalariDok", true).FirstOrDefault() as Button;
            Button? btn8 = this.Controls.Find($"btnYumurtalariPisir", true).FirstOrDefault() as Button;
            Button? btn9 = this.Controls.Find($"btnYemegiServisYap", true).FirstOrDefault() as Button;

            if (forceClean)
            {
                btn.BackColor = Color.White;
                btn2.BackColor = Color.White;
                btn3.BackColor = Color.White;
                btn4.BackColor = Color.White;
                btn5.BackColor = Color.White;
                btn6.BackColor = Color.White;
                btn7.BackColor = Color.White;
                btn8.BackColor = Color.White;
                btn9.BackColor = Color.White;

            }
            else
            {
                if (v == 1)
                {
                    btn.BackColor = Color.Green;
                }
                if (v == 2)
                {
                    btn2.BackColor = Color.Green;
                }
                if (v == 3)
                {
                    btn3.BackColor = Color.Green;
                }
                if (v == 4)
                {
                    btn4.BackColor = Color.Green;
                }
                if (v == 5)
                {
                    btn5.BackColor = Color.Green;
                }
                if (v == 6)
                {
                    btn6.BackColor = Color.Green;
                }
                if (v == 7)
                {
                    btn7.BackColor = Color.Green;
                }
                if (v == 8)
                {
                    btn8.BackColor = Color.Green;
                }
                if (v == 9)
                {
                    btn9.BackColor = Color.Green;
                }
            }




        }

        private async void btnStartAsyncCooking_Click(object sender, EventArgs e)
        {
            PrepareScreenForStarting();

            var sw = Stopwatch.StartNew();

            var yumurtaTaskGroup = async () =>
            {
                await YumurtalariKirAsync();
                await YumurtalariCirpAsync();
                await TuzEkleAsync();
            };

            var ocakTaskGroup = async () =>
            {
                await OcagiAcAsync();
                await TavayiIsitAsync();
                await YagEkleAsync();
            };

            await Task.WhenAll(yumurtaTaskGroup(), ocakTaskGroup());


            await YumurtalariDokAsync();
            await YumurtalariPisirAsync();
            await YemegiServisYapAsync();



            sw.Stop();
            AddLog($"Toplam Yemek Piþirme Süresi {sw.ElapsedMilliseconds:0} ms");
        }
    }
}
