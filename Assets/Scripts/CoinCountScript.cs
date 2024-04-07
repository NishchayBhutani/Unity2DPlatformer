using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinCountScript : MonoBehaviour
{

    public int numberOfCoins = 0;

    public void IncreaseCount() {
        numberOfCoins++;
    }

    public void IncreaseCount(int count) {
        numberOfCoins+=count;
    }

    public void DecreaseCount() {
        if(numberOfCoins == 0) {
            Debug.Log("don't have enough coins");
            return;
        }
        numberOfCoins--;
    }

    public void DecreaseCount(int count) {
        if(numberOfCoins < count) {
            Debug.Log("don't have enough coins");
            return;
        }
        numberOfCoins-=count;
    }

}
