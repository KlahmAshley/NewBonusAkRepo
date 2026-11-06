using System.Collections;
using UnityEngine;

public class FactoryManager : Singleton<FactoryManager>
{
    private Factory factory;


    public GameObject applePrefab;
    public Vector2 spawnA;


    void Start()
    {


        factory = new AppleFactory();
        IFruit a = factory.SpawnFruit(applePrefab);
        a.AssignFruit(applePrefab, spawnA);



        // StartCoroutine(Spawner());

    }


    /*IEnumerator Spawner()
    {
        while (true)
        {
          
          // yield return new WaitForSeconds(.5f);
        }
    }
*/
}
