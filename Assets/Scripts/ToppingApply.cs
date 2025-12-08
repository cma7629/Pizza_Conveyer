using UnityEngine;

public class ToppingApply : MonoBehaviour
{
    public ToppingType toppingType;

    private void OnTriggerEnter(Collider other)
    {
        // Try to get a PizzaBuild component from the collided object or its parent
        PizzaBuild pizza = other.GetComponentInParent<PizzaBuild>();

        if (pizza != null)
        {
            pizza.ApplyTopping(toppingType);

            // Destroy the pickup topping so it disappears from the player's hand
            Destroy(gameObject);
        }
    }
}