using UnityEngine;
using System.Collections;

public class InitialInputScreenManager : MonoBehaviour {


	public GameObject Continue_btn;


	private bool btn_displayed = false;

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	}

	public void showContinue( string curr_Name)
	{
		if(curr_Name != "")
		{
			Debug.Log (curr_Name);

			if(!btn_displayed)
			{
				//Play Continue Btn Animation && Cannot Click until Anim is over!  
				Continue_btn.animation.enabled = true;
				Continue_btn.animation["ContinueBtnShowAnim"].speed = 2;
				Continue_btn.animation["ContinueBtnShowAnim"].time = 0;
				Continue_btn.animation.Play ("ContinueBtnShowAnim");
				btn_displayed = true;
			}
		}
		else
		{
			Debug.Log ("Input a Name!");

			//Play Anim Backwards if already out there...
			if(btn_displayed)
			{
				Debug.Log("Here");
				Continue_btn.animation.enabled = true;
				Continue_btn.animation["ContinueBtnShowAnim"].speed = -2;
				Continue_btn.animation["ContinueBtnShowAnim"].time = Continue_btn.animation["ContinueBtnShowAnim"].length;
				Continue_btn.animation.Play("ContinueBtnShowAnim");
				btn_displayed = false;
			}
		}

	}

}
