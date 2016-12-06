// 코드 A-2  데이터 불러오기

public class MainScript : MonoBehaviour {
    void Start() {
        if (PlayerPrefs.GetInt("is_first_run" != 1){
            // 게임을 처음 실행하는 경우
            PlayerPrefs.SetInt("is_first_run", 1);
            PlayerPrefs.SetString("name", "Rint");
        } else {
            // 게임을 처음 실행하는 경우가 아닌 경우
            print(PlayerPrefs.GetString("name"));
        }
    }
}