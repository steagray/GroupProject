﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProject
{
    class gameFactory
    {
        private Uri getCoverArt(string title)
        {
            //temporary
            return new Uri("https://static.wikia.nocookie.net/senkizesshousymphogear/images/4/45/Symphogear_GX_Character_Song_8.png/revision/latest/scale-to-width-down/300?cb=20200728003041");
        }

        public game createGame(string title, string filePath, DateTime lastPlayed, double fileSize, DateTime lastUpdated)
        {
            try
            {
                return createSteamGame(title, filePath, lastPlayed, fileSize, lastUpdated, -1);
            }
            catch
            {
                return new game(title, filePath, getCoverArt(title), lastPlayed, fileSize, lastUpdated);
            }
        }

        public steamGame createSteamGame(string title, string filePath, DateTime lastPlayed, double fileSize, DateTime lastUpdated, int appID = -1)
        {
            throw new Exception("This is just for testing purposes bc I want to compile this sometime soon.");
        }

    }

    
}