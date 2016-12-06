// 코드 C-3  iTween 라이브러리 사용 방법

using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    void Start() {
        iTween.MoveTo(gameObject,
            new Hashtable(
                "position", new Vector3(100, 100, 100),
                "time", 2.0,
                "easetype", "easeInBounce",
                "oncomplete", "OnComplete",
                "oncompletetarget", gameObject
            ));
    }

    void Update() { }
    void OnComplete() {
        print("Move To 100, 100, 100 End .. !");
    }
}