using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObject : MonoBehaviour
{
    public static PoolObject instance;
    private List<GameObject> objects = new List<GameObject>();
    private int amount = 20;
    [SerializeField]
    private GameObject prefabPool;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void Start()
    {
        for (int i = 0; i < amount; i++)
        {
            prefabPool = Instantiate(prefabPool);                                          /*Паттерн проектирование PoolObject для монет*/
            prefabPool.SetActive(false);
            objects.Add(prefabPool);
        }
    }

    public GameObject GetFreeElement()
    {
        for (int i = 0; i < objects.Count; i++)
        {
            if (!objects[i].activeInHierarchy)
            {
                return objects[i];
            }
        }
        return null;
    }
}
