﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsYF
{
    class Game
    {

        public string title, genre; 

        public Game(string titleParam = "Unknown Title", string genreParam = "Casual") 
        {

            title = titleParam;
            genre = genreParam;
        
        }
        

    }
}