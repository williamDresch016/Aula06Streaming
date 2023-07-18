namespace Aula06Streaming
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.imgFundo = new System.Windows.Forms.PictureBox();
            this.wvVideo = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.imgFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(60, 248);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(84, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "TÍTULO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Assistir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(62, 338);
            this.lblDescricao.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(138, 13);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "DESCRIÇÃO LONGA AQUI";
            // 
            // imgFundo
            // 
            this.imgFundo.Location = new System.Drawing.Point(13, 13);
            this.imgFundo.Name = "imgFundo";
            this.imgFundo.Size = new System.Drawing.Size(775, 425);
            this.imgFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFundo.TabIndex = 0;
            this.imgFundo.TabStop = false;
            // 
            // wvVideo
            // 
            this.wvVideo.AllowExternalDrop = true;
            this.wvVideo.CreationProperties = null;
            this.wvVideo.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvVideo.Location = new System.Drawing.Point(13, 13);
            this.wvVideo.Name = "wvVideo";
            this.wvVideo.Size = new System.Drawing.Size(776, 425);
            this.wvVideo.TabIndex = 4;
            this.wvVideo.Visible = false;
            this.wvVideo.ZoomFactor = 1D;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wvVideo);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.imgFundo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgFundo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDescricao;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvVideo;
    }
}