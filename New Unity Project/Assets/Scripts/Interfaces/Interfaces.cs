﻿public interface IRun
{
    void Run();
    void Run(float f);
}

public interface ITest
{
    void Test();
}

public interface IListen
{
    IRun NewIRunObj { get; set; }
    void Start();
}