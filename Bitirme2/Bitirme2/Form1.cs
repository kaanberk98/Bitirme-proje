using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitirme2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BilgiDal _bilgiDal = new BilgiDal();
        List<Bilgi> isimler = new List<Bilgi>();
        List<Bilgi> şehirler = new List<Bilgi>();
        private Boolean checkparameters()
        {
            if(tbxname.Text != "" && tbxsurname.Text != "" && tbxage.Text != "" && tbxcity.Text != "")
                return true;
         
            return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            LoadBilgiler();
            isimler = _bilgiDal.GetAll3();
            şehirler = _bilgiDal.GetAll4();
        }
        private void LoadBilgiler()
        {
            dgwBilgiler.DataSource = _bilgiDal.GetAll();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (checkparameters())
            {
                _bilgiDal.Ekle(new Bilgi
                {
                    Name = tbxname.Text,
                    Surname = tbxsurname.Text,
                    Age = Convert.ToInt32(tbxage.Text),
                    City = tbxcity.Text,

                });
                LoadBilgiler();
                MessageBox.Show("Bilgi Eklendi!");
            }
            else
            {
                MessageBox.Show("Tüm alanları doldurunuz.");
            }
        }

        private void dgwBilgiler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxnameUpdate.Text = dgwBilgiler.CurrentRow.Cells[1].Value.ToString();
            tbxsurnameUpdate.Text = dgwBilgiler.CurrentRow.Cells[2].Value.ToString();
            tbxageUpdate.Text = dgwBilgiler.CurrentRow.Cells[3].Value.ToString();
            tbxcityUpdate.Text = dgwBilgiler.CurrentRow.Cells[4].Value.ToString();

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            Bilgi bilgi = new Bilgi
            {
                Id= Convert.ToInt32(dgwBilgiler.CurrentRow.Cells[0].Value),
                Name = tbxnameUpdate.Text,
                Surname = tbxsurnameUpdate.Text,
                Age = Convert.ToInt32(tbxageUpdate.Text),
                City = tbxcityUpdate.Text,
            };
            _bilgiDal.Güncelle(bilgi);
            LoadBilgiler();
            MessageBox.Show("Güncellendi!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwBilgiler.CurrentRow.Cells[0].Value);
            _bilgiDal.Sil(id);
            LoadBilgiler();
            MessageBox.Show("Silindi!");


        }

        private void btnRnd_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rastgelesayi = rnd.Next(isimler.Count);
            int rastgelesayi2 = rnd.Next(şehirler.Count);
            Bilgi bilgi = new Bilgi
            {
                Id = Convert.ToInt32(dgwBilgiler.CurrentRow.Cells[0].Value),
                Name = isimler[rastgelesayi].Name,
                Surname = tbxsurnameUpdate.Text,
                Age = Convert.ToInt32(tbxageUpdate.Text),
                City = şehirler[rastgelesayi2].Name,
            };
            _bilgiDal.Güncelle(bilgi);
            LoadBilgiler();
            MessageBox.Show("Güncellendi!");
        }
    }
}
