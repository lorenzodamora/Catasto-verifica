namespace Catasto
{
	partial class Catasto
	{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
			this.pagine = new System.Windows.Forms.TabControl();
			this.pageTerreno = new System.Windows.Forms.TabPage();
			this.view_terreni = new System.Windows.Forms.ListView();
			this.btn_sendTerreno = new System.Windows.Forms.Button();
			this.btn_fabbricabile = new System.Windows.Forms.Button();
			this.lbl_fabbricabile = new System.Windows.Forms.Label();
			this.pageAbitazione = new System.Windows.Forms.TabPage();
			this.subPagine = new System.Windows.Forms.TabControl();
			this.pageAbitazioneNormale = new System.Windows.Forms.TabPage();
			this.view_abitazioniNormali = new System.Windows.Forms.ListView();
			this.txt_vani = new System.Windows.Forms.TextBox();
			this.lbl_vani = new System.Windows.Forms.Label();
			this.btn_sendAbitazioneNormale = new System.Windows.Forms.Button();
			this.pageAbitazioneAttico = new System.Windows.Forms.TabPage();
			this.view_abitazioniAttici = new System.Windows.Forms.ListView();
			this.txt_terrazzo = new System.Windows.Forms.TextBox();
			this.lbl_terrazzo = new System.Windows.Forms.Label();
			this.btn_sendAbitazioneAttico = new System.Windows.Forms.Button();
			this.GraphicTitle = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_categoria = new System.Windows.Forms.TextBox();
			this.txt_superficie = new System.Windows.Forms.TextBox();
			this.lbl_categoria = new System.Windows.Forms.Label();
			this.lbl_particella = new System.Windows.Forms.Label();
			this.lbl_superficie = new System.Windows.Forms.Label();
			this.txt_particella = new System.Windows.Forms.TextBox();
			this.view_immobili = new System.Windows.Forms.ListView();
			this.head_indice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_superficie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_particella = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_extra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pagine.SuspendLayout();
			this.pageTerreno.SuspendLayout();
			this.pageAbitazione.SuspendLayout();
			this.subPagine.SuspendLayout();
			this.pageAbitazioneNormale.SuspendLayout();
			this.pageAbitazioneAttico.SuspendLayout();
			this.SuspendLayout();
			// 
			// pagine
			// 
			this.pagine.Controls.Add(this.pageTerreno);
			this.pagine.Controls.Add(this.pageAbitazione);
			this.pagine.Location = new System.Drawing.Point(669, 57);
			this.pagine.Name = "pagine";
			this.pagine.SelectedIndex = 0;
			this.pagine.Size = new System.Drawing.Size(946, 566);
			this.pagine.TabIndex = 0;
			// 
			// pageTerreno
			// 
			this.pageTerreno.Controls.Add(this.view_terreni);
			this.pageTerreno.Controls.Add(this.btn_sendTerreno);
			this.pageTerreno.Controls.Add(this.btn_fabbricabile);
			this.pageTerreno.Controls.Add(this.lbl_fabbricabile);
			this.pageTerreno.Location = new System.Drawing.Point(4, 22);
			this.pageTerreno.Name = "pageTerreno";
			this.pageTerreno.Padding = new System.Windows.Forms.Padding(3);
			this.pageTerreno.Size = new System.Drawing.Size(938, 540);
			this.pageTerreno.TabIndex = 0;
			this.pageTerreno.Text = "Terreno";
			this.pageTerreno.UseVisualStyleBackColor = true;
			// 
			// view_terreni
			// 
			this.view_terreni.HideSelection = false;
			this.view_terreni.Location = new System.Drawing.Point(344, 34);
			this.view_terreni.Name = "view_terreni";
			this.view_terreni.Size = new System.Drawing.Size(588, 490);
			this.view_terreni.TabIndex = 39;
			this.view_terreni.UseCompatibleStateImageBehavior = false;
			// 
			// btn_sendTerreno
			// 
			this.btn_sendTerreno.Location = new System.Drawing.Point(235, 34);
			this.btn_sendTerreno.Name = "btn_sendTerreno";
			this.btn_sendTerreno.Size = new System.Drawing.Size(84, 217);
			this.btn_sendTerreno.TabIndex = 31;
			this.btn_sendTerreno.Text = "Invia";
			this.btn_sendTerreno.UseVisualStyleBackColor = true;
			this.btn_sendTerreno.Click += new System.EventHandler(this.SendTerreno_Click);
			// 
			// btn_fabbricabile
			// 
			this.btn_fabbricabile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_fabbricabile.Location = new System.Drawing.Point(134, 42);
			this.btn_fabbricabile.Name = "btn_fabbricabile";
			this.btn_fabbricabile.Size = new System.Drawing.Size(52, 33);
			this.btn_fabbricabile.TabIndex = 36;
			this.btn_fabbricabile.Text = "Si";
			this.btn_fabbricabile.UseVisualStyleBackColor = true;
			this.btn_fabbricabile.Click += new System.EventHandler(this.Fabbricabile_Click);
			// 
			// lbl_fabbricabile
			// 
			this.lbl_fabbricabile.AutoSize = true;
			this.lbl_fabbricabile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_fabbricabile.Location = new System.Drawing.Point(35, 41);
			this.lbl_fabbricabile.Name = "lbl_fabbricabile";
			this.lbl_fabbricabile.Size = new System.Drawing.Size(93, 34);
			this.lbl_fabbricabile.TabIndex = 35;
			this.lbl_fabbricabile.Text = "Fabbricabile?\r\nNo";
			this.lbl_fabbricabile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pageAbitazione
			// 
			this.pageAbitazione.Controls.Add(this.subPagine);
			this.pageAbitazione.Location = new System.Drawing.Point(4, 22);
			this.pageAbitazione.Name = "pageAbitazione";
			this.pageAbitazione.Padding = new System.Windows.Forms.Padding(3);
			this.pageAbitazione.Size = new System.Drawing.Size(938, 540);
			this.pageAbitazione.TabIndex = 1;
			this.pageAbitazione.Text = "Abitazione";
			this.pageAbitazione.UseVisualStyleBackColor = true;
			// 
			// subPagine
			// 
			this.subPagine.Controls.Add(this.pageAbitazioneNormale);
			this.subPagine.Controls.Add(this.pageAbitazioneAttico);
			this.subPagine.Location = new System.Drawing.Point(6, 6);
			this.subPagine.Name = "subPagine";
			this.subPagine.SelectedIndex = 0;
			this.subPagine.Size = new System.Drawing.Size(926, 528);
			this.subPagine.TabIndex = 1;
			this.subPagine.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.SubPagine_Selecting);
			// 
			// pageAbitazioneNormale
			// 
			this.pageAbitazioneNormale.Controls.Add(this.view_abitazioniNormali);
			this.pageAbitazioneNormale.Controls.Add(this.txt_vani);
			this.pageAbitazioneNormale.Controls.Add(this.lbl_vani);
			this.pageAbitazioneNormale.Controls.Add(this.btn_sendAbitazioneNormale);
			this.pageAbitazioneNormale.Location = new System.Drawing.Point(4, 22);
			this.pageAbitazioneNormale.Name = "pageAbitazioneNormale";
			this.pageAbitazioneNormale.Padding = new System.Windows.Forms.Padding(3);
			this.pageAbitazioneNormale.Size = new System.Drawing.Size(918, 502);
			this.pageAbitazioneNormale.TabIndex = 0;
			this.pageAbitazioneNormale.Text = "Normale";
			this.pageAbitazioneNormale.UseVisualStyleBackColor = true;
			// 
			// view_abitazioniNormali
			// 
			this.view_abitazioniNormali.HideSelection = false;
			this.view_abitazioniNormali.Location = new System.Drawing.Point(324, 3);
			this.view_abitazioniNormali.Name = "view_abitazioniNormali";
			this.view_abitazioniNormali.Size = new System.Drawing.Size(588, 490);
			this.view_abitazioniNormali.TabIndex = 39;
			this.view_abitazioniNormali.UseCompatibleStateImageBehavior = false;
			// 
			// txt_vani
			// 
			this.txt_vani.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_vani.Location = new System.Drawing.Point(6, 47);
			this.txt_vani.MaxLength = 20;
			this.txt_vani.Name = "txt_vani";
			this.txt_vani.Size = new System.Drawing.Size(204, 29);
			this.txt_vani.TabIndex = 39;
			// 
			// lbl_vani
			// 
			this.lbl_vani.AutoSize = true;
			this.lbl_vani.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_vani.Location = new System.Drawing.Point(3, 31);
			this.lbl_vani.Name = "lbl_vani";
			this.lbl_vani.Size = new System.Drawing.Size(68, 13);
			this.lbl_vani.TabIndex = 38;
			this.lbl_vani.Text = "Numero Vani";
			// 
			// btn_sendAbitazioneNormale
			// 
			this.btn_sendAbitazioneNormale.Location = new System.Drawing.Point(225, 6);
			this.btn_sendAbitazioneNormale.Name = "btn_sendAbitazioneNormale";
			this.btn_sendAbitazioneNormale.Size = new System.Drawing.Size(84, 217);
			this.btn_sendAbitazioneNormale.TabIndex = 37;
			this.btn_sendAbitazioneNormale.Text = "Invia";
			this.btn_sendAbitazioneNormale.UseVisualStyleBackColor = true;
			// 
			// pageAbitazioneAttico
			// 
			this.pageAbitazioneAttico.Controls.Add(this.view_abitazioniAttici);
			this.pageAbitazioneAttico.Controls.Add(this.txt_terrazzo);
			this.pageAbitazioneAttico.Controls.Add(this.lbl_terrazzo);
			this.pageAbitazioneAttico.Controls.Add(this.btn_sendAbitazioneAttico);
			this.pageAbitazioneAttico.Location = new System.Drawing.Point(4, 22);
			this.pageAbitazioneAttico.Name = "pageAbitazioneAttico";
			this.pageAbitazioneAttico.Padding = new System.Windows.Forms.Padding(3);
			this.pageAbitazioneAttico.Size = new System.Drawing.Size(918, 502);
			this.pageAbitazioneAttico.TabIndex = 1;
			this.pageAbitazioneAttico.Text = "Attico";
			this.pageAbitazioneAttico.UseVisualStyleBackColor = true;
			// 
			// view_abitazioniAttici
			// 
			this.view_abitazioniAttici.HideSelection = false;
			this.view_abitazioniAttici.Location = new System.Drawing.Point(324, 6);
			this.view_abitazioniAttici.Name = "view_abitazioniAttici";
			this.view_abitazioniAttici.Size = new System.Drawing.Size(588, 490);
			this.view_abitazioniAttici.TabIndex = 38;
			this.view_abitazioniAttici.UseCompatibleStateImageBehavior = false;
			// 
			// txt_terrazzo
			// 
			this.txt_terrazzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_terrazzo.Location = new System.Drawing.Point(15, 165);
			this.txt_terrazzo.MaxLength = 20;
			this.txt_terrazzo.Name = "txt_terrazzo";
			this.txt_terrazzo.Size = new System.Drawing.Size(204, 29);
			this.txt_terrazzo.TabIndex = 38;
			// 
			// lbl_terrazzo
			// 
			this.lbl_terrazzo.AutoSize = true;
			this.lbl_terrazzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_terrazzo.Location = new System.Drawing.Point(12, 149);
			this.lbl_terrazzo.Name = "lbl_terrazzo";
			this.lbl_terrazzo.Size = new System.Drawing.Size(98, 13);
			this.lbl_terrazzo.TabIndex = 37;
			this.lbl_terrazzo.Text = "Superficie Terrazzo";
			// 
			// btn_btn_sendAbitazioneAttico
			// 
			this.btn_sendAbitazioneAttico.Location = new System.Drawing.Point(225, 6);
			this.btn_sendAbitazioneAttico.Name = "btn_btn_sendAbitazioneAttico";
			this.btn_sendAbitazioneAttico.Size = new System.Drawing.Size(84, 217);
			this.btn_sendAbitazioneAttico.TabIndex = 38;
			this.btn_sendAbitazioneAttico.Text = "Invia";
			this.btn_sendAbitazioneAttico.UseVisualStyleBackColor = true;
			// 
			// GraphicTitle
			// 
			this.GraphicTitle.BackColor = System.Drawing.Color.Black;
			this.GraphicTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GraphicTitle.ForeColor = System.Drawing.Color.White;
			this.GraphicTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.GraphicTitle.Location = new System.Drawing.Point(397, 0);
			this.GraphicTitle.Name = "GraphicTitle";
			this.GraphicTitle.Size = new System.Drawing.Size(400, 40);
			this.GraphicTitle.TabIndex = 17;
			this.GraphicTitle.Text = "CATASTO";
			this.GraphicTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.DimGray;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Location = new System.Drawing.Point(24, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 45);
			this.label1.TabIndex = 18;
			this.label1.Text = "Immobile";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_categoria
			// 
			this.txt_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_categoria.Location = new System.Drawing.Point(12, 211);
			this.txt_categoria.Name = "txt_categoria";
			this.txt_categoria.Size = new System.Drawing.Size(204, 29);
			this.txt_categoria.TabIndex = 36;
			// 
			// txt_superficie
			// 
			this.txt_superficie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_superficie.Location = new System.Drawing.Point(12, 88);
			this.txt_superficie.MaxLength = 20;
			this.txt_superficie.Name = "txt_superficie";
			this.txt_superficie.Size = new System.Drawing.Size(204, 29);
			this.txt_superficie.TabIndex = 34;
			// 
			// lbl_categoria
			// 
			this.lbl_categoria.AutoSize = true;
			this.lbl_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_categoria.Location = new System.Drawing.Point(9, 195);
			this.lbl_categoria.Name = "lbl_categoria";
			this.lbl_categoria.Size = new System.Drawing.Size(52, 13);
			this.lbl_categoria.TabIndex = 33;
			this.lbl_categoria.Text = "Categoria";
			// 
			// lbl_particella
			// 
			this.lbl_particella.AutoSize = true;
			this.lbl_particella.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_particella.Location = new System.Drawing.Point(9, 131);
			this.lbl_particella.Name = "lbl_particella";
			this.lbl_particella.Size = new System.Drawing.Size(50, 13);
			this.lbl_particella.TabIndex = 32;
			this.lbl_particella.Text = "Particella";
			// 
			// lbl_superficie
			// 
			this.lbl_superficie.AutoSize = true;
			this.lbl_superficie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_superficie.Location = new System.Drawing.Point(9, 72);
			this.lbl_superficie.Name = "lbl_superficie";
			this.lbl_superficie.Size = new System.Drawing.Size(71, 13);
			this.lbl_superficie.TabIndex = 31;
			this.lbl_superficie.Text = "Superficie mq";
			// 
			// txt_particella
			// 
			this.txt_particella.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_particella.Location = new System.Drawing.Point(12, 147);
			this.txt_particella.Name = "txt_particella";
			this.txt_particella.Size = new System.Drawing.Size(204, 29);
			this.txt_particella.TabIndex = 30;
			// 
			// view_immobili
			// 
			this.view_immobili.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.head_indice,
            this.head_superficie,
            this.head_particella,
            this.head_categoria,
            this.head_extra});
			this.view_immobili.HideSelection = false;
			this.view_immobili.Location = new System.Drawing.Point(12, 256);
			this.view_immobili.Name = "view_immobili";
			this.view_immobili.Size = new System.Drawing.Size(619, 363);
			this.view_immobili.TabIndex = 37;
			this.view_immobili.UseCompatibleStateImageBehavior = false;
			this.view_immobili.View = System.Windows.Forms.View.Details;
			// 
			// head_indice
			// 
			this.head_indice.Text = "Indice";
			this.head_indice.Width = 41;
			// 
			// head_superficie
			// 
			this.head_superficie.Text = "Superficie mq";
			this.head_superficie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.head_superficie.Width = 85;
			// 
			// head_particella
			// 
			this.head_particella.Text = "Particella";
			this.head_particella.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// head_categoria
			// 
			this.head_categoria.Text = "Categoria";
			this.head_categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// head_extra
			// 
			this.head_extra.Text = "Details";
			this.head_extra.Width = 369;
			// 
			// Catasto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1625, 635);
			this.Controls.Add(this.view_immobili);
			this.Controls.Add(this.txt_categoria);
			this.Controls.Add(this.txt_superficie);
			this.Controls.Add(this.lbl_categoria);
			this.Controls.Add(this.lbl_particella);
			this.Controls.Add(this.lbl_superficie);
			this.Controls.Add(this.txt_particella);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.GraphicTitle);
			this.Controls.Add(this.pagine);
			this.Name = "Catasto";
			this.Text = "Catasto";
			this.pagine.ResumeLayout(false);
			this.pageTerreno.ResumeLayout(false);
			this.pageTerreno.PerformLayout();
			this.pageAbitazione.ResumeLayout(false);
			this.subPagine.ResumeLayout(false);
			this.pageAbitazioneNormale.ResumeLayout(false);
			this.pageAbitazioneNormale.PerformLayout();
			this.pageAbitazioneAttico.ResumeLayout(false);
			this.pageAbitazioneAttico.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl pagine;
		private System.Windows.Forms.TabPage pageTerreno;
		private System.Windows.Forms.TabPage pageAbitazione;
		private System.Windows.Forms.TabControl subPagine;
		private System.Windows.Forms.TabPage pageAbitazioneNormale;
		private System.Windows.Forms.TabPage pageAbitazioneAttico;
		private System.Windows.Forms.Label GraphicTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_categoria;
		private System.Windows.Forms.TextBox txt_superficie;
		private System.Windows.Forms.Label lbl_categoria;
		private System.Windows.Forms.Label lbl_particella;
		private System.Windows.Forms.Label lbl_superficie;
		private System.Windows.Forms.TextBox txt_particella;
		private System.Windows.Forms.Button btn_fabbricabile;
		private System.Windows.Forms.Label lbl_fabbricabile;
		private System.Windows.Forms.Button btn_sendTerreno;
		private System.Windows.Forms.Button btn_sendAbitazioneNormale;
		private System.Windows.Forms.Button btn_sendAbitazioneAttico;
		private System.Windows.Forms.TextBox txt_vani;
		private System.Windows.Forms.Label lbl_vani;
		private System.Windows.Forms.TextBox txt_terrazzo;
		private System.Windows.Forms.Label lbl_terrazzo;
		private System.Windows.Forms.ListView view_terreni;
		private System.Windows.Forms.ListView view_abitazioniNormali;
		private System.Windows.Forms.ListView view_abitazioniAttici;
		private System.Windows.Forms.ListView view_immobili;
		private System.Windows.Forms.ColumnHeader head_indice;
		private System.Windows.Forms.ColumnHeader head_superficie;
		private System.Windows.Forms.ColumnHeader head_particella;
		private System.Windows.Forms.ColumnHeader head_categoria;
		private System.Windows.Forms.ColumnHeader head_extra;
	}
}

