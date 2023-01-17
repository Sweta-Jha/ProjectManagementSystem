using ProjectManagementSystem;
using System.Security.AccessControl;

public class Program
{
    public static void Main(string[] args)
    {
        Project projectobj1 = new HealthCareProject();
        projectobj1.display(02);
        projectobj1.display("Project Management system");
        projectobj1.ProjectDetails();
        projectobj1.ProjectInfo();
        projectobj1.projectId = 02;
        WebDevelopment projectObj2 = new WebDevelopment();

    }
}
public abstract class Project
{
    //Data members
    private int ProjectID;
    public int projectId
    {
        get { return ProjectID; }
        // set { projectId = value; }
        set
        { 
            ProjectID = value;
        }
    }

    private int ManagerID;
    public int managerId
    {
        get { return ManagerID; }
        set { ManagerID = value; }
    }
    private int CategoryID;
    public int categoryId
    {
        get { return CategoryID; }
        set { CategoryID = value; }
    }
    private string ProjectName;
    public string projectName
    {
        get { return ProjectName; }
        set { ProjectName = value; }
    }
    private string ProjectDescription;
    public string projectDescription
    {
        get { return ProjectDescription; }
        set { ProjectDescription = value; }
    }
    private DateTime StartDate;
    public DateTime startDate
    {
        get { return StartDate; }
        set { StartDate = value; }
    }
    private DateTime ExpectedEndDate;
    public DateTime expectedEndDate
    {
        get { return expectedEndDate; }
        set { expectedEndDate = value; }
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
   internal void display(string ProjectName)
    {
        projectName= ProjectName;
        Console.WriteLine("Project name:" + projectName);
    }
   internal void display(int projectId)
    {
        ProjectID= projectId;
        Console.WriteLine("project Id:" + ProjectID);
    }
}
class HealthCareProject : Project, IProject
{

    public override void ProjectDetails()
    {
        Console.WriteLine("This is Healthcare Project");
    }

    void IProject.GetProjectCategory()
    {
        Console.WriteLine("Project category");
    }

    void IProject.GetProjectDescription()
    {
        Console.WriteLine("Project description");
    }

    void IProject.GetProjectMembersDetail()
    {
        Console.WriteLine("Project members details");
    }

    void IProject.GetProjectStatus()
    {
        Console.WriteLine("Project status");
    }
}
class WebDevelopment : IProject
{
    void IProject.GetProjectCategory()
    {
        Console.WriteLine("Project category");
    }

    void IProject.GetProjectDescription()
    {
        Console.WriteLine("Project description");
    }

    void IProject.GetProjectMembersDetail()
    {
        Console.WriteLine("Project members details");
    }

    void IProject.GetProjectStatus()
    {
        Console.WriteLine("Project status");
    }
}

