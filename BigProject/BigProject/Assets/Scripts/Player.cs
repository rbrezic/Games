using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	//Variables

	public float movementSpeed;
	public GameObject playerMovePoint;
	private Transform pmr;


	//Functions
	void Update()
    {

		//Player movement
		Plane playerPlane = new Plane(Vector3.up, transform.position);
		Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition); // where mouse is looking
		float hitDistance = 0.0f;

		if(playerPlane.Raycast(ray,out hitDistance))
        {
			Vector3 targetPoint = ray.GetPoint(hitDistance);
            if (Input.GetMouseButton(0))
            {
				pmr = Instantiate(playerMovePoint.transform, targetPoint, Quaternion.identity);
            }
        
		}



    }

}
