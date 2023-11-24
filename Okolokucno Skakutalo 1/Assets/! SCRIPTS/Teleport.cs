 using UnityEngine;
 public class Teleport : MonoBehaviour { 
     public Transform Destination;
     public Transform player;
     void Start() {
     }
     public void OnTriggerEnter(Collider other) { 
        player.transform.position = Destination.transform.position;
     }
 }