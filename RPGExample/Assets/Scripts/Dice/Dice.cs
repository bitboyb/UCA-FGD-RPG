using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dice
{
    [Serializable]
    public class Dice
    {
        public int sides;

        public void Roll()
        {
            Debug.Log("Dice " + sides + " :: " + UnityEngine.Random.Range(1, sides + 1));
        }
    }
}