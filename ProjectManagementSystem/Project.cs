using ProjectManagementSystem;

public class Program
{
    public static void Main(string[] args)
    {
        Project projectobj1 = new HealthCareProject();
        projectobj1.display(02);
        projectobj1.display("Project Management system");
        projectobj1.ProjectDetails();
        projectobj1.ProjectInfo();
        projectobj1.ProjectID = 02;
        WebDevelopmentProject projectObj2 = new WebDevelopmentProject();
        var projectType = ProjectFactory.GetProject("HealthCareProject");
    }
}
public abstract class Project
{
    //Data members
    private int _ProjectID;
    public int ProjectID
    {
        get { return _ProjectID; }
        set { _ProjectID = value; }
    }

    private int _ManagerID;
    public int ManagerId
    {
        get { return _ManagerID; }
        set { _ManagerID = value; }
    }
    private string _CategoryName;
    public string CategoryName
    {
        get { return _CategoryName; }
        set { _CategoryName = value; }
    }
    private string _ProjectName;
    public string ProjectName
    {
        get { return _ProjectName; }
        set { _ProjectName = value; }
    }
    private string _ProjectDescription;
    public string ProjectDescription
    {
        get { return _ProjectDescription; }
        set { _ProjectDescription = value; }
    }
    private ProjectMembers _ProjectMember;
    public ProjectMembers ProjectMember
    {
        get { return _ProjectMember; }
        set { _ProjectMember = value; }
    }
    private DateTime _StartDate;
    public DateTime StartDate
    {
        get { return _StartDate; }
        set { _StartDate = value; }
    }
    private DateTime _ExpectedEndDate;
    public DateTime ExpectedEndDate
    {
        get { return _ExpectedEndDate; }
        set { _ExpectedEndDate = value; }
    }
    public Project()
    {
        Console.WriteLine("constructor call");
        this.ProjectID = 01;
    }
    public abstract void ProjectDetails();
    // public virtual void ProjectDetail();
    public void ProjectInfo()
    {
        Console.WriteLine("Method of the abstract class");
    }
    public void display(string ProjectName)
    {
        ProjectName = ProjectName;
        Console.WriteLine("Project name:" + ProjectName);
    }
    public void display(int projectId)
    {
        ProjectID = projectId;
        Console.WriteLine("project Id:" + ProjectID);
    }
}



