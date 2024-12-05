using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_to_Activity_1 : MonoBehaviour
{   

    
    void Update()
    {
        if(Input.GetKey(KeyCode.F)){
            SceneManager.LoadScene(1);
        }
    }

}
