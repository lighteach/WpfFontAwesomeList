﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using FontAwesome;
using FontAwesome.WPF;

namespace ListBoxTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> FontListResource { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
            BindFontAwesomeList();
        }

        private void BindFontAwesomeList()
        {
            FontListResource = FontListResource ?? new ObservableCollection<string>();
            Enum.GetNames(typeof(FontAwesomeIcon)).ToList().ForEach(FontListResource.Add);
        }
    }
}
