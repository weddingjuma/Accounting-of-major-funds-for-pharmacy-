namespace Курсовая_Чуваев
{
    partial class Главная_форма
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
            this.Vhod_v_apteky = new System.Windows.Forms.Button();
            this.Nazv = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Vhod_v_apteky
            // 
            this.Vhod_v_apteky.Location = new System.Drawing.Point(47, 72);
            this.Vhod_v_apteky.Name = "Vhod_v_apteky";
            this.Vhod_v_apteky.Size = new System.Drawing.Size(200, 40);
            this.Vhod_v_apteky.TabIndex = 5;
            this.Vhod_v_apteky.Text = "Препараты";
            this.Vhod_v_apteky.UseVisualStyleBackColor = true;
            this.Vhod_v_apteky.Click += new System.EventHandler(this.Vhod_v_apteky_Click_1);
            // 
            // Nazv
            // 
            this.Nazv.AutoSize = true;
            this.Nazv.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nazv.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Nazv.Location = new System.Drawing.Point(75, 9);
            this.Nazv.Name = "Nazv";
            this.Nazv.Size = new System.Drawing.Size(214, 40);
            this.Nazv.TabIndex = 4;
            this.Nazv.Text = "\"Дарница\"";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Фирмы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Прайс цен";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Добро пожаловать!!!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Vhod_v_apteky);
            this.groupBox1.Location = new System.Drawing.Point(40, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 174);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Начните работу с нажатия этих кнопок";
            // 
            // Главная_форма
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Nazv);
            this.Name = "Главная_форма";
            this.Text = "Дарница";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Vhod_v_apteky;
        private System.Windows.Forms.Label Nazv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

