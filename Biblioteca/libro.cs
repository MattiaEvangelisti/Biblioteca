using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class libro
    {
        string autore, titolo, editore;
        int anno, numPag;

        int i = 0;
        List<string> listaLibri;

        public libro(string autore, string titolo, string editore, int anno, int numPag)
        {
            this.autore = autore;
            this.titolo = titolo;
            this.editore = editore;
            this.anno = anno;
            this.numPag = numPag;
            i++;
            listaLibri.Add(autore + "|" + titolo + "|" + editore + "|" + anno + "|" + numPag);
        }

        public string SearchTitolo(string titolo)
        {
            return titolo;
        }

        public string SearchLibri(string autore)
        {
            return autore;
        }

        public string NumLibri()
        {
            return ("Ci sono " + i.ToString() + " libro nella biblioteca");
        }

        public string toString()
        {
            return ("Autore: " + autore + "\nTitolo: " + titolo + "\nEditore: " + editore + "\nAnno di pubblicazione:" + anno + "\nNumero di pagine: " + numPag);
        }
        public void readingTime()
        {
            if (numPag < 100)
            {
                System.Windows.MessageBox.Show("Tempo di lettura: 1h");
            }
            else if (numPag > 100 && numPag < 200)
            {
                System.Windows.MessageBox.Show("Tempo di lettura: 2h");
            }
            else if (numPag > 200)
            {
                System.Windows.MessageBox.Show("Tempo di lettura: 2h+");
            }
        }
        //DISPLAY DEI DATI
        #region dati
        public void showTitolo()
        {
            System.Windows.MessageBox.Show(titolo.ToString());
        }
        public void showAutore()
        {
            System.Windows.MessageBox.Show(autore.ToString());
        }
        public void showEditore()
        {
            System.Windows.MessageBox.Show(editore.ToString());
        }
        public void showAnno()
        {
            System.Windows.MessageBox.Show(anno.ToString());
        }
        public void showNumPag()
        {
            System.Windows.MessageBox.Show(numPag.ToString());
        }
        //MODIFICA DEI DATI

        public void editTitolo(string titolo)
        {
            this.titolo = titolo;
            System.Windows.MessageBox.Show("Dato Modificato con successo.");
        }
        public void editAutore(string autore)
        {
            this.autore = autore;
            System.Windows.MessageBox.Show("Dato Modificato con successo.");
        }
        public void editEditore(string editore)
        {
            this.editore = editore;
            System.Windows.MessageBox.Show("Dato Modificato con successo.");
        }
        public void editAnno(int anno)
        {
            this.anno = anno;
            System.Windows.MessageBox.Show("Dato Modificato con successo.");
        }
        public void editNumPag(int numPag)
        {
            this.numPag = numPag;
            System.Windows.MessageBox.Show("Dato Modificato con successo.");
        }
        #endregion
    }
}
