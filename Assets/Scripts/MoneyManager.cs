using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public int totalMoney = 0;

    public delegate void MoneyChanged(int newTotal);
    public static event MoneyChanged OnMoneyChanged;

    public void AddMoney(int amount)
    {
        totalMoney += amount;
        Debug.Log($"💰 Earned ${amount} | Total: ${totalMoney}");

        OnMoneyChanged?.Invoke(totalMoney);
    }
}