using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmaeraControiller : MonoBehaviour {

	GameObject player;
	void Start () {
		this.player = GameObject.Find ("ThirdPersonController");
		
	}

	void Update () {
		Vector3 playerPos = this.player.transform.position;
		transform.position = new Vector3 (
			playerPos.x, playerPos.y+15, playerPos.z-23);

		/*Vector3 playerRot = this.player.transform.rotation;

		transform.rotation = new Vector3 (
			playerRot.x-10, playerPos.y, playerPos.z);*/
	
		
	}
}
