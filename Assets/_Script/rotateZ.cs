﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateZ : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate(Vector3.forward*Time.deltaTime*10);
	}
}
