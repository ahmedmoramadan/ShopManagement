using System;
using System.Windows.Forms;

namespace Shop.presentation
{
    internal class SharedClass
    {
        // Singleton instance
        private static readonly Lazy<SharedClass> _instance = new Lazy<SharedClass>(() => new SharedClass());

        // Public accessor for the singleton instance
        public static SharedClass Instance => _instance.Value;

        // Private constructor to prevent external instantiation
        private SharedClass() { }

        // Method to navigate to the WelcomeForm
        public void GoTOWelcomePage(Form currentForm)
        {
            try
            {
                // Create and show the WelcomeForm
                WelcomeForm welcomeForm = new WelcomeForm();
                welcomeForm.Show();

                // Hide and dispose of the current form
                currentForm.Hide();
                currentForm.Dispose();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during navigation
                MessageBox.Show($"An error occurred while navigating to the Welcome page: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}