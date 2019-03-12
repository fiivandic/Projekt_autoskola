namespace Projekt
{
    partial class Glavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavna));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInstruktori = new System.Windows.Forms.Button();
            this.btnPolaznici = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.brziPregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelVozilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korištenjeVozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lokacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mjestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mjestaAutoškolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vrstaTelefonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefoniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zahvaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvješćaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Image = global::Projekt.Properties.Resources.c241036b008d6e273c4a4d3a6cbeddf5__mint_background_custom_fabric;
            this.label1.Location = new System.Drawing.Point(94, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sustav autoškola ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "v1.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "© FiivandicDS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.BackgroundImage = global::Projekt.Properties.Resources.c241036b008d6e273c4a4d3a6cbeddf5__mint_background_custom_fabric;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Projekt.Properties.Resources.auto_161040_960_720;
            this.pictureBox1.Location = new System.Drawing.Point(95, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnInstruktori
            // 
            this.btnInstruktori.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInstruktori.Location = new System.Drawing.Point(95, 309);
            this.btnInstruktori.Name = "btnInstruktori";
            this.btnInstruktori.Size = new System.Drawing.Size(130, 54);
            this.btnInstruktori.TabIndex = 4;
            this.btnInstruktori.Text = "Pregled instruktora";
            this.btnInstruktori.UseVisualStyleBackColor = true;
            this.btnInstruktori.Click += new System.EventHandler(this.btnInstruktori_Click);
            // 
            // btnPolaznici
            // 
            this.btnPolaznici.Location = new System.Drawing.Point(247, 309);
            this.btnPolaznici.Name = "btnPolaznici";
            this.btnPolaznici.Size = new System.Drawing.Size(132, 54);
            this.btnPolaznici.TabIndex = 5;
            this.btnPolaznici.Text = "Pregled polaznika";
            this.btnPolaznici.UseVisualStyleBackColor = true;
            this.btnPolaznici.Click += new System.EventHandler(this.btnPolaznici_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brziPregledToolStripMenuItem,
            this.zahvaleToolStripMenuItem,
            this.izvješćaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(446, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // brziPregledToolStripMenuItem
            // 
            this.brziPregledToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vozilaToolStripMenuItem,
            this.lokacijeToolStripMenuItem,
            this.telefonToolStripMenuItem});
            this.brziPregledToolStripMenuItem.Name = "brziPregledToolStripMenuItem";
            this.brziPregledToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.brziPregledToolStripMenuItem.Text = "Brzi pregled";
            // 
            // vozilaToolStripMenuItem
            // 
            this.vozilaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelVozilsToolStripMenuItem,
            this.korištenjeVozilaToolStripMenuItem});
            this.vozilaToolStripMenuItem.Name = "vozilaToolStripMenuItem";
            this.vozilaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.vozilaToolStripMenuItem.Text = "Vozila";
            // 
            // modelVozilsToolStripMenuItem
            // 
            this.modelVozilsToolStripMenuItem.Name = "modelVozilsToolStripMenuItem";
            this.modelVozilsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.modelVozilsToolStripMenuItem.Text = "Model vozila";
            this.modelVozilsToolStripMenuItem.Click += new System.EventHandler(this.modelVozilsToolStripMenuItem_Click);
            // 
            // korištenjeVozilaToolStripMenuItem
            // 
            this.korištenjeVozilaToolStripMenuItem.Name = "korištenjeVozilaToolStripMenuItem";
            this.korištenjeVozilaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.korištenjeVozilaToolStripMenuItem.Text = "Korištenje vozila";
            this.korištenjeVozilaToolStripMenuItem.Click += new System.EventHandler(this.korištenjeVozilaToolStripMenuItem_Click);
            // 
            // lokacijeToolStripMenuItem
            // 
            this.lokacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mjestaToolStripMenuItem,
            this.mjestaAutoškolaToolStripMenuItem});
            this.lokacijeToolStripMenuItem.Name = "lokacijeToolStripMenuItem";
            this.lokacijeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.lokacijeToolStripMenuItem.Text = "Lokacije";
            // 
            // mjestaToolStripMenuItem
            // 
            this.mjestaToolStripMenuItem.Name = "mjestaToolStripMenuItem";
            this.mjestaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.mjestaToolStripMenuItem.Text = "Lokacije autoškola";
            this.mjestaToolStripMenuItem.Click += new System.EventHandler(this.mjestaToolStripMenuItem_Click);
            // 
            // mjestaAutoškolaToolStripMenuItem
            // 
            this.mjestaAutoškolaToolStripMenuItem.Name = "mjestaAutoškolaToolStripMenuItem";
            this.mjestaAutoškolaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.mjestaAutoškolaToolStripMenuItem.Text = "Mjesta autoškola";
            this.mjestaAutoškolaToolStripMenuItem.Click += new System.EventHandler(this.mjestaAutoškolaToolStripMenuItem_Click);
            // 
            // telefonToolStripMenuItem
            // 
            this.telefonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vrstaTelefonaToolStripMenuItem,
            this.telefoniToolStripMenuItem});
            this.telefonToolStripMenuItem.Name = "telefonToolStripMenuItem";
            this.telefonToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.telefonToolStripMenuItem.Text = "Telefon";
            // 
            // vrstaTelefonaToolStripMenuItem
            // 
            this.vrstaTelefonaToolStripMenuItem.Name = "vrstaTelefonaToolStripMenuItem";
            this.vrstaTelefonaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.vrstaTelefonaToolStripMenuItem.Text = "Vrsta telefona";
            this.vrstaTelefonaToolStripMenuItem.Click += new System.EventHandler(this.vrstaTelefonaToolStripMenuItem_Click);
            // 
            // telefoniToolStripMenuItem
            // 
            this.telefoniToolStripMenuItem.Name = "telefoniToolStripMenuItem";
            this.telefoniToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.telefoniToolStripMenuItem.Text = "Pozivni brojevi ";
            this.telefoniToolStripMenuItem.Click += new System.EventHandler(this.telefoniToolStripMenuItem_Click);
            // 
            // zahvaleToolStripMenuItem
            // 
            this.zahvaleToolStripMenuItem.Name = "zahvaleToolStripMenuItem";
            this.zahvaleToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.zahvaleToolStripMenuItem.Text = "Zahvale";
            this.zahvaleToolStripMenuItem.Click += new System.EventHandler(this.zahvaleToolStripMenuItem_Click);
            // 
            // izvješćaToolStripMenuItem
            // 
            this.izvješćaToolStripMenuItem.Name = "izvješćaToolStripMenuItem";
            this.izvješćaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.izvješćaToolStripMenuItem.Text = "Izvješća";
            this.izvješćaToolStripMenuItem.Click += new System.EventHandler(this.izvješćaToolStripMenuItem_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt.Properties.Resources.c241036b008d6e273c4a4d3a6cbeddf5__mint_background_custom_fabric;
            this.ClientSize = new System.Drawing.Size(446, 456);
            this.Controls.Add(this.btnPolaznici);
            this.Controls.Add(this.btnInstruktori);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna";
            this.Text = "Sustav autoškola";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInstruktori;
        private System.Windows.Forms.Button btnPolaznici;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem brziPregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lokacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelVozilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korištenjeVozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mjestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mjestaAutoškolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vrstaTelefonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefoniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zahvaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvješćaToolStripMenuItem;
    }
}

