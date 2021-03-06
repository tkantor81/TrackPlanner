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
using TrackPlanner;

namespace WPFTrackPlanner
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

        private Circuit circuit = new Circuit()
        {
            Name = "Prvni okruh"
        };

        private void btnAddCurve_Click(object sender, RoutedEventArgs e)
        {
            circuit.AddTrack(new Curve());
        }

        private void btnAddStraight_Click(object sender, RoutedEventArgs e)
        {
            circuit.AddTrack(new Straight());
        }
    }
}
