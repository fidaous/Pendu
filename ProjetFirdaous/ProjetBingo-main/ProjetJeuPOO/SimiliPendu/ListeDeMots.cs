﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliPendu
{
    class ListeDeMots
    {
        private string text;
        private int length;
        private List<string> mots = new List<string>();
    
        public ListeDeMots()
    {
            Mots.Add("banane");
            Mots.Add("pomme");
            Mots.Add("poire");
            Mots.Add("framboise");
            Mots.Add("fraise");
            Mots.Add("orange");
            Mots.Add("ananas");
     }

       

       public string  GetMotauHasard()
           {
             Random rand = new Random();
             int indice = rand.Next(0, 6);

            string mots = Mots[indice];

            return mots;
            
        }


        
        


        public string Text { get => text; set => text = value; }
    public int Length { get => length; set => length = value; }
        public List<string> Mots { get => mots; set => mots = value; }
    }
}
