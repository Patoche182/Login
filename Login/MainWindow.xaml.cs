﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string mailTxt = mail.Text;
            string passeTxt = passe.Text;

            if (mailTxt == "admin" && passeTxt == "admin")
            {
                MessageBox.Show("Connexion OK !");
            }
            else
            {
                MessageBox.Show("Erreur de connexion !", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}