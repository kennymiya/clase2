using UnityEngine;
using System.Collections;
//botones
using UnityEngine.UI;
//cambiar escenarios
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

	// Use this for initialization
	Button start;
	void Start () {
		start = GetComponent<Button> ();
		start.onClick.AddListener (() => goGame ());
	}
	void goGame(){
		SceneManager.LoadScene ("Game");
	   
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
