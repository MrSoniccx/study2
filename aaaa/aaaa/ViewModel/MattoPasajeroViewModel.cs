using aaaa.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace aaaa.ViewModel
{
   
    public class MattoPasajeroViewModel
    {
        public Pasajero Pasajero { get; set; }
        public MattoPasajeroViewModel(Pasajero pasajero)
        {
            Pasajero = pasajero;
        }

    }
}
