using UnityEngine;
using System.Collections;

public class BGScaler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//creando un background que encaje con el escenario
		float height = Camera.main.orthographicSize * 2f;
		float width = height * Screen.width / Screen.height;

		if (gameObject.name == "Background") {
			transform.localScale = new Vector3 (width, height, 0);}
		else if(gameObject.name=="Floor"){
			transform.localScale = new Vector3 (width, 5f,0);
				
			}
		}

	}
	
