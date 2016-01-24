using UnityEngine;
using System.Collections;

public class GenereateMoreSpace : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		// Create new Plane (Floor)
		GameObject planeObject = GameObject.Find("Plane");
		Vector3 positionFloor = new Vector3 (-40, 0, 0);
		Quaternion rotationFloor = new Quaternion ();
		Instantiate (planeObject, positionFloor, rotationFloor);

		// Create new walls
		GameObject wallObject1 = GameObject.Find("WallPlane");
		Vector3 positionWall1 = new Vector3 (-40, 5, -20);
		Quaternion rotationWall1 = Quaternion.Euler (90, 0, 0);
		Instantiate (wallObject1, positionWall1, rotationWall1);

		GameObject wallObject2 = GameObject.Find("WallPlane");
		Vector3 positionWall2 = new Vector3 (-40, 5, 20);
		Quaternion rotationWall2 = Quaternion.Euler (-90, 0, 0);
		Instantiate (wallObject2, positionWall2, rotationWall2);

		GameObject wallObject3 = GameObject.Find("WallPlane");
		Vector3 positionWall3 = new Vector3 (-60, 5, 0);
		Quaternion rotationWall3 = Quaternion.Euler (90, 90, 0);
		Instantiate (wallObject3, positionWall3, rotationWall3);

		GameObject sphereObject = GameObject.Find("Sphere");
		Vector3 positionSphere = new Vector3 (-40, (float) 2.5, 0);
		Quaternion rotationSphere = new Quaternion();
		Instantiate (sphereObject, positionSphere, rotationSphere);

		//Destroy trigger
		Destroy(this.gameObject);
	}
}
