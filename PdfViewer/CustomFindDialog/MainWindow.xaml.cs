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
using Telerik.Windows.Documents.Fixed.UI.Dialogs;
using Telerik.Windows.Documents.Fixed.UI.Extensibility;

namespace CustomFindDialog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            FindDialog findDialog = new FindDialog();
            findDialog.Owner = this;
            ExtensibilityManager.RegisterFindDialog(findDialog);
            InitializeComponent();
        }
    }
}