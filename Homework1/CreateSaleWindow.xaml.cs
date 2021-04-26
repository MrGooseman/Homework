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

namespace Homework1
{
    /// <summary>
    /// Логика взаимодействия для CreateSaleWindow.xaml
    /// </summary>
    public partial class CreateSaleWindow : Window
    {
        public CreateSaleWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public string getName()
        {
            return nameText.Text;
        }
        public int getValue()
        {
            return Convert.ToInt32(valueText.Text);
        }
        public double getPrice()
        {
            return Convert.ToDouble(priceText.Text);
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (nameText.Text != "" && valueText.Text != "" && priceText.Text != "")
            {
                //MainWindow window = new MainWindow();
                //window.Show();
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Fill all the fields");
            }
        }
    }
}
