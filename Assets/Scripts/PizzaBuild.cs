using JetBrains.Annotations;
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
    public bool hasPepperoni = false;
    public bool hasAnchovy = false;
    public bool hasBacon = false;
    public bool hasBeef = false;
    public bool hasOnion = false;
    public bool hasOliveG = false;
    public bool hasOliveB = false;
    public bool hasMushroom = false;
    public bool hasPepper = false;
    public bool hasPineapple = false;

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
                if (mushroomLayer != null)
                {
                    mushroomLayer.SetActive(true);
                    hasMushroom = true;
                }
                break;

            case ToppingType.Pepper_Green:
                if (pepperGreenLayer != null)
                {
                    pepperGreenLayer.SetActive(true);
                    hasPepper = true;
                }
                break;

            case ToppingType.Anchovy:
                if (anchovyLayer != null)
                {
                    anchovyLayer.SetActive(true);
                    hasAnchovy = true;
                }
                break;

            case ToppingType.Bacon:
                if (baconLayer != null)
                {
                    baconLayer.SetActive(true);
                    hasBacon = true;
                }
                break;

            case ToppingType.Beef:
                if (beefLayer != null)
                {
                    beefLayer.SetActive(true);
                    hasBeef = true;
                }
                break;

            case ToppingType.Onion:
                if (onionLayer != null)
                {
                    onionLayer.SetActive(true);
                    hasOnion = true;
                }
                break;

            case ToppingType.Olive_Green:
                if (oliveGreenLayer != null)
                {
                    oliveGreenLayer.SetActive(true);
                    hasOliveG = true;
                }
                break;

            case ToppingType.Olive_Black:
                if (oliveBlackLayer != null)
                {
                    oliveBlackLayer.SetActive(true);
                    hasOliveB = true;
                }
                break;

            case ToppingType.Pepperoni:
                if (pepperoniLayer != null)
                {
                    pepperoniLayer.SetActive(true);
                    hasPepperoni = true;
                }
                break;

            case ToppingType.Pineapple:
                if (pineappleLayer != null)
                {
                    pineappleLayer.SetActive(true);
                    hasPineapple = true;
                }
                break;
        }
        
    }/*
    public void RemoveAll(PizzaBuild pizza)
    {
        pizza.hasSauce = false;
        pizza.hasCheese = false;
        pizza.hasPepperoni = false;
        pizza.hasAnchovy = false;
        pizza.hasBacon = false;
        pizza.hasBeef = false;
        pizza.hasOnion = false;
        pizza.hasOliveG = false;
        pizza.hasOliveB = false;
        pizza.hasMushroom = false;
        pizza.hasPepper = false;
        pizza.hasPineapple = false;

        sauceLayer.SetActive(false);
        cheeseLayer.SetActive(false);
        mushroomLayer.SetActive(false);
        pepperGreenLayer.SetActive(false);
        anchovyLayer.SetActive(false);
        baconLayer.SetActive(false);
        beefLayer.SetActive(false);
        onionLayer.SetActive(false);
        oliveGreenLayer.SetActive(false);
        oliveBlackLayer.SetActive(false);
        pepperoniLayer.SetActive(false);
        pineappleLayer.SetActive(false);
    }
    */
}