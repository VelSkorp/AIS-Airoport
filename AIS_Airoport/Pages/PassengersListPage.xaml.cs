﻿using AIS_Airoport.Core;

namespace AIS_Airoport
{
    /// <summary>
    /// Логика взаимодействия для PassengersPage.xaml
    /// </summary>
    public partial class PassengersPage : BasePage<PassengersListViewModel>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PassengersPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor with specific view model
        /// </summary>
        /// <param name="specificViewModel">The specific view model to use for this page</param>
        public PassengersPage(PassengersListViewModel specificViewModel = null) : base(specificViewModel)
        {
            InitializeComponent();
        }

        #endregion
    }
}