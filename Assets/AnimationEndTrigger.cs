using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEndTrigger : MonoBehaviour
{
    public void OnAnimationEnd (Order order, PizzaBuild pizza){
        //Cross reference order and pizza
        foreach (var topping in pizza.appliedToppings) //for each topping on pizza
        {
            if (order.requiredToppings.Contains(topping)) 
            {
                //pass
            }
            else {
                //fail
            }
            
        }
        foreach (var topping in order.requiredToppings) //second pass to cross reference
        {
            if (pizza.appliedToppings.Contains(topping))
            {
                //pass
            }
            else
            {
                //fail
            }
        }
        //pizza.RemoveAll(pizza); //remove all toppings
    }
    
}


