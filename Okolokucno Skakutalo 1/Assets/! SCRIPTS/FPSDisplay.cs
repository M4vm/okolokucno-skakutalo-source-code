using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class FPSDisplay : MonoBehaviour
{
    private float count;
    
    private IEnumerator Start()
    {
        GUI.depth = 2;
        while (true)
        {
            count = 1f / Time.unscaledDeltaTime;
            yield return new WaitForSeconds(0.1f);
        }
    }
    
    private void OnGUI()
    {
        GUI.Label(new Rect(5, 5, 100, 25), "FPS: " + Mathf.Round(count));
    }
}
