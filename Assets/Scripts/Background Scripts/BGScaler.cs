using UnityEngine;
using System.Collections;

public class BGScaler : MonoBehaviour {

	void Start () {
		
		var height = Camera.main.orthographicSize * 2f;
		var width = height * Screen.width / Screen.height;
		
		if (gameObject.name == "Background") {
			transform.localScale = new Vector3(width, height, -2);
		}
		
		if (gameObject.name == "Ground") {
			transform.localScale = new Vector3(width + 4f, 5, -2);
		}
		
	
	}
	


}
