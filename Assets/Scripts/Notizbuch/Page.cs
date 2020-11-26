using UnityEngine;
class Page : MonoBehaviour{
    public int page;
    public bool found = false;
    public GameObject sprite;
		
public void Awake() {
		if(PlayerPrefs.GetInt("Page" + page) == 1) {
			found = true;		
		}
	}
    public void SetFound() {
        found = true;
        PlayerPrefs.SetInt("Page" + page, 1);
    }
}