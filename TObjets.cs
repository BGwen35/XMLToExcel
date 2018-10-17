using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLToExcel
{
    class TComplement
    {
        public string IdComplement { get; set; }
        public string NomCommercial { get; set; }
        public string Marque { get; set; }
        public string FormeGalenique { get; set; }
        public string ResponsableEtiquetage { get; set; }
        public string DoseJournaliere { get; set; }
        public string ModeEmploi { get; set; }
        public string Gamme { get; set; }
        public string Aromes { get; set; }

        public long LongIdComplent
        {
            get
            {
                try
                {
                    return long.Parse(IdComplement);
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }


        public BindingList<TObjectifEffet> ObjectifsEffets { get; set; } = new BindingList<TObjectifEffet>();
        public BindingList<TIngredientAutre> IngredientsAutres { get; set; } = new BindingList<TIngredientAutre>();
        public BindingList<TPlante> Plantes { get; set; } = new BindingList<TPlante>();
        public BindingList<TMicroOrganisme> MicroOrganismes { get; set; } = new BindingList<TMicroOrganisme>();
        public BindingList<TPopulationARisque> PopulationsARisque { get; set; } = new BindingList<TPopulationARisque>();
        public BindingList<TPopulationCible> PopulationsCible { get; set; } = new BindingList<TPopulationCible>();

        public string Filtre { get; set; } = "KO";

        public override string ToString() { return $@"({IdComplement}) {NomCommercial} / {Marque}"; }

    }

    class TObjectifEffet
    {
        public string ObjectifEffet { get; set; }
    }

    class TIngredientAutre
    {
        public string IdentIngredientAutre { get; set; }
        public string NomIngredientAutre { get; set; }

    }

    class TPlante
    {
        public string IdFamillePlante { get; set; }
        public string FamillePlante { get; set; }
        public string IdPlante { get; set; }
        public string NomPlante { get; set; }
        public string IdPartiePlante { get; set; }
        public string PartiePlante { get; set; }
    }

    class TMicroOrganisme
    {
        public string IdMicroOrga { get; set; }
        public string GenreMicroOrga { get; set; }
        public string EspeceMicroOrga { get; set; }

        public string GenreEspeceMicroOrganisme { get { return $@"{GenreMicroOrga}/{EspeceMicroOrga}"; } }

    }

    class TPopulationARisque
    {
        public string PopulationARisque { get; set; }
    }



    class TPopulationCible
    {
        public string PopulationCible { get; set; }
    }

}
