using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGraphy : MonoBehaviour
{

    public GameObject graphy;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {

            bool isActive = graphy.activeSelf;
 
            graphy.SetActive(!isActive);
        }
    }
}
