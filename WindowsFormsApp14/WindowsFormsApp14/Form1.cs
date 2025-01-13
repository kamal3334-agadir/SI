using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionAteliers
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Server=DESKTOP-UBPPQDP\\SQLEXPRESS;Database=MINI_PROJET;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Populate ComboBox
                comboChoix.Items.Clear();
                comboChoix.Items.AddRange(new string[] { "Participant", "Formateur"});
                comboChoix.SelectedIndex = 0;

                // Enable controls
                buttonCreerCompte.Enabled = true;
                buttonCreerCompte.Visible = true;
                buttonConnexion.Enabled = true;
                buttonConnexion.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement du formulaire: {ex.Message}",
                              "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCreerCompte_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérer et valider les valeurs des champs
                string nom = textNom.Text?.Trim() ?? "";
                string prenom = textPrenom.Text?.Trim() ?? "";
                string email = textEmail.Text?.Trim() ?? "";
                string telephone = textTelephone.Text?.Trim() ?? "";
                string motPasse = textMotPasse.Text?.Trim() ?? "";
                string choix = comboChoix.SelectedItem?.ToString()?.ToLower() ?? "";

                if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) ||
                    string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(motPasse) ||
                    string.IsNullOrWhiteSpace(choix))
                {
                    MessageBox.Show("Tous les champs sont obligatoires.", "Erreur",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate email format
                if (!System.Text.RegularExpressions.Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Format d'email invalide.", "Erreur",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_AjouterUtilisateur", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        cmd.Parameters.AddWithValue("@Choix", choix);
                        cmd.Parameters.AddWithValue("@Nom", nom);
                        cmd.Parameters.AddWithValue("@Prenom", prenom);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Telephone",
                            string.IsNullOrWhiteSpace(telephone) ? DBNull.Value : (object)telephone);
                        cmd.Parameters.AddWithValue("@Password", motPasse);

                        // Execute procedure
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            MessageBox.Show("Compte créé avec succès!", "Succès",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Erreur de base de données: {sqlEx.Message}",
                              "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite: {ex.Message}",
                              "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LinkLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Redirection vers la page de connexion...",
                          "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Add your login form navigation logic here
        }

        private void ClearFields()
        {
            textNom.Clear();
            textPrenom.Clear();
            textEmail.Clear();
            textTelephone.Clear();
            textMotPasse.Clear();
            comboChoix.SelectedIndex = 0;
        }
    }
}