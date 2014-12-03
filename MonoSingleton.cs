using UnityEngine;
using System.Collections;

//A singleton class that to avoid duplicated instances of object on reload
//Just make it your base class and voila

public class MonoSingleton: MonoBehaviour {
    
    static MonoSingleton m_instance;
    
    void Awake() 
    {
        if(m_instance != null) Destroy(gameObject);
        m_instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
