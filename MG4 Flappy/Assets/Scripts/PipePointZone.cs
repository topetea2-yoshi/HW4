using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePointZone : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            Player Player = other.GetComponent<Player>();
            if (Player != null)
            {
                Player.AddScore();
            }
        }
    }
   
}
