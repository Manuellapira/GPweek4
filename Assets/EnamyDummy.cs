using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnamyDummy : MonoBehaviour
{
    public List<itemsDrops> Drops = new List<itemsDrops>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void DrophealingItem()
    {
        //genarate a random number to determines of loot will dropped
        float chance = Random.RandomRange(0f, 100f);
        for (int i = 0; i < Drops.Count; i++)
        {
            if(chance <= Drops[i].Dropchance)
            {
                //calulate amount of item drop
                int amountToDrop =Mathf.RoundToInt (Random.Range(Drops[i].min,Drops[i].max));
                for (int j = 0; j < amountToDrop; j++)
                {
                    //Instantiate Item
                    GameObject droppedItem = Instantiate(Drops[i].PrefabDrops, transform.position, Quaternion.identity);
                    //Destroy Item Base on duration
                    Destroy(droppedItem, Drops[i].duration);
                }
                //Check if what item drops and its amount of it
                Debug.Log($"{amountToDrop} {Drops[i].ItemName}(s) dropped");
            }
        }
    }

    private void OnDestroy()
    {
        DrophealingItem();
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
