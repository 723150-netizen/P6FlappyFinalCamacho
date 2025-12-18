using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    private void OnTriggerEnter2D (Collision2D collision)
    { 
         if (gameObject.GetComponent<Bird>() != null)
        {
            GameControl.instance.BirdScored();
        }
    }
}

