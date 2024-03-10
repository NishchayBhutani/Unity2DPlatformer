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

    public void DecreaseCount() {
        numberOfCoins--;
    }

}
