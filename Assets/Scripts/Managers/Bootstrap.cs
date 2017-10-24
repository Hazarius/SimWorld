using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{

	public WorldLoader worldLoader;

	IEnumerator _worldRoutine;
	// Use this for initialization
	void Start ()	
	{
		Game.Init();
		_worldRoutine = WorldRoutine();	
		StartCoroutine(_worldRoutine);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnDestroy()
	{
		if (_worldRoutine != null) {
			StopCoroutine(_worldRoutine);
			_worldRoutine = null;
		}
	}

	IEnumerator WorldRoutine()
	{
		yield return null;
		var map = worldLoader.LoadMap();
		Game.map = new Map(map);
		yield return null;
		worldLoader.CreateWorld(Game.map);
	}
}
