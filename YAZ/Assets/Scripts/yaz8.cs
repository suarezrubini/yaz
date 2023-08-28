using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yaz8 : MonoBehaviour
{
    [SerializeField] GameObject obstacle;

    // test para ver si al chocar vamos a GameOver

    public yaz3 movement;
    public GameManager gameManager;
    private void OnCollisionEnter(Collision otherObj)
    {
        if (otherObj.gameObject.tag == "Obstacle")
        {
            Destroy(obstacle,.5f);
            //Debug.Log("Obstaculo destruido");
            //FindObjectOfType<GameManager>().EndGame();
        }
    }

    void Update()
    {
        
    }
}
