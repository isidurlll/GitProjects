using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movCube : MonoBehaviour {

    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    public Vector3 posicionInicial; //= new Vector3(1, 1, 1);
    public Rigidbody rb;

    //Make sure you attach a Rigidbody in the Inspector of this GameObject
    Rigidbody m_Rigidbody;
    Vector3 m_EulerAngleVelocity;

	// Use thiss for initialization
	void Start () {
        posicionInicial = transform.position;
        rb = GetComponent<Rigidbody>();

        //Set the axis the Rigidbody rotates in (100 in the y axis)
        m_EulerAngleVelocity = new Vector3(0, 100, 0);

        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            //rb.AddForce(transform.forward * 100);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
            //rb.AddForce(transform.forward * (-100));

        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
            //Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.deltaTime);
            //m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);
        }

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A)){
            gameObject.transform.position = posicionInicial;
            //m_Rigidbody.MoveRotation(Quaternion.Euler(m_EulerAngleVelocity));
        }
	}
}