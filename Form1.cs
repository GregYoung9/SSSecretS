namespace Codeco9
{
    using System;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;
    using System.Windows.Forms;
    using System.Linq;

    public partial class Form1 : Form
    {
        private static readonly string FilePath = "passwords.txt";
        private static readonly string Key = Properties.Settings.Default.MySecretKey;
        //private static readonly string Key = "YourVerySecureKey123"; // Must be exactly 16, 24, or 32 characters long
        public Form1()
        {
            InitializeComponent();
        }

        private static string? Encrypt(string text)
        {
            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = GetValidKey();
                    aes.IV = new byte[aes.BlockSize / 8];
                    using (var encryptor = aes.CreateEncryptor())
                    {
                        byte[] inputBytes = Encoding.UTF8.GetBytes(text);
                        byte[] encryptedBytes = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
                        return Convert.ToBase64String(encryptedBytes);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encryption failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private static byte[] GetValidKey()
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(Key);
            return keyBytes.Length switch
            {
                >= 32 => keyBytes.Take(32).ToArray(),
                >= 24 => keyBytes.Take(24).ToArray(),
                _ => keyBytes.Take(16).ToArray(),
            };
        }


        private static string Decrypt(string encryptedText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = GetValidKey(); // Ensure correct key size
                aes.IV = new byte[aes.BlockSize / 8]; // Same IV used in encryption
                using (var decryptor = aes.CreateDecryptor())
                {
                    byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
                    byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                    return Encoding.UTF8.GetString(decryptedBytes);
                }
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string _Website = txtWebsite.Text;
            string _Login = txtLogin.Text;
            string password = txtPassword.Text;
            string _Notes = txtNotes.Text;

            if (string.IsNullOrWhiteSpace(_Website) || string.IsNullOrWhiteSpace(_Login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(_Login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both account and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string? encryptedPassword = Encrypt(password);
            if (encryptedPassword == null)
            {
                MessageBox.Show("Failed to encrypt the password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string _entry = $"{_Website} <&> {_Login} <&> {encryptedPassword} <&> Notes: {_Notes}\n";
            _entry = _entry.TrimStart();
            File.AppendAllText(FilePath, _entry);

            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnNew.Enabled = true;

            MessageBox.Show("Password saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtWebsite.Text = "";
            txtLogin.Text = "";
            txtPassword.Text = "";
            txtNotes.Text = "";

        }

        private void btnRetrieve_Click_1(object sender, EventArgs e)
        {
            try
            {
                lstPasswords.Items.Clear();
                lstPasswords2.Items.Clear();
                if (!File.Exists(FilePath))
                {
                    MessageBox.Show("No stored passwords found.");
                    return;
                }

                string[] entries = File.ReadAllLines(FilePath);
                foreach (var entry in entries)
                {
                    var parts = entry.Split(" <&> ");
                    if (parts.Length == 4)
                        lstPasswords.Items.Add($"{parts[0]} <&> {parts[1]} <&> {Decrypt(parts[2])} <&> {parts[3]}");
                    lstPasswords2.Items.Add($"{parts[0]}: {parts[1]}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RetrieveAccount(string _startsWith)
        {
            try
            {
                lstPasswords.Items.Clear();
                lstPasswords2.Items.Clear();
                if (!File.Exists(FilePath))
                {
                    MessageBox.Show("No stored passwords found.");
                    return;
                }
                string[] entries = File.ReadAllLines(FilePath);
                foreach (var entry in entries)
                {
                    var parts = entry.Split(" <&> ");
                    if (parts.Length == 4)
                    {

                        if (parts[0].StartsWith(_startsWith, StringComparison.OrdinalIgnoreCase))
                        {
                            lstPasswords.Items.Add($"{parts[0]} <&> {parts[1]} <&> {Decrypt(parts[2])} <&> {parts[3]}");
                            lstPasswords2.Items.Add($"{parts[0]}: {parts[1]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Click letter lookup buttons
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RetrieveAccount("a");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            RetrieveAccount("b");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            RetrieveAccount("c");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            RetrieveAccount("d");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            RetrieveAccount("e");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RetrieveAccount("f");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RetrieveAccount("g");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RetrieveAccount("h");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RetrieveAccount("i");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RetrieveAccount("j");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RetrieveAccount("k");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RetrieveAccount("l");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RetrieveAccount("m");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RetrieveAccount("n");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            RetrieveAccount("o");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            RetrieveAccount("p");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            RetrieveAccount("q");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            RetrieveAccount("r");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            RetrieveAccount("s");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            RetrieveAccount("t");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            RetrieveAccount("u");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            RetrieveAccount("v");
        }
        private void button27_Click(object sender, EventArgs e)
        {
            RetrieveAccount("w");
        }
        private void button16_Click(object sender, EventArgs e)
        {
            RetrieveAccount("x");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            RetrieveAccount("y");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            RetrieveAccount("z");
        }
        #endregion
        // Updated code to handle potential null value for lstPasswords.SelectedItem

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this entry?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {

                    // Fix for CS0131: The left-hand side of an assignment must be a variable, property or indexer  
                    if (MessageBox.Show("Are you sure you want to delete this entry?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        // Your existing code here  
                    }
                    // Fix for CS0131: The left-hand side of an assignment must be a variable, property or indexer
                    if (MessageBox.Show("Are you sure you want to delete this entry?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        // Your existing code here
                    }
                    // Ensure an item is selected

                    if (lstPasswords2.SelectedItem == null)
                    {
                        MessageBox.Show("Please select an entry to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        lstPasswords.SelectedIndex = lstPasswords2.SelectedIndex;
                    }

                    if (lstPasswords.SelectedItem == null)
                    {
                        MessageBox.Show("Please select an entry to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Get the selected entry
                    string? selectedEntry = lstPasswords.SelectedItem?.ToString();

                    if (string.IsNullOrEmpty(selectedEntry))
                    {
                        MessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Read all lines from the file
                    string[] entries = File.ReadAllLines(FilePath);

                    // Filter out the selected entry
                    var updatedEntries = entries.Where(entry =>
                    {
                        // Split the entry to match the format
                        var parts = entry.Split(new[] { " <&> " }, StringSplitOptions.None);
                        if (parts.Length == 4)
                        {
                            // Reconstruct the entry to match the selected item
                            string reconstructedEntry = $"{parts[0]} <&> {parts[1]} <&> {Decrypt(parts[2])} <&> {parts[3]}";
                            return !reconstructedEntry.Equals(selectedEntry, StringComparison.OrdinalIgnoreCase);
                        }
                        return true;
                    });

                    // Write the updated entries back to the file
                    File.WriteAllLines(FilePath, updatedEntries);

                    // Refresh the list
                    btnRetrieve_Click_1(sender, e);

                    MessageBox.Show("Entry deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting entry: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstPasswords2.SelectedItem == null)
                {
                    MessageBox.Show("Please select an entry to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    lstPasswords.SelectedIndex = lstPasswords2.SelectedIndex;
                }

                if (lstPasswords.SelectedItem == null)
                {
                    MessageBox.Show("Please select an entry to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string? selectedEntry = lstPasswords.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedEntry))
                {
                    MessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string newPassword = txtPassword.Text;
                string newNotes = txtNotes.Text;

                if (string.IsNullOrWhiteSpace(newPassword) && string.IsNullOrWhiteSpace(newNotes))
                {
                    MessageBox.Show("No updates were made. Both fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string[] entries = File.ReadAllLines(FilePath);

                var updatedEntries = entries.Select(entry =>
                {
                    var parts = entry.Split(new[] { " <&> " }, StringSplitOptions.None);
                    if (parts.Length == 4)
                    {
                        string reconstructedEntry = $"{parts[0]} <&> {parts[1]} <&> {Decrypt(parts[2])} <&> {parts[3]}";
                        if (reconstructedEntry.Equals(selectedEntry, StringComparison.OrdinalIgnoreCase))
                        {
                            if (!string.IsNullOrWhiteSpace(newPassword))
                            {
                                parts[2] = Encrypt(newPassword) ?? parts[2]; // Fix: Handle potential null from Encrypt
                            }
                            if (!string.IsNullOrWhiteSpace(newNotes))
                            {
                                parts[3] = $"{newNotes}";
                            }
                            btnNew.Enabled = true;
                            btnSave.Enabled = false;
                            btnUpdate.Enabled = false;
                            btnDelete.Enabled = false;
                            return string.Join(" <&> ", parts);
                        }
                    }
                    return entry;
                });

                File.WriteAllLines(FilePath, updatedEntries);

                btnRetrieve_Click_1(sender, e);

                MessageBox.Show("Entry updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating entry: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstPasswords_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Ensure an item is selected
                if (lstPasswords2.SelectedItem == null)
                {
                    return;
                }
                else
                {
                    lstPasswords.SelectedIndex = lstPasswords2.SelectedIndex;
                }
                // Get the selected entry
                string? selectedEntry = lstPasswords.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedEntry))
                {
                    return;
                }

                // Split the selected entry to extract the parts
                var parts = selectedEntry.Split(new[] { " <&> " }, StringSplitOptions.None);

                if (parts.Length == 4)
                {
                    // Populate the textboxes
                    txtWebsite.Text = parts[0];
                    txtLogin.Text = parts[1];
                    txtPassword.Text = parts[2];
                    txtNotes.Text = parts[3].Replace("Notes: ", "");
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error populating textboxes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtWebsite.Text = "";
            txtLogin.Text = "";
            txtPassword.Text = "";
            txtNotes.Text = "";

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                lstPasswords.Items.Clear();
                lstPasswords2.Items.Clear();
                if (!File.Exists(FilePath))
                {
                    MessageBox.Show("No stored passwords found.");
                    return;
                }
                string[] entries = File.ReadAllLines(FilePath);
                foreach (var entry in entries)
                {
                    var parts = entry.Split(" <&> ");
                    if (parts.Length == 4)
                    {

                        if (parts[0].StartsWith(txtSearchFor.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            lstPasswords.Items.Add($"{parts[0]} <&> {parts[1]} <&> {Decrypt(parts[2])} <&> {parts[3]}");
                            lstPasswords2.Items.Add($"{parts[0]}: {parts[1]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewKey_Click(object sender, EventArgs e)
        {
            txtSecretKey.DataBindings.Add("Text", Properties.Settings.Default, "MySecretKey");
            txtSecretKey.Visible = true;
            btnCopyKey.Visible = true;
        }

        private void lstPasswords2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPasswords.SelectedIndex = lstPasswords2.SelectedIndex;
        }
    }
}
