using UnityEngine;
using System.Collections;
using UnityEngine.UI;


/*public class user :MonoBehaviour {
	public string name;
	public string id;
	public int score;
}
*/

public class title : MonoBehaviour {
	//public static user player;
	public InputField namei;
	public InputField idi;
	public string nameUa;
	public string id;
	public int score;
	//public string aaa;

	 void Start () {
		
		//player = GameObject.FindGameObjectWithTag ("Finish").GetComponent<user> ();

	
	}
	public void changeScene(string scenename){
		//aaa = namei.text;

		Application.LoadLevel (scenename);
		nameUa = namei.text;
		id = idi.text;
		Debug.Log ("hi"+nameUa+"with id"+id);
	}



}
