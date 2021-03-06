using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignClasses
{
    public interface IInstructorService: IPersonService
    {
        IDepartmentService GetDepartment();
        bool IsHead();
        uint GetYearsOfExperience();
    }
}
