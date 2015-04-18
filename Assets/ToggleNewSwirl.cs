using UnityEngine;
using System.Collections;

public class ToggleNewSwirl : MonoBehaviour {

	public GameObject snowSwirl;
	public GameObject subEmitter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			var pos = new Vector3(Random.Range(-5, 15), 0, 0);
			var rot = new Vector3(0, 0, 0);
			Instantiate(subEmitter, pos+this.transform.position, this.transform.rotation);
			Instantiate(snowSwirl, pos+this.transform.position, this.transform.rotation);
		}
	}
}
