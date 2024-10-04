using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dice
{
    public class DiceManager : MonoBehaviour
    {
        public void Start()
        {
            CreateDice(6);
            CreateDice(12);
            CreateDice(20);
            RollAllDice();
        }

        public List<Dice> dice = new List<Dice>();
        public void CreateDice(int sides)
        {
            var newDice = new Dice();
            newDice.sides = sides;
            dice.Add(newDice);
        }

        public void RollAllDice()
        {
            foreach (Dice d in dice) d.Roll();
        }
    }
}