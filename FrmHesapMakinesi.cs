using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFin
{
	public partial class FrmHesapMakinesi : Form
	{
		public FrmHesapMakinesi()
		{
			InitializeComponent();
		}
		private string islem = "";
		private double sonuc = 0;
		private bool yeniGiris = true;
		private void FrmHesapMakinesi_Load(object sender, EventArgs e)
		{
			btnSayi1.Click += BtnSayi_Click;
			btnSayi2.Click += BtnSayi_Click;
			btnSayi3.Click += BtnSayi_Click;
			btnSayi4.Click += BtnSayi_Click;
			btnSayi5.Click += BtnSayi_Click;
			btnSayi6.Click += BtnSayi_Click;
			btnSayi7.Click += BtnSayi_Click;
			btnSayi8.Click += BtnSayi_Click;
			btnSayi9.Click += BtnSayi_Click;
			btnSayi0.Click += BtnSayi_Click;

			btnTopla.Click += BtnIslem_Click;
			btnCikar.Click += BtnIslem_Click;
			btnCarp.Click += BtnIslem_Click;
			btnBol.Click += BtnIslem_Click;

			BtnEsittir.Click += BtnEsittir_Click;
			BtnTemizle.Click += BtnTemizle_Click;
		}

		private void BtnIslem_Click(object sender, EventArgs e)
		{
			var button = sender as Button;
			if (button != null && !string.IsNullOrWhiteSpace(txtSonuc.Text))
			{
				if (string.IsNullOrEmpty(islem))
				{
					sonuc = Convert.ToDouble(txtSonuc.Text);
				}
				else
				{
					Hesapla();
				}
				islem = button.Text;
				yeniGiris = true;
			}
		}

		private void BtnEsittir_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(islem) && !string.IsNullOrWhiteSpace(txtSonuc.Text))
			{
				Hesapla();
				txtSonuc.Text = sonuc.ToString();
				islem = "";
				yeniGiris = true;
			}
			else
			{
				MessageBox.Show("Geçerli bir işlem giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void BtnTemizle_Click(object sender, EventArgs e)
		{
			txtSonuc.Text = "";
			islem = "";
			sonuc = 0;
			yeniGiris = true;
		}

		private void Hesapla()
		{
			try
			{
				double ikinciSayi = Convert.ToDouble(txtSonuc.Text);
				switch (islem)
				{
					case "+":
						sonuc += ikinciSayi;
						break;
					case "-":
						sonuc -= ikinciSayi;
						break;
					case "*":
						sonuc *= ikinciSayi;
						break;
					case "/":
						if (ikinciSayi != 0)
							sonuc /= ikinciSayi;
						else
							throw new DivideByZeroException("Sıfıra bölme hatası!");
						break;
				}
				yeniGiris = true;
			}
			catch
			{
				MessageBox.Show("Geçersiz giriş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnSayi_Click(object sender, EventArgs e)
		{
			var button = sender as Button;
			if (button != null)
			{
				if (yeniGiris)
				{
					txtSonuc.Text = "";
					yeniGiris = false;
				}
				txtSonuc.Text += button.Text;
			}
		}
	}
}
