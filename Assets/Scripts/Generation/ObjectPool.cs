using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    /* Implemented as a Heap */ 
    private GameObject[] objectPool; //Partially Filled Array
    int count = 0;

    void Start() {}

    private void OnDestroy()
    {
        for (int i = 0; i < count; i++) Destroy(objectPool[i]);
    }

    public void initializePool(int poolSize, GameObject objectClass) //Initial instantiation
    {
        objectPool = new GameObject[poolSize];
        count = poolSize;
        for (int i = 0; i < poolSize; i++)
        {
            objectPool[i] = Instantiate(objectClass, Vector3.zero, Quaternion.identity) as GameObject;
            objectPool[i].transform.parent = gameObject.transform;
            objectPool[i].SetActive(false);
        }
    }

    public GameObject getObject()
    {
        count--;
        objectPool[count].SetActive(true);
        return objectPool[count];
    }

    public void disableObject(GameObject obj)
    {
        objectPool[count] = obj;
        count++;
        obj.SetActive(false);
    }
}
