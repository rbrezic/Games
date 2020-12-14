
using UnityEngine;

public class followIgrac : MonoBehaviour {

	public Transform igrac;
	public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
		transform.position = igrac.position + offset;
	}
}
