using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProLab3
{
    public partial class ChooseSymptoms : Form
    {
        public ChooseSymptoms()
        {
            InitializeComponent();
        }

        private void ChooseSymptoms_Load(object sender, EventArgs e)
        {
            BelirtileriOlustur();

        }
        private void BelirtileriOlustur()
        {
            string[] belirtiler = {
        "Poliüri (Sık idrara çıkma)",
        "Polifaji (Aşırı açlık hissi)",
        "Polidipsi (Aşırı susama hissi)",
        "Nöropati (Uyuşma)",
        "Kilo kaybı",
        "Yorgunluk",
        "Yavaş iyileşen yaralar",
        "Bulanık görme"
    };

            // Semptom açıklamaları - her semptom için daha detaylı bilgi
            string[] aciklamalar = {
        "Günde 3 litreden fazla idrar çıkışı. Gece idrara kalkma sıklığında artış.",
        "Normal beslenmeye rağmen sürekli açlık hissi. Yemek sonrası hızlı acıkma.",
        "Aşırı su içme isteği. Günde 3 litreden fazla sıvı tüketimi.",
        "Ellerde ve ayaklarda uyuşma, karıncalanma veya yanma hissi.",
        "Beslenme alışkanlığı değişmeden açıklanamayan kilo kaybı.",
        "Günlük aktiviteleri gerçekleştiremeyecek kadar güçsüzlük ve yorgunluk.",
        "Küçük kesikler veya sıyrıkların normalden uzun sürede iyileşmesi.",
        "Görmede geçici bulanıklık, özellikle kan şekeri seviyesi yükseldiğinde."
    };

            // Bilimsel risk derecelendirmesi (1-5 arası)
            int[] riskDereceleri = { 5, 4, 5, 3, 4, 3, 4, 3 };

            // FlowLayout'u temizle ve ayarla
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Padding = new Padding(15, 15, 15, 15);
            flowLayoutPanel1.BackColor = Color.FromArgb(245, 247, 250); // Hafif mavi-gri arka plan

            // Panel üstünde başlık oluştur
            Label baslik = new Label();
            baslik.Text = "Diyabet Belirtileri Değerlendirme";
            baslik.Font = new Font("Segoe UI Semibold", 16, FontStyle.Bold);
            baslik.ForeColor = Color.FromArgb(41, 79, 125); // Koyu mavi
            baslik.AutoSize = true;
            baslik.Dock = DockStyle.Top;
            baslik.TextAlign = ContentAlignment.MiddleCenter;
            baslik.Padding = new Padding(0, 0, 0, 15);
            baslik.Width = flowLayoutPanel1.Width;
            flowLayoutPanel1.Controls.Add(baslik);

            // Açıklama etiketi
            Label aciklama = new Label();
            aciklama.Text = "Lütfen hastada gözlemlediğiniz belirtileri işaretleyin. Her belirti, diyabet tanısı olasılığını farklı oranlarda etkileyebilir.";
            aciklama.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            aciklama.ForeColor = Color.FromArgb(70, 70, 70);
            aciklama.AutoSize = false;
            aciklama.Width = flowLayoutPanel1.Width - 30;
            aciklama.Height = 50;
            aciklama.Padding = new Padding(5, 5, 5, 15);
            flowLayoutPanel1.Controls.Add(aciklama);

            // Gradient panel için kullanılacak renkler
            Color[] renkler = {
        Color.FromArgb(235, 242, 252), // Açık mavi
        Color.FromArgb(232, 245, 233), // Açık yeşil
        Color.FromArgb(248, 237, 235)  // Açık somon
    };

            for (int i = 0; i < belirtiler.Length; i++)
            {
                // Her belirti için bir panel oluştur
                Panel belirtiPanel = new Panel();
                belirtiPanel.Width = flowLayoutPanel1.Width - 35;
                belirtiPanel.Height = 95;
                belirtiPanel.Margin = new Padding(0, 0, 0, 12);
                belirtiPanel.BackColor = renkler[i % renkler.Length];
                belirtiPanel.BorderStyle = BorderStyle.None;

                // Kenarları yuvarla
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddArc(0, 0, 20, 20, 180, 90);
                path.AddArc(belirtiPanel.Width - 20, 0, 20, 20, 270, 90);
                path.AddArc(belirtiPanel.Width - 20, belirtiPanel.Height - 20, 20, 20, 0, 90);
                path.AddArc(0, belirtiPanel.Height - 20, 20, 20, 90, 90);
                path.CloseAllFigures();
                belirtiPanel.Region = new Region(path);

                // Checkbox oluştur
                CheckBox chk = new CheckBox();
                chk.Text = belirtiler[i];
                chk.Name = "chkBeliriti_" + i;
                chk.AutoSize = false;
                chk.Width = belirtiPanel.Width - 110; // Risk göstergesi için alan bırak
                chk.Height = 30;
                chk.Location = new Point(15, 12);
                chk.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
                chk.ForeColor = Color.FromArgb(47, 79, 79); // Koyu turkuaz
                chk.BackColor = Color.Transparent;
                chk.Cursor = Cursors.Hand;

                chk.FlatStyle = FlatStyle.Flat;
                chk.FlatAppearance.BorderSize = 0;
                chk.FlatAppearance.CheckedBackColor = Color.Transparent;

                // Açıklama etiketi
                Label lblAciklama = new Label();
                lblAciklama.Text = aciklamalar[i];
                lblAciklama.Font = new Font("Segoe UI", 9, FontStyle.Italic);
                lblAciklama.ForeColor = Color.FromArgb(90, 90, 90);
                lblAciklama.AutoSize = false;
                lblAciklama.Width = belirtiPanel.Width - 140;
                lblAciklama.Height = 40;
                lblAciklama.Location = new Point(35, 45);
                lblAciklama.BackColor = Color.Transparent;

                // Risk seviyesi göstergesi
                Panel riskPanel = new Panel();
                riskPanel.Width = 80;
                riskPanel.Height = 25;
                riskPanel.Location = new Point(belirtiPanel.Width - 100, 15);
                riskPanel.BackColor = Color.Transparent;

                // Risk seviyesi etiketi
                Label lblRisk = new Label();
                lblRisk.Text = "Risk: " + riskDereceleri[i] + "/5";
                lblRisk.AutoSize = false;
                lblRisk.Width = 75;
                lblRisk.Height = 20;
                lblRisk.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                lblRisk.TextAlign = ContentAlignment.MiddleCenter;
                lblRisk.Location = new Point(0, 0);

                // Risk seviyesine göre renk belirleme
                Color riskRenk;
                switch (riskDereceleri[i])
                {
                    case 5:
                        riskRenk = Color.FromArgb(179, 0, 0); // Koyu kırmızı
                        break;
                    case 4:
                        riskRenk = Color.FromArgb(227, 66, 52); // Açık kırmızı
                        break;
                    case 3:
                        riskRenk = Color.FromArgb(240, 134, 0); // Turuncu
                        break;
                    default:
                        riskRenk = Color.FromArgb(51, 105, 30); // Yeşil
                        break;
                }
                lblRisk.ForeColor = riskRenk;
                riskPanel.Controls.Add(lblRisk);

                // Risk çubuğu göstergesi
                Panel riskBar = new Panel();
                riskBar.Width = 70;
                riskBar.Height = 4;
                riskBar.Location = new Point(5, 20);
                riskBar.BackColor = Color.FromArgb(220, 220, 220);

                Panel riskBarFill = new Panel();
                riskBarFill.Width = (int)(70 * (riskDereceleri[i] / 5.0));
                riskBarFill.Height = 4;
                riskBarFill.Location = new Point(0, 0);
                riskBarFill.BackColor = riskRenk;

                riskBar.Controls.Add(riskBarFill);
                riskPanel.Controls.Add(riskBar);

                //// Olay işleyicileri
                //belirtiPanel.MouseEnter += (s, e) => {
                //    belirtiPanel.BackColor = Color.FromArgb(
                //        Math.Max(belirtiPanel.BackColor.R - 15, 0),
                //        Math.Max(belirtiPanel.BackColor.G - 15, 0),
                //        Math.Max(belirtiPanel.BackColor.B - 15, 0)
                //    );
                //};

                //belirtiPanel.MouseLeave += (s, e) => {
                //    belirtiPanel.BackColor = renkler[Array.IndexOf(belirtiler, chk.Text) % renkler.Length];
                //};

                // Bileşenleri panel'e ekle
                belirtiPanel.Controls.Add(chk);
                belirtiPanel.Controls.Add(lblAciklama);
                belirtiPanel.Controls.Add(riskPanel);

                // Panel'i flowLayoutPanel'e ekle
                flowLayoutPanel1.Controls.Add(belirtiPanel);
            }

            // Alt bilgi paneli
            Panel altBilgiPanel = new Panel();
            altBilgiPanel.Width = flowLayoutPanel1.Width - 35;
            altBilgiPanel.Height = 80;
            altBilgiPanel.Margin = new Padding(0, 10, 0, 0);
            altBilgiPanel.BackColor = Color.FromArgb(41, 79, 125); // Koyu mavi
            altBilgiPanel.ForeColor = Color.White;

            // Kenarları yuvarla
            System.Drawing.Drawing2D.GraphicsPath altPath = new System.Drawing.Drawing2D.GraphicsPath();
            altPath.AddArc(0, 0, 20, 20, 180, 90);
            altPath.AddArc(altBilgiPanel.Width - 20, 0, 20, 20, 270, 90);
            altPath.AddArc(altBilgiPanel.Width - 20, altBilgiPanel.Height - 20, 20, 20, 0, 90);
            altPath.AddArc(0, altBilgiPanel.Height - 20, 20, 20, 90, 90);
            altPath.CloseAllFigures();
            altBilgiPanel.Region = new Region(altPath);

            Label altBilgi = new Label();
            altBilgi.Text = "Not: Bu değerlendirme kesin teşhis amaçlı değildir. Mutlaka bir sağlık uzmanına danışınız.";
            altBilgi.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            altBilgi.AutoSize = false;
            altBilgi.Width = altBilgiPanel.Width - 30;
            altBilgi.Height = 60;
            altBilgi.TextAlign = ContentAlignment.MiddleCenter;
            altBilgi.Location = new Point(15, 10);

            altBilgiPanel.Controls.Add(altBilgi);
            flowLayoutPanel1.Controls.Add(altBilgiPanel);

            // Değerlendir butonu ekle
            Button btnDegerlendir = new Button();
            btnDegerlendir.Text = "Belirtileri Değerlendir";
            btnDegerlendir.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnDegerlendir.ForeColor = Color.White;
            btnDegerlendir.BackColor = Color.FromArgb(46, 125, 50); // Yeşil
            btnDegerlendir.Width = 200;
            btnDegerlendir.Height = 45;
            btnDegerlendir.FlatStyle = FlatStyle.Flat;
            btnDegerlendir.FlatAppearance.BorderSize = 0;
            btnDegerlendir.Margin = new Padding((flowLayoutPanel1.Width - 235) / 2, 15, 0, 10);
            btnDegerlendir.Cursor = Cursors.Hand;

            // Buton kenarlarını yuvarla
            System.Drawing.Drawing2D.GraphicsPath btnPath = new System.Drawing.Drawing2D.GraphicsPath();
            btnPath.AddArc(0, 0, 10, 10, 180, 90);
            btnPath.AddArc(btnDegerlendir.Width - 10, 0, 10, 10, 270, 90);
            btnPath.AddArc(btnDegerlendir.Width - 10, btnDegerlendir.Height - 10, 10, 10, 0, 90);
            btnPath.AddArc(0, btnDegerlendir.Height - 10, 10, 10, 90, 90);
            btnPath.CloseAllFigures();
            btnDegerlendir.Region = new Region(btnPath);

            // Buton olayları
            btnDegerlendir.MouseEnter += (s, e) => {
                btnDegerlendir.BackColor = Color.FromArgb(30, 100, 40);
            };

            btnDegerlendir.MouseLeave += (s, e) => {
                btnDegerlendir.BackColor = Color.FromArgb(46, 125, 50);
            };

            btnDegerlendir.Click += (s, e) => {
                // İşaretli belirtileri say
                int isaretliSayisi = flowLayoutPanel1.Controls.OfType<Panel>()
                    .SelectMany(p => p.Controls.OfType<CheckBox>())
                    .Count(c => c.Checked);

                // Risk puanını hesapla
                int riskPuani = 0;
                for (int j = 0; j < belirtiler.Length; j++)
                {
                    CheckBox chk = flowLayoutPanel1.Controls.OfType<Panel>()
                        .SelectMany(p => p.Controls.OfType<CheckBox>())
                        .FirstOrDefault(c => c.Text == belirtiler[j]);

                    if (chk != null && chk.Checked)
                    {
                        riskPuani += riskDereceleri[j];
                    }
                }

                // Sonuç mesajı
                string riskSeviyesi = "";
                if (riskPuani >= 12) riskSeviyesi = "YÜKSEK";
                else if (riskPuani >= 6) riskSeviyesi = "ORTA";
                else riskSeviyesi = "DÜŞÜK";

                MessageBox.Show(
                    $"Toplam {isaretliSayisi} belirti işaretlediniz.\nHesaplanan risk puanı: {riskPuani}\nRisk seviyesi: {riskSeviyesi}\n\nBu sonuç yalnızca bilgilendirme amaçlıdır. Kesin teşhis için doktora başvurunuz.",
                    "Değerlendirme Sonucu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            };

            flowLayoutPanel1.Controls.Add(btnDegerlendir);
        }


        private void ChooseSymptoms_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
