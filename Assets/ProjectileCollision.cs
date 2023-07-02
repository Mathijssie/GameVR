using UnityEngine;

public class ProjectileCollision : MonoBehaviour
{
    public Transform startPoint; // Referentie naar het gameobject StartPoint

    private void OnTriggerEnter(Collider other)
    {
        // Controleer of de geraakte collider de speler is
        if (other.CompareTag("Player"))
        {
            // Log een debugbericht
            Debug.Log("De speler is geraakt!");

            // Teleporteer de speler naar het StartPoint
            other.transform.position = startPoint.position;
        }
    }
}
