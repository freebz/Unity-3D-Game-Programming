using UnityEngine;
using System.Collections;

public class BarrelScript : MonoBehaviour {

    // bool 자료형의 변수
    public bool IsClick = false;
    public bool IsFail = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // 변수 IsClick이 true를 가지고 있을 경우
        if (IsClick == true)
        {
            if (IsFail == false)
            {
                gameObject.transform.Rotate(0, 1, 0);
            } else if (IsFail == true)
            {
                Application.LoadLevel("GameOverScene");
            }
        }
	}
}
