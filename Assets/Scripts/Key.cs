using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public static int Count = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Collectible")){
            Destroy(collision.gameObject);
            Count++;
            Debug.Log(Count);
        }
    }
}
