using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoLogic : MonoBehaviour
{
    public float canoSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CanoMove();
    }

void CanoMove()
    {
        transform.position += Vector3.left * canoSpeed * Time.deltaTime;
    }
}
