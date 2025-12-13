using UnityEngine;

public class InfiniteToppingSpawner : MonoBehaviour
{
    public GameObject toppingPrefab;
    public Transform spawnPoint;

    private GameObject currentTopping;

    // How far the topping must move before we respawn
    public float respawnDistance = 0.25f;

    void Start()
    {
        SpawnTopping();
    }

    void Update()
    {
        if (currentTopping == null)
        {
            SpawnTopping();
            return;
        }

        float distance = Vector3.Distance(
            currentTopping.transform.position,
            spawnPoint.position
        );

        // If player moved it away → spawn a new one
        if (distance > respawnDistance)
        {
            currentTopping = null;
            SpawnTopping();
        }
    }

    void SpawnTopping()
    {
        if (toppingPrefab == null || spawnPoint == null)
        {
            Debug.LogError("❌ Topping prefab or spawn point not assigned!");
            return;
        }

        currentTopping = Instantiate(
            toppingPrefab,
            spawnPoint.position,
            spawnPoint.rotation
        );
    }
}