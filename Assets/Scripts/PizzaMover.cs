using UnityEngine;

public class PizzaMover : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    public bool isMoving = true;

    void Update()
    {
        if (isMoving)
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
    }

    public void StopMoving()
    {
        isMoving = false;
    }
}