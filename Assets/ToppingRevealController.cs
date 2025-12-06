using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToppingRevealController : MonoBehaviour
{
    [System.Serializable]
    public class Topping
    {
        public string toppingName;        // e.g. "Pepperoni"
        public Renderer[] renderers;      // assign the renderers of that topping
    }

    public Topping[] toppings;

    void Start()
    {
        // Hide all toppings at the start
        foreach (var t in toppings)
        {
            foreach (var r in t.renderers)
                r.enabled = false;
        }
    }

    public void RevealTopping(string toppingName)
    {
        foreach (var t in toppings)
        {
            if (t.toppingName == toppingName)
            {
                foreach (var r in t.renderers)
                    r.enabled = true;
            }
        }
    }
}