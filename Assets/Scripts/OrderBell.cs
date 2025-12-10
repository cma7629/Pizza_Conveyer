using UnityEngine;

public class OrderBell : MonoBehaviour
{
    public OrderGenerator orderGenerator;
    public OrderSlipManager slipManager;

    private bool canPress = true;

    private void OnTriggerEnter(Collider other)
    {
        // You can change this to detect hand, controller, or specific object tag
        if (canPress)
        {
            GenerateOrder();
            //start pizza animation
        }
    }

    private void GenerateOrder()
    {
        canPress = false;

        // Generate new order
        orderGenerator.GenerateNewOrder();

        // Create slip with that order on it
        slipManager.SpawnSlip(orderGenerator.currentOrder);

        // Cooldown
        Invoke(nameof(ResetPress), 1f);
    }

    void ResetPress()
    {
        canPress = true;
    }
}
