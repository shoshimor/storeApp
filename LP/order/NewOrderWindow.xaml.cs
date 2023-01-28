﻿using System.Windows;
using BO;
namespace PL;

/// <summary>
/// Interaction logic for NewOrderWindow.xaml
/// a display window that shows the entire list of product for the customer
/// </summary>
public partial class NewOrderWindow : Window
{
    private BlApi.IBL? Bl { get; set; }
    /// <summary>
    /// the constractor of the new order window
    /// the function initializes the array of product
    /// and initializes the categories
    /// </summary>
    /// <param name="bl"></param>
    public NewOrderWindow(BlApi.IBL? bl)
    {
        InitializeComponent();
        Bl = bl;
        NewOrderView.ItemsSource = Bl.Product.ReadProductsList();
        SelectorProduct.ItemsSource = eCategories.GetValues(typeof(eCategories));
    }
    /// <summary>
    /// when the button:"X" is press the functionis activated
    /// when the user want to return all product list
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FilterDelete_Click(object sender, RoutedEventArgs e)
    {
        NewOrderView.ItemsSource = Bl.Product.ReadProductsList();
    }
    /// <summary>
    /// when the user choose a category to search
    /// the function search and send all product in this category
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CategorySelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
        NewOrderView.ItemsSource = Bl.Product.ReadProductsList((eCategories)SelectorProduct.SelectedItem);
    }

    private void GoToCart_Click(object sender, RoutedEventArgs e)
    {
        UserCartWindow cart = new UserCartWindow(Bl);
        cart.Show();
        this.Hide();
    }

    private void GoToProductProperties(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        new ProductWindow(Bl, ((Product)NewOrderView.SelectedItem).ID).Show();
        Hide();
    }
}