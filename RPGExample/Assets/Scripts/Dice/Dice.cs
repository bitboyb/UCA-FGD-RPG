using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dice
{
    // the "[Serializable]" macro tells unity that this class can be used in the inspector like other data types
    [Serializable]
    public class Dice
    {
        // this is declaring a data type, in this case, an integer which is a whole number like 0 , 10 , 256
        public int sides;

        // This is a method/function which rolls this specific dice!
        public void Roll()
        {
            // "Debug" is a class found in the UnityEngine namespace which is used to print to console
            // ".Log" is a method/function found in the class to print the information in the ()
            Debug.Log("Dice " + sides + " :: " + UnityEngine.Random.Range(1, sides + 1));
        }
    }
}