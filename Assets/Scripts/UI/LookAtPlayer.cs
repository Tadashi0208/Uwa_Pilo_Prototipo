using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    void Start()
    {
        player=GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation=Quaternion.LookRotation(player.transform.forward);
    }
}
