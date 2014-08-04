using UnityEngine;
using System.Collections;

public class ID_Submitted : MonoBehaviour {


	private GameObject GameEngine;

	// Use this for initialization
	void Start () {

		GameEngine = GameObject.Find ("GameEngine");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Function Called when the user clicks enter after inputing name in field.
	void OnSubmit(string inputString)
	{

		GameEngine.GetComponent<InitialInputScreenManager>().showContinue(inputString);



	}
}
