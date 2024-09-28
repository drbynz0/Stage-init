using System.Windows.Forms;

namespace winForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null; 

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            ModePassation = new ComboBox();
            CategoriePrincipale = new ComboBox();
            DateStart = new DateTimePicker();
            label1 = new Label();
            DateEnd = new DateTimePicker();
            LancerRecherche = new Button();
            TotalNumber = new NumericUpDown();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            LogoSite1 = new PictureBox();
            DrapeauMa = new PictureBox();
            IconFiltre = new PictureBox();
            IconRech = new PictureBox();
            LabelIconRet = new Label();
            IconRet = new PictureBox();
            NbResult = new Label();
            LabelNbResult = new Label();
            FiltrerTextBox = new TextBox();
            FiltrerButton = new Button();
            ValeurParDefaut = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            numListDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            procedureDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categorieDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            datePublicationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            referenceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            objetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estimation = new DataGridViewTextBoxColumn();
            caution = new DataGridViewTextBoxColumn();
            acheteurPublicDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lieuExecutionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateLimiteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            heureLimite = new DataGridViewTextBoxColumn();
            Consultation = new DataGridViewButtonColumn();
            appelOffreDtoBindingSource = new BindingSource(components);
            SaveFile = new Button();
            Clear = new Button();
            IconSupp = new PictureBox();
            IconExp = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)TotalNumber).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoSite1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DrapeauMa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconFiltre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconRech).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconRet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appelOffreDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconSupp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconExp).BeginInit();
            SuspendLayout();
            // 
            // ModePassation
            // 
            resources.ApplyResources(ModePassation, "ModePassation");
            ModePassation.FormattingEnabled = true;
            ModePassation.Items.AddRange(new object[] { resources.GetString("ModePassation.Items"), resources.GetString("ModePassation.Items1"), resources.GetString("ModePassation.Items2"), resources.GetString("ModePassation.Items3"), resources.GetString("ModePassation.Items4"), resources.GetString("ModePassation.Items5"), resources.GetString("ModePassation.Items6"), resources.GetString("ModePassation.Items7"), resources.GetString("ModePassation.Items8"), resources.GetString("ModePassation.Items9"), resources.GetString("ModePassation.Items10"), resources.GetString("ModePassation.Items11"), resources.GetString("ModePassation.Items12"), resources.GetString("ModePassation.Items13"), resources.GetString("ModePassation.Items14"), resources.GetString("ModePassation.Items15"), resources.GetString("ModePassation.Items16"), resources.GetString("ModePassation.Items17"), resources.GetString("ModePassation.Items18"), resources.GetString("ModePassation.Items19"), resources.GetString("ModePassation.Items20"), resources.GetString("ModePassation.Items21") });
            ModePassation.Name = "ModePassation";
            // 
            // CategoriePrincipale
            // 
            resources.ApplyResources(CategoriePrincipale, "CategoriePrincipale");
            CategoriePrincipale.FormattingEnabled = true;
            CategoriePrincipale.Items.AddRange(new object[] { resources.GetString("CategoriePrincipale.Items"), resources.GetString("CategoriePrincipale.Items1"), resources.GetString("CategoriePrincipale.Items2") });
            CategoriePrincipale.Name = "CategoriePrincipale";
            // 
            // DateStart
            // 
            resources.ApplyResources(DateStart, "DateStart");
            DateStart.Name = "DateStart";
            DateStart.Value = new DateTime(2024, 8, 26, 0, 0, 0, 0);
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // DateEnd
            // 
            resources.ApplyResources(DateEnd, "DateEnd");
            DateEnd.Name = "DateEnd";
            DateEnd.Value = new DateTime(2024, 8, 26, 0, 0, 0, 0);
            // 
            // LancerRecherche
            // 
            resources.ApplyResources(LancerRecherche, "LancerRecherche");
            LancerRecherche.BackColor = Color.FromArgb(192, 192, 255);
            LancerRecherche.Name = "LancerRecherche";
            LancerRecherche.UseVisualStyleBackColor = false;
            LancerRecherche.Click += LancerRecherche_Click;
            // 
            // TotalNumber
            // 
            resources.ApplyResources(TotalNumber, "TotalNumber");
            TotalNumber.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            TotalNumber.Name = "TotalNumber";
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.BackColor = Color.Wheat;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(LogoSite1);
            groupBox1.Controls.Add(DrapeauMa);
            groupBox1.Controls.Add(IconFiltre);
            groupBox1.Controls.Add(IconRech);
            groupBox1.Controls.Add(LabelIconRet);
            groupBox1.Controls.Add(IconRet);
            groupBox1.Controls.Add(NbResult);
            groupBox1.Controls.Add(LabelNbResult);
            groupBox1.Controls.Add(FiltrerTextBox);
            groupBox1.Controls.Add(FiltrerButton);
            groupBox1.Controls.Add(ValeurParDefaut);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TotalNumber);
            groupBox1.Controls.Add(LancerRecherche);
            groupBox1.Controls.Add(DateEnd);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(DateStart);
            groupBox1.Controls.Add(CategoriePrincipale);
            groupBox1.Controls.Add(ModePassation);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.logo_site22;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // LogoSite1
            // 
            resources.ApplyResources(LogoSite1, "LogoSite1");
            LogoSite1.Image = Properties.Resources.logo_site1;
            LogoSite1.Name = "LogoSite1";
            LogoSite1.TabStop = false;
            // 
            // DrapeauMa
            // 
            resources.ApplyResources(DrapeauMa, "DrapeauMa");
            DrapeauMa.Image = Properties.Resources.drapeau_ma;
            DrapeauMa.Name = "DrapeauMa";
            DrapeauMa.TabStop = false;
            // 
            // IconFiltre
            // 
            resources.ApplyResources(IconFiltre, "IconFiltre");
            IconFiltre.BackColor = Color.White;
            IconFiltre.Image = Properties.Resources.icon_filt;
            IconFiltre.Name = "IconFiltre";
            IconFiltre.TabStop = false;
            // 
            // IconRech
            // 
            resources.ApplyResources(IconRech, "IconRech");
            IconRech.BackColor = Color.FromArgb(192, 192, 255);
            IconRech.Image = Properties.Resources.icon_rech;
            IconRech.Name = "IconRech";
            IconRech.TabStop = false;
            // 
            // LabelIconRet
            // 
            resources.ApplyResources(LabelIconRet, "LabelIconRet");
            LabelIconRet.Name = "LabelIconRet";
            // 
            // IconRet
            // 
            resources.ApplyResources(IconRet, "IconRet");
            IconRet.Cursor = Cursors.Hand;
            IconRet.Image = Properties.Resources.icon_ret;
            IconRet.Name = "IconRet";
            IconRet.TabStop = false;
            IconRet.Click += IconRet_Click;
            // 
            // NbResult
            // 
            resources.ApplyResources(NbResult, "NbResult");
            NbResult.BorderStyle = BorderStyle.Fixed3D;
            NbResult.Name = "NbResult";
            // 
            // LabelNbResult
            // 
            resources.ApplyResources(LabelNbResult, "LabelNbResult");
            LabelNbResult.Name = "LabelNbResult";
            // 
            // FiltrerTextBox
            // 
            resources.ApplyResources(FiltrerTextBox, "FiltrerTextBox");
            FiltrerTextBox.ForeColor = Color.DarkSlateGray;
            FiltrerTextBox.Name = "FiltrerTextBox";
            // 
            // FiltrerButton
            // 
            resources.ApplyResources(FiltrerButton, "FiltrerButton");
            FiltrerButton.BackColor = Color.White;
            FiltrerButton.Name = "FiltrerButton";
            FiltrerButton.UseVisualStyleBackColor = false;
            FiltrerButton.Click += Filtrer_Click;
            // 
            // ValeurParDefaut
            // 
            resources.ApplyResources(ValeurParDefaut, "ValeurParDefaut");
            ValeurParDefaut.BackColor = Color.FromArgb(255, 192, 128);
            ValeurParDefaut.Name = "ValeurParDefaut";
            ValeurParDefaut.UseVisualStyleBackColor = false;
            ValeurParDefaut.Click += button1_Click;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { numListDataGridViewTextBoxColumn, procedureDataGridViewTextBoxColumn, categorieDataGridViewTextBoxColumn, datePublicationDataGridViewTextBoxColumn, referenceDataGridViewTextBoxColumn, objetDataGridViewTextBoxColumn, estimation, caution, acheteurPublicDataGridViewTextBoxColumn, lieuExecutionDataGridViewTextBoxColumn, dateLimiteDataGridViewTextBoxColumn, heureLimite, Consultation });
            dataGridView1.DataSource = appelOffreDtoBindingSource;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // numListDataGridViewTextBoxColumn
            // 
            numListDataGridViewTextBoxColumn.DataPropertyName = "NumList";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            numListDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(numListDataGridViewTextBoxColumn, "numListDataGridViewTextBoxColumn");
            numListDataGridViewTextBoxColumn.Name = "numListDataGridViewTextBoxColumn";
            numListDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procedureDataGridViewTextBoxColumn
            // 
            procedureDataGridViewTextBoxColumn.DataPropertyName = "Procedure";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            procedureDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(procedureDataGridViewTextBoxColumn, "procedureDataGridViewTextBoxColumn");
            procedureDataGridViewTextBoxColumn.Name = "procedureDataGridViewTextBoxColumn";
            procedureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            categorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            categorieDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(categorieDataGridViewTextBoxColumn, "categorieDataGridViewTextBoxColumn");
            categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            categorieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datePublicationDataGridViewTextBoxColumn
            // 
            datePublicationDataGridViewTextBoxColumn.DataPropertyName = "DatePublication";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datePublicationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(datePublicationDataGridViewTextBoxColumn, "datePublicationDataGridViewTextBoxColumn");
            datePublicationDataGridViewTextBoxColumn.Name = "datePublicationDataGridViewTextBoxColumn";
            datePublicationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // referenceDataGridViewTextBoxColumn
            // 
            referenceDataGridViewTextBoxColumn.DataPropertyName = "Reference";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            referenceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(referenceDataGridViewTextBoxColumn, "referenceDataGridViewTextBoxColumn");
            referenceDataGridViewTextBoxColumn.Name = "referenceDataGridViewTextBoxColumn";
            referenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // objetDataGridViewTextBoxColumn
            // 
            objetDataGridViewTextBoxColumn.DataPropertyName = "Objet";
            resources.ApplyResources(objetDataGridViewTextBoxColumn, "objetDataGridViewTextBoxColumn");
            objetDataGridViewTextBoxColumn.Name = "objetDataGridViewTextBoxColumn";
            objetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estimation
            // 
            estimation.DataPropertyName = "Estimation";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            estimation.DefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(estimation, "estimation");
            estimation.Name = "estimation";
            // 
            // caution
            // 
            caution.DataPropertyName = "Caution";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            caution.DefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(caution, "caution");
            caution.Name = "caution";
            // 
            // acheteurPublicDataGridViewTextBoxColumn
            // 
            acheteurPublicDataGridViewTextBoxColumn.DataPropertyName = "AcheteurPublic";
            resources.ApplyResources(acheteurPublicDataGridViewTextBoxColumn, "acheteurPublicDataGridViewTextBoxColumn");
            acheteurPublicDataGridViewTextBoxColumn.Name = "acheteurPublicDataGridViewTextBoxColumn";
            acheteurPublicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lieuExecutionDataGridViewTextBoxColumn
            // 
            lieuExecutionDataGridViewTextBoxColumn.DataPropertyName = "LieuExecution";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            lieuExecutionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            resources.ApplyResources(lieuExecutionDataGridViewTextBoxColumn, "lieuExecutionDataGridViewTextBoxColumn");
            lieuExecutionDataGridViewTextBoxColumn.Name = "lieuExecutionDataGridViewTextBoxColumn";
            lieuExecutionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateLimiteDataGridViewTextBoxColumn
            // 
            dateLimiteDataGridViewTextBoxColumn.DataPropertyName = "DateLimite";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateLimiteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            resources.ApplyResources(dateLimiteDataGridViewTextBoxColumn, "dateLimiteDataGridViewTextBoxColumn");
            dateLimiteDataGridViewTextBoxColumn.Name = "dateLimiteDataGridViewTextBoxColumn";
            dateLimiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heureLimite
            // 
            heureLimite.DataPropertyName = "HeureLimite";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            heureLimite.DefaultCellStyle = dataGridViewCellStyle11;
            resources.ApplyResources(heureLimite, "heureLimite");
            heureLimite.Name = "heureLimite";
            heureLimite.ReadOnly = true;
            // 
            // Consultation
            // 
            resources.ApplyResources(Consultation, "Consultation");
            Consultation.Name = "Consultation";
            Consultation.ReadOnly = true;
            Consultation.Resizable = DataGridViewTriState.True;
            Consultation.SortMode = DataGridViewColumnSortMode.Automatic;
            Consultation.Text = "Télécharger";
            Consultation.UseColumnTextForButtonValue = true;
            // 
            // appelOffreDtoBindingSource
            // 
            appelOffreDtoBindingSource.DataSource = typeof(AppelOffreDto);
            // 
            // SaveFile
            // 
            resources.ApplyResources(SaveFile, "SaveFile");
            SaveFile.BackColor = Color.LightGreen;
            SaveFile.Name = "SaveFile";
            SaveFile.UseVisualStyleBackColor = false;
            SaveFile.Click += SaveFile_Click;
            // 
            // Clear
            // 
            resources.ApplyResources(Clear, "Clear");
            Clear.BackColor = Color.IndianRed;
            Clear.Name = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // IconSupp
            // 
            resources.ApplyResources(IconSupp, "IconSupp");
            IconSupp.BackColor = Color.IndianRed;
            IconSupp.Image = Properties.Resources.icon_supp;
            IconSupp.Name = "IconSupp";
            IconSupp.TabStop = false;
            // 
            // IconExp
            // 
            resources.ApplyResources(IconExp, "IconExp");
            IconExp.BackColor = Color.LightGreen;
            IconExp.Image = Properties.Resources.icon_exp;
            IconExp.Name = "IconExp";
            IconExp.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.Gainsboro;
            Controls.Add(IconExp);
            Controls.Add(IconSupp);
            Controls.Add(Clear);
            Controls.Add(SaveFile);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            TransparencyKey = Color.Gray;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)TotalNumber).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoSite1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DrapeauMa).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconFiltre).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconRech).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconRet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)appelOffreDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconSupp).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconExp).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox ModePassation;
        private ComboBox CategoriePrincipale;
        private DateTimePicker DateStart;
        private Label label1;
        private DateTimePicker DateEnd;
        private Button LancerRecherche;
        private NumericUpDown TotalNumber;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private Button SaveFile;
        private Button Clear;
        private Button ValeurParDefaut;
        private Button FiltrerButton;
        private BindingSource appelOffreDtoBindingSource;
        private TextBox FiltrerTextBox;
        private Label LabelNbResult;
        private Label NbResult;
        private DataGridViewTextBoxColumn numListDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn procedureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datePublicationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn referenceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn objetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estimation;
        private DataGridViewTextBoxColumn caution;
        private DataGridViewTextBoxColumn acheteurPublicDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lieuExecutionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateLimiteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn heureLimite;
        private DataGridViewButtonColumn Consultation;
        private PictureBox IconRet;
        private Label LabelIconRet;
        private PictureBox IconFiltre;
        private PictureBox IconRech;
        private PictureBox IconSupp;
        private PictureBox IconExp;
        private PictureBox DrapeauMa;
        private PictureBox LogoSite1;
        private PictureBox pictureBox1;
    }
}
