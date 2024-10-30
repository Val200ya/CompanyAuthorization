﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CompanyAuthorizationRodina
{
    /// <summary>
    /// Логика взаимодействия для ErrorWindow.xaml
    /// </summary>
    public partial class ErrorMessageWindow : Window
    {
        public ErrorMessageWindow()
        {
            InitializeComponent();
        }

        private void ErrorMessageBtn_Click(object sender, RoutedEventArgs e)
        {
            Window errorMessageWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = errorMessageWindow;
            errorMessageWindow.Hide();
        }
    }
}
