using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinéma
{
    class SalleCinema
    {

        private string titreFilm;
        private int nombrePlace;
        private double prixPlace;
        private int nombrePlaceNormal;
        private int nombrePlaceReduit;



        public SalleCinema(string TitreFilm, int NombrePlace, float PrixPlace, int NombrePlaceNormal, int NombrePlaceReduit, string titreFilm = null, int nombrePlace = 0, float prixPlace = 0, int nombrePlaceNormal = 0, int nombrePlaceReduit = 0)
        {

            this.TitreFilm = titreFilm;
            this.NombrePlace = nombrePlace;
            this.PrixPlace = prixPlace;
            this.NombrePlaceNormal = 0;
            this.NombrePlaceReduit = 0;
        }

        public string TitreFilm { get => titreFilm; set => titreFilm = value; }
        public int NombrePlace { get => nombrePlace; set => nombrePlace = value; }
        public double PrixPlace { get => prixPlace; set => prixPlace = value; }
        public int NombrePlaceNormal { get => nombrePlaceNormal; set => nombrePlaceNormal = value; }
        public int NombrePlaceReduit { get => nombrePlaceReduit; set => nombrePlaceReduit = value; }

        public int nbPlacesDisponibles()
        {
            return (this.nombrePlace - this.nombrePlaceNormal - this.nombrePlaceReduit);
        }
        public void vendrePlaces(int nbre, bool tarifReduit)
        {
            if (nbre <= this.nbPlacesDisponibles())
            {
                if (tarifReduit == true)
                {
                    this.nombrePlace = (this.nombrePlace - nbre);
                    this.NombrePlaceReduit += nbre;
                    label1.text = nbre + " places vendues " + (nbre * (this.PrixPlace * 0.2)) + " €";
                }
                else
                {
                    this.nombrePlace = (this.nombrePlace - nbre);
                    this.NombrePlaceNormal += nbre;
                    label1.text = nbre + " places vendues " + (nbre * this.PrixPlace) + " €";
                }
            }
            else
            {
                label1.text = "vente impossible";
            }

        }
    }
}
