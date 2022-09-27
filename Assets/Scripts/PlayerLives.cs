using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerLives : MonoBehaviour
{
    public int lives;
    public Transform spawnPoint;
    public UnityEvent<PlayerLives> OnLifeLoss;
    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
    }
    void Update()
    {
        if (lives < 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    // Update is called once per frame
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy") {
            lives--;
            gameObject.transform.position = spawnPoint.position;
            OnLifeLoss.Invoke(this);
        }
    }
}
