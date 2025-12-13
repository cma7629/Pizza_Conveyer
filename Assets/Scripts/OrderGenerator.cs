using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class OrderGenerator : MonoBehaviour
{
    public Order currentOrder;

    public delegate void OnOrderGenerated(Order order);
    public static event OnOrderGenerated OrderGenerated;

    public void GenerateNewOrder()
    {
        currentOrder = new Order();
        currentOrder.orderName = "Order #" + Random.Range(1000, 9999);

        int toppingCount = Random.Range(1, 5); // 1–4 toppings

        // Get ALL toppings
        List<ToppingType> allToppings =
            System.Enum.GetValues(typeof(ToppingType))
            .Cast<ToppingType>()
            .ToList();

        // 🚫 REMOVE base ingredients
        allToppings.Remove(ToppingType.Sauce);
        allToppings.Remove(ToppingType.Cheese);

        // Pick random toppings
        for (int i = 0; i < toppingCount && allToppings.Count > 0; i++)
        {
            int index = Random.Range(0, allToppings.Count);
            currentOrder.requiredToppings.Add(allToppings[index]);
            allToppings.RemoveAt(index);
        }

        Debug.Log("Generated Order (no sauce/cheese as toppings)");

        OrderGenerated?.Invoke(currentOrder);
    }
}