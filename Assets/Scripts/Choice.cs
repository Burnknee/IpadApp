using UnityEngine;
using System.Collections;

public class Choice : MonoBehaviour {

	public string color;
	public string number; 

	private GameObject GameEngine;
	// Use this for initialization
	void Start () {
		GameEngine = GameObject.Find ("GameEngine");
	}

	IEnumerator playAnswerAnim()
	{
		GameEngine.GetComponent<TestManager> ().AnswerLabel.SetActive (true);
		GameEngine.GetComponent<TestManager>().AnswerLabel.animation.Play("Correct_Wrong Animation");
		yield return new WaitForSeconds(GameEngine.GetComponent<TestManager>().AnswerLabel.animation["Correct_Wrong Animation"].length); //This does the magic
		GameEngine.GetComponent<TestManager> ().AnswerLabel.SetActive (false);	

	}
	// Update is called once per frame
	void Update () {
	
	}
	void OnClick()
	{
		if(!GameEngine.GetComponent<TestManager>().WaitingOnStart)
		{

			//Check if Correct/Wrong
			if((color == GameEngine.GetComponent<TestManager>().currentColor)
			   && (number == GameEngine.GetComponent<TestManager>().currentNumber))
			{
				GameEngine.GetComponent<TestManager>().AnswerLabel.GetComponent<UILabel>().text = "Correct!";
				GameEngine.GetComponent<TestManager>().AnswerLabel.GetComponent<UILabel>().color = Color.green;
				//GameEngine.GetComponent<TestManager>().AnswerLabel.animation.Play("Correct_Wrong Animation");
			}
			else
			{
				GameEngine.GetComponent<TestManager>().AnswerLabel.GetComponent<UILabel>().text = "Wrong!";
				GameEngine.GetComponent<TestManager>().AnswerLabel.GetComponent<UILabel>().color = Color.red;
				//GameEngine.GetComponent<TestManager>().AnswerLabel.animation.Play("Correct_Wrong Animation");
			}

			StartCoroutine(playAnswerAnim());
			//Debug.Log ("Color: " + color + " Number: " + number);
			GameEngine.GetComponent<TestManager>().WaitingOnStart = true;
		}


	}

}
