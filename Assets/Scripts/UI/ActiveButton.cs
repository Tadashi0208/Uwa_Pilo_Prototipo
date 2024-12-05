using UnityEngine;
using UnityEngine.UI;

public class ActiveButton : MonoBehaviour
{
    [SerializeField] GameObject button;
    private void OnTriggerEnter(Collider other) {
        if(other.transform.tag=="Player"){
            button.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) {
        button.SetActive(false);
    }
}
