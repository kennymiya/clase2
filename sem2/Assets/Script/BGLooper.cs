using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {

	// Use this for initialization
	//moviemiento del background
	Material mat;
	public float speed;
	Vector2 offset;
	void Start () {
		mat = GetComponent<Renderer>().material;
		offset = mat.GetTextureOffset ("_MainTex");

	}
	
	// Update is called once per frame
	void Update () {
		offset.x += speed*Time.deltaTime;
		mat.SetTextureOffset ("_MainTex", offset);
	}
}
