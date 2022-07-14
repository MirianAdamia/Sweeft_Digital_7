using Microsoft.EntityFrameworkCore;
using Sweeft_Digital_7.Dbcontext;
using System;
using System.Linq;

namespace Sweeft_Digital_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var results = (from t0 in context.Teachers
                           join t1 in context.TeacherPupils on t0.Id equals t1.TeacherId
                           join t2 in context.Pupils on t1.PupilId equals t2.Id
                           where t2.Name == "გიორგი"
                           select t0).ToList();

                foreach (var result in results)
                {
                    Console.WriteLine($"{result.Id} - {result.Name} {result.LastName} - {result.Subject}");
                }
            }
        }
    }
}
