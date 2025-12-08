using System.Collections.Generic;
using UnityEngine;

public enum ToppingType
{
    Sauce,
    Cheese,
    Mushroom,
    Pepper_Green,
    Anchovy,
    Bacon,
    Beef,
    Onion,
    Olive_Green,
    Olive_Black,
    Pepperoni,
    Pineapple
}

public class Order
{
    public string orderName;
    public List<ToppingType> requiredToppings = new List<ToppingType>();
    public bool needsToBeBaked = true;
}
