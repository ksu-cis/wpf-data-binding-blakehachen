using System;
using System.Windows;
using System.Windows.Controls;
using UniversityRegistry.Data;
using UniversityRegistry.UI;
using System.Collections.ObjectModel;

namespace UniversityRegistry.UI
{
    /// <summary>
    /// Interaction logic for RegistryList.xaml
    /// </summary>
    public partial class PersonList : UserControl
    {
        public PersonList()
        {
            InitializeComponent();
        }

        public event SelectionChangedEventHandler SelectionChanged;

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectionChanged?.Invoke(this, e);
        }

        
        private void OnAddNewPerson(object sender, RoutedEventArgs e)
        {
            
           //Wasn't sure how to implement.
           
        }

        
    }
}
