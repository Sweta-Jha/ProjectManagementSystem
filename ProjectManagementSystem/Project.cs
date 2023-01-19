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
    private int _projectID;
    public int ProjectID
    {
        get { return _projectID; }
        set { _projectID = value; }
    }

    private int _managerID;
    public int ManagerId
    {
        get { return _managerID; }
        set { _managerID = value; }
    }
    private string _categoryName;
    public string CategoryName
    {
        get { return _categoryName; }
        set { _categoryName = value; }
    }
    private string _projectName;
    public string ProjectName
    {
        get { return _projectName; }
        set { _projectName = value; }
    }
    private string _projectDescription;
    public string ProjectDescription
    {
        get { return _projectDescription; }
        set { _projectDescription = value; }
    }
    private ProjectMembers _projectMember;
    public ProjectMembers ProjectMember
    {
        get { return _projectMember; }
        set { _projectMember = value; }
    }
    private DateTime _startDate;
    public DateTime StartDate
    {
        get { return _startDate; }
        set { _startDate = value; }
    }
    private DateTime _expectedEndDate;
    public DateTime ExpectedEndDate
    {
        get { return _expectedEndDate; }
        set { _expectedEndDate = value; }
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



