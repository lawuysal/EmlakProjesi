using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmlakProjesi
{
    internal class App
    {
        public static Ev evListesi = new Ev();
        public static void ilceleriYukle(ref ComboBox ilceComboBox, ref ComboBox semtComboBox)
        {
            string secilenIlce = ilceComboBox.SelectedItem.ToString() ?? "besiktas";
            List<string> semtler = new List<string>();

            using (StreamReader sr = new StreamReader("semtler\\" + secilenIlce + ".txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    semtler.Add(line);
                }
            }

            semtComboBox.Items.Clear();

            foreach (string semt in semtler)
            {
                semtComboBox.Items.Add(semt);
            }
        }
    }
}
