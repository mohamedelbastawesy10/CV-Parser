using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace CVParserApp
{
    public partial class Form1 : Form
    {
        private bool isManualFormValid = false;
        private Dictionary<string, string> manualFormData = new Dictionary<string, string>();
        private Dictionary<string, string> cvParsedData = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string resultMessage = "Validation Results:\n";
            manualFormData.Clear();

            // Reset all fields to default color
            txtName.BackColor = System.Drawing.SystemColors.Window;
            txtEmail.BackColor = System.Drawing.SystemColors.Window;
            txtPhone.BackColor = System.Drawing.SystemColors.Window;
            txtPassword.BackColor = System.Drawing.SystemColors.Window;
            txtAddress.BackColor = System.Drawing.SystemColors.Window;
            txtPostalCode.BackColor = System.Drawing.SystemColors.Window;

            // Name validation (allows English and Arabic characters)
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                resultMessage += "- Name is required\n";
                txtName.BackColor = System.Drawing.Color.LightPink;
                isValid = false;
            }
            else if (!Regex.IsMatch(txtName.Text, @"^[\p{L}\s'-]+$"))
            {
                resultMessage += "- Name contains invalid characters\n";
                txtName.BackColor = System.Drawing.Color.LightPink;
                isValid = false;
            }
            else
            {
                manualFormData["Name"] = txtName.Text;
            }

            // Email validation
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                resultMessage += "- Email is required\n";
                txtEmail.BackColor = System.Drawing.Color.LightPink;
                isValid = false;
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                resultMessage += "- Invalid email format\n";
                txtEmail.BackColor = System.Drawing.Color.LightPink;
                isValid = false;
            }
            else
            {
                manualFormData["Email"] = txtEmail.Text;
            }

            // Phone validation (supports international formats)
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                resultMessage += "- Phone is required\n";
                txtPhone.BackColor = System.Drawing.Color.LightPink;
                isValid = false;
            }
            else if (!Regex.IsMatch(txtPhone.Text, @"^\+?[\d\s\-\(\)]{7,}$"))
            {
                resultMessage += "- Invalid phone number format\n";
                txtPhone.BackColor = System.Drawing.Color.LightPink;
                isValid = false;
            }
            else
            {
                manualFormData["Phone"] = txtPhone.Text;
            }

            // Password validation (at least 8 chars, with number and special char)
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                resultMessage += "- Password is required\n";
                txtPassword.BackColor = System.Drawing.Color.LightPink;
                isValid = false;
            }
            else if (!Regex.IsMatch(txtPassword.Text, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$"))
            {
                resultMessage += "- Password must be at least 8 characters with at least one number and one special character\n";
                txtPassword.BackColor = System.Drawing.Color.LightPink;
                isValid = false;
            }
            else
            {
                manualFormData["Password"] = "********"; // Don't store actual password
            }

            // Address validation
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                resultMessage += "- Address is required\n";
                txtAddress.BackColor = System.Drawing.Color.LightPink;
                isValid = false;
            }
            else
            {
                manualFormData["Address"] = txtAddress.Text;
            }

            // Postal code validation (allows various international formats)
            if (string.IsNullOrWhiteSpace(txtPostalCode.Text))
            {
                resultMessage += "- Postal code is required\n";
                txtPostalCode.BackColor = System.Drawing.Color.LightPink;
                isValid = false;
            }
            else if (!Regex.IsMatch(txtPostalCode.Text, @"^[a-zA-Z0-9\-\s]{3,10}$"))
            {
                resultMessage += "- Invalid postal code format\n";
                txtPostalCode.BackColor = System.Drawing.Color.LightPink;
                isValid = false;
            }
            else
            {
                manualFormData["PostalCode"] = txtPostalCode.Text;
            }

            if (isValid)
            {
                resultMessage = "All fields are valid!\n\nSubmitted Data:\n";
                foreach (var item in manualFormData)
                {
                    resultMessage += $"{item.Key}: {item.Value}\n";
                }
                isManualFormValid = true;
                btnSaveManual.Enabled = true;
            }
            else
            {
                isManualFormValid = false;
                btnSaveManual.Enabled = false;
            }

            lblManualResult.Text = resultMessage;
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCVContent.Text))
            {
                lblCVResult.Text = "Please paste or type your CV content first.";
                btnSaveCV.Enabled = false;
                return;
            }

            cvParsedData.Clear();
            string cvText = txtCVContent.Text;
            string resultMessage = "Parsed CV Data:\n";

            // Extract name (looks for title-case words at the beginning)
            var nameMatch = Regex.Match(cvText, @"^(?:[A-Z][a-z]+\s?){2,3}");
            if (nameMatch.Success)
            {
                cvParsedData["Name"] = nameMatch.Value.Trim();
                resultMessage += $"Name: {nameMatch.Value.Trim()}\n";
            }
            else
            {
                resultMessage += "Name: Not found\n";
            }

            // Extract email
            var emailMatch = Regex.Match(cvText, @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b");
            if (emailMatch.Success)
            {
                cvParsedData["Email"] = emailMatch.Value;
                resultMessage += $"Email: {emailMatch.Value}\n";
            }
            else
            {
                resultMessage += "Email: Not found\n";
            }

            // Extract phone (supports various formats)
            var phoneMatch = Regex.Match(cvText, @"(\+?\d{1,3}[\s\-]?)?\(?\d{3}\)?[\s\-]?\d{3}[\s\-]?\d{4}");
            if (phoneMatch.Success)
            {
                cvParsedData["Phone"] = phoneMatch.Value;
                resultMessage += $"Phone: {phoneMatch.Value}\n";
            }
            else
            {
                resultMessage += "Phone: Not found\n";
            }

            // Extract skills (common programming languages and tools)
            var skillsMatches = Regex.Matches(cvText, @"\b(C#|Java|Python|JavaScript|SQL|HTML|CSS|PHP|Ruby|\.NET|Angular|React)\b", RegexOptions.IgnoreCase);
            if (skillsMatches.Count > 0)
            {
                HashSet<string> uniqueSkills = new HashSet<string>();
                foreach (Match match in skillsMatches)
                {
                    uniqueSkills.Add(match.Value);
                }
                string skills = string.Join(", ", uniqueSkills);
                cvParsedData["Skills"] = skills;
                resultMessage += $"Skills: {skills}\n";
            }
            else
            {
                resultMessage += "Skills: None detected\n";
            }

            // Extract years of experience
            var expMatch = Regex.Match(cvText, @"(\d+)\s+(year|yr)s?", RegexOptions.IgnoreCase);
            if (expMatch.Success)
            {
                cvParsedData["Experience"] = expMatch.Value;
                resultMessage += $"Experience: {expMatch.Value}\n";
            }
            else
            {
                resultMessage += "Experience: Not specified\n";
            }

            btnSaveCV.Enabled = cvParsedData.Count > 0;
            lblCVResult.Text = resultMessage;
        }

        private void btnSaveManual_Click(object sender, EventArgs e)
        {
            if (!isManualFormValid || manualFormData.Count == 0)
            {
                MessageBox.Show("No valid data to save. Please validate the form first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv";
            saveFileDialog1.Title = "Save Validated Form Data";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        if (saveFileDialog1.FilterIndex == 2) // CSV
                        {
                            sw.WriteLine("Field,Value");
                            foreach (var item in manualFormData)
                            {
                                sw.WriteLine($"\"{item.Key}\",\"{item.Value}\"");
                            }
                        }
                        else // TXT
                        {
                            foreach (var item in manualFormData)
                            {
                                sw.WriteLine($"{item.Key}: {item.Value}");
                            }
                        }
                    }
                    MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveCV_Click(object sender, EventArgs e)
        {
            if (cvParsedData.Count == 0)
            {
                MessageBox.Show("No parsed data to save. Please parse a CV first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv";
            saveFileDialog1.Title = "Save Parsed CV Data";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        if (saveFileDialog1.FilterIndex == 2) // CSV
                        {
                            sw.WriteLine("Field,Value");
                            foreach (var item in cvParsedData)
                            {
                                sw.WriteLine($"\"{item.Key}\",\"{item.Value}\"");
                            }
                        }
                        else // TXT
                        {
                            foreach (var item in cvParsedData)
                            {
                                sw.WriteLine($"{item.Key}: {item.Value}");
                            }
                        }
                    }
                    MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}