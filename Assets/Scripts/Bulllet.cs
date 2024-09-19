using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulllet : MonoBehaviour
{
    private float time = 10;
    private float variantTime = 0;
    private void OnEnable()
    {
        
    }
    private void OnDisable()
    {
        variantTime = 0;
    }

    private void Update()
    {
        if (variantTime < time)
        {
            variantTime += Time.deltaTime;

        }
        else {
            variantTime = 0;
            PoolManager.Instance.ReturnObjectToPool(this.gameObject);
        
        
        
        
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        variantTime = 0;

        PoolManager.Instance.ReturnObjectToPool(this.gameObject);
    }
}
