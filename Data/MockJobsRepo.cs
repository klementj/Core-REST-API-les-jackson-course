using System.Collections.Generic;
using Core_REST_API_les_jackson_course.Models;

namespace Core_REST_API_les_jackson_course.Data
{
    public class MockJobsRepo : IJobsRepo
    {
        public IEnumerable<Job> GetAllJobs()
        {
            var jobs = new List<Job>
            {
                new Job{Id=0, Name="Mock Developer", Description="This is a Mock Job description from the MockJobsRepo.cs", Email="john@doe.com"},
                new Job{Id=1, Name="Mock front-end", Description="This is a Mock Job description from the MockJobsRepo.cs", Email="john@doe.com"},
                new Job{Id=2, Name="Mock back", Description="This is a Mock Job description from the MockJobsRepo.cs", Email="john@doe.com"},
            };

            return jobs;
        }

        public Job GetJobById(int id)
        {
            return new Job{Id=0, Name="Mock Developer", Description="This is a Mock Job description from the MockJobsRepo.cs", Email="john@doe.com"};
        }
    }
}