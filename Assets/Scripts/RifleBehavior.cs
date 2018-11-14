using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleBehavior : MonoBehaviour {

    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform spawnShot;
    [SerializeField] private float shotForce = 1000;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject newBullet = Instantiate(bullet, spawnShot.position, transform.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * shotForce);
        }
    }
}
