using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

    // 변수를 선언합니다.
    public int MaxHealth = 100;
    public int CurrentHealth = 100;
    public float HealthBarLength;

	// Use this for initialization
	void Start () {
        // HP 바의 길이를 구합니다.
        HealthBarLength = Screen.width / 2;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        // 플레이어의 HP의 최소치와 최대치를 설정합니다.
        if (CurrentHealth < 0)
        {
            CurrentHealth = 0;
        } else if (MaxHealth < CurrentHealth)
        {
            CurrentHealth = MaxHealth;
        }

        // HP 바를 생성합니다.
        GUI.Box(new Rect(10, 10, HealthBarLength / ((float)MaxHealth / CurrentHealth), 20), CurrentHealth + "/" + MaxHealth);
    }
}
