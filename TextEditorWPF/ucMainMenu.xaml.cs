using System.Windows;
using System.Windows.Controls;

namespace TextEditorWPF
{
    /// <summary>
    /// Lógica de interacción para ucMainMenu.xaml
    /// </summary>
    public partial class ucMainMenu : UserControl
    {
        public ucMainMenu()
        {
            InitializeComponent();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
           MessageBox.Show("WPF Text Editor Free", "About");
        }

    }
}
