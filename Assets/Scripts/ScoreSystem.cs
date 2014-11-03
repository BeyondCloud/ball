using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreSystem : MonoBehaviour {


	public static int score;
	Text text;
	// Update is called once per frame
	void Awake()
	{
		text = GetComponent<Text> ();

		score = 0;
	}
	void Update()
	{
		text.text = "Score:" + score;
	}

}
