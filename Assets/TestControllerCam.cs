using UnityEngine;
using System.Collections;

public class TestControllerCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up") || Input.GetKey("w")) {
			transform.Translate (0, 0, (float) 0.1);
		}else if (Input.GetKey ("down") || Input.GetKey("s")) {
			transform.Translate (0, 0, (float) -0.1);
		}
		if(Input.GetKey("left") || Input.GetKey("a")){
			transform.Rotate (0, -5, 0);
		}
		
		if(Input.GetKey("right")  || Input.GetKey("d")){
			transform.Rotate (0, 5, 0);
		}

	}
}
