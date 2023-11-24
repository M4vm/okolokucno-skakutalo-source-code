using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPManager : MonoBehaviour
{
    public GameObject ppv;
    
    void Update () {

        if (Input.GetKeyDown(KeyCode.P))
        {

            bool isActive = ppv.activeSelf;
 
            ppv.SetActive(!isActive);
        }
    }
}
