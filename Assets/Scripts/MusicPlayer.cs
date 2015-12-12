using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	public AudioClip loadSound;
	
	private AudioSource music;
	
	// Use this for initialization
	void Start () {
		GameObject.DontDestroyOnLoad(gameObject);
		
		music = GetComponent<AudioSource>();
		music.clip = loadSound;
		music.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
