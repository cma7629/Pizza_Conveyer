using UnityEngine;

public class PizzaEvaluator : MonoBehaviour
{
    public OrderGenerator orderGenerator;
    public MoneyManager moneyManager;

    private const int BASE_PRICE = 15;
    private const int PRICE_PER_TOPPING = 1;

    public void EvaluatePizza(PizzaBuild pizza)
    {
        Debug.Log("🍕 EvaluatePizza() CALLED");

        if (orderGenerator == null)
        {
            Debug.LogError("❌ OrderGenerator reference is NULL");
            return;
        }

        Order order = orderGenerator.currentOrder;

        if (order == null)
        {
            Debug.LogError("❌ currentOrder is NULL (bell probably not pressed)");
            return;
        }

        Debug.Log($"📄 Evaluating order: {order.orderName}");

        bool isCorrect = CheckCorrectness(pizza, order);

        Debug.Log("🧪 Correctness result: " + isCorrect);

        if (!isCorrect)
        {
            Debug.Log("❌ Pizza incorrect → $0 earned");
            return;
        }

        int toppingCount = CountToppingsOnPizza(pizza);
        int moneyEarned = BASE_PRICE + toppingCount * PRICE_PER_TOPPING;

        Debug.Log($"💰 Pizza correct → Earned ${moneyEarned}");

        moneyManager.AddMoney(moneyEarned);
    }

    private bool CheckCorrectness(PizzaBuild pizza, Order order)
    {
        Debug.Log("🔍 Checking base ingredients...");

        if (!pizza.hasSauce)
        {
            Debug.Log("❌ Missing Sauce");
            return false;
        }

        if (!pizza.hasCheese)
        {
            Debug.Log("❌ Missing Cheese");
            return false;
        }

        Debug.Log("🔍 Checking required toppings...");

        foreach (var topping in order.requiredToppings)
        {
            if (!PizzaHasTopping(pizza, topping))
            {
                Debug.Log($"❌ Missing required topping: {topping}");
                return false;
            }
        }

        Debug.Log("🔍 Checking for extra toppings...");

        if (HasExtraToppings(pizza, order))
        {
            Debug.Log("❌ Extra topping found");
            return false;
        }

        Debug.Log("✅ Pizza passed all checks");
        return true;
    }

    private bool HasExtraToppings(PizzaBuild pizza, Order order)
    {
        bool Extra(ToppingType t, bool hasIt) =>
            hasIt && !order.requiredToppings.Contains(t);

        return
            Extra(ToppingType.Pepperoni, pizza.hasPepperoni) ||
            Extra(ToppingType.Anchovy, pizza.hasAnchovy) ||
            Extra(ToppingType.Mushroom, pizza.hasMushroom) ||
            Extra(ToppingType.Pepper_Green, pizza.hasPepperGreen) ||
            Extra(ToppingType.Olive_Green, pizza.hasOliveGreen) ||
            Extra(ToppingType.Olive_Black, pizza.hasOliveBlack) ||
            Extra(ToppingType.Bacon, pizza.hasBacon) ||
            Extra(ToppingType.Beef, pizza.hasBeef) ||
            Extra(ToppingType.Onion, pizza.hasOnion) ||
            Extra(ToppingType.Pineapple, pizza.hasPineapple);
    }

    private bool PizzaHasTopping(PizzaBuild pizza, ToppingType type)
    {
        return type switch
        {
            ToppingType.Pepperoni => pizza.hasPepperoni,
            ToppingType.Anchovy => pizza.hasAnchovy,
            ToppingType.Mushroom => pizza.hasMushroom,
            ToppingType.Pepper_Green => pizza.hasPepperGreen,
            ToppingType.Olive_Green => pizza.hasOliveGreen,
            ToppingType.Olive_Black => pizza.hasOliveBlack,
            ToppingType.Bacon => pizza.hasBacon,
            ToppingType.Beef => pizza.hasBeef,
            ToppingType.Onion => pizza.hasOnion,
            ToppingType.Pineapple => pizza.hasPineapple,
            _ => false
        };
    }

    private int CountToppingsOnPizza(PizzaBuild pizza)
    {
        int count = 0;
        if (pizza.hasPepperoni) count++;
        if (pizza.hasAnchovy) count++;
        if (pizza.hasMushroom) count++;
        if (pizza.hasPepperGreen) count++;
        if (pizza.hasOliveGreen) count++;
        if (pizza.hasOliveBlack) count++;
        if (pizza.hasBacon) count++;
        if (pizza.hasBeef) count++;
        if (pizza.hasOnion) count++;
        if (pizza.hasPineapple) count++;
        return count;
    }
}