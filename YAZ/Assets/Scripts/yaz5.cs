using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yaz5 : GameManager
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Chocar();
            Debug.Log(GameManager.lives);
            //Destroy(other.gameObject);
        }
    }
}
