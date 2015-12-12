using UnityEngine;
using System.Collections;

public class ShipMove : MonoBehaviour {

	public LevelManager levelmanager;
	public float speed = 15.0f;
	private Rigidbody2D rb;
	public int upForce = 10;

	void OnTriggerEnter2D (Collider2D collider) {
		Debug.Log(collider);
		Destroy(gameObject);
		Debug.Log("SHIP DOWN");
		levelmanager.LoadLevel("Lose");
		
	}

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		//levelmanager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0)){
			//transform.position += Vector3.up * speed * Time.deltaTime;
			rb.AddForce(Vector2.up *upForce);
			
		}
	}
}
