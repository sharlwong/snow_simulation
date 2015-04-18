using UnityEngine;
using System.Collections;

public class ChangeSnowType : MonoBehaviour {

	public Material[] myMaterials = new Material[3];
	int maxMaterials;
	int arrayPos;

	// Use this for initialization
	void Start ()
	{
		maxMaterials = myMaterials.Length-1;
		arrayPos = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.X))
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


