using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerPurchaseScript : MonoBehaviour
{
    
    public CoinCountScript coinCountScript;

    public int itemcost = 1;
    public TextMeshProUGUI text;

    public void DropCoin(InputAction.CallbackContext context) {
        if(context.performed && IsPlayerInShop()) {
            int initCoinCount = coinCountScript.numberOfCoins;
            coinCountScript.DecreaseCount();
            int finalCoinCount = coinCountScript.numberOfCoins;
            if(initCoinCount == finalCoinCount) {
                //TODO add logic when player does not have enough coins to make transaction
            } else {
                Debug.Log("Item Bought!");
                text.text = "Coins: " + finalCoinCount;
                //TODO also add logic to give player the item that they purchased
            }
        }  
    }

    bool IsPlayerInShop() {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 1f);
        foreach (Collider2D collider in colliders) {
            if(collider.gameObject.name == "Shop") {
                return true;
            }
        }
        return false;
    }
}
