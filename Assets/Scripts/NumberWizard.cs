using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max,min,guess;
	// Use this for initialization
	void Start () 
	{
		StartGame ();
	}
	
	void StartGame ()
	{
		max=1000;
		min=1;
		guess=500;
		print ("==============The Game Has Started======================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head but do not tell me!");
		print ("You can pick a number from " + min +" to " + max);
		print ("Is yor number higher or lower than " + guess +  " ?");
		print ("Hit Up Arrow if it is higher or Down Arrow if it is lower or return for equal");
		max=max+1;
	}
	
	void NextGuess ()
	{
		guess=((max+min)/2);
		print ("Higher or lower than " + guess);
		print ("Hit Up Arrow if it is higher or Down Arrow if it is lower or return for equal");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			min=guess;
			NextGuess ();
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			max=guess;
			NextGuess ();
		}
		else if (Input.GetKeyDown(KeyCode.Return))
		{
			print ("I WON");
			StartGame ();
		}
	}
}
