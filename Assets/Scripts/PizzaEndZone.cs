using UnityEngine;

public class PizzaEndZone : MonoBehaviour
{
    [Header("References")]
    public PizzaEvaluator pizzaEvaluator;
    public PizzaSpawner pizzaSpawner;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("🏁 Pizza reached end zone");
        // Find the PizzaBuild on the object or its parent
        PizzaBuild pizza = other.GetComponentInParent<PizzaBuild>();
        if (pizza == null)
            return;

        // Stop pizza movement
        PizzaMover mover = pizza.GetComponent<PizzaMover>();
        if (mover != null)
            mover.StopMoving();

        // Evaluate pizza (money + correctness)
        if (pizzaEvaluator != null)
        {
            pizzaEvaluator.EvaluatePizza(pizza);
        }
        else
        {
            Debug.LogError("❌ PizzaEvaluator not assigned on PizzaEndZone!");
        }

        // Clear the current pizza from the spawner
        if (pizzaSpawner != null)
        {
            pizzaSpawner.ClearCurrentPizza();
        }
        else
        {
            Debug.LogWarning("⚠ PizzaSpawner not assigned on PizzaEndZone.");
        }

        // Destroy pizza after short delay
        Destroy(pizza.gameObject, 1f);
    }
}
