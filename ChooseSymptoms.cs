using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProLab3
{
    public partial class ChooseSymptoms : Form
    {
        // Belirti tanımları ve açıklamaları
        private readonly Dictionary<string, string> belirtiAciklamalari = new Dictionary<string, string>
        {
            { "Poliüri", "Sık idrara çıkma" },
            { "Polifaji", "Aşırı açlık hissi" },
            { "Polidipsi", "Aşırı susama hissi" },
            { "Nöropati", "El ve ayaklarda karıncalanma veya uyuşma hissi" },
            { "Kilo kaybı", "İstemsiz kilo kaybı yaşanması" },
            { "Yorgunluk", "Sürekli yorgunluk ve halsizlik hissi" },
            { "Yaraların yavaş iyileşmesi", "Kesik ve yaraların normalden uzun sürede iyileşmesi" },
            { "Bulanık görme", "Net görememe ve görüş bulanıklığı" }
        };

        // UI elemanlarını global olarak tanımlayalım ki erişim kolaylaşsın
        private ListBox secilenBelirtilerListBox;
        private Panel mainPanel;
        private GroupBox belirtilerGroupBox;
        private GroupBox secilenBelirtilerGroupBox;

        public ChooseSymptoms()
        {
            InitializeComponent();

            // Form temel özellikleri
            this.Text = "Hasta Belirti Seçimi";
            this.Size = new Size(700, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(600, 500);

            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Üst başlık paneli
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.FromArgb(41, 128, 185)
            };

            Label headerLabel = new Label
            {
                Text = "Hasta Belirti Seçimi",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            headerPanel.Controls.Add(headerLabel);
            this.Controls.Add(headerPanel);

            // Alt bilgi paneli
            Panel infoPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 40,
                BackColor = Color.FromArgb(236, 240, 241)
            };

            Label infoLabel = new Label
            {
                Text = "Lütfen hastanın sahip olduğu belirtileri seçiniz",
                ForeColor = Color.FromArgb(52, 73, 94),
                Font = new Font("Segoe UI", 9F, FontStyle.Italic),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            infoPanel.Controls.Add(infoLabel);
            this.Controls.Add(infoPanel);

            // Ana panel - TableLayoutPanel kullanarak daha iyi hizalama sağlayalım
            mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(15)
            };

            // TableLayoutPanel oluşturalım - iki bölümlü bir düzen
            TableLayoutPanel tableLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 2,
                Padding = new Padding(10),
                RowStyles = {
                    new RowStyle(SizeType.Percent, 60),
                    new RowStyle(SizeType.Percent, 40)
                }
            };

            // Belirtiler grubu - CheckBox'ları doğrudan göstermek için ListView kullanacağız
            belirtilerGroupBox = new GroupBox
            {
                Text = "Belirtiler",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                Padding = new Padding(10)
            };

            // CheckBox'ları doğrudan panel içine yerleştirelim
            Panel belirtiPanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(5)
            };

            // Belirtileri ekleyelim - artık doğrudan CheckBox olarak
            int yPos = 10;
            int index = 0;
            foreach (var belirti in belirtiAciklamalari)
            {
                CheckBox belirtiCheckBox = new CheckBox
                {
                    Text = $"{belirti.Key} ({belirti.Value})",
                    Tag = belirti.Key,
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                    Location = new Point(20, yPos),
                    Width = belirtilerGroupBox.Width - 50,
                    Height = 30,
                    ForeColor = Color.FromArgb(44, 62, 80),
                    BackColor = index % 2 == 0 ? Color.FromArgb(240, 243, 244) : Color.FromArgb(236, 240, 241)
                };

                belirtiCheckBox.CheckedChanged += BelirtiCheckBox_CheckedChanged;
                belirtiPanel.Controls.Add(belirtiCheckBox);
                yPos += 35; // Her checkbox arasında boşluk bırakalım
                index++;
            }

            belirtilerGroupBox.Controls.Add(belirtiPanel);
            tableLayout.Controls.Add(belirtilerGroupBox, 0, 0);

            // Seçilen belirtiler liste kutusu
            secilenBelirtilerGroupBox = new GroupBox
            {
                Text = "Seçilen Belirtiler",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                Padding = new Padding(10)
            };

            secilenBelirtilerListBox = new ListBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                BackColor = Color.FromArgb(253, 254, 254),
                BorderStyle = BorderStyle.None,
                Name = "secilenBelirtilerListBox"
            };

            secilenBelirtilerGroupBox.Controls.Add(secilenBelirtilerListBox);
            tableLayout.Controls.Add(secilenBelirtilerGroupBox, 0, 1);

            mainPanel.Controls.Add(tableLayout);

            // Buton paneli
            Panel buttonPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 60,
                Padding = new Padding(0, 10, 0, 10)
            };

            Button tamamlaButton = new Button
            {
                Text = "Belirti Seçimlerini Tamamla",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                BackColor = Color.FromArgb(46, 204, 113),
                ForeColor = Color.White,
                Size = new Size(250, 40),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            tamamlaButton.FlatAppearance.BorderSize = 0;

            // Butonu panel içinde merkezleyelim
            tamamlaButton.Anchor = AnchorStyles.None;
            buttonPanel.Resize += (s, e) => {
                tamamlaButton.Left = (buttonPanel.Width - tamamlaButton.Width) / 2;
                tamamlaButton.Top = (buttonPanel.Height - tamamlaButton.Height) / 2;
            };

            tamamlaButton.Click += TamamlaButton_Click;

            buttonPanel.Controls.Add(tamamlaButton);
            this.Controls.Add(buttonPanel);
            this.Controls.Add(mainPanel);

            // Form yüklendiğinde boyutları ayarlayalım
            this.Load += (s, e) => {
                // Panel içindeki CheckBox'ların genişliğini ayarla
                foreach (Control c in belirtiPanel.Controls)
                {
                    if (c is CheckBox)
                    {
                        c.Width = belirtiPanel.Width - 40;
                    }
                }
            };

            // Form boyutu değiştiğinde kontrolleri yeniden boyutlandır
            this.Resize += (s, e) => {
                // Panel içindeki CheckBox'ların genişliğini ayarla
                foreach (Control c in belirtiPanel.Controls)
                {
                    if (c is CheckBox)
                    {
                        c.Width = belirtiPanel.Width - 40;
                    }
                }
            };
        }

        private void BelirtiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                string belirti = checkBox.Tag.ToString();

                if (checkBox.Checked)
                {
                    // Belirti listede yoksa ekleyelim
                    if (!PatientInfo.PatientSymptoms.Contains(belirti))
                    {
                        PatientInfo.PatientSymptoms.Add(belirti);
                        secilenBelirtilerListBox.Items.Add($"{belirti} - {belirtiAciklamalari[belirti]}");
                    }
                }
                else
                {
                    // Belirti listede varsa çıkaralım
                    if (PatientInfo.PatientSymptoms.Contains(belirti))
                    {
                        PatientInfo.PatientSymptoms.Remove(belirti);
                        for (int i = 0; i < secilenBelirtilerListBox.Items.Count; i++)
                        {
                            string item = secilenBelirtilerListBox.Items[i].ToString();
                            if (item.StartsWith(belirti))
                            {
                                secilenBelirtilerListBox.Items.RemoveAt(i);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void TamamlaButton_Click(object sender, EventArgs e)
        {
            if (PatientInfo.PatientSymptoms.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir belirti seçiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen belirtileri başka bir forma aktaralım ve o formu açalım
            // SonucFormu sonucForm = new SonucFormu(secilenBelirtiler);
            this.Hide();
            // sonucForm.ShowDialog();
            // this.Close();
        }
    }
}