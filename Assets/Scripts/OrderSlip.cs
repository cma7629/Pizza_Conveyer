using UnityEngine;
using TMPro;
using System.Text;
using System.Linq;

public class OrderSlip : MonoBehaviour
{
    [Tooltip("Assign the TextMeshPro component used to display the slip. Use 'Text (UI)' for Canvas UI (TextMeshProUGUI) or a 3D TextMeshPro object.")]
    public TMP_Text orderText;

    public void SetOrder(Order order)
    {
        if (order == null)
        {
            Debug.LogError($"[{nameof(OrderSlip)}] SetOrder called with null order.");
            return;
        }

        if (orderText == null)
        {
            Debug.LogError($"[{nameof(OrderSlip)}] orderText is not assigned on '{gameObject.name}'. Assign the TextMeshPro component in the prefab/Inspector.");
            return;
        }

        StringBuilder sb = new StringBuilder();
        sb.AppendLine(order.orderName);
        sb.AppendLine("---------------");

        bool hasSauce = order.requiredToppings.Contains(ToppingType.Sauce);
        bool hasCheese = order.requiredToppings.Contains(ToppingType.Cheese);

        sb.AppendLine($"Sauce: {(hasSauce ? "YES" : "NO")}");
        sb.AppendLine($"Cheese: {(hasCheese ? "YES" : "NO")}");
        sb.AppendLine();
        sb.AppendLine("Toppings:");

        var otherToppings = order.requiredToppings
            .Where(t => t != ToppingType.Sauce && t != ToppingType.Cheese)
            .ToList();

        if (otherToppings.Count == 0)
        {
            sb.AppendLine("- None");
        }
        else
        {
            foreach (var topping in otherToppings)
            {
                string pretty = topping.ToString().Replace("_", " ");
                sb.AppendLine("- " + pretty);
            }
        }

        orderText.text = sb.ToString();
    }
}
