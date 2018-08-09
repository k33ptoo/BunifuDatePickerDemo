// ***********************************************************************
// Assembly         : BunifuDatePickerDemo
// Author           : KeepToo
// Created          : 08-03-2018
//
// Last Modified By : KeepToo
// Last Modified On : 08-08-2018
// ***********************************************************************
// <copyright file="Home.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BunifuDatePickerDemo
{
    /// <summary>
    /// Class Home.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Home : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Home"/> class.
        /// </summary>
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            DateTime result = DateTime.Today.Subtract(TimeSpan.FromDays(1));
            bunifuDatePicker1.Value = result;
        }
    }
}
