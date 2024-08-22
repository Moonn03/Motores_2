using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public Transform SpawnPoint;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject newbullet = GameObject.Instantiate(bulletPrefab);
            newbullet.transform.position = SpawnPoint.position;

        }
        
        
    }
}
