using UnityEngine;

public class Camerascript : MonoBehaviour
    {

    public GameObject Jhon;
        void Update()
    {
        Vector3 position = transform.position;
        position.x = Jhon.transform.position.x;
        transform.position = position;
    }


}
