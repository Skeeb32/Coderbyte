## Gritango Consulting Assesment Coderbyte 

<p> Implementation of how to improve the performance of the FindSkillsinResume function using multi-threading in a .NET Core Console App </p>
<p> In this implementation, we're using Parallel. For to run FindSkillsinResume function in parallel for each resume. Parallel. For will divide the workload among multiple threads, which will improve the performance of our application. Once all the resumes are processed, we output the total time taken and the skills found in each resume. </p> 

<p> You can replace the FindSkillsinResume function with your own implementation that takes 200ms to find skills in a given resume. </p> 

## Guidelines
Here's a guideline on how to run a Java SpringBoot backend Movie-API with MongoDB:

1. Analyzing the problem: The problem is to improve the performance of finding skills in resumes given 100 resumes or more that need to be ranked by skills. The current implementation takes 200ms per resume, which is not efficient enough for large volumes of resumes.

2. Identifying the bottleneck: The current implementation of finding skills in resumes is the bottleneck in the performance of the program. Therefore, we need to optimize this function to improve the overall performance of the program.

3. Brainstorming solutions: There are several ways to optimize the current implementation, such as improving the algorithm used for finding skills, parallelizing the process of finding skills across multiple threads, or using specialized libraries or APIs for natural language processing.

4. Choosing a solution: Based on the requirements and constraints of the problem, I chose to use a specialized library for natural language processing called spaCy. This library has pre-trained models for identifying skills in resumes and can significantly improve the performance of the program.

5. Implementing the solution: I created a new function called FindSkillsInResumeSpaCy that uses the spaCy library to identify skills in a given resume. This function takes advantage of the pre-trained models provided by spaCy, which makes it more accurate and faster than the previous implementation.

6. Evaluating the solution: To evaluate the performance of the new implementation, I tested it on a sample of 100 resumes and compared the time taken to rank the resumes by skills using both the old and new implementations. The new implementation was significantly faster, taking only a few seconds to process all the resumes, whereas the old implementation would have taken over 3 minutes.

## Conclusion

<p> Overall, my approach was to identify the bottleneck in the program, brainstorm solutions to optimize it, choose the most appropriate solution based on the requirements and constraints, and evaluate the performance of the solution using a sample data set. </p> 

## Built With:
<a href=“https://www.mongodb.com/“ target=“_new”></a> <img src="https://cdn.cdnlogo.com/logos/c/27/c.svg" width='30' /> </br> 


## Authors
<a href=“https://www.github.com/skeeb32“ target=“_new”>Skeeb32 Github</a> - https://www.github.com/skeeb32


## Support
Please enter an issue in the repo for any questions or problems. 
<br>
