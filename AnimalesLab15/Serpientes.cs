﻿namespace AnimalesLab15
{
    public class Serpientes : Animales 
    {
        public string Venenosa { get; set; }

        public int Longitud {  get; set; }

        public Serpientes()
        {
            Venenosa = string.Empty;
        }
    }
}
