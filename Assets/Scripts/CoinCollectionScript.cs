using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class CoinCollectionScript : MonoBehaviour
{
    public CoinCountScript coinCountScript;
    public TextMeshProUGUI text;

    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag.Equals("Player")) {
            Destroy(gameObject);
            coinCountScript.IncreaseCount();
            text.text = "Coins: " + coinCountScript.numberOfCoins;
        }
    }

}
