// 코드 B-1  StartCoroutine() 메서드

using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {
    void Start() {
        StartCoroutine("Other");
    }

    IEnumerator Other() {
        print("Other() Method");
        return null;
    }
}