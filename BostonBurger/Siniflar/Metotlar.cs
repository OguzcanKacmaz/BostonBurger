using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonBurger.Siniflar
{
    public static class Metotlar
    {
        public static void Temizle(Control.ControlCollection kontroller)
        {
            foreach (var kontrol in kontroller)
            {
                if (kontrol is ComboBox)
                    ((ComboBox)kontrol).SelectedIndex = 0;
                else if (kontrol is TextBox)
                    ((TextBox)kontrol).Text = "";
                else if (kontrol is RadioButton)
                    ((RadioButton)kontrol).Checked = default;
                else if (kontrol is NumericUpDown)
                    ((NumericUpDown)kontrol).Value = default;
                else if (kontrol is Panel)
                {
                    foreach (var panelKontrol in ((Panel)kontrol).Controls)
                    {
                        if (panelKontrol is CheckBox)
                            ((CheckBox)kontrol).Checked = false;
                    }
                }


            }
        }
    }
}
