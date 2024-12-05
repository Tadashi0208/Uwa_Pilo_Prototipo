using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class ChooseElementsRandom : MonoBehaviour
{
    [SerializeField] List<GameObject> animals;
    [SerializeField] List<GameObject> options;
    [SerializeField] GameObject buttons;
    [SerializeField] GameObject Victory;
    [SerializeField] int index;

    
    void Start()
    {
        index=Random.Range(0,animals.Count);
        animals[index].SetActive(true);
        options[index].SetActive(true);
        
    }

    
    void Update()
    {
        if(animals.Count==0){
            Victory.SetActive(true);
        }
    }

    public void Continue(){
        print("hello");
        animals[index].SetActive(false);
        options[index].SetActive(false);
        animals.RemoveAt(index);
        options.RemoveAt(index);
        print(index);
        buttons.SetActive(false);
        SelectedOptios.next=false;
        nextActivity();
        
    }

    public void nextActivity(){
        if(animals.Count!=0){
            index=Random.Range(0,animals.Count);
            animals[index].SetActive(true);
            options[index].SetActive(true);
        }
        
    }

}
