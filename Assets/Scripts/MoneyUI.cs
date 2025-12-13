using UnityEngine;
using TMPro;

public class MoneyUI : MonoBehaviour
{
    public TextMeshProUGUI moneyText;

    private void OnEnable()
    {
        MoneyManager.OnMoneyChanged += UpdateMoneyUI;
    }

    private void OnDisable()
    {
        MoneyManager.OnMoneyChanged -= UpdateMoneyUI;
    }

    private void Start()
    {
        UpdateMoneyUI(0);
    }

    void UpdateMoneyUI(int amount)
    {
        moneyText.text = $"${amount}";
    }
}