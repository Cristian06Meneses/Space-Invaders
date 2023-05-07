namespace Trabajodeclase2HP2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pic_enemigo = new System.Windows.Forms.PictureBox();
            this.pic_amigo = new System.Windows.Forms.PictureBox();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_puntos = new System.Windows.Forms.Label();
            this.lbl_nivel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_enemigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_amigo)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_enemigo
            // 
            this.pic_enemigo.BackColor = System.Drawing.Color.Transparent;
            this.pic_enemigo.Image = global::Trabajodeclase2HP2.Properties.Resources.si_px;
            this.pic_enemigo.Location = new System.Drawing.Point(310, 12);
            this.pic_enemigo.Name = "pic_enemigo";
            this.pic_enemigo.Size = new System.Drawing.Size(136, 111);
            this.pic_enemigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_enemigo.TabIndex = 0;
            this.pic_enemigo.TabStop = false;
            // 
            // pic_amigo
            // 
            this.pic_amigo.BackColor = System.Drawing.Color.Transparent;
            this.pic_amigo.Image = global::Trabajodeclase2HP2.Properties.Resources.SeekPng_com_nave_png_5280929;
            this.pic_amigo.Location = new System.Drawing.Point(329, 348);
            this.pic_amigo.Name = "pic_amigo";
            this.pic_amigo.Size = new System.Drawing.Size(117, 90);
            this.pic_amigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_amigo.TabIndex = 1;
            this.pic_amigo.TabStop = false;
            // 
            // tmr1
            // 
            this.tmr1.Enabled = true;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // lbl_puntos
            // 
            this.lbl_puntos.AutoSize = true;
            this.lbl_puntos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_puntos.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_puntos.ForeColor = System.Drawing.Color.Red;
            this.lbl_puntos.Location = new System.Drawing.Point(654, 422);
            this.lbl_puntos.Name = "lbl_puntos";
            this.lbl_puntos.Size = new System.Drawing.Size(78, 19);
            this.lbl_puntos.TabIndex = 2;
            this.lbl_puntos.Text = "Puntos: ";
            // 
            // lbl_nivel
            // 
            this.lbl_nivel.AutoSize = true;
            this.lbl_nivel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nivel.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nivel.ForeColor = System.Drawing.Color.Red;
            this.lbl_nivel.Location = new System.Drawing.Point(12, 422);
            this.lbl_nivel.Name = "lbl_nivel";
            this.lbl_nivel.Size = new System.Drawing.Size(65, 19);
            this.lbl_nivel.TabIndex = 3;
            this.lbl_nivel.Text = "Nivel 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = global::Trabajodeclase2HP2.Properties.Resources.espaciospaceinv;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_nivel);
            this.Controls.Add(this.pic_amigo);
            this.Controls.Add(this.pic_enemigo);
            this.Controls.Add(this.lbl_puntos);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pic_enemigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_amigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pic_enemigo;
        private PictureBox pic_amigo;
        private System.Windows.Forms.Timer tmr1;
        private Label lbl_puntos;
        private Label lbl_nivel;
    }
}