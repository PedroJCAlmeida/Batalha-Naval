namespace batalha_naval
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbl_jogador1 = new System.Windows.Forms.Label();
            this.tb_jogador = new System.Windows.Forms.TextBox();
            this.btn_play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_jogador1
            // 
            this.lbl_jogador1.AutoSize = true;
            this.lbl_jogador1.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_jogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jogador1.Location = new System.Drawing.Point(35, 26);
            this.lbl_jogador1.Name = "lbl_jogador1";
            this.lbl_jogador1.Size = new System.Drawing.Size(98, 24);
            this.lbl_jogador1.TabIndex = 0;
            this.lbl_jogador1.Text = "Jogador :";
            // 
            // tb_jogador
            // 
            this.tb_jogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_jogador.Location = new System.Drawing.Point(133, 23);
            this.tb_jogador.Name = "tb_jogador";
            this.tb_jogador.Size = new System.Drawing.Size(246, 29);
            this.tb_jogador.TabIndex = 1;
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_play.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_play.Location = new System.Drawing.Point(120, 195);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(188, 44);
            this.btn_play.TabIndex = 4;
            this.btn_play.Text = "Iniciar Batalha";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(440, 251);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.tb_jogador);
            this.Controls.Add(this.lbl_jogador1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Batalha Naval";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Form1 f1;
        private System.Windows.Forms.Label lbl_jogador1;
        public System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.TextBox tb_jogador;
    }
}