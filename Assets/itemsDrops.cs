using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class itemsDrops
{
    public string ItemName;
    public GameObject PrefabDrops;
    [Range(0,100)]
    public float Dropchance;
    public float min, max;
    public float duration;
}
