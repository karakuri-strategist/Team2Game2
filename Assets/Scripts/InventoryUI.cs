using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI keyAmount;
    // Start is called before the first frame update
    void Start()
    {
        keyAmount = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void UpdateKeys(PlayerInventory playerInventory)
    {
        keyAmount.text = playerInventory.NumberOfKeys.ToString();
    }
}
