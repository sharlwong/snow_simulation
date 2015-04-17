using UnityEngine;
using System.Collections;

public class footsound : MonoBehaviour {
	public AudioClip[] footsteps;
	public float nextFoot;

	// Use this for initialization
	IEnumerator Start ()
	{
		CharacterController controller = GetComponent<CharacterController>();
		
		while(true)
		{
			if(controller.isGrounded && controller.velocity.magnitude > 0.3F)
			{
				audio.PlayOneShot (footsteps[Random.Range(0, footsteps.Length)]);
				yield return new WaitForSeconds(nextFoot);
			}
			else
			{
				yield return 0;
			}
		}
	}

}
