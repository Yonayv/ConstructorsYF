using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsYF
{
    class Game
    {
        /// <summary>
        /// The Game class constructer was made to initialize the params values
        /// The public string game holds the the strings' titleParam and genreParam
        /// The title and genres' value equal to the titleParam and genreParam
        /// 
        /// </summary>
        /// 

        public string title, genre; 

        public Game(string titleParam = "Unknown Title", string genreParam = "Casual") 
        {

            title = titleParam;
            genre = genreParam;
        
        }
        

    }
}
