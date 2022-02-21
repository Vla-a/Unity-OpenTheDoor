using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreate : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;
    [SerializeField] float bulletVelocity;
    [SerializeField] Inventaries player;   
 
    public void CreateBullet()
    {      
      
        //Debug.Log(addInventory.inventoryContent.Count);
        GameObject newBall = Instantiate(ballPrefab, transform.position, transform.rotation);
        newBall.GetComponent<Rigidbody>().velocity = transform.forward * bulletVelocity;     
    }
}
