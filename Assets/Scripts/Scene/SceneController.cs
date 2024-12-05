using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    
    public void ReStart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Activity_1(){
        SceneManager.LoadScene(1);
    }

    public void Planet(){
        SceneManager.LoadScene(0);
    }


}
