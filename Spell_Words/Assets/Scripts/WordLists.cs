using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordLists : MonoBehaviour
{
    //Declares and instantiates the arrays with the words for each spell type.
    public string[] fireBall = new string[10] { "blaze", "heat", "ember", "scorch", "inferno", "pyre", "flare", "flame", "char", "spark" };
    public string[] iceBlast = new string[10] { "ice", "hail", "sleet", "glacial", "frost", "arctic", "cryo", "freeze", "snow", "chill" };
    public string[] rebuild = new string[10] { "reconstruct", "rehabilitate", "reconstitute", "reassemble", "ameliorate", "reinforce", "strengthen", "fortify", "manufacture", "restoration" };

    //Method for retrieving a random string from the fireBall array.
    public string FireWord()
    {       
        int randomIndex = Random.Range(0, fireBall.Length);
        return fireBall[randomIndex];
    }

    //Method for retrieving a random string from the iceBlast array.
    public string IceWord()
    {
        int randomIndex = Random.Range(0, iceBlast.Length);
        return iceBlast[randomIndex];
    }

    //Method for retrieving a random string from the rebuild array.
    public string Rebuild()
    {
        int randomIndex = Random.Range(0, rebuild.Length);
        return rebuild[randomIndex];
    }
}
