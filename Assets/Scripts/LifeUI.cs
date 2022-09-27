using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifeUI : MonoBehaviour
{
    // Start is called before the first frame update
    private TextMeshProUGUI livesAmount;
    // Start is called before the first frame update
    void Start()
    {
        livesAmount = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void UpdateLives(PlayerLives playerLives)
    {
        livesAmount.text = playerLives.lives.ToString();
    }
}
