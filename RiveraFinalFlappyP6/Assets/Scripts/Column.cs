using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    { 
         if (collision.gameObject.GetComponent<Bird>() != null)
        {
            GameControl.instance.BirdScored();
        }
    }
}

