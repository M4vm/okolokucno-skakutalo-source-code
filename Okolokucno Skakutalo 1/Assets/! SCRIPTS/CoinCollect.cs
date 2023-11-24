using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{

    public GameObject LevelCoin;
    public GameObject Trigger;

    public void OnTriggerEnter(Collider Col)
     {
        LevelCoin.SetActive(true);
        Trigger.SetActive(false);
     }
}
