using UnityEngine;
using System.Linq;

public class OrderGenerator : MonoBehaviour
{
    public Order currentOrder;

    public delegate void OnOrderGenerated(Order order);
    public static event OnOrderGenerated OrderGenerated;

    public void GenerateNewOrder()
    {
        currentOrder = new Order();

        // Random name
        currentOrder.orderName = "Order #" + Random.Range(1000, 9999);

        // Random number of toppings
        int toppingCount = Random.Range(1, 5); // 1 to 4 toppings

        // Get all possible topping types
        var allToppings = System.Enum.GetValues(typeof(ToppingType)).Cast<ToppingType>().ToList();

        // Shuffle and pick the first N toppings
        for (int i = 0; i < toppingCount; i++)
        {
            int index = Random.Range(0, allToppings.Count);
            currentOrder.requiredToppings.Add(allToppings[index]);
            allToppings.RemoveAt(index); // prevent duplicates
        }

        Debug.Log("Generated Random Order!");

        OrderGenerated?.Invoke(currentOrder);
    }
}