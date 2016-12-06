// 코드 B-2  MainScript.cs 파일

using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {
    void Start() {
        StartCoroutine("Other");
    }

    IEnumerator Other() {
        // 출력합니다.
        print("Other() Method");

        // 2초 동안 중지합니다.
        yield return new WaitForSeconds(2);

        // 출력합니다.
        print("After WaitForSeconds() Method");

        // 반복합니다.
        StartCoroutine("Other");
    }
}