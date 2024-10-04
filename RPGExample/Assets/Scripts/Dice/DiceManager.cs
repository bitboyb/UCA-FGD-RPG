using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this makes the class a part of the Dice namespace, this is just a way to organise our code and we can use the "using" keyword to use theses namespaces.
namespace Dice
{
    public class DiceManager : MonoBehaviour
    {
        // this is declaring a List, which is like a bucket we can carry multiples of the same time. So it is like a bucket full of dice!
        // the "new List<Dice>()" just means we are creating a new list when this object comes into existence, it will delete anything done in the inspector.
        public List<Dice> dice = new List<Dice>();

        // this is a method/function, it is called when the object comes into existence.
        // as you can see, we are calling/running our custom methods!
        public void Start()
        {
            CreateDice(6);
            CreateDice(12);
            CreateDice(20);
            RollAllDice();
        }

        // this method creates dice and take a parameter to change the sides it has
        public void CreateDice(int sides)
        {
            // this is a local variable, it only exists inside this method
            // it is creating a new dice
            var newDice = new Dice();
            // this is changing the amount of sides on the dice
            newDice.sides = sides;
            // this is adding our dice to our list (like dropping the dice in the bucket once we have made it)
            dice.Add(newDice);
        }

        // this rolls all the dice in our bucket
        public void RollAllDice()
        {
            foreach (Dice d in dice) d.Roll();
        }
    }
}