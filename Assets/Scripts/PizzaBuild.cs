using System.Collections.Generic;
using UnityEngine;

public class PizzaBuild : MonoBehaviour
{
    [Header("Base Layers")]
    public GameObject sauceLayer;
    public GameObject cheeseLayer;

    [Header("Topping Layers")]
    public GameObject mushroomLayer;
    public GameObject pepperGreenLayer;
    public GameObject anchovyLayer;
    public GameObject baconLayer;
    public GameObject beefLayer;
    public GameObject onionLayer;
    public GameObject oliveGreenLayer;
    public GameObject oliveBlackLayer;
    public GameObject pepperoniLayer;
    public GameObject pineappleLayer;

    [Header("Ingredient State (for evaluation)")]
    public bool hasSauce;
    public bool hasCheese;
    public bool hasPepperoni;
    public bool hasAnchovy;
    public bool hasMushroom;
    public bool hasPepperGreen;
    public bool hasOliveGreen;
    public bool hasOliveBlack;
    public bool hasBacon;
    public bool hasBeef;
    public bool hasOnion;
    public bool hasPineapple;

    // Optional: useful for debugging or generic loops
    public List<ToppingType> appliedToppings = new List<ToppingType>();

    public void ApplyTopping(ToppingType type)
    {
        if (!appliedToppings.Contains(type))
            appliedToppings.Add(type);

        EnableLayer(type);
    }

    private void EnableLayer(ToppingType type)
    {
        switch (type)
        {
            case ToppingType.Sauce:
                sauceLayer?.SetActive(true);
                hasSauce = true;
                break;

            case ToppingType.Cheese:
                cheeseLayer?.SetActive(true);
                hasCheese = true;
                break;

            case ToppingType.Mushroom:
                mushroomLayer?.SetActive(true);
                hasMushroom = true;
                break;

            case ToppingType.Pepper_Green:
                pepperGreenLayer?.SetActive(true);
                hasPepperGreen = true;
                break;

            case ToppingType.Anchovy:
                anchovyLayer?.SetActive(true);
                hasAnchovy = true;
                break;

            case ToppingType.Bacon:
                baconLayer?.SetActive(true);
                hasBacon = true;
                break;

            case ToppingType.Beef:
                beefLayer?.SetActive(true);
                hasBeef = true;
                break;

            case ToppingType.Onion:
                onionLayer?.SetActive(true);
                hasOnion = true;
                break;

            case ToppingType.Olive_Green:
                oliveGreenLayer?.SetActive(true);
                hasOliveGreen = true;
                break;

            case ToppingType.Olive_Black:
                oliveBlackLayer?.SetActive(true);
                hasOliveBlack = true;
                break;

            case ToppingType.Pepperoni:
                pepperoniLayer?.SetActive(true);
                hasPepperoni = true;
                break;

            case ToppingType.Pineapple:
                pineappleLayer?.SetActive(true);
                hasPineapple = true;
                break;
        }
    }
}