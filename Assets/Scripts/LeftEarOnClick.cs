using UnityEngine;
using System.Collections;

public class LeftEarOnClick : MonoBehaviour {

	public GameObject RightEarCheckBox;
	public GameObject BothEarCheckBox;

	private GameObject GameEngine;

	void Start()
	{

		GameEngine = GameObject.Find ("GameEngine");

	}

	void OnClick()
	{
		//Changes state of Checkbox before going into this function.
		if(gameObject.GetComponent<UICheckbox>().isChecked)
		{
			//Remove the RightEarCheck
			RightEarCheckBox.GetComponent<UICheckbox>().isChecked = false;


			//Remove the BothEarCheck
			BothEarCheckBox.GetComponent<UICheckbox>().isChecked = false;

			GameEngine.GetComponent<TestManager>().EarOutput = -1;

		}

	}
}
