using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject ball;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (ball.transform.position.y < -2) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		}
	}
}
