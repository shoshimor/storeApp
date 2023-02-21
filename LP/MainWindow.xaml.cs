﻿using BlApi;
using BO;
using System;
using System.Windows;

namespace PL;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// Main display window
/// </summary>
public partial class MainWindow : Window
{
    private static BlApi.IBL? Bl { get; set; }
    
    /// <summary>
    /// constractor of the main window
    /// </summary>
    public MainWindow()
    {
        InitializeComponent();
        //if (Bl is null)
        Bl = BlApi.Factory.Get();
    }

    /// <summary>
    /// when the button: "go to product" is press the function is activated
    /// the main window id hide and the window of the list of product is show
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LogInAdmin_Click(object sender, RoutedEventArgs e)
    {
        new ProductListWindow(Bl).Show();
        Hide();
    }

    private void NewOrder_Click(object sender, RoutedEventArgs e)
    {

        new NewOrderWindow(Bl).Show();
        Hide();
    }

    private void FollowOrder_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            int idOrderTrack = Convert.ToInt32(TrackOrderText.Text);
            Order orderTrack = Bl.Order.ReadOrderProperties(idOrderTrack);
            new OrderTrackingWindow(orderTrack).Show();
            Hide();
        }
        catch(BlNotExistException ex)
        {
            MessageBox.Show(
                ex.Message,
                "order tracking error",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
        }
    }

    private void NumberOrderTrack(object sender, System.Windows.Input.KeyEventArgs e)
    {
        int idOrderTrack = Convert.ToInt32(TrackOrderText.Text);
        if (idOrderTrack > 0)
        {
            followBtn.IsEnabled = true;
        }
    }
}
