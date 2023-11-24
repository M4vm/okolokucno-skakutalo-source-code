using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BDcoin : MonoBehaviour
{

    public GameObject gun;
    public GameObject trumpet;
    public GameObject dagger;

        public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "BDCoin")
        {
            Debug.Log("Dagger Coin Collected!");
            gun.SetActive(false);
            dagger.SetActive(true);
            trumpet.SetActive(false);
        }
    }
}