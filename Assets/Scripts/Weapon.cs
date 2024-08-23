using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab de la bala
    public Transform SpawnPoint; // Punto desde donde se disparará la bala
    public int maxBullets = 10; // Número máximo de balas que se pueden disparar
    private int currentBullets = 0; // Contador de balas disparadas

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && currentBullets < maxBullets)
        {
            GameObject newbullet = Instantiate(bulletPrefab);
            newbullet.transform.position = SpawnPoint.position;
            newbullet.transform.rotation = SpawnPoint.rotation;
            newbullet.GetComponent<Rigidbody>().AddForce(SpawnPoint.transform.forward * 100.0f);
            newbullet.GetComponent<MeshRenderer>().material.color = Color.green;

            // Incrementar el contador de balas disparadas
            currentBullets++;

            // Destruye la bala después de 3 segundos
            Destroy(newbullet, 3.0f);

            // Reducir el contador de balas cuando la bala sea destruida
            StartCoroutine(DecreaseBulletCountAfterTime(3.0f));
        }
    }

    IEnumerator DecreaseBulletCountAfterTime(float delay)
    {
        yield return new WaitForSeconds(delay);
        currentBullets--; // Disminuir el contador de balas después de que se destruye la bala
    }
}
