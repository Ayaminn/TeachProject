using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		//右に移動
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.position += new Vector3 (0.1f, 0, 0);
		}
		//左に移動
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.position += new Vector3 (-0.1f, 0, 0);
		}
		//ジャンプ
		if (Input.GetKeyDown(KeyCode.Space)) {
			if(rb.velocity.y < 0.2f) {
				rb.AddForce(transform.up * 300);
			}
		}
	}
}
