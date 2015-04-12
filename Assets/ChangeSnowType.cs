using UnityEngine;
using System.Collections;

public class ChangeSnowType : MonoBehaviour {

	public Material[] myMaterials = new Material[3];
	int maxMaterials;
	int arrayPos = 0;

	// Use this for initialization
	void Start ()
	{
		maxMaterials = myMaterials.Length-1;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.S))
		{
			renderer.material = myMaterials[arrayPos];
			
			if(arrayPos == maxMaterials)
			{
				arrayPos = 0;
			}
			else
			{
				arrayPos++;
			}
			
		}  
		
	}
}


