using UnityEngine;
using System.Collections;

public class TurnManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // 게임 객체를 회전합니다.
        gameObject.transform.Rotate(0, 1, 0);
	}
}
