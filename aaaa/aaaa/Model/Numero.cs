using aaaa.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace aaaa.Model
{
    public class Numero : BaseViewModel
    {
        public int id { get; set; }
        private int _numba;
        public int numba { get { return _numba; } set { _numba = value; OnPropertyChanged(); } }

    }
}
