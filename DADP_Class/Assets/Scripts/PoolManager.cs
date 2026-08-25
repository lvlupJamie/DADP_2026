using UnityEngine;
using System.Collections.Generic;

public class PoolManager : MonoBehaviour
{
    public GameObject prefab; //object to pool
    public int poolSize = 10; //number of objects to pre-instantiate

    private List<GameObject> pool = new List<GameObject>();
    void Start()
    {
        //Create Pool
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
            pool.Add(obj);
        }
        
    }

    public GameObject GetObject()
    {
        //try to find an inactive object
        for (int i = 0; i < poolSize; i++)
        {
            if (!pool[i].activeInHierarchy) //if not in hierarchy, then they
            {
                pool[i].SetActive(true);// set active when called
                return pool[i]; //Return object when calling class
            }
        }

        //If we got here then all objects are active, then we must reset the pool
        for (int i = 0; i < pool.Count; i++)
        {
            pool[i].SetActive(false);
        }

        //Hand out the first object after rest
        var obj = pool[0];
        obj.SetActive(true);
        return obj; 
    }
}
