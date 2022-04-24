using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignClasses
{
    public interface IDepartmentService
    {
        IInstructorService GetHead();
        String GetName();
        //List<ICourseService> GetAllCourses();
    }
}
