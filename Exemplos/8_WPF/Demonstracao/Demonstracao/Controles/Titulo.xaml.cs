﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demonstracao.Controles
{
    /// <summary>
    /// Interaction logic for Titulo.xaml
    /// </summary>
    public partial class Titulo : UserControl
    {
        public String TextoTitulo
        {
            set
            {
                label1.Content = value;
            }
        }

        public Titulo()
        {
            InitializeComponent();
        }
    }
}
