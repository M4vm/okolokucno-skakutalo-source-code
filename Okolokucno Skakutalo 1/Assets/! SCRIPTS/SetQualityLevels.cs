using UnityEngine;
using System.Collections;
 
public class SetQualityLevels : MonoBehaviour
{
    void Update ()
    {
        switch(Input.inputString)
        {
        case "1":
            QualitySettings.SetQualityLevel(0, true);
            Debug.Log("Quality settings set to 'Fastest'");
            break;
        case "2":
            QualitySettings.SetQualityLevel(1, true);
            Debug.Log("Quality settings set to 'Fast'");
            break;
        case "3":
            QualitySettings.SetQualityLevel(2, true);
            Debug.Log("Quality settings set to 'Simple'");
            break;
        case "4":
            QualitySettings.SetQualityLevel(3, true);
            Debug.Log("Quality settings set to 'Good'");
            break;
        case "5":
            QualitySettings.SetQualityLevel(4, true);
            Debug.Log("Quality settings set to 'Beautiful'");
            break;
        case "6":
            QualitySettings.SetQualityLevel(5, true);
            Debug.Log("Quality settings set to 'Fantastic'");
            break;
        default:
            Debug.Log("Button does not change the quality settings!");
            break;
        }
    }
}