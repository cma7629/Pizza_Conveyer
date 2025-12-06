using System.Collections.Generic;
using UnityEngine;

public class PizzaBuild : MonoBehaviour
{
    public bool hasSauce = false;
    public bool hasCheese = false;

    public List<ToppingType> appliedToppings = new List<ToppingType>();

    public void ApplySauce()
    {
        hasSauce = true;
        Debug.Log("Sauce applied.");
    }

    public void ApplyCheese()
    {
        hasCheese = true;
        Debug.Log("Cheese applied.");
    }

    public void ApplyTopping(ToppingType type)
    {
        if (!appliedToppings.Contains(type))
        {
            appliedToppings.Add(type);
            Debug.Log("Added topping: " + type);
        }
    }
}
