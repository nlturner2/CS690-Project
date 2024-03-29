﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp1
{
    public class TeamManagement
    {

        public Variables Callingform { get; set; }
        /* To use Functions from this class or variables from this class in other places put 
         * "Variables.TM"
         * in front of them.
         */
        public Team[] teamBook = new Team[1];
        public List<TeamButton> teamButton = new List<TeamButton>();
        public int count = 0;
        public void CreateTeam(HomeDashboard obj, string name, string url)
        {
            // check if either box was empty
            if ((name != "") && (url != ""))
            {
                // replaced "!File.Exists(fileName)" with true
                if (!(Variables.db.CheckTeam(name, url)))
                {
                    // create team
                    Team team = new Team(name, url);
                    Variables.db.AddTeam(team);
                    CreateMembers(name, url);
                    Triggers Trigger1 = new Triggers("teamCommit", name);
                    Variables.db.AddTriggers(Trigger1);
                    Triggers Trigger2 = new Triggers("teamMeeting", name);
                    Variables.db.AddTriggers(Trigger2);
                    Triggers Trigger3 = new Triggers("standard", name);
                    Variables.db.AddTriggers(Trigger3);

                    obj.tableLayoutPanel1.Show();
                    obj.Show();
                    var main = Application.OpenForms.OfType<HomeDashboard>().First();
                    Variables.TMInstance.Write(team);
                }
                else
                {
                    MessageBox.Show("Either Team name or URL already exists");
                }
            }
            else
            {
                MessageBox.Show("Both Team name or URL cannot be empty");
            }


        }

        public void CreateMembers(string teamName, string url)
        {
            IList users = Variables.parseInstance.usernameFilter(Variables.parseInstance.LoadGithubDataAsync(Variables.parseInstance.URLFactory(url, "commit"), "username"));
            string userName = "";
            foreach (string item in users)
            {
                if (userName != item)
                {
                    userName = item;
                    TeamMembers Member = new TeamMembers(item, teamName);
                    Triggers Trigger = new Triggers("memberCommit", teamName,item);
                    Variables.db.AddMember(Member);
                    Variables.db.AddTriggers(Trigger);
                }
            }
        }
        public void removeTeam(string teamName)
        {
            if (Variables.db.CheckTeam(teamName,"any url"))
            {
                //create new smaller temporary array
                Team[] tempTeam = new Team[teamBook.Count() - 1];
                int index = 0;
                foreach (Team i in teamBook)
                {
                    //check if a file is in array when it is delete it.
                    if (i.Name != teamName)
                    {
                        tempTeam[index] = i;
                        index++;
                    }
                    else
                    {
                        Variables.db.DeleteRecord(teamName);
                    }
                }
                //resize teamBook array
                count = tempTeam.Count();
                Array.Resize<Team>(ref teamBook, count);
                //add all the items back to the original array
                index = 0;
                foreach (Team i in tempTeam)
                {
                    teamBook[index] = i;
                    index++;
                }
            }
            else
            {
                MessageBox.Show("This team does not exists");
            }
            
        }
        public void Write(Team obj)
        {
            //add team to array of team objects
            Array.Resize<Team>(ref teamBook, count + 1);
            teamBook[teamBook.Count() - 1] = obj;
            count = teamBook.Count();   
        }
        public void Read()
        {
            int i = 0;
            //create array of files and set teamBook length
            teamBook = new Team[Variables.db.CountTeams()];
            //read in all the file names and the first line of each file which contains the URL
            foreach (var item in Variables.db.GetAll())
            {
                teamBook[i] = item;
                i++; 
            }
            //get the size of teamBook
            count = teamBook.Count();
        }
    }
}
