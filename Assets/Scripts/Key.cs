using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public AudioClip keysound;
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
        if (playerInventory != null)
        {
            playerInventory.KeyCollected();
            gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(keysound, transform.position);
        }
    }
}
