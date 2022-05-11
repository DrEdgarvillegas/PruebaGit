using System;
using System.Collections.Generic;
using System.Text;

namespace Pract8Ejer1
{
    public sealed class Singleton
    {
        private Singleton() { }

        private static Singleton _countries;

        private static Singleton _provinces;


        public static Singleton getCountries() 
    {
        if (_countries == null) 
        {
            _countries = new Singleton();
        }

        return _countries;
    }

    

    }
}
