using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerRandom : MonoBehaviour
{
    //public int numberToSpawn;
    //public List<GameObject> spawnPool;
    //public GameObject quad;

    public GameObject objectToSpawn;
    public float timeToSpawn;
    public float currentTimeToSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        //spawnObjects();
    }


    void Update()
    {
        if(currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
        }
    }

    public void SpawnObject()
    {

        Vector2 position = new Vector2(Random.Range(-8, 8), Random.Range(-5, 5));
        Instantiate(objectToSpawn, position, Quaternion.identity);

        //   Instantiate(objectToSpawn, transform.position, Quaternion.identity);
    }

    //    public void spawnObjects()
    //{
    //    int randomItem = 0;
    //    GameObject toSpawn;
    //    MeshCollider c = quad.GetComponent<MeshCollider>();

    //    float screenX; 
    //    float screenY;
    //    Vector2 pos;

    //    for(int i = 0; i < numberToSpawn; i++)
    //    {
    //        randomItem = Random.Range(0, spawnPool.Count);
    //        toSpawn = spawnPool[randomItem];

    //        screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
    //        screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
    //        pos = new Vector2(screenX, screenY);

    //        Instantiate(toSpawn, pos, toSpawn.transform.rotation);
    //    }
    //}


    //private void destroyObjects()
    //{
    //    foreach(GameObject o in GameObject.FindGameObjectsWithTag("Spawnable"))
    //    {
    //        Destroy(o);
    //    }
    //}

}
