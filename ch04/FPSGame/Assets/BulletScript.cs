using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

    // 원본 파티클 객체
    public GameObject OriginSpark;

    // 복제될 파티클 객체
    private GameObject CloneSpark;

    // 파티클을 제어하기 위한 Emitter 객체
    private ParticleEmitter Emitter;

	// Use this for initialization
	void Start () {
        // 객체를 복제합니다.
        CloneSpark = (GameObject)Instantiate(OriginSpark, OriginSpark.transform.position, OriginSpark.transform.rotation);

        // 파티클을 방출하지 않게 만듭니다.
        Emitter = CloneSpark.GetComponent<ParticleEmitter>();
        Emitter.emit = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        // 충돌한 객체의 태그가 "Bullet"일 경우
        if (collision.transform.tag == "Bullet")
        {
            return;
        }

        // 파티클을 생성합니다.
        CloneSpark.transform.position = transform.position;
        Emitter.Emit();

        // 현재 게임 객체를 제거합니다.
        Destroy(transform.gameObject);
    }
}
