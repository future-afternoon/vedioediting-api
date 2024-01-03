// Services/VideoEditingTaskService.cs
using System.Collections.Generic;

public class VideoEditingTaskService
{
    public List<VideoEditingTask> GetVideoEditingTasks()
    {
        // Simulate fetching tasks from a database
        return new List<VideoEditingTask>
        {
            new VideoEditingTask { Id = 1, TaskName = "Trimming", Description = "Trimming video clips" },
            new VideoEditingTask { Id = 2, TaskName = "Adding Effects", Description = "Adding special effects to videos" },
            // Add more tasks as needed
        };
    }
}
