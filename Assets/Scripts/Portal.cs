using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    
    private void Start()
    {
           
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Portal"))
        {
            if(Key.Count == 4) { 
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                Key.Count = 0;
            }
        }
    }
}
