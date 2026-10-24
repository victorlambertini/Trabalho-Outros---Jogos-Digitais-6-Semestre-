using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoSpawn : MonoBehaviour
{
    public float maxtime;
    private float  time;
    public GameObject cano;
    GameObject canoClone;
    public float dist;

    // Start is called before the first frame update
    void Start()
    {
        CanoSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        if(time> maxtime)
        {
            CanoSpawner();
            time = 0;
        }

        time += Time.deltaTime;
    }

    void CanoSpawner()
    {
        canoClone = Instantiate(cano);
        canoClone.transform.position = transform.position + new Vector3(0,Random.Range(dist, -dist),
         0);
    }
}
