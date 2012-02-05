using System.Windows;
using System.Windows.Input;
using TextEditorWPF;

namespace TextEditorWPF
{
    public partial class MainWindow : Window
    {
        private readonly DocumentManager _documentManager;
        private readonly PrintManager _printManager;

        public MainWindow()
        {
            InitializeComponent();
            _documentManager = new DocumentManager(body);
            _printManager = new PrintManager(body);
        }

        private void NewDocument(object sender, ExecutedRoutedEventArgs e)
        {
            _documentManager.NewDocument();
            status.Text = "New Document";
        }

        private void OpenDocument(object sender, ExecutedRoutedEventArgs e)
        {
            if (_documentManager.OpenDocument())
                status.Text = "Document loaded.";
        }

        private void SaveDocument(object sender, ExecutedRoutedEventArgs e)
        {
            if (_documentManager.SaveDocument())
                status.Text = "Document saved.";
        }

        private void SaveDocumentAs(object sender, ExecutedRoutedEventArgs e)
        {
            if (_documentManager.SaveDocumentAs())
                status.Text = "Document saved.";
        }

        private void ApplicationClose(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

        private void SaveDocument_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _documentManager.CanSaveDocument();
        }

        private void PrintDocument(object sender, ExecutedRoutedEventArgs e)
        {
            // Dialogo Impresion Standard
            // PrintDialog dlg = new PrintDialog();
            // if (dlg.ShowDialog() == true)
            // {
            //     dlg.PrintDocument((((IDocumentPaginatorSource)body.Document).DocumentPaginator),"Text Editor Printing");
            // }

            // Dialogo Personalizado
            if (_printManager.Print())
                status.Text = "Document sent to print.";
        }

        private void PrintPreview(object sender, ExecutedRoutedEventArgs e)
        {
            _printManager.PrintPreview();
        }
    }
}
