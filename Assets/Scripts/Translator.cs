using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translator : MonoBehaviour
{

    //public int moveUp = 1f;
    public float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
        //transform.Tranlate (new Vector3.moveUp * Time.deltaTime * rotateSpeed);
    }
}
