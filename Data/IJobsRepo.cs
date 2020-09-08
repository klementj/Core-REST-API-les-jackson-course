using System.Collections.Generic;
using Core_REST_API_les_jackson_course.Models;

namespace Core_REST_API_les_jackson_course.Data
{
    public interface IJobsRepo
    {
        IEnumerable<Job> GetAllJobs();
        Job GetJobById(int id);
    }
}