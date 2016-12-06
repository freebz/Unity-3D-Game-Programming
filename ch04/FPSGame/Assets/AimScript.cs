using UnityEngine;
using System.Collections;

public class AimScript : MonoBehaviour {

    // 변수를 선언합니다.
    public Texture2D AimTexture;
    public Rect AimRect;

	// Use this for initialization
	void Start () {
        // 화면에서 커서가 보이지 않게 만듭니다.
        Cursor.visible = false;

        // Rect 객체를 설정할 값을 생성합니다.
        float left = (Screen.width - AimTexture.width) / 2;
        float top = (Screen.height - AimTexture.height) / 2;
        float width = AimTexture.width;
        float height = AimTexture.height;

        // Rect 객체를 생성 및 설정합니다.
        AimRect = new Rect(left, top, width, height);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        // 화면에 텍스처를 그립니다.
        GUI.DrawTexture(AimRect, AimTexture);
    }
}
