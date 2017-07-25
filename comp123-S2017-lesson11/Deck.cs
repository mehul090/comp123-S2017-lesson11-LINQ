using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 neme: mehul khosla
 date:july25,2017
 Description:this is the deck class which inherits from list card
 this class sreates a new list type-card
 version:0.1-created class Deck
 */
namespace comp123_S2017_lesson11
{
    public class Deck : List<Card>
    {
        //private instace variable

        //public properties

        //constructor
        /// <summary>
        /// this is the main constructor
        /// </summary>

        public Deck()
        {
            this._initialize();
        }

        //private methods
        /// <summary>
        /// this is the private initialize method that loads the deck with card
        /// </summary>
        private void _initialize()
        {
            for (int suit = 0; suit < (int)Suit.Spades; suit++)
            {
                for (int face = 0; face < (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }

        //public methods
        /// <summary>
        /// this method overides the build in Tostring method and output the current content of deck
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            string outputString = "";
            foreach (Card card in this)
            {
                outputString += "the" + card.Face + "of" + card.Suit + "\n";
            }
            return outputString;
        }
    }
}