using MahApps.Metro.Controls;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HydrogenAtomSchrodinger.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FloatingNumberOnly_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null)
                return;

            string changedText = textBox.Text.Remove(textBox.SelectionStart, textBox.SelectionLength).Insert(textBox.SelectionStart, e.Text);

            Regex regex = new Regex(@"[^0-9.]+");
            if (regex.IsMatch(changedText))
            {
                textBox.Text = regex.Replace(changedText, "");
                e.Handled = true;
            }
        }
    }
}
