using UnityEngine;
using System.Collections;

abstract class Unit: MonoBehaviour 
{
    //soldiers in the unit
	private int unitSize;
	//maximum hitpoints this unit can have, limited by unitSize (hp = unitSize)
	private int hitPoints;
	//damage this unit has received
	private int damage;
	//offensive capability
	private int	attack;
	//defence against attacks
	private int defense;
	//how far the unit can attack before terrain modifiers
	private int attackRangeBase;
	//how far the unit can move before terrain modifiers
	private int movementBase;
	//how far the unit can see before terrain modifiers
	private int sightBase;
	//how much intelligence this unit gathers in the area that it can see
	private int intelBase;
	//how hard it is to detect this unit and its actions
	private int stealth;
	//what equipment this unit is currently using - array{offensive, defensive, tactical(in combat), logistical(out of combat)}
	private int[] equipment;
    //what type of supply line this unit is supported by
	private int[] supplyType;
	//what type of supplies this unit receives
	private int[] supplies;
	//what training this unit has received
	private int[] training;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



}

