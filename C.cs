using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] resumes = new string[]
            {
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis accumsan auctor metus, vitae commodo nulla tincidunt ac.",
                "Maecenas vitae quam faucibus, finibus enim in, aliquet purus. Aliquam erat volutpat.",
                "Curabitur bibendum lacus ac nibh pulvinar lacinia. Sed scelerisque dui vel ligula laoreet vestibulum.",
                "Proin pharetra augue non est tincidunt, quis rutrum sapien varius. In varius mi ac nisi malesuada, at ultrices lorem molestie.",
                // ... add more resumes here ...
            };

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string[][] skills = new string[resumes.Length][];
            Parallel.For(0, resumes.Length, i =>
            {
                skills[i] = FindSkillsinResume(resumes[i]);
            });

            stopwatch.Stop();
            Console.WriteLine($"Total time taken: {stopwatch.ElapsedMilliseconds}ms");

            // Output skills
            for (int i = 0; i < skills.Length; i++)
            {
                Console.WriteLine($"Resumes {i + 1} skills: {string.Join(", ", skills[i])}");
            }
        }

        static string[] FindSkillsinResume(string resume)
        {
            // This is a dummy implementation of FindSkillsinResume function.
            // Replace it with your own implementation that takes 200ms to find skills in resume.

            // Sleep for 200ms to simulate the time it takes to find skills in the resume.
            System.Threading.Thread.Sleep(200);

            // Return a random set of skills for demonstration purposes.
            string[] allSkills = new string[]
            {
                "C#", "JavaScript", "Python", "SQL", "React", "Angular", "HTML", "CSS", "Java", "PHP"
            };
            Random random = new Random();
            return allSkills.OrderBy(x => random.Next()).Take(3).ToArray();
        }
    }
}
// Implementation of how to improve the performance of the FindSkillsinResume function using multi-threading in a .NET Core Console App
// In this implementation, we're using Parallel.For to run FindSkillsinResume function in parallel for each resume. Parallel.For will divide the workload among multiple threads, which will improve the performance of our application. Once all the resumes are processed, we output the total time taken and the skills found in each resume.

// You can replace the FindSkillsinResume function with your own implementation that takes 200ms to find skills in a given resume.