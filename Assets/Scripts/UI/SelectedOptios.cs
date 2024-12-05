using UnityEngine;

public class SelectedOptios : MonoBehaviour
{
    
    Animator anim;
    int correctOption=1;
    
    public static bool next=false;

    void Start() {
        anim=gameObject.GetComponent<Animator>();
        next=false;
    }
    public void Enter(){
        anim.SetBool("Enter", true);
    }

    public void Exit(){
        anim.SetBool("Enter",false);
    }

    public void IsCorrect(int n){
        if(correctOption==n){
            this.gameObject.SetActive(false);
            next=true;
        }
        else{
            this.gameObject.SetActive(false);
            LifeStar.Instance.EnableStart();

        }
    }
    
}
