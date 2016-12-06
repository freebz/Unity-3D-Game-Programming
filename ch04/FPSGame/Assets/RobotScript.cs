using UnityEngine;
using System.Collections;

public class RobotScript : MonoBehaviour {

    public GameObject WayPoint0;
    public GameObject WayPoint1;

    public float MoveSpeed = 3.0f;
    public float RotationSpeed = 2.0f;

    bool IsWayPoint = false;
    bool IsSearch = true;

    public GameObject Target;

    public RocketLauncherScript RocketLauncher;
    public float MaxDelay = 50;
    public float CurrentDelay;

    public int Health = 10;

	// Use this for initialization
	void Start () {
        CurrentDelay = MaxDelay;
        //GetComponent<Animation>().Play("idle");
	}

    // Update is called once per frame
    void Update() {
        if (IsSearch == true)
        {
            // 애니메이션을 재생합니다.
            GetComponent<Animation>().Play("run");
            WayPointMove();
        } else
        {
            Attack();
        }
    }

    void WayPointMove()
    {
        if (IsWayPoint == false)
        {
            // 객체를 회전합니다.
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.
                LookRotation(WayPoint0.transform.position - transform.position), 1);

            // 앞으로 이동합니다.
            transform.Translate(Vector3.forward * Time.smoothDeltaTime * MoveSpeed);

            // 목표 지점에 다다르면 방향을 변경합니다.
            if (Vector3.Distance(transform.position, WayPoint0.transform.position) <= 0.5f)
            {
                IsWayPoint = true;
            }
        } else
        {
            // 객체를 회전합니다.
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.
                LookRotation(WayPoint1.transform.position - transform.position), 1);

            // 앞으로 이동합니다.
            transform.Translate(Vector3.forward * Time.smoothDeltaTime * MoveSpeed);

            // 목표 지점에 다다르면 방향을 변경합니다.
            if (Vector3.Distance(transform.position, WayPoint1.transform.position) <= 0.5f)
            {
                IsWayPoint = false;
            }
        }

        Search();
	}

    void Search()
    {
        float distance = Vector3.Distance(Target.transform.position, transform.position);
        if (distance <= 10)
        {
            IsSearch = false;
        }
    }

    void Attack()
    {
        GetComponent<Animation>().CrossFade("shoot", 0.5f);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.
            LookRotation(Target.transform.position - transform.position), Time.smoothDeltaTime * 5.0f);
        float distance = Vector3.Distance(Target.transform.position, transform.position);
        if (distance > 10)
        {
            IsSearch = true;
        }

        CurrentDelay -= 1.0f;
        if (CurrentDelay <= 0)
        {
            CurrentDelay = MaxDelay;
            RocketLauncher.Fire();
            GetComponent<Animation>().CrossFade("shoot", 0.5f);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Bullet")
        {
            Camera.main.GetComponent<ScoreScript>().CurrentScore += 20;

            Health = Health - 1;
            if (Health < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
