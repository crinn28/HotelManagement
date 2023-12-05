using Multi_Login.Models.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Login.Models.BusinessLogicLayer
{
    public class OfertaBLL
    {
        public ObservableCollection<Oferta> Oferte { get; set; }
        public ObservableCollection<Oferta> TipuriOferte { get; set; } = new ObservableCollection<Oferta>();
        public Oferta SelectedOferta { get; set; }
        //public string ErrorMessage { get; set; }

        OfertaDAL ofertaDAL = new OfertaDAL();

        public OfertaBLL()
        {
            Oferte = ofertaDAL.GetAllOferta();
        }

        public ObservableCollection<Oferta> GetAllOferta()
        {
            return ofertaDAL.GetAllOferta();
        }

        public void AddOferta(Oferta oferta, string numeClient, string email)
        {
            ofertaDAL.AddOferta(oferta,numeClient, email);
            Oferte.Add(oferta);
        }

        public void DeleteOferta(Oferta oferta)
        {
            ofertaDAL.DeleteOferta(oferta);
            Oferte.Remove(oferta);
        }

        public void ModifyOferta(Oferta oferta)
        {
            //ofertaDAL.ModifyOferta(oferta);
            //Oferte.Remove(oferta);
        }

        public void AddOfertaNoua(Oferta oferta)
        {
            ofertaDAL.AddOfertaNoua(oferta);

            TipuriOferte.Add(oferta);
        }

    }
}
