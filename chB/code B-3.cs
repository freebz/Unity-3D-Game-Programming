// 코드 B-3  MainScript.cs 파일

using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {
    void Start() {
        Invoke("Other", 2);
    }

    void Other() {
        print("Other() Method");
    }
}