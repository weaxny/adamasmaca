
namespace adamasmaca
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ip1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ip2 = new System.Windows.Forms.Label();
            this.ip3 = new System.Windows.Forms.Label();
            this.ip4 = new System.Windows.Forms.Label();
            this.ip5 = new System.Windows.Forms.Label();
            this.ip6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ip7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Geçen süre: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Magenta;
            this.label3.Location = new System.Drawing.Point(16, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "cizgiler";
            // 
            // ip1
            // 
            this.ip1.AutoSize = true;
            this.ip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ip1.Location = new System.Drawing.Point(398, 9);
            this.ip1.Name = "ip1";
            this.ip1.Size = new System.Drawing.Size(128, 273);
            this.ip1.TabIndex = 3;
            this.ip1.Text = "   +---+\r\n   |      |\r\n          |\r\n          |\r\n          |\r\n          |\r\n------" +
    "--";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Harf Tahmin Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kalan Hakkınız:";
            // 
            // ip2
            // 
            this.ip2.AutoSize = true;
            this.ip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ip2.Location = new System.Drawing.Point(388, 9);
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(128, 273);
            this.ip2.TabIndex = 7;
            this.ip2.Text = "   +---+\r\n   |      |\r\n  O     |\r\n          |\r\n          |\r\n          |\r\n--------" +
    "";
            this.ip2.Visible = false;
            // 
            // ip3
            // 
            this.ip3.AutoSize = true;
            this.ip3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ip3.Location = new System.Drawing.Point(388, 9);
            this.ip3.Name = "ip3";
            this.ip3.Size = new System.Drawing.Size(128, 273);
            this.ip3.TabIndex = 8;
            this.ip3.Text = "   +---+\r\n   |      |\r\n  O     |\r\n   |      |\r\n          |\r\n          |\r\n--------" +
    "";
            this.ip3.Visible = false;
            // 
            // ip4
            // 
            this.ip4.AutoSize = true;
            this.ip4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ip4.Location = new System.Drawing.Point(388, 9);
            this.ip4.Name = "ip4";
            this.ip4.Size = new System.Drawing.Size(128, 273);
            this.ip4.TabIndex = 9;
            this.ip4.Text = "   +---+\r\n   |      |\r\n  O     |\r\n   |\\     |\r\n          |\r\n          |\r\n--------" +
    "";
            this.ip4.Visible = false;
            // 
            // ip5
            // 
            this.ip5.AutoSize = true;
            this.ip5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ip5.Location = new System.Drawing.Point(396, 9);
            this.ip5.Name = "ip5";
            this.ip5.Size = new System.Drawing.Size(129, 273);
            this.ip5.TabIndex = 10;
            this.ip5.Text = "   +---+\r\n   |      |\r\n  O     |\r\n  /|\\     |\r\n          |\r\n          |\r\n--------" +
    "";
            this.ip5.Visible = false;
            // 
            // ip6
            // 
            this.ip6.AutoSize = true;
            this.ip6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ip6.Location = new System.Drawing.Point(396, 9);
            this.ip6.Name = "ip6";
            this.ip6.Size = new System.Drawing.Size(129, 273);
            this.ip6.TabIndex = 11;
            this.ip6.Text = "   +---+\r\n   |      |\r\n  O     |\r\n  /|\\     |\r\n    \\     |\r\n          |\r\n--------" +
    "";
            this.ip6.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Harf Giriniz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kelime Giriniz";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Kelime Tahmin Et";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ip7
            // 
            this.ip7.AutoSize = true;
            this.ip7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ip7.Location = new System.Drawing.Point(387, 9);
            this.ip7.Name = "ip7";
            this.ip7.Size = new System.Drawing.Size(129, 273);
            this.ip7.TabIndex = 16;
            this.ip7.Text = "   +---+\r\n   |      |\r\n  O     |\r\n  /|\\     |\r\n  / \\     |\r\n          |\r\n--------" +
    "";
            this.ip7.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 28);
            this.button3.TabIndex = 17;
            this.button3.Text = "Yeni Oyun Başlat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(531, 323);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ip7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ip6);
            this.Controls.Add(this.ip5);
            this.Controls.Add(this.ip4);
            this.Controls.Add(this.ip3);
            this.Controls.Add(this.ip2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weaxny Development Adam Asmaca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ip2;
        private System.Windows.Forms.Label ip3;
        private System.Windows.Forms.Label ip4;
        private System.Windows.Forms.Label ip5;
        private System.Windows.Forms.Label ip6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ip7;
        private System.Windows.Forms.Button button3;
    }
}

