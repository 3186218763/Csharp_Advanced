namespace _07_线程基础;

/// <summary>
/// 自定义多线程的封装
/// </summary>
public class DownLoadTool
{
    public string URL { get; private set; }
    public string Message { get; private set; }

    public DownLoadTool(string url, string message)
    {
        this.URL = url;
        this.Message = message;
    }

    public void DownLoad()
    {
        Console.WriteLine($"从{URL}下载进行中");
    }
}