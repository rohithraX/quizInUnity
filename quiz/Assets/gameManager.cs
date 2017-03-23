using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {

	public Question[] questions;
	private Question currentQuestion;
	public int qAnswered = 0;
	[SerializeField]
	public Text quesText;
	[SerializeField]


	public InputField ip;
	public int points = 0;
	public float Timer = 0;
	public int score = 0;


	void Start()
	{
		currentQuestion = questions[0];
		quesText.text = currentQuestion.ques;
		//ip = ip.GetComponent<InputField> ();
		//var input = gameObject.GetComponent<InputField> ();
		ip = ip.GetComponent<InputField> ();


	}


	void Update ()
	{
		// Update your timer every frame.
		Timer += Time.deltaTime;
		//Debug.Log (Timer);
	}
	void GetNextQues ()
	{
		Debug.Log ("GNQ");

		int nextQuestionIndex = qAnswered + 1;
		currentQuestion = questions[nextQuestionIndex];
		quesText.text = currentQuestion.ques;

		Timer = 0;

	}
	public void go()
	{
		//ip = ip.GetComponent<InputField> ();
		//inputString = ip.text;
		if (string.Compare (ip.text, currentQuestion.ans) == 0) {
			AssignPoints ();             //caluculate score
			score = score + points;
			Debug.Log ("Corect_added_"+points+" = "+score);
			GetNextQues ();
			//StartCoroutine (TransitionToNextQ ());

			qAnswered++;


		} else {
			Debug.Log (" Wrong ");
			
		}
	}




	void AssignPoints ()
	{
		
		if (Timer <= 5f)
		{
			points = 2;
		}
		else if (Timer > 5f && Timer <= 10f)
		{
			points = 1;
		}
	}

	/*IEnumerator TransitionToNextQ()
	{
		yield return new WaitForSeconds (timebetweenQ);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}*/



}
