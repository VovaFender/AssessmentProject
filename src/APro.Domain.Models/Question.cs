using System.Collections.Generic;

public class Question
{
    public string Description { get; set; }

    public Rate Rate { get; set; }

    public IList<Tag> Tags { get; set; }
}