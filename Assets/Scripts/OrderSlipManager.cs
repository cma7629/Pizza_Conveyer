using UnityEngine;

public class OrderSlipManager : MonoBehaviour
{
    public GameObject orderSlipPrefab;
    public Transform slipSpawnPoint;

    public void SpawnSlip(Order order)
    {
        GameObject slip = Instantiate(orderSlipPrefab, slipSpawnPoint.position, slipSpawnPoint.rotation);

        OrderSlip slipScript = slip.GetComponent<OrderSlip>();
        slipScript.SetOrder(order);
    }
}
