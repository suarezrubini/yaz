using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Invoke(nameof(Spawn), 2);
        StartCoroutine("SpaceTest");
    }
    IEnumerator SpaceTest()
    {
       /*private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag != "Space")
            {
                //Destroy(this.gameObject);
                Debug.Log("Nave destruida");
            }*/
        yield return new WaitForSeconds(2f);
        

    }
        void Update()
        {
        }
}


