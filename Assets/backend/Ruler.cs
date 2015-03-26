using UnityEngine;
using System;
using System.Collections.Generic;

public class Ruler : MonoBehaviour {
    /*array that stores the character's 12 attributes:
     * The contained arrays are as follows:
     *          leadership (inspiring/management/loyalty)
     *          education (culture/knowledge/ledgers)
     *          combat prowess (Swordsmanship/Archery/Tactics)
     *          charisma (smooth-talking/attractiveness/fashion)
     */
	public int[] attributes = new int[12];
	
    //This is a string that dictates what country they currently rule over
    private Country rulerOf;


	public void Start()
    {
		checkAttributes();
    }

	public void Update()
	{
	}

    //Function to return the attribute array in question from the attributes array.
	// 0 = inspiring, 1 = management, 2 = loyalty, 3 = culture
    public int getAttribute(int foo)
    {
		return this.attributes[foo];
    }
    
    public void checkAttributes()
    {
		Debug.Log ("Starting...");
        if (attributes == null)
        {
			Debug.Log("Error - Ruler did not intantiate properly.");
            return;
        }
		//  int Inspiring = this.attributes [0][0];

		Debug.Log("Inspiring = " + attributes[0].ToString());
		Debug.Log("Management = " + attributes[1].ToString());
		Debug.Log("Loyalty = " + attributes[2].ToString());
		Debug.Log("Culture = " + attributes[3].ToString());
		Debug.Log("Knowledge = " + attributes[4].ToString());
		Debug.Log("Ledgers = " + attributes[5].ToString());
		Debug.Log("Swordsmanship = " + attributes[6].ToString());
		Debug.Log("Archery = " + attributes[7].ToString());
		Debug.Log("Tactics = " + attributes[8].ToString());
		Debug.Log("Smooth-Talking = " + attributes[9].ToString());
		Debug.Log("Attractiveness = " + attributes[10].ToString());
		Debug.Log("Fashion = " + attributes[11].ToString());
    }

    /*
    static void Main(string[] args)
    {
        Ruler currRuler = new Ruler();
        currRuler.attributes = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        currRuler.checkAttributes();
    }
    */
}
