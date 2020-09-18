//Ctrl+R+G tuşları ile kullanılmayan kütüphaneleri using'den kaldırabiilirsiniz.
using System;
using System.Windows.Forms;
using NTierMovie.BLL.Service;


namespace NTierMovie.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MovieService movieService = new MovieService();
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "MovieName";
            listBox1.ValueMember = "MovieID";
            listBox1.DataSource = movieService.GetMovies();

        }
    }
}
