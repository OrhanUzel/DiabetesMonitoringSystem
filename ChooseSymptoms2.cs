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
    public partial class ChooseSymptoms2 : Form
    {
       
        // Seçilen belirtileri tutacak liste
        private List<string> secilenBelirtiler = new List<string>();

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

        public ChooseSymptoms2()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }


        private void InitializeCustomComponents()
        {

            // Üst başlık paneli
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 80,
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

            // Ana panel
            Panel mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20)
            };

            // Belirtiler grubu
            GroupBox belirtilerGroupBox = new GroupBox
            {
                Text = "Belirtiler",
                Dock = DockStyle.Top,
                Height = 380,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                Padding = new Padding(15)
            };

            FlowLayoutPanel belirtiFlowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true
            };

            // Belirtileri ekleyelim
            int index = 0;
            foreach (var belirti in belirtiAciklamalari)
            {
                Panel belirtiPanel = new Panel
                {
                    Width = belirtilerGroupBox.Width - 50,
                    Height = 40,
                    Margin = new Padding(0, 5, 0, 5),
                    BackColor = index % 2 == 0 ? Color.FromArgb(240, 243, 244) : Color.FromArgb(236, 240, 241)
                };

                CheckBox belirtiCheckBox = new CheckBox
                {
                    Text = $"{belirti.Key} ({belirti.Value})",
                    Tag = belirti.Key,
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                    Location = new Point(10, 10),
                    Width = belirtiPanel.Width - 20,
                    ForeColor = Color.FromArgb(44, 62, 80)
                    
                };

                belirtiCheckBox.CheckedChanged += BelirtiCheckBox_CheckedChanged;
                belirtiPanel.Controls.Add(belirtiCheckBox);
                belirtiFlowPanel.Controls.Add(belirtiPanel);
                index++;
            }

            belirtilerGroupBox.Controls.Add(belirtiFlowPanel);
            mainPanel.Controls.Add(belirtilerGroupBox);

            // Seçilen belirtiler liste kutusu
            GroupBox secilenBelirtilerGroupBox = new GroupBox
            {
                Text = "Seçilen Belirtiler",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                Padding = new Padding(15)
            };

            ListBox secilenBelirtilerListBox = new ListBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                BackColor = Color.FromArgb(253, 254, 254),
                BorderStyle = BorderStyle.None,
                Name = "secilenBelirtilerListBox"
            };

            secilenBelirtilerGroupBox.Controls.Add(secilenBelirtilerListBox);
            mainPanel.Controls.Add(secilenBelirtilerGroupBox);

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

            tamamlaButton.Location = new Point((buttonPanel.Width - tamamlaButton.Width) / 2, 10);
            tamamlaButton.Anchor = AnchorStyles.None;
            tamamlaButton.Click += TamamlaButton_Click;

            buttonPanel.Controls.Add(tamamlaButton);
            mainPanel.Controls.Add(buttonPanel);

            this.Controls.Add(mainPanel);
        }

        private void BelirtiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                string belirti = checkBox.Tag.ToString();
                ListBox secilenListBox = this.Controls.Find("secilenBelirtilerListBox", true).FirstOrDefault() as ListBox;

                if (checkBox.Checked)
                {
                    // Belirti listede yoksa ekleyelim
                    if (!PatientInfo.PatientSymptoms.Contains(belirti))
                    {
                        PatientInfo.PatientSymptoms.Add(belirti);
                        if (secilenListBox != null)
                        {
                            secilenListBox.Items.Add($"{belirti} - {belirtiAciklamalari[belirti]}");
                        }
                    }
                }
                else
                {
                    // Belirti listede varsa çıkaralım
                    if (PatientInfo.PatientSymptoms.Contains(belirti))
                    {
                        PatientInfo.PatientSymptoms.Remove(belirti);
                        if (secilenListBox != null)
                        {
                            for (int i = 0; i < secilenListBox.Items.Count; i++)
                            {
                                string item = secilenListBox.Items[i].ToString();
                                if (item.StartsWith(belirti))
                                {
                                    secilenListBox.Items.RemoveAt(i);
                                    break;
                                }
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
            //this.Close();
        }
    }
}
