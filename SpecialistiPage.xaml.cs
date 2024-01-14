using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace Salon_Infrumusetare2
{
    public partial class SpecialistiPage : ContentPage
    {
        public SpecialistiPage()
        {
            InitializeComponent();
            InitializeSpecialisti();
        }

        private void InitializeSpecialisti()
        {
            // Crearea unei liste de specialiști
            var specialisti = new List<Specialist>
            {
                new Specialist { Nume = "Ema Uta", Imagine = "emauta.png" },
                new Specialist { Nume = "Ana", Imagine = "gina.png" },
                new Specialist { Nume = "Carmen", Imagine = "carmen.png" }
            };

            // Aici poți alege să folosești un ListView, CollectionView etc., pentru a arăta specialiștii
            // De exemplu, dacă ai un ListView în XAML-ul tău, poți face:
            // listViewSpecialisti.ItemsSource = specialisti;
        }
    }

    // Clasa pentru a reprezenta un specialist
    public class Specialist
    {
        public string Nume { get; set; }
        public string Imagine { get; set; }
    }
}