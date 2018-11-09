using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour {
    public float amplitude;
    public float frequency;
 
    Vector3 posOffset = new Vector3 ();
    Vector3 tempPos = new Vector3 ();
 
    void Start () {
        // Store the starting position & rotation of the object
        posOffset = transform.position;
		amplitude = Random.Range(0.1f, 0.2f);
		frequency = Random.Range(0.4f, 0.6f);
    }
     
    // Update is called once per frame
    void Update () {
        // Spin object around Y-Axis
        // transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);
 
        // Float up/down with a Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
 
        transform.position = tempPos;
	}
}
