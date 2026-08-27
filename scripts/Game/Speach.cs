using System;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class Speach : MonoBehaviour
{
    public CharacterSelector CharSel;
    public Details details;
    public int character;
    public int speachSelected;
    public TextMeshProUGUI chatBox;
    public TextMeshProUGUI button1;
    public TextMeshProUGUI button2;
    public TextMeshProUGUI button3;
    public bool gameOver;
    public int button;

    public string[] speaches1 =
    {
        "Hello, may I have your name?", "Hi there, I am here for my interview.", "Hi, How are you?", "What's up?",
        "I was told I need to come in here.", "Hey there, I'm kind of busy, can we make this quick",
        "This is all stupid, Skinwalkers aren't real, neither are Fae.", "Hello, what do you need.",
        "I'm back. Oh, are you new?", "Those skinwalkers are terrifying, thank you for this.",
        "I just want to go home.", "What is a human truly, why should those who hide be removed?"
    };

    public string[] speaches2 =
    {
        "Hi again, uuhhh, I didn't get your name last time", "Hey, I'm back for another interview",
        "Hello, how are you?", "What's happening with you?", "I was told I need to come back.",
        "I don't have much time, hurry up.",
        "Ok, I have seen them, I believe you now.", "Again,yay!", "Hey newbie, how ya goin'",
        "Thank you for your service.", "Can I leave yet?", "What is a being of tricks if not one of simple logic?"
    };

    public string[] speaches3 =
    {
        "Hi again, may I have your name?", "Interview day, my favourite part of the week.", "How are you going?",
        "What's Up?", "I was told that this is very frequent now.", "I have places to be, hurry up.",
        "Thank you, they keep getting in.",
        "Again!", "Hey there, do you have time after your shift?", "Thank you again.", "Please, just let me leave.",
        "Why should one have to repeat a test, why not monitor activity?"
    };

    public string[] button1Text =
    {
        "What are you, a Fae?", "Welcome, may I request your name?", "I'm ok, now, are you a skinwalker?",
        "The ceiling, why did you kill those people?", "Yes, you do, where do you live?",
        "Just for you I'll make this long, have you ever seen a skinwalker?",
        "They are real. Please, do you know any Fae?", "Answers, did you take someone's skin?",
        "Yes, I'm new. Who are you?", "No problem, where have you seen them?",
        "You can after. Have you ever met a Fae?", "They can be dangerous to others. Have you ever seen one?"
    };

    public string[] button2Text =
    {
        "No, do you know any Fae?", "Welcome, may I request your occupation?", "I'm ok, now, are you a Fae?",
        "Space, have you ever seen a skinwalker?", "Yes, you do. Do you live?",
        "Just for you I'll make this long, have you ever seen a Fae?",
        "They are truly dangerous. Please, do you know anyone who has been replaced?",
        "Answers, did you take someone's Name?", "Yes, I'm new. I don't have time. Do you want my skin?",
        "No problem, have you ever been attacked by one?",
        "You can after. How many encounters have you had with skinwalkers?",
        "They must be removed before causing harm. What do you know about them?"
    };

    public string[] button3Text =
    {
        "No, have you seen a skinwalker?", "Welcome, may I request your address?",
        "I'm ok, now, have you ever been attacked by a Fae?", "Not much, has anyone ever asked to have your name?",
        "Yes, you do. Do you kill?", "We can be done quickly, are any of your relatives Fae?",
        "Conspiracy theories! why would they be fake?", "Information. Are you real?",
        "Yes, I'm new. I am not interested. Do you want my skin?", "No problem, have you ever seen a Fae?",
        "You can after. Who might you be?", "They are dangerous creature who shouldn't exist. Are you defending them?"
    }; 
    
    private string[] Response1 = { "No, I'm not a Fae, I just want to know to whom I speak.", "Thank you, my name is John.", "No, I'm just an average guy." , "Way to kill the fun, I never harmed anyone.", 
        "That is personal, I live on Main Street.", "Rude, I have never seen one.", "Real-- maybe. Though I know no Fae.", "That is not how you start a conversation. No, i have no one else's skin.", "Oh. I feel offended that I am not recognised! You know who I am!", "My Neighbour's house, I think there were 3.", "No, I need to go.", "Can you truly 'see' something, or just believe you see, is this real?"};
    private string[] Response2 = { "Never seen one. I know some people who were tricked though.", "Of course, I'm a builder.", "No, I don't rely on tricks." , "I saw one from a distance at one time.", 
        "Yes I live, that is a strange question.", "Dude, I have things to do. No I haven't seen a Fae.", "Ok, they can be dangerous. I know no-one that has been replaced.", "I have only my own name.", "No, my skin is perfect, it should be enough for you to get time.", "I haven't, but I have seen what they do, it was terrifying!", "Not one, I have things to do.", "I know of them all that I know, and that may be all that humanity knows, or may be a small part."};
    private string[] Response3 = { "No. I probably wouldn't survive an encounter.", "No, that is personal.", "No never, I didn't know Fae were hostile." , "People have asked to know it, not to have it.", 
        "No, I respect other's desire to live.", "I'm not a Fae, so neither are they.", "The government wants to control our lives!", "Do I look real? Of course I'm real!", "Ok newbie, why would one as perfect as I want your skin?", "No, I have only seen the walkers.", "I am but a lowly office clerk, I have a meeting in 5 minutes.", "Defence, no; question, yes, why should they be eliminated completely, they just live as is natural to them."};
    public string[] FaeSpeach = {"Hello, may I have your name and contact details?", "Hi there. would you like to take part in my new belief?", 
        "Hello, may I have the purpose for being here?", "What's up? I will bet everything I own you get this wrong."};
    public string[] walkerSpeach = { "Hello, do you human today?", "Hi there, I am here for my talking.", "Hi, are you good?", "What is above?", "I was told they need to come in here.", "Hey there, we're kind of busy, can we make this quick",
        "This is all stupid, Skinwalkers aren't real, even if they were, you think I am one?", "Hello, what dost thou need.", "I'm back. Oh, am I new?", "Those skinwalkers aren't that bad, this is unnecessary.", "I just want to go home and learn my life.", "What is a skinwalker truly, why should those who hide be removed?" };
    public string[] FaeResponse = {"Me? I have never been in the same room as a Fae or Skinwalker! Much less am I one. I may need to report your assumptions, may I have your name?", "Sure, but first may I have yours?", "That's good. No, I have seen them but never interacted, much less been, one.", "I have not. I am legally bound to tell the truth and only the truth I tell."};
    public string[] walkerResponse = {"No, I am a normal person, I have never met another kind.", "Those details are classified, I can't share them.", "That's good, no, I'm not even sure they exist", "I didn't do anything, and none did any to me.", "I live a ordinary life, at my house most time, I lack the time to kill", "I have met no Fae, nor have I met skinwalkers.", 
        "I still think it's preposterous to believe in beings that steal our skin.", "I am real, I stand before you, as myself, under my name.", "I am an ordinary human, you have my details there.", "I have never seen either of these dangerous creatures", "I am me, I have never seen a Fae or Skinwalker.", "Are they inherently dangerous, could it simply be that you killing them has made them mad?" };

    private void FixedUpdate()
    {
        if (chatBox.text != Response1[character] && chatBox.text != Response2[character] &&
            chatBox.text != Response3[character] && chatBox.text != speaches1[character] && 
            chatBox.text != speaches2[character] && chatBox.text != speaches3[character] &&
            chatBox.text != FaeSpeach[character] && chatBox.text != FaeResponse[character] &&
            chatBox.text != walkerResponse[character] && chatBox.text != walkerSpeach[character]
            )
        {
            if (CharSel.fae)
            {
                if (button == 0)
                {
                    chatBox.text = FaeSpeach[character];
                }
                else if (button != 0)
                {
                    chatBox.text = FaeResponse[character];
                }
            }
            else if (CharSel.walker)
            {
                if (button == 0)
                {
                    chatBox.text = walkerSpeach[character];
                }
                else if (button != 0)
                {
                    chatBox.text = walkerResponse[character];
                }
            }
            else if (button == 0)
            {
                if (speachSelected == 1)
                {
                    chatBox.text = speaches1[character];
                }
                else if (speachSelected == 2)
                {
                    chatBox.text = speaches2[character];
                }
                else if (speachSelected == 3)
                {
                    chatBox.text = speaches3[character];
                }
            }
            else if (button == 1)
            {
                chatBox.text = Response1[character];
            }
            else if (button == 2)
            {
                chatBox.text = Response2[character];
            }
            else if (button == 3)
            {
                chatBox.text = Response3[character];
            }
        } 
    }
    
    public void speak()
    {
        character = CharSel.character;
        button = 0;
        speachSelected = Random.Range(1, 3);
        if (details.day == 1)
        {
            chatBox.text = speaches1[character];
        }
        else if (details.day == 2)
        {
            chatBox.text = speaches1[character];
        }
        else if (CharSel.fae)
        {
            chatBox.text = FaeSpeach[character];
        }
        else if (CharSel.walker)
        {
            chatBox.text = walkerSpeach[character];
        }
        else if (speachSelected == 1)
        {
            chatBox.text = speaches1[character];
        }
        else if (speachSelected == 2)
        {
            chatBox.text = speaches2[character];
        }
        else if (speachSelected == 3)
        {
            chatBox.text = speaches3[character];
        }
        
        button1.text = button1Text[character];
        button2.text = button2Text[character];
        button3.text = button3Text[character];
    }

    public void button1Pressed()
    {
        if (button == 0)
        {
            if (!CharSel.fae && !CharSel.walker)
            {
                chatBox.text = Response1[character];
            }
            else if (CharSel.fae && !CharSel.walker)
            {
                chatBox.text = FaeResponse[character];
            }
            else if (CharSel.walker && !CharSel.fae)
            {
                chatBox.text = walkerResponse[character];
            }

            button = 1;
        }
    }

    public void button2Pressed()
    {
        if (button == 0)
        {
            if (!CharSel.fae && !CharSel.walker)
            {
                chatBox.text = Response2[character];
            }
            else if (CharSel.fae && !CharSel.walker)
            {
                chatBox.text = FaeResponse[character];
            }
            else if (CharSel.walker && !CharSel.fae)
            {
                chatBox.text = walkerResponse[character];
            }

            button = 2;
        }
    }

    public void button3Pressed()
    {
        if (button == 0)
        {
            if (!CharSel.fae && !CharSel.walker)
            {
                chatBox.text = Response3[character];
            }
            else if (CharSel.fae && !CharSel.walker)
            {
                chatBox.text = FaeResponse[character];
            }
            else if (CharSel.walker && !CharSel.fae)
            {
                chatBox.text = walkerResponse[character];
            }

        button = 3;
        }
    }

    public void gameWon()
    {
        chatBox.text = "Congratulations! You successfully found and removed all skinwalkers!";
        gameOver = true;
    }

    public void gameLost()
    {
        chatBox.text =
            "An individual was misidentified, this has caused a major loss of identity, life, or both. You shall be severely disciplined.";
        gameOver = true;
    }
}
