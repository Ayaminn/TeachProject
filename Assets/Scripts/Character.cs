using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.position += new Vector3 (1, 0, 0);
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.position += new Vector3 (-1, 0, 0);
		}
	}
}
