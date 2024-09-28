using System;
using System.Collections.Generic;
using System.ComponentModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Support.UI;
using System.Text.RegularExpressions;

namespace winForms
{
    public partial class Form2 : Form
    {
        public static string? nomF2 { get; set; }
        public static string? prenomF2 { get; set; }
        public static string? emailF2 { get; set; }
        public static string? resSocialF2 { get; set; }
        public static string? entMarocF2 { get; set; }
        public static string? entNonMarocF2 { get; set; }
        public static string? ICEF2 { get; set; }
        public static string? adresseF2 { get; set; }
        public static string? adresseSuiteF2 { get; set; }
        public static string? codePostalF2 { get; set; }
        public static string? villeF2 { get; set; }
        public static string? phoneF2 { get; set; }
        public static string? faxF2 { get; set; }
        public static string? reconnaissnceF2 { get; set; }
        public Form2(int RowIndex)
        {
            InitializeComponent();
            rowIndex = RowIndex;
            name1.Text = ConfigurationManager.AppSettings["Nom"] ?? "";
            name2.Text = ConfigurationManager.AppSettings["Prenom"] ?? "";
            email.Text = ConfigurationManager.AppSettings["Email"] ?? "";
            ResSocial.Text = ConfigurationManager.AppSettings["ResSocial"] ?? "";
            ice.Text = ConfigurationManager.AppSettings["ICE"] ?? "";
            Adresse.Text = ConfigurationManager.AppSettings["Adresse"] ?? "";
            AdresseSuite.Text = ConfigurationManager.AppSettings["AdresseSuite"] ?? "";
            CodePostal.Text = ConfigurationManager.AppSettings["Cd"] ?? "";
            Ville.Text = ConfigurationManager.AppSettings["Ville"] ?? "";
            Tel.Text = ConfigurationManager.AppSettings["Tel"] ?? "";
            Fax.Text = ConfigurationManager.AppSettings["Fax"] ?? "";

        }

        private void InfoValide_Click(object sender, EventArgs e)
        {
            bool IsValidEmail(string email)
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, emailPattern);
            }
            if (string.IsNullOrEmpty(name1.Text) ||
                string.IsNullOrEmpty(name2.Text) ||
                string.IsNullOrEmpty(email.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!IsValidEmail(email.Text))
            {
                MessageBox.Show("Adresse e-mail invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Reconnaissance.Checked)
            {
                MessageBox.Show("Veuillez accépter les conditions générale de la pate-forme.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["Nom"].Value = name1.Text;
                config.AppSettings.Settings["Prenom"].Value = name2.Text;
                config.AppSettings.Settings["Email"].Value = email.Text;
                config.AppSettings.Settings["ResSocial"].Value = ResSocial.Text;
                config.AppSettings.Settings["ICE"].Value = ice.Text;
                config.AppSettings.Settings["Adresse"].Value = Adresse.Text;
                config.AppSettings.Settings["AdresseSuite"].Value = AdresseSuite.Text;
                config.AppSettings.Settings["Cd"].Value = CodePostal.Text;
                config.AppSettings.Settings["Ville"].Value = Ville.Text;
                config.AppSettings.Settings["Tel"].Value = Tel.Text;
                config.AppSettings.Settings["Fax"].Value = Fax.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                nomF2 = name1.Text;
                prenomF2 = name2.Text;
                emailF2 = email.Text;
                resSocialF2 = ResSocial.Text;
                ICEF2 = ice.Text;
                adresseF2 = Adresse.Text;
                adresseSuiteF2 = AdresseSuite.Text;
                codePostalF2 = CodePostal.Text;
                villeF2 = Ville.Text;
                phoneF2 = Tel.Text;
                faxF2 = Fax.Text;

                //string driverPath = ConfigurationManager.AppSettings["DriverPath"] ?? "";
                string outputPath = ConfigurationManager.AppSettings["OutputPath"] ?? "";
                string modePassation = ConfigurationManager.AppSettings["ProcedureOptions"] ?? "";
                string categoriePrincipale = ConfigurationManager.AppSettings["CategoriePrincipale"] ?? "";
                string dateStart = ConfigurationManager.AppSettings["DateStart"] ?? "";
                string dateEnd = ConfigurationManager.AppSettings["DateEnd"] ?? "";
                string pageSize = ConfigurationManager.AppSettings["PageSize"] ?? "";
                string totalNumberValue = ConfigurationManager.AppSettings["TotalNumber"] ?? "";
                int totalNumber = int.Parse(totalNumberValue);

                var downloadDirectory = @"C:\Users\ADMIN\Download";

                var service = ChromeDriverService.CreateDefaultService();
                var options = new ChromeOptions();
                options.AddUserProfilePreference("download.default_directory", downloadDirectory);
                options.AddUserProfilePreference("download.prompt_for_download", false);
                options.AddUserProfilePreference("download.directory_upgrade", true);
                options.AddUserProfilePreference("safebrowsing.enabled", true);
                service.HideCommandPromptWindow = true;
                var resultat = new ChromeDriver(service, options);

                using (resultat)
                {
                    resultat.Navigate().GoToUrl("https://www.marchespublics.gov.ma/index.php?page=entreprise.EntrepriseAdvancedSearch&searchAnnCons");

                    IWebElement travaux = resultat.FindElement(By.CssSelector(".main-part"));


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


                    IWebElement lancerRecherche = travaux.FindElement(By.Id("ctl0_CONTENU_PAGE_AdvancedSearch_lancerRecherche"));
                    lancerRecherche.Click();
                    IWebElement MaxResult = resultat.FindElement(By.Id("ctl0_CONTENU_PAGE_resultSearch_listePageSizeTop"));
                    SelectElement selectMax = new SelectElement(MaxResult);
                    selectMax.SelectByValue(pageSize.Trim());


                    IWebElement resultatsRecherche = resultat.FindElement(By.XPath("//*[@id='main-part']"));


                    IWebElement boutonConsultation = resultatsRecherche.FindElement(By.XPath($"//*[@id='ctl0_CONTENU_PAGE_resultSearch_tableauResultSearch_ctl{rowIndex}_panelAction']/a[1]"));

                    string hrefRefValue = boutonConsultation.GetAttribute("href");
                    int hrefRef = hrefRefValue.IndexOf("=");
                    string RefConsultation = hrefRefValue.Substring(hrefRef + 2).Trim();
                    boutonConsultation.Click();

                    resultat.Navigate().GoToUrl($"https://www.marchespublics.gov.ma/index.php?page=entreprise.EntrepriseDetailsConsultation&refConsultation={RefConsultation}");
                    IWebElement folderConsultation = resultat.FindElement(By.XPath("//*[@id=\'ctl0_CONTENU_PAGE_linkDownloadDce\']"));
                    folderConsultation.Click();
                    resultat.Navigate().GoToUrl($"https://www.marchespublics.gov.ma/index.php?page=entreprise.EntrepriseDemandeTelechargementDce&refConsultation={RefConsultation}");
                    IWebElement demandeFormulaire = resultat.FindElement(By.Id("ctl0_CONTENU_PAGE_panelEntrepriseFormulaireDemande"));
                    IWebElement reconnaissance = demandeFormulaire.FindElement(By.Id("ctl0_CONTENU_PAGE_EntrepriseFormulaireDemande_accepterConditions"));
                    IWebElement nom = demandeFormulaire.FindElement(By.Id("ctl0_CONTENU_PAGE_EntrepriseFormulaireDemande_nom"));
                    IWebElement prenom = demandeFormulaire.FindElement(By.Id("ctl0_CONTENU_PAGE_EntrepriseFormulaireDemande_prenom"));
                    IWebElement email = demandeFormulaire.FindElement(By.Id("ctl0_CONTENU_PAGE_EntrepriseFormulaireDemande_email"));
                    IWebElement resSocial = demandeFormulaire.FindElement(By.Id("ctl0_CONTENU_PAGE_EntrepriseFormulaireDemande_raisonSocial"));
                    IWebElement entMaroc = demandeFormulaire.FindElement(By.Id("ctl0_CONTENU_PAGE_EntrepriseFormulaireDemande_france"));
                    IWebElement ICE = demandeFormulaire.FindElement(By.Id("ctl0_CONTENU_PAGE_EntrepriseFormulaireDemande_ICE"));
                    IWebElement entNonMaroc = demandeFormulaire.FindElement(By.Id("ctl0_CONTENU_PAGE_EntrepriseFormulaireDemande_etranger"));
                    IWebElement adresse = demandeFormulaire.FindElement(By.Id("ctl0_CONTENU_PAGE_EntrepriseFormulaireDemande_address"));
                    IWebElement adresseSuite = demandeFormulaire.FindElement(By.Id("ctl0_CONTENU_PAGE_EntrepriseFormulaireDemande_address2"));
                    IWebElement codePostal = demandeFormulaire.FindElement(By.Id("ctl0_CONTENU_PAGE_EntrepriseFormulaireDemande_cp"));
                    IWebElement ville = demandeFormulaire.FindElement(By.Id("ctl0_CONTENU_PAGE_EntrepriseFormulaireDemande_ville"));
                    IWebElement phone = demandeFormulaire.FindElement(By.Id("ctl0_CONTENU_PAGE_EntrepriseFormulaireDemande_tel"));
                    IWebElement fax = demandeFormulaire.FindElement(By.Id("ctl0_CONTENU_PAGE_EntrepriseFormulaireDemande_fax"));

                    reconnaissance.Click();
                    nom.SendKeys(nomF2.Trim());
                    prenom.SendKeys(prenomF2.Trim());
                    email.SendKeys(emailF2.Trim());
                    resSocial.SendKeys(resSocialF2.Trim());
                    if (EntMaroc.Checked)
                    {
                        entMaroc.Click();
                    }
                    ICE.SendKeys(ICEF2.Trim());
                    if (EntNonMaroc.Checked)
                    {
                        entNonMaroc.Click();
                    }
                    adresse.SendKeys(adresseF2.Trim());
                    adresseSuite.SendKeys(adresseSuiteF2.Trim());
                    codePostal.SendKeys(codePostalF2.Trim());
                    phone.SendKeys(phoneF2.Trim());
                    fax.SendKeys(faxF2.Trim());

                    IWebElement valide = demandeFormulaire.FindElement(By.Id("ctl0_CONTENU_PAGE_validateButton"));
                    valide.Click();

                    IWebElement download = resultat.FindElement(By.ClassName("content"));
                    IWebElement downloadbutton = resultat.FindElement(By.Id("ctl0_CONTENU_PAGE_EntrepriseDownloadDce_completeDownload"));
                    downloadbutton.Click();
                    Thread.Sleep(2000);
                    TimeSpan maxWaitTime = TimeSpan.FromSeconds(30);
                    var stopWatch = System.Diagnostics.Stopwatch.StartNew();
                    while (stopWatch.Elapsed < maxWaitTime)
                    {
                        bool isDownloading = Directory.GetFiles(downloadDirectory, "*.crdownload").Any();
                        bool hasCompletedDownload = Directory.GetFiles(downloadDirectory).Any(f => !f.EndsWith(".crdownload"));

                        if (!isDownloading && hasCompletedDownload)
                        {
                            resultat.Quit();
                            MessageBox.Show("Téléchargement términé.");
                            break;
                        }

                        Thread.Sleep(5000);
                    }
                }
            }
        }


        private void InfoClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir réinitialiser ?",
                                          "Confirmation",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                name1.Text = null;
                name2.Text = null;
                email.Text = null;
                ResSocial.Text = null;
                EntMaroc.Checked = false;
                EntNonMaroc.Checked = false;
                Adresse.Text = null;
                AdresseSuite.Text = null;
                CodePostal.Text = null;
                Ville.Text = null;
                Tel.Text = null;
                Fax.Text = null;
                Reconnaissance.Checked = false;

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["Nom"].Value = null;
                config.AppSettings.Settings["Prenom"].Value = null;
                config.AppSettings.Settings["Email"].Value = null;
                config.AppSettings.Settings["ResSocial"].Value = null;
                config.AppSettings.Settings["ICE"].Value = null;
                config.AppSettings.Settings["Adresse"].Value = null;
                config.AppSettings.Settings["AdresseSuite"].Value = null;
                config.AppSettings.Settings["Cd"].Value = null;
                config.AppSettings.Settings["Ville"].Value = null;
                config.AppSettings.Settings["Tel"].Value = null;
                config.AppSettings.Settings["Fax"].Value = null;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            else
            {
                MessageBox.Show("L'action a été annulée.");
            }
        }

        private void EntMaroc_CheckedChanged(object sender, EventArgs e)
        {
            if (EntMaroc.Checked)
            {
                ice.Enabled = true;
            }
            else
            {
                ice.Enabled = false;
            }
        }

        private void EntNonMaroc_CheckedChanged(object sender, EventArgs e)
        {
            if (EntNonMaroc.Checked)
            {
                Adresse.Enabled = true;
                AdresseSuite.Enabled = true;
                CodePostal.Enabled = true;
                Ville.Enabled = true;
                Tel.Enabled = true;
                Fax.Enabled = true;
            }
            else
            {
                Adresse.Enabled = false;
                AdresseSuite.Enabled = false;
                CodePostal.Enabled = false;
                Ville.Enabled = false;
                Tel.Enabled = false;
                Fax.Enabled = false;
            }
            
        }
    }
}
