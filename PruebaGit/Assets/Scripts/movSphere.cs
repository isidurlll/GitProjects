using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movSphere : MonoBehaviour {
    Vector3 posicionInicial;

	// Use this for initialization
	void Start () {
        posicionInicial = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position = posicionInicial;
        }
	}
}
