using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] wallPrefeb;
    public GameObject dropPrefeb;

    public float interval = 1.5f;
    public float range = 3;
    public int randomInt;

    float term;

    // Start is called before the first frame update
    void Start()
    {
        term = interval;
    }

    // Update is called once per frame
    void Update()
    {
        term += Time.deltaTime;
        if (term >= interval)
        {
            Vector3 pos = transform.position;
            pos.y += Random.Range(-range, range);
            randomInt = Random.Range(0, wallPrefeb.Length);
            Instantiate(wallPrefeb[randomInt],
                pos, transform.rotation);
            term -= interval;
        }
    }
}
