
namespace CronogramaYoutube
{
    partial class CronogramaLogado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CronogramaLogado));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListView();
            this.tituloTxt = new System.Windows.Forms.TextBox();
            this.gravadoTxt = new System.Windows.Forms.TextBox();
            this.nada = new System.Windows.Forms.Label();
            this.btn_limparlista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataMasked = new System.Windows.Forms.MaskedTextBox();
            this.maskHora = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(-10, -8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(956, 136);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Brown;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cadastrar.Location = new System.Drawing.Point(578, 137);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(204, 21);
            this.btn_cadastrar.TabIndex = 3;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lista
            // 
            this.Lista.FullRowSelect = true;
            this.Lista.GridLines = true;
            this.Lista.HideSelection = false;
            this.Lista.Location = new System.Drawing.Point(80, 189);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(831, 218);
            this.Lista.TabIndex = 4;
            this.Lista.UseCompatibleStateImageBehavior = false;
            this.Lista.View = System.Windows.Forms.View.Details;
            // 
            // tituloTxt
            // 
            this.tituloTxt.Location = new System.Drawing.Point(251, 163);
            this.tituloTxt.Name = "tituloTxt";
            this.tituloTxt.Size = new System.Drawing.Size(206, 20);
            this.tituloTxt.TabIndex = 7;
            // 
            // gravadoTxt
            // 
            this.gravadoTxt.Location = new System.Drawing.Point(457, 163);
            this.gravadoTxt.Name = "gravadoTxt";
            this.gravadoTxt.Size = new System.Drawing.Size(115, 20);
            this.gravadoTxt.TabIndex = 8;
            this.gravadoTxt.TextChanged += new System.EventHandler(this.gravadoTxt_TextChanged);
            // 
            // nada
            // 
            this.nada.AutoSize = true;
            this.nada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nada.Location = new System.Drawing.Point(142, 145);
            this.nada.Name = "nada";
            this.nada.Size = new System.Drawing.Size(33, 15);
            this.nada.TabIndex = 9;
            this.nada.Text = "Data";
            // 
            // btn_limparlista
            // 
            this.btn_limparlista.BackColor = System.Drawing.Color.Snow;
            this.btn_limparlista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limparlista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limparlista.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limparlista.Location = new System.Drawing.Point(578, 161);
            this.btn_limparlista.Name = "btn_limparlista";
            this.btn_limparlista.Size = new System.Drawing.Size(204, 21);
            this.btn_limparlista.TabIndex = 10;
            this.btn_limparlista.Text = "REMOVER ITEM SELECIONADO";
            this.btn_limparlista.UseVisualStyleBackColor = false;
            this.btn_limparlista.Click += new System.EventHandler(this.btn_limparlista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Título do vídeo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Gravado [SIM/NÃO]";
            // 
            // dataMasked
            // 
            this.dataMasked.Location = new System.Drawing.Point(127, 163);
            this.dataMasked.Mask = "00/00/0000";
            this.dataMasked.Name = "dataMasked";
            this.dataMasked.Size = new System.Drawing.Size(64, 20);
            this.dataMasked.TabIndex = 15;
            this.dataMasked.ValidatingType = typeof(System.DateTime);
            // 
            // maskHora
            // 
            this.maskHora.Location = new System.Drawing.Point(190, 163);
            this.maskHora.Mask = "90:00";
            this.maskHora.Name = "maskHora";
            this.maskHora.Size = new System.Drawing.Size(62, 20);
            this.maskHora.TabIndex = 16;
            this.maskHora.ValidatingType = typeof(System.DateTime);
            // 
            // CronogramaLogado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(936, 477);
            this.Controls.Add(this.maskHora);
            this.Controls.Add(this.dataMasked);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_limparlista);
            this.Controls.Add(this.nada);
            this.Controls.Add(this.gravadoTxt);
            this.Controls.Add(this.tituloTxt);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "CronogramaLogado";
            this.Text = "CronogramaLogado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.TextBox tituloTxt;
        private System.Windows.Forms.TextBox gravadoTxt;
        private System.Windows.Forms.Label nada;
        private System.Windows.Forms.Button btn_limparlista;
        public System.Windows.Forms.ListView Lista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox dataMasked;
        private System.Windows.Forms.MaskedTextBox maskHora;
    }
}