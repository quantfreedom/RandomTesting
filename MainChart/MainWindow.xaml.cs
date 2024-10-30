﻿using MainChart.ViewModels;
using ScottPlot;
using System.Windows;

namespace MainChart;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow:Window
{
    public MainWindow()
    {
        InitializeComponent();

        this.DataContext = new WindowViewModel(this);
    }
}