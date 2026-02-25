using UnityEngine;

public class FullHealPickup : MonoBehaviour
{
    public GameObject pickupEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Heal up player to the maximum health if collide
        if (collision.tag == "Player")
        {
            Health playerHealth = collision.gameObject.GetComponent<Health>();
            playerHealth.ReceiveHealing(playerHealth.maximumHealth);
            if (pickupEffect != null)
            {
                Instantiate(pickupEffect, transform.position, Quaternion.identity);
            }
            Destroy(this.gameObject);
        }
    }
}
