using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 neme: mehul khosla
 date:july25,2017
 Description: this is the card class to be used n the card shuffling
 version:0.1-created card class
 */
namespace comp123_S2017_lesson11
{
    public class Card
    {
        //private instance variable
        private Face _face;
        private Suit _suit;


        //public properties

        public Face Face
        {
            get { return this._face; }
                set { this._face = value; }
            }

             public Suit Suit
        {
            get
            {
                return this._suit;
            }
            
                set { this._suit = value; }
            }

            //constructor
            /// <summary>
            /// this is the card constructor 
            /// it takes two argument face and suit
            /// </summary>
            /// <param name="face"></param>
            /// <param name="suit"></param>
            public Card (Face face , Suit suit)
        {
            this.Face = face;
            this.Suit=suit;
        }

            //private method

            //public method
        }
}