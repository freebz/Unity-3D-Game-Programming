// 코드 C-1  레이캐스트

using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {
    void Start() { }
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                print("HIT: " + hit.transform.gameObject);
            }
        }
    }
}