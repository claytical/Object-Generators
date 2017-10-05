using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shower : MonoBehaviour {
	public GameObject item;
	public int minimumAmount;
	public int maximumAmount;
	public float timeBetweenShowers;
	private float timeSinceLastShower;
	// Use this for initialization
	void Start () {
		timeSinceLastShower = Time.time + timeBetweenShowers;
	}
	
	// Update is called once per frame
	void Update () {
		if (timeSinceLastShower <= Time.time) {
			timeSinceLastShower = Time.time + timeBetweenShowers;
			int numberOfItemsToDrop = Random.Range (minimumAmount, maximumAmount);
			for(int i = 0; i < numberOfItemsToDrop; i++) {
				GameObject showerItem = (GameObject)Instantiate (item, transform);
				showerItem.transform.Translate (Random.Range (-.01f, .01f), Random.Range (-.01f, .01f), Random.Range (-.01f, .01f)); 
				showerItem.GetComponent<CollectableItem> ().value = Random.Range (1, 100);
			}
		}
	}
}
