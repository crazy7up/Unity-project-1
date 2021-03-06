﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestScript : MonoBehaviour {

    [HideInInspector]
    public UITextHandler textHandling;

    public Text t_questName;
    public Text t_questDescription;
    public Text t_questTask;  //Text to be changed (showing the quest task)

    string questName;
    string questDescription;
    string questTask;

    int killed = 0;         //Amount killed
    int toBeKilled = 2;    //Amount to be killed

    int questReward;

    bool questComplete = false;

    int quest_ID;

    CharacterType mobType;

    ////To Keep Track on which quest is which.
    //[HideInInspector]
   // public int zombieQuestNum;
    //[HideInInspector]
    //public int spiderQuestNum;

    public List<Quest> quests = new List<Quest>();
    public List<string> questListName = new List<string>();
    public List<string> completedQuestsList = new List<string>();

    void Start()
    {
        
        textHandling = GetComponent<UITextHandler>();

        t_questName.gameObject.SetActive(true);
        t_questDescription.gameObject.SetActive(true);
        t_questTask.gameObject.SetActive(true);
    }

    void Update()
    {

    }

    public void QuestUpdate()
    {
        for (int i = 0; i < quests.Count; i++)
        {
            if (quests[i].m_task1 >= quests[i].m_taskMax1)
            quests[i].m_completed = true;

            if (quests[i].m_task1 >= quests[i].m_taskMax1)
                quests[i].m_task1 = quests[i].m_taskMax1; //Make sure a task never goes over taskMax (0/2 -> 1/2 -> 2/2 -X 3/2 -> 2/2)
        }

    }

    //Add Quests Here:

    //questName, questDescription, questTask, task1, taskMax1, questComplete, questReward

    public void ZombieQuest()
    {
        string qName = "Zombie Quest";
        if (!completedQuestsList.Contains(qName) && !questListName.Contains(qName))
        {

            string qDesc = "Help the ranger clear the cemetary from zombies!";
            string qTask = "Zombies Slain: ";
            int task1 = 0;           //e.g. Amount killed
            int taskMax1 = 12;       //e.g. Amount to be killed
            int qReward = 500;
            bool questComplete = false;

            questName = qName;
            questDescription = qDesc;
            questTask = qTask;

            questReward = qReward;

            questListName.Add(qName);

            quest_ID = quests.Count;

            mobType = CharacterType.ZOMBIE;


            quests.Add(new Quest(questName, questDescription, questTask, task1, taskMax1, questComplete, questReward, quest_ID, mobType, CharacterType.RANGER));
            //zombieQuestNum = quests.Count-1;
            textHandling.questBrowser.ClearOptions();
            textHandling.questBrowser.AddOptions(questListName);
        }
    }

    public void SpiderQuest2()
    {
        string qName = "Spider Quest";
        if (!completedQuestsList.Contains(qName) && !questListName.Contains(qName))
        {
            
            string qDesc = "Go kill some spiders and come back to when you are done!";
            string qTask = "Spiders Slain: ";
            int task1 = 0;           //e.g. Amount killed
            int taskMax1 = 8;       //e.g. Amount to be killed
            int qReward = 150;
            bool questComplete = false;

            questName = qName;
            questDescription = qDesc;
            questTask = qTask;

            questReward = qReward;

            questListName.Add(qName);

            quest_ID = quests.Count;
            mobType = CharacterType.SPIDER;

            quests.Add(new Quest(questName, questDescription, questTask, task1, taskMax1, questComplete, questReward, quest_ID, mobType, CharacterType.WIZARD));

            //spiderQuestNum = quests.Count-1;
            textHandling.questBrowser.ClearOptions();
            textHandling.questBrowser.AddOptions(questListName);
        }

    }

    public void ChangeTextColor(int quest)
    {

        t_questName.color = Color.gray;
        t_questDescription.color = Color.gray;
        t_questTask.color = Color.gray;
    }



    //Not Used Code/Functions:

    public void ChangeText(string qName, string qDesc, string qTask)
    {
        t_questName.text = qName;
        t_questDescription.text = qDesc;
        t_questTask.text = qTask;
    }


    void ShittyOldQuest() //Called everytime a spider dies (in the script "ItemDrop"->"DropItem()")
    {
        t_questName.text = "Spider Mess";
        t_questDescription.text = "Spiders. I don't like them. Kill them. You will be rewarded.";

        killed++; //Spider was killed
        if (killed >= toBeKilled)
        {
            killed = toBeKilled;
            t_questTask.color = Color.gray;
            questComplete = true;
        }
        t_questTask.text = killed.ToString() + "/" + toBeKilled.ToString() + " Spiders Slain"; //Update quest text
    }
}