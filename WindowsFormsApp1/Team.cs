public class Team
{
    string teamName;
    int teamMembersCount;
    string teamURL;

    public Team(string name, string url)
    {
        teamName = name;
        teamURL = url;
        teamMembersCount = 0;
    }

    public Team(string name, string url, int count)
    {
        teamName = name;
        teamURL = url;
        teamMembersCount = count;
    }

    public void setCount (int count)
    {
        teamMembersCount = count; 
    }

    public string getName()
    {
        return teamName;
    }

    public string getUrl()
    {
        return teamURL;
    }
    public int getCount ()
    {
        return teamMembersCount;
    }
    
    
}
    

