// 코드 A-1  데이터 저장

public class MainScript : MonoBehaviour {
    void Start() {
        PlayerPrefs.SetInt("is_first_run", 1);
        PlayerPrefs.setString("name", "Rint");
    }
}