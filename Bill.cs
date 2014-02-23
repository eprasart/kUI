﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Kredit.UI
{
    public partial class Bill : ButtonFlat
    {
        private double mAmount;
        public bool DecimalPoint { get; set; }

        public Bill()
        {
            InitializeComponent();
        }

        public double Amount
        {
            set
            {
                mAmount = value;
                //todo: Currency symbol should be from db
                string s = "$";
                if (DecimalPoint)
                    s += mAmount.ToString("N02");
                else
                    s += mAmount.ToString();
                Text = s;
            }
            get { return mAmount; }
        }
    }
}
