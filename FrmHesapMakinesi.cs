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
		private string islem = ""; // İşlem tipi (+, -, *, /)
		private double sonuc = 0;  // Hesaplanan sonuç
		private bool yeniGiris = true; // Yeni giriş mi kontrolü
		private void FrmHesapMakinesi_Load(object sender, EventArgs e)
		{
			foreach (Control control in this.Controls)
			{
				if (control is DevExpress.XtraEditors.SimpleButton button && button.Name.StartsWith("btnSayi"))
				{
					button.Click += BtnSayi_Click;
				}
			}

			// İşlem butonları için:
			btnTopla.Click += BtnIslem_Click;
			btnCikar.Click += BtnIslem_Click;
			btnCarp.Click += BtnIslem_Click;
			btnBol.Click += BtnIslem_Click;

			// Diğer butonlar:
			BtnEsittir.Click += BtnEsittir_Click;
			BtnTemizle.Click += BtnTemizle_Click;
		}

		private void BtnIslem_Click(object sender, EventArgs e)
		{
			var button = sender as DevExpress.XtraEditors.SimpleButton;
			if (button != null)
			{
				if (!string.IsNullOrWhiteSpace(txtSonuc.Text))
				{
					if (yeniGiris && !string.IsNullOrEmpty(islem)) // Önceki işlem tamamlandıysa
					{
						islem = button.Text; // Yeni işlem tipi
						txtSonuc.Text = sonuc.ToString() + islem; // Sonucu ve yeni işlemi ekrana yaz
					}
					else
					{
						// İlk sayı ve işlem tipini al
						sonuc = Convert.ToDouble(txtSonuc.Text);
						islem = button.Text;
						txtSonuc.Text += islem; // İşleci ekle
						yeniGiris = true; // Yeni giriş bekle
					}
				}
			}
		}

		private void BtnEsittir_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtSonuc.Text) && !string.IsNullOrEmpty(islem))
			{
				Hesapla();
				txtSonuc.Text = sonuc.ToString(); // Sonucu ekrana yaz
				islem = ""; // İşlemi sıfırla
				yeniGiris = true; // Yeni giriş başlasın
			}
		}

		private void BtnTemizle_Click(object sender, EventArgs e)
		{
			txtSonuc.Text = ""; // Giriş alanını temizle
			islem = "";         // İşlemi sıfırla
			sonuc = 0;          // Sonucu sıfırla
			yeniGiris = true;   // Yeni giriş başlasın
		}

		private void Hesapla()
		{
			try
			{
				// İşlem dizisinden ikinci sayıyı al
				string[] sayilar = txtSonuc.Text.Split(new[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);

				if (sayilar.Length > 1)
				{
					double ikinciSayi = Convert.ToDouble(sayilar[1]);

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
								MessageBox.Show("Sıfıra bölme hatası!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
							break;
					}
				}
				else
				{
					MessageBox.Show("Geçerli bir işlem giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hesaplama sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void BtnSayi_Click(object sender, EventArgs e)
		{
			var button = sender as DevExpress.XtraEditors.SimpleButton;
			if (button != null)
			{
				if (yeniGiris)
				{
					txtSonuc.Text = ""; // Yeni bir giriş başlarsa ekranı temizle
					yeniGiris = false;
				}
				txtSonuc.Text += button.Text; // Tıklanan rakamı ekle
			}
		}
	}
}
