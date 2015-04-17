using UnityEngine;
using UnityEditor;
using System.Collections;

public class OlafCollision : MonoBehaviour {

	public GameObject newOlaf;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other) {
		Destroy(this.gameObject);
		Debug.Log (other);
		newOlaf.SetActive (true);
	}
}
