using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrumpetCoin : MonoBehaviour
{

    public GameObject gun;
    public GameObject trumpet;
    public GameObject dagger;

        public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "TCoin")
        {
            Debug.Log("Trumpet Coin Collected!");
            gun.SetActive(false);
            dagger.SetActive(false);
            trumpet.SetActive(true);
        }
    }
}