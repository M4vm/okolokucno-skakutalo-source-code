using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinColllectPlayer : MonoBehaviour
{

    public int coins;
    public GameObject trumpet_coin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(coins == 15)
        {
            trumpet_coin.SetActive(true);
        }
    }

    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Coin")
        {
            Debug.Log("Coin Collected!");
            coins = coins + 1;
        }
    }
}
