using UnityEngine;

public class PizzaEvaluator : MonoBehaviour
{
    public int Evaluate(Order order, PizzaBuild pizza)
    {
        int score = 0;

        // Sauce & cheese always required
        if (pizza.hasSauce) score += 20;
        if (pizza.hasCheese) score += 20;

        foreach (var topping in order.requiredToppings)
        {
            if (pizza.appliedToppings.Contains(topping))
                score += 10;
        }

        return score;
    }
}
