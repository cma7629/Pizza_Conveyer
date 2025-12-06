using UnityEngine;
using TMPro;
using System.Text;

public class OrderSlip : MonoBehaviour
{
    public TextMeshProUGUI orderText;

    public void SetOrder(Order order)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(order.orderName);
        sb.AppendLine("---------------");
        sb.AppendLine("Sauce: YES");
        sb.AppendLine("Cheese: YES");

        sb.AppendLine("Toppings:");
        foreach (var topping in order.requiredToppings)
        {
            sb.AppendLine("- " + topping.ToString());
        }

        orderText.text = sb.ToString();
    }
}
