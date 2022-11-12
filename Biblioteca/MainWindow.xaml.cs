using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Biblioteca
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        libro newLibro;
        string autore, titolo, editore;
        int anno, numPag;


        private void btnAddLibro_Click(object sender, RoutedEventArgs e)
        {
            autore = txtAutore.Text;
            titolo = txtTitolo.Text;
            editore = txtEditore.Text;
            anno = int.Parse(txtAnno.Text);
            numPag = int.Parse(txtAnno.Text);

            libro newLibro = new libro(autore, titolo, editore, anno, numPag);
        }
        #region mostra dati
        private void btnStampaTitolo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(newLibro.ShowTitolo(titolo));
        }

        private void btnStampaEditore_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(newLibro.ShowEditore(editore));
        }


        private void btnStampaNumPag_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(newLibro.ShowNumPag(numPag));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Non avevo tempo di far la parte della biblioteca");
        }

        private void btnStampaAnno_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(newLibro.ShowAnno(anno));
        }

        private void btnStampaAutore_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(newLibro.ShowAutore(autore));
        }
#endregion

        private void btnModifica_Click(object sender, RoutedEventArgs e)
        {
            string autoreMod = txtAutore.Text, titoloMod = txtTitolo.Text, editoreMod = txtEditore.Text;

            if (autoreMod.ToLower() == "nil")
            {
                //NIENTE
            }
            else
            {
                MessageBox.Show(newLibro.EditAutore(autoreMod));
            }

            if (titoloMod.ToLower() == "nil")
            {
                //NIENTE
            }
            else
            {
                MessageBox.Show(newLibro.EditTitolo(titoloMod));
            }

            if (editoreMod.ToLower() == "nil")
            {
                //NIENTE
            }
            else
            {
                MessageBox.Show(newLibro.EditEditore(editoreMod));
            }

            try
            {
                int annoMod = int.Parse(txtAnno.Text), numPagMod = int.Parse(txtNumPag.Text);
                MessageBox.Show(newLibro.EditAnno(annoMod));
                MessageBox.Show(newLibro.EditNumPag(numPagMod));
            }
            catch
            {

            }
           
        }
    }
}
