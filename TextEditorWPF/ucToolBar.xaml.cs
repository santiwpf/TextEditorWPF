using System.Windows;
using System.Windows.Controls;

namespace TextEditorWPF
{
    /// <summary>
    /// Lógica de interacción para ucToolBar.xaml
    /// </summary>
    public partial class ucToolBar : UserControl
    {
        public ucToolBar()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 8; i < 48; i += 2)
                fontSize.Items.Add(i);
        }
    }
}
