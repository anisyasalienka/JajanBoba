﻿using System;

namespace JajanBoba
{
    class Customer
    {
        private static int id = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string DrinkOrder { get; set; }

        public Customer()
        {
            this.Id = InputId();
        }

        private static int InputId()
        {
            return id++;
        }
    }
}