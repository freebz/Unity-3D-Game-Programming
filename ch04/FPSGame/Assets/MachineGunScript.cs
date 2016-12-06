using UnityEngine;
using System.Collections;

public class MachineGunScript : MonoBehaviour {

    // 변수를 선언합니다.
    public Rigidbody Bullet;
    public float BulletSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    // 마우스 왼쪽 버튼을 눌렀을 경우
        if (Input.GetMouseButtonDown(0))
        {
            // Rigidbody 객체를 복제합니다.
            Rigidbody cb = (Rigidbody)Instantiate(Bullet, transform.position, transform.rotation);

            // Velocity 값을 변경해서 발사 효과를 줍니다.
            cb.velocity = transform.TransformDirection(new Vector3(0, 0, BulletSpeed));

            // 소리를 재상합니다.
            AudioSource.PlayClipAtPoint(GetComponent<AudioSource>().clip, transform.position);
        }
	}
}
