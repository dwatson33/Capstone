using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dudfollowPath : MonoBehaviour {

	/*
	#region Enums
	public enum MovementType //Type of Movement
	{
		MoveTowards,
		LerpTowards
	}
	#endregion //Enums
	*/

	/*
	#region Public Variables
	public MovementType Type = MovementType.MoveTowards; // Movement type used
	public movementPath MyPath; // Reference to the Movement Path Used // can have on player itself
	public float Speed = 1; //Speed object is moving
	public float MaxDistanceToGoal = 0.1f; //How close does it have to be to the point to be considered at point
	#endregion //Public Variables
	*/

	/*
	#region Private Varaibles
	private IEnumerator<Transform> pointInPath; //Used to reference points returned from My.Path.GetNextPathPoint
	#endregion //Private Varaibles
	*/

	/*
	// (Unity Named Methods
	#region Main Methods
	// Use this for initialization
	// Gets the ball rolling
	public void Start () {
		//Make sure there is a path assigned
		if (MyPath == null) {
			Debug.LogError ("Movement Path cannot be null, I must have a path to follow.", gameObject);
		}

		//Sets up reference to an instance of the coroutine GetNextPathPoint
		pointInPath = MyPath.GetNextPathPoint();
		//Get the next point in the path to move to (Gets the Default 1st value)
		pointInPath.MoveNext (); //MoveNe xt advances element to next element in sequence
		//Make sure there is a ppoint to move to
		if (pointInPath.Current == null) {
			Debug.LogError ("A path must have points in it to follow", gameObject);
			return;
		}

		//Set the position of the object to the postion of our starting point
		transform.position = pointInPath.Current.position;

	}
	*/
	/*
	public void Update () {
		//Validate there is a path with a point in it
		if (pointInPath == null || pointInPath.Current == null)
		{
			return; //Exit if no path is found
		}

		if (Type == MovementType.MoveTowards) { // If you are using MoveTowards movement type
			//Move to the next point in path using MoveTowards
			transform.position = 
				Vector3.MoveTowards (transform.position,
					pointInPath.Current.position,
					Time.deltaTime * Speed);
		} else if (Type == MovementType.LerpTowards) { //If you are using LerpTowards movement type
			//Move towards the next point in path using Lerp
			transform.position = Vector3.Lerp (transform.position,
				pointInPath.Current.position,
				Time.deltaTime * Speed);
		}

		//Check to see if you are close enough to the next point to start moving to the following one
		//Using Puthagorean Theorem
		//per unity squaring a number is faster than the square root of a number
		//Using .sqrMagnitude
		var distanceSquared = (transform.position - pointInPath.Current.position).sqrMagnitude;
		if (distanceSquared < MaxDistanceToGoal * MaxDistanceToGoal) { //If you are close enough
			pointInPath.MoveNext(); //Get next point in MovementPath
		}
		//The version below uses Vector3.Distance same as Vector3.Magnitude which 

		var distanceSquared = Vector3.Distance(transform.positon, pointInPath.Current.position);
		if (distanceSquared < MaxDistanceToGoal) //If you are close enough
		{
			pointInPath.MoveNext(); //Get next point in MovementPath
		}


	}

	#endregion // Main Methods
	*/

	//(Custom Named Methods)
	#region Utility Methods
	#endregion

	//Coroutines run parallel to other functions
	#region Coroutine
	#endregion

}






