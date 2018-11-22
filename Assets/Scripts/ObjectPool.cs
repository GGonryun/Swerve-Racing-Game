using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObjectPool
{
    [SerializeField] List<GameObject> pool;
    [SerializeField] GameObject prefab;

    public ObjectPool(int size, GameObject obj)
    {
        pool = new List<GameObject>();
        prefab = obj;

        for(int i = 0; i < size; i++)
        {
            AddToPool(CloneObject(prefab));
        }
    }

    public GameObject CloneObject(GameObject obj) { 
        return Object.Instantiate(obj) as GameObject;
    }

    public void AddToPool(GameObject obj) {
        pool.Add(obj);
    }

    public GameObject FetchObject() {
        if(pool.Count > 0) {
            GameObject obj = pool[0];
            pool.RemoveAt(0);
            return obj;
        } else {
            return CloneObject(prefab);
        }
        return null;
    }

    public void ReturnObject(GameObject obj) {
        pool.Add(obj);
        obj.SetActive(false);
    }


}
