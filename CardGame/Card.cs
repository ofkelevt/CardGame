using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Card
    {
        private int val;//ערך 
        private int suit;//צורה
        
        public Card(int val, int suit)
        {
            this.suit = suit;
            this.val = val;
        }
        public int getVal() { return val; } 
        public int getSuit() {  return suit; }

        public override string ToString()
        {
            string result = "";
            switch (val)
            {
                 
                case 1: result = "A"; 
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:result += val + " ";
                    break;
                case 11:result += "J ";
                break;
                case 12:result += "Q ";
                    break;
                    case 13:result += "K ";
                    break;
                default: result = "error";
                    break;
            }
            switch (suit)
            {
                case 3:
                    result +="♥";
                    break;
                case 1:
                    result += "♣";
                break;
                case 4:
                    result += "♠";
                    break;  
                case 2: result += "♦";
                    break;
                    default: result += ""; 
                    break;  
            }
            return result;


        }

    }
}
