//Ctrl+R+G tuşları ile kullanılmayan kütüphaneleri using'den kaldırabiilirsiniz.
using System;
using System.Linq;
using System.Windows.Forms;
using NTierMovie.BLL.Service;
using NTierMovie.DAL.Context.imdb;
using NTierMovie.WinForm.Tools;

namespace NTierMovie.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //MovieService movieService = new MovieService();
        sampleImdbEntities db = new sampleImdbEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            //listBox1.DisplayMember = "MovieName";
            //listBox1.ValueMember = "MovieID";
            //listBox1.DataSource = db.Movies;
            dataGridView1.DataSource = db.Movies.ToList();
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "MovieName";
            listBox1.DataSource = ImportData.ImportMovie();
        }
    }
}
