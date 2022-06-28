using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoint : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject FireBallPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Shoot();
        }



    }

    void Shoot()
    {
        Instantiate(FireBallPrefab, firePoint.position, firePoint.rotation);
    }
}
