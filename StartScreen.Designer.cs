using System;

namespace ProLab3
{
    partial class StartScreen
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
            this.btnLogPat = new System.Windows.Forms.Button();
            this.btnLogDoc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogPat
            // 
            this.btnLogPat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogPat.Location = new System.Drawing.Point(421, 325);
            this.btnLogPat.Name = "btnLogPat";
            this.btnLogPat.Size = new System.Drawing.Size(257, 79);
            this.btnLogPat.TabIndex = 1;
            this.btnLogPat.Text = "Hasta Girişi";
            this.btnLogPat.UseVisualStyleBackColor = true;
            this.btnLogPat.Click += new System.EventHandler(this.btnLogPat_Click);
            // 
            // btnLogDoc
            // 
            this.btnLogDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogDoc.Location = new System.Drawing.Point(421, 232);
            this.btnLogDoc.Name = "btnLogDoc";
            this.btnLogDoc.Size = new System.Drawing.Size(258, 87);
            this.btnLogDoc.TabIndex = 0;
            this.btnLogDoc.Text = "Doktor Girişi";
            this.btnLogDoc.UseVisualStyleBackColor = true;
            this.btnLogDoc.Click += new System.EventHandler(this.btnLogDoc_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(257, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(606, 97);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Diyabet Takip Sistemine Hoşgeldiniz";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.WordWrap = false;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 619);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLogDoc);
            this.Controls.Add(this.btnLogPat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartScreen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       



        #endregion

        private System.Windows.Forms.Button btnLogPat;
        private System.Windows.Forms.Button btnLogDoc;
        private System.Windows.Forms.TextBox textBox1;
    }
}

