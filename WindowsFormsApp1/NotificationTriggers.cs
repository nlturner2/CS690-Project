

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
        int TeamDays1;
        int TeamDays2;
        int MembersDays1;
        int MembersDays2;
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
            if (counter > 0)
            {
                Boolean checkTeamCommit = true;
                //update members commit
                foreach (Triggers item in Variables.db.GetTriggers())
                {
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
                if (t.Name == item.TeamName)
                {
                    if (item.Type == "memberCommit")
                        {
                        if (DismissCheckForCommit(item.DismissDate, Variables.SettingsInstance.MembersDays))
                        {
                            if (commitCheck)
                            {
                                item.Active = false;
                                Variables.db.UpdateTriggers(item, false);
                            }
                            else
                            {
                                // databse error, it does not update database even though it function work somewhere else
                                //it can update the date but does not update the status
                                item.Active = true;
                                Variables.db.UpdateTriggers(item, true); 
                            }
                        }
                        else
                        {
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
                    if (DismissCheckForMeeting(itemMeetings.DismissDate))
                    {
                        if (meetingCheck)
                        {
                            Variables.db.UpdateTriggers(itemMeetings, false);
                            //dissmiss notification
                        }
                        else
                        {
                            Variables.db.UpdateTriggers(itemMeetings, true);
                            //more code to make it apper
                        }
                    }
                    else
                    {
                        Variables.db.UpdateTriggers(itemMeetings, false);
                        //dissmiss notification
                    }
                }
            }       
        }

        public void StandardTrigger(Team t, Boolean check)
        {
            foreach (Triggers itemStandard in Variables.db.GetTriggers())
            {
                if (itemStandard.Type == "standard")
                {
                    if (DismissCheckForCommit(itemStandard.DismissDate, Variables.SettingsInstance.MembersDays))
                    {
                        if (check)
                        {
                            Variables.db.UpdateTriggers(itemStandard, true);
                        }
                        else
                        {
                            Variables.db.UpdateTriggers(itemStandard, false);
                        }
                    }
                   
                }
            }
        }
        public void Refresh()
        {
            foreach (Team team in Variables.db.GetAll())
            {
                Boolean commit = CommitDateCheck(team.Url, Variables.SettingsInstance.MembersDays);
                Boolean standardCheck = StandardCheck(team.Url);
                if (!(standardCheck))
                {
                    Boolean meetings = MeetingDateCheck(team.Url, Variables.SettingsInstance.TeamWeeks);
                    MeetingsTrigger(team, meetings);
                }
                CommitTrigger2(team, commit);
                TeamCommitTrigger(team);
                StandardTrigger(team, standardCheck);
            }
        }
        /// <summary>
        /// to check if the team committed in the past #numberOfDays. 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="numberOfDays"></param>
        /// <returns></returns> return true if they did, return false if they didn't, throw .
        ///
        public Boolean CommitDateCheck (string url, int numberOfDays)         {              Boolean acceptable = true;             List<DateTime> dates = new List<DateTime>();             List<string> datesText = Variables.parseInstance.LoadGithubDataAsync(Variables.parseInstance.URLFactory(url, "commit"), "date");             foreach (var date in datesText)             {                 DateTime dateTime = DateTime.Parse(date);                 dates.Add(dateTime);             }             dates.Sort();             DateTime today = DateTime.Today;             DateTime daysAgo = today.AddDays(-numberOfDays);             int datesCount = dates.Count;             if (daysAgo > dates[datesCount - 1])             {                 acceptable = false;             }                 return acceptable;         }   
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
        public Boolean MeetingDateCheck (string url, int numberOfWeeks)
        {
            Boolean acceptable = true;
            string meetingfileNameURL = Variables.parseInstance.URLFactory(url, "meetings");
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
                
                    int Location = item.LastIndexOf('.');
                    var revisedItem = item.Remove(Location);
                    if (revisedItem.Contains('_'))
                    {
                        string[] list = revisedItem.Split('_');
                        string startDate = list[0].Replace('-', '/');
                        //string endDate = list[1].Replace('-', '/');
                        DateTime start = DateTime.Parse(startDate);
                        var end = new DateTime(); 
                        end = start.AddDays(7);
                        //DateTime end = DateTime.Parse(endDate);
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
            return acceptable;
        }

        /// <summary>
        /// check if the team's files are following the standard or not based on the these aspects: if they have README.md file, MeetingMinutes folder, Team folder and if meetingFiles have "-" or "_".
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public Boolean StandardCheck(string url)
        {
   
            Boolean flag = false;
            string meetingfileNameURL = Variables.parseInstance.URLFactory(url, "meetings");
            string contentFileNameURL = Variables.parseInstance.URLFactory(url, "contents");
            var Contentlist = Variables.parseInstance.LoadGithubDataAsync(contentFileNameURL, "filename");

            if(!Contentlist.Contains("MeetingMinutes"))
            {
                flag = true;
            }
            else
            {
                string TeamFolderURL = Variables.parseInstance.URLFactory(url, "TeamFolder");
                var list = Variables.parseInstance.LoadGithubDataAsync(TeamFolderURL, "filename");


                if (!list.Contains("Team"))
                {
                    flag = true;
                }
                else
                {

                    foreach (var item in Variables.parseInstance.LoadGithubDataAsync(meetingfileNameURL, "filename"))
                    {

                        if (!(item.Contains('-') && (item.Contains("_"))))
                        {
                            flag = true;
                        }
                        else
                        {
                            if(!item.Contains(".md"))
                            {
                                flag = true;
                            }
                        }

                    }
                }
            }
            
            /*if(!Contentlist.Contains("README.md"))
            {
                flag = true;
            }*/
            
            return flag;
        }
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