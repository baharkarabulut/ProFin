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
	public partial class FrmEtkilesimGecmisi : Form
	{
		public FrmEtkilesimGecmisi()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();

		private void EtkilesimleriListele()
		{
			var etkilesimListesi = db.Etkilesim
				.Select(e => new
				{
					e.EtkilesimID,
					MusteriAdi = e.Musteriler.AdSoyad,
					ProjeAdi = e.Projeler != null ? e.Projeler.ProjeAdi : "Genel",
					e.Tarih,
					e.EtkilesimTuru,
					e.Detay
				})
				.ToList();

			gridControlEtkilesim.DataSource = etkilesimListesi;
		}

		private void btnEtkilesimEkle_Click(object sender, EventArgs e)
		{
			try
			{
				if (cmbMusteri.SelectedValue == null)
				{
					MessageBox.Show("Lütfen bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (string.IsNullOrWhiteSpace(cmbEtkilesimTuru.Text))
				{
					MessageBox.Show("Lütfen bir etkileşim türü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (string.IsNullOrWhiteSpace(txtDetay.Text))
				{
					MessageBox.Show("Lütfen etkileşim detayını girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				Etkilesim yeniEtkilesim = new Etkilesim
				{
					MusteriID = Convert.ToInt32(cmbMusteri.SelectedValue),
					Tarih = dateEtkilesimTarihi.DateTime,
					EtkilesimTuru = cmbEtkilesimTuru.Text,
					Detay = txtDetay.Text,
					ProjeID = cmbProje.SelectedValue != null ? (int?)Convert.ToInt32(cmbProje.SelectedValue) : null
				};

				db.Etkilesim.Add(yeniEtkilesim);
				db.SaveChanges();

				MessageBox.Show("Etkileşim başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

				EtkilesimleriListele();

				Temizle();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void Temizle()
		{
			cmbMusteri.SelectedIndex = -1;
			cmbEtkilesimTuru.SelectedIndex = -1;
			txtDetay.Clear();
			cmbProje.SelectedIndex = -1;
			dateEtkilesimTarihi.DateTime = DateTime.Now;
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			try
			{
				int secilenID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("EtkilesimID"));
				var etkilesim = db.Etkilesim.Find(secilenID);

				if (cmbMusteri.SelectedValue == null || string.IsNullOrWhiteSpace(cmbEtkilesimTuru.Text) || string.IsNullOrWhiteSpace(txtDetay.Text))
				{
					MessageBox.Show("Zorunlu alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				etkilesim.MusteriID = Convert.ToInt32(cmbMusteri.SelectedValue);
				etkilesim.ProjeID = cmbProje.SelectedValue != null ? (int?)Convert.ToInt32(cmbProje.SelectedValue) : null;
				etkilesim.Tarih = dateEtkilesimTarihi.DateTime;
				etkilesim.EtkilesimTuru = cmbEtkilesimTuru.Text;
				etkilesim.Detay = txtDetay.Text;

				db.SaveChanges();
				MessageBox.Show("Etkileşim başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

				EtkilesimleriListele();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			int secilenID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("EtkilesimID"));
			var etkilesim = db.Etkilesim.Find(secilenID);

			db.Etkilesim.Remove(etkilesim);
			db.SaveChanges();
			MessageBox.Show("Etkileşim başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

			EtkilesimleriListele();
		}

		private void FrmEtkilesimGecmisi_Load(object sender, EventArgs e)
		{
			using (var db = new DbProFinEntities())
			{
				var musteriler = db.Musteriler.Select(m => new
				{
					m.MusteriID,
					m.AdSoyad
				}).ToList();

				cmbMusteri.DataSource = musteriler;
				cmbMusteri.DisplayMember = "AdSoyad";
				cmbMusteri.ValueMember = "MusteriID";

				cmbProje.DataSource = db.Projeler.Select(p => new
				{
					p.ProjeID,
					p.ProjeAdi
				}).ToList();
				cmbProje.DisplayMember = "ProjeAdi";
				cmbProje.ValueMember = "ProjeID";

				cmbEtkilesimTuru.Items.AddRange(new string[] { "Telefon Görüşmesi", "E-posta", "Toplantı", "Diğer" });
			}
			dateEtkilesimTarihi.DateTime = DateTime.Now;
			MüşteriVeProjeleriDoldur();
			EtkilesimleriListele();
		}

		private void MüşteriVeProjeleriDoldur()
		{
			cmbMusteri.DataSource = db.Musteriler.Select(m => new
			{
				m.MusteriID,
				m.AdSoyad
			}).ToList();
			cmbMusteri.DisplayMember = "AdSoyad";
			cmbMusteri.ValueMember = "MusteriID";

			cmbProje.DataSource = db.Projeler.Select(p => new
			{
				p.ProjeID,
				p.ProjeAdi
			}).ToList();
			cmbProje.DisplayMember = "ProjeAdi";
			cmbProje.ValueMember = "ProjeID";

			cmbEtkilesimTuru.Items.Clear();
			cmbEtkilesimTuru.Items.AddRange(new string[] { "Telefon Görüşmesi", "E-posta", "Toplantı", "Diğer" });
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			try
			{
				int secilenID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("EtkilesimID"));
				var etkilesim = db.Etkilesim.Find(secilenID);

				if (etkilesim != null)
				{
					cmbMusteri.SelectedValue = etkilesim.MusteriID;
					cmbProje.SelectedValue = etkilesim.ProjeID;
					dateEtkilesimTarihi.DateTime = etkilesim.Tarih.HasValue ? etkilesim.Tarih.Value : DateTime.Now;
					cmbEtkilesimTuru.Text = etkilesim.EtkilesimTuru;
					txtDetay.Text = etkilesim.Detay;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
