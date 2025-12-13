using UnityEngine;
using TMPro;

public class OrderCanvasUI : MonoBehaviour
{
    public TextMeshProUGUI orderText;

    private void OnEnable()
    {
        OrderGenerator.OrderGenerated += UpdateOrder;
    }

    private void OnDisable()
    {
        OrderGenerator.OrderGenerated -= UpdateOrder;
    }

    void UpdateOrder(Order order)
    {
        string text = $"{order.orderName}\n";
        text += "----------------\n";
        text += "Base:\n";
        text += "- Sauce\n";
        text += "- Cheese\n\n";
        text += "Toppings:\n";

        foreach (var topping in order.requiredToppings)
        {
            text += "- " + topping.ToString().Replace("_", " ") + "\n";
        }

        orderText.text = text;
    }
}