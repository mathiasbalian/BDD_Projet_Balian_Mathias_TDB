﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDD_Projet_Balian_Mathias_TDB
{
    public partial class OrderDetails : Form
    {
        private int orderId;

        public OrderDetails(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
        }


        private void getOrderDetails()
        {

        }

    }
}