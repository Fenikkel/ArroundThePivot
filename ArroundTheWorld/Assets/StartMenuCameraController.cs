using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuCameraController : MonoBehaviour {

    public Transform worldPivot;
    public float speed;
    private Quaternion worldRotation;

	// Use this for initialization
	void Start () {
        worldRotation = new Quaternion(0,0,0,0);
	}
	
	// Update is called once per frame
	void Update () {

        /* 
         // Rotate the object around its local X axis at 1 degree per second
        transform.Rotate(Vector3.right * Time.deltaTime);

        // ...also rotate around the World's Y axis
        transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
         
         */

        worldPivot.Rotate(0, Time.deltaTime * speed, 0); //para que esto funcione la camara tiene que ser hijo del world pivot

        //transform.Rotate(0, Time.deltaTime * speed, 0, worldPivot); //no funciona

        //transform.Rotate(0, Time.deltaTime * speed, 0, Space.World); //gira sobre el eix y del mon (independentment de com estiga rota la camera)
        //transform.Rotate(0, Time.deltaTime * speed, 0); //gira super random perque la Y no esta igual que la Y del mon

    }
}
