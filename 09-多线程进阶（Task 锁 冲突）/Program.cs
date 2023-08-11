using _09_多线程进阶_Task_锁_冲突_;


Test test = new Test();

#region 任务（Task）
//也是把线程放在线程池里面,所以也需要Main线程休息才看的出来结果

//启动方法一
/*
TaskFactory taskFactory = new TaskFactory();
Task task = taskFactory.StartNew(test.Fun);
*/

//启动方法二
/*
Task task = new Task(test.Fun);
task.Start();
*/

//连续任务
/*
Task task1 = new Task(test.Download);
Task task2 = task1.ContinueWith(test.Alert);

task1.Start();
*/
#endregion

Thread.Sleep(5000);