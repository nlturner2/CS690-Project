

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class NotificationTriggers
    {

        private int TeamDays1 = 7;
        private int TeamDays2 = 14;
        private int MembersDays1 = 7;
        private int MembersDays2 = 14;
        public Variables Callingform { get; set; }

        public NotificationTriggers()
        {

        }


        
        public void TeamCommitTrigger(Team t)
        {
            //making sure team have at least one memmber
            int counter =0;
            foreach(TeamMembers members in Variables.db.GetMembers())
            {
                if (members.TeamName == t.Name)
                {
                    counter++;
                }
            }
            //MessageBox.Show("Counter is " + counter.ToString());

            if (counter > 0)
            {
                Boolean checkTeamCommit = true;
                //update members commit
                foreach (Triggers item in Variables.db.GetTriggers())
                {
                    //MessageBox.Show("1");
                    if (t.Name == item.TeamName && item.Type == "memberCommit")
                    {
                        if(item.Active == false)
                        {
                            checkTeamCommit = checkTeamCommit && false;
                        }     
                        else if (item.Active == true)
                        {
                            checkTeamCommit = checkTeamCommit && true;
                        }
                    }
                }
                
                //update team commit
                foreach (Triggers itemTeamCommit in Variables.db.GetTriggers())
                {
                    
                    if(t.Name == itemTeamCommit.TeamName && (itemTeamCommit.Type == "teamCommit"))
                    {
                        //itemTeamCommit.Active = checkTeamCommit;
                        Variables.db.UpdateTriggers(itemTeamCommit, checkTeamCommit);
                    }
                   
                }
                
            }

        }

        public void CommitTrigger2(Team t, Boolean commitCheck)
        {
            //update members commit
            foreach (Triggers item in Variables.db.GetTriggers())
                {
                    //MessageBox.Show("1");
                    if (t.Name == item.TeamName)
                    {
                        //MessageBox.Show("2");
                        if (item.Type == "memberCommit")
                        {
                            //MessageBox.Show("3");
                            if (DismissCheckForCommit(item.DismissDate, TeamDays1))
                            {
                                //MessageBox.Show("4");
                                if (commitCheck)
                                {
                                    //MessageBox.Show("5");
                                    item.Active = false;
                                    
                                    Variables.db.UpdateTriggers(item, false);
                                }
                                else
                                {
                                    // databse error, it does not update database even though it function work somewhere else
                                    //it can update the date but does not update the status
                                    //MessageBox.Show("6");
                                    item.Active = true;
                                    
                                    Variables.db.UpdateTriggers(item, true);
                                    
                                }
                            }
                            else
                            {
                                //MessageBox.Show("7");
                                item.Active = false;
                              
                                Variables.db.UpdateTriggers(item, false);
                           }

                        }
                    }


                }
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <param name="meetingCheck"></param>
        public void MeetingsTrigger(Team t, Boolean meetingCheck)
        {
            foreach (Triggers itemMeetings in Variables.db.GetTriggers())
            {
                if (itemMeetings.Type == "teamMeeting")
                {
                    //MessageBox.Show("1");
                    if (DismissCheckForMeeting(itemMeetings.DismissDate))
                    //if(true)
                    //if (DismissCheckForCommit(itemMeetings.DismissDate, TeamDays1))
                    {
                        //MessageBox.Show("2");
                        if (meetingCheck)
                        {
                            //MessageBox.Show("3");
                            //item.Active = false;
                            Variables.db.UpdateTriggers(itemMeetings, false);
                            //dissmiss notification
                        }
                        else
                        {
                            //MessageBox.Show("4");
                            //itemMeetings.Active = true;
                            Variables.db.UpdateTriggers(itemMeetings, true);
                            //itemMeetings.DismissDate = DateTime.Today;
                            //Variables.db.UpdateTriggerDismiss(itemMeetings, DateTime.Today);
                            //more code to make it apper
                        }
                    }
                    else
                    {
                        //MessageBox.Show("5");
                        //itemMeetings.Active = false;
                        Variables.db.UpdateTriggers(itemMeetings, false);
                        //dissmiss notification
                    }
                }
            }
                
        }
        
        public void Refresh()
        {
            foreach (Team team in Variables.db.GetAll())
            {
                Boolean commit = CommitDateCheck(team.Url, Variables.SettingsInstance.MembersDays);
                Boolean meetings = MeetingDateCheck(team.Url);
                //MessageBox.Show(meetings.ToString());

                CommitTrigger2(team, commit);
                MeetingsTrigger(team, meetings);
                TeamCommitTrigger(team);

            }
        }
        /*
        public void TriggerCheck()
        {
            // tracking progress
            //string s = "";
            foreach (Triggers item in Variables.db.GetTriggers())
            {
                //s += "team: " + item.TeamName.ToString() + " member: " + item.MemberName.ToString() + " notification: " + item.Active.ToString() + " date:" + item.DismissDate.ToString()+ "\n  \n";
                if (item.Type == "memberCommit")
                {
                    //s +="input1:"+ item.DismissDate + " input2:" + TeamDays1 +" result:"+ DismissCheckForCommit(item.DismissDate, TeamDays1) + "\n  \n";
                    if (DismissCheckForCommit(item.DismissDate, TeamDays1))
                    {
                        //s += "input1:" + item.Url + " input2:" + MembersDays1 + " result:" + CommitDateCheck(item.Url, MembersDays1) + "\n  \n";
                        if (CommitDateCheck(item.Url, MembersDays1))
                        {
                            item.Active = false;
                            Variables.db.UpdateTriggers(item, false);
                            //dissmiss notification
                            //s += "if result: true and data should be false"+ " notification: " + item.Active.ToString() + " date:" + item.DismissDate.ToString() + "\n  \n";
                        }
                        else
                        {
                            item.Active = true;
                            Variables.db.UpdateTriggers(item, true);
                            item.DismissDate = DateTime.Today;
                            //Variables.db.UpdateTriggerDismiss(item, DateTime.Today);
                            //more code to make it apper
                            //s += "if result: false and data should be true and date should be todays" + " notification: " + item.Active.ToString() + " date:" + item.DismissDate.ToString() + "\n  \n";
                        }
                    }
                    else
                    {
                        item.Active = false;
                        Variables.db.UpdateTriggers(item, false);
                        //dissmiss notification
                        //s += "dismiss if result: false and data should be false" + " notification: " + item.Active.ToString() + " date:" + item.DismissDate.ToString() + "\n \n";
                    }

                }
                if (item.Type == "teamCommit")
                {
                    Boolean status = true;
                    int counter = 0;
                    foreach (Triggers item2 in Variables.db.GetTriggers())
                    {
                        
                        string team = item.TeamName;
                        if (item.Type == "memberCommit" && team == item.TeamName)
                        {
                            status = item.Active && status;
                            counter++;
                        }
                        
                    }
                    if (counter > 0)
                    {
                        item.Active = status;
                        Variables.db.UpdateTriggers(item, status);
                    }
                    else
                    {
                        item.Active = false;
                        Variables.db.UpdateTriggers(item, false);
                    }
                    
                }
                if (item.Type == "teamMeeting")
                {
                    // need to replace this line with the new function
                    if (DismissCheckForMeeting(item.DismissDate))
                    //if (false)
                    {
                        //ths function has an error
                        if (MeetingDateCheck(item.Url))
                        {
                            item.Active = false;
                            Variables.db.UpdateTriggers(item, false);
                            //dissmiss notification
                        }
                        else
                        {
                            item.Active = true;
                            Variables.db.UpdateTriggers(item, true);
                            item.DismissDate = DateTime.Today;
                            Variables.db.UpdateTriggerDismiss(item, DateTime.Today);
                            //more code to make it apper
                        }
                    }
                    else
                    {
                        item.Active = false;
                        Variables.db.UpdateTriggers(item, false);
                        //dissmiss notification
                    }
                }
            }
            //return s;
        }
        */

        /// <summary>
        /// to check if the team committed in the past #numberOfDays. 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="numberOfDays"></param>
        /// <returns></returns> return true if they did, return false if they didn't.
        ///

        public Boolean CommitDateCheck (string url, int numberOfDays)         {              Boolean acceptable = true;             List<DateTime> dates = new List<DateTime>();             List<string> datesText = Variables.parseInstance.LoadGithubDataAsync(Variables.parseInstance.URLFactory(url, "commit"), "date");             foreach (var date in datesText)             {                 DateTime dateTime = DateTime.Parse(date);                 dates.Add(dateTime);             }             dates.Sort();             DateTime today = DateTime.Today;             DateTime daysAgo = today.AddDays(-numberOfDays);             int datesCount = dates.Count;             //acceptable = DateTime.Compare(daysAgo, dates[datesCount - 1]);             if (daysAgo > dates[datesCount - 1])             {                 acceptable = false;             }                  return acceptable;         }   

        /// <summary>
        /// to check if the commit notification should shown or not. in the $numberOfDays, after the user dismiss the notification, the notification should shown up again.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="numberOfDays"></param>
        /// <returns></returns>if it returns true, that means the notification should shown up, otherwise teh notification should not shown.
        public Boolean DismissCheckForCommit(DateTime date, int numberOfDays)
        {
            Boolean dismiss = false;
            DateTime today = DateTime.Today;
            date = date.AddDays(+numberOfDays);
            if (today > date)
            {
                dismiss = true;
            }

            return dismiss;
        }

        /// <summary>
        /// get the date when the notification was dismissed, and calculate the date of that next Monday, check if today is the next Monday, 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>if it returns true, the notification should shown up, false means not shown 
        public Boolean DismissCheckForMeeting(DateTime DismissDate)
        {
            Boolean notification = false;
            DayOfWeek weekStart = DayOfWeek.Monday;
            DateTime today = DateTime.Today;
            while (DismissDate.DayOfWeek != weekStart)
                DismissDate = DismissDate.AddDays(1);

            DateTime nextWeekStart = DismissDate.AddDays(1);
            //DateTime nextWeekEnd = startingDate.AddDays(7);

            if(!(today<nextWeekStart))
            {
                notification = true;
            }

            return notification;
        }
        /// <summary>
        /// to check if the team has a meeting file in the previous week
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>if the return value is false, it means the team didn't meet last week, otherwise, it's true. 
        public Boolean MeetingDateCheck (string url)
        {
            //int index = 0;
            Boolean acceptable = true;
            string meetingfileNameURL = Variables.parseInstance.URLFactory(url, "meetings");
            //string meetingMinutesURL = Variables.parseInstance.meetingFileURL(url, Variables.parseInstance.LoadGithubDataAsync(meetingfileNameURL, "filename"));
            List<string> filename = new List<string>();


            DayOfWeek weekStart = DayOfWeek.Monday;
            DateTime startingDate = DateTime.Today;
            while (startingDate.DayOfWeek != weekStart)
                startingDate = startingDate.AddDays(-1);

            DateTime previousWeekStart = startingDate.AddDays(-7);
            DateTime previousWeekEnd = startingDate.AddDays(-1);

            foreach (var item in Variables.parseInstance.LoadGithubDataAsync(meetingfileNameURL, "filename"))
            {
                filename.Add(item);
            }

            //only check the last 
            foreach (var item in filename)
            {
                try
                {
                    int Location = item.LastIndexOf('.');
                    var revisedItem = item.Remove(Location);
                    if (revisedItem.Contains('_'))
                    {
                        string[] list = revisedItem.Split('_');
                        string startDate = list[0].Replace('-', '/');
                        string endDate = list[1].Replace('-', '/');
                        DateTime start = DateTime.Parse(startDate);
                        DateTime end = DateTime.Parse(endDate);

                        if (previousWeekStart > end)
                        {
                            acceptable = false;
                        }
                    }

                    if (revisedItem.Contains('-') && !(revisedItem.Contains("_")))
                    {
                        string startDate = revisedItem.Replace('-', '/');
                        string endDate = revisedItem.Replace('-', '/');
                        DateTime start = DateTime.Parse(startDate);
                        DateTime end = DateTime.Parse(endDate);
                        if (previousWeekStart > end)
                        {
                            acceptable = false;
                        }


                    }

                }
                catch (Exception)
                {
                    throw new Exception("The MeetingMinutes file is not following the standard format.");
                } 

            }
            
            return acceptable;
        }



        //Variables.SettingsInstance
        public void setTeamDays(string days)
        {
            int count = 0;
            foreach (SettingsData i in Variables.db.GetSettings())
            {
                count++;
            }
            if (count == 0)
            {
                Variables.db.AddSettings(Variables.SettingsInstance);
            }
            
            this.TeamDays1 = Convert.ToInt32(days);
            Variables.SettingsInstance.TeamWeeks = this.TeamDays1;
            Variables.db.UpdateSettings(Variables.SettingsInstance);
            this.TeamDays2 = 2*this.TeamDays1;

        }
        public void setMemberDays(string days)
        {
            int count = 0;
            foreach (SettingsData i in Variables.db.GetSettings())
            {
                count++;
            }
            if (count == 0)
            {
                Variables.db.AddSettings(Variables.SettingsInstance);
            }

            this.MembersDays1 = Convert.ToInt32(days);
            this.MembersDays2 = 2 * this.MembersDays1;
            Variables.SettingsInstance.MembersDays = MembersDays1;
            Variables.db.UpdateSettings(Variables.SettingsInstance);
        }
    }
}
