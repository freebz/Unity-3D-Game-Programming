using UnityEngine;
using System.Collections;

public class BarrelScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        // 충돌한 객체가 "Bullet" 태그를 가지고 있으면
        if (collision.transform.tag == "Bullet")
        {
            // 점수를 10점 더합니다.
            Camera.main.GetComponent<ScoreScript>().CurrentScore += 10;
        }
    }
}
