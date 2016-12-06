// 코드 C-2  디버그 전용 레이캐스트 코드

using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {
    void Start() { }
    void Update() {
        Ray ray = Camera.mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) {
            if (Input.GetMouseButtonDown(0)) {
               print("HIT: " + hit.transform.gameObject);
            }
        }
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.red);
    }
}