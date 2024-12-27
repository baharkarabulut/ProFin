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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void barButtonItem56_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

		}

		private void BtnYeniProje_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmYeniProje YeniProje= new FrmYeniProje();
			YeniProje.ShowDialog(); 
		}

		private void BtnYeniMusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmYeniMusteri YeniMusteri = new FrmYeniMusteri();
			YeniMusteri.ShowDialog();
		}
	}
}
