namespace XMLToExcel
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode5 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode6 = new DevExpress.XtraGrid.GridLevelNode();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gridCtrl = new DevExpress.XtraGrid.GridControl();
            this.BSComplements = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdComplement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomCommercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormeGalenique = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResponsableEtiquetage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoseJournaliere = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModeEmploi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGamme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAromes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPlantes = new System.Windows.Forms.ComboBox();
            this.BSPlantes = new System.Windows.Forms.BindingSource(this.components);
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.cbxObjectifs = new System.Windows.Forms.ComboBox();
            this.BSObjectifs = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cbxIngredients = new System.Windows.Forms.ComboBox();
            this.BSIngredients = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cbxMicroOrganismes = new System.Windows.Forms.ComboBox();
            this.BSMicroOrganismes = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cbxPopulationARisque = new System.Windows.Forms.ComboBox();
            this.BSPopulationARisque = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cbxPopulationCible = new System.Windows.Forms.ComboBox();
            this.BSPopulationCible = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSComplements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSPlantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSObjectifs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSMicroOrganismes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSPopulationARisque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSPopulationCible)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOuvrir.ImageKey = "Chantier.ico";
            this.btnOuvrir.ImageList = this.imageList1;
            this.btnOuvrir.Location = new System.Drawing.Point(15, 12);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(86, 62);
            this.btnOuvrir.TabIndex = 2;
            this.btnOuvrir.Text = "Charger fichier";
            this.btnOuvrir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Chantier.ico");
            this.imageList1.Images.SetKeyName(1, "excel.ico");
            // 
            // gridCtrl
            // 
            this.gridCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCtrl.DataSource = this.BSComplements;
            gridLevelNode1.RelationName = "ObjectifsEffets";
            gridLevelNode2.RelationName = "IngredientsAutres";
            gridLevelNode3.RelationName = "Plantes";
            gridLevelNode4.RelationName = "MicroOrganismes";
            gridLevelNode5.RelationName = "PopulationsARisque";
            gridLevelNode6.RelationName = "PopulationsCible";
            this.gridCtrl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode3,
            gridLevelNode4,
            gridLevelNode5,
            gridLevelNode6});
            this.gridCtrl.Location = new System.Drawing.Point(15, 102);
            this.gridCtrl.MainView = this.gridView1;
            this.gridCtrl.Name = "gridCtrl";
            this.gridCtrl.Size = new System.Drawing.Size(1163, 545);
            this.gridCtrl.TabIndex = 3;
            this.gridCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // BSComplements
            // 
            this.BSComplements.DataSource = typeof(XMLToExcel.TComplement);
            this.BSComplements.Filter = "";
            this.BSComplements.Sort = "IdComplement";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdComplement,
            this.colNomCommercial,
            this.colMarque,
            this.colFormeGalenique,
            this.colResponsableEtiquetage,
            this.colDoseJournaliere,
            this.colModeEmploi,
            this.colGamme,
            this.colAromes});
            this.gridView1.GridControl = this.gridCtrl;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdComplement", null, " : {0} complément(s) ")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colIdComplement
            // 
            this.colIdComplement.FieldName = "IdComplement";
            this.colIdComplement.Name = "colIdComplement";
            this.colIdComplement.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdComplement", "{0} compléments")});
            this.colIdComplement.Visible = true;
            this.colIdComplement.VisibleIndex = 0;
            // 
            // colNomCommercial
            // 
            this.colNomCommercial.FieldName = "NomCommercial";
            this.colNomCommercial.Name = "colNomCommercial";
            this.colNomCommercial.Visible = true;
            this.colNomCommercial.VisibleIndex = 1;
            // 
            // colMarque
            // 
            this.colMarque.FieldName = "Marque";
            this.colMarque.Name = "colMarque";
            this.colMarque.Visible = true;
            this.colMarque.VisibleIndex = 2;
            // 
            // colFormeGalenique
            // 
            this.colFormeGalenique.FieldName = "FormeGalenique";
            this.colFormeGalenique.Name = "colFormeGalenique";
            this.colFormeGalenique.Visible = true;
            this.colFormeGalenique.VisibleIndex = 3;
            // 
            // colResponsableEtiquetage
            // 
            this.colResponsableEtiquetage.FieldName = "ResponsableEtiquetage";
            this.colResponsableEtiquetage.Name = "colResponsableEtiquetage";
            this.colResponsableEtiquetage.Visible = true;
            this.colResponsableEtiquetage.VisibleIndex = 4;
            // 
            // colDoseJournaliere
            // 
            this.colDoseJournaliere.FieldName = "DoseJournaliere";
            this.colDoseJournaliere.Name = "colDoseJournaliere";
            this.colDoseJournaliere.Visible = true;
            this.colDoseJournaliere.VisibleIndex = 5;
            // 
            // colModeEmploi
            // 
            this.colModeEmploi.FieldName = "ModeEmploi";
            this.colModeEmploi.Name = "colModeEmploi";
            this.colModeEmploi.Visible = true;
            this.colModeEmploi.VisibleIndex = 6;
            // 
            // colGamme
            // 
            this.colGamme.FieldName = "Gamme";
            this.colGamme.Name = "colGamme";
            this.colGamme.Visible = true;
            this.colGamme.VisibleIndex = 7;
            // 
            // colAromes
            // 
            this.colAromes.FieldName = "Aromes";
            this.colAromes.Name = "colAromes";
            this.colAromes.Visible = true;
            this.colAromes.VisibleIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "sur une plante";
            // 
            // cbxPlantes
            // 
            this.cbxPlantes.DataSource = this.BSPlantes;
            this.cbxPlantes.DisplayMember = "NomPlante";
            this.cbxPlantes.FormattingEnabled = true;
            this.cbxPlantes.Location = new System.Drawing.Point(136, 17);
            this.cbxPlantes.Name = "cbxPlantes";
            this.cbxPlantes.Size = new System.Drawing.Size(434, 21);
            this.cbxPlantes.TabIndex = 5;
            this.cbxPlantes.ValueMember = "IdPlante";
            this.cbxPlantes.SelectedIndexChanged += new System.EventHandler(this.cbxPlantes_SelectedIndexChanged);
            // 
            // BSPlantes
            // 
            this.BSPlantes.DataSource = typeof(XMLToExcel.TPlante);
            this.BSPlantes.Sort = "NomPlante";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportExcel.ImageIndex = 1;
            this.btnExportExcel.ImageList = this.imageList1;
            this.btnExportExcel.Location = new System.Drawing.Point(1092, 12);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(86, 62);
            this.btnExportExcel.TabIndex = 6;
            this.btnExportExcel.Text = "Exporter";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // cbxObjectifs
            // 
            this.cbxObjectifs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxObjectifs.DataSource = this.BSObjectifs;
            this.cbxObjectifs.DisplayMember = "ObjectifEffet";
            this.cbxObjectifs.FormattingEnabled = true;
            this.cbxObjectifs.Location = new System.Drawing.Point(724, 16);
            this.cbxObjectifs.Name = "cbxObjectifs";
            this.cbxObjectifs.Size = new System.Drawing.Size(249, 21);
            this.cbxObjectifs.TabIndex = 8;
            this.cbxObjectifs.ValueMember = "IdPlante";
            this.cbxObjectifs.SelectedIndexChanged += new System.EventHandler(this.cbxObjectifs_SelectedIndexChanged);
            // 
            // BSObjectifs
            // 
            this.BSObjectifs.DataSource = typeof(XMLToExcel.TObjectifEffet);
            this.BSObjectifs.Sort = "ObjectifEffet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "sur un objectif";
            // 
            // cbxIngredients
            // 
            this.cbxIngredients.DataSource = this.BSIngredients;
            this.cbxIngredients.DisplayMember = "NomIngredientAutre";
            this.cbxIngredients.FormattingEnabled = true;
            this.cbxIngredients.Location = new System.Drawing.Point(135, 43);
            this.cbxIngredients.Name = "cbxIngredients";
            this.cbxIngredients.Size = new System.Drawing.Size(434, 21);
            this.cbxIngredients.TabIndex = 11;
            this.cbxIngredients.ValueMember = "IdPlante";
            this.cbxIngredients.SelectedIndexChanged += new System.EventHandler(this.cbxIngredients_SelectedIndexChanged);
            // 
            // BSIngredients
            // 
            this.BSIngredients.DataSource = typeof(XMLToExcel.TIngredientAutre);
            this.BSIngredients.Sort = "NomIngredientAutre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "sur un ingrédient";
            // 
            // cbxMicroOrganismes
            // 
            this.cbxMicroOrganismes.DataSource = this.BSMicroOrganismes;
            this.cbxMicroOrganismes.DisplayMember = "GenreEspeceMicroOrganisme";
            this.cbxMicroOrganismes.FormattingEnabled = true;
            this.cbxMicroOrganismes.Location = new System.Drawing.Point(136, 70);
            this.cbxMicroOrganismes.Name = "cbxMicroOrganismes";
            this.cbxMicroOrganismes.Size = new System.Drawing.Size(434, 21);
            this.cbxMicroOrganismes.TabIndex = 13;
            this.cbxMicroOrganismes.ValueMember = "IdPlante";
            this.cbxMicroOrganismes.SelectedIndexChanged += new System.EventHandler(this.cbxMicroOrganismes_SelectedIndexChanged);
            // 
            // BSMicroOrganismes
            // 
            this.BSMicroOrganismes.DataSource = typeof(XMLToExcel.TMicroOrganisme);
            this.BSMicroOrganismes.Sort = "GenreEspeceMicroOrganisme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "sur un micro-organisme";
            // 
            // cbxPopulationARisque
            // 
            this.cbxPopulationARisque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPopulationARisque.DataSource = this.BSPopulationARisque;
            this.cbxPopulationARisque.DisplayMember = "PopulationARisque";
            this.cbxPopulationARisque.FormattingEnabled = true;
            this.cbxPopulationARisque.Location = new System.Drawing.Point(724, 43);
            this.cbxPopulationARisque.Name = "cbxPopulationARisque";
            this.cbxPopulationARisque.Size = new System.Drawing.Size(249, 21);
            this.cbxPopulationARisque.TabIndex = 15;
            this.cbxPopulationARisque.ValueMember = "IdPlante";
            this.cbxPopulationARisque.SelectedIndexChanged += new System.EventHandler(this.cbxPopulationARisque_SelectedIndexChanged);
            // 
            // BSPopulationARisque
            // 
            this.BSPopulationARisque.DataSource = typeof(XMLToExcel.TPopulationARisque);
            this.BSPopulationARisque.Sort = "PopulationARisque";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "sur une population à risque";
            // 
            // cbxPopulationCible
            // 
            this.cbxPopulationCible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPopulationCible.DataSource = this.BSPopulationCible;
            this.cbxPopulationCible.DisplayMember = "PopulationCible";
            this.cbxPopulationCible.FormattingEnabled = true;
            this.cbxPopulationCible.Location = new System.Drawing.Point(724, 70);
            this.cbxPopulationCible.Name = "cbxPopulationCible";
            this.cbxPopulationCible.Size = new System.Drawing.Size(249, 21);
            this.cbxPopulationCible.TabIndex = 17;
            this.cbxPopulationCible.ValueMember = "IdPlante";
            this.cbxPopulationCible.SelectedIndexChanged += new System.EventHandler(this.cbxPopulationCible_SelectedIndexChanged);
            // 
            // BSPopulationCible
            // 
            this.BSPopulationCible.DataSource = typeof(XMLToExcel.TPopulationCible);
            this.BSPopulationCible.Sort = "PopulationCible";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(598, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "sur une population cible";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbxPlantes);
            this.groupBox1.Controls.Add(this.cbxPopulationCible);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbxIngredients);
            this.groupBox1.Controls.Add(this.cbxPopulationARisque);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxObjectifs);
            this.groupBox1.Controls.Add(this.cbxMicroOrganismes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(107, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 96);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrer";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 659);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.gridCtrl);
            this.Controls.Add(this.btnOuvrir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Comp. Alim. Reader";
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSComplements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSPlantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSObjectifs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSMicroOrganismes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSPopulationARisque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSPopulationCible)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOuvrir;
        private DevExpress.XtraGrid.GridControl gridCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource BSComplements;
        private DevExpress.XtraGrid.Columns.GridColumn colIdComplement;
        private DevExpress.XtraGrid.Columns.GridColumn colNomCommercial;
        private DevExpress.XtraGrid.Columns.GridColumn colMarque;
        private DevExpress.XtraGrid.Columns.GridColumn colFormeGalenique;
        private DevExpress.XtraGrid.Columns.GridColumn colResponsableEtiquetage;
        private DevExpress.XtraGrid.Columns.GridColumn colDoseJournaliere;
        private DevExpress.XtraGrid.Columns.GridColumn colModeEmploi;
        private DevExpress.XtraGrid.Columns.GridColumn colGamme;
        private DevExpress.XtraGrid.Columns.GridColumn colAromes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPlantes;
        private System.Windows.Forms.BindingSource BSPlantes;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cbxObjectifs;
        private System.Windows.Forms.BindingSource BSObjectifs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxIngredients;
        private System.Windows.Forms.BindingSource BSIngredients;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxMicroOrganismes;
        private System.Windows.Forms.BindingSource BSMicroOrganismes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxPopulationARisque;
        private System.Windows.Forms.BindingSource BSPopulationARisque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxPopulationCible;
        private System.Windows.Forms.BindingSource BSPopulationCible;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

