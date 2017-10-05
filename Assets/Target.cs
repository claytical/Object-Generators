using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Weapon") {
			Renderer r = gameObject.GetComponent<Renderer>();
			r.material.shader = Shader.Find ("Standard");
			r.material.SetColor ("_Color", Color.red);
		}
	}
}
