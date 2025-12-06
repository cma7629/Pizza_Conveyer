using System.Collections.Generic;
using UnityEngine;

public enum ToppingType
{
    Pepperoni,
    Beef,
    Bacon,
    Anchovie,
    Mushroom,
    Onion,
    Pepper,
    Pineapple,
    OliveBlack,
    OliveGreen
}

public class Order
{
    public string orderName;
    public List<ToppingType> requiredToppings = new List<ToppingType>();
    public bool needsToBeBaked = true;
}
