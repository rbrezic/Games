using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform igrac;
	public Text scoreText;

	
	// Update is called once per frame
	void Update () {
		scoreText.text = igrac.position.z.ToString("0");
		
	}
}
