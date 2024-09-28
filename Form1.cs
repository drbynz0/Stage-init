using ClosedXML.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Extensions.Options;
using Excel = Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Bibliography;
using static System.Windows.Forms.DataFormats;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace winForms

{

    public partial class Form1 : Form
    {

        private List<AppelOffreDto> resultsList = new List<AppelOffreDto>();
        private List<AppelOffreDto> filtreList = new List<AppelOffreDto>();


        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = null;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["ProcedureOptions"].Value = ModePassation.SelectedItem?.ToString() ?? "";
            config.AppSettings.Settings["CategoriePrincipale"].Value = CategoriePrincipale.SelectedItem?.ToString() ?? "";
            config.AppSettings.Settings["DateStart"].Value = DateStart.Value.ToString("dd/MM/yyyy");
            config.AppSettings.Settings["DateEnd"].Value = DateEnd.Value.ToString("dd/MM/yyyy");
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            MessageBox.Show("Modifications enregistré");
        }



        private void LancerRecherche_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            //string driverPath = ConfigurationManager.AppSettings["DriverPath"] ?? "";
            string outputPath = ConfigurationManager.AppSettings["OutputPath"] ?? "";
            string modePassation = ModePassation.SelectedItem?.ToString() ?? "";
            string categoriePrincipale = CategoriePrincipale.SelectedItem?.ToString() ?? "";
            string dateStart = DateStart.Value.ToString("dd/MM/yyyy");
            string dateEnd = DateEnd.Value.ToString("dd/MM/yyyy");
            string pageSize = ConfigurationManager.AppSettings["PageSize"] ?? "";
            int totalNumber = (int)TotalNumber.Value;

            var service = ChromeDriverService.CreateDefaultService();
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--window-size=1920,1080");
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            new DriverManager().SetUpDriver(new ChromeConfig());
            service.HideCommandPromptWindow = true;
            var resultat = new ChromeDriver(service, options);

            using (resultat)
            {
                resultat.Navigate().GoToUrl("https://www.marchespublics.gov.ma/index.php?page=entreprise.EntrepriseAdvancedSearch&searchAnnCons");

                IWebElement travaux = resultat.FindElement(By.CssSelector(".main-part"));

                // Interagir avec les éléments sur la page

                IWebElement passationOptions = travaux.FindElement(By.Id("ctl0_CONTENU_PAGE_AdvancedSearch_procedureType"));
                SelectElement selectPassation = new SelectElement(passationOptions);
                selectPassation.SelectByText(modePassation.Trim());


                IWebElement categorieOptions = travaux.FindElement(By.Id("ctl0_CONTENU_PAGE_AdvancedSearch_categorie"));
                SelectElement selectCategorie = new SelectElement(categorieOptions);
                selectCategorie.SelectByText(categoriePrincipale.Trim());

                IWebElement checkboxNone = travaux.FindElement(By.Id("ctl0_CONTENU_PAGE_AdvancedSearch_idAtexoLtRefRadio_RepeaterReferentielRadio_ctl0_OptionNon_label"));
                ((IJavaScriptExecutor)resultat).ExecuteScript("arguments[0].scrollIntoView(true);", checkboxNone);
                checkboxNone.Click();


                IWebElement dateDebut = travaux.FindElement(By.Id("ctl0_CONTENU_PAGE_AdvancedSearch_dateMiseEnLigneStart"));
                dateDebut.Clear();
                dateDebut.SendKeys(dateStart.Trim());

                IWebElement dateFin = travaux.FindElement(By.Id("ctl0_CONTENU_PAGE_AdvancedSearch_dateMiseEnLigneEnd"));
                dateFin.Clear();
                dateFin.SendKeys(dateEnd.Trim());
                IWebElement dateMiseEnligne1 = travaux.FindElement(By.Id("ctl0_CONTENU_PAGE_AdvancedSearch_dateMiseEnLigneCalculeStart"));
                dateMiseEnligne1.Clear();
                IWebElement dateMiseEnligne2 = travaux.FindElement(By.Id("ctl0_CONTENU_PAGE_AdvancedSearch_dateMiseEnLigneCalculeEnd"));
                dateMiseEnligne2.Clear();

                Console.WriteLine("Date début: " + dateStart.Trim());
                Console.WriteLine("Date fin: " + dateEnd.Trim());

                IWebElement lancerRecherche = travaux.FindElement(By.Id("ctl0_CONTENU_PAGE_AdvancedSearch_lancerRecherche"));
                lancerRecherche.Click();

                DialogResult alert = DialogResult;
                try
                {

                    IWebElement MaxResult = resultat.FindElement(By.Id("ctl0_CONTENU_PAGE_resultSearch_listePageSizeTop"));
                    SelectElement selectMax = new SelectElement(MaxResult);
                    selectMax.SelectByValue(pageSize.Trim());
                    resultsList.Clear();
                    dataGridView1.DataSource = null;
                }
                catch (NoSuchElementException)
                {
                    this.Cursor = Cursors.Default;
                    alert = MessageBox.Show("Aucun résultats disponible", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (alert == DialogResult.Yes)
                {
                    resultat.Quit();
                }


                IReadOnlyCollection<IWebElement> resultatsRecherche = resultat.FindElements(By.XPath("//*[@id='tabNav']/div[2]/div[2]"));


                foreach (IWebElement Result in resultatsRecherche)
                {
                    try
                    {
                        string numList = "1";
                        string procedure = Result.FindElement(By.XPath("//*[@id='tabNav']/div[2]/div[2]/table/tbody/tr[1]/td[2]/div[1]")).Text.Trim();
                        string categorie = Result.FindElement(By.XPath("//*[@id='ctl0_CONTENU_PAGE_resultSearch_tableauResultSearch_ctl1_panelBlocCategorie']")).Text.Trim();
                        string datePublication = Result.FindElement(By.XPath("//*[@id='tabNav']/div[2]/div[2]/table/tbody/tr[1]/td[2]/div[4]")).Text.Trim();
                        string reference = Result.FindElement(By.XPath("//*[@id='ctl0_CONTENU_PAGE_resultSearch_tableauResultSearch_ctl1_reference']")).Text.Trim();
                        string objetAll = Result.FindElement(By.XPath("//*[@id='ctl0_CONTENU_PAGE_resultSearch_tableauResultSearch_ctl1_panelBlocObjet']")).Text.Trim();
                        int objet = objetAll.IndexOf(' ');
                        string acheteurPublicAll = Result.FindElement(By.XPath("//*[@id='ctl0_CONTENU_PAGE_resultSearch_tableauResultSearch_ctl1_panelBlocDenomination']")).Text.Trim();
                        int acheteurPublic = acheteurPublicAll.IndexOf(':');
                        string lieuExecution = Result.FindElement(By.XPath("//*[@id='ctl0_CONTENU_PAGE_resultSearch_tableauResultSearch_ctl1_panelBlocLieuxExec']")).Text.Trim();
                        string dateLimiteAll = Result.FindElement(By.XPath("//*[@id=\'tabNav\']/div[2]/div[2]/table/tbody/tr[1]/td[5]/div[1]/div")).Text.Trim();
                        string[] dateLimite = dateLimiteAll.Split("\n");

                        var appelOffre = new AppelOffreDto
                        {
                            NumList = numList,
                            Procedure = procedure,
                            Categorie = categorie,
                            DatePublication = datePublication,
                            Reference = reference,
                            Objet = objetAll.Substring(objet + 2).Trim(),
                            Estimation = "A saisir",
                            Caution = "A saisir",
                            AcheteurPublic = acheteurPublicAll.Substring(acheteurPublic + 1).Trim(),
                            LieuExecution = lieuExecution,
                            DateLimite = dateLimite[0].Trim(),
                            HeureLimite = dateLimite[1].Trim()
                        };
                        resultsList.Add(appelOffre);


                    }
                    catch (NoSuchElementException)
                    {
                        continue;
                    }
                }

                int i;
                foreach (IWebElement OtherResult in resultatsRecherche)
                {

                    try
                    {

                        for (i = 2; i <= totalNumber; i++)
                        {

                            // Collection des resultats de recherche des autres lignes
                            string numList = $"{i}";
                            string procedure = OtherResult.FindElement(By.ClassName("line-info-bulle")).Text.Trim();
                            string categorie = OtherResult.FindElement(By.XPath($"//*[@id='ctl0_CONTENU_PAGE_resultSearch_tableauResultSearch_ctl{i}_panelBlocCategorie']")).Text.Trim();
                            string datePublication = OtherResult.FindElement(By.XPath($"//*[@id='tabNav']/div[2]/div[2]/table/tbody/tr[{i}]/td[2]/div[4]")).Text.Trim();
                            string reference = OtherResult.FindElement(By.XPath($"//*[@id=\'ctl0_CONTENU_PAGE_resultSearch_tableauResultSearch_ctl{i}_reference\']")).Text.Trim();
                            string objetAll = OtherResult.FindElement(By.XPath($"//*[@id='ctl0_CONTENU_PAGE_resultSearch_tableauResultSearch_ctl{i}_panelBlocObjet']")).Text.Trim();
                            int objet = objetAll.IndexOf(' ');
                            string acheteurPublicAll = OtherResult.FindElement(By.XPath($"//*[@id='ctl0_CONTENU_PAGE_resultSearch_tableauResultSearch_ctl{i}_panelBlocDenomination']")).Text.Trim();
                            int acheteurPublic = acheteurPublicAll.IndexOf(':');
                            string lieuExecution = OtherResult.FindElement(By.XPath($"//*[@id='ctl0_CONTENU_PAGE_resultSearch_tableauResultSearch_ctl{i}_panelBlocLieuxExec']")).Text.Trim();
                            string dateLimiteAll = OtherResult.FindElement(By.XPath($"//*[@id=\'tabNav\']/div[2]/div[2]/table/tbody/tr[{i}]/td[5]/div[1]/div")).Text.Trim();
                            string[] dateLimite = dateLimiteAll.Split("\n");

                            var appelOffre = new AppelOffreDto
                            {
                                NumList = $"{i}",
                                Procedure = procedure,
                                Categorie = categorie,
                                DatePublication = datePublication,
                                Reference = reference,
                                Objet = objetAll.Substring(objet + 2).Trim(),
                                Estimation = "A saisir",
                                Caution = "A saisir",
                                AcheteurPublic = acheteurPublicAll.Substring(acheteurPublic + 1).Trim(),
                                LieuExecution = lieuExecution,
                                DateLimite = dateLimite[0].Trim(),
                                HeureLimite = dateLimite[1].Trim()
                            };
                            resultsList.Add(appelOffre);


                        }
                    }
                    catch (NoSuchElementException)
                    {
                        continue;
                    }

                }


                dataGridView1.DataSource = resultsList;
                int nbResult = dataGridView1.Rows.Count;
                NbResult.Text = nbResult.ToString();
                this.Cursor = Cursors.Default;





                resultat.Quit();
            }
        }


        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Marche Public");

                    worksheet.Cell(1, 1).Value = "Procédure";
                    worksheet.Cell(1, 1).Style.Font.SetBold(true);

                    worksheet.Cell(1, 2).Value = "Categorie";
                    worksheet.Cell(1, 2).Style.Font.SetBold(true);

                    worksheet.Cell(1, 3).Value = "Publié le";
                    worksheet.Cell(1, 3).Style.Font.SetBold(true);

                    worksheet.Cell(1, 4).Value = "Référence";
                    worksheet.Cell(1, 4).Style.Font.SetBold(true);

                    worksheet.Cell(1, 5).Value = "Objet";
                    worksheet.Cell(1, 5).Style.Font.SetBold(true);
                    worksheet.Cell(1, 5).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;


                    worksheet.Cell(1, 6).Value = "Estimation";
                    worksheet.Cell(1, 6).Style.Font.SetBold(true);

                    worksheet.Cell(1, 7).Value = "Caution";
                    worksheet.Cell(1, 7).Style.Font.SetBold(true);

                    worksheet.Cell(1, 8).Value = "Acheteur public";
                    worksheet.Cell(1, 8).Style.Font.SetBold(true);
                    worksheet.Cell(1, 8).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;


                    worksheet.Cell(1, 9).Value = "Lieu d'exécution";
                    worksheet.Cell(1, 9).Style.Font.SetBold(true);

                    worksheet.Cell(1, 10).Value = "Date limite";
                    worksheet.Cell(1, 10).Style.Font.SetBold(true);

                    worksheet.Cell(1, 11).Value = "Heure limite";
                    worksheet.Cell(1, 11).Style.Font.SetBold(true);
                    worksheet.Row(1).Style.Fill.BackgroundColor = XLColor.LightBlue;

                    worksheet.Column(1).Width = 20;
                    worksheet.Column(1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    worksheet.Column(2).Width = 20;
                    worksheet.Column(2).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    worksheet.Column(3).Width = 20;
                    worksheet.Column(3).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    worksheet.Column(4).Width = 20;
                    worksheet.Column(4).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    worksheet.Column(5).Width = 60;

                    worksheet.Column(6).Width = 20;
                    worksheet.Column(6).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    worksheet.Column(7).Width = 20;
                    worksheet.Column(7).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    worksheet.Column(8).Width = 60;

                    worksheet.Column(9).Width = 20;
                    worksheet.Column(9).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    worksheet.Column(10).Width = 20;
                    worksheet.Column(10).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    worksheet.Column(11).Width = 20;
                    worksheet.Column(11).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;




                    // Insérer les données ligne par ligne dans le tableau Excel
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 1; j < dataGridView1.Columns.Count - 1; j++)
                        {
                            worksheet.Cell(i + 2, j).Value = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                        }
                    }


                    // Afficher la boîte de dialogue pour choisir l'emplacement et le nom du fichier
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Fichiers Excel (*.xlsx)|*.xlsx";
                        saveFileDialog.Title = "Enregistrer le fichier Excel";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Enregistrer le fichier à l'emplacement spécifié
                            workbook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Fichier enregistré avec succès à : " + saveFileDialog.FileName);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Aucun élément récupéré !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && resultsList != null)
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir effacer cette liste ?",
                                          "Confirmation",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    dataGridView1.DataSource = null;
                    int nbResult = dataGridView1.Rows.Count;
                    NbResult.Text = nbResult.ToString();

                    MessageBox.Show("La liste a bien été supprimée.");
                }
                else
                {
                    MessageBox.Show("L'action a été annulée.");
                }
            }
            else
            {
                MessageBox.Show("Aucun élément récupéré !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 12 && e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                int nbList = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                Form2 form2 = new Form2(nbList);
                form2.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ModePassation.SelectedItem = ConfigurationManager.AppSettings["ProcedureOptions"] ?? "";
            CategoriePrincipale.SelectedItem = ConfigurationManager.AppSettings["CategoriePrincipale"] ?? "";
            string DateStartValue = ConfigurationManager.AppSettings["DateStart"] ?? "";
            DateTime dateStart = DateTime.Parse(DateStartValue);
            DateStart.Value = dateStart;
            string DateEndValue = ConfigurationManager.AppSettings["DateEnd"] ?? "";
            DateTime dateEnd = DateTime.Parse(DateEndValue);
            DateEnd.Value = dateEnd;
            string totalNumberString = ConfigurationManager.AppSettings["TotalNumber"] ?? "";
            int totalNumber = int.Parse(totalNumberString);
            TotalNumber.Value = totalNumber;
        }

        private void Filtrer_Click(object sender, EventArgs e)
        {
            string filtreText = FiltrerTextBox.Text.Trim().ToLower();

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Aucun élément récupéré.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (filtreText.Length > 0)
            {

                filtreList = resultsList
                .Where(ao => (ao.Procedure != null && ao.Procedure.ToLower().Contains(filtreText))
                          || (ao.Categorie != null && ao.Categorie.ToLower().Contains(filtreText))
                          || (ao.DatePublication != null && ao.DatePublication.ToLower().Contains(filtreText))
                          || (ao.Reference != null && ao.Reference.ToLower().Contains(filtreText))
                          || (ao.Objet != null && ao.Objet.ToLower().Contains(filtreText))
                          || (ao.LieuExecution != null && ao.LieuExecution.ToLower().Contains(filtreText))
                          || (ao.Estimation != null && ao.Estimation.ToLower().Contains(filtreText))
                          || (ao.Caution != null && ao.Caution.ToLower().Contains(filtreText))
                          || (ao.AcheteurPublic != null && ao.AcheteurPublic.ToLower().Contains(filtreText))
                          || (ao.DateLimite != null && ao.DateLimite.ToLower().Contains(filtreText)))
                .ToList();


                if (filtreList.Count == 0)
                {
                    MessageBox.Show("Aucun élément trouvé correspondant au filtre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dataGridView1.DataSource = filtreList;
                    int nbResult = dataGridView1.Rows.Count;
                    NbResult.Text = nbResult.ToString();
                }
            }
            else
            {
                MessageBox.Show("Veuillez saisir un texte pour filtrer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void IconRet_Click(object sender, EventArgs e)
        {
            if (resultsList == null && dataGridView1.DataSource == null)
            {
                MessageBox.Show("Aucun élément récupéré !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView1.DataSource = resultsList;
                int nbResult = dataGridView1.Rows.Count;
                NbResult.Text = nbResult.ToString();
            }
        }

    }

}
