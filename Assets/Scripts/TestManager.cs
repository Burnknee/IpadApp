using UnityEngine;
using System.Collections;

public class TestManager : MonoBehaviour {

	public bool WaitingOnStart = true;
	public string currentColor = "";
	public string currentNumber = "";
	public GameObject AnswerLabel;
	public int EarOutput = 0;// -1 left   0 center   1 right


	// Use this for initialization
	void Start () {
		//AnswerLabel.SetActive (false);
	}

	/*void OnApplicationPause(bool pauseStatus)
	{
		if(pauseStatus)
		{
			Application.Quit();
		}
	}*/

	// Update is called once per frame
	void Update () {
	
	}
}
