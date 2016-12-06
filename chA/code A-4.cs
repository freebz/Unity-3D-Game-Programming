// 코드 A-4  MainScript.cs 파일

using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {
    void Start() {
        TextAsset text = (TextAsset)Resources.Load("Data");
        print(text);
    }
}