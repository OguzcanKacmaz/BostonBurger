using BostonBurger.Siniflar;

namespace BostonBurger
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }
        public void PencereyiGoster(Form acilacakForm)
        {
            bool durum = false;
            foreach (Form form in MdiChildren)
            {
                if (form.Text==acilacakForm.Text)
                {
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
                if (durum ==false)
                {
                    acilacakForm.MdiParent = this;
                    acilacakForm.Show();
                }
        }

        private void tsmiSiparisOlustur_Click(object sender, EventArgs e)
        {
            PencereyiGoster(new SiparisYonetimi());
        }

        private void tsmiSiparisBilgileri_Click(object sender, EventArgs e)
        {
            PencereyiGoster(new SiparisGoruntuleme());
        }

        private void tsmiMenuEkle_Click(object sender, EventArgs e)
        {
            PencereyiGoster(new MenuYonetimi());
        }

        private void tsmiEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            PencereyiGoster(new MalzemeYonetimi());

        }


    }
}