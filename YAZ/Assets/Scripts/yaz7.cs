using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yaz7 : MonoBehaviour
{
    //INSTANCIAR OBJETOS ALEATORIAMENTE EN EL EJE Z 
    [SerializeField] GameObject[] obst = new GameObject[0];
    Vector3 initPos = new Vector3(0, 0, 50);
    Vector3 NewPos;
    Vector3 CambioPos; 
    void Start()
    {
        //Invoke(nameof(Spawn), 2);
        StartCoroutine("SpawnObs");
    }
    IEnumerator SpawnObs()
    {
        for (int n = 0; n <= 50; n++)
        {
            int x = Random.Range(-1, 1); 
            int z = Random.Range (-200,200);
            int y = Random.Range(-3, 3);
            Instantiate(obst[0], NewPos, Quaternion.identity);
            NewPos = initPos + CambioPos;
            CambioPos += new Vector3(x, y, z);

            yield return new WaitForSeconds(1f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
