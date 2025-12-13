using UnityEngine;

public class PizzaSpawner : MonoBehaviour
{
    [Header("Spawn Setup")]
    public GameObject pizzaPrefab;
    public Transform spawnPoint;

    private GameObject currentPizza;

    public void SpawnPizza()
    {
        // Prevent spawning multiple pizzas at once
        if (currentPizza != null)
        {
            Debug.Log("⚠ Pizza already exists!");
            return;
        }

        currentPizza = Instantiate(
            pizzaPrefab,
            spawnPoint.position,
            spawnPoint.rotation
        );
    }

    // Called by EndZone when pizza is destroyed
    public void ClearCurrentPizza()
    {
        currentPizza = null;
    }
}
