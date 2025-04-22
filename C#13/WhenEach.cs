namespace CSharp13
{
    public class WhenEach
    {
        public async static void Run()
        {
            var tasks = Enumerable.Range(1, 5)
                .Select(async i =>
             {
                 await Task.Delay(new Random().Next(1000, 5000));
                 return $"Task {i} done";
             })
              .ToList();

            //Before
            //we had to manage the tasks queue and maintain their state by removing them from list
            //while (tasks.Count > 0)
            //{
            //    var completedTask = await Task.WhenAny(tasks);
            //    tasks.Remove(completedTask);
            //    Console.WriteLine(await completedTask);
            //}

            // After
            //when each internally uses WhenAny and continuations and returns a task
            //reduces the overhead of managing the state of the tasks
            //thus reduces manual efforts as well as errors
            await foreach (var completedTask in Task.WhenEach(tasks))
                Console.WriteLine(await completedTask);
        }
    }
}
