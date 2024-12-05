using UnityEngine;

public class LifeStar : MonoBehaviour
{
    [SerializeField] GameObject[] lifeStarts;
    [SerializeField] GameObject[] backGroundItems;
    [SerializeField] GameObject[] activeItems;
    [SerializeField] GameObject loseMenu;
    [SerializeField] GameObject nextActivity;
    [SerializeField] GameObject[] buttons;

    int index=0;
    

    public static LifeStar Instance {get; private set;}

    private void Start() {
        index=0;
        Instance=this;
        
    }

    ///////////   Failed attempts Controller  ////////
    public void EnableStart(){
        lifeStarts[index].SetActive(true);
        index++;
    }

    private void Update() {
        You_Lose();

        ///////Disable buttons Ootions/////
        
        if(SelectedOptios.next){
            nextActivity.SetActive(true);
            buttons=GameObject.FindGameObjectsWithTag("Numbers");
            foreach(GameObject button in buttons){
                button.SetActive(false);
            }
        }
    }

    void You_Lose(){
        if(index==3){
            foreach(GameObject items in backGroundItems){
                items.SetActive(false);
            }
            activeItems=GameObject.FindGameObjectsWithTag("Active_Items");
            foreach(GameObject items in activeItems){
                items.SetActive(false);
            }
            loseMenu.SetActive(true);
        }
    }
}
