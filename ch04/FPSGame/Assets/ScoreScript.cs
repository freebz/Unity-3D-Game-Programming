using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {

    // 변수를 선언합니다.
    public int CurrentScore = 0;
    public Rect ScorePosition;

	// Use this for initialization
	void Start () {
        // ScorePosition 객체를 설정합니다.
        ScorePosition = new Rect(Screen.width - 110, 10, 100, 30);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        // 화면에 글자를 생성합니다.
        GUI.Label(ScorePosition, CurrentScore.ToString());
    }
}
