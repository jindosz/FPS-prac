using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memorypool
{
    private class PoolItem
    {
        public bool         isActive;
        public GameObject   gameObject;
    }

    private int increaseCount = 5;
    private int maxCount;
    private int activeCount;

    private GameObject      poolObject;
    private List<PoolItem>  po
}
