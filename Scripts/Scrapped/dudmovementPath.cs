using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dudmovementPath : MonoBehaviour {

	#region Enums
	public enum PathTypes //Types of movement paths
	{
		linear,
		loop
	}
	#endregion //Enums

	#region Public Variables
	public PathTypes PathType; //Indicated type of path (Linear or Looping)
	public int movementDirection = 1; //1 clockwise/forward || -1 counter clockwise/backwards
	public int movingTo = 0; //used to identify point in PathSequence we are moving to, first point
	public Transform[] PathSequence; //Array of all points in the path, all paths transforms that will occur
	#endregion //Public Variables

	#region Private Varaibles
	#endregion
	/*
	// Use this for initialization
	void Start () {

	}
	*/

	// (Unity Named Methods
	#region Main Methods
	// Update is called once per frame
	void Update () {

	}

	//OnDrawGizmos will draw lines between our points in the Unity Engine
	//These lines will allow us to easily see the path that our moving object will follow in the game
	public void OnDrawGizmos()
	{
		//Make sure that your sequence has points in it and that there are at least two points to 
		//constitute a path
		if (PathSequence == null || PathSequence.Length < 2)
		{
			return; //Exits OnDrawGizmos if no line is needed
		}

		//Loop through all of the points in the sequence of points
		for (var i = 1; i < PathSequence.Length; i++) {
			//Draw a line between the points
			Gizmos.DrawLine (PathSequence [i - 1].position, PathSequence [i].position);
		}

		//If your path loops back to the begining when it reaches the end
		if(PathType == PathTypes.loop)
		{
			//Draw a line from the last point to the first point in the sequence
			Gizmos.DrawLine(PathSequence[0].position, PathSequence[PathSequence.Length - 1].position);
		}
	}
	#endregion // Main Methods

	//(Custom Named Methods)
	#region Utility Methods
	#endregion

	//Coroutines run parallel to other functions
	#region Coroutine
	//GetNextPathPoint() returns the transform of the next point in our path
	//FollowPath.cs scripts will inturn move the object it is on to that point in the game
	//will get and return next point component
	public IEnumerator<Transform> GetNextPathPoint()
	{
		//Make sure that your sequence has points in it and that there are at least twopoints to con a path
		if (PathSequence == null || PathSequence.Length < 1) {
			yield break; //Exits the Coroutine sequence if length check fails
		}

		while (true) { //Does not infinite loop due to yield return
			//Return the current point in Path Sequence and wait for nect call of enumerator 
			//(Prevents infinite loop)
			yield return PathSequence [movingTo]; // move to devolt value we set, send to path sequence 0
			// tell where next point to move to
			//////////////////////////////// PAUSES HERE ///////////////////////////////////////
			//if there is only one point exit the coroutine
			if (PathSequence.Length == 1) {
				continue;
			}

			//If Linear path move from start to end then end to start then repeat
			if (PathType == PathTypes.linear) {
				//If you are at the beginning of the path
				if (movingTo <= 0) {
					movementDirection = 1; //Setting to 1 moves forward
				}
				//Else if you are at the end of your path
				else if (movingTo >= PathSequence.Length - 1) {
					movementDirection = -1; //Setting to -1 moves backwards
				}
			}

			//updates movement
			//ie we start at 0, we update our moveTo, so now it's 1, goes to next ppoint
			movingTo = movingTo + movementDirection;
			//movementDirection should always be either 1 of -1
			//We add direction to the index to move us to the next point in the sequence of points in our path


			//Need to make sure we are returning a value that is within our path, not out of it

			//For Looping path you must move the index when you reach the begining or end of the PathSequence
			// to loop the path
			if (PathType == PathTypes.loop) {
				//If you just moved past the last point(moving forward)
				if (movingTo >= PathSequence.Length) {
					//Set the next point to move to as the first point in sequence
					movingTo = 0;
				}
				//
				if (movingTo < 0) {
					//Set the next point to move to as the last point in sequence
					movingTo = PathSequence.Length - 1;
				}
			}
		}
	}
	#endregion
}
