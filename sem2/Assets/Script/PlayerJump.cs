using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerJump : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D body;
	Button jumpBtn;
	bool canJump;
	float jumpPower=5f;

	//llamar de la escena GameObject.Find("nombre del objeto")
	void Start () {
		body = GetComponent<Rigidbody2D> ();
		jumpBtn=GameObject.Find("btnTouchGame").GetComponent<Button>();
		jumpBtn.onClick.AddListener (() => jump ());
		canJump = false;
	}
	void jump(){

		if (canJump) {
			canJump = false;
			body.velocity = new Vector2 (body.velocity.x, jumpPower);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Mathf.Abs (body.velocity.y) == 0) {
			canJump = true;
		}
	
	}
}
