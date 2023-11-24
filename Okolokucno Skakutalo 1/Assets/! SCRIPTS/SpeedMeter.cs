using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class SpeedMeter : MonoBehaviour
{

    public Rigidbody target;

    [Header("UI")]
    public TMP_Text speedLabel;

    private float speed = 0.0f;

    void Start()
    {
        
    }

    void Update()
    {

        speed = target.velocity.magnitude;
        
        if (speedLabel != null)
            speedLabel.text = ((int)speed) + " m/s";

    }
}
