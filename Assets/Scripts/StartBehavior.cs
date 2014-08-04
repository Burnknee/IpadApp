using UnityEngine;
using System.Collections;

public class StartBehavior : MonoBehaviour {
	

	private int talkerIndex;
	private string ClipPath;
	private AudioClip[] AudioClipTalkers;
	private GameObject GameEngine;

	private int[] talkers;
	private int[] talkersNames;
	private int[] talkersColors;
	private int[] talkersNumbers;


	// Use this for initialization
	void Start () {
	
		GameEngine = GameObject.Find ("GameEngine");
		AudioClipTalkers = new AudioClip[3]; //One Charlie, and two randoms
		talkerIndex = 0;
		talkers = new int[3]; //They have to be different talkers?
		talkersNames = new int[3]; //They have to be different names? (Only One Charlie) - This version the Randoms can be the same.
		talkersColors = new int[3]; //They have to be different Colors?
		talkersNumbers = new int[3]; //They have to be different Numbers?
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnClick()
	{
		//If we are ready
		if(GameEngine.GetComponent<TestManager>().WaitingOnStart)
		{

			talkerIndex = 0;

			//Get the three Clips ready;

			//Path.
			ClipPath = "CRMwaves/Talker";

			//Choose initial Charlie Talker
			//Talkers 0-3 are male. Talkers 4-7 are female
			int talker_num = Random.Range (0, 4);
			int name_num = 0;//Always Charlie
			int color_num = Random.Range (0,4);
			int number_num = Random.Range (0, 8);

			talkers[talkerIndex] = talker_num;
			talkersNames[talkerIndex] = name_num;
			talkersColors[talkerIndex] = color_num;
			talkersNumbers[talkerIndex] = number_num;


			ClipPath += talker_num.ToString () 
				+ "/0" + name_num.ToString ()
					+ "0" + color_num.ToString ()
					+ "0" + number_num.ToString ();
			Debug.Log ("Init Charlie Talker: "+ClipPath);
			AudioClipTalkers[talkerIndex] = (AudioClip)Resources.Load (ClipPath);


			GameEngine.GetComponent<TestManager>().currentColor = "0"+color_num.ToString();
			GameEngine.GetComponent<TestManager>().currentNumber = "0"+number_num.ToString();




			//Setup Random Talker 1
			talkerIndex++;
			//Path.
			ClipPath = "CRMwaves/Talker";

			//All variables need to be different that whats in the arrays!
			//Talkers 0-3 are male. Talkers 4-7 are female


			talker_num = Random.Range (0, 4);
			while(talker_num ==  talkers[0])
			{
				talker_num = Random.Range (0,4);
			}

			name_num = Random.Range (0, 8);
			while(name_num == talkersNames[0])
			{
				name_num = Random.Range (0,8);
			}

			color_num = Random.Range (0,4);
			while(color_num == talkersColors[0])
			{
				color_num = Random.Range (0,4);
			}

			number_num = Random.Range (0, 8);
			while(number_num == talkersNumbers[0])
			{
				number_num = Random.Range (0,8);
			}
			
			talkers[talkerIndex] = talker_num;
			talkersNames[talkerIndex] = name_num;
			talkersColors[talkerIndex] = color_num;
			talkersNumbers[talkerIndex] = number_num;
			
			
			ClipPath += talker_num.ToString () 
				+ "/0" + name_num.ToString ()
					+ "0" + color_num.ToString ()
					+ "0" + number_num.ToString ();
			Debug.Log ("Random Talker1: "+ClipPath);
			AudioClipTalkers[talkerIndex] = (AudioClip)Resources.Load (ClipPath);


			//Setup Random Talker 2
			talkerIndex++;
			//Path.
			ClipPath = "CRMwaves/Talker";
			
			//All variables need to be different that whats in the arrays!
			//Talkers 0-3 are male. Talkers 4-7 are female
			
			
			talker_num = Random.Range (0, 4);
			while(talker_num ==  talkers[0] || talker_num ==  talkers[1] )
			{
				talker_num = Random.Range (0,4);
			}
			
			name_num = Random.Range (0, 8);
			while(name_num == talkersNames[0] || name_num == talkersNames[1])
			{
				name_num = Random.Range (0,8);
			}
			
			color_num = Random.Range (0,4);
			while(color_num == talkersColors[0] || color_num == talkersColors[1])
			{
				color_num = Random.Range (0,4);
			}
			
			number_num = Random.Range (0, 8);
			while(number_num == talkersNumbers[0] || number_num == talkersNumbers[1] )
			{
				number_num = Random.Range (0,8);
			}
			
			talkers[talkerIndex] = talker_num;
			talkersNames[talkerIndex] = name_num;
			talkersColors[talkerIndex] = color_num;
			talkersNumbers[talkerIndex] = number_num;
			
			
			ClipPath += talker_num.ToString () 
				+ "/0" + name_num.ToString ()
					+ "0" + color_num.ToString ()
					+ "0" + number_num.ToString ();
			Debug.Log ("Random Talker2: "+ClipPath);
			AudioClipTalkers[talkerIndex] = (AudioClip)Resources.Load (ClipPath);

		

			//Play each talker at the same time.
			//Playsound
			float talker1vol = .5f;
			float talker2vol = .5f;
			GameEngine.GetComponent<TestManager>().WaitingOnStart = false;
			audio.pan = GameEngine.GetComponent<TestManager>().EarOutput;
			audio.PlayOneShot(AudioClipTalkers[0]);
			audio.PlayOneShot(AudioClipTalkers[1],talker1vol);
			audio.PlayOneShot(AudioClipTalkers[2],talker2vol);














		}





	}
}
