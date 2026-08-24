using TMPro;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class CharacterSelector : MonoBehaviour
{
    public Details details;
    public float chance;
    public float fchance;
    public float character;
    public TextMeshPro chatBox;
    public TextMeshPro Button1;
    public TextMeshPro Button2;
    public TextMeshPro Button3;
    private bool fae;
    private bool walker;
    private float number;
    public int question;
    public bool shot;
    public bool documented;
    public bool released;
    private bool correct;
    public bool decided;

    void Start()
    {
        select();
    }

    public void select()
    {
        number = Random.Range(0f, 100f);
        if (number < chance)
        {
            walker = true;
            fae = false;
        }
        else if (number > chance + fchance)
        {
            fae = true;
            walker = false;
        }
        else
        {
            walker = false;
            fae = false;
        }
    }

    public void option3()
    {
        question = 3;
    }

    public void option2()
    {
        question = 2;
    }

    public void option1()
    {
        question = 1;
    }

    
    public void gun()
    {
        shot = true;
        if (walker == true)
        {
            correct = true;
            decided = true;
        }
        else
        {
            correct = false;
            decided = true;
        }
    }

    public void pencil()
    {
        documented = true;
        if (fae == true)
        {
            correct = true;
            decided = true;
        }
        else
        {
            correct = false;
            decided = true;
        }
    }

    public void release()
    {
        decided = true;
        if (fae == true)
        {
            correct = false;
        }
        else if (walker == true)
        {
            correct = false;
        }
        else
        {
            correct = true;
        }
    }
}
