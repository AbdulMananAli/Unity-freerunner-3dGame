using UnityEngine;

public class endTrigger : MonoBehaviour {

    public GameManager GM;
    void OnTriggerEnter()
    {
        GM.completeLevel();
    }

}
