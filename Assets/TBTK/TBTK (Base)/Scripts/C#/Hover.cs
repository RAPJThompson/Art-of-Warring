using UnityEngine;
using System.Collections;

public class Hover : MonoBehaviour {

	public float offset;
	public float speed=3.5f;
	public float magnitude=1;
	
	private float startingX=0;
	private float startingY=0;
	private float startingZ=0;
	
	// Use this for initialization
	void Start () {
		offset=Random.Range(-5f, 5f);
		
		startingX=transform.localPosition.x;
		startingY=transform.localPosition.y;
		startingZ=transform.localPosition.z;
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate(Vector3.up*magnitude*Mathf.Sin(speed*Time.time+offset)*Time.deltaTime);
		
		float y=startingY+magnitude*Mathf.Sin(speed*Time.time+offset);
		transform.localPosition=new Vector3(startingX, y, startingZ);
	}
}
