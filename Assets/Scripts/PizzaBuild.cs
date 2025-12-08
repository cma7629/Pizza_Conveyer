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

    public bool hasSauce = false;
    public bool hasCheese = false;

    public List<ToppingType> appliedToppings = new List<ToppingType>();

    public void ApplyTopping(ToppingType type)
    {
        if (!appliedToppings.Contains(type))
            appliedToppings.Add(type);

        EnableLayer(type);
    }

    void EnableLayer(ToppingType type)
    {
        switch (type)
        {
            case ToppingType.Sauce:
                if (sauceLayer != null)
                {
                    sauceLayer.SetActive(true);
                    hasSauce = true;
                }
                break;

            case ToppingType.Cheese:
                if (cheeseLayer != null)
                {
                    cheeseLayer.SetActive(true);
                    hasCheese = true;
                }
                break;

            case ToppingType.Mushroom:
                mushroomLayer?.SetActive(true);
                break;

            case ToppingType.Pepper_Green:
                pepperGreenLayer?.SetActive(true);
                break;

            case ToppingType.Anchovy:
                anchovyLayer?.SetActive(true);
                break;

            case ToppingType.Bacon:
                baconLayer?.SetActive(true);
                break;

            case ToppingType.Beef:
                beefLayer?.SetActive(true);
                break;

            case ToppingType.Onion:
                onionLayer?.SetActive(true);
                break;

            case ToppingType.Olive_Green:
                oliveGreenLayer?.SetActive(true);
                break;

            case ToppingType.Olive_Black:
                oliveBlackLayer?.SetActive(true);
                break;

            case ToppingType.Pepperoni:
                pepperoniLayer?.SetActive(true);
                break;

            case ToppingType.Pineapple:
                pineappleLayer?.SetActive(true);
                break;
        }
    }
}