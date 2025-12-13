using UnityEngine;

public class OrderBell : MonoBehaviour
{
    public OrderGenerator orderGenerator;
    public PizzaSpawner pizzaSpawner;

    private bool canPress = true;

    private void OnTriggerEnter(Collider other)
    {
        if (!canPress) return;

        canPress = false;

        // Generate order
        orderGenerator.GenerateNewOrder();

        // Spawn pizza
        pizzaSpawner.SpawnPizza();

        Invoke(nameof(ResetPress), 1f);
    }

    void ResetPress()
    {
        canPress = true;
    }
}
