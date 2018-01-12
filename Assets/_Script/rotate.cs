using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		speed = 2f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up*Time.deltaTime*speed*10f);
	}
}
