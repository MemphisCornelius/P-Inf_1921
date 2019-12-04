using UnityEngine;

public class Test : MonoBehaviour {
    private Vector3 target;
    public Transform player;
    public float range;
    public GameObject Wall;

    public void PlaceWall() {
        Vector3 difference = player.transform.position - transform.position;
        float rotation = Mathf.Atan2(difference.y, difference.x);
        float x = Mathf.Cos(rotation);
        float y = Mathf.Sin(rotation);
        Vector3 pos = new Vector3(x, y);
        pos = pos * range + transform.position;
        Instantiate(Wall, pos, Quaternion.Euler(0, 0, 0));
    }
}