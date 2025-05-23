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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Engine.ViewModels;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession _gamesession;

        public MainWindow()
        {
            InitializeComponent();

            _gamesession = new GameSession();

            DataContext = _gamesession;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _gamesession.CurrentPlayer.ExperiencePoints= _gamesession.CurrentPlayer.ExperiencePoints + 10;

        }

    }
}
