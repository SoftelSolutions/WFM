using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace WFM.Entity
{
    public class WFMContext : DbContext
    {
        public WFMContext(DbContextOptions<WFMContext> options)
            : base(options)
        { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskAsigned> TaskAsigneds { get; set; }
        public DbSet<TaskEDocs> TaskEDocses { get; set; }
        public DbSet<TaskPriority> TaskPriorities { get; set; }
        public DbSet<TaskStatus> TaskStatuses { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<WorkFlow> WorkFlows { get; set; }
        public DbSet<WorkFlowTemplate> WorkFlowTemplates { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}
