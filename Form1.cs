using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLToExcel
{
    public partial class frmMain : Form
    {
        BindingList<TComplement> complements;
        BindingList<TComplement> complementsFiltres = new BindingList<TComplement>();
        BindingList<TComplement> dataSourceComplements = new BindingList<TComplement>();
        BindingList<TPlante> datasourcePlantes = new BindingList<TPlante>();
        BindingList<TObjectifEffet> datasourceObjectifsEffets = new BindingList<TObjectifEffet>();
        BindingList<TIngredientAutre> datasourceIngredientAutre = new BindingList<TIngredientAutre>();
        BindingList<TMicroOrganisme> datasourceMicroOrganisme = new BindingList<TMicroOrganisme>();
        BindingList<TPopulationARisque> datasourcePopulationARisque = new BindingList<TPopulationARisque>();
        BindingList<TPopulationCible> datasourcePopulationCible = new BindingList<TPopulationCible>();

        string cheminFichierXML = @".\ListeCompAlim.xml";
        string chemin = @"c:\";

        public frmMain()
        {
            InitializeComponent();

            this.BSComplements.DataSource = dataSourceComplements;

            chemin = Application.ExecutablePath;
        }


        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            if (!OuvrirFichier()) return;

            complements = new BindingList<TComplement>();

            //TObjectifEffet
            datasourceObjectifsEffets.Clear();
            datasourceObjectifsEffets.Add(new TObjectifEffet() { ObjectifEffet = "_Tous_" });
            //TIngredientAutre
            datasourceIngredientAutre.Clear();
            datasourceIngredientAutre.Add(new TIngredientAutre() { IdentIngredientAutre = "-1", NomIngredientAutre = "_Tous_" });
            //TPlante
            datasourcePlantes.Clear();
            datasourcePlantes.Add(new TPlante() { IdPlante = "-1", NomPlante = "_Toutes_" });
            //TMicroOrganisme
            datasourceMicroOrganisme.Clear();
            datasourceMicroOrganisme.Add(new TMicroOrganisme() { IdMicroOrga = "-1", GenreMicroOrga = "_Tous_" });
            //TPopulationARisque
            datasourcePopulationARisque.Clear();
            datasourcePopulationARisque.Add(new TPopulationARisque() { PopulationARisque = "_Toutes_" });
            //TPopulationCible
            datasourcePopulationCible.Clear();
            datasourcePopulationCible.Add(new TPopulationCible() { PopulationCible = "_Toutes_" });

            XmlDocument doc = new XmlDocument();
            Cursor = Cursors.WaitCursor;
            try
            {
                XmlTextReader reader = new XmlTextReader(cheminFichierXML);
                while (reader.Read())
                {
                    if (reader.Name.Equals("Complements"))
                    {
                        LireNoeud_Complements(doc.ReadNode(reader));

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de lecture du fichier : " + ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

            this.BSComplements.DataSource = complements.OrderBy(x => x.LongIdComplent).ToList();
            gridCtrl.RefreshDataSource();

            //Plantes
            this.BSPlantes.DataSource = datasourcePlantes.OrderBy(x => x.NomPlante).ToList(); ;
            cbxPlantes.Refresh();
            //Objectifs
            this.BSObjectifs.DataSource = datasourceObjectifsEffets.OrderBy(x => x.ObjectifEffet).ToList(); ;
            cbxObjectifs.Refresh();
            //Ingredients
            this.BSIngredients.DataSource = datasourceIngredientAutre.OrderBy(x => x.NomIngredientAutre).ToList(); ;
            cbxIngredients.Refresh();
            //MicroOrganismes
            this.BSMicroOrganismes.DataSource = datasourceMicroOrganisme.OrderBy(x => x.GenreEspeceMicroOrganisme).ToList(); ;
            cbxMicroOrganismes.Refresh();
            //population à risque
            this.BSPopulationARisque.DataSource = datasourcePopulationARisque.OrderBy(x => x.PopulationARisque).ToList(); ;
            cbxPopulationARisque.Refresh();
            //population cible
            this.BSPopulationCible.DataSource = datasourcePopulationCible.OrderBy(x => x.PopulationCible).ToList(); ;
            cbxPopulationCible.Refresh();

            Filtrer();
        }

        private bool OuvrirFichier()
        {
            openFileDialog1.InitialDirectory = chemin;
            openFileDialog1.Filter = "Liste complément|ListeCompAlim.xml|All xml files (*.xml)|*.xml";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = "ListeCompAlim.xml";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cheminFichierXML = openFileDialog1.FileName;
                FileInfo fichierInfos = new FileInfo(cheminFichierXML);
                chemin = fichierInfos.DirectoryName;

                return true;
            }
            return false;
        }

        private void LireNoeud_Complements(XmlNode pNode)
        {
            foreach (XmlNode sousnode in pNode.ChildNodes)
            {
                if (sousnode.Name == "Complement")
                {
                    LireNoeud_Complement(sousnode, complements);
                }
            }
        }

        private void LireNoeud_Complement(XmlNode pNode, BindingList<TComplement> pListe)
        {
            TComplement complement = new TComplement();
            pListe.Add(complement);

            foreach (XmlNode nodeChamp in pNode.ChildNodes)
            {
                if (nodeChamp.Name == "IdComplement") complement.IdComplement = nodeChamp.ChildNodes[0].InnerText;
                if (nodeChamp.Name == "NomCommercial") complement.NomCommercial = nodeChamp.ChildNodes[0].InnerText;
                if (nodeChamp.Name == "Marque") complement.Marque = nodeChamp.ChildNodes[0].InnerText;
                if (nodeChamp.Name == "FormeGalenique") complement.FormeGalenique = nodeChamp.ChildNodes[0].InnerText;
                if (nodeChamp.Name == "ResponsableEtiquetage") complement.ResponsableEtiquetage = nodeChamp.ChildNodes[0].InnerText;
                if (nodeChamp.Name == "DoseJournaliere") complement.DoseJournaliere = nodeChamp.ChildNodes[0].InnerText;
                if (nodeChamp.Name == "ModeEmploi") complement.ModeEmploi = nodeChamp.ChildNodes[0].InnerText;
                if (nodeChamp.Name == "Gamme") complement.Gamme = nodeChamp.ChildNodes[0].InnerText;
                if (nodeChamp.Name == "Aromes") complement.Aromes = nodeChamp.ChildNodes[0].InnerText;

                if (nodeChamp.Name == "ObjectifsEffets") LireNoeud_ObjectifsEffets(nodeChamp, complement.ObjectifsEffets);
                if (nodeChamp.Name == "Ingredients") LireNoeud_Ingredients(nodeChamp, complement);
                if (nodeChamp.Name == "PopulationsArisques") LireNoeud_PopulationsARisque(nodeChamp, complement.PopulationsARisque);
                if (nodeChamp.Name == "PopulationsCibles") LireNoeud_PopulationsCibles(nodeChamp, complement.PopulationsCible);
            }

        }

        private void LireNoeud_PopulationsCibles(XmlNode pNode, BindingList<TPopulationCible> pListe)
        {
            TPopulationCible Obj = new TPopulationCible();
            pListe.Add(Obj);
            foreach (XmlNode nodeChamp in pNode.ChildNodes)
            {
                if (nodeChamp.Name == "PopulationCible") Obj.PopulationCible = nodeChamp.ChildNodes[0].InnerText;
            }
            if (!datasourcePopulationCible.Any<TPopulationCible>(elt => elt.PopulationCible == Obj.PopulationCible)) datasourcePopulationCible.Add(Obj);

        }

        private void LireNoeud_PopulationsARisque(XmlNode pNode, BindingList<TPopulationARisque> pListe)
        {
            TPopulationARisque Obj = new TPopulationARisque();
            pListe.Add(Obj);
            foreach (XmlNode nodeChamp in pNode.ChildNodes)
            {
                if (nodeChamp.Name == "PopulationARisque") Obj.PopulationARisque = nodeChamp.ChildNodes[0].InnerText;
            }
            if (!datasourcePopulationARisque.Any<TPopulationARisque>(elt => elt.PopulationARisque == Obj.PopulationARisque)) datasourcePopulationARisque.Add(Obj);

        }

        private void LireNoeud_Ingredients(XmlNode pNode, TComplement pComplement)
        {
            foreach (XmlNode sousnode in pNode.ChildNodes)
            {
                if (sousnode.Name == "IngredientsAutres") LireNoeud_IngredientsAutres(sousnode, pComplement.IngredientsAutres);
                if (sousnode.Name == "Plantes") LireNoeud_Plantes(sousnode, pComplement.Plantes);
                if (sousnode.Name == "MicroOrganismes") LireNoeud_MicroOrganismes(sousnode, pComplement.MicroOrganismes);

            }
        }

        private void LireNoeud_MicroOrganismes(XmlNode pNode, BindingList<TMicroOrganisme> pListe)
        {
            foreach (XmlNode sousnode in pNode.ChildNodes)
            {
                if (sousnode.Name == "MicroOrganisme")
                {
                    LireNoeud_MicroOrganisme(sousnode, pListe);
                }
            }
        }

        private void LireNoeud_MicroOrganisme(XmlNode pNode, BindingList<TMicroOrganisme> pListe)
        {
            TMicroOrganisme Obj = new TMicroOrganisme();
            pListe.Add(Obj);
            foreach (XmlNode nodeChamp in pNode.ChildNodes)
            {
                if (nodeChamp.Name == "IdMicroOrga") Obj.IdMicroOrga = nodeChamp.ChildNodes[0].InnerText;
                if (nodeChamp.Name == "GenreMicroOrga") Obj.GenreMicroOrga = nodeChamp.ChildNodes[0].InnerText;
                if (nodeChamp.Name == "EspeceMicroOrga") Obj.EspeceMicroOrga = nodeChamp.ChildNodes[0].InnerText;
            }
            if (!datasourceMicroOrganisme.Any<TMicroOrganisme>(elt => elt.GenreMicroOrga == Obj.GenreMicroOrga && elt.EspeceMicroOrga == Obj.EspeceMicroOrga)) datasourceMicroOrganisme.Add(Obj);

        }

        private void LireNoeud_Plantes(XmlNode pNode, BindingList<TPlante> pListe)
        {
            foreach (XmlNode sousnode in pNode.ChildNodes)
            {
                if (sousnode.Name == "Plante")
                {
                    LireNoeud_Plante(sousnode, pListe);
                }
            }
        }

        private void LireNoeud_Plante(XmlNode pNode, BindingList<TPlante> pListe)
        {
            TPlante Obj = new TPlante();
            pListe.Add(Obj);
            foreach (XmlNode nodeChamp in pNode.ChildNodes)
            {
                if (nodeChamp.Name == "IdFamillePlante") Obj.IdFamillePlante = nodeChamp.ChildNodes[0].InnerText;
                if (nodeChamp.Name == "FamillePlante") Obj.FamillePlante = nodeChamp.ChildNodes[0].InnerText;
                if (nodeChamp.Name == "IdPlante") Obj.IdPlante = nodeChamp.ChildNodes[0].InnerText;
                if (nodeChamp.Name == "NomPlante") Obj.NomPlante = nodeChamp.ChildNodes[0].InnerText;
                if (nodeChamp.Name == "IdPartiePlante") Obj.IdPartiePlante = nodeChamp.ChildNodes[0].InnerText;
                if (nodeChamp.Name == "PartiePlante") Obj.PartiePlante = nodeChamp.ChildNodes[0].InnerText;
            }

            if (!datasourcePlantes.Any<TPlante>(elt => elt.NomPlante == Obj.NomPlante)) datasourcePlantes.Add(Obj);
        }

        private void LireNoeud_IngredientsAutres(XmlNode pNode, BindingList<TIngredientAutre> pListe)
        {
            foreach (XmlNode sousnode in pNode.ChildNodes)
            {
                if (sousnode.Name == "IngredientAutre")
                {
                    LireNoeud_IngredientAutre(sousnode, pListe);
                }
            }
        }

        private void LireNoeud_IngredientAutre(XmlNode pNode, BindingList<TIngredientAutre> pListe)
        {
            TIngredientAutre Obj = new TIngredientAutre();
            pListe.Add(Obj);
            foreach (XmlNode nodeChamp in pNode.ChildNodes)
            {
                if (nodeChamp.Name == "IdentIngredientAutre") Obj.IdentIngredientAutre = nodeChamp.ChildNodes[0].InnerText;
                if (nodeChamp.Name == "NomIngredientAutre") Obj.NomIngredientAutre = nodeChamp.ChildNodes[0].InnerText;
            }
            if (!datasourceIngredientAutre.Any<TIngredientAutre>(elt => elt.NomIngredientAutre == Obj.NomIngredientAutre)) datasourceIngredientAutre.Add(Obj);

        }

        private void LireNoeud_ObjectifsEffets(XmlNode pNode, BindingList<TObjectifEffet> pListe)
        {
            TObjectifEffet Obj = new TObjectifEffet();
            pListe.Add(Obj);
            foreach (XmlNode nodeChamp in pNode.ChildNodes)
            {
                if (nodeChamp.Name == "ObjectifEffet") Obj.ObjectifEffet = nodeChamp.ChildNodes[0].InnerText;
            }
            if (!datasourceObjectifsEffets.Any<TObjectifEffet>(elt => elt.ObjectifEffet == Obj.ObjectifEffet)) datasourceObjectifsEffets.Add(Obj);

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            string fichierExport = $@"{chemin}\ListeCompAlim_Export.xlsx";
            gridCtrl.ExportToXlsx(fichierExport);
            if (MessageBox.Show("Voulez-vous ouvrir le fichier", "Export terminé", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start(fichierExport);
            }
        }

        private void cbxPlantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrer();
        }

        private void Filtrer()
        {
            TPlante planteSelectionnee = (TPlante)cbxPlantes.SelectedItem;
            TObjectifEffet objectifSelectione = (TObjectifEffet)cbxObjectifs.SelectedItem;
            TIngredientAutre IngredientSelectione = (TIngredientAutre)cbxIngredients.SelectedItem;
            TMicroOrganisme MicroOrganismeSelectione = (TMicroOrganisme)cbxMicroOrganismes.SelectedItem;
            TPopulationARisque PopARisqueSelectionee = (TPopulationARisque)cbxPopulationARisque.SelectedItem;
            TPopulationCible PopCibleSelectionee = (TPopulationCible)cbxPopulationCible.SelectedItem;

            if (((planteSelectionnee == null || planteSelectionnee.IdPlante == "-1"))
                 && ((objectifSelectione == null || objectifSelectione.ObjectifEffet == "_Tous_"))
                 && ((IngredientSelectione == null || IngredientSelectione.IdentIngredientAutre == "-1"))
                 && ((MicroOrganismeSelectione == null || MicroOrganismeSelectione.IdMicroOrga == "-1"))
                 && ((PopARisqueSelectionee == null || PopARisqueSelectionee.PopulationARisque == "_Toutes_"))
                 && ((PopCibleSelectionee == null || PopCibleSelectionee.PopulationCible == "_Toutes_"))
               )
            {
                this.BSComplements.DataSource = complements;
            }
            else
            {
                complementsFiltres.Clear();
                this.BSComplements.DataSource = complementsFiltres;

                foreach (TComplement complement in complements)
                {
                    if ((planteSelectionnee == null || planteSelectionnee.IdPlante == "-1" || complement.Plantes.Any<TPlante>(elt => elt.NomPlante == planteSelectionnee.NomPlante))
                        && (objectifSelectione == null || objectifSelectione.ObjectifEffet == "_Tous_" || complement.ObjectifsEffets.Any<TObjectifEffet>(elt => elt.ObjectifEffet == objectifSelectione.ObjectifEffet))
                        && (IngredientSelectione == null || IngredientSelectione.IdentIngredientAutre == "-1" || complement.IngredientsAutres.Any<TIngredientAutre>(elt => elt.NomIngredientAutre == IngredientSelectione.NomIngredientAutre))
                        && (MicroOrganismeSelectione == null || MicroOrganismeSelectione.IdMicroOrga == "-1" || complement.MicroOrganismes.Any<TMicroOrganisme>(elt => elt.GenreEspeceMicroOrganisme == MicroOrganismeSelectione.GenreEspeceMicroOrganisme))
                        && (PopARisqueSelectionee == null || PopARisqueSelectionee.PopulationARisque == "_Toutes_" || complement.PopulationsARisque.Any<TPopulationARisque>(elt => elt.PopulationARisque == PopARisqueSelectionee.PopulationARisque))
                        && (PopCibleSelectionee == null || PopCibleSelectionee.PopulationCible == "_Toutes_" || complement.PopulationsCible.Any<TPopulationCible>(elt => elt.PopulationCible == PopCibleSelectionee.PopulationCible))
                       )
                    {
                        complementsFiltres.Add(complement);
                    }
                }
            }

            gridCtrl.RefreshDataSource();

        }

        private void cbxIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrer();
        }

        private void cbxMicroOrganismes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrer();
        }

        private void cbxObjectifs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrer();
        }

        private void cbxPopulationARisque_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrer();
        }

        private void cbxPopulationCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrer();
        }
    }
}
