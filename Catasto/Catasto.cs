using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Catasto
{
	public partial class Catasto : Form
	{
		List<Immobile> imm;
		public Catasto()
		{
			InitializeComponent();
			imm = new List<Immobile>();
		}

		/** Switch grafico della textbox numero vani */
		void SubPagine_Selecting(object sender, TabControlCancelEventArgs e)
		{
			if((sender as TabControl).SelectedTab == pageAbitazioneAttico)
			{
				pageAbitazioneNormale.Controls.Remove(lbl_vani);
				pageAbitazioneNormale.Controls.Remove(txt_vani);
				pageAbitazioneAttico.Controls.Add(lbl_vani);
				pageAbitazioneAttico.Controls.Add(txt_vani);
				return;
			}
			pageAbitazioneAttico.Controls.Remove(lbl_vani);
			pageAbitazioneAttico.Controls.Remove(txt_vani);
			pageAbitazioneNormale.Controls.Add(lbl_vani);
			pageAbitazioneNormale.Controls.Add(txt_vani);
		}

		private void Fabbricabile_Click(object sender, EventArgs e)
		{
			if(btn_fabbricabile.Text == "No")
			{
				btn_fabbricabile.Text = "Si";
				lbl_fabbricabile.Text = "Fabbricabile?\r\nNo";
			}
			else
			{
				btn_fabbricabile.Text = "No";
				lbl_fabbricabile.Text = "Fabbricabile?\r\nSi";
			}
		}

		private void SendTerreno_Click(object sender, EventArgs e)
		{
			if(CheckImmobile()) return;
			imm.Add(new Terreno(float.Parse(txt_superficie.Text), txt_particella.Text.Trim(), short.Parse(txt_categoria.Text.Trim()), btn_fabbricabile.Text == "No"));
			ListViewItem item = new ListViewItem((view_immobili.Items.Count + 1).ToString());
			string[] text = imm[imm.Count - 1].ToString().Split();
			foreach(var txt in text)
			{
				item.SubItems.Add(txt);
			}
			view_immobili.Items.Add(item);
		}

		/// <returns>true se c'è errore</returns>
		private bool CheckImmobile()
		{
			string super = txt_superficie.Text.Trim();
			string id = txt_particella.Text.Trim();
			string cat = txt_categoria.Text.Trim();
			string errore1 = "Errore nell'inserimento";
			if(super == "" || id == "" || cat == "")
			{
				MessageBox.Show("Riempi le TextBox: Superficie, Particella, Categoria.", errore1);
				return true;
			}
			if(!float.TryParse(super, out float superf) || superf <= 0)
			{
				MessageBox.Show("La Superficie è un numero maggiore di 0", errore1);
				return true;
			}
			if(!System.Linq.Enumerable.All(id, char.IsDigit))
			{
				MessageBox.Show("la particella deve essere solo numerica [0-9]", errore1);
				return true;
			}
			if(!short.TryParse(cat, out short cats) || cats < 1 || cats > 5)
			{
				MessageBox.Show("Categoria tra 1 e 5", errore1);
				return true;
			}
			return false;
		}
	}
}
